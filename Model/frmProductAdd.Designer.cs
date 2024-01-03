namespace POS_SYSTEM.Model
{
    partial class frmProductAdd
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
            this.txtProductCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.comboUnit = new System.Windows.Forms.ComboBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.comboSupplier = new System.Windows.Forms.ComboBox();
            this.txtNettPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNPrice = new System.Windows.Forms.Label();
            this.txtMargin = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMargin = new System.Windows.Forms.Label();
            this.txtTax = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtDiscount = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSPrice = new System.Windows.Forms.Label();
            this.txtSellPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblInformation = new System.Windows.Forms.Label();
            this.txtInformation = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBrowse = new Guna.UI2.WinForms.Guna2Button();
            this.lblPP = new System.Windows.Forms.Label();
            this.pictProduct = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProductCode
            // 
            this.txtProductCode.AutoRoundedCorners = true;
            this.txtProductCode.AutoSize = true;
            this.txtProductCode.BackColor = System.Drawing.Color.Transparent;
            this.txtProductCode.BorderRadius = 19;
            this.txtProductCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductCode.DefaultText = "";
            this.txtProductCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductCode.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtProductCode.ForeColor = System.Drawing.Color.Black;
            this.txtProductCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductCode.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtProductCode.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtProductCode.Location = new System.Drawing.Point(50, 199);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.PasswordChar = '\0';
            this.txtProductCode.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtProductCode.PlaceholderText = "";
            this.txtProductCode.SelectedText = "";
            this.txtProductCode.Size = new System.Drawing.Size(250, 40);
            this.txtProductCode.TabIndex = 35;
            this.txtProductCode.Tag = "t";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.BackColor = System.Drawing.Color.Transparent;
            this.lblProductCode.ForeColor = System.Drawing.Color.Black;
            this.lblProductCode.Location = new System.Drawing.Point(60, 173);
            this.lblProductCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(155, 24);
            this.lblProductCode.TabIndex = 34;
            this.lblProductCode.Text = "Product Code";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.BackColor = System.Drawing.Color.Transparent;
            this.lblUnit.ForeColor = System.Drawing.Color.Black;
            this.lblUnit.Location = new System.Drawing.Point(60, 375);
            this.lblUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(46, 24);
            this.lblUnit.TabIndex = 37;
            this.lblUnit.Text = "Unit";
            this.lblUnit.Click += new System.EventHandler(this.lblUnit_Click);
            // 
            // comboUnit
            // 
            this.comboUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboUnit.DropDownHeight = 105;
            this.comboUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboUnit.FormattingEnabled = true;
            this.comboUnit.IntegralHeight = false;
            this.comboUnit.Location = new System.Drawing.Point(50, 402);
            this.comboUnit.Name = "comboUnit";
            this.comboUnit.Size = new System.Drawing.Size(250, 32);
            this.comboUnit.TabIndex = 36;
            this.comboUnit.Tag = "com";
            this.comboUnit.SelectedIndexChanged += new System.EventHandler(this.comboUnit_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.AutoRoundedCorners = true;
            this.txtName.AutoSize = true;
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.BorderRadius = 19;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtName.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtName.Location = new System.Drawing.Point(50, 298);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(250, 40);
            this.txtName.TabIndex = 39;
            this.txtName.Tag = "t";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(60, 272);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 24);
            this.lblName.TabIndex = 38;
            this.lblName.Text = "Name";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.ForeColor = System.Drawing.Color.Black;
            this.lblCategory.Location = new System.Drawing.Point(60, 476);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(107, 24);
            this.lblCategory.TabIndex = 41;
            this.lblCategory.Text = "Category";
            // 
            // comboCategory
            // 
            this.comboCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboCategory.DropDownHeight = 105;
            this.comboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.IntegralHeight = false;
            this.comboCategory.Location = new System.Drawing.Point(50, 503);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(250, 32);
            this.comboCategory.TabIndex = 40;
            this.comboCategory.Tag = "com";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.BackColor = System.Drawing.Color.Transparent;
            this.lblSupplier.ForeColor = System.Drawing.Color.Black;
            this.lblSupplier.Location = new System.Drawing.Point(374, 173);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(89, 24);
            this.lblSupplier.TabIndex = 43;
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
            this.comboSupplier.Location = new System.Drawing.Point(364, 200);
            this.comboSupplier.Name = "comboSupplier";
            this.comboSupplier.Size = new System.Drawing.Size(250, 32);
            this.comboSupplier.TabIndex = 42;
            this.comboSupplier.Tag = "com";
            // 
            // txtNettPrice
            // 
            this.txtNettPrice.AutoRoundedCorners = true;
            this.txtNettPrice.AutoSize = true;
            this.txtNettPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtNettPrice.BorderRadius = 19;
            this.txtNettPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNettPrice.DefaultText = "";
            this.txtNettPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNettPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNettPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNettPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNettPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNettPrice.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtNettPrice.ForeColor = System.Drawing.Color.Black;
            this.txtNettPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNettPrice.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtNettPrice.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtNettPrice.Location = new System.Drawing.Point(364, 298);
            this.txtNettPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtNettPrice.Name = "txtNettPrice";
            this.txtNettPrice.PasswordChar = '\0';
            this.txtNettPrice.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtNettPrice.PlaceholderText = "1000.00";
            this.txtNettPrice.SelectedText = "";
            this.txtNettPrice.Size = new System.Drawing.Size(250, 40);
            this.txtNettPrice.TabIndex = 45;
            this.txtNettPrice.Tag = "n";
            this.txtNettPrice.TextChanged += new System.EventHandler(this.txtNettPrice_TextChanged);
            // 
            // lblNPrice
            // 
            this.lblNPrice.AutoSize = true;
            this.lblNPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblNPrice.ForeColor = System.Drawing.Color.Black;
            this.lblNPrice.Location = new System.Drawing.Point(374, 272);
            this.lblNPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNPrice.Name = "lblNPrice";
            this.lblNPrice.Size = new System.Drawing.Size(109, 24);
            this.lblNPrice.TabIndex = 44;
            this.lblNPrice.Text = "Nett Price";
            // 
            // txtMargin
            // 
            this.txtMargin.AutoRoundedCorners = true;
            this.txtMargin.AutoSize = true;
            this.txtMargin.BackColor = System.Drawing.Color.Transparent;
            this.txtMargin.BorderRadius = 19;
            this.txtMargin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMargin.DefaultText = "";
            this.txtMargin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMargin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMargin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMargin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMargin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMargin.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtMargin.ForeColor = System.Drawing.Color.Black;
            this.txtMargin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMargin.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtMargin.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtMargin.Location = new System.Drawing.Point(364, 401);
            this.txtMargin.Margin = new System.Windows.Forms.Padding(2);
            this.txtMargin.Name = "txtMargin";
            this.txtMargin.PasswordChar = '\0';
            this.txtMargin.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtMargin.PlaceholderText = "100";
            this.txtMargin.SelectedText = "";
            this.txtMargin.Size = new System.Drawing.Size(250, 40);
            this.txtMargin.TabIndex = 47;
            this.txtMargin.Tag = "t";
            this.txtMargin.TextChanged += new System.EventHandler(this.txtMargin_TextChanged);
            // 
            // lblMargin
            // 
            this.lblMargin.AutoSize = true;
            this.lblMargin.BackColor = System.Drawing.Color.Transparent;
            this.lblMargin.ForeColor = System.Drawing.Color.Black;
            this.lblMargin.Location = new System.Drawing.Point(374, 375);
            this.lblMargin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMargin.Name = "lblMargin";
            this.lblMargin.Size = new System.Drawing.Size(101, 24);
            this.lblMargin.TabIndex = 46;
            this.lblMargin.Text = "Margin %";
            // 
            // txtTax
            // 
            this.txtTax.AutoRoundedCorners = true;
            this.txtTax.AutoSize = true;
            this.txtTax.BackColor = System.Drawing.Color.Transparent;
            this.txtTax.BorderRadius = 19;
            this.txtTax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTax.DefaultText = "";
            this.txtTax.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTax.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTax.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTax.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTax.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTax.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtTax.ForeColor = System.Drawing.Color.Black;
            this.txtTax.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTax.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtTax.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtTax.Location = new System.Drawing.Point(364, 502);
            this.txtTax.Margin = new System.Windows.Forms.Padding(2);
            this.txtTax.Name = "txtTax";
            this.txtTax.PasswordChar = '\0';
            this.txtTax.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTax.PlaceholderText = "100";
            this.txtTax.SelectedText = "";
            this.txtTax.Size = new System.Drawing.Size(250, 40);
            this.txtTax.TabIndex = 49;
            this.txtTax.Tag = "t";
            this.txtTax.TextChanged += new System.EventHandler(this.txtTax_TextChanged);
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.BackColor = System.Drawing.Color.Transparent;
            this.lblTax.ForeColor = System.Drawing.Color.Black;
            this.lblTax.Location = new System.Drawing.Point(374, 476);
            this.lblTax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(64, 24);
            this.lblTax.TabIndex = 48;
            this.lblTax.Text = "Tax %";
            // 
            // txtDiscount
            // 
            this.txtDiscount.AutoRoundedCorners = true;
            this.txtDiscount.AutoSize = true;
            this.txtDiscount.BackColor = System.Drawing.Color.Transparent;
            this.txtDiscount.BorderRadius = 19;
            this.txtDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscount.DefaultText = "";
            this.txtDiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtDiscount.ForeColor = System.Drawing.Color.Black;
            this.txtDiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtDiscount.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtDiscount.Location = new System.Drawing.Point(681, 199);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PasswordChar = '\0';
            this.txtDiscount.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtDiscount.PlaceholderText = "100";
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.Size = new System.Drawing.Size(250, 40);
            this.txtDiscount.TabIndex = 51;
            this.txtDiscount.Tag = "t";
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscount.ForeColor = System.Drawing.Color.Black;
            this.lblDiscount.Location = new System.Drawing.Point(691, 173);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(120, 24);
            this.lblDiscount.TabIndex = 50;
            this.lblDiscount.Text = "Discount %";
            // 
            // lblSPrice
            // 
            this.lblSPrice.AutoSize = true;
            this.lblSPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblSPrice.ForeColor = System.Drawing.Color.Black;
            this.lblSPrice.Location = new System.Drawing.Point(691, 272);
            this.lblSPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSPrice.Name = "lblSPrice";
            this.lblSPrice.Size = new System.Drawing.Size(99, 24);
            this.lblSPrice.TabIndex = 52;
            this.lblSPrice.Text = "Sell Price";
            this.lblSPrice.Click += new System.EventHandler(this.lblSPrice_Click);
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.AutoRoundedCorners = true;
            this.txtSellPrice.AutoSize = true;
            this.txtSellPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtSellPrice.BorderRadius = 19;
            this.txtSellPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSellPrice.DefaultText = "";
            this.txtSellPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSellPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSellPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSellPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSellPrice.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtSellPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSellPrice.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtSellPrice.ForeColor = System.Drawing.Color.Black;
            this.txtSellPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSellPrice.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtSellPrice.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtSellPrice.Location = new System.Drawing.Point(681, 298);
            this.txtSellPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.PasswordChar = '\0';
            this.txtSellPrice.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSellPrice.PlaceholderText = "auto complete";
            this.txtSellPrice.ReadOnly = true;
            this.txtSellPrice.SelectedText = "";
            this.txtSellPrice.Size = new System.Drawing.Size(250, 40);
            this.txtSellPrice.TabIndex = 53;
            this.txtSellPrice.Tag = "t";
            this.txtSellPrice.TextChanged += new System.EventHandler(this.txtSellPrice_TextChanged);
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.BackColor = System.Drawing.Color.Transparent;
            this.lblInformation.ForeColor = System.Drawing.Color.Black;
            this.lblInformation.Location = new System.Drawing.Point(691, 376);
            this.lblInformation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(49, 24);
            this.lblInformation.TabIndex = 55;
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
            this.txtInformation.Location = new System.Drawing.Point(681, 402);
            this.txtInformation.Margin = new System.Windows.Forms.Padding(2);
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.PasswordChar = '\0';
            this.txtInformation.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtInformation.PlaceholderText = "";
            this.txtInformation.SelectedText = "";
            this.txtInformation.Size = new System.Drawing.Size(250, 40);
            this.txtInformation.TabIndex = 54;
            this.txtInformation.Tag = "";
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
            this.btnBrowse.Location = new System.Drawing.Point(1030, 466);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(140, 40);
            this.btnBrowse.TabIndex = 58;
            this.btnBrowse.Text = "BROWSE";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblPP
            // 
            this.lblPP.AutoSize = true;
            this.lblPP.BackColor = System.Drawing.Color.Transparent;
            this.lblPP.ForeColor = System.Drawing.Color.Black;
            this.lblPP.Location = new System.Drawing.Point(1017, 233);
            this.lblPP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPP.Name = "lblPP";
            this.lblPP.Size = new System.Drawing.Size(165, 24);
            this.lblPP.TabIndex = 57;
            this.lblPP.Text = "Product Picture";
            // 
            // pictProduct
            // 
            this.pictProduct.BackColor = System.Drawing.Color.Transparent;
            this.pictProduct.Image = global::POS_SYSTEM.Properties.Resources.product;
            this.pictProduct.ImageRotate = 0F;
            this.pictProduct.Location = new System.Drawing.Point(1012, 272);
            this.pictProduct.Name = "pictProduct";
            this.pictProduct.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictProduct.Size = new System.Drawing.Size(180, 180);
            this.pictProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictProduct.TabIndex = 56;
            this.pictProduct.TabStop = false;
            this.pictProduct.UseTransparentBackground = true;
            // 
            // frmProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 674);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblPP);
            this.Controls.Add(this.pictProduct);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.txtInformation);
            this.Controls.Add(this.txtSellPrice);
            this.Controls.Add(this.lblSPrice);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.txtMargin);
            this.Controls.Add(this.lblMargin);
            this.Controls.Add(this.txtNettPrice);
            this.Controls.Add(this.lblNPrice);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.comboSupplier);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.comboUnit);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.lblProductCode);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmProductAdd";
            this.Text = "frmProductAdd";
            this.Load += new System.EventHandler(this.frmProductAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2TextBox txtProductCode;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.Label lblUnit;
        public System.Windows.Forms.ComboBox comboUnit;
        public Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCategory;
        public System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.Label lblSupplier;
        public System.Windows.Forms.ComboBox comboSupplier;
        public Guna.UI2.WinForms.Guna2TextBox txtNettPrice;
        private System.Windows.Forms.Label lblNPrice;
        public Guna.UI2.WinForms.Guna2TextBox txtMargin;
        private System.Windows.Forms.Label lblMargin;
        public Guna.UI2.WinForms.Guna2TextBox txtTax;
        private System.Windows.Forms.Label lblTax;
        public Guna.UI2.WinForms.Guna2TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblSPrice;
        public Guna.UI2.WinForms.Guna2TextBox txtSellPrice;
        private System.Windows.Forms.Label lblInformation;
        public Guna.UI2.WinForms.Guna2TextBox txtInformation;
        public Guna.UI2.WinForms.Guna2Button btnBrowse;
        private System.Windows.Forms.Label lblPP;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictProduct;
    }
}