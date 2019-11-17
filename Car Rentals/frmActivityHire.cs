using System;

namespace Car_Rentals
{
    //This code was developed by Dean.Stanleyhunt@live.nmit.ac.nz @ 22/06/2018. As an Assessment Project for SDV701 at NMIT NZ.
    //This software is for educational purposes to display knowledge learned about OOP, Refactoring and Design Patterns .
    public sealed partial class frmActivityHire : Car_Rentals.frmActivity
    {

        private static readonly frmActivityHire Instance = new frmActivityHire();

        private frmActivityHire()
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
            clsActivityHire lcActivity = (clsActivityHire)_Activity;
            dtpDateEnd.Value = DateTime.Parse(lcActivity.EndDate);
            if (lcActivity.Paid == 1) cbPaid.Checked = true; 
            tmrCost.Enabled = true;
        }

        protected override void pushData()
        {
            base.pushData();
            tmrCost.Enabled = false;
            clsActivityHire lcActivity = (clsActivityHire)_Activity;
            lcActivity.EndDate = dtpDateEnd.Value.ToShortDateString();
            lcActivity.Paid = 0;
            if(cbPaid.Checked==true) lcActivity.Paid = 1;
        }

        private void calculateCost()
        {
            try
            {

                clsActivityHire lcActivity = (clsActivityHire)_Activity;
                int Days = Convert.ToInt32(lcActivity.countDays(base.getDate(), dtpDateEnd.Value)) + 1;
                if (Days < 1)
                {
                    base.updateCost(Convert.ToDecimal("0.00"));
                    base.updateStatus(clsErrorHandler.Instance.ErrorMessage(8));
                    dtpDateEnd.Value = DateTime.Today;
                } else {
                    base.updateCost(Convert.ToDecimal(lcActivity.Rate) * Days);
                    base.updateStatus("Status: $" + Convert.ToString(lcActivity.Rate) + " x " + Days + " Days");
                }
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message); // Not Needed, if error just do nothing, method will work on next timer tick.
            }
        }

        private void tmrCost_Tick(object sender, EventArgs e)
        {
            this.calculateCost();
        }

    }
}
