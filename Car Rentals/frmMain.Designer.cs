namespace Car_Rentals
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.lstVehicles = new System.Windows.Forms.ListBox();
            this.btnEditVehicle = new System.Windows.Forms.Button();
            this.btnDeleteVehicle = new System.Windows.Forms.Button();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.ttpFindVehicle = new System.Windows.Forms.ToolTip(this.components);
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnpbFindRego = new System.Windows.Forms.PictureBox();
            this.lblRego = new System.Windows.Forms.Label();
            this.lblQuickView = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNotifications = new System.Windows.Forms.Label();
            this.lstNotifications = new System.Windows.Forms.ListBox();
            this.btnClrNotifications = new System.Windows.Forms.Button();
            this.btnDltNotification = new System.Windows.Forms.Button();
            this.btnNotification = new System.Windows.Forms.Button();
            this.tmrNotifications = new System.Windows.Forms.Timer(this.components);
            this.ssMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnpbFindRego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddVehicle.Location = new System.Drawing.Point(12, 191);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(81, 28);
            this.btnAddVehicle.TabIndex = 0;
            this.btnAddVehicle.Text = "Add Vehicle";
            this.btnAddVehicle.UseVisualStyleBackColor = false;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.Location = new System.Drawing.Point(196, 191);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 28);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblVehicle
            // 
            this.lblVehicle.BackColor = System.Drawing.Color.White;
            this.lblVehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVehicle.ForeColor = System.Drawing.Color.Black;
            this.lblVehicle.Location = new System.Drawing.Point(168, 25);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(120, 124);
            this.lblVehicle.TabIndex = 3;
            // 
            // lstVehicles
            // 
            this.lstVehicles.ForeColor = System.Drawing.Color.Black;
            this.lstVehicles.FormattingEnabled = true;
            this.lstVehicles.Location = new System.Drawing.Point(12, 25);
            this.lstVehicles.Name = "lstVehicles";
            this.lstVehicles.Size = new System.Drawing.Size(150, 95);
            this.lstVehicles.Sorted = true;
            this.lstVehicles.TabIndex = 4;
            this.lstVehicles.SelectedIndexChanged += new System.EventHandler(this.lstVehilces_SelectedIndexChanged);
            this.lstVehicles.DoubleClick += new System.EventHandler(this.lstVehicles_DoubleClick);
            // 
            // btnEditVehicle
            // 
            this.btnEditVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEditVehicle.Location = new System.Drawing.Point(12, 152);
            this.btnEditVehicle.Name = "btnEditVehicle";
            this.btnEditVehicle.Size = new System.Drawing.Size(276, 35);
            this.btnEditVehicle.TabIndex = 5;
            this.btnEditVehicle.Text = "Manage Selected Vehicle";
            this.btnEditVehicle.UseVisualStyleBackColor = false;
            this.btnEditVehicle.Click += new System.EventHandler(this.btnEditVehicle_Click);
            // 
            // btnDeleteVehicle
            // 
            this.btnDeleteVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDeleteVehicle.Location = new System.Drawing.Point(99, 191);
            this.btnDeleteVehicle.Name = "btnDeleteVehicle";
            this.btnDeleteVehicle.Size = new System.Drawing.Size(91, 28);
            this.btnDeleteVehicle.TabIndex = 6;
            this.btnDeleteVehicle.Text = "Delete Vehicle";
            this.btnDeleteVehicle.UseVisualStyleBackColor = false;
            this.btnDeleteVehicle.Click += new System.EventHandler(this.btnDeleteVehicle_Click);
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus,
            this.tssValue});
            this.ssMain.Location = new System.Drawing.Point(0, 381);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(568, 22);
            this.ssMain.SizingGrip = false;
            this.ssMain.TabIndex = 7;
            this.ssMain.Text = "statusStrip1";
            // 
            // tssStatus
            // 
            this.tssStatus.BackColor = System.Drawing.Color.White;
            this.tssStatus.ForeColor = System.Drawing.Color.Black;
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(487, 17);
            this.tssStatus.Spring = true;
            this.tssStatus.Text = "Status: Idle";
            this.tssStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tssValue
            // 
            this.tssValue.BackColor = System.Drawing.Color.White;
            this.tssValue.ForeColor = System.Drawing.Color.Green;
            this.tssValue.Name = "tssValue";
            this.tssValue.Size = new System.Drawing.Size(66, 17);
            this.tssValue.Text = "Total: $0.00";
            // 
            // txtFind
            // 
            this.txtFind.ForeColor = System.Drawing.Color.Black;
            this.txtFind.Location = new System.Drawing.Point(12, 126);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(118, 20);
            this.txtFind.TabIndex = 8;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            this.txtFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyDown);
            this.txtFind.Leave += new System.EventHandler(this.txtFind_Leave);
            // 
            // btnpbFindRego
            // 
            this.btnpbFindRego.Image = ((System.Drawing.Image)(resources.GetObject("btnpbFindRego.Image")));
            this.btnpbFindRego.Location = new System.Drawing.Point(130, 126);
            this.btnpbFindRego.Name = "btnpbFindRego";
            this.btnpbFindRego.Size = new System.Drawing.Size(32, 20);
            this.btnpbFindRego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnpbFindRego.TabIndex = 10;
            this.btnpbFindRego.TabStop = false;
            this.btnpbFindRego.Click += new System.EventHandler(this.btnpbFindRego_Click);
            // 
            // lblRego
            // 
            this.lblRego.AutoSize = true;
            this.lblRego.BackColor = System.Drawing.Color.Transparent;
            this.lblRego.ForeColor = System.Drawing.Color.Black;
            this.lblRego.Location = new System.Drawing.Point(9, 9);
            this.lblRego.Name = "lblRego";
            this.lblRego.Size = new System.Drawing.Size(73, 13);
            this.lblRego.TabIndex = 11;
            this.lblRego.Text = "Registration #";
            // 
            // lblQuickView
            // 
            this.lblQuickView.AutoSize = true;
            this.lblQuickView.ForeColor = System.Drawing.Color.Black;
            this.lblQuickView.Location = new System.Drawing.Point(165, 9);
            this.lblQuickView.Name = "lblQuickView";
            this.lblQuickView.Size = new System.Drawing.Size(61, 13);
            this.lblQuickView.TabIndex = 12;
            this.lblQuickView.Text = "Quick View";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(303, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lblNotifications
            // 
            this.lblNotifications.AutoSize = true;
            this.lblNotifications.Location = new System.Drawing.Point(12, 229);
            this.lblNotifications.Name = "lblNotifications";
            this.lblNotifications.Size = new System.Drawing.Size(129, 13);
            this.lblNotifications.TabIndex = 14;
            this.lblNotifications.Text = "Hire Booking Notifications";
            // 
            // lstNotifications
            // 
            this.lstNotifications.FormattingEnabled = true;
            this.lstNotifications.Location = new System.Drawing.Point(12, 245);
            this.lstNotifications.Name = "lstNotifications";
            this.lstNotifications.Size = new System.Drawing.Size(546, 95);
            this.lstNotifications.TabIndex = 20;
            // 
            // btnClrNotifications
            // 
            this.btnClrNotifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClrNotifications.Location = new System.Drawing.Point(430, 346);
            this.btnClrNotifications.Name = "btnClrNotifications";
            this.btnClrNotifications.Size = new System.Drawing.Size(128, 28);
            this.btnClrNotifications.TabIndex = 23;
            this.btnClrNotifications.Text = "Clear Notifications";
            this.btnClrNotifications.UseVisualStyleBackColor = false;
            this.btnClrNotifications.Click += new System.EventHandler(this.btnClrNotifications_Click);
            // 
            // btnDltNotification
            // 
            this.btnDltNotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDltNotification.Location = new System.Drawing.Point(296, 346);
            this.btnDltNotification.Name = "btnDltNotification";
            this.btnDltNotification.Size = new System.Drawing.Size(128, 28);
            this.btnDltNotification.TabIndex = 22;
            this.btnDltNotification.Text = "Delete Notification";
            this.btnDltNotification.UseVisualStyleBackColor = false;
            this.btnDltNotification.Click += new System.EventHandler(this.btnDltNotification_Click);
            // 
            // btnNotification
            // 
            this.btnNotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNotification.Location = new System.Drawing.Point(12, 346);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Size = new System.Drawing.Size(178, 28);
            this.btnNotification.TabIndex = 21;
            this.btnNotification.Text = "Manage Vehicle Notification";
            this.btnNotification.UseVisualStyleBackColor = false;
            this.btnNotification.Click += new System.EventHandler(this.btnNotification_Click);
            // 
            // tmrNotifications
            // 
            this.tmrNotifications.Enabled = true;
            this.tmrNotifications.Interval = 5000;
            this.tmrNotifications.Tick += new System.EventHandler(this.tmrNotifications_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(568, 403);
            this.Controls.Add(this.btnClrNotifications);
            this.Controls.Add(this.btnDltNotification);
            this.Controls.Add(this.btnNotification);
            this.Controls.Add(this.lstNotifications);
            this.Controls.Add(this.lblNotifications);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblQuickView);
            this.Controls.Add(this.lblRego);
            this.Controls.Add(this.btnpbFindRego);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.btnDeleteVehicle);
            this.Controls.Add(this.btnEditVehicle);
            this.Controls.Add(this.lstVehicles);
            this.Controls.Add(this.lblVehicle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddVehicle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Downtown Vehicle Rentals";
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnpbFindRego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.ListBox lstVehicles;
        private System.Windows.Forms.Button btnEditVehicle;
        private System.Windows.Forms.Button btnDeleteVehicle;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tssValue;
        private System.Windows.Forms.ToolTip ttpFindVehicle;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.PictureBox btnpbFindRego;
        private System.Windows.Forms.Label lblRego;
        private System.Windows.Forms.Label lblQuickView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNotifications;
        private System.Windows.Forms.ListBox lstNotifications;
        private System.Windows.Forms.Button btnClrNotifications;
        private System.Windows.Forms.Button btnDltNotification;
        private System.Windows.Forms.Button btnNotification;
        private System.Windows.Forms.Timer tmrNotifications;
    }
}

