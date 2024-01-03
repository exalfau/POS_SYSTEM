namespace POS_SYSTEM.Model
{
    partial class frmStockInAdd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateIn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblJoinDate = new System.Windows.Forms.Label();
            this.txtTimeIn = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTimeIn = new System.Windows.Forms.Label();
            this.btnBrowse = new Guna.UI2.WinForms.Guna2Button();
            this.lblPP = new System.Windows.Forms.Label();
            this.pictStockIn = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.comboProduct = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtColi = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblColi = new System.Windows.Forms.Label();
            this.lblInformation = new System.Windows.Forms.Label();
            this.txtInformation = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTPrice = new System.Windows.Forms.Label();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.elipsTable = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dataProduct = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvSR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIDProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNettPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.comboSupplier = new System.Windows.Forms.ComboBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.cbConfim = new Guna.UI2.WinForms.Guna2CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictStockIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dateIn
            // 
            this.dateIn.AutoRoundedCorners = true;
            this.dateIn.BorderRadius = 17;
            this.dateIn.Checked = true;
            this.dateIn.FillColor = System.Drawing.Color.White;
            this.dateIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateIn.Location = new System.Drawing.Point(361, 186);
            this.dateIn.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateIn.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateIn.Name = "dateIn";
            this.dateIn.Size = new System.Drawing.Size(250, 36);
            this.dateIn.TabIndex = 41;
            this.dateIn.Value = new System.DateTime(2023, 9, 20, 14, 30, 24, 405);
            // 
            // lblJoinDate
            // 
            this.lblJoinDate.AutoSize = true;
            this.lblJoinDate.BackColor = System.Drawing.Color.Transparent;
            this.lblJoinDate.ForeColor = System.Drawing.Color.Black;
            this.lblJoinDate.Location = new System.Drawing.Point(378, 160);
            this.lblJoinDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJoinDate.Name = "lblJoinDate";
            this.lblJoinDate.Size = new System.Drawing.Size(83, 24);
            this.lblJoinDate.TabIndex = 40;
            this.lblJoinDate.Text = "Date in";
            // 
            // txtTimeIn
            // 
            this.txtTimeIn.AutoRoundedCorners = true;
            this.txtTimeIn.AutoSize = true;
            this.txtTimeIn.BackColor = System.Drawing.Color.Transparent;
            this.txtTimeIn.BorderRadius = 19;
            this.txtTimeIn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimeIn.DefaultText = "";
            this.txtTimeIn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimeIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimeIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimeIn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimeIn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimeIn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtTimeIn.ForeColor = System.Drawing.Color.Black;
            this.txtTimeIn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimeIn.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtTimeIn.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtTimeIn.Location = new System.Drawing.Point(677, 186);
            this.txtTimeIn.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimeIn.Name = "txtTimeIn";
            this.txtTimeIn.PasswordChar = '\0';
            this.txtTimeIn.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTimeIn.PlaceholderText = "00:00";
            this.txtTimeIn.SelectedText = "";
            this.txtTimeIn.Size = new System.Drawing.Size(250, 40);
            this.txtTimeIn.TabIndex = 45;
            this.txtTimeIn.Tag = "time";
            // 
            // lblTimeIn
            // 
            this.lblTimeIn.AutoSize = true;
            this.lblTimeIn.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeIn.ForeColor = System.Drawing.Color.Black;
            this.lblTimeIn.Location = new System.Drawing.Point(687, 160);
            this.lblTimeIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimeIn.Name = "lblTimeIn";
            this.lblTimeIn.Size = new System.Drawing.Size(80, 24);
            this.lblTimeIn.TabIndex = 44;
            this.lblTimeIn.Text = "Time In";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Animated = true;
            this.btnBrowse.AutoRoundedCorners = true;
            this.btnBrowse.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowse.BorderRadius = 19;
            this.btnBrowse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBrowse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBrowse.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnBrowse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBrowse.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnBrowse.ImageSize = new System.Drawing.Size(25, 25);
            this.btnBrowse.Location = new System.Drawing.Point(1006, 393);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(140, 40);
            this.btnBrowse.TabIndex = 61;
            this.btnBrowse.Text = "BROWSE";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblPP
            // 
            this.lblPP.AutoSize = true;
            this.lblPP.BackColor = System.Drawing.Color.Transparent;
            this.lblPP.ForeColor = System.Drawing.Color.Black;
            this.lblPP.Location = new System.Drawing.Point(990, 160);
            this.lblPP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPP.Name = "lblPP";
            this.lblPP.Size = new System.Drawing.Size(163, 24);
            this.lblPP.TabIndex = 60;
            this.lblPP.Text = "Stock in Picture";
            // 
            // pictStockIn
            // 
            this.pictStockIn.BackColor = System.Drawing.Color.Transparent;
            this.pictStockIn.Image = global::POS_SYSTEM.Properties.Resources.product;
            this.pictStockIn.ImageRotate = 0F;
            this.pictStockIn.Location = new System.Drawing.Point(988, 199);
            this.pictStockIn.Name = "pictStockIn";
            this.pictStockIn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictStockIn.Size = new System.Drawing.Size(180, 180);
            this.pictStockIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictStockIn.TabIndex = 59;
            this.pictStockIn.TabStop = false;
            this.pictStockIn.UseTransparentBackground = true;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblProduct.ForeColor = System.Drawing.Color.Black;
            this.lblProduct.Location = new System.Drawing.Point(56, 266);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(90, 24);
            this.lblProduct.TabIndex = 63;
            this.lblProduct.Text = "Product";
            // 
            // comboProduct
            // 
            this.comboProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboProduct.DropDownHeight = 105;
            this.comboProduct.Enabled = false;
            this.comboProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboProduct.FormattingEnabled = true;
            this.comboProduct.IntegralHeight = false;
            this.comboProduct.Location = new System.Drawing.Point(39, 292);
            this.comboProduct.Name = "comboProduct";
            this.comboProduct.Size = new System.Drawing.Size(250, 32);
            this.comboProduct.TabIndex = 62;
            this.comboProduct.Tag = "com2";
            this.comboProduct.TextChanged += new System.EventHandler(this.comboProduct_TextChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.AutoRoundedCorners = true;
            this.txtQuantity.AutoSize = true;
            this.txtQuantity.BackColor = System.Drawing.Color.Transparent;
            this.txtQuantity.BorderRadius = 19;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "";
            this.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.Enabled = false;
            this.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtQuantity.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtQuantity.Location = new System.Drawing.Point(355, 292);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtQuantity.PlaceholderText = "100";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(250, 40);
            this.txtQuantity.TabIndex = 69;
            this.txtQuantity.Tag = "n2";
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.ForeColor = System.Drawing.Color.Black;
            this.lblQuantity.Location = new System.Drawing.Point(365, 266);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(120, 24);
            this.lblQuantity.TabIndex = 68;
            this.lblQuantity.Text = "Quantity In";
            // 
            // txtColi
            // 
            this.txtColi.AutoRoundedCorners = true;
            this.txtColi.AutoSize = true;
            this.txtColi.BackColor = System.Drawing.Color.Transparent;
            this.txtColi.BorderRadius = 19;
            this.txtColi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtColi.DefaultText = "";
            this.txtColi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtColi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtColi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtColi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtColi.Enabled = false;
            this.txtColi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtColi.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtColi.ForeColor = System.Drawing.Color.Black;
            this.txtColi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtColi.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtColi.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtColi.Location = new System.Drawing.Point(680, 292);
            this.txtColi.Margin = new System.Windows.Forms.Padding(2);
            this.txtColi.Name = "txtColi";
            this.txtColi.PasswordChar = '\0';
            this.txtColi.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtColi.PlaceholderText = "100";
            this.txtColi.SelectedText = "";
            this.txtColi.Size = new System.Drawing.Size(250, 40);
            this.txtColi.TabIndex = 71;
            this.txtColi.Tag = "n2";
            // 
            // lblColi
            // 
            this.lblColi.AutoSize = true;
            this.lblColi.BackColor = System.Drawing.Color.Transparent;
            this.lblColi.ForeColor = System.Drawing.Color.Black;
            this.lblColi.Location = new System.Drawing.Point(690, 266);
            this.lblColi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColi.Name = "lblColi";
            this.lblColi.Size = new System.Drawing.Size(73, 24);
            this.lblColi.TabIndex = 70;
            this.lblColi.Text = "Coli In";
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.BackColor = System.Drawing.Color.Transparent;
            this.lblInformation.ForeColor = System.Drawing.Color.Black;
            this.lblInformation.Location = new System.Drawing.Point(690, 369);
            this.lblInformation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(49, 24);
            this.lblInformation.TabIndex = 73;
            this.lblInformation.Text = "Info";
            // 
            // txtInformation
            // 
            this.txtInformation.AutoRoundedCorners = true;
            this.txtInformation.AutoSize = true;
            this.txtInformation.BackColor = System.Drawing.Color.Transparent;
            this.txtInformation.BorderRadius = 19;
            this.txtInformation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInformation.DefaultText = "";
            this.txtInformation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInformation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInformation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInformation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInformation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInformation.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtInformation.ForeColor = System.Drawing.Color.Black;
            this.txtInformation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInformation.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtInformation.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtInformation.Location = new System.Drawing.Point(680, 395);
            this.txtInformation.Margin = new System.Windows.Forms.Padding(2);
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.PasswordChar = '\0';
            this.txtInformation.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtInformation.PlaceholderText = "";
            this.txtInformation.SelectedText = "";
            this.txtInformation.Size = new System.Drawing.Size(250, 40);
            this.txtInformation.TabIndex = 72;
            this.txtInformation.Tag = "";
            // 
            // txtTPrice
            // 
            this.txtTPrice.AutoRoundedCorners = true;
            this.txtTPrice.AutoSize = true;
            this.txtTPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtTPrice.BorderRadius = 19;
            this.txtTPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTPrice.DefaultText = "";
            this.txtTPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTPrice.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtTPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTPrice.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtTPrice.ForeColor = System.Drawing.Color.Black;
            this.txtTPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTPrice.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtTPrice.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtTPrice.Location = new System.Drawing.Point(355, 393);
            this.txtTPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtTPrice.Name = "txtTPrice";
            this.txtTPrice.PasswordChar = '\0';
            this.txtTPrice.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTPrice.PlaceholderText = "auto complete";
            this.txtTPrice.ReadOnly = true;
            this.txtTPrice.SelectedText = "";
            this.txtTPrice.Size = new System.Drawing.Size(250, 40);
            this.txtTPrice.TabIndex = 77;
            this.txtTPrice.Tag = "t2";
            // 
            // lblTPrice
            // 
            this.lblTPrice.AutoSize = true;
            this.lblTPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTPrice.ForeColor = System.Drawing.Color.Black;
            this.lblTPrice.Location = new System.Drawing.Point(365, 369);
            this.lblTPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTPrice.Name = "lblTPrice";
            this.lblTPrice.Size = new System.Drawing.Size(113, 24);
            this.lblTPrice.TabIndex = 76;
            this.lblTPrice.Text = "Total Price";
            // 
            // txtPrice
            // 
            this.txtPrice.AutoRoundedCorners = true;
            this.txtPrice.AutoSize = true;
            this.txtPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtPrice.BorderRadius = 19;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtPrice.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtPrice.Location = new System.Drawing.Point(39, 395);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPrice.PlaceholderText = "auto complete";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(250, 40);
            this.txtPrice.TabIndex = 75;
            this.txtPrice.Tag = "t2";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(56, 369);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(59, 24);
            this.lblPrice.TabIndex = 74;
            this.lblPrice.Text = "Price";
            // 
            // elipsTable
            // 
            this.elipsTable.BorderRadius = 30;
            this.elipsTable.TargetControl = this.dataProduct;
            // 
            // dataProduct
            // 
            this.dataProduct.AllowUserToAddRows = false;
            this.dataProduct.AllowUserToDeleteRows = false;
            this.dataProduct.AllowUserToOrderColumns = true;
            this.dataProduct.AllowUserToResizeColumns = false;
            this.dataProduct.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dataProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(169)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataProduct.ColumnHeadersHeight = 50;
            this.dataProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSR,
            this.dgvID,
            this.dgvIDProduct,
            this.dgvName,
            this.dgvQty,
            this.dgvColi,
            this.dgvNettPrice,
            this.dgvTotalPrice,
            this.dgvEdit});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataProduct.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataProduct.Location = new System.Drawing.Point(39, 537);
            this.dataProduct.Name = "dataProduct";
            this.dataProduct.RowHeadersVisible = false;
            this.dataProduct.Size = new System.Drawing.Size(1131, 402);
            this.dataProduct.TabIndex = 78;
            this.dataProduct.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataProduct.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataProduct.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataProduct.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataProduct.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataProduct.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataProduct.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataProduct.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataProduct.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataProduct.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataProduct.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataProduct.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataProduct.ThemeStyle.HeaderStyle.Height = 50;
            this.dataProduct.ThemeStyle.ReadOnly = false;
            this.dataProduct.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataProduct.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataProduct.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataProduct.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataProduct.ThemeStyle.RowsStyle.Height = 22;
            this.dataProduct.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataProduct.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProduct_CellClick);
            this.dataProduct.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataProduct_CellFormatting);
            // 
            // dgvSR
            // 
            this.dgvSR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvSR.FillWeight = 50F;
            this.dgvSR.HeaderText = "SR#";
            this.dgvSR.Name = "dgvSR";
            this.dgvSR.Width = 50;
            // 
            // dgvID
            // 
            this.dgvID.FillWeight = 30F;
            this.dgvID.HeaderText = "";
            this.dgvID.Name = "dgvID";
            this.dgvID.Visible = false;
            // 
            // dgvIDProduct
            // 
            this.dgvIDProduct.FillWeight = 150F;
            this.dgvIDProduct.HeaderText = "ID Product";
            this.dgvIDProduct.Name = "dgvIDProduct";
            this.dgvIDProduct.Visible = false;
            // 
            // dgvName
            // 
            this.dgvName.FillWeight = 150F;
            this.dgvName.HeaderText = "Name";
            this.dgvName.Name = "dgvName";
            // 
            // dgvQty
            // 
            this.dgvQty.HeaderText = "Qty";
            this.dgvQty.Name = "dgvQty";
            // 
            // dgvColi
            // 
            this.dgvColi.HeaderText = "Coli";
            this.dgvColi.Name = "dgvColi";
            // 
            // dgvNettPrice
            // 
            this.dgvNettPrice.FillWeight = 120F;
            this.dgvNettPrice.HeaderText = "Nett Price";
            this.dgvNettPrice.Name = "dgvNettPrice";
            // 
            // dgvTotalPrice
            // 
            this.dgvTotalPrice.FillWeight = 120F;
            this.dgvTotalPrice.HeaderText = "Total Price";
            this.dgvTotalPrice.Name = "dgvTotalPrice";
            // 
            // dgvEdit
            // 
            this.dgvEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvEdit.FillWeight = 30F;
            this.dgvEdit.HeaderText = "";
            this.dgvEdit.Image = global::POS_SYSTEM.Properties.Resources.edit;
            this.dgvEdit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvEdit.MinimumWidth = 50;
            this.dgvEdit.Name = "dgvEdit";
            this.dgvEdit.Width = 50;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.BackColor = System.Drawing.Color.Transparent;
            this.lblSupplier.ForeColor = System.Drawing.Color.Black;
            this.lblSupplier.Location = new System.Drawing.Point(56, 160);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(89, 24);
            this.lblSupplier.TabIndex = 80;
            this.lblSupplier.Text = "Supplier";
            // 
            // comboSupplier
            // 
            this.comboSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboSupplier.DropDownHeight = 105;
            this.comboSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboSupplier.FormattingEnabled = true;
            this.comboSupplier.IntegralHeight = false;
            this.comboSupplier.Location = new System.Drawing.Point(39, 190);
            this.comboSupplier.Name = "comboSupplier";
            this.comboSupplier.Size = new System.Drawing.Size(250, 32);
            this.comboSupplier.TabIndex = 79;
            this.comboSupplier.TextChanged += new System.EventHandler(this.comboSupplier_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Animated = true;
            this.btnAdd.AutoRoundedCorners = true;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderRadius = 19;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdd.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnAdd.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAdd.Location = new System.Drawing.Point(39, 467);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 41);
            this.btnAdd.TabIndex = 81;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Animated = true;
            this.btnUpdate.AutoRoundedCorners = true;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BorderRadius = 19;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdate.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnUpdate.ImageSize = new System.Drawing.Size(25, 25);
            this.btnUpdate.Location = new System.Drawing.Point(202, 467);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 41);
            this.btnUpdate.TabIndex = 82;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbConfim
            // 
            this.cbConfim.AutoSize = true;
            this.cbConfim.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbConfim.CheckedState.BorderRadius = 0;
            this.cbConfim.CheckedState.BorderThickness = 0;
            this.cbConfim.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbConfim.Location = new System.Drawing.Point(691, 467);
            this.cbConfim.Name = "cbConfim";
            this.cbConfim.Size = new System.Drawing.Size(196, 28);
            this.cbConfim.TabIndex = 83;
            this.cbConfim.Text = "Confirm Stock In";
            this.cbConfim.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbConfim.UncheckedState.BorderRadius = 0;
            this.cbConfim.UncheckedState.BorderThickness = 0;
            this.cbConfim.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbConfim.Visible = false;
            // 
            // frmStockInAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 1080);
            this.Controls.Add(this.cbConfim);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.comboSupplier);
            this.Controls.Add(this.dataProduct);
            this.Controls.Add(this.txtTPrice);
            this.Controls.Add(this.lblTPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.txtInformation);
            this.Controls.Add(this.txtColi);
            this.Controls.Add(this.lblColi);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.comboProduct);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblPP);
            this.Controls.Add(this.pictStockIn);
            this.Controls.Add(this.txtTimeIn);
            this.Controls.Add(this.lblTimeIn);
            this.Controls.Add(this.dateIn);
            this.Controls.Add(this.lblJoinDate);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmStockInAdd";
            this.Text = "frmStockInAdd";
            this.Load += new System.EventHandler(this.frmStockInAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictStockIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2DateTimePicker dateIn;
        private System.Windows.Forms.Label lblJoinDate;
        public Guna.UI2.WinForms.Guna2TextBox txtTimeIn;
        private System.Windows.Forms.Label lblTimeIn;
        public Guna.UI2.WinForms.Guna2Button btnBrowse;
        private System.Windows.Forms.Label lblPP;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictStockIn;
        private System.Windows.Forms.Label lblProduct;
        public System.Windows.Forms.ComboBox comboProduct;
        public Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        public Guna.UI2.WinForms.Guna2TextBox txtColi;
        private System.Windows.Forms.Label lblColi;
        private System.Windows.Forms.Label lblInformation;
        public Guna.UI2.WinForms.Guna2TextBox txtInformation;
        public Guna.UI2.WinForms.Guna2TextBox txtTPrice;
        private System.Windows.Forms.Label lblTPrice;
        public Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        public Guna.UI2.WinForms.Guna2Elipse elipsTable;
        private Guna.UI2.WinForms.Guna2DataGridView dataProduct;
        private System.Windows.Forms.Label lblSupplier;
        public System.Windows.Forms.ComboBox comboSupplier;
        public Guna.UI2.WinForms.Guna2Button btnAdd;
        public Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2CheckBox cbConfim;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIDProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNettPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTotalPrice;
        private System.Windows.Forms.DataGridViewImageColumn dgvEdit;
    }
}