namespace POS_SYSTEM.Model
{
    partial class frmUserAdd
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
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.comboStaffID = new System.Windows.Forms.ComboBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPP = new System.Windows.Forms.Label();
            this.pictProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pictHide = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictShow = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblInformation = new System.Windows.Forms.Label();
            this.txtInformation = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnGP = new Guna.UI2.WinForms.Guna2Button();
            this.btnGenerateNewPassword = new Guna.UI2.WinForms.Guna2Button();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.pictShowNew = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictHideNew = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictShowNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictHideNew)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.AutoRoundedCorners = true;
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BorderRadius = 19;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.IconLeft = global::POS_SYSTEM.Properties.Resources._lock;
            this.txtPassword.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtPassword.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtPassword.Location = new System.Drawing.Point(52, 386);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(250, 40);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.Tag = "t";
            // 
            // txtUsername
            // 
            this.txtUsername.AutoRoundedCorners = true;
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BorderRadius = 19;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.IconLeft = global::POS_SYSTEM.Properties.Resources.username;
            this.txtUsername.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtUsername.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtUsername.Location = new System.Drawing.Point(52, 287);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(250, 40);
            this.txtUsername.TabIndex = 11;
            this.txtUsername.Tag = "t";
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
            this.lblStaffID.TabIndex = 20;
            this.lblStaffID.Text = "Staff ID";
            // 
            // comboStaffID
            // 
            this.comboStaffID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboStaffID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboStaffID.DropDownHeight = 105;
            this.comboStaffID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboStaffID.FormattingEnabled = true;
            this.comboStaffID.IntegralHeight = false;
            this.comboStaffID.Location = new System.Drawing.Point(52, 185);
            this.comboStaffID.Name = "comboStaffID";
            this.comboStaffID.Size = new System.Drawing.Size(250, 32);
            this.comboStaffID.TabIndex = 19;
            this.comboStaffID.Tag = "com";
            this.comboStaffID.SelectedIndexChanged += new System.EventHandler(this.comboStaffID_SelectedIndexChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(69, 259);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(113, 24);
            this.lblUsername.TabIndex = 21;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(69, 358);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(104, 24);
            this.lblPassword.TabIndex = 22;
            this.lblPassword.Text = "Password";
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
            this.txtName.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtName.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtName.Location = new System.Drawing.Point(383, 185);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtName.PlaceholderText = "auto complete";
            this.txtName.ReadOnly = true;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(250, 40);
            this.txtName.TabIndex = 24;
            this.txtName.Tag = "t";
            // 
            // lblPP
            // 
            this.lblPP.AutoSize = true;
            this.lblPP.BackColor = System.Drawing.Color.Transparent;
            this.lblPP.ForeColor = System.Drawing.Color.Black;
            this.lblPP.Location = new System.Drawing.Point(717, 233);
            this.lblPP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPP.Name = "lblPP";
            this.lblPP.Size = new System.Drawing.Size(146, 24);
            this.lblPP.TabIndex = 40;
            this.lblPP.Text = "Profile Picture";
            // 
            // pictProfile
            // 
            this.pictProfile.BackColor = System.Drawing.Color.Transparent;
            this.pictProfile.Image = global::POS_SYSTEM.Properties.Resources.businessman_color;
            this.pictProfile.ImageRotate = 0F;
            this.pictProfile.Location = new System.Drawing.Point(701, 260);
            this.pictProfile.Name = "pictProfile";
            this.pictProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictProfile.Size = new System.Drawing.Size(180, 180);
            this.pictProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictProfile.TabIndex = 39;
            this.pictProfile.TabStop = false;
            this.pictProfile.UseTransparentBackground = true;
            // 
            // pictHide
            // 
            this.pictHide.BackColor = System.Drawing.Color.Transparent;
            this.pictHide.Image = global::POS_SYSTEM.Properties.Resources.hidden;
            this.pictHide.ImageRotate = 0F;
            this.pictHide.Location = new System.Drawing.Point(257, 391);
            this.pictHide.Name = "pictHide";
            this.pictHide.Size = new System.Drawing.Size(30, 30);
            this.pictHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictHide.TabIndex = 41;
            this.pictHide.TabStop = false;
            this.pictHide.UseTransparentBackground = true;
            this.pictHide.Visible = false;
            this.pictHide.Click += new System.EventHandler(this.pictHide_Click);
            // 
            // pictShow
            // 
            this.pictShow.BackColor = System.Drawing.Color.Transparent;
            this.pictShow.Image = global::POS_SYSTEM.Properties.Resources.show;
            this.pictShow.ImageRotate = 0F;
            this.pictShow.Location = new System.Drawing.Point(257, 391);
            this.pictShow.Name = "pictShow";
            this.pictShow.Size = new System.Drawing.Size(30, 30);
            this.pictShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictShow.TabIndex = 42;
            this.pictShow.TabStop = false;
            this.pictShow.UseTransparentBackground = true;
            this.pictShow.Click += new System.EventHandler(this.pictShow_Click);
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.BackColor = System.Drawing.Color.Transparent;
            this.lblInformation.ForeColor = System.Drawing.Color.Black;
            this.lblInformation.Location = new System.Drawing.Point(400, 259);
            this.lblInformation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(49, 24);
            this.lblInformation.TabIndex = 45;
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
            this.txtInformation.Location = new System.Drawing.Point(383, 285);
            this.txtInformation.Margin = new System.Windows.Forms.Padding(2);
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.PasswordChar = '\0';
            this.txtInformation.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtInformation.PlaceholderText = "";
            this.txtInformation.SelectedText = "";
            this.txtInformation.Size = new System.Drawing.Size(250, 40);
            this.txtInformation.TabIndex = 44;
            this.txtInformation.Tag = "";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(400, 159);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 24);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Name";
            // 
            // btnGP
            // 
            this.btnGP.Animated = true;
            this.btnGP.AutoRoundedCorners = true;
            this.btnGP.BackColor = System.Drawing.Color.Transparent;
            this.btnGP.BorderRadius = 11;
            this.btnGP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGP.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnGP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGP.ForeColor = System.Drawing.Color.White;
            this.btnGP.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGP.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnGP.ImageSize = new System.Drawing.Size(25, 25);
            this.btnGP.Location = new System.Drawing.Point(52, 433);
            this.btnGP.Name = "btnGP";
            this.btnGP.Size = new System.Drawing.Size(152, 25);
            this.btnGP.TabIndex = 43;
            this.btnGP.Text = "Generate Password";
            this.btnGP.Click += new System.EventHandler(this.btnGP_Click);
            // 
            // btnGenerateNewPassword
            // 
            this.btnGenerateNewPassword.Animated = true;
            this.btnGenerateNewPassword.AutoRoundedCorners = true;
            this.btnGenerateNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerateNewPassword.BorderRadius = 11;
            this.btnGenerateNewPassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateNewPassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerateNewPassword.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnGenerateNewPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateNewPassword.ForeColor = System.Drawing.Color.White;
            this.btnGenerateNewPassword.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGenerateNewPassword.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnGenerateNewPassword.ImageSize = new System.Drawing.Size(25, 25);
            this.btnGenerateNewPassword.Location = new System.Drawing.Point(383, 433);
            this.btnGenerateNewPassword.Name = "btnGenerateNewPassword";
            this.btnGenerateNewPassword.Size = new System.Drawing.Size(152, 25);
            this.btnGenerateNewPassword.TabIndex = 50;
            this.btnGenerateNewPassword.Text = "Generate Password";
            this.btnGenerateNewPassword.Visible = false;
            this.btnGenerateNewPassword.Click += new System.EventHandler(this.btnGenerateNewPassword_Click);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPassword.ForeColor = System.Drawing.Color.Black;
            this.lblNewPassword.Location = new System.Drawing.Point(400, 358);
            this.lblNewPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(158, 24);
            this.lblNewPassword.TabIndex = 47;
            this.lblNewPassword.Text = "New Password";
            this.lblNewPassword.Visible = false;
            // 
            // pictShowNew
            // 
            this.pictShowNew.BackColor = System.Drawing.Color.Transparent;
            this.pictShowNew.Image = global::POS_SYSTEM.Properties.Resources.show;
            this.pictShowNew.ImageRotate = 0F;
            this.pictShowNew.Location = new System.Drawing.Point(588, 391);
            this.pictShowNew.Name = "pictShowNew";
            this.pictShowNew.Size = new System.Drawing.Size(30, 30);
            this.pictShowNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictShowNew.TabIndex = 49;
            this.pictShowNew.TabStop = false;
            this.pictShowNew.UseTransparentBackground = true;
            this.pictShowNew.Visible = false;
            this.pictShowNew.Click += new System.EventHandler(this.pictShowNew_Click);
            // 
            // pictHideNew
            // 
            this.pictHideNew.BackColor = System.Drawing.Color.Transparent;
            this.pictHideNew.Image = global::POS_SYSTEM.Properties.Resources.hidden;
            this.pictHideNew.ImageRotate = 0F;
            this.pictHideNew.Location = new System.Drawing.Point(588, 391);
            this.pictHideNew.Name = "pictHideNew";
            this.pictHideNew.Size = new System.Drawing.Size(30, 30);
            this.pictHideNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictHideNew.TabIndex = 48;
            this.pictHideNew.TabStop = false;
            this.pictHideNew.UseTransparentBackground = true;
            this.pictHideNew.Visible = false;
            this.pictHideNew.Click += new System.EventHandler(this.pictHideNew_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.AutoRoundedCorners = true;
            this.txtNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtNewPassword.BorderRadius = 19;
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.DefaultText = "";
            this.txtNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPassword.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.ForeColor = System.Drawing.Color.Black;
            this.txtNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPassword.IconLeft = global::POS_SYSTEM.Properties.Resources._lock;
            this.txtNewPassword.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtNewPassword.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtNewPassword.Location = new System.Drawing.Point(383, 386);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '●';
            this.txtNewPassword.PlaceholderText = "Password";
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.Size = new System.Drawing.Size(250, 40);
            this.txtNewPassword.TabIndex = 46;
            this.txtNewPassword.Tag = "";
            this.txtNewPassword.Visible = false;
            // 
            // frmUserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 628);
            this.Controls.Add(this.btnGenerateNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.txtInformation);
            this.Controls.Add(this.btnGP);
            this.Controls.Add(this.lblPP);
            this.Controls.Add(this.pictProfile);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblStaffID);
            this.Controls.Add(this.comboStaffID);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pictShow);
            this.Controls.Add(this.pictHide);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.pictShowNew);
            this.Controls.Add(this.pictHideNew);
            this.Controls.Add(this.txtNewPassword);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmUserAdd";
            this.Text = "frmUserAdd";
            this.Load += new System.EventHandler(this.frmUserAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictShowNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictHideNew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2TextBox txtPassword;
        public Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private System.Windows.Forms.Label lblStaffID;
        public System.Windows.Forms.ComboBox comboStaffID;
        private System.Windows.Forms.Label lblUsername;
        public Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label lblPP;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictProfile;
        private Guna.UI2.WinForms.Guna2PictureBox pictHide;
        private Guna.UI2.WinForms.Guna2PictureBox pictShow;
        private System.Windows.Forms.Label lblInformation;
        public Guna.UI2.WinForms.Guna2TextBox txtInformation;
        private System.Windows.Forms.Label lblName;
        public Guna.UI2.WinForms.Guna2Button btnGP;
        public Guna.UI2.WinForms.Guna2Button btnGenerateNewPassword;
        public Guna.UI2.WinForms.Guna2TextBox txtNewPassword;
        public System.Windows.Forms.Label lblPassword;
        public Guna.UI2.WinForms.Guna2PictureBox pictShowNew;
        public Guna.UI2.WinForms.Guna2PictureBox pictHideNew;
        public System.Windows.Forms.Label lblNewPassword;
    }
}