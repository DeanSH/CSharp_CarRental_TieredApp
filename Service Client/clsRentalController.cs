using System;
using System.Web.Http;
using System.Data;
using System.Net;
using System.Collections.Generic;

namespace Service_Client
{
    public class clsRentalController : ApiController
    {
        //This code was developed by Dean.Stanleyhunt@live.nmit.ac.nz @ 22/06/2018. As an Assessment Project for SDV701 at NMIT NZ.
        //This software is for educational purposes to display knowledge learned about OOP, Refactoring and Design Patterns .
        public DataTable GetTotalIncome()
        {   // select
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT T1.rego,T1.activity_type,T1.cost,T2.paid FROM activities AS T1 JOIN hire AS T2 ON T2.id = T1.id");
            return lcResult;
        }

        public List<clsVehicle> GetVehicleList()
        {   // select
            DataTable Tbl_vehicles = clsDbConnection.GetDataTable("SELECT * FROM vehicles");
            List<clsVehicle> tmpVehicles = new List<clsVehicle>();
            foreach (DataRow dr in Tbl_vehicles.Rows)
            {
                clsVehicle tmpVehicleData = ParseVehicle(dr);
                tmpVehicles.Add(tmpVehicleData);
            }
            return tmpVehicles;
        }

        private clsVehicle ParseVehicle(DataRow dr)
        {
            clsVehicle tmpVehicleData = new clsVehicle();
            tmpVehicleData.Rego = dr["rego"].ToString();
            tmpVehicleData.Make = dr["make"].ToString();
            tmpVehicleData.Model = dr["model"].ToString();
            tmpVehicleData.Year = Convert.ToInt16(dr["year"]);
            tmpVehicleData.VehicleType = dr["type"].ToString();
            tmpVehicleData.Trans = dr["trans"].ToString();
            tmpVehicleData.Rate = Convert.ToDecimal(dr["rate"].ToString());
            return tmpVehicleData;
        }

