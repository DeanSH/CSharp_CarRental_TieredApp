using System;
using System.Windows.Forms;

namespace Car_Rentals
{
    //This code was developed by Dean.Stanleyhunt@live.nmit.ac.nz @ 22/06/2018. As an Assessment Project for SDV701 at NMIT NZ.
    //This software is for educational purposes to display knowledge learned about OOP, Refactoring and Design Patterns .
    public sealed partial class frmActivityService : Car_Rentals.frmActivity
    {
        private static readonly frmActivityService Instance = new frmActivityService();

        private frmActivityService()
        {
            InitializeComponent();
        }

        public static void Run(clsActivity prActivity)
        {
            Instance.ShowDialog(prActivity);
        }

        protected override void updateDisplay()
        {
            base.updateDisplay();
            clsActivityService lcActivity = (clsActivityService)_Activity;
            txtDescription.Text = Convert.ToString(lcActivity.Description);
        }

        protected override void pushData()
        {
            base.pushData();
            clsActivityService lcActivity = (clsActivityService)_Activity;
            lcActivity.Description = txtDescription.Text;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if (clsErrorHandler.Instance.ErrorCheckTextLength(txtDescription.Text, 101) == 1)
                txtDescription.Text = txtDescription.Text.Substring(1, 100);
        }

        private void txtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (clsErrorHandler.Instance.ErrorCheckTextLength(txtDescription.Text, 100) == 1 && e.KeyCode != Keys.Back && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right)
            {
                e.SuppressKeyPress = true;
                base.updateStatus(clsErrorHandler.Instance.ErrorMessage(1));
            }
            else
            {
                base.updateStatus("Status: Inputting Activity Details..");
            }
        }
    }
}
