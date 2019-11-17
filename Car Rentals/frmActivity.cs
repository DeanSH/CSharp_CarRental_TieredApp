using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
namespace Car_Rentals
{
    //This code was developed by Dean.Stanleyhunt@live.nmit.ac.nz @ 22/06/2018. As an Assessment Project for SDV701 at NMIT NZ.
    //This software is for educational purposes to display knowledge learned about OOP, Refactoring and Design Patterns .
    public partial class frmActivity : Form
    {
        protected clsActivity _Activity;

        public delegate void LoadWorkFormDelegate(clsActivity prActivity);

        public static Dictionary<string, Delegate> _ActivityForm = new Dictionary<string, Delegate>
        {
            {"Hire", new LoadWorkFormDelegate(frmActivityHire.Run)},
            {"Service", new LoadWorkFormDelegate(frmActivityService.Run)},
        };

        public static void DispatchWorkForm(clsActivity prActivity)
        {
            _ActivityForm[prActivity.typeOfActivity()].DynamicInvoke(prActivity);
        }

        public frmActivity()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.Execut‌​ablePath);
        }

        protected DateTime getDate()
        {
            return dtpDate.Value;
        }

        protected virtual void pushData()
        {
            _Activity.Name = txtName.Text;
            _Activity.Date = dtpDate.Value.ToShortDateString();
            _Activity.Cost = Math.Round(Convert.ToDecimal(txtCost.Text), 2);
        }

        public bool ShowDialog(clsActivity prActivity)
        {
            _Activity = prActivity;
            updateDisplay();
            return ShowDialog() == DialogResult.OK;
        }

        protected virtual void updateDisplay()
        {
            this.Text = _Activity.typeOfActivity();
            txtName.Text = _Activity.Name;
            dtpDate.Value = DateTime.Parse(_Activity.Date);
            txtCost.Text = Convert.ToString(_Activity.Cost);
            if (this.Text == "Hire")
            {
                txtCost.Enabled = false;
            }
            else
            {
                txtCost.Enabled = true;
            }
        }

        protected void updateCost(decimal prCost)
        {
            txtCost.Text = Convert.ToString(prCost);
        }

        protected void updateStatus(string prStatus)
        {
            tssStatus.Text = prStatus;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtCost.Text != "")
            {
                pushData();
                DialogResult = DialogResult.OK;
            }
            else
                tssStatus.Text = clsErrorHandler.Instance.ErrorMessage(5);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (clsErrorHandler.Instance.ErrorCheckTextLength(txtName.Text, 31) == 1)
                txtName.Text = txtName.Text.Substring(1, 30);
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (clsErrorHandler.Instance.ErrorCheckTextLength(txtName.Text, 30) == 1 && e.KeyCode != Keys.Back && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right)
            {
                e.SuppressKeyPress = true;
                tssStatus.Text = clsErrorHandler.Instance.ErrorMessage(1);
            }
            else
            {
                tssStatus.Text = "Status: Inputting Activity Details..";
            }
        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {
            int ErrNum = clsErrorHandler.Instance.ErrorCheckTextCurrency(txtCost.Text);
            if (ErrNum > 0)
                txtCost.Text = "";
        }

        private void txtCost_KeyDown(object sender, KeyEventArgs e)
        {
            int ErrNum = clsErrorHandler.Instance.ErrorCheckTextCurrency(txtCost.Text + Convert.ToChar(e.KeyValue));
            if (ErrNum > 0 && e.KeyCode != Keys.OemPeriod && e.KeyCode != Keys.Back && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyValue > 105 && e.KeyValue < 96)
            {
                e.SuppressKeyPress = true;
                tssStatus.Text = clsErrorHandler.Instance.ErrorMessage(ErrNum);
            }
            else
            {
                tssStatus.Text = "Status: Inputting Activity Details..";
            }
        }

    }
}