        public string GetVehicleInsert(string prRego, string prMake, string prModel, int prYear, string prTrans, decimal prRate, string prType)
        {   // insert
            try
            {
                int lcRecCount = clsDbConnection.Execute("INSERT INTO vehicles VALUES('" + prRego + "','" + prMake.Replace("%20", " ") + 
                    "','" + prModel.Replace("%20", " ") + "'," + prYear.ToString() + ",'" + prTrans + 
                    "'," + prRate.ToString() + ",'" + prType + "')");
                if (lcRecCount == 1)
                    return "One car inserted";
                else
                    return "Unexpected car insert count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        public string GetVehicleUpdate(string prRego, string prMake, string prModel, int prYear, string prTrans, decimal prRate, string prType)
        {   // update
            try
            {
                int lcRecCount = clsDbConnection.Execute(
                "UPDATE vehicles SET make='" + prMake.Replace("%20", " ") + "',model='" + prModel.Replace("%20", " ") + 
                "',year=" + prYear.ToString() + ",trans='" + prTrans + "',rate=" + prRate.ToString() + 
                ",type='" + prType + "' WHERE rego='" + prRego + "'");
                if (lcRecCount == 1)
                    return "One car updated";
                else
                    return "Unexpected car update count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        public string GetVehicleDelete(string prRego)
        {   // delete
            try
            {
                int lcRecCount = clsDbConnection.Execute("DELETE FROM vehicles WHERE rego='" + prRego + "'");
                if (lcRecCount == 1)
                    return "One car deleted";
                else
                    return "Unexpected car delete count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }


        public DataTable GetNotifications()
        {   // select
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT * FROM activities WHERE activity_type='hire' AND notify=1");
            return lcResult;
        }

        public string GetRemoveNotification(int prID)
        {   // update 1 activity notify field
            try
            {
                int lcRecCount = clsDbConnection.Execute("UPDATE activities SET notify=0 WHERE id=" + prID.ToString());
                if (lcRecCount == 1)
                    return "One activity notify updated";
                else
                    return "Unexpected activity notify update count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        public string GetClearNotifications()
        {   // update all activity notify fields
            try
            {
                int lcRecCount = clsDbConnection.Execute("UPDATE activities SET notify=0 WHERE notify=1");
                if (lcRecCount == 1)
                    return "One or more activity notifies updated";
                else
                    return "Unexpected activity notify update all count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }


        public DataTable GetVehicleActivities(string prRego)
        {   // select
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT * FROM activities WHERE rego='" + prRego + "'");
            return lcResult;
        }

        public DataTable GetHireActivity(string prID)
        {   // select
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT * FROM hire WHERE id='" + prID + "'");
            return lcResult;
        }

        public DataTable GetServiceActivity(string prID)
        {   // select
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT * FROM service WHERE id='" + prID + "'");
            return lcResult;
        }

        public string GetActivityInsert(string prRego, string prType, string prNameID, string prDate, decimal prRate, decimal prCost, string prD, int prPaid)
        {   // insert where prD depending on activity type is a Date or a Description!
            try
            {
                int lcRecCount = clsDbConnection.Execute(
                "INSERT INTO activities(rego,activity_type,name_id,starting_date,rate,cost) VALUES('" + prRego + "','" + prType + "','" + 
                prNameID.Replace("%20"," ") + "','" + WebUtility.UrlDecode(prDate) + "'," + prRate.ToString() + "," + prCost.ToString() + ")");
                if (lcRecCount == 1)
                {
                    DataTable lcResult = clsDbConnection.GetDataTable("SELECT id FROM activities WHERE rego='" + prRego + "'");
                    int Id_Index = 0;
                    foreach (DataRow dr in lcResult.Rows)
                    {
                        Id_Index = Convert.ToInt16(dr["id"]);
                    }
                    if (prType == "hire")
                    {
                        lcRecCount = clsDbConnection.Execute("INSERT INTO hire VALUES(" + Id_Index.ToString() + 
                            ",'" + WebUtility.UrlDecode(prD) + "'," + prPaid + ")");
                    } else {
                        lcRecCount = clsDbConnection.Execute("INSERT INTO service VALUES(" + Id_Index.ToString() + 
                            ",'" + WebUtility.UrlDecode(prD) + "')");
                    }
                    return "One activity inserted";
                }
                else
                    return "Unexpected activity insert count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        public string GetActivityUpdate(int prID, string prType, string prNameID, string prDate, decimal prRate, decimal prCost, string prD, int prPaid)
        {   // update where depending on activity type prD is a Date or Description!
            try
            {
                int lcRecCount = clsDbConnection.Execute(
                "UPDATE activities SET name_id='" + prNameID.Replace("%20", " ") + "',starting_date='" + WebUtility.UrlDecode(prDate) + 
                "',rate=" + prRate.ToString() + ",cost=" + prCost.ToString() + " WHERE id=" + prID.ToString());
                if (lcRecCount == 1)
                {
                    if (prType == "hire")
                    {
                        lcRecCount = clsDbConnection.Execute("UPDATE hire SET end_date='" + WebUtility.UrlDecode(prD) + "',paid=" + prPaid + 
                            " WHERE id=" + prID.ToString());
                    }
                    else
                    {
                        lcRecCount = clsDbConnection.Execute("UPDATE service SET description='" + WebUtility.UrlDecode(prD) + 
                            "' WHERE id=" + prID.ToString());
                    }
                    return "One activity updated";
                }
                else
                    return "Unexpected activity update count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        public string GetActivityDelete(int prID)
        {   // delete
            try
            {
                int lcRecCount = clsDbConnection.Execute("DELETE FROM activities WHERE id=" + prID.ToString());
                if (lcRecCount == 1)
                {
                    lcRecCount = clsDbConnection.Execute("DELETE FROM hire WHERE id=" + prID.ToString());
                    lcRecCount = clsDbConnection.Execute("DELETE FROM service WHERE id=" + prID.ToString());
                    return "One activity deleted";
                }
                else
                    return "Unexpected activity delete count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }


    }
}
