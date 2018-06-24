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
    public sealed partial class pgVehicle : Page
    {
        public pgVehicle()
        {
            this.InitializeComponent();
            UpdateDisplay();
        }

        private async void UpdateDisplay()
        {
            lvVehicles.ItemsSource = await clsServiceCalls.Instance.GetVehicles();
            lvVehicles.SelectedIndex = 0;
            clsVehicle lcVehicle = (clsVehicle)lvVehicles.SelectedItem;
            if (clsClient.Instance.Servicing == true)
            {
                lblVehicles.Text = "Select a Vehicle to Service:";
                lblQuickView.Text = lcVehicle.QuickViewService();
            }
            else
            {
                lblVehicles.Text = "Select a Vehicle to Rent:";
                lblQuickView.Text = lcVehicle.QuickViewHire();
            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (lvVehicles.Items.Count > 0)
            {
                clsClient.Instance.Vehicle = new clsVehicle();
                clsClient.Instance.Vehicle = (clsVehicle)lvVehicles.SelectedItem;
                this.Frame.Navigate(typeof(pgDetails));
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(pgMain));
        }

        private void lvVehicles_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (lvVehicles.Items.Count > 0)
            {
                clsVehicle lcVehicle = (clsVehicle)lvVehicles.SelectedItem;
                if (clsClient.Instance.Servicing == true)
                {
                    lblVehicles.Text = "Select a Vehicle to Service:";
                    lblQuickView.Text = lcVehicle.QuickViewService();
                }
                else
                {
                    lblVehicles.Text = "Select a Vehicle to Rent:";
                    lblQuickView.Text = lcVehicle.QuickViewHire();
                }
            }
        }
    }
}
