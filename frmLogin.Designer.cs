namespace POS_SYSTEM
{
    partial class frmLogin
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
            this.elipsForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelMain = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.controlExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pictShow = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictHide = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblHead1 = new System.Windows.Forms.Label();
            this.lblHead2 = new System.Windows.Forms.Label();
            this.lblHead3 = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // elipsForm
            // 
            this.elipsForm.BorderRadius = 60;
            this.elipsForm.TargetControl = this;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.btnLogin);
            this.panelMain.Controls.Add(this.controlExit);
            this.panelMain.Controls.Add(this.txtUsername);
            this.panelMain.Controls.Add(this.lblLogin);
            this.panelMain.Controls.Add(this.pictShow);
            this.panelMain.Controls.Add(this.pictHide);
            this.panelMain.Controls.Add(this.txtPassword);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(169)))), ((int)(((byte)(230)))));
            this.panelMain.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(169)))), ((int)(((byte)(230)))));
            this.panelMain.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(200)))), ((int)(((byte)(248)))));
            this.panelMain.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(200)))), ((int)(((byte)(248)))));
            this.panelMain.Location = new System.Drawing.Point(360, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(600, 540);
            this.panelMain.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.AutoRoundedCorners = true;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 19;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogin.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnLogin.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLogin.Location = new System.Drawing.Point(188, 384);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(140, 40);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // controlExit
            // 
            this.controlExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlExit.BackColor = System.Drawing.Color.Transparent;
            this.controlExit.FillColor = System.Drawing.Color.Transparent;
            this.controlExit.IconColor = System.Drawing.Color.White;
            this.controlExit.Location = new System.Drawing.Point(543, 12);
            this.controlExit.Name = "controlExit";
            this.controlExit.Size = new System.Drawing.Size(45, 30);
            this.controlExit.TabIndex = 12;
            this.controlExit.Click += new System.EventHandler(this.controlExit_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.txtUsername.Location = new System.Drawing.Point(94, 260);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(350, 40);
            this.txtUsername.TabIndex = 9;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(90, 213);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(233, 25);
            this.lblLogin.TabIndex = 8;
            this.lblLogin.Text = "Login to your account";
            // 
            // pictShow
            // 
            this.pictShow.BackColor = System.Drawing.Color.Transparent;
            this.pictShow.Image = global::POS_SYSTEM.Properties.Resources.show;
            this.pictShow.ImageRotate = 0F;
            this.pictShow.Location = new System.Drawing.Point(393, 318);
            this.pictShow.Name = "pictShow";
            this.pictShow.Size = new System.Drawing.Size(30, 30);
            this.pictShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictShow.TabIndex = 8;
            this.pictShow.TabStop = false;
            this.pictShow.UseTransparentBackground = true;
            this.pictShow.Click += new System.EventHandler(this.pictShow_Click);
            // 
            // pictHide
            // 
            this.pictHide.BackColor = System.Drawing.Color.Transparent;
            this.pictHide.Image = global::POS_SYSTEM.Properties.Resources.hidden;
            this.pictHide.ImageRotate = 0F;
            this.pictHide.Location = new System.Drawing.Point(393, 318);
            this.pictHide.Name = "pictHide";
            this.pictHide.Size = new System.Drawing.Size(30, 30);
            this.pictHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictHide.TabIndex = 11;
            this.pictHide.TabStop = false;
            this.pictHide.UseTransparentBackground = true;
            this.pictHide.Visible = false;
            this.pictHide.Click += new System.EventHandler(this.pictHide_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.txtPassword.Location = new System.Drawing.Point(94, 313);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(350, 40);
            this.txtPassword.TabIndex = 10;
            // 
            // lblHead1
            // 
            this.lblHead1.AutoSize = true;
            this.lblHead1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead1.Location = new System.Drawing.Point(194, 286);
            this.lblHead1.Name = "lblHead1";
            this.lblHead1.Size = new System.Drawing.Size(138, 24);
            this.lblHead1.TabIndex = 2;
            this.lblHead1.Text = "Welcome to";
            // 
            // lblHead2
            // 
            this.lblHead2.AutoSize = true;
            this.lblHead2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead2.Location = new System.Drawing.Point(77, 318);
            this.lblHead2.Name = "lblHead2";
            this.lblHead2.Size = new System.Drawing.Size(255, 24);
            this.lblHead2.TabIndex = 3;
            this.lblHead2.Text = "Inventory Management";
            // 
            // lblHead3
            // 
            this.lblHead3.AutoSize = true;
            this.lblHead3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead3.Location = new System.Drawing.Point(251, 350);
            this.lblHead3.Name = "lblHead3";
            this.lblHead3.Size = new System.Drawing.Size(81, 24);
            this.lblHead3.TabIndex = 4;
            this.lblHead3.Text = "System";
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredit.Location = new System.Drawing.Point(207, 472);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(110, 17);
            this.lblCredit.TabIndex = 6;
            this.lblCredit.Text = "progammed by";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::POS_SYSTEM.Properties.Resources.codelabs_logo_rectangle;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(205, 492);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(120, 25);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 7;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // pictLogo
            // 
            this.pictLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictLogo.Image = global::POS_SYSTEM.Properties.Resources.codelabs_logo_rectangle;
            this.pictLogo.ImageRotate = 0F;
            this.pictLogo.Location = new System.Drawing.Point(104, 66);
            this.pictLogo.Name = "pictLogo";
            this.pictLogo.Size = new System.Drawing.Size(150, 150);
            this.pictLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictLogo.TabIndex = 1;
            this.pictLogo.TabStop = false;
            this.pictLogo.UseTransparentBackground = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.lblHead3);
            this.Controls.Add(this.lblHead2);
            this.Controls.Add(this.lblHead1);
            this.Controls.Add(this.pictLogo);
            this.Controls.Add(this.panelMain);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elipsForm;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelMain;
        private System.Windows.Forms.Label lblHead3;
        private System.Windows.Forms.Label lblHead2;
        private System.Windows.Forms.Label lblHead1;
        private Guna.UI2.WinForms.Guna2PictureBox pictLogo;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Label lblLogin;
        public Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2ControlBox controlExit;
        private Guna.UI2.WinForms.Guna2PictureBox pictHide;
        private Guna.UI2.WinForms.Guna2PictureBox pictShow;
        public Guna.UI2.WinForms.Guna2TextBox txtPassword;
        public Guna.UI2.WinForms.Guna2Button btnLogin;
    }
}