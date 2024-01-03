namespace POS_SYSTEM.Model
{
    partial class frmStockOutAdd
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
            this.lblSupplier = new System.Windows.Forms.Label();
            this.comboSupplier = new System.Windows.Forms.ComboBox();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblInformation = new System.Windows.Forms.Label();
            this.txtInformation = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtColi = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblColi = new System.Windows.Forms.Label();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.comboProduct = new System.Windows.Forms.ComboBox();
            this.btnBrowse = new Guna.UI2.WinForms.Guna2Button();
            this.lblPP = new System.Windows.Forms.Label();
            this.pictStockIn = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txtTimeIn = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTimeIn = new System.Windows.Forms.Label();
            this.dateIn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblDateOut = new System.Windows.Forms.Label();
            this.comboCause = new System.Windows.Forms.ComboBox();
            this.lblCause = new System.Windows.Forms.Label();
            this.txtQuantityT = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblQualityTotal = new System.Windows.Forms.Label();
            this.txtColiT = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbConfim = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtTPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictStockIn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.BackColor = System.Drawing.Color.Transparent;
            this.lblSupplier.ForeColor = System.Drawing.Color.Black;
            this.lblSupplier.Location = new System.Drawing.Point(65, 170);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(89, 24);
            this.lblSupplier.TabIndex = 104;
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
            this.comboSupplier.Location = new System.Drawing.Point(48, 200);
            this.comboSupplier.Name = "comboSupplier";
            this.comboSupplier.Size = new System.Drawing.Size(250, 32);
            this.comboSupplier.TabIndex = 103;
            this.comboSupplier.TextChanged += new System.EventHandler(this.comboSupplier_TextChanged);
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
            this.txtPrice.Location = new System.Drawing.Point(48, 405);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPrice.PlaceholderText = "auto complete";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(250, 40);
            this.txtPrice.TabIndex = 100;
            this.txtPrice.Tag = "t";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(65, 379);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(59, 24);
            this.lblPrice.TabIndex = 99;
            this.lblPrice.Text = "Price";
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.BackColor = System.Drawing.Color.Transparent;
            this.lblInformation.ForeColor = System.Drawing.Color.Black;
            this.lblInformation.Location = new System.Drawing.Point(699, 482);
            this.lblInformation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(49, 24);
            this.lblInformation.TabIndex = 98;
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
            this.txtInformation.Location = new System.Drawing.Point(686, 508);
            this.txtInformation.Margin = new System.Windows.Forms.Padding(2);
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.PasswordChar = '\0';
            this.txtInformation.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtInformation.PlaceholderText = "";
            this.txtInformation.SelectedText = "";
            this.txtInformation.Size = new System.Drawing.Size(250, 40);
            this.txtInformation.TabIndex = 97;
            this.txtInformation.Tag = "";
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
            this.txtColi.Location = new System.Drawing.Point(689, 302);
            this.txtColi.Margin = new System.Windows.Forms.Padding(2);
            this.txtColi.Name = "txtColi";
            this.txtColi.PasswordChar = '\0';
            this.txtColi.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtColi.PlaceholderText = "100";
            this.txtColi.SelectedText = "";
            this.txtColi.Size = new System.Drawing.Size(250, 40);
            this.txtColi.TabIndex = 96;
            this.txtColi.Tag = "t";
            this.txtColi.TextChanged += new System.EventHandler(this.txtColi_TextChanged);
            // 
            // lblColi
            // 
            this.lblColi.AutoSize = true;
            this.lblColi.BackColor = System.Drawing.Color.Transparent;
            this.lblColi.ForeColor = System.Drawing.Color.Black;
            this.lblColi.Location = new System.Drawing.Point(699, 276);
            this.lblColi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColi.Name = "lblColi";
            this.lblColi.Size = new System.Drawing.Size(93, 24);
            this.lblColi.TabIndex = 95;
            this.lblColi.Text = "Coli Out";
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
            this.txtQuantity.Location = new System.Drawing.Point(364, 302);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtQuantity.PlaceholderText = "100";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(250, 40);
            this.txtQuantity.TabIndex = 94;
            this.txtQuantity.Tag = "n";
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.ForeColor = System.Drawing.Color.Black;
            this.lblQuantity.Location = new System.Drawing.Point(374, 276);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(140, 24);
            this.lblQuantity.TabIndex = 93;
            this.lblQuantity.Text = "Quantity Out";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblProduct.ForeColor = System.Drawing.Color.Black;
            this.lblProduct.Location = new System.Drawing.Point(65, 276);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(90, 24);
            this.lblProduct.TabIndex = 92;
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
            this.comboProduct.Location = new System.Drawing.Point(48, 302);
            this.comboProduct.Name = "comboProduct";
            this.comboProduct.Size = new System.Drawing.Size(250, 32);
            this.comboProduct.TabIndex = 91;
            this.comboProduct.Tag = "com";
            this.comboProduct.TextChanged += new System.EventHandler(this.comboProduct_TextChanged);
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
            this.btnBrowse.Location = new System.Drawing.Point(1049, 403);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(140, 40);
            this.btnBrowse.TabIndex = 90;
            this.btnBrowse.Text = "BROWSE";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblPP
            // 
            this.lblPP.AutoSize = true;
            this.lblPP.BackColor = System.Drawing.Color.Transparent;
            this.lblPP.ForeColor = System.Drawing.Color.Black;
            this.lblPP.Location = new System.Drawing.Point(1033, 170);
            this.lblPP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPP.Name = "lblPP";
            this.lblPP.Size = new System.Drawing.Size(163, 24);
            this.lblPP.TabIndex = 89;
            this.lblPP.Text = "Stock in Picture";
            // 
            // pictStockIn
            // 
            this.pictStockIn.BackColor = System.Drawing.Color.Transparent;
            this.pictStockIn.Image = global::POS_SYSTEM.Properties.Resources.product;
            this.pictStockIn.ImageRotate = 0F;
            this.pictStockIn.Location = new System.Drawing.Point(1031, 209);
            this.pictStockIn.Name = "pictStockIn";
            this.pictStockIn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictStockIn.Size = new System.Drawing.Size(180, 180);
            this.pictStockIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictStockIn.TabIndex = 88;
            this.pictStockIn.TabStop = false;
            this.pictStockIn.UseTransparentBackground = true;
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
            this.txtTimeIn.Location = new System.Drawing.Point(686, 196);
            this.txtTimeIn.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimeIn.Name = "txtTimeIn";
            this.txtTimeIn.PasswordChar = '\0';
            this.txtTimeIn.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTimeIn.PlaceholderText = "00:00";
            this.txtTimeIn.SelectedText = "";
            this.txtTimeIn.Size = new System.Drawing.Size(250, 40);
            this.txtTimeIn.TabIndex = 87;
            this.txtTimeIn.Tag = "time";
            // 
            // lblTimeIn
            // 
            this.lblTimeIn.AutoSize = true;
            this.lblTimeIn.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeIn.ForeColor = System.Drawing.Color.Black;
            this.lblTimeIn.Location = new System.Drawing.Point(696, 170);
            this.lblTimeIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimeIn.Name = "lblTimeIn";
            this.lblTimeIn.Size = new System.Drawing.Size(80, 24);
            this.lblTimeIn.TabIndex = 86;
            this.lblTimeIn.Text = "Time In";
            // 
            // dateIn
            // 
            this.dateIn.AutoRoundedCorners = true;
            this.dateIn.BorderRadius = 17;
            this.dateIn.Checked = true;
            this.dateIn.FillColor = System.Drawing.Color.White;
            this.dateIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateIn.Location = new System.Drawing.Point(370, 196);
            this.dateIn.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateIn.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateIn.Name = "dateIn";
            this.dateIn.Size = new System.Drawing.Size(250, 36);
            this.dateIn.TabIndex = 85;
            this.dateIn.Value = new System.DateTime(2023, 9, 20, 14, 30, 24, 405);
            // 
            // lblDateOut
            // 
            this.lblDateOut.AutoSize = true;
            this.lblDateOut.BackColor = System.Drawing.Color.Transparent;
            this.lblDateOut.ForeColor = System.Drawing.Color.Black;
            this.lblDateOut.Location = new System.Drawing.Point(387, 170);
            this.lblDateOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateOut.Name = "lblDateOut";
            this.lblDateOut.Size = new System.Drawing.Size(101, 24);
            this.lblDateOut.TabIndex = 84;
            this.lblDateOut.Text = "Date out";
            // 
            // comboCause
            // 
            this.comboCause.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboCause.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboCause.DropDownHeight = 105;
            this.comboCause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboCause.FormattingEnabled = true;
            this.comboCause.IntegralHeight = false;
            this.comboCause.Items.AddRange(new object[] {
            "Refund",
            "Expired",
            "Damaged",
            "Other"});
            this.comboCause.Location = new System.Drawing.Point(364, 509);
            this.comboCause.Name = "comboCause";
            this.comboCause.Size = new System.Drawing.Size(250, 32);
            this.comboCause.TabIndex = 106;
            this.comboCause.Tag = "comtext";
            // 
            // lblCause
            // 
            this.lblCause.AutoSize = true;
            this.lblCause.BackColor = System.Drawing.Color.Transparent;
            this.lblCause.ForeColor = System.Drawing.Color.Black;
            this.lblCause.Location = new System.Drawing.Point(381, 482);
            this.lblCause.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCause.Name = "lblCause";
            this.lblCause.Size = new System.Drawing.Size(76, 24);
            this.lblCause.TabIndex = 107;
            this.lblCause.Text = "Cause";
            // 
            // txtQuantityT
            // 
            this.txtQuantityT.AutoRoundedCorners = true;
            this.txtQuantityT.AutoSize = true;
            this.txtQuantityT.BackColor = System.Drawing.Color.Transparent;
            this.txtQuantityT.BorderRadius = 19;
            this.txtQuantityT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantityT.DefaultText = "";
            this.txtQuantityT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantityT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantityT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantityT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantityT.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtQuantityT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantityT.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtQuantityT.ForeColor = System.Drawing.Color.Black;
            this.txtQuantityT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantityT.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtQuantityT.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtQuantityT.Location = new System.Drawing.Point(364, 403);
            this.txtQuantityT.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantityT.Name = "txtQuantityT";
            this.txtQuantityT.PasswordChar = '\0';
            this.txtQuantityT.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtQuantityT.PlaceholderText = "auto complete";
            this.txtQuantityT.ReadOnly = true;
            this.txtQuantityT.SelectedText = "";
            this.txtQuantityT.Size = new System.Drawing.Size(250, 40);
            this.txtQuantityT.TabIndex = 102;
            this.txtQuantityT.Tag = "t";
            // 
            // lblQualityTotal
            // 
            this.lblQualityTotal.AutoSize = true;
            this.lblQualityTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblQualityTotal.ForeColor = System.Drawing.Color.Black;
            this.lblQualityTotal.Location = new System.Drawing.Point(374, 379);
            this.lblQualityTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQualityTotal.Name = "lblQualityTotal";
            this.lblQualityTotal.Size = new System.Drawing.Size(150, 24);
            this.lblQualityTotal.TabIndex = 101;
            this.lblQualityTotal.Text = "Quantity Total";
            // 
            // txtColiT
            // 
            this.txtColiT.AutoRoundedCorners = true;
            this.txtColiT.AutoSize = true;
            this.txtColiT.BackColor = System.Drawing.Color.Transparent;
            this.txtColiT.BorderRadius = 19;
            this.txtColiT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtColiT.DefaultText = "";
            this.txtColiT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtColiT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtColiT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtColiT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtColiT.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtColiT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtColiT.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtColiT.ForeColor = System.Drawing.Color.Black;
            this.txtColiT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtColiT.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtColiT.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtColiT.Location = new System.Drawing.Point(686, 403);
            this.txtColiT.Margin = new System.Windows.Forms.Padding(2);
            this.txtColiT.Name = "txtColiT";
            this.txtColiT.PasswordChar = '\0';
            this.txtColiT.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtColiT.PlaceholderText = "auto complete";
            this.txtColiT.ReadOnly = true;
            this.txtColiT.SelectedText = "";
            this.txtColiT.Size = new System.Drawing.Size(250, 40);
            this.txtColiT.TabIndex = 109;
            this.txtColiT.Tag = "t";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(696, 379);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 108;
            this.label1.Text = "Coli Total";
            // 
            // cbConfim
            // 
            this.cbConfim.AutoSize = true;
            this.cbConfim.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbConfim.CheckedState.BorderRadius = 0;
            this.cbConfim.CheckedState.BorderThickness = 0;
            this.cbConfim.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbConfim.Location = new System.Drawing.Point(1014, 509);
            this.cbConfim.Name = "cbConfim";
            this.cbConfim.Size = new System.Drawing.Size(216, 28);
            this.cbConfim.TabIndex = 110;
            this.cbConfim.Text = "Confirm Stock Out";
            this.cbConfim.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbConfim.UncheckedState.BorderRadius = 0;
            this.cbConfim.UncheckedState.BorderThickness = 0;
            this.cbConfim.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbConfim.Visible = false;
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
            this.txtTPrice.Location = new System.Drawing.Point(48, 508);
            this.txtTPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtTPrice.Name = "txtTPrice";
            this.txtTPrice.PasswordChar = '\0';
            this.txtTPrice.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTPrice.PlaceholderText = "auto complete";
            this.txtTPrice.ReadOnly = true;
            this.txtTPrice.SelectedText = "";
            this.txtTPrice.Size = new System.Drawing.Size(250, 40);
            this.txtTPrice.TabIndex = 112;
            this.txtTPrice.Tag = "t";
            // 
            // lblTPrice
            // 
            this.lblTPrice.AutoSize = true;
            this.lblTPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTPrice.ForeColor = System.Drawing.Color.Black;
            this.lblTPrice.Location = new System.Drawing.Point(65, 482);
            this.lblTPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTPrice.Name = "lblTPrice";
            this.lblTPrice.Size = new System.Drawing.Size(113, 24);
            this.lblTPrice.TabIndex = 111;
            this.lblTPrice.Text = "Total Price";
            // 
            // frmStockOutAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 679);
            this.Controls.Add(this.txtTPrice);
            this.Controls.Add(this.lblTPrice);
            this.Controls.Add(this.cbConfim);
            this.Controls.Add(this.txtColiT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCause);
            this.Controls.Add(this.comboCause);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.comboSupplier);
            this.Controls.Add(this.txtQuantityT);
            this.Controls.Add(this.lblQualityTotal);
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
            this.Controls.Add(this.lblDateOut);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmStockOutAdd";
            this.Text = "frmStockOutAdd";
            this.Load += new System.EventHandler(this.frmStockOutAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictStockIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSupplier;
        public System.Windows.Forms.ComboBox comboSupplier;
        public Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblInformation;
        public Guna.UI2.WinForms.Guna2TextBox txtInformation;
        public Guna.UI2.WinForms.Guna2TextBox txtColi;
        private System.Windows.Forms.Label lblColi;
        public Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblProduct;
        public System.Windows.Forms.ComboBox comboProduct;
        public Guna.UI2.WinForms.Guna2Button btnBrowse;
        private System.Windows.Forms.Label lblPP;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictStockIn;
        public Guna.UI2.WinForms.Guna2TextBox txtTimeIn;
        private System.Windows.Forms.Label lblTimeIn;
        public Guna.UI2.WinForms.Guna2DateTimePicker dateIn;
        private System.Windows.Forms.Label lblDateOut;
        public System.Windows.Forms.ComboBox comboCause;
        private System.Windows.Forms.Label lblCause;
        public Guna.UI2.WinForms.Guna2TextBox txtQuantityT;
        private System.Windows.Forms.Label lblQualityTotal;
        public Guna.UI2.WinForms.Guna2TextBox txtColiT;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CheckBox cbConfim;
        public Guna.UI2.WinForms.Guna2TextBox txtTPrice;
        private System.Windows.Forms.Label lblTPrice;
    }
}