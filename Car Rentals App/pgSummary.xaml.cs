using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Car_Rentals_App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class pgSummary : Page
    {
        public pgSummary()
        {
            this.InitializeComponent();
            insertActivity();
            clsVehicle lcVehicle = clsClient.Instance.Vehicle;
            if (clsClient.Instance.Servicing == false)
            {
                clsActivityHire lcActivity = (clsActivityHire)clsClient.Instance.Activity;
                int lcDays = lcActivity.countDays(Convert.ToDateTime(lcActivity.Date).Date, Convert.ToDateTime(lcActivity.EndDate).Date) + 1;
                lblSummary.Text = "Summary of your Booking: \n\nRego: " + lcActivity.Rego + " \nMake: " + lcVehicle.Make + " \nModel: " + lcVehicle.Model + " \nYear: " + lcVehicle.Year.ToString() + " \nTrans: " + lcVehicle.Trans + " \nType: " + lcVehicle.VehicleType + " \nDaily Rate: $" + lcVehicle.Rate.ToString() + " " +
                    "\n\nName: " + lcActivity.Name + " \nStart Date: " + lcActivity.Date + " \nEnd Date: " + lcActivity.EndDate + " \nNumber of Days: " + lcDays.ToString() + " \n\nTotal Cost: $" + lcActivity.Cost.ToString() + " " +
                    "\n\nTotal must be Paid when Vehicle is picked up! Thanks for Booking!";
            }
            else
            {
                clsActivityService lcActivity = (clsActivityService)clsClient.Instance.Activity;
                lblTitle.Text = "Service Summary";
                lblSummary.Text = "Summary of your Service: \n\nRego: " + lcActivity.Rego + " \nMake: " + lcVehicle.Make + " \nModel: " + lcVehicle.Model + " \nYear: " + lcVehicle.Year.ToString() + " \nTrans: " + lcVehicle.Trans + " \nType: " + lcVehicle.VehicleType + " " +
                    "\n\nName: " + lcActivity.Name + " \nService Date: " + lcActivity.Date + " \nDescription: " + lcActivity.Description + " \n\nTotal Cost: $" + lcActivity.Cost.ToString() + " " +
                    "\n\nThanks for Servicing our Fleet!";
            }
        }

        private async void insertActivity()
        {
            string lcReply = await clsServiceCalls.Instance.AddActivity(clsClient.Instance.Activity);
        }

        private void btnFinish_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(pgMain));
        }
    }
}
