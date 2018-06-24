using System;
using System.Threading;
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

namespace Car_Rentals_App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class pgDetails : Page
    {
        private ucHire lcHire = new ucHire();
        private ucService lcService = new ucService();
        private DispatcherTimer dispatcherTimer;

        public pgDetails()
        {
            this.InitializeComponent();
            clsVehicle lcVehicle = clsClient.Instance.Vehicle;
            if (clsClient.Instance.Servicing == false)
            {
                spUserControl.Children.Add(lcHire);
                txtCost.IsReadOnly = true;
                lblVehicleInfo.Text = lcVehicle.QuickViewHire();
                clsClient.Instance.Activity = clsActivity.NewActivity(0);
                dispatcherTimer = new DispatcherTimer();
                dispatcherTimer.Tick += dispatcherTimer_Tick;
                dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
                dispatcherTimer.Start();
            }
            else
            {
                spUserControl.Children.Add(lcService);
                lblTitle.Text = "Service Details";
                lblStartDate.Text = "Service Date:";
                btnBook.Content = "Charge!";
                lblVehicleInfo.Text = lcVehicle.QuickViewService();
                clsClient.Instance.Activity = clsActivity.NewActivity(1);
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (clsClient.Instance.Servicing == false)
                dispatcherTimer.Stop();
            this.Frame.Navigate(typeof(pgVehicle));
        }

        private void btnBook_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text != "")
            {
                clsClient.Instance.Activity.Name = txtName.Text;
                clsClient.Instance.Activity.Rego = clsClient.Instance.Vehicle.Rego;
                clsClient.Instance.Activity.Rate = clsClient.Instance.Vehicle.Rate;
                clsClient.Instance.Activity.Notify = 1;
                clsClient.Instance.Activity.ActivityType = clsClient.Instance.Activity.typeOfActivity().ToLower().ToString();
                clsClient.Instance.Activity.Date = dpStart.Date.Date.Date.ToString();
                clsClient.Instance.Activity.Date = clsClient.Instance.Activity.Date.Split(Convert.ToChar(" "))[0];
                if (clsClient.Instance.Servicing == false)
                {
                    clsActivityHire lcActivity = (clsActivityHire)clsClient.Instance.Activity;
                    int lcDays = lcActivity.countDays(dpStart.Date.Date, lcHire.GetDate()) + 1;
                    txtCost.Text = Convert.ToString(clsClient.Instance.Vehicle.Rate * lcDays);
                    lcActivity.EndDate = lcHire.GetDate().Date.ToString();
                    lcActivity.EndDate = lcActivity.EndDate.Split(Convert.ToChar(" "))[0];
                    lcActivity.Cost = Convert.ToDecimal(txtCost.Text);
                    clsClient.Instance.Activity = lcActivity;
                    dispatcherTimer.Stop();
                }
                else
                {
                    clsActivityService lcActivity = (clsActivityService)clsClient.Instance.Activity;
                    lcActivity.Description = lcService.Description();
                    if (clsErrorHandler.Instance.ErrorCheckTextCurrency(txtCost.Text) > 0)
                        return;
                    lcActivity.Cost = Convert.ToDecimal(txtCost.Text);
                    clsClient.Instance.Activity = lcActivity;
                }
                this.Frame.Navigate(typeof(pgSummary));
            }
        }

        private void dispatcherTimer_Tick(object sender, object e)
        {
            clsActivityHire lcActivity = new clsActivityHire();
            if (lcActivity.countDays(dpStart.Date.Date, lcHire.GetDate()) < 0)
                lcHire.SetDate(dpStart);
            int lcDays = lcActivity.countDays(dpStart.Date.Date, lcHire.GetDate()) + 1;
            txtCost.Text = Convert.ToString(clsClient.Instance.Vehicle.Rate * lcDays);
        }
    }
}
