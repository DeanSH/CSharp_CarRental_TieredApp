namespace Car_Rentals
{
    partial class frmVehicle
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbActivityLog = new System.Windows.Forms.GroupBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.cboSortChoice = new System.Windows.Forms.ComboBox();
            this.lblHeaders = new System.Windows.Forms.Label();
            this.btnDelActivity = new System.Windows.Forms.Button();
            this.lstActivities = new System.Windows.Forms.ListBox();
            this.cboActivityType = new System.Windows.Forms.ComboBox();
            this.btnModActivity = new System.Windows.Forms.Button();
            this.btnNewActivity = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtRego = new System.Windows.Forms.TextBox();
            this.cboTrans = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.cboVehicleType = new System.Windows.Forms.ComboBox();
            this.ssVehicle = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbActivityLog.SuspendLayout();
            this.ssVehicle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.Location = new System.Drawing.Point(269, 49);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 28);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbActivityLog
            // 
            this.gbActivityLog.BackColor = System.Drawing.SystemColors.Control;
            this.gbActivityLog.Controls.Add(this.lblSort);
            this.gbActivityLog.Controls.Add(this.cboSortChoice);
            this.gbActivityLog.Controls.Add(this.lblHeaders);
            this.gbActivityLog.Controls.Add(this.btnDelActivity);
            this.gbActivityLog.Controls.Add(this.lstActivities);
            this.gbActivityLog.Controls.Add(this.cboActivityType);
            this.gbActivityLog.Controls.Add(this.btnModActivity);
            this.gbActivityLog.Controls.Add(this.btnNewActivity);
            this.gbActivityLog.ForeColor = System.Drawing.Color.Black;
            this.gbActivityLog.Location = new System.Drawing.Point(12, 167);
            this.gbActivityLog.Name = "gbActivityLog";
            this.gbActivityLog.Size = new System.Drawing.Size(383, 165);
            this.gbActivityLog.TabIndex = 16;
            this.gbActivityLog.TabStop = false;
            this.gbActivityLog.Text = "Activity Log";
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(254, 18);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(44, 13);
            this.lblSort.TabIndex = 23;
            this.lblSort.Text = "Sort By:";
            // 
            // cboSortChoice
            // 
            this.cboSortChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSortChoice.FormattingEnabled = true;
            this.cboSortChoice.Location = new System.Drawing.Point(304, 15);
            this.cboSortChoice.Name = "cboSortChoice";
            this.cboSortChoice.Size = new System.Drawing.Size(73, 21);
            this.cboSortChoice.TabIndex = 22;
            this.cboSortChoice.SelectedIndexChanged += new System.EventHandler(this.cboSortChoice_SelectedIndexChanged);
            // 
            // lblHeaders
            // 
            this.lblHeaders.AutoSize = true;
            this.lblHeaders.Location = new System.Drawing.Point(6, 28);
            this.lblHeaders.Name = "lblHeaders";
            this.lblHeaders.Size = new System.Drawing.Size(142, 13);
            this.lblHeaders.TabIndex = 21;
            this.lblHeaders.Text = "Name / Type / Date / Value";
            // 
            // btnDelActivity
            // 
            this.btnDelActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDelActivity.Location = new System.Drawing.Point(288, 130);
            this.btnDelActivity.Name = "btnDelActivity";
            this.btnDelActivity.Size = new System.Drawing.Size(89, 28);
            this.btnDelActivity.TabIndex = 20;
            this.btnDelActivity.Text = "Delete Activity";
            this.btnDelActivity.UseVisualStyleBackColor = false;
            this.btnDelActivity.Click += new System.EventHandler(this.btnDelActivity_Click);
            // 
            // lstActivities
            // 
            this.lstActivities.FormattingEnabled = true;
            this.lstActivities.Location = new System.Drawing.Point(6, 42);
            this.lstActivities.Name = "lstActivities";
            this.lstActivities.Size = new System.Drawing.Size(371, 82);
            this.lstActivities.TabIndex = 19;
            this.lstActivities.DoubleClick += new System.EventHandler(this.lstActivities_DoubleClick);
            // 
            // cboActivityType
            // 
            this.cboActivityType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActivityType.FormattingEnabled = true;
            this.cboActivityType.Location = new System.Drawing.Point(85, 135);
            this.cboActivityType.Name = "cboActivityType";
            this.cboActivityType.Size = new System.Drawing.Size(104, 21);
            this.cboActivityType.TabIndex = 18;
            // 
            // btnModActivity
            // 
            this.btnModActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnModActivity.Location = new System.Drawing.Point(195, 130);
            this.btnModActivity.Name = "btnModActivity";
            this.btnModActivity.Size = new System.Drawing.Size(87, 28);
            this.btnModActivity.TabIndex = 17;
            this.btnModActivity.Text = "Modify Activity";
            this.btnModActivity.UseVisualStyleBackColor = false;
            this.btnModActivity.Click += new System.EventHandler(this.btnModActivity_Click);
            // 
            // btnNewActivity
            // 
            this.btnNewActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNewActivity.Location = new System.Drawing.Point(5, 130);
            this.btnNewActivity.Name = "btnNewActivity";
            this.btnNewActivity.Size = new System.Drawing.Size(74, 28);
            this.btnNewActivity.TabIndex = 16;
            this.btnNewActivity.Text = "New Activity";
            this.btnNewActivity.UseVisualStyleBackColor = false;
            this.btnNewActivity.Click += new System.EventHandler(this.btnNewActivity_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOK.Location = new System.Drawing.Point(269, 12);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(125, 29);
            this.btnOK.TabIndex = 17;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Vehicle Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Make:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Rego:";
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(72, 41);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(129, 20);
            this.txtMake.TabIndex = 19;
            this.txtMake.TextChanged += new System.EventHandler(this.txtMake_TextChanged);
            this.txtMake.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMake_KeyDown);
            // 
            // txtRego
            // 
            this.txtRego.Location = new System.Drawing.Point(72, 12);
            this.txtRego.Name = "txtRego";
            this.txtRego.Size = new System.Drawing.Size(101, 20);
            this.txtRego.TabIndex = 18;
            this.txtRego.TextChanged += new System.EventHandler(this.txtRego_TextChanged);
            this.txtRego.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRego_KeyDown);
            // 
            // cboTrans
            // 
            this.cboTrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrans.FormattingEnabled = true;
            this.cboTrans.Location = new System.Drawing.Point(265, 99);
            this.cboTrans.Name = "cboTrans";
            this.cboTrans.Size = new System.Drawing.Size(124, 21);
            this.cboTrans.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Model:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(72, 70);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(129, 20);
            this.txtModel.TabIndex = 25;
            this.txtModel.TextChanged += new System.EventHandler(this.txtModel_TextChanged);
            this.txtModel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtModel_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Trans:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Year:";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(72, 99);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(129, 20);
            this.txtYear.TabIndex = 28;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            this.txtYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtYear_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Daily Rate $";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(72, 127);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(129, 20);
            this.txtRate.TabIndex = 30;
            this.txtRate.TextChanged += new System.EventHandler(this.txtRate_TextChanged);
            this.txtRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRate_KeyDown);
            // 
            // cboVehicleType
            // 
            this.cboVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVehicleType.FormattingEnabled = true;
            this.cboVehicleType.Location = new System.Drawing.Point(295, 127);
            this.cboVehicleType.Name = "cboVehicleType";
            this.cboVehicleType.Size = new System.Drawing.Size(93, 21);
            this.cboVehicleType.TabIndex = 32;
            // 
            // ssVehicle
            // 
            this.ssVehicle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus,
            this.tssValue});
            this.ssVehicle.Location = new System.Drawing.Point(0, 337);
            this.ssVehicle.Name = "ssVehicle";
            this.ssVehicle.Size = new System.Drawing.Size(407, 22);
            this.ssVehicle.SizingGrip = false;
            this.ssVehicle.TabIndex = 33;
            this.ssVehicle.Text = "statusStrip1";
            // 
            // tssStatus
            // 
            this.tssStatus.BackColor = System.Drawing.Color.White;
            this.tssStatus.ForeColor = System.Drawing.Color.Black;
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(325, 17);
            this.tssStatus.Spring = true;
            this.tssStatus.Text = "Status: Idle";
            this.tssStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tssValue
            // 
            this.tssValue.BackColor = System.Drawing.Color.White;
            this.tssValue.ForeColor = System.Drawing.Color.Green;
            this.tssValue.Name = "tssValue";
            this.tssValue.Size = new System.Drawing.Size(67, 17);
            this.tssValue.Text = "Total: $0.00";
            // 
            // FrmVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 359);
            this.Controls.Add(this.ssVehicle);
            this.Controls.Add(this.cboVehicleType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.cboTrans);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtRego);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbActivityLog);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmVehicle";
            this.Text = "Vehicle Details";
            this.gbActivityLog.ResumeLayout(false);
            this.gbActivityLog.PerformLayout();
            this.ssVehicle.ResumeLayout(false);
            this.ssVehicle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbActivityLog;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.ComboBox cboSortChoice;
        private System.Windows.Forms.Label lblHeaders;
        private System.Windows.Forms.Button btnDelActivity;
        private System.Windows.Forms.ListBox lstActivities;
        private System.Windows.Forms.ComboBox cboActivityType;
        private System.Windows.Forms.Button btnModActivity;
        private System.Windows.Forms.Button btnNewActivity;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtRego;
        private System.Windows.Forms.ComboBox cboTrans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.ComboBox cboVehicleType;
        private System.Windows.Forms.StatusStrip ssVehicle;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tssValue;
    }
}