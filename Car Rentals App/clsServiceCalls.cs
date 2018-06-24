using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net;

namespace Car_Rentals_App
{
    sealed class clsServiceCalls
    {
        //This code was developed by Dean.Stanleyhunt@live.nmit.ac.nz @ 22/06/2018. As an Assessment Project for SDV701 at NMIT NZ.
        //This software is for educational purposes to display knowledge learned about OOP, Refactoring and Design Patterns .
        public static readonly clsServiceCalls Instance = new clsServiceCalls();

        private clsServiceCalls() { }

        #region Get Vehicles
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
        #endregion

        #region Insert Activities (Hire,Service)

        internal async Task<string> AddActivity(clsActivity prActivity)
        {
            string lcURI = "";
            if (prActivity.typeOfActivity() == "Hire")
            {
                clsActivityHire lcActivity = (clsActivityHire)prActivity;
                lcURI = "http://localhost:60064/api/clsRental/GetActivityInsert?prRego=" + lcActivity.Rego +
                    "&prType=" + lcActivity.typeOfActivity().ToLower().ToString() + "&prNameID=" + lcActivity.Name.Replace(" ", "%20") +
                    "&prDate=" + WebUtility.UrlEncode(lcActivity.Date) + "&prRate=" + lcActivity.Rate.ToString() + "&prCost=" + lcActivity.Cost.ToString() +
                    "&prD=" + WebUtility.UrlEncode(lcActivity.EndDate) + "&prPaid=" + lcActivity.Paid.ToString();
            }
            else
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
        #endregion

    }
}
