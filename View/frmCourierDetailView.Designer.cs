namespace POS_SYSTEM.View
{
    partial class frmCourierDetailView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.elipsTable = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dataDelivery = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInvoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCourier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDateSent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTimeSent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDateDelivered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTimeDelivered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInformation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAll = new Guna.UI2.WinForms.Guna2Button();
            this.btn5YearDate = new Guna.UI2.WinForms.Guna2Button();
            this.btnYearDate = new Guna.UI2.WinForms.Guna2Button();
            this.btnTodayDate = new Guna.UI2.WinForms.Guna2Button();
            this.btnWeekDate = new Guna.UI2.WinForms.Guna2Button();
            this.btnMonthDate = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataDelivery)).BeginInit();
            this.SuspendLayout();
            // 
            // elipsTable
            // 
            this.elipsTable.BorderRadius = 30;
            this.elipsTable.TargetControl = this.dataDelivery;
            // 
            // dataDelivery
            // 
            this.dataDelivery.AllowUserToAddRows = false;
            this.dataDelivery.AllowUserToDeleteRows = false;
            this.dataDelivery.AllowUserToOrderColumns = true;
            this.dataDelivery.AllowUserToResizeColumns = false;
            this.dataDelivery.AllowUserToResizeRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            this.dataDelivery.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dataDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataDelivery.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(169)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDelivery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dataDelivery.ColumnHeadersHeight = 50;
            this.dataDelivery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvInvoiceID,
            this.dgvCustomer,
            this.dgvCourier,
            this.dgvAddress,
            this.dgvDateSent,
            this.dgvTimeSent,
            this.dgvCost,
            this.dgvDateDelivered,
            this.dgvTimeDelivered,
            this.dgvStatus,
            this.dgvInformation});
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataDelivery.DefaultCellStyle = dataGridViewCellStyle24;
            this.dataDelivery.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataDelivery.Location = new System.Drawing.Point(49, 225);
            this.dataDelivery.Name = "dataDelivery";
            this.dataDelivery.ReadOnly = true;
            this.dataDelivery.RowHeadersVisible = false;
            this.dataDelivery.Size = new System.Drawing.Size(1226, 335);
            this.dataDelivery.TabIndex = 8;
            this.dataDelivery.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataDelivery.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataDelivery.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataDelivery.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataDelivery.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataDelivery.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataDelivery.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataDelivery.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataDelivery.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataDelivery.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDelivery.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataDelivery.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataDelivery.ThemeStyle.HeaderStyle.Height = 50;
            this.dataDelivery.ThemeStyle.ReadOnly = true;
            this.dataDelivery.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataDelivery.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataDelivery.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDelivery.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataDelivery.ThemeStyle.RowsStyle.Height = 22;
            this.dataDelivery.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataDelivery.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dgvID
            // 
            this.dgvID.FillWeight = 30F;
            this.dgvID.HeaderText = "";
            this.dgvID.Name = "dgvID";
            this.dgvID.ReadOnly = true;
            this.dgvID.Visible = false;
            // 
            // dgvInvoiceID
            // 
            this.dgvInvoiceID.HeaderText = "Invoice ID";
            this.dgvInvoiceID.Name = "dgvInvoiceID";
            this.dgvInvoiceID.ReadOnly = true;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.HeaderText = "Customer";
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            // 
            // dgvCourier
            // 
            this.dgvCourier.HeaderText = "Courier";
            this.dgvCourier.Name = "dgvCourier";
            this.dgvCourier.ReadOnly = true;
            this.dgvCourier.Visible = false;
            // 
            // dgvAddress
            // 
            this.dgvAddress.HeaderText = "Address";
            this.dgvAddress.Name = "dgvAddress";
            this.dgvAddress.ReadOnly = true;
            // 
            // dgvDateSent
            // 
            this.dgvDateSent.HeaderText = "Date Sent";
            this.dgvDateSent.Name = "dgvDateSent";
            this.dgvDateSent.ReadOnly = true;
            // 
            // dgvTimeSent
            // 
            this.dgvTimeSent.HeaderText = "Time Sent";
            this.dgvTimeSent.Name = "dgvTimeSent";
            this.dgvTimeSent.ReadOnly = true;
            // 
            // dgvCost
            // 
            this.dgvCost.HeaderText = "Cost";
            this.dgvCost.Name = "dgvCost";
            this.dgvCost.ReadOnly = true;
            // 
            // dgvDateDelivered
            // 
            this.dgvDateDelivered.HeaderText = "Date Delivered";
            this.dgvDateDelivered.Name = "dgvDateDelivered";
            this.dgvDateDelivered.ReadOnly = true;
            // 
            // dgvTimeDelivered
            // 
            this.dgvTimeDelivered.HeaderText = "Time Delivered";
            this.dgvTimeDelivered.Name = "dgvTimeDelivered";
            this.dgvTimeDelivered.ReadOnly = true;
            // 
            // dgvStatus
            // 
            this.dgvStatus.HeaderText = "Status";
            this.dgvStatus.Name = "dgvStatus";
            this.dgvStatus.ReadOnly = true;
            // 
            // dgvInformation
            // 
            this.dgvInformation.HeaderText = "Info";
            this.dgvInformation.Name = "dgvInformation";
            this.dgvInformation.ReadOnly = true;
            // 
            // btnAll
            // 
            this.btnAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAll.Animated = true;
            this.btnAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(77)))), ((int)(((byte)(166)))));
            this.btnAll.BorderThickness = 2;
            this.btnAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAll.FillColor = System.Drawing.Color.Transparent;
            this.btnAll.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.Black;
            this.btnAll.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAll.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnAll.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAll.Location = new System.Drawing.Point(49, 161);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(141, 40);
            this.btnAll.TabIndex = 69;
            this.btnAll.Text = "ALL DATA";
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btn5YearDate
            // 
            this.btn5YearDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn5YearDate.Animated = true;
            this.btn5YearDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(77)))), ((int)(((byte)(166)))));
            this.btn5YearDate.BorderThickness = 2;
            this.btn5YearDate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn5YearDate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn5YearDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn5YearDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn5YearDate.FillColor = System.Drawing.Color.Transparent;
            this.btn5YearDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5YearDate.ForeColor = System.Drawing.Color.Black;
            this.btn5YearDate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn5YearDate.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn5YearDate.ImageSize = new System.Drawing.Size(25, 25);
            this.btn5YearDate.Location = new System.Drawing.Point(780, 161);
            this.btn5YearDate.Name = "btn5YearDate";
            this.btn5YearDate.Size = new System.Drawing.Size(141, 40);
            this.btn5YearDate.TabIndex = 68;
            this.btn5YearDate.Text = "THIS 5 YEAR";
            this.btn5YearDate.Click += new System.EventHandler(this.btn5YearDate_Click);
            // 
            // btnYearDate
            // 
            this.btnYearDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYearDate.Animated = true;
            this.btnYearDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(77)))), ((int)(((byte)(166)))));
            this.btnYearDate.BorderThickness = 2;
            this.btnYearDate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnYearDate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnYearDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnYearDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnYearDate.FillColor = System.Drawing.Color.Transparent;
            this.btnYearDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYearDate.ForeColor = System.Drawing.Color.Black;
            this.btnYearDate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnYearDate.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnYearDate.ImageSize = new System.Drawing.Size(25, 25);
            this.btnYearDate.Location = new System.Drawing.Point(634, 161);
            this.btnYearDate.Name = "btnYearDate";
            this.btnYearDate.Size = new System.Drawing.Size(141, 40);
            this.btnYearDate.TabIndex = 67;
            this.btnYearDate.Text = "THIS YEAR";
            this.btnYearDate.Click += new System.EventHandler(this.btnYearDate_Click);
            // 
            // btnTodayDate
            // 
            this.btnTodayDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTodayDate.Animated = true;
            this.btnTodayDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(77)))), ((int)(((byte)(166)))));
            this.btnTodayDate.BorderThickness = 2;
            this.btnTodayDate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTodayDate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTodayDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTodayDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTodayDate.FillColor = System.Drawing.Color.Transparent;
            this.btnTodayDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodayDate.ForeColor = System.Drawing.Color.Black;
            this.btnTodayDate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTodayDate.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnTodayDate.ImageSize = new System.Drawing.Size(25, 25);
            this.btnTodayDate.Location = new System.Drawing.Point(196, 161);
            this.btnTodayDate.Name = "btnTodayDate";
            this.btnTodayDate.Size = new System.Drawing.Size(141, 40);
            this.btnTodayDate.TabIndex = 66;
            this.btnTodayDate.Text = "TODAY";
            this.btnTodayDate.Click += new System.EventHandler(this.btnTodayDate_Click);
            // 
            // btnWeekDate
            // 
            this.btnWeekDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWeekDate.Animated = true;
            this.btnWeekDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(77)))), ((int)(((byte)(166)))));
            this.btnWeekDate.BorderThickness = 2;
            this.btnWeekDate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWeekDate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWeekDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWeekDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWeekDate.FillColor = System.Drawing.Color.Transparent;
            this.btnWeekDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeekDate.ForeColor = System.Drawing.Color.Black;
            this.btnWeekDate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnWeekDate.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnWeekDate.ImageSize = new System.Drawing.Size(25, 25);
            this.btnWeekDate.Location = new System.Drawing.Point(343, 161);
            this.btnWeekDate.Name = "btnWeekDate";
            this.btnWeekDate.Size = new System.Drawing.Size(141, 40);
            this.btnWeekDate.TabIndex = 65;
            this.btnWeekDate.Text = "LAST 7 DAYS";
            this.btnWeekDate.Click += new System.EventHandler(this.btnWeekDate_Click);
            // 
            // btnMonthDate
            // 
            this.btnMonthDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMonthDate.Animated = true;
            this.btnMonthDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(77)))), ((int)(((byte)(166)))));
            this.btnMonthDate.BorderThickness = 2;
            this.btnMonthDate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMonthDate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMonthDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMonthDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMonthDate.FillColor = System.Drawing.Color.Transparent;
            this.btnMonthDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthDate.ForeColor = System.Drawing.Color.Black;
            this.btnMonthDate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMonthDate.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnMonthDate.ImageSize = new System.Drawing.Size(25, 25);
            this.btnMonthDate.Location = new System.Drawing.Point(488, 161);
            this.btnMonthDate.Name = "btnMonthDate";
            this.btnMonthDate.Size = new System.Drawing.Size(141, 40);
            this.btnMonthDate.TabIndex = 64;
            this.btnMonthDate.Text = "THIS MONTH";
            this.btnMonthDate.Click += new System.EventHandler(this.btnMonthDate_Click);
            // 
            // frmCourierDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 700);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btn5YearDate);
            this.Controls.Add(this.btnYearDate);
            this.Controls.Add(this.btnTodayDate);
            this.Controls.Add(this.btnWeekDate);
            this.Controls.Add(this.btnMonthDate);
            this.Controls.Add(this.dataDelivery);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmCourierDetailView";
            this.Text = "frmCourierDetailView";
            this.Load += new System.EventHandler(this.frmCourierDetailView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDelivery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Elipse elipsTable;
        private Guna.UI2.WinForms.Guna2DataGridView dataDelivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInvoiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCourier;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDateSent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTimeSent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDateDelivered;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTimeDelivered;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInformation;
        public Guna.UI2.WinForms.Guna2Button btnAll;
        public Guna.UI2.WinForms.Guna2Button btn5YearDate;
        public Guna.UI2.WinForms.Guna2Button btnYearDate;
        public Guna.UI2.WinForms.Guna2Button btnTodayDate;
        public Guna.UI2.WinForms.Guna2Button btnWeekDate;
        public Guna.UI2.WinForms.Guna2Button btnMonthDate;
    }
}