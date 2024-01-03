namespace POS_SYSTEM
{
    partial class frmMain
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
            this.panelControl = new Guna.UI2.WinForms.Guna2Panel();
            this.lblClock = new System.Windows.Forms.Label();
            this.controlMin = new Guna.UI2.WinForms.Guna2ControlBox();
            this.controlExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.flowSidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelProfile = new Guna.UI2.WinForms.Guna2Panel();
            this.pictProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.panelDashboard = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.panelStaff = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCourier = new Guna.UI2.WinForms.Guna2Button();
            this.btnAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnStaffList = new Guna.UI2.WinForms.Guna2Button();
            this.btnRole = new Guna.UI2.WinForms.Guna2Button();
            this.btnStaff = new Guna.UI2.WinForms.Guna2Button();
            this.panelInventory = new Guna.UI2.WinForms.Guna2Panel();
            this.btnStockOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnStockIn = new Guna.UI2.WinForms.Guna2Button();
            this.btnProduct = new Guna.UI2.WinForms.Guna2Button();
            this.btnCategory = new Guna.UI2.WinForms.Guna2Button();
            this.btnUnit = new Guna.UI2.WinForms.Guna2Button();
            this.btnInventory = new Guna.UI2.WinForms.Guna2Button();
            this.panelCustomer = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDeposit = new Guna.UI2.WinForms.Guna2Button();
            this.btnLoan = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerList = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.panelSupplier = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSupplier = new Guna.UI2.WinForms.Guna2Button();
            this.panelSale = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSale = new Guna.UI2.WinForms.Guna2Button();
            this.panelDelivery = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDelivery = new Guna.UI2.WinForms.Guna2Button();
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.timerStaff = new System.Windows.Forms.Timer(this.components);
            this.timerCustomer = new System.Windows.Forms.Timer(this.components);
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.timerInventory = new System.Windows.Forms.Timer(this.components);
            this.panelControl.SuspendLayout();
            this.flowSidebar.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictProfile)).BeginInit();
            this.panelDashboard.SuspendLayout();
            this.panelStaff.SuspendLayout();
            this.panelInventory.SuspendLayout();
            this.panelCustomer.SuspendLayout();
            this.panelSupplier.SuspendLayout();
            this.panelSale.SuspendLayout();
            this.panelDelivery.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(200)))), ((int)(((byte)(248)))));
            this.panelControl.Controls.Add(this.lblClock);
            this.panelControl.Controls.Add(this.controlMin);
            this.panelControl.Controls.Add(this.controlExit);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1920, 40);
            this.panelControl.TabIndex = 0;
            // 
            // lblClock
            // 
            this.lblClock.BackColor = System.Drawing.Color.Transparent;
            this.lblClock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.Color.Black;
            this.lblClock.Location = new System.Drawing.Point(35, 2);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(290, 35);
            this.lblClock.TabIndex = 15;
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // controlMin
            // 
            this.controlMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlMin.BackColor = System.Drawing.Color.Transparent;
            this.controlMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.controlMin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(77)))), ((int)(((byte)(166)))));
            this.controlMin.IconColor = System.Drawing.Color.White;
            this.controlMin.Location = new System.Drawing.Point(1818, 5);
            this.controlMin.Name = "controlMin";
            this.controlMin.Size = new System.Drawing.Size(45, 30);
            this.controlMin.TabIndex = 14;
            // 
            // controlExit
            // 
            this.controlExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlExit.BackColor = System.Drawing.Color.Transparent;
            this.controlExit.FillColor = System.Drawing.Color.Red;
            this.controlExit.IconColor = System.Drawing.Color.White;
            this.controlExit.Location = new System.Drawing.Point(1869, 5);
            this.controlExit.Name = "controlExit";
            this.controlExit.Size = new System.Drawing.Size(45, 30);
            this.controlExit.TabIndex = 13;
            this.controlExit.Click += new System.EventHandler(this.controlExit_Click);
            // 
            // flowSidebar
            // 
            this.flowSidebar.AutoScroll = true;
            this.flowSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(169)))), ((int)(((byte)(230)))));
            this.flowSidebar.Controls.Add(this.panelHeader);
            this.flowSidebar.Controls.Add(this.panelProfile);
            this.flowSidebar.Controls.Add(this.panelDashboard);
            this.flowSidebar.Controls.Add(this.panelStaff);
            this.flowSidebar.Controls.Add(this.panelInventory);
            this.flowSidebar.Controls.Add(this.panelCustomer);
            this.flowSidebar.Controls.Add(this.panelSupplier);
            this.flowSidebar.Controls.Add(this.panelSale);
            this.flowSidebar.Controls.Add(this.panelDelivery);
            this.flowSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowSidebar.Location = new System.Drawing.Point(0, 40);
            this.flowSidebar.Name = "flowSidebar";
            this.flowSidebar.Size = new System.Drawing.Size(300, 1040);
            this.flowSidebar.TabIndex = 1;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(3, 3);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(290, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(0, 16);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(290, 40);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "INVENTORY MANAGER";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelProfile
            // 
            this.panelProfile.Controls.Add(this.pictProfile);
            this.panelProfile.Controls.Add(this.lblName);
            this.panelProfile.Controls.Add(this.lblPosition);
            this.panelProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProfile.Location = new System.Drawing.Point(3, 79);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(290, 267);
            this.panelProfile.TabIndex = 1;
            // 
            // pictProfile
            // 
            this.pictProfile.Image = global::POS_SYSTEM.Properties.Resources.businessman_color;
            this.pictProfile.ImageRotate = 0F;
            this.pictProfile.Location = new System.Drawing.Point(67, 56);
            this.pictProfile.Name = "pictProfile";
            this.pictProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictProfile.Size = new System.Drawing.Size(150, 150);
            this.pictProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictProfile.TabIndex = 4;
            this.pictProfile.TabStop = false;
            this.pictProfile.Click += new System.EventHandler(this.pictProfile_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(0, 209);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(290, 40);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "NAME";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPosition
            // 
            this.lblPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblPosition.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.White;
            this.lblPosition.Location = new System.Drawing.Point(0, 16);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(290, 40);
            this.lblPosition.TabIndex = 1;
            this.lblPosition.Text = "POSITION";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDashboard
            // 
            this.panelDashboard.Controls.Add(this.btnDashboard);
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDashboard.Location = new System.Drawing.Point(3, 352);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(290, 55);
            this.panelDashboard.TabIndex = 2;
            this.panelDashboard.Visible = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FillColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::POS_SYSTEM.Properties.Resources.admin_color;
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.ImageOffset = new System.Drawing.Point(45, 0);
            this.btnDashboard.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(290, 50);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "       DASHBOARD";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelStaff
            // 
            this.panelStaff.Controls.Add(this.btnCourier);
            this.panelStaff.Controls.Add(this.btnAccount);
            this.panelStaff.Controls.Add(this.btnStaffList);
            this.panelStaff.Controls.Add(this.btnRole);
            this.panelStaff.Controls.Add(this.btnStaff);
            this.panelStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStaff.Location = new System.Drawing.Point(3, 413);
            this.panelStaff.MaximumSize = new System.Drawing.Size(290, 260);
            this.panelStaff.MinimumSize = new System.Drawing.Size(290, 50);
            this.panelStaff.Name = "panelStaff";
            this.panelStaff.Size = new System.Drawing.Size(290, 260);
            this.panelStaff.TabIndex = 3;
            this.panelStaff.Visible = false;
            // 
            // btnCourier
            // 
            this.btnCourier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCourier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCourier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCourier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCourier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCourier.FillColor = System.Drawing.Color.Transparent;
            this.btnCourier.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourier.ForeColor = System.Drawing.Color.White;
            this.btnCourier.Image = global::POS_SYSTEM.Properties.Resources.delivery_courier_color;
            this.btnCourier.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCourier.ImageOffset = new System.Drawing.Point(45, 0);
            this.btnCourier.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCourier.Location = new System.Drawing.Point(0, 200);
            this.btnCourier.Name = "btnCourier";
            this.btnCourier.Size = new System.Drawing.Size(290, 50);
            this.btnCourier.TabIndex = 5;
            this.btnCourier.Text = "       COURIER";
            this.btnCourier.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCourier.Visible = false;
            this.btnCourier.Click += new System.EventHandler(this.btnCourier_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccount.FillColor = System.Drawing.Color.Transparent;
            this.btnAccount.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Image = global::POS_SYSTEM.Properties.Resources.user_color;
            this.btnAccount.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAccount.ImageOffset = new System.Drawing.Point(45, 0);
            this.btnAccount.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAccount.Location = new System.Drawing.Point(0, 150);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(290, 50);
            this.btnAccount.TabIndex = 4;
            this.btnAccount.Text = "       ACCOUNT";
            this.btnAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAccount.Visible = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnStaffList
            // 
            this.btnStaffList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStaffList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStaffList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStaffList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStaffList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaffList.FillColor = System.Drawing.Color.Transparent;
            this.btnStaffList.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnStaffList.ForeColor = System.Drawing.Color.White;
            this.btnStaffList.Image = global::POS_SYSTEM.Properties.Resources.team_color;
            this.btnStaffList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStaffList.ImageOffset = new System.Drawing.Point(45, 0);
            this.btnStaffList.ImageSize = new System.Drawing.Size(25, 25);
            this.btnStaffList.Location = new System.Drawing.Point(0, 100);
            this.btnStaffList.Name = "btnStaffList";
            this.btnStaffList.Size = new System.Drawing.Size(290, 50);
            this.btnStaffList.TabIndex = 3;
            this.btnStaffList.Text = "       STAFF LIST";
            this.btnStaffList.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStaffList.Visible = false;
            this.btnStaffList.Click += new System.EventHandler(this.btnStaffList_Click);
            // 
            // btnRole
            // 
            this.btnRole.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRole.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRole.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRole.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRole.FillColor = System.Drawing.Color.Transparent;
            this.btnRole.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRole.ForeColor = System.Drawing.Color.White;
            this.btnRole.Image = global::POS_SYSTEM.Properties.Resources.id_card_color;
            this.btnRole.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRole.ImageOffset = new System.Drawing.Point(45, 0);
            this.btnRole.ImageSize = new System.Drawing.Size(25, 25);
            this.btnRole.Location = new System.Drawing.Point(0, 50);
            this.btnRole.Name = "btnRole";
            this.btnRole.Size = new System.Drawing.Size(290, 50);
            this.btnRole.TabIndex = 2;
            this.btnRole.Text = "       ROLE";
            this.btnRole.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRole.Visible = false;
            this.btnRole.Click += new System.EventHandler(this.btnRole_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaff.FillColor = System.Drawing.Color.Transparent;
            this.btnStaff.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.Image = global::POS_SYSTEM.Properties.Resources.right_arrow_color;
            this.btnStaff.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStaff.ImageOffset = new System.Drawing.Point(45, 0);
            this.btnStaff.ImageSize = new System.Drawing.Size(25, 25);
            this.btnStaff.Location = new System.Drawing.Point(0, 0);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(290, 50);
            this.btnStaff.TabIndex = 0;
            this.btnStaff.Text = "       STAFF";
            this.btnStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // panelInventory
            // 
            this.panelInventory.Controls.Add(this.btnStockOut);
            this.panelInventory.Controls.Add(this.btnStockIn);
            this.panelInventory.Controls.Add(this.btnProduct);
            this.panelInventory.Controls.Add(this.btnCategory);
            this.panelInventory.Controls.Add(this.btnUnit);
            this.panelInventory.Controls.Add(this.btnInventory);
            this.panelInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInventory.Location = new System.Drawing.Point(3, 679);
            this.panelInventory.MaximumSize = new System.Drawing.Size(290, 305);
            this.panelInventory.MinimumSize = new System.Drawing.Size(290, 50);
            this.panelInventory.Name = "panelInventory";
            this.panelInventory.Size = new System.Drawing.Size(290, 305);
            this.panelInventory.TabIndex = 4;
            this.panelInventory.Visible = false;
            // 
            // btnStockOut
            // 
            this.btnStockOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStockOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStockOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStockOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStockOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStockOut.FillColor = System.Drawing.Color.Transparent;
            this.btnStockOut.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockOut.ForeColor = System.Drawing.Color.White;
            this.btnStockOut.Image = global::POS_SYSTEM.Properties.Resources.return_box_color;
            this.btnStockOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStockOut.ImageOffset = new System.Drawing.Point(45, 0);
            this.btnStockOut.ImageSize = new System.Drawing.Size(25, 25);
            this.btnStockOut.Location = new System.Drawing.Point(0, 250);
            this.btnStockOut.Name = "btnStockOut";
            this.btnStockOut.Size = new System.Drawing.Size(290, 50);
            this.btnStockOut.TabIndex = 6;
            this.btnStockOut.Text = "       STOCK OUT";
            this.btnStockOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStockOut.Visible = false;
            this.btnStockOut.Click += new System.EventHandler(this.btnStockOut_Click);
            // 
            // btnStockIn
            // 
            this.btnStockIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStockIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStockIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStockIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStockIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStockIn.FillColor = System.Drawing.Color.Transparent;
            this.btnStockIn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockIn.ForeColor = System.Drawing.Color.White;
            this.btnStockIn.Image = global::POS_SYSTEM.Properties.Resources.packaging_color;
            this.btnStockIn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStockIn.ImageOffset = new System.Drawing.Point(45, 0);
            this.btnStockIn.ImageSize = new System.Drawing.Size(25, 25);
            this.btnStockIn.Location = new System.Drawing.Point(0, 200);
            this.btnStockIn.Name = "btnStockIn";
            this.btnStockIn.Size = new System.Drawing.Size(290, 50);
            this.btnStockIn.TabIndex = 5;
            this.btnStockIn.Text = "       STOCK IN";
            this.btnStockIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStockIn.Visible = false;
            this.btnStockIn.Click += new System.EventHandler(this.btnStockIn_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.FillColor = System.Drawing.Color.Transparent;
            this.btnProduct.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Image = global::POS_SYSTEM.Properties.Resources.product1;
            this.btnProduct.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProduct.ImageOffset = new System.Drawing.Point(45, 0);
            this.btnProduct.ImageSize = new System.Drawing.Size(25, 25);
            this.btnProduct.Location = new System.Drawing.Point(0, 150);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(290, 50);
            this.btnProduct.TabIndex = 4;
            this.btnProduct.Text = "       PRODUCT";
            this.btnProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProduct.Visible = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategory.FillColor = System.Drawing.Color.Transparent;
            this.btnCategory.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.Image = global::POS_SYSTEM.Properties.Resources.package_color;
            this.btnCategory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCategory.ImageOffset = new System.Drawing.Point(45, 0);
            this.btnCategory.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCategory.Location = new System.Drawing.Point(0, 100);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(290, 50);
            this.btnCategory.TabIndex = 3;
            this.btnCategory.Text = "       CATEGORY";
            this.btnCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCategory.Visible = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnUnit
            // 
            this.btnUnit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUnit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUnit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUnit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUnit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUnit.FillColor = System.Drawing.Color.Transparent;
            this.btnUnit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnUnit.ForeColor = System.Drawing.Color.White;
            this.btnUnit.Image = global::POS_SYSTEM.Properties.Resources.delivery_box_color;
            this.btnUnit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUnit.ImageOffset = new System.Drawing.Point(45, 0);
            this.btnUnit.ImageSize = new System.Drawing.Size(25, 25);
            this.btnUnit.Location = new System.Drawing.Point(0, 50);
            this.btnUnit.Name = "btnUnit";
            this.btnUnit.Size = new System.Drawing.Size(290, 50);
            this.btnUnit.TabIndex = 2;
            this.btnUnit.Text = "       UNIT";
            this.btnUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUnit.Visible = false;
            this.btnUnit.Click += new System.EventHandler(this.btnUnit_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInventory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInventory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInventory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventory.FillColor = System.Drawing.Color.Transparent;
            this.btnInventory.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Image = global::POS_SYSTEM.Properties.Resources.right_arrow_color;
            this.btnInventory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInventory.ImageOffset = new System.Drawing.Point(45, 0);
            this.btnInventory.ImageSize = new System.Drawing.Size(25, 25);
            this.btnInventory.Location = new System.Drawing.Point(0, 0);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(290, 50);
            this.btnInventory.TabIndex = 0;
            this.btnInventory.Text = "       INVENTORY";
            this.btnInventory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // panelCustomer
            // 
            this.panelCustomer.Controls.Add(this.btnDeposit);
            this.panelCustomer.Controls.Add(this.btnLoan);
            this.panelCustomer.Controls.Add(this.btnCustomerList);
            this.panelCustomer.Controls.Add(this.btnCustomer);
            this.panelCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCustomer.Location = new System.Drawing.Point(3, 990);
            this.panelCustomer.MaximumSize = new System.Drawing.Size(290, 205);
            this.panelCustomer.MinimumSize = new System.Drawing.Size(290, 50);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(290, 205);
            this.panelCustomer.TabIndex = 5;
            this.panelCustomer.Visible = false;
            // 
            // btnDeposit
            // 
            this.btnDeposit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeposit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeposit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeposit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeposit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeposit.FillColor = System.Drawing.Color.Transparent;
            this.btnDeposit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.Color.White;
            this.btnDeposit.Image = global::POS_SYSTEM.Properties.Resources.deposit_color;
            this.btnDeposit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeposit.ImageOffset = new System.Drawing.Point(45, 0);
            this.btnDeposit.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDeposit.Location = new System.Drawing.Point(0, 150);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(290, 50);
            this.btnDeposit.TabIndex = 3;
            this.btnDeposit.Text = "       DEPOSIT";
            this.btnDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeposit.Visible = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnLoan
            // 
            this.btnLoan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoan.FillColor = System.Drawing.Color.Transparent;
            this.btnLoan.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoan.ForeColor = System.Drawing.Color.White;
            this.btnLoan.Image = global::POS_SYSTEM.Properties.Resources.funding_color;
            this.btnLoan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLoan.ImageOffset = new System.Drawing.Point(45, 0);
            this.btnLoan.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLoan.Location = new System.Drawing.Point(0, 100);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(290, 50);
            this.btnLoan.TabIndex = 2;
            this.btnLoan.Text = "       LOAN";
            this.btnLoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLoan.Visible = false;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // btnCustomerList
            // 
            this.btnCustomerList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomerList.FillColor = System.Drawing.Color.Transparent;
            this.btnCustomerList.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerList.ForeColor = System.Drawing.Color.White;
            this.btnCustomerList.Image = global::POS_SYSTEM.Properties.Resources.community_color;
            this.btnCustomerList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomerList.ImageOffset = new System.Drawing.Point(45, 0);
            this.btnCustomerList.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCustomerList.Location = new System.Drawing.Point(0, 50);
            this.btnCustomerList.Name = "btnCustomerList";
            this.btnCustomerList.Size = new System.Drawing.Size(290, 50);
            this.btnCustomerList.TabIndex = 1;
            this.btnCustomerList.Text = "       CUSTOMER LIST";
            this.btnCustomerList.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomerList.Visible = false;
            this.btnCustomerList.Click += new System.EventHandler(this.btnCustomerList_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FillColor = System.Drawing.Color.Transparent;
            this.btnCustomer.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Image = global::POS_SYSTEM.Properties.Resources.right_arrow_color;
            this.btnCustomer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomer.ImageOffset = new System.Drawing.Point(45, 0);
            this.btnCustomer.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCustomer.Location = new System.Drawing.Point(0, 0);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(290, 50);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "       CUSTOMER";
            this.btnCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // panelSupplier
            // 
            this.panelSupplier.Controls.Add(this.btnSupplier);
            this.panelSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSupplier.Location = new System.Drawing.Point(3, 1201);
            this.panelSupplier.Name = "panelSupplier";
            this.panelSupplier.Size = new System.Drawing.Size(290, 55);
            this.panelSupplier.TabIndex = 6;
            this.panelSupplier.Visible = false;
            // 
            // btnSupplier
            // 
            this.btnSupplier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSupplier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSupplier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSupplier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSupplier.FillColor = System.Drawing.Color.Transparent;
            this.btnSupplier.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.ForeColor = System.Drawing.Color.White;
            this.btnSupplier.Image = global::POS_SYSTEM.Properties.Resources.inventory_color;
            this.btnSupplier.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSupplier.ImageOffset = new System.Drawing.Point(45, 0);
            this.btnSupplier.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSupplier.Location = new System.Drawing.Point(0, 0);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(290, 50);
            this.btnSupplier.TabIndex = 0;
            this.btnSupplier.Text = "       SUPPLIER";
            this.btnSupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // panelSale
            // 
            this.panelSale.Controls.Add(this.btnSale);
            this.panelSale.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSale.Location = new System.Drawing.Point(3, 1262);
            this.panelSale.Name = "panelSale";
            this.panelSale.Size = new System.Drawing.Size(290, 55);
            this.panelSale.TabIndex = 8;
            this.panelSale.Visible = false;
            // 
            // btnSale
            // 
            this.btnSale.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSale.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSale.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSale.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSale.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSale.FillColor = System.Drawing.Color.Transparent;
            this.btnSale.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.ForeColor = System.Drawing.Color.White;
            this.btnSale.Image = global::POS_SYSTEM.Properties.Resources.shopping_basket_color;
            this.btnSale.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSale.ImageOffset = new System.Drawing.Point(45, 0);
            this.btnSale.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSale.Location = new System.Drawing.Point(0, 0);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(290, 50);
            this.btnSale.TabIndex = 1;
            this.btnSale.Text = "       SALE";
            this.btnSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // panelDelivery
            // 
            this.panelDelivery.Controls.Add(this.btnDelivery);
            this.panelDelivery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDelivery.Location = new System.Drawing.Point(3, 1323);
            this.panelDelivery.Name = "panelDelivery";
            this.panelDelivery.Size = new System.Drawing.Size(290, 55);
            this.panelDelivery.TabIndex = 9;
            this.panelDelivery.Visible = false;
            // 
            // btnDelivery
            // 
            this.btnDelivery.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelivery.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelivery.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelivery.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelivery.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelivery.FillColor = System.Drawing.Color.Transparent;
            this.btnDelivery.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelivery.ForeColor = System.Drawing.Color.White;
            this.btnDelivery.Image = global::POS_SYSTEM.Properties.Resources.delivery_color;
            this.btnDelivery.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDelivery.ImageOffset = new System.Drawing.Point(45, 0);
            this.btnDelivery.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDelivery.Location = new System.Drawing.Point(0, 0);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(290, 50);
            this.btnDelivery.TabIndex = 1;
            this.btnDelivery.Text = "       DELIVERY";
            this.btnDelivery.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Location = new System.Drawing.Point(310, 40);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1610, 1080);
            this.panelMain.TabIndex = 2;
            // 
            // timerStaff
            // 
            this.timerStaff.Interval = 10;
            this.timerStaff.Tick += new System.EventHandler(this.timerStaff_Tick);
            // 
            // timerCustomer
            // 
            this.timerCustomer.Interval = 10;
            this.timerCustomer.Tick += new System.EventHandler(this.timerCustomer_Tick);
            // 
            // timerClock
            // 
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // timerInventory
            // 
            this.timerInventory.Interval = 10;
            this.timerInventory.Tick += new System.EventHandler(this.timerInventory_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.flowSidebar);
            this.Controls.Add(this.panelControl);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelControl.ResumeLayout(false);
            this.flowSidebar.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictProfile)).EndInit();
            this.panelDashboard.ResumeLayout(false);
            this.panelStaff.ResumeLayout(false);
            this.panelInventory.ResumeLayout(false);
            this.panelCustomer.ResumeLayout(false);
            this.panelSupplier.ResumeLayout(false);
            this.panelSale.ResumeLayout(false);
            this.panelDelivery.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelControl;
        private System.Windows.Forms.FlowLayoutPanel flowSidebar;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private Guna.UI2.WinForms.Guna2ControlBox controlMin;
        private Guna.UI2.WinForms.Guna2ControlBox controlExit;
        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        public System.Windows.Forms.Label lblHeader;
        private Guna.UI2.WinForms.Guna2Panel panelProfile;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblPosition;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictProfile;
        private Guna.UI2.WinForms.Guna2Panel panelDashboard;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Panel panelStaff;
        private Guna.UI2.WinForms.Guna2Button btnStaff;
        private Guna.UI2.WinForms.Guna2Panel panelInventory;
        private Guna.UI2.WinForms.Guna2Button btnInventory;
        private Guna.UI2.WinForms.Guna2Panel panelCustomer;
        private Guna.UI2.WinForms.Guna2Button btnCustomer;
        private Guna.UI2.WinForms.Guna2Button btnCourier;
        private Guna.UI2.WinForms.Guna2Button btnAccount;
        private Guna.UI2.WinForms.Guna2Button btnStaffList;
        private Guna.UI2.WinForms.Guna2Button btnRole;
        private Guna.UI2.WinForms.Guna2Button btnCategory;
        private Guna.UI2.WinForms.Guna2Button btnUnit;
        private Guna.UI2.WinForms.Guna2Button btnLoan;
        private Guna.UI2.WinForms.Guna2Button btnCustomerList;
        private Guna.UI2.WinForms.Guna2Panel panelSupplier;
        private Guna.UI2.WinForms.Guna2Button btnSupplier;
        private Guna.UI2.WinForms.Guna2Panel panelSale;
        private Guna.UI2.WinForms.Guna2Panel panelDelivery;
        private Guna.UI2.WinForms.Guna2Button btnProduct;
        private Guna.UI2.WinForms.Guna2Button btnDeposit;
        private System.Windows.Forms.Timer timerStaff;
        private System.Windows.Forms.Timer timerCustomer;
        private System.Windows.Forms.Timer timerClock;
        public System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer timerInventory;
        private Guna.UI2.WinForms.Guna2Button btnSale;
        private Guna.UI2.WinForms.Guna2Button btnDelivery;
        private Guna.UI2.WinForms.Guna2Button btnStockOut;
        private Guna.UI2.WinForms.Guna2Button btnStockIn;
    }
}