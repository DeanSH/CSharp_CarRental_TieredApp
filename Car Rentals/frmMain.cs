using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Car_Rentals
{
    //This code was developed by Dean.Stanleyhunt@live.nmit.ac.nz @ 22/06/2018. As an Assessment Project for SDV701 at NMIT NZ.
    //This software is for educational purposes to display knowledge learned about OOP, Refactoring and Design Patterns .
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.Execut‌​ablePath);
            try
            {
                updateDisplay();
                ttpFindVehicle.SetToolTip(txtFind, "Enter a Vehicle Rego here to search for!");
                updateNotifications();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void editVehicle()
        {
            clsVehicle lcVehicle = (clsVehicle)lstVehicles.SelectedItem;
            if (lcVehicle != null && frmVehicle.Instance.ShowDialog(lcVehicle))
            {
                await clsServiceCalls.Instance.UpdateVehicle(lcVehicle);
            }
            updateDisplay();
        }
        private async void updateDisplay()
        {
            List<clsVehicle> lcVehicleList = await clsServiceCalls.Instance.GetVehicles();
            lstVehicles.DataSource = null;
            lstVehicles.DataSource = lcVehicleList;
            if (lcVehicleList.Count > 0)
            {
                clsVehicle lcVehicle = (clsVehicle)lstVehicles.SelectedItem;
                lblVehicle.Text = lcVehicle.QuickView();
            }
            tssStatus.Text = "Status: " + lstVehicles.Items.Count + " Vehicle(s)";
            tssValue.Text = "Total Income: $" + await clsServiceCalls.Instance.GetTotalIncome();
        }

        private async void btnAddVehicle_Click(object sender, EventArgs e)
        {
            clsVehicle lcVehicle = new clsVehicle();
            if (lcVehicle != null && frmVehicle.Instance.ShowDialog(lcVehicle))
            {
                await clsServiceCalls.Instance.AddVehicle(lcVehicle);
                if(lcVehicle.ActivityList.Count > 0)
                {
                    foreach (clsActivity lcActivity in lcVehicle.ActivityList)
                    {
                        lcActivity.Rego = lcVehicle.Rego;
                        await clsServiceCalls.Instance.AddActivity(lcActivity);
                    }
                }
            }
            updateDisplay();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            clsVehicle lcVehicle = (clsVehicle)lstVehicles.SelectedItem;
            if (lcVehicle != null)
                if (MessageBox.Show(this, "Are you sure you want to Delete '" + lcVehicle.Rego + "'", "Delete?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    await clsServiceCalls.Instance.DeleteVehicle(lcVehicle);
                    updateDisplay();
                }
        }

        private void btnEditVehicle_Click(object sender, EventArgs e)
        {
            editVehicle();
        }

        private void btnpbFindRego_Click(object sender, EventArgs e)
        {
            foreach (clsVehicle tmpVehicle in lstVehicles.Items)
            {
                if (txtFind.Text == tmpVehicle.Rego)
                {
                    lstVehicles.SelectedItem = tmpVehicle;
                    return;
                }
            }
            MessageBox.Show(clsErrorHandler.Instance.ErrorMessage(7));
        }

        private void lstVehilces_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsVehicle lcVehicle = (clsVehicle)lstVehicles.SelectedItem;
            if (lcVehicle != null)
                lblVehicle.Text = lcVehicle.QuickView();
        }

        private void lstVehicles_DoubleClick(object sender, EventArgs e)
        {
            editVehicle();
        }

        private void txtFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (clsErrorHandler.Instance.ErrorCheckTextLength(txtFind.Text, 10) == 1 && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
                tssStatus.Text = clsErrorHandler.Instance.ErrorMessage(1);
            }
            else
            {
                tssStatus.Text = "Status: " + lstVehicles.Items.Count + " Vehicle(s)";
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (clsErrorHandler.Instance.ErrorCheckTextLength(txtFind.Text, 11) == 1)
                txtFind.Text = txtFind.Text.Substring(1,10);
        }

        private void txtFind_Leave(object sender, EventArgs e)
        {
            tssStatus.Text = "Status: " + lstVehicles.Items.Count + " Vehicle(s)";
        }

        private void tmrNotifications_Tick(object sender, EventArgs e)
        { 
            updateNotifications();
        }

        private async void updateNotifications()
        {
            try
            {
                List<clsNotification> lcNotificationList = await clsServiceCalls.Instance.GetNotifications();
                int tmpSel = 0;
                if (lstNotifications.Items.Count > 0) tmpSel = lstNotifications.SelectedIndex;
                lstNotifications.DataSource = null;
                lstNotifications.DataSource = lcNotificationList;
                if (lstNotifications.Items.Count > 0) lstNotifications.SelectedIndex = tmpSel;
            }
            catch (Exception ex) { }
        }

        private async void btnNotification_Click(object sender, EventArgs e)
        {
            clsNotification lcNotification = (clsNotification)lstNotifications.SelectedItem;
            if (lcNotification != null)
            {
                foreach (clsVehicle tmpVehicle in lstVehicles.Items)
                {
                    if (tmpVehicle.Rego == lcNotification.Rego)
                    {
                        clsVehicle lcVehicle = tmpVehicle;
                        if (lcVehicle != null && frmVehicle.Instance.ShowDialog(lcVehicle))
                        {
                            await clsServiceCalls.Instance.UpdateVehicle(lcVehicle);
                        }
                        updateDisplay();
                        break;
                    }
                }
            }
        }

        private async void btnDltNotification_Click(object sender, EventArgs e)
        {
            clsNotification lcNotification = (clsNotification)lstNotifications.SelectedItem;
            if (lcNotification != null)
                if (MessageBox.Show(this, "Are you sure you want to Delete Notification for Vehicle '" + lcNotification.Rego + "'", "Delete?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    await clsServiceCalls.Instance.StopNotification(lcNotification);
                    updateNotifications();
                }
        }

        private async void btnClrNotifications_Click(object sender, EventArgs e)
        {
            if (lstNotifications.Items.Count > 0)
                if (MessageBox.Show(this, "Are you sure you want to Delete All Booking Notifications?", "Delete?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    await clsServiceCalls.Instance.ClearAllNotifications();
                    updateNotifications();
                }
        }
    }
}
