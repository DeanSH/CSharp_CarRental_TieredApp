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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Car_Rentals_App
{
    public sealed partial class ucHire : UserControl
    {
        public ucHire()
        {
            this.InitializeComponent();
        }

        public DateTime GetDate()
        {
            return dpEnd.Date.Date;
        }

        public void SetDate(DatePicker prDP)
        {
            dpEnd.Date = prDP.Date;
        }
    }
}
