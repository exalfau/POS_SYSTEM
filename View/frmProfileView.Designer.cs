namespace POS_SYSTEM.View
{
    partial class frmProfileView
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
            this.panelProfile = new Guna.UI2.WinForms.Guna2Panel();
            this.btnPrevious = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.lblPP = new System.Windows.Forms.Label();
            this.pictProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnEditAcount = new Guna.UI2.WinForms.Guna2Button();
            this.panelAccount = new Guna.UI2.WinForms.Guna2Panel();
            this.lblInfoAcount = new System.Windows.Forms.Label();
            this.lblInfoAcountText = new System.Windows.Forms.Label();
            this.lblUsernameText = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panelGT = new Guna.UI2.WinForms.Guna2Panel();
            this.lblAddressText = new System.Windows.Forms.Label();
            this.lblInformation = new System.Windows.Forms.Label();
            this.lblInfoText = new System.Windows.Forms.Label();
            this.lblNameText = new System.Windows.Forms.Label();
            this.lblJoinDateText = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblRoleText = new System.Windows.Forms.Label();
            this.lblJoinDate = new System.Windows.Forms.Label();
            this.lblGenderText = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblStaffIDText = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPhoneText = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.elipsTable = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dataStaff = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.panelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictProfile)).BeginInit();
            this.panelAccount.SuspendLayout();
            this.panelGT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // panelProfile
            // 
            this.panelProfile.BackColor = System.Drawing.Color.Transparent;
            this.panelProfile.BorderRadius = 50;
            this.panelProfile.Controls.Add(this.btnPrevious);
            this.panelProfile.Controls.Add(this.btnNext);
            this.panelProfile.Controls.Add(this.btnEdit);
            this.panelProfile.Controls.Add(this.lblPP);
            this.panelProfile.Controls.Add(this.pictProfile);
            this.panelProfile.Controls.Add(this.btnEditAcount);
            this.panelProfile.Controls.Add(this.panelGT);
            this.panelProfile.Controls.Add(this.panelAccount);
            this.panelProfile.FillColor = System.Drawing.Color.CornflowerBlue;
            this.panelProfile.Location = new System.Drawing.Point(934, 64);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(554, 950);
            this.panelProfile.TabIndex = 3;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Animated = true;
            this.btnPrevious.AutoRoundedCorners = true;
            this.btnPrevious.BorderRadius = 29;
            this.btnPrevious.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrevious.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrevious.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrevious.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrevious.FillColor = System.Drawing.Color.Transparent;
            this.btnPrevious.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Image = global::POS_SYSTEM.Properties.Resources.left_arrow;
            this.btnPrevious.ImageSize = new System.Drawing.Size(40, 40);
            this.btnPrevious.Location = new System.Drawing.Point(62, 838);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(60, 60);
            this.btnPrevious.TabIndex = 75;
            this.btnPrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPrevious.Visible = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Animated = true;
            this.btnNext.AutoRoundedCorners = true;
            this.btnNext.BorderRadius = 29;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.Transparent;
            this.btnNext.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = global::POS_SYSTEM.Properties.Resources.right_arrow;
            this.btnNext.ImageSize = new System.Drawing.Size(40, 40);
            this.btnNext.Location = new System.Drawing.Point(415, 838);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(60, 60);
            this.btnNext.TabIndex = 74;
            this.btnNext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Animated = true;
            this.btnEdit.AutoRoundedCorners = true;
            this.btnEdit.BorderRadius = 19;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEdit.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnEdit.ImageSize = new System.Drawing.Size(25, 25);
            this.btnEdit.Location = new System.Drawing.Point(201, 848);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(147, 40);
            this.btnEdit.TabIndex = 72;
            this.btnEdit.Text = "  EDIT PROFILE";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblPP
            // 
            this.lblPP.AutoSize = true;
            this.lblPP.BackColor = System.Drawing.Color.Transparent;
            this.lblPP.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPP.ForeColor = System.Drawing.Color.White;
            this.lblPP.Location = new System.Drawing.Point(211, 52);
            this.lblPP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPP.Name = "lblPP";
            this.lblPP.Size = new System.Drawing.Size(148, 25);
            this.lblPP.TabIndex = 41;
            this.lblPP.Text = "Profile Picture";
            // 
            // pictProfile
            // 
            this.pictProfile.BackColor = System.Drawing.Color.Transparent;
            this.pictProfile.Image = global::POS_SYSTEM.Properties.Resources.businessman_color;
            this.pictProfile.ImageRotate = 0F;
            this.pictProfile.Location = new System.Drawing.Point(192, 91);
            this.pictProfile.Name = "pictProfile";
            this.pictProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictProfile.Size = new System.Drawing.Size(180, 180);
            this.pictProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictProfile.TabIndex = 40;
            this.pictProfile.TabStop = false;
            this.pictProfile.UseTransparentBackground = true;
            // 
            // btnEditAcount
            // 
            this.btnEditAcount.Animated = true;
            this.btnEditAcount.AutoRoundedCorners = true;
            this.btnEditAcount.BorderRadius = 19;
            this.btnEditAcount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditAcount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditAcount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditAcount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditAcount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnEditAcount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAcount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditAcount.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEditAcount.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnEditAcount.ImageSize = new System.Drawing.Size(25, 25);
            this.btnEditAcount.Location = new System.Drawing.Point(190, 848);
            this.btnEditAcount.Name = "btnEditAcount";
            this.btnEditAcount.Size = new System.Drawing.Size(167, 40);
            this.btnEditAcount.TabIndex = 76;
            this.btnEditAcount.Text = "  EDIT ACCOUNT";
            this.btnEditAcount.Visible = false;
            this.btnEditAcount.Click += new System.EventHandler(this.btnEditAcount_Click);
            // 
            // panelAccount
            // 
            this.panelAccount.BackColor = System.Drawing.Color.Transparent;
            this.panelAccount.BorderRadius = 40;
            this.panelAccount.Controls.Add(this.lblInfoAcount);
            this.panelAccount.Controls.Add(this.lblUsername);
            this.panelAccount.Controls.Add(this.lblInfoAcountText);
            this.panelAccount.Controls.Add(this.lblUsernameText);
            this.panelAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(169)))), ((int)(((byte)(230)))));
            this.panelAccount.Location = new System.Drawing.Point(31, 307);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(496, 496);
            this.panelAccount.TabIndex = 77;
            this.panelAccount.Visible = false;
            // 
            // lblInfoAcount
            // 
            this.lblInfoAcount.AutoSize = true;
            this.lblInfoAcount.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoAcount.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoAcount.ForeColor = System.Drawing.Color.White;
            this.lblInfoAcount.Location = new System.Drawing.Point(35, 171);
            this.lblInfoAcount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfoAcount.Name = "lblInfoAcount";
            this.lblInfoAcount.Size = new System.Drawing.Size(130, 25);
            this.lblInfoAcount.TabIndex = 57;
            this.lblInfoAcount.Text = "Info Acount";
            // 
            // lblInfoAcountText
            // 
            this.lblInfoAcountText.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoAcountText.ForeColor = System.Drawing.Color.White;
            this.lblInfoAcountText.Location = new System.Drawing.Point(35, 195);
            this.lblInfoAcountText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfoAcountText.Name = "lblInfoAcountText";
            this.lblInfoAcountText.Size = new System.Drawing.Size(200, 80);
            this.lblInfoAcountText.TabIndex = 68;
            // 
            // lblUsernameText
            // 
            this.lblUsernameText.BackColor = System.Drawing.Color.Transparent;
            this.lblUsernameText.ForeColor = System.Drawing.Color.White;
            this.lblUsernameText.Location = new System.Drawing.Point(35, 76);
            this.lblUsernameText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsernameText.Name = "lblUsernameText";
            this.lblUsernameText.Size = new System.Drawing.Size(200, 80);
            this.lblUsernameText.TabIndex = 64;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(35, 52);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(115, 25);
            this.lblUsername.TabIndex = 47;
            this.lblUsername.Text = "Username";
            // 
            // panelGT
            // 
            this.panelGT.BackColor = System.Drawing.Color.Transparent;
            this.panelGT.BorderRadius = 40;
            this.panelGT.Controls.Add(this.lblAddressText);
            this.panelGT.Controls.Add(this.lblInformation);
            this.panelGT.Controls.Add(this.lblInfoText);
            this.panelGT.Controls.Add(this.lblNameText);
            this.panelGT.Controls.Add(this.lblJoinDateText);
            this.panelGT.Controls.Add(this.lblAddress);
            this.panelGT.Controls.Add(this.lblRoleText);
            this.panelGT.Controls.Add(this.lblJoinDate);
            this.panelGT.Controls.Add(this.lblGenderText);
            this.panelGT.Controls.Add(this.lblRole);
            this.panelGT.Controls.Add(this.lblStaffIDText);
            this.panelGT.Controls.Add(this.lblGender);
            this.panelGT.Controls.Add(this.lblPhoneText);
            this.panelGT.Controls.Add(this.lblPhone);
            this.panelGT.Controls.Add(this.lblStaffID);
            this.panelGT.Controls.Add(this.lblName);
            this.panelGT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(169)))), ((int)(((byte)(230)))));
            this.panelGT.Location = new System.Drawing.Point(31, 307);
            this.panelGT.Name = "panelGT";
            this.panelGT.Size = new System.Drawing.Size(496, 496);
            this.panelGT.TabIndex = 73;
            // 
            // lblAddressText
            // 
            this.lblAddressText.BackColor = System.Drawing.Color.Transparent;
            this.lblAddressText.ForeColor = System.Drawing.Color.White;
            this.lblAddressText.Location = new System.Drawing.Point(274, 401);
            this.lblAddressText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddressText.Name = "lblAddressText";
            this.lblAddressText.Size = new System.Drawing.Size(210, 80);
            this.lblAddressText.TabIndex = 69;
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.BackColor = System.Drawing.Color.Transparent;
            this.lblInformation.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.ForeColor = System.Drawing.Color.White;
            this.lblInformation.Location = new System.Drawing.Point(35, 377);
            this.lblInformation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(50, 25);
            this.lblInformation.TabIndex = 57;
            this.lblInformation.Text = "Info";
            // 
            // lblInfoText
            // 
            this.lblInfoText.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoText.ForeColor = System.Drawing.Color.White;
            this.lblInfoText.Location = new System.Drawing.Point(35, 401);
            this.lblInfoText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfoText.Name = "lblInfoText";
            this.lblInfoText.Size = new System.Drawing.Size(210, 80);
            this.lblInfoText.TabIndex = 68;
            // 
            // lblNameText
            // 
            this.lblNameText.BackColor = System.Drawing.Color.Transparent;
            this.lblNameText.ForeColor = System.Drawing.Color.White;
            this.lblNameText.Location = new System.Drawing.Point(274, 76);
            this.lblNameText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameText.Name = "lblNameText";
            this.lblNameText.Size = new System.Drawing.Size(210, 80);
            this.lblNameText.TabIndex = 71;
            // 
            // lblJoinDateText
            // 
            this.lblJoinDateText.BackColor = System.Drawing.Color.Transparent;
            this.lblJoinDateText.ForeColor = System.Drawing.Color.White;
            this.lblJoinDateText.Location = new System.Drawing.Point(28, 294);
            this.lblJoinDateText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJoinDateText.Name = "lblJoinDateText";
            this.lblJoinDateText.Size = new System.Drawing.Size(210, 80);
            this.lblJoinDateText.TabIndex = 66;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(273, 377);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(94, 25);
            this.lblAddress.TabIndex = 53;
            this.lblAddress.Text = "Address";
            // 
            // lblRoleText
            // 
            this.lblRoleText.BackColor = System.Drawing.Color.Transparent;
            this.lblRoleText.ForeColor = System.Drawing.Color.White;
            this.lblRoleText.Location = new System.Drawing.Point(28, 184);
            this.lblRoleText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoleText.Name = "lblRoleText";
            this.lblRoleText.Size = new System.Drawing.Size(210, 80);
            this.lblRoleText.TabIndex = 65;
            // 
            // lblJoinDate
            // 
            this.lblJoinDate.AutoSize = true;
            this.lblJoinDate.BackColor = System.Drawing.Color.Transparent;
            this.lblJoinDate.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoinDate.ForeColor = System.Drawing.Color.White;
            this.lblJoinDate.Location = new System.Drawing.Point(28, 270);
            this.lblJoinDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJoinDate.Name = "lblJoinDate";
            this.lblJoinDate.Size = new System.Drawing.Size(107, 25);
            this.lblJoinDate.TabIndex = 49;
            this.lblJoinDate.Text = "Join Date";
            // 
            // lblGenderText
            // 
            this.lblGenderText.BackColor = System.Drawing.Color.Transparent;
            this.lblGenderText.ForeColor = System.Drawing.Color.White;
            this.lblGenderText.Location = new System.Drawing.Point(274, 184);
            this.lblGenderText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenderText.Name = "lblGenderText";
            this.lblGenderText.Size = new System.Drawing.Size(210, 80);
            this.lblGenderText.TabIndex = 70;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.BackColor = System.Drawing.Color.Transparent;
            this.lblRole.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(28, 160);
            this.lblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(55, 25);
            this.lblRole.TabIndex = 46;
            this.lblRole.Text = "Role";
            // 
            // lblStaffIDText
            // 
            this.lblStaffIDText.BackColor = System.Drawing.Color.Transparent;
            this.lblStaffIDText.ForeColor = System.Drawing.Color.White;
            this.lblStaffIDText.Location = new System.Drawing.Point(28, 76);
            this.lblStaffIDText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffIDText.Name = "lblStaffIDText";
            this.lblStaffIDText.Size = new System.Drawing.Size(210, 80);
            this.lblStaffIDText.TabIndex = 64;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Location = new System.Drawing.Point(273, 160);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(90, 25);
            this.lblGender.TabIndex = 67;
            this.lblGender.Text = "Gender";
            // 
            // lblPhoneText
            // 
            this.lblPhoneText.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneText.ForeColor = System.Drawing.Color.White;
            this.lblPhoneText.Location = new System.Drawing.Point(274, 294);
            this.lblPhoneText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneText.Name = "lblPhoneText";
            this.lblPhoneText.Size = new System.Drawing.Size(210, 80);
            this.lblPhoneText.TabIndex = 67;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(273, 270);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(76, 25);
            this.lblPhone.TabIndex = 52;
            this.lblPhone.Text = "Phone";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.BackColor = System.Drawing.Color.Transparent;
            this.lblStaffID.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffID.ForeColor = System.Drawing.Color.White;
            this.lblStaffID.Location = new System.Drawing.Point(28, 52);
            this.lblStaffID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(82, 25);
            this.lblStaffID.TabIndex = 47;
            this.lblStaffID.Text = "Staff ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(274, 52);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 25);
            this.lblName.TabIndex = 43;
            this.lblName.Text = "Name";
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(298, 50);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(200, 40);
            this.lblHeader.TabIndex = 5;
            this.lblHeader.Text = "Sale History";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 30F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::POS_SYSTEM.Properties.Resources.edit;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 50;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.FillWeight = 40F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::POS_SYSTEM.Properties.Resources.delete;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 50;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // elipsTable
            // 
            this.elipsTable.BorderRadius = 30;
            this.elipsTable.TargetControl = this.dataStaff;
            // 
            // dataStaff
            // 
            this.dataStaff.AllowUserToAddRows = false;
            this.dataStaff.AllowUserToDeleteRows = false;
            this.dataStaff.AllowUserToOrderColumns = true;
            this.dataStaff.AllowUserToResizeColumns = false;
            this.dataStaff.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataStaff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataStaff.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(169)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataStaff.ColumnHeadersHeight = 50;
            this.dataStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataStaff.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataStaff.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataStaff.Location = new System.Drawing.Point(41, 193);
            this.dataStaff.Name = "dataStaff";
            this.dataStaff.RowHeadersVisible = false;
            this.dataStaff.Size = new System.Drawing.Size(852, 821);
            this.dataStaff.TabIndex = 11;
            this.dataStaff.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataStaff.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataStaff.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataStaff.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataStaff.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataStaff.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataStaff.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataStaff.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataStaff.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataStaff.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataStaff.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataStaff.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataStaff.ThemeStyle.HeaderStyle.Height = 50;
            this.dataStaff.ThemeStyle.ReadOnly = false;
            this.dataStaff.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataStaff.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataStaff.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataStaff.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataStaff.ThemeStyle.RowsStyle.Height = 22;
            this.dataStaff.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataStaff.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.AutoRoundedCorners = true;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderRadius = 19;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeft = global::POS_SYSTEM.Properties.Resources.search;
            this.txtSearch.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtSearch.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtSearch.Location = new System.Drawing.Point(50, 116);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search Here";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(250, 40);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvID
            // 
            this.dgvID.FillWeight = 30F;
            this.dgvID.HeaderText = "";
            this.dgvID.Name = "dgvID";
            this.dgvID.Visible = false;
            // 
            // dgvInvoiceID
            // 
            this.dgvInvoiceID.FillWeight = 84.24946F;
            this.dgvInvoiceID.HeaderText = "Invoice ID";
            this.dgvInvoiceID.Name = "dgvInvoiceID";
            // 
            // dgvDateSale
            // 
            this.dgvDateSale.FillWeight = 84.24946F;
            this.dgvDateSale.HeaderText = "Date Sale";
            this.dgvDateSale.Name = "dgvDateSale";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.FillWeight = 84.24946F;
            this.dgvCustomer.HeaderText = "Customer";
            this.dgvCustomer.Name = "dgvCustomer";
            // 
            // dgvStaff
            // 
            this.dgvStaff.HeaderText = "Staff";
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.Visible = false;
            // 
            // dgvProduct
            // 
            this.dgvProduct.FillWeight = 84.24946F;
            this.dgvProduct.HeaderText = "Product";
            this.dgvProduct.Name = "dgvProduct";
            // 
            // dgvQty
            // 
            this.dgvQty.FillWeight = 40F;
            this.dgvQty.HeaderText = "Qty";
            this.dgvQty.Name = "dgvQty";
            // 
            // dgvUnitPrice
            // 
            this.dgvUnitPrice.FillWeight = 84.24946F;
            this.dgvUnitPrice.HeaderText = "Unit Price";
            this.dgvUnitPrice.Name = "dgvUnitPrice";
            // 
            // dgvTotalPrice
            // 
            this.dgvTotalPrice.FillWeight = 84.24946F;
            this.dgvTotalPrice.HeaderText = "Total Price";
            this.dgvTotalPrice.Name = "dgvTotalPrice";
            // 
            // dgvInformation
            // 
            this.dgvInformation.FillWeight = 84.24946F;
            this.dgvInformation.HeaderText = "Info";
            this.dgvInformation.Name = "dgvInformation";
            // 
            // frmProfileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1610, 1080);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataStaff);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.panelProfile);
            this.Name = "frmProfileView";
            this.Text = "frmProfileView";
            this.Load += new System.EventHandler(this.frmProfileView_Load);
            this.panelProfile.ResumeLayout(false);
            this.panelProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictProfile)).EndInit();
            this.panelAccount.ResumeLayout(false);
            this.panelAccount.PerformLayout();
            this.panelGT.ResumeLayout(false);
            this.panelGT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataStaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panelProfile;
        private System.Windows.Forms.Label lblPP;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictProfile;
        private System.Windows.Forms.Label lblJoinDate;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        public System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblRoleText;
        private System.Windows.Forms.Label lblStaffIDText;
        private System.Windows.Forms.Label lblJoinDateText;
        private System.Windows.Forms.Label lblNameText;
        private System.Windows.Forms.Label lblGenderText;
        private System.Windows.Forms.Label lblPhoneText;
        private System.Windows.Forms.Label lblAddressText;
        private System.Windows.Forms.Label lblInfoText;
        private System.Windows.Forms.Label lblGender;
        public Guna.UI2.WinForms.Guna2Button btnEdit;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private Guna.UI2.WinForms.Guna2Panel panelGT;
        public Guna.UI2.WinForms.Guna2Button btnPrevious;
        public Guna.UI2.WinForms.Guna2Button btnNext;
        public Guna.UI2.WinForms.Guna2Button btnEditAcount;
        private Guna.UI2.WinForms.Guna2Panel panelAccount;
        private System.Windows.Forms.Label lblInfoAcount;
        private System.Windows.Forms.Label lblInfoAcountText;
        private System.Windows.Forms.Label lblUsernameText;
        private System.Windows.Forms.Label lblUsername;
        public Guna.UI2.WinForms.Guna2Elipse elipsTable;
        private Guna.UI2.WinForms.Guna2DataGridView dataStaff;
        public Guna.UI2.WinForms.Guna2TextBox txtSearch;
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
    }
}