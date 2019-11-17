using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net;

namespace Car_Rentals
{
    sealed class clsServiceCalls
    {
        //This code was developed by Dean.Stanleyhunt@live.nmit.ac.nz @ 22/06/2018. As an Assessment Project for SDV701 at NMIT NZ.
        //This software is for educational purposes to display knowledge learned about OOP, Refactoring and Design Patterns .
        public static readonly clsServiceCalls Instance = new clsServiceCalls();

        private clsServiceCalls() { }

        #region Get One or All Vehicles Total Income
        internal async Task<string> GetTotalIncome()
        {
            string lcURI = "http://localhost:60064/api/clsRental/GetTotalIncome/";
            using (HttpClient lcHttpClient = new HttpClient())
            {
                DataTable TblIncome = JsonConvert.DeserializeObject<DataTable>
                (await lcHttpClient.GetStringAsync(lcURI));
                decimal lcTotal = 0;
                foreach (DataRow dr in TblIncome.Rows)
                {
                    if (dr["activity_type"].ToString() == "hire")
                        lcTotal += Convert.ToDecimal(dr["cost"].ToString());
                    else
                        lcTotal -= Convert.ToDecimal(dr["cost"].ToString());
                }
                return lcTotal.ToString();
            }
        }

        internal async Task<string> GetVehicleTotalIncome(string prRego)
        {
            string lcURI = "http://localhost:60064/api/clsRental/GetTotalIncome/";
            using (HttpClient lcHttpClient = new HttpClient())
            {
                DataTable TblIncome = JsonConvert.DeserializeObject<DataTable>
                (await lcHttpClient.GetStringAsync(lcURI));
                decimal lcTotal = 0;
                foreach (DataRow dr in TblIncome.Rows)
                {
                    if (dr["rego"].ToString() == prRego && dr["activity_type"].ToString() == "hire")
                        lcTotal += Convert.ToDecimal(dr["cost"].ToString());
                    else if (dr["rego"].ToString() == prRego)
                        lcTotal -= Convert.ToDecimal(dr["cost"].ToString());
                }
                return lcTotal.ToString();
            }
        }
        #endregion

        #region Get,Insert,Update,Delete Vehicles
        internal async Task<List<clsVehicle>> GetVehicles()
        {
            List<clsVehicle> lcVehicles = new List<clsVehicle>();
            using (HttpClient lcHttpClient = new HttpClient())
            {
                lcVehicles = JsonConvert.DeserializeObject<List<clsVehicle>>
                (await lcHttpClient.GetStringAsync("http://localhost:60064/api/clsRental/GetVehicleList/"));
            }
            return lcVehicles;
        }

        internal async Task<string> AddVehicle(clsVehicle prVehicle)
        {
            string lcURI = "http://localhost:60064/api/clsRental/GetVehicleInsert?prRego=" + prVehicle.Rego + "&prMake=" + 
                prVehicle.Make.Replace(" ", "%20") + "&prModel=" + prVehicle.Model.Replace(" ", "%20") + 
                "&prYear=" + prVehicle.Year.ToString() + "&prTrans=" + prVehicle.Trans + 
                "&prRate=" + prVehicle.Rate.ToString() + "&prType=" + prVehicle.VehicleType;
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<string>
            (await lcHttpClient.GetStringAsync(lcURI));
        }

        internal async Task<string> UpdateVehicle(clsVehicle prVehicle)
        {
            string lcURI = "http://localhost:60064/api/clsRental/GetVehicleUpdate?prRego=" + prVehicle.Rego + "&prMake=" +
                prVehicle.Make.Replace(" ", "%20") + "&prModel=" + prVehicle.Model.Replace(" ", "%20") + 
                "&prYear=" + prVehicle.Year.ToString() + "&prTrans=" + prVehicle.Trans + 
                "&prRate=" + prVehicle.Rate.ToString() + "&prType=" + prVehicle.VehicleType;
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<string>
            (await lcHttpClient.GetStringAsync(lcURI));
        }

        internal async Task<string> DeleteVehicle(clsVehicle prVehicle)
        {
            string lcURI = "http://localhost:60064/api/clsRental/GetVehicleDelete?prRego=" + prVehicle.Rego;
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<string>
            (await lcHttpClient.GetStringAsync(lcURI));
        }
        #endregion

        #region Get,Insert,Update,Delete Activities (Hire,Service)
        internal async Task<clsVehicle> GetVehicleActivities(clsVehicle prVehicle)
        {
            using (HttpClient lcHttpClient = new HttpClient())
            {
                DataTable Tbl_activities = JsonConvert.DeserializeObject<DataTable>
                    (await lcHttpClient.GetStringAsync(
                    "http://localhost:60064/api/clsRental/GetVehicleActivities?prRego=" + prVehicle.Rego));
                clsVehicle lcVehicle = prVehicle;
                List<clsActivity> lcActivityList = new List<clsActivity>();
                foreach (DataRow dr in Tbl_activities.Rows)
                {
                    if (dr["activity_type"].ToString() == "hire")
                    {
                        clsActivityHire tmpHireData = new clsActivityHire();
                        tmpHireData = (clsActivityHire)ParseActivity(tmpHireData, dr);
                        lcActivityList.Add(tmpHireData);
                    }
                    else
                    {
                        clsActivityService tmpServiceData = new clsActivityService();
                        tmpServiceData = (clsActivityService)ParseActivity(tmpServiceData, dr);
                        lcActivityList.Add(tmpServiceData);
                    }
                }
                lcVehicle.ActivityList = lcActivityList;
                return lcVehicle;
            }
        }

        private clsActivity ParseActivity(clsActivity prActivity, DataRow dr2)
        {
            prActivity.Id = Convert.ToInt16(dr2["id"]);
            prActivity.Rego = dr2["rego"].ToString();
            prActivity.Name = dr2["name_id"].ToString();
            prActivity.ActivityType = dr2["activity_type"].ToString();
            prActivity.Cost = Convert.ToDecimal(dr2["cost"]);
            prActivity.Rate = Convert.ToDecimal(dr2["rate"]);
            prActivity.Date = dr2["starting_date"].ToString();
            prActivity.Notify = Convert.ToInt16(dr2["notify"]);
            return prActivity;
        }

        internal async Task<clsActivity> GetVehicleActivity(clsActivity prActivity)
        {
            if (prActivity.ActivityType == "hire")
            {
                DataTable Tbl_hire = await GetHireActivityAsync(prActivity.Id.ToString());
                clsActivityHire lcActivity = (clsActivityHire)prActivity;
                lcActivity.Paid = Convert.ToInt16(Tbl_hire.Rows[0]["paid"]);
                lcActivity.EndDate = Tbl_hire.Rows[0]["end_date"].ToString();
                return lcActivity;
            }
            else
            {
                DataTable Tbl_service = await GetServiceActivityAsync(prActivity.Id.ToString());
                clsActivityService lcActivity = (clsActivityService)prActivity;
                lcActivity.Description = Tbl_service.Rows[0]["description"].ToString();
                return lcActivity;
            }
        }

        internal async Task<DataTable> GetHireActivityAsync(string prID)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<DataTable>
            (await lcHttpClient.GetStringAsync("http://localhost:60064/api/clsRental/GetHireActivity?prID=" + @prID));
        }

        internal async Task<DataTable> GetServiceActivityAsync(string prID)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<DataTable>
            (await lcHttpClient.GetStringAsync("http://localhost:60064/api/clsRental/GetServiceActivity?prID=" + @prID));
        }

        internal async Task<string> AddActivity(clsActivity prActivity)
        {
            string lcURI = "";
            if (prActivity.typeOfActivity() == "Hire")
            {
                clsActivityHire lcActivity = (clsActivityHire)prActivity;
                lcURI = "http://localhost:60064/api/clsRental/GetActivityInsert?prRego=" + lcActivity.Rego + 
                    "&prType=" + lcActivity.typeOfActivity().ToLower().ToString() + "&prNameID=" + lcActivity.Name.Replace(" ","%20") + 
                    "&prDate=" + WebUtility.UrlEncode(lcActivity.Date) + "&prRate=" + lcActivity.Rate.ToString() + "&prCost=" + lcActivity.Cost.ToString() + 
                    "&prD=" + WebUtility.UrlEncode(lcActivity.EndDate) + "&prPaid=" + lcActivity.Paid.ToString();
            } else
            {
                clsActivityService lcActivity = (clsActivityService)prActivity;
                lcURI = "http://localhost:60064/api/clsRental/GetActivityInsert?prRego=" + lcActivity.Rego +
                    "&prType=" + lcActivity.typeOfActivity().ToLower().ToString() + "&prNameID=" + lcActivity.Name.Replace(" ", "%20") +
                    "&prDate=" + WebUtility.UrlEncode(lcActivity.Date) + "&prRate=" + lcActivity.Rate.ToString() + "&prCost=" + lcActivity.Cost.ToString() +
                    "&prD=" + WebUtility.UrlEncode(lcActivity.Description) + "&prPaid=1";
            }
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<string>
            (await lcHttpClient.GetStringAsync(lcURI));
        }

        internal async Task<string> UpdateActivity(clsActivity prActivity)
        {
            string lcURI = "";
            if (prActivity.typeOfActivity() == "Hire")
            {
                clsActivityHire lcActivity = (clsActivityHire)prActivity;
                lcURI = "http://localhost:60064/api/clsRental/GetActivityUpdate?prID=" + lcActivity.Id +
                    "&prType=" + lcActivity.typeOfActivity().ToLower().ToString() + "&prNameID=" + lcActivity.Name.Replace(" ", "%20") +
                    "&prDate=" + WebUtility.UrlEncode(lcActivity.Date) + "&prRate=" + lcActivity.Rate.ToString() + "&prCost=" + lcActivity.Cost.ToString() +
                    "&prD=" + WebUtility.UrlEncode(lcActivity.EndDate) + "&prPaid=" + lcActivity.Paid.ToString();
            }
            else
            {
                clsActivityService lcActivity = (clsActivityService)prActivity;
                lcURI = "http://localhost:60064/api/clsRental/GetActivityUpdate?prID=" + lcActivity.Id +
                    "&prType=" + lcActivity.typeOfActivity().ToLower().ToString() + "&prNameID=" + lcActivity.Name.Replace(" ", "%20") +
                    "&prDate=" + WebUtility.UrlEncode(lcActivity.Date) + "&prRate=" + lcActivity.Rate.ToString() + "&prCost=" + lcActivity.Cost.ToString() +
                    "&prD=" + WebUtility.UrlEncode(lcActivity.Description) + "&prPaid=1";
            }
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<string>
            (await lcHttpClient.GetStringAsync(lcURI));
        }

        internal async Task<string> DeleteActivity(clsActivity prActivity)
        {
            string lcURI = "http://localhost:60064/api/clsRental/GetVehicleDelete?prID=" + prActivity.Id;
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<string>
            (await lcHttpClient.GetStringAsync(lcURI));
        }
        #endregion

        #region Get,Stop,Clear Notifications
        internal async Task<List<clsNotification>> GetNotifications()
        {
            List<clsNotification> tmpNotificationList = new List<clsNotification>();
            using (HttpClient lcHttpClient = new HttpClient())
            {
                DataTable Tbl_notifications = JsonConvert.DeserializeObject<DataTable>
                    (await lcHttpClient.GetStringAsync("http://localhost:60064/api/clsRental/GetNotifications/"));
                clsNotification tmpNotification;
                foreach (DataRow dr in Tbl_notifications.Rows)
                {
                    tmpNotification = new clsNotification();
                    tmpNotification.Id = Convert.ToInt16(dr["id"]);
                    tmpNotification.Rego = dr["rego"].ToString();
                    tmpNotification.Description = "Booked for " + dr["starting_date"].ToString() + 
                        " by " + dr["name_id"].ToString() + "! Income: $" + dr["cost"].ToString();
                    tmpNotificationList.Add(tmpNotification);
                }
            }
            return tmpNotificationList;
        }

        internal async Task<string> StopNotification(clsNotification prNotification)
        {
            string lcURI = "http://localhost:60064/api/clsRental/GetRemoveNotification?prID=" + prNotification.Id;
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<string>
            (await lcHttpClient.GetStringAsync(lcURI));
        }

        internal async Task<string> ClearAllNotifications()
        {
            string lcURI = "http://localhost:60064/api/clsRental/GetClearNotifications/";
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<string>
            (await lcHttpClient.GetStringAsync(lcURI));
        }
        #endregion

    }
}
