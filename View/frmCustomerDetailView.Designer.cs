namespace POS_SYSTEM.View
{
    partial class frmCustomerDetailView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataCustomer = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInvoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDateSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInformation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elipsTable = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn5YearDate = new Guna.UI2.WinForms.Guna2Button();
            this.btnYearDate = new Guna.UI2.WinForms.Guna2Button();
            this.btnTodayDate = new Guna.UI2.WinForms.Guna2Button();
            this.btnWeekDate = new Guna.UI2.WinForms.Guna2Button();
            this.btnMonthDate = new Guna.UI2.WinForms.Guna2Button();
            this.btnAll = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataCustomer
            // 
            this.dataCustomer.AllowUserToAddRows = false;
            this.dataCustomer.AllowUserToDeleteRows = false;
            this.dataCustomer.AllowUserToOrderColumns = true;
            this.dataCustomer.AllowUserToResizeColumns = false;
            this.dataCustomer.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataCustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(169)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataCustomer.ColumnHeadersHeight = 50;
            this.dataCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvInvoiceID,
            this.dgvDateSale,
            this.dgvCustomer,
            this.dgvStaff,
            this.dgvProduct,
            this.dgvQty,
            this.dgvUnitPrice,
            this.dgvTotalPrice,
            this.dgvInformation});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataCustomer.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataCustomer.Location = new System.Drawing.Point(58, 221);
            this.dataCustomer.Name = "dataCustomer";
            this.dataCustomer.ReadOnly = true;
            this.dataCustomer.RowHeadersVisible = false;
            this.dataCustomer.Size = new System.Drawing.Size(1226, 335);
            this.dataCustomer.TabIndex = 9;
            this.dataCustomer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataCustomer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataCustomer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataCustomer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataCustomer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataCustomer.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataCustomer.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataCustomer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataCustomer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataCustomer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataCustomer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataCustomer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataCustomer.ThemeStyle.HeaderStyle.Height = 50;
            this.dataCustomer.ThemeStyle.ReadOnly = true;
            this.dataCustomer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataCustomer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataCustomer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataCustomer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataCustomer.ThemeStyle.RowsStyle.Height = 22;
            this.dataCustomer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataCustomer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            // dgvDateSale
            // 
            this.dgvDateSale.HeaderText = "Date Sale";
            this.dgvDateSale.Name = "dgvDateSale";
            this.dgvDateSale.ReadOnly = true;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.HeaderText = "Customer";
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.Visible = false;
            // 
            // dgvStaff
            // 
            this.dgvStaff.HeaderText = "Staff";
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            // 
            // dgvProduct
            // 
            this.dgvProduct.HeaderText = "Product";
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            // 
            // dgvQty
            // 
            this.dgvQty.HeaderText = "Qty";
            this.dgvQty.Name = "dgvQty";
            this.dgvQty.ReadOnly = true;
            // 
            // dgvUnitPrice
            // 
            this.dgvUnitPrice.HeaderText = "Unit Price";
            this.dgvUnitPrice.Name = "dgvUnitPrice";
            this.dgvUnitPrice.ReadOnly = true;
            // 
            // dgvTotalPrice
            // 
            this.dgvTotalPrice.HeaderText = "Total Price";
            this.dgvTotalPrice.Name = "dgvTotalPrice";
            this.dgvTotalPrice.ReadOnly = true;
            // 
            // dgvInformation
            // 
            this.dgvInformation.HeaderText = "Info";
            this.dgvInformation.Name = "dgvInformation";
            this.dgvInformation.ReadOnly = true;
            // 
            // elipsTable
            // 
            this.elipsTable.BorderRadius = 30;
            this.elipsTable.TargetControl = this.dataCustomer;
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
            this.btn5YearDate.Location = new System.Drawing.Point(789, 158);
            this.btn5YearDate.Name = "btn5YearDate";
            this.btn5YearDate.Size = new System.Drawing.Size(141, 40);
            this.btn5YearDate.TabIndex = 62;
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
            this.btnYearDate.Location = new System.Drawing.Point(643, 158);
            this.btnYearDate.Name = "btnYearDate";
            this.btnYearDate.Size = new System.Drawing.Size(141, 40);
            this.btnYearDate.TabIndex = 61;
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
            this.btnTodayDate.Location = new System.Drawing.Point(205, 158);
            this.btnTodayDate.Name = "btnTodayDate";
            this.btnTodayDate.Size = new System.Drawing.Size(141, 40);
            this.btnTodayDate.TabIndex = 58;
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
            this.btnWeekDate.Location = new System.Drawing.Point(352, 158);
            this.btnWeekDate.Name = "btnWeekDate";
            this.btnWeekDate.Size = new System.Drawing.Size(141, 40);
            this.btnWeekDate.TabIndex = 57;
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
            this.btnMonthDate.Location = new System.Drawing.Point(497, 158);
            this.btnMonthDate.Name = "btnMonthDate";
            this.btnMonthDate.Size = new System.Drawing.Size(141, 40);
            this.btnMonthDate.TabIndex = 56;
            this.btnMonthDate.Text = "THIS MONTH";
            this.btnMonthDate.Click += new System.EventHandler(this.btnMonthDate_Click);
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
            this.btnAll.Location = new System.Drawing.Point(58, 158);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(141, 40);
            this.btnAll.TabIndex = 63;
            this.btnAll.Text = "ALL DATA";
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // frmCustomerDetailView
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
            this.Controls.Add(this.dataCustomer);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmCustomerDetailView";
            this.Text = "frmCustomerDetailView";
            this.Load += new System.EventHandler(this.frmCustomerDetailView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataCustomer;
        public Guna.UI2.WinForms.Guna2Elipse elipsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInvoiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDateSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInformation;
        public Guna.UI2.WinForms.Guna2Button btn5YearDate;
        public Guna.UI2.WinForms.Guna2Button btnYearDate;
        public Guna.UI2.WinForms.Guna2Button btnTodayDate;
        public Guna.UI2.WinForms.Guna2Button btnWeekDate;
        public Guna.UI2.WinForms.Guna2Button btnMonthDate;
        public Guna.UI2.WinForms.Guna2Button btnAll;
    }
}