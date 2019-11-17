namespace Car_Rentals
{
    partial class frmActivity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblCost = new System.Windows.Forms.Label();
            this.ssActivity = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssActivity.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(232, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(323, 64);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(118, 20);
            this.txtCost.TabIndex = 2;
            this.txtCost.TextChanged += new System.EventHandler(this.txtCost_TextChanged);
            this.txtCost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCost_KeyDown);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOK.Location = new System.Drawing.Point(282, 12);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 42);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.Location = new System.Drawing.Point(366, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 42);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(15, 64);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(232, 20);
            this.dtpDate.TabIndex = 6;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(279, 67);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(37, 13);
            this.lblCost.TabIndex = 10;
            this.lblCost.Text = "Cost $";
            // 
            // ssActivity
            // 
            this.ssActivity.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus});
            this.ssActivity.Location = new System.Drawing.Point(0, 101);
            this.ssActivity.Name = "ssActivity";
            this.ssActivity.Size = new System.Drawing.Size(453, 22);
            this.ssActivity.SizingGrip = false;
            this.ssActivity.TabIndex = 34;
            // 
            // tssStatus
            // 
            this.tssStatus.BackColor = System.Drawing.Color.White;
            this.tssStatus.ForeColor = System.Drawing.Color.Black;
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(438, 17);
            this.tssStatus.Spring = true;
            this.tssStatus.Text = "Status: Idle";
            this.tssStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 123);
            this.Controls.Add(this.ssActivity);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmActivity";
            this.Text = "Activity";
            this.ssActivity.ResumeLayout(false);
            this.ssActivity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.StatusStrip ssActivity;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
    }
}