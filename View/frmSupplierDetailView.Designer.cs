namespace POS_SYSTEM.View
{
    partial class frmSupplierDetailView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.elipsTable = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dataCustomer = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAll = new Guna.UI2.WinForms.Guna2Button();
            this.btn5YearDate = new Guna.UI2.WinForms.Guna2Button();
            this.btnYearDate = new Guna.UI2.WinForms.Guna2Button();
            this.btnTodayDate = new Guna.UI2.WinForms.Guna2Button();
            this.btnWeekDate = new Guna.UI2.WinForms.Guna2Button();
            this.btnMonthDate = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // elipsTable
            // 
            this.elipsTable.BorderRadius = 30;
            this.elipsTable.TargetControl = this.dataCustomer;
            // 
            // dataCustomer
            // 
            this.dataCustomer.AllowUserToAddRows = false;
            this.dataCustomer.AllowUserToDeleteRows = false;
            this.dataCustomer.AllowUserToOrderColumns = true;
            this.dataCustomer.AllowUserToResizeColumns = false;
            this.dataCustomer.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.dataCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dataCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataCustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(169)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dataCustomer.ColumnHeadersHeight = 50;
            this.dataCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvProduct,
            this.dgvQty,
            this.dgvColi,
            this.dgvDate,
            this.dgvTIme,
            this.dgvPrice,
            this.dgvTotalPrice});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataCustomer.DefaultCellStyle = dataGridViewCellStyle21;
            this.dataCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataCustomer.Location = new System.Drawing.Point(56, 222);
            this.dataCustomer.Name = "dataCustomer";
            this.dataCustomer.ReadOnly = true;
            this.dataCustomer.RowHeadersVisible = false;
            this.dataCustomer.Size = new System.Drawing.Size(1226, 335);
            this.dataCustomer.TabIndex = 10;
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
            // dgvColi
            // 
            this.dgvColi.HeaderText = "Coli";
            this.dgvColi.Name = "dgvColi";
            this.dgvColi.ReadOnly = true;
            // 
            // dgvDate
            // 
            this.dgvDate.HeaderText = "Date";
            this.dgvDate.Name = "dgvDate";
            this.dgvDate.ReadOnly = true;
            // 
            // dgvTIme
            // 
            this.dgvTIme.HeaderText = "Time";
            this.dgvTIme.Name = "dgvTIme";
            this.dgvTIme.ReadOnly = true;
            // 
            // dgvPrice
            // 
            this.dgvPrice.HeaderText = "Price";
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.ReadOnly = true;
            // 
            // dgvTotalPrice
            // 
            this.dgvTotalPrice.HeaderText = "Total Price";
            this.dgvTotalPrice.Name = "dgvTotalPrice";
            this.dgvTotalPrice.ReadOnly = true;
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
            this.btnAll.Location = new System.Drawing.Point(56, 158);
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
            this.btn5YearDate.Location = new System.Drawing.Point(787, 158);
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
            this.btnYearDate.Location = new System.Drawing.Point(641, 158);
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
            this.btnTodayDate.Location = new System.Drawing.Point(203, 158);
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
            this.btnWeekDate.Location = new System.Drawing.Point(350, 158);
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
            this.btnMonthDate.Location = new System.Drawing.Point(495, 158);
            this.btnMonthDate.Name = "btnMonthDate";
            this.btnMonthDate.Size = new System.Drawing.Size(141, 40);
            this.btnMonthDate.TabIndex = 64;
            this.btnMonthDate.Text = "THIS MONTH";
            this.btnMonthDate.Click += new System.EventHandler(this.btnMonthDate_Click);
            // 
            // frmSupplierDetailView
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
            this.Name = "frmSupplierDetailView";
            this.Text = "frmSupplierDetailView";
            this.Load += new System.EventHandler(this.frmSupplierDetailView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Elipse elipsTable;
        private Guna.UI2.WinForms.Guna2DataGridView dataCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTotalPrice;
        public Guna.UI2.WinForms.Guna2Button btnAll;
        public Guna.UI2.WinForms.Guna2Button btn5YearDate;
        public Guna.UI2.WinForms.Guna2Button btnYearDate;
        public Guna.UI2.WinForms.Guna2Button btnTodayDate;
        public Guna.UI2.WinForms.Guna2Button btnWeekDate;
        public Guna.UI2.WinForms.Guna2Button btnMonthDate;
    }
}