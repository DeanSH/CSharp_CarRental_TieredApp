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
    public sealed partial class pgMain : Page
    {
        public pgMain()
        {
            this.InitializeComponent();
        }

        private void btnHire_Click(object sender, RoutedEventArgs e)
        {
            clsClient.Instance.Servicing = false;
            this.Frame.Navigate(typeof(pgVehicle));
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void btnService_Click(object sender, RoutedEventArgs e)
        {
            clsClient.Instance.Servicing = true;
            this.Frame.Navigate(typeof(pgVehicle));
        }
    }
}
