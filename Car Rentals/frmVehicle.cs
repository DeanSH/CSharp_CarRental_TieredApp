using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Car_Rentals
{
    //This code was developed by Dean.Stanleyhunt@live.nmit.ac.nz @ 22/06/2018. As an Assessment Project for SDV701 at NMIT NZ.
    //This software is for educational purposes to display knowledge learned about OOP, Refactoring and Design Patterns .
    public sealed partial class frmVehicle : Form
    {
        public static readonly frmVehicle Instance = new frmVehicle();

        private IComparer<clsActivity>[] _Comparer = { clsNameComparer.Instance, clsDateComparer.Instance };
        private readonly string[] _SortStrings = { "Name", "Date" };
        private readonly string[] _TransStrings = { "Automatic", "Manual" };
        private readonly string[] _VehicleTypeStrings = { "Compact", "Sedan", "Wagon", "Van", "Truck", "Trailer", "Other" };
        private clsVehicle _Vehicle;

        private frmVehicle()
        {
            InitializeComponent();
            cboActivityType.DataSource = clsActivity.ActivityTypes;
            cboActivityType.SelectedIndex = 0;
            cboSortChoice.DataSource = _SortStrings;
            cboSortChoice.SelectedIndex = 0;
            cboTrans.DataSource = _TransStrings;
            cboVehicleType.DataSource = _VehicleTypeStrings;
            this.Icon = Icon.ExtractAssociatedIcon(Application.Execut‌​ablePath);
        }

        private async void editActivity()
        {
            if (lstActivities.Items.Count > 0)
            {
                clsActivity lcActivity = (clsActivity)lstActivities.SelectedItem;
                if (txtRego.Enabled == false)
                    lcActivity = await clsServiceCalls.Instance.GetVehicleActivity(lcActivity);
                if (lcActivity != null)
                {
                    frmActivity.DispatchWorkForm(lcActivity);
                    pushData();
                    if (txtRego.Enabled == false)
                        await clsServiceCalls.Instance.UpdateActivity(lcActivity);
                }
                updateActivityDisplay();
            }
        }

        public bool ShowDialog(clsVehicle prVehicle)
        {
            _Vehicle = prVehicle;
            updateVehicleDisplay();
            updateActivityDisplay();
            return ShowDialog() == DialogResult.OK;
        }

        private void pushData()
        {
            _Vehicle.Rego = txtRego.Text;
            _Vehicle.Make = txtMake.Text;
            _Vehicle.Model = txtModel.Text;
            _Vehicle.Year = Convert.ToInt32(txtYear.Text);
            _Vehicle.Rate = Math.Round(Convert.ToDecimal(txtRate.Text), 2);
            _Vehicle.Trans = cboTrans.Text;
            _Vehicle.VehicleType = cboVehicleType.Text;
        }

        private void updateVehicleDisplay()
        {
            txtRego.Text = _Vehicle.Rego;
            txtMake.Text = _Vehicle.Make;
            txtModel.Text = _Vehicle.Model;
            txtYear.Text = Convert.ToString(_Vehicle.Year);
            txtRate.Text = Convert.ToString(_Vehicle.Rate);
            cboTrans.Text = _Vehicle.Trans;
            cboVehicleType.Text = _Vehicle.VehicleType;
            txtRego.Enabled = String.IsNullOrEmpty(_Vehicle.Rego);
        }

        private async void updateActivityDisplay()
        {
            try
            {
                if (_Vehicle != null)
                {
                    lstActivities.DataSource = null;
                    if (txtRego.Enabled == false)
                        _Vehicle = await clsServiceCalls.Instance.GetVehicleActivities(_Vehicle);
                    List<clsActivity> lcActivityList = _Vehicle.ActivityList;
                    lcActivityList.Sort(_Comparer[cboSortChoice.SelectedIndex]);
                    lstActivities.DataSource = lcActivityList;
                    tssStatus.Text = "Status: " + lstActivities.Items.Count + " Activity(s)";
                    if (_Vehicle.ActivityList.Count > 0)
                        tssValue.Text = "Total Vehicle Income: $" + await clsServiceCalls.Instance.GetVehicleTotalIncome(_Vehicle.Rego);
                }
            }
            catch (Exception)
            {
                // Do nothing, this Try catch is only to prevent an error on program load where saved data is not yet loaded.
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async void btnNewActivity_Click(object sender, EventArgs e)
        {
            clsActivity lcActivity = clsActivity.NewActivity(cboActivityType.SelectedIndex);
            if (lcActivity.typeOfActivity()=="Hire")
            {
                lcActivity.Rate = Math.Round(Convert.ToDecimal(txtRate.Text),2);
            }
            if(lcActivity != null)
            {
                frmActivity.DispatchWorkForm(lcActivity);
                lcActivity.Rego = _Vehicle.Rego;
                _Vehicle.ActivityList.Add(lcActivity);
                pushData();
                if (txtRego.Enabled == false)
                    await clsServiceCalls.Instance.AddActivity(lcActivity);
            }
            updateActivityDisplay();
        }

        private void btnModActivity_Click(object sender, EventArgs e)
        {
            editActivity();
        }

        private async void btnDelActivity_Click(object sender, EventArgs e)
        {
            clsActivity lcActivity = (clsActivity)lstActivities.SelectedItem;
            if (lcActivity != null)
                if (MessageBox.Show(this, "Are you sure you want to Delete '" + lcActivity.Name + "'", "Delete?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _Vehicle.ActivityList.Remove(lcActivity);
                    await clsServiceCalls.Instance.DeleteActivity(lcActivity);
                    updateActivityDisplay();
                }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtYear.Text != "" && txtRate.Text != "" && txtRego.Text != "" && txtMake.Text != "" && txtModel.Text != "")
                if (Convert.ToInt32(txtYear.Text) < 1950)
                {
                    tssStatus.Text = clsErrorHandler.Instance.ErrorMessage(4);
                }
                else
                {
                    pushData();
                    DialogResult = DialogResult.OK;
                }
            else
                tssStatus.Text = clsErrorHandler.Instance.ErrorMessage(5);
        }

        private void cboSortChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateActivityDisplay();
        }

        private void lstActivities_DoubleClick(object sender, EventArgs e)
        {
            editActivity();
        }

        private void txtRego_TextChanged(object sender, EventArgs e)
        {
            if (clsErrorHandler.Instance.ErrorCheckTextLength(txtRego.Text, 11) == 1)
                txtRego.Text = txtRego.Text.Substring(1, 10);
        }

        private void txtRego_KeyDown(object sender, KeyEventArgs e)
        {
            if (clsErrorHandler.Instance.ErrorCheckTextLength(txtRego.Text, 10) == 1 && e.KeyCode != Keys.Back && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right)
            {
                e.SuppressKeyPress = true;
                tssStatus.Text = clsErrorHandler.Instance.ErrorMessage(1);
            }
            else
            {
                tssStatus.Text = "Status: " + _Vehicle.ActivityList.Count + " Activity(s)";
            }
        }

        private void txtMake_TextChanged(object sender, EventArgs e)
        {
            if (clsErrorHandler.Instance.ErrorCheckTextLength(txtMake.Text, 31) == 1)
                txtMake.Text = txtMake.Text.Substring(1, 30);
        }

        private void txtMake_KeyDown(object sender, KeyEventArgs e)
        {
            if (clsErrorHandler.Instance.ErrorCheckTextLength(txtMake.Text, 30) == 1 && e.KeyCode != Keys.Back && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right)
            {
                e.SuppressKeyPress = true;
                tssStatus.Text = clsErrorHandler.Instance.ErrorMessage(1);
            }
            else
            {
                tssStatus.Text = "Status: " + _Vehicle.ActivityList.Count + " Activity(s)";
            }
        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {
            if (clsErrorHandler.Instance.ErrorCheckTextLength(txtModel.Text, 31) == 1)
                txtModel.Text = txtModel.Text.Substring(1, 30);
        }

        private void txtModel_KeyDown(object sender, KeyEventArgs e)
        {
            if (clsErrorHandler.Instance.ErrorCheckTextLength(txtModel.Text, 30) == 1 && e.KeyCode != Keys.Back && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right)
            {
                e.SuppressKeyPress = true;
                tssStatus.Text = clsErrorHandler.Instance.ErrorMessage(1);
            }
            else
            {
                tssStatus.Text = "Status: " + _Vehicle.ActivityList.Count + " Activity(s)";
            }
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            int ErrNum = clsErrorHandler.Instance.ErrorCheckTextYear(txtYear.Text, 4);
            if (ErrNum > 0)
                txtYear.Text = "";
        }

        private void txtYear_KeyDown(object sender, KeyEventArgs e)
        {
            int ErrNum = clsErrorHandler.Instance.ErrorCheckTextYear(txtYear.Text + Convert.ToChar(e.KeyValue), 4);
            if (ErrNum > 0 && e.KeyCode != Keys.Back && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyValue > 105 && e.KeyValue < 96)
            {
                e.SuppressKeyPress = true;
                tssStatus.Text = clsErrorHandler.Instance.ErrorMessage(ErrNum);
            }
            else
            {
                tssStatus.Text = "Status: " + _Vehicle.ActivityList.Count + " Activity(s)";
            }
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            int ErrNum = clsErrorHandler.Instance.ErrorCheckTextCurrency(txtRate.Text);
            if (ErrNum > 0)
                txtRate.Text = "";
        }

        private void txtRate_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine(Convert.ToString(Convert.ToChar(e.KeyValue) + " " + e.KeyValue + " " + e.KeyCode));
            int ErrNum = clsErrorHandler.Instance.ErrorCheckTextCurrency(txtRate.Text + Convert.ToChar(e.KeyValue));
            if (ErrNum > 0 && e.KeyCode != Keys.OemPeriod && e.KeyCode != Keys.Back && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyValue > 105 && e.KeyValue < 96)
            {
                e.SuppressKeyPress = true;
                tssStatus.Text = clsErrorHandler.Instance.ErrorMessage(ErrNum);
            }
            else
            {
                tssStatus.Text = "Status: " + _Vehicle.ActivityList.Count + " Activity(s)";
            }
        }

    }
}
