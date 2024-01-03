namespace POS_SYSTEM.Model
{
    partial class frmStaffAdd
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
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.comboRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtStaffID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblJoinDate = new System.Windows.Forms.Label();
            this.dateJoin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblInformation = new System.Windows.Forms.Label();
            this.txtInformation = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblPP = new System.Windows.Forms.Label();
            this.btnBrowse = new Guna.UI2.WinForms.Guna2Button();
            this.radioMale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioFemale = new Guna.UI2.WinForms.Guna2RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictProfile)).BeginInit();
            this.SuspendLayout();
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
            this.txtName.Location = new System.Drawing.Point(59, 389);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(250, 40);
            this.txtName.TabIndex = 16;
            this.txtName.Tag = "t";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(69, 363);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 24);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Name";
            // 
            // comboRole
            // 
            this.comboRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboRole.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboRole.DropDownHeight = 105;
            this.comboRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboRole.FormattingEnabled = true;
            this.comboRole.IntegralHeight = false;
            this.comboRole.Location = new System.Drawing.Point(59, 292);
            this.comboRole.Name = "comboRole";
            this.comboRole.Size = new System.Drawing.Size(250, 32);
            this.comboRole.TabIndex = 17;
            this.comboRole.Tag = "com";
            this.comboRole.SelectedIndexChanged += new System.EventHandler(this.comboRole_SelectedIndexChanged);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.BackColor = System.Drawing.Color.Transparent;
            this.lblRole.ForeColor = System.Drawing.Color.Black;
            this.lblRole.Location = new System.Drawing.Point(69, 265);
            this.lblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(56, 24);
            this.lblRole.TabIndex = 18;
            this.lblRole.Text = "Role";
            // 
            // txtStaffID
            // 
            this.txtStaffID.AutoRoundedCorners = true;
            this.txtStaffID.AutoSize = true;
            this.txtStaffID.BackColor = System.Drawing.Color.Transparent;
            this.txtStaffID.BorderRadius = 19;
            this.txtStaffID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStaffID.DefaultText = "";
            this.txtStaffID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStaffID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStaffID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStaffID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStaffID.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtStaffID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStaffID.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtStaffID.ForeColor = System.Drawing.Color.Black;
            this.txtStaffID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStaffID.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtStaffID.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtStaffID.Location = new System.Drawing.Point(52, 185);
            this.txtStaffID.Margin = new System.Windows.Forms.Padding(2);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.PasswordChar = '\0';
            this.txtStaffID.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtStaffID.PlaceholderText = "auto complete";
            this.txtStaffID.ReadOnly = true;
            this.txtStaffID.SelectedText = "";
            this.txtStaffID.Size = new System.Drawing.Size(250, 40);
            this.txtStaffID.TabIndex = 20;
            this.txtStaffID.Tag = "t";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.BackColor = System.Drawing.Color.Transparent;
            this.lblStaffID.ForeColor = System.Drawing.Color.Black;
            this.lblStaffID.Location = new System.Drawing.Point(69, 159);
            this.lblStaffID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(82, 24);
            this.lblStaffID.TabIndex = 19;
            this.lblStaffID.Text = "Staff ID";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.ForeColor = System.Drawing.Color.Black;
            this.lblGender.Location = new System.Drawing.Point(393, 159);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(89, 24);
            this.lblGender.TabIndex = 21;
            this.lblGender.Text = "Gender";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Location = new System.Drawing.Point(393, 265);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(76, 24);
            this.lblPhone.TabIndex = 23;
            this.lblPhone.Text = "Phone";
            // 
            // txtAddress
            // 
            this.txtAddress.AutoRoundedCorners = true;
            this.txtAddress.AutoSize = true;
            this.txtAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtAddress.BorderRadius = 19;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtAddress.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtAddress.Location = new System.Drawing.Point(383, 389);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(250, 40);
            this.txtAddress.TabIndex = 26;
            this.txtAddress.Tag = "t";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(393, 363);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(89, 24);
            this.lblAddress.TabIndex = 25;
            this.lblAddress.Text = "Address";
            // 
            // lblJoinDate
            // 
            this.lblJoinDate.AutoSize = true;
            this.lblJoinDate.BackColor = System.Drawing.Color.Transparent;
            this.lblJoinDate.ForeColor = System.Drawing.Color.Black;
            this.lblJoinDate.Location = new System.Drawing.Point(69, 473);
            this.lblJoinDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJoinDate.Name = "lblJoinDate";
            this.lblJoinDate.Size = new System.Drawing.Size(107, 24);
            this.lblJoinDate.TabIndex = 27;
            this.lblJoinDate.Text = "Join Date";
            // 
            // dateJoin
            // 
            this.dateJoin.AutoRoundedCorners = true;
            this.dateJoin.BorderRadius = 17;
            this.dateJoin.FillColor = System.Drawing.Color.White;
            this.dateJoin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateJoin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateJoin.Location = new System.Drawing.Point(59, 499);
            this.dateJoin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateJoin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateJoin.Name = "dateJoin";
            this.dateJoin.Size = new System.Drawing.Size(250, 36);
            this.dateJoin.TabIndex = 31;
            this.dateJoin.Value = new System.DateTime(2023, 9, 20, 14, 30, 24, 405);
            // 
            // txtPhone
            // 
            this.txtPhone.AutoRoundedCorners = true;
            this.txtPhone.AutoSize = true;
            this.txtPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtPhone.BorderRadius = 19;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtPhone.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtPhone.Location = new System.Drawing.Point(383, 292);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPhone.PlaceholderText = "08XXXXXXXXX";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(250, 40);
            this.txtPhone.TabIndex = 34;
            this.txtPhone.Tag = "p";
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.BackColor = System.Drawing.Color.Transparent;
            this.lblInformation.ForeColor = System.Drawing.Color.Black;
            this.lblInformation.Location = new System.Drawing.Point(393, 473);
            this.lblInformation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(49, 24);
            this.lblInformation.TabIndex = 36;
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
            this.txtInformation.Location = new System.Drawing.Point(383, 499);
            this.txtInformation.Margin = new System.Windows.Forms.Padding(2);
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.PasswordChar = '\0';
            this.txtInformation.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtInformation.PlaceholderText = "";
            this.txtInformation.SelectedText = "";
            this.txtInformation.Size = new System.Drawing.Size(250, 40);
            this.txtInformation.TabIndex = 35;
            this.txtInformation.Tag = "";
            // 
            // pictProfile
            // 
            this.pictProfile.BackColor = System.Drawing.Color.Transparent;
            this.pictProfile.Image = global::POS_SYSTEM.Properties.Resources.businessman_color;
            this.pictProfile.ImageRotate = 0F;
            this.pictProfile.Location = new System.Drawing.Point(722, 265);
            this.pictProfile.Name = "pictProfile";
            this.pictProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictProfile.Size = new System.Drawing.Size(180, 180);
            this.pictProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictProfile.TabIndex = 37;
            this.pictProfile.TabStop = false;
            this.pictProfile.UseTransparentBackground = true;
            // 
            // lblPP
            // 
            this.lblPP.AutoSize = true;
            this.lblPP.BackColor = System.Drawing.Color.Transparent;
            this.lblPP.ForeColor = System.Drawing.Color.Black;
            this.lblPP.Location = new System.Drawing.Point(741, 226);
            this.lblPP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPP.Name = "lblPP";
            this.lblPP.Size = new System.Drawing.Size(146, 24);
            this.lblPP.TabIndex = 38;
            this.lblPP.Text = "Profile Picture";
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
            this.btnBrowse.Location = new System.Drawing.Point(740, 459);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(140, 40);
            this.btnBrowse.TabIndex = 39;
            this.btnBrowse.Text = "BROWSE";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioMale.CheckedState.BorderThickness = 0;
            this.radioMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioMale.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radioMale.CheckedState.InnerOffset = -4;
            this.radioMale.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.radioMale.Location = new System.Drawing.Point(383, 189);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(80, 28);
            this.radioMale.TabIndex = 40;
            this.radioMale.Tag = "r";
            this.radioMale.Text = "Male";
            this.radioMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioMale.UncheckedState.BorderThickness = 2;
            this.radioMale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioMale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioFemale.CheckedState.BorderThickness = 0;
            this.radioFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioFemale.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radioFemale.CheckedState.InnerOffset = -4;
            this.radioFemale.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.radioFemale.Location = new System.Drawing.Point(494, 189);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(106, 28);
            this.radioFemale.TabIndex = 41;
            this.radioFemale.Tag = "r";
            this.radioFemale.Text = "Female";
            this.radioFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioFemale.UncheckedState.BorderThickness = 2;
            this.radioFemale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioFemale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // frmStaffAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 674);
            this.Controls.Add(this.radioFemale);
            this.Controls.Add(this.radioMale);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblPP);
            this.Controls.Add(this.pictProfile);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.txtInformation);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.dateJoin);
            this.Controls.Add(this.lblJoinDate);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.lblStaffID);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.comboRole);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmStaffAdd";
            this.Text = "frmStaffAdd";
            this.Load += new System.EventHandler(this.frmStaffAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRole;
        public Guna.UI2.WinForms.Guna2TextBox txtStaffID;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblPhone;
        public Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblJoinDate;
        public Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private System.Windows.Forms.Label lblInformation;
        public Guna.UI2.WinForms.Guna2TextBox txtInformation;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictProfile;
        private System.Windows.Forms.Label lblPP;
        public Guna.UI2.WinForms.Guna2Button btnBrowse;
        public System.Windows.Forms.ComboBox comboRole;
        public Guna.UI2.WinForms.Guna2DateTimePicker dateJoin;
        public Guna.UI2.WinForms.Guna2RadioButton radioMale;
        public Guna.UI2.WinForms.Guna2RadioButton radioFemale;
    }
}