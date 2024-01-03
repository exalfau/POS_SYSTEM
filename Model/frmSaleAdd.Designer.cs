namespace POS_SYSTEM.Model
{
    partial class frmSaleAdd
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.elipsForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dateSales = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblDateSales = new System.Windows.Forms.Label();
            this.txtTimeSales = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTimeSales = new System.Windows.Forms.Label();
            this.panelGT = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblGT = new System.Windows.Forms.Label();
            this.lblInformation = new System.Windows.Forms.Label();
            this.txtInfoTransaction = new Guna.UI2.WinForms.Guna2TextBox();
            this.flowCheckOut = new System.Windows.Forms.FlowLayoutPanel();
            this.panelPayment = new Guna.UI2.WinForms.Guna2Panel();
            this.seperatePayment = new Guna.UI2.WinForms.Guna2Separator();
            this.lblPaymentOption = new System.Windows.Forms.Label();
            this.radioDeposit = new System.Windows.Forms.RadioButton();
            this.radioLoan = new System.Windows.Forms.RadioButton();
            this.radioCash = new System.Windows.Forms.RadioButton();
            this.panelLoan = new Guna.UI2.WinForms.Guna2Panel();
            this.seperateInstallment = new Guna.UI2.WinForms.Guna2Separator();
            this.lblInstallment = new System.Windows.Forms.Label();
            this.radio12X = new System.Windows.Forms.RadioButton();
            this.radio6X = new System.Windows.Forms.RadioButton();
            this.radio3X = new System.Windows.Forms.RadioButton();
            this.panelDeposit = new Guna.UI2.WinForms.Guna2Panel();
            this.seperateBalance = new Guna.UI2.WinForms.Guna2Separator();
            this.txtBalance = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.panelShipping = new Guna.UI2.WinForms.Guna2Panel();
            this.seperateShippingOption = new Guna.UI2.WinForms.Guna2Separator();
            this.lblShippingOption = new System.Windows.Forms.Label();
            this.radioDelivery = new System.Windows.Forms.RadioButton();
            this.radioSelfPick = new System.Windows.Forms.RadioButton();
            this.panelDelivery = new Guna.UI2.WinForms.Guna2Panel();
            this.txtCost = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDeliveryCost = new System.Windows.Forms.Label();
            this.seperateDeliveryDetail = new Guna.UI2.WinForms.Guna2Separator();
            this.lblInfoDelivery = new System.Windows.Forms.Label();
            this.txtInfoDelivery = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAddres = new System.Windows.Forms.Label();
            this.lblCourier = new System.Windows.Forms.Label();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboCourier = new System.Windows.Forms.ComboBox();
            this.lblDeliveryDetail = new System.Windows.Forms.Label();
            this.panelOrder = new Guna.UI2.WinForms.Guna2Panel();
            this.btnOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrevious = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.flowMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.comboCustomer = new System.Windows.Forms.ComboBox();
            this.cbConfim = new Guna.UI2.WinForms.Guna2CheckBox();
            this.controlExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblClock = new System.Windows.Forms.Label();
            this.flowShopingCart = new System.Windows.Forms.FlowLayoutPanel();
            this.elipsMenu = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelGT.SuspendLayout();
            this.flowCheckOut.SuspendLayout();
            this.panelPayment.SuspendLayout();
            this.panelLoan.SuspendLayout();
            this.panelDeposit.SuspendLayout();
            this.panelShipping.SuspendLayout();
            this.panelDelivery.SuspendLayout();
            this.panelOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(109, 48);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(64, 25);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Sales";
            // 
            // elipsForm
            // 
            this.elipsForm.BorderRadius = 30;
            this.elipsForm.TargetControl = this;
            // 
            // dateSales
            // 
            this.dateSales.AutoRoundedCorners = true;
            this.dateSales.BorderRadius = 17;
            this.dateSales.Checked = true;
            this.dateSales.FillColor = System.Drawing.Color.White;
            this.dateSales.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSales.ForeColor = System.Drawing.Color.Black;
            this.dateSales.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSales.Location = new System.Drawing.Point(57, 147);
            this.dateSales.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateSales.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateSales.Name = "dateSales";
            this.dateSales.Size = new System.Drawing.Size(250, 36);
            this.dateSales.TabIndex = 43;
            this.dateSales.Value = new System.DateTime(2023, 9, 20, 14, 30, 24, 405);
            // 
            // lblDateSales
            // 
            this.lblDateSales.AutoSize = true;
            this.lblDateSales.BackColor = System.Drawing.Color.Transparent;
            this.lblDateSales.ForeColor = System.Drawing.Color.Black;
            this.lblDateSales.Location = new System.Drawing.Point(74, 121);
            this.lblDateSales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateSales.Name = "lblDateSales";
            this.lblDateSales.Size = new System.Drawing.Size(118, 24);
            this.lblDateSales.TabIndex = 42;
            this.lblDateSales.Text = "Date Sales";
            // 
            // txtTimeSales
            // 
            this.txtTimeSales.AutoRoundedCorners = true;
            this.txtTimeSales.AutoSize = true;
            this.txtTimeSales.BackColor = System.Drawing.Color.Transparent;
            this.txtTimeSales.BorderRadius = 19;
            this.txtTimeSales.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimeSales.DefaultText = "";
            this.txtTimeSales.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimeSales.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimeSales.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimeSales.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimeSales.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimeSales.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtTimeSales.ForeColor = System.Drawing.Color.Black;
            this.txtTimeSales.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimeSales.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtTimeSales.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtTimeSales.Location = new System.Drawing.Point(373, 147);
            this.txtTimeSales.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimeSales.Name = "txtTimeSales";
            this.txtTimeSales.PasswordChar = '\0';
            this.txtTimeSales.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTimeSales.PlaceholderText = "00:00";
            this.txtTimeSales.SelectedText = "";
            this.txtTimeSales.Size = new System.Drawing.Size(250, 40);
            this.txtTimeSales.TabIndex = 47;
            this.txtTimeSales.Tag = "time";
            // 
            // lblTimeSales
            // 
            this.lblTimeSales.AutoSize = true;
            this.lblTimeSales.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeSales.ForeColor = System.Drawing.Color.Black;
            this.lblTimeSales.Location = new System.Drawing.Point(383, 121);
            this.lblTimeSales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimeSales.Name = "lblTimeSales";
            this.lblTimeSales.Size = new System.Drawing.Size(113, 24);
            this.lblTimeSales.TabIndex = 46;
            this.lblTimeSales.Text = "Time Sales";
            // 
            // panelGT
            // 
            this.panelGT.BackColor = System.Drawing.Color.Transparent;
            this.panelGT.BorderRadius = 40;
            this.panelGT.Controls.Add(this.lblTotal);
            this.panelGT.Controls.Add(this.lblGT);
            this.panelGT.CustomizableEdges.BottomLeft = false;
            this.panelGT.CustomizableEdges.BottomRight = false;
            this.panelGT.FillColor = System.Drawing.Color.Navy;
            this.panelGT.Location = new System.Drawing.Point(974, 121);
            this.panelGT.Name = "panelGT";
            this.panelGT.Size = new System.Drawing.Size(458, 105);
            this.panelGT.TabIndex = 48;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(162, 41);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(274, 25);
            this.lblTotal.TabIndex = 5;
            // 
            // lblGT
            // 
            this.lblGT.AutoSize = true;
            this.lblGT.BackColor = System.Drawing.Color.Transparent;
            this.lblGT.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGT.ForeColor = System.Drawing.Color.White;
            this.lblGT.Location = new System.Drawing.Point(17, 41);
            this.lblGT.Name = "lblGT";
            this.lblGT.Size = new System.Drawing.Size(143, 25);
            this.lblGT.TabIndex = 4;
            this.lblGT.Text = "Grand Total :";
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.BackColor = System.Drawing.Color.Transparent;
            this.lblInformation.ForeColor = System.Drawing.Color.Black;
            this.lblInformation.Location = new System.Drawing.Point(695, 121);
            this.lblInformation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(49, 24);
            this.lblInformation.TabIndex = 50;
            this.lblInformation.Text = "Info";
            // 
            // txtInfoTransaction
            // 
            this.txtInfoTransaction.AutoRoundedCorners = true;
            this.txtInfoTransaction.AutoSize = true;
            this.txtInfoTransaction.BackColor = System.Drawing.Color.Transparent;
            this.txtInfoTransaction.BorderRadius = 19;
            this.txtInfoTransaction.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInfoTransaction.DefaultText = "";
            this.txtInfoTransaction.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInfoTransaction.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInfoTransaction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInfoTransaction.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInfoTransaction.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInfoTransaction.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtInfoTransaction.ForeColor = System.Drawing.Color.Black;
            this.txtInfoTransaction.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInfoTransaction.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtInfoTransaction.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtInfoTransaction.Location = new System.Drawing.Point(676, 147);
            this.txtInfoTransaction.Margin = new System.Windows.Forms.Padding(2);
            this.txtInfoTransaction.Name = "txtInfoTransaction";
            this.txtInfoTransaction.PasswordChar = '\0';
            this.txtInfoTransaction.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtInfoTransaction.PlaceholderText = "";
            this.txtInfoTransaction.SelectedText = "";
            this.txtInfoTransaction.Size = new System.Drawing.Size(250, 40);
            this.txtInfoTransaction.TabIndex = 49;
            this.txtInfoTransaction.Tag = "";
            // 
            // flowCheckOut
            // 
            this.flowCheckOut.AutoScroll = true;
            this.flowCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(200)))), ((int)(((byte)(248)))));
            this.flowCheckOut.Controls.Add(this.panelPayment);
            this.flowCheckOut.Controls.Add(this.panelLoan);
            this.flowCheckOut.Controls.Add(this.panelDeposit);
            this.flowCheckOut.Controls.Add(this.panelShipping);
            this.flowCheckOut.Controls.Add(this.panelDelivery);
            this.flowCheckOut.Location = new System.Drawing.Point(974, 237);
            this.flowCheckOut.Name = "flowCheckOut";
            this.flowCheckOut.Size = new System.Drawing.Size(458, 543);
            this.flowCheckOut.TabIndex = 51;
            this.flowCheckOut.Visible = false;
            // 
            // panelPayment
            // 
            this.panelPayment.BackColor = System.Drawing.Color.Transparent;
            this.panelPayment.BorderRadius = 20;
            this.panelPayment.Controls.Add(this.seperatePayment);
            this.panelPayment.Controls.Add(this.lblPaymentOption);
            this.panelPayment.Controls.Add(this.radioDeposit);
            this.panelPayment.Controls.Add(this.radioLoan);
            this.panelPayment.Controls.Add(this.radioCash);
            this.panelPayment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(169)))), ((int)(((byte)(230)))));
            this.panelPayment.Location = new System.Drawing.Point(3, 3);
            this.panelPayment.Name = "panelPayment";
            this.panelPayment.Size = new System.Drawing.Size(455, 189);
            this.panelPayment.TabIndex = 53;
            // 
            // seperatePayment
            // 
            this.seperatePayment.FillColor = System.Drawing.Color.Black;
            this.seperatePayment.Location = new System.Drawing.Point(2, 38);
            this.seperatePayment.Name = "seperatePayment";
            this.seperatePayment.Size = new System.Drawing.Size(458, 13);
            this.seperatePayment.TabIndex = 55;
            // 
            // lblPaymentOption
            // 
            this.lblPaymentOption.AutoSize = true;
            this.lblPaymentOption.BackColor = System.Drawing.Color.Transparent;
            this.lblPaymentOption.ForeColor = System.Drawing.Color.White;
            this.lblPaymentOption.Location = new System.Drawing.Point(145, 12);
            this.lblPaymentOption.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaymentOption.Name = "lblPaymentOption";
            this.lblPaymentOption.Size = new System.Drawing.Size(177, 24);
            this.lblPaymentOption.TabIndex = 54;
            this.lblPaymentOption.Text = "Payment Option";
            // 
            // radioDeposit
            // 
            this.radioDeposit.AutoSize = true;
            this.radioDeposit.ForeColor = System.Drawing.Color.White;
            this.radioDeposit.Location = new System.Drawing.Point(54, 147);
            this.radioDeposit.Name = "radioDeposit";
            this.radioDeposit.Size = new System.Drawing.Size(104, 28);
            this.radioDeposit.TabIndex = 53;
            this.radioDeposit.TabStop = true;
            this.radioDeposit.Text = "Deposit";
            this.radioDeposit.UseVisualStyleBackColor = true;
            this.radioDeposit.CheckedChanged += new System.EventHandler(this.radioDeposit_CheckedChanged);
            // 
            // radioLoan
            // 
            this.radioLoan.AutoSize = true;
            this.radioLoan.ForeColor = System.Drawing.Color.White;
            this.radioLoan.Location = new System.Drawing.Point(54, 102);
            this.radioLoan.Name = "radioLoan";
            this.radioLoan.Size = new System.Drawing.Size(79, 28);
            this.radioLoan.TabIndex = 52;
            this.radioLoan.TabStop = true;
            this.radioLoan.Text = "Loan";
            this.radioLoan.UseVisualStyleBackColor = true;
            this.radioLoan.CheckedChanged += new System.EventHandler(this.radioLoan_CheckedChanged);
            // 
            // radioCash
            // 
            this.radioCash.AutoSize = true;
            this.radioCash.ForeColor = System.Drawing.Color.White;
            this.radioCash.Location = new System.Drawing.Point(54, 57);
            this.radioCash.Name = "radioCash";
            this.radioCash.Size = new System.Drawing.Size(80, 28);
            this.radioCash.TabIndex = 51;
            this.radioCash.TabStop = true;
            this.radioCash.Text = "Cash";
            this.radioCash.UseVisualStyleBackColor = true;
            // 
            // panelLoan
            // 
            this.panelLoan.BackColor = System.Drawing.Color.Transparent;
            this.panelLoan.BorderRadius = 20;
            this.panelLoan.Controls.Add(this.seperateInstallment);
            this.panelLoan.Controls.Add(this.lblInstallment);
            this.panelLoan.Controls.Add(this.radio12X);
            this.panelLoan.Controls.Add(this.radio6X);
            this.panelLoan.Controls.Add(this.radio3X);
            this.panelLoan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(169)))), ((int)(((byte)(230)))));
            this.panelLoan.Location = new System.Drawing.Point(3, 198);
            this.panelLoan.Name = "panelLoan";
            this.panelLoan.Size = new System.Drawing.Size(455, 115);
            this.panelLoan.TabIndex = 56;
            this.panelLoan.Visible = false;
            // 
            // seperateInstallment
            // 
            this.seperateInstallment.FillColor = System.Drawing.Color.Black;
            this.seperateInstallment.Location = new System.Drawing.Point(-2, 44);
            this.seperateInstallment.Name = "seperateInstallment";
            this.seperateInstallment.Size = new System.Drawing.Size(458, 13);
            this.seperateInstallment.TabIndex = 58;
            // 
            // lblInstallment
            // 
            this.lblInstallment.AutoSize = true;
            this.lblInstallment.BackColor = System.Drawing.Color.Transparent;
            this.lblInstallment.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstallment.ForeColor = System.Drawing.Color.White;
            this.lblInstallment.Location = new System.Drawing.Point(173, 14);
            this.lblInstallment.Name = "lblInstallment";
            this.lblInstallment.Size = new System.Drawing.Size(122, 24);
            this.lblInstallment.TabIndex = 57;
            this.lblInstallment.Text = "Installment";
            // 
            // radio12X
            // 
            this.radio12X.AutoSize = true;
            this.radio12X.ForeColor = System.Drawing.Color.White;
            this.radio12X.Location = new System.Drawing.Point(311, 69);
            this.radio12X.Name = "radio12X";
            this.radio12X.Size = new System.Drawing.Size(65, 28);
            this.radio12X.TabIndex = 56;
            this.radio12X.TabStop = true;
            this.radio12X.Text = "12X";
            this.radio12X.UseVisualStyleBackColor = true;
            // 
            // radio6X
            // 
            this.radio6X.AutoSize = true;
            this.radio6X.ForeColor = System.Drawing.Color.White;
            this.radio6X.Location = new System.Drawing.Point(192, 69);
            this.radio6X.Name = "radio6X";
            this.radio6X.Size = new System.Drawing.Size(53, 28);
            this.radio6X.TabIndex = 55;
            this.radio6X.TabStop = true;
            this.radio6X.Text = "6X";
            this.radio6X.UseVisualStyleBackColor = true;
            // 
            // radio3X
            // 
            this.radio3X.AutoSize = true;
            this.radio3X.ForeColor = System.Drawing.Color.White;
            this.radio3X.Location = new System.Drawing.Point(78, 69);
            this.radio3X.Name = "radio3X";
            this.radio3X.Size = new System.Drawing.Size(53, 28);
            this.radio3X.TabIndex = 54;
            this.radio3X.TabStop = true;
            this.radio3X.Text = "3X";
            this.radio3X.UseVisualStyleBackColor = true;
            // 
            // panelDeposit
            // 
            this.panelDeposit.BackColor = System.Drawing.Color.Transparent;
            this.panelDeposit.BorderRadius = 20;
            this.panelDeposit.Controls.Add(this.seperateBalance);
            this.panelDeposit.Controls.Add(this.txtBalance);
            this.panelDeposit.Controls.Add(this.lblBalance);
            this.panelDeposit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(169)))), ((int)(((byte)(230)))));
            this.panelDeposit.Location = new System.Drawing.Point(3, 319);
            this.panelDeposit.Name = "panelDeposit";
            this.panelDeposit.Size = new System.Drawing.Size(455, 110);
            this.panelDeposit.TabIndex = 57;
            this.panelDeposit.Visible = false;
            // 
            // seperateBalance
            // 
            this.seperateBalance.FillColor = System.Drawing.Color.Black;
            this.seperateBalance.Location = new System.Drawing.Point(-2, 38);
            this.seperateBalance.Name = "seperateBalance";
            this.seperateBalance.Size = new System.Drawing.Size(458, 13);
            this.seperateBalance.TabIndex = 56;
            // 
            // txtBalance
            // 
            this.txtBalance.AutoRoundedCorners = true;
            this.txtBalance.AutoSize = true;
            this.txtBalance.BackColor = System.Drawing.Color.Transparent;
            this.txtBalance.BorderRadius = 19;
            this.txtBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBalance.DefaultText = "";
            this.txtBalance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBalance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBalance.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtBalance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBalance.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtBalance.ForeColor = System.Drawing.Color.Black;
            this.txtBalance.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBalance.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtBalance.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtBalance.Location = new System.Drawing.Point(59, 56);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(2);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.PasswordChar = '\0';
            this.txtBalance.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtBalance.PlaceholderText = "auto complete";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.SelectedText = "";
            this.txtBalance.Size = new System.Drawing.Size(347, 40);
            this.txtBalance.TabIndex = 54;
            this.txtBalance.Tag = "tb";
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblBalance.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(183, 12);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(96, 24);
            this.lblBalance.TabIndex = 51;
            this.lblBalance.Text = "Balance";
            // 
            // panelShipping
            // 
            this.panelShipping.BackColor = System.Drawing.Color.Transparent;
            this.panelShipping.BorderRadius = 20;
            this.panelShipping.Controls.Add(this.seperateShippingOption);
            this.panelShipping.Controls.Add(this.lblShippingOption);
            this.panelShipping.Controls.Add(this.radioDelivery);
            this.panelShipping.Controls.Add(this.radioSelfPick);
            this.panelShipping.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(169)))), ((int)(((byte)(230)))));
            this.panelShipping.Location = new System.Drawing.Point(3, 435);
            this.panelShipping.Name = "panelShipping";
            this.panelShipping.Size = new System.Drawing.Size(455, 159);
            this.panelShipping.TabIndex = 58;
            // 
            // seperateShippingOption
            // 
            this.seperateShippingOption.FillColor = System.Drawing.Color.Black;
            this.seperateShippingOption.Location = new System.Drawing.Point(-2, 45);
            this.seperateShippingOption.Name = "seperateShippingOption";
            this.seperateShippingOption.Size = new System.Drawing.Size(458, 13);
            this.seperateShippingOption.TabIndex = 56;
            // 
            // lblShippingOption
            // 
            this.lblShippingOption.AutoSize = true;
            this.lblShippingOption.BackColor = System.Drawing.Color.Transparent;
            this.lblShippingOption.ForeColor = System.Drawing.Color.White;
            this.lblShippingOption.Location = new System.Drawing.Point(150, 13);
            this.lblShippingOption.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShippingOption.Name = "lblShippingOption";
            this.lblShippingOption.Size = new System.Drawing.Size(169, 24);
            this.lblShippingOption.TabIndex = 54;
            this.lblShippingOption.Text = "Shipping Option";
            // 
            // radioDelivery
            // 
            this.radioDelivery.AutoSize = true;
            this.radioDelivery.ForeColor = System.Drawing.Color.White;
            this.radioDelivery.Location = new System.Drawing.Point(54, 109);
            this.radioDelivery.Name = "radioDelivery";
            this.radioDelivery.Size = new System.Drawing.Size(110, 28);
            this.radioDelivery.TabIndex = 52;
            this.radioDelivery.TabStop = true;
            this.radioDelivery.Text = "Delivery";
            this.radioDelivery.UseVisualStyleBackColor = true;
            this.radioDelivery.CheckedChanged += new System.EventHandler(this.radioDelivery_CheckedChanged);
            // 
            // radioSelfPick
            // 
            this.radioSelfPick.AutoSize = true;
            this.radioSelfPick.ForeColor = System.Drawing.Color.White;
            this.radioSelfPick.Location = new System.Drawing.Point(54, 64);
            this.radioSelfPick.Name = "radioSelfPick";
            this.radioSelfPick.Size = new System.Drawing.Size(145, 28);
            this.radioSelfPick.TabIndex = 51;
            this.radioSelfPick.TabStop = true;
            this.radioSelfPick.Text = "Self pick up";
            this.radioSelfPick.UseVisualStyleBackColor = true;
            // 
            // panelDelivery
            // 
            this.panelDelivery.BackColor = System.Drawing.Color.Transparent;
            this.panelDelivery.BorderRadius = 20;
            this.panelDelivery.Controls.Add(this.txtCost);
            this.panelDelivery.Controls.Add(this.lblDeliveryCost);
            this.panelDelivery.Controls.Add(this.seperateDeliveryDetail);
            this.panelDelivery.Controls.Add(this.lblInfoDelivery);
            this.panelDelivery.Controls.Add(this.txtInfoDelivery);
            this.panelDelivery.Controls.Add(this.lblAddres);
            this.panelDelivery.Controls.Add(this.lblCourier);
            this.panelDelivery.Controls.Add(this.txtAddress);
            this.panelDelivery.Controls.Add(this.comboCourier);
            this.panelDelivery.Controls.Add(this.lblDeliveryDetail);
            this.panelDelivery.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(169)))), ((int)(((byte)(230)))));
            this.panelDelivery.Location = new System.Drawing.Point(3, 600);
            this.panelDelivery.Name = "panelDelivery";
            this.panelDelivery.Size = new System.Drawing.Size(455, 446);
            this.panelDelivery.TabIndex = 59;
            this.panelDelivery.Visible = false;
            // 
            // txtCost
            // 
            this.txtCost.AutoRoundedCorners = true;
            this.txtCost.AutoSize = true;
            this.txtCost.BackColor = System.Drawing.Color.Transparent;
            this.txtCost.BorderRadius = 19;
            this.txtCost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCost.DefaultText = "";
            this.txtCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCost.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtCost.ForeColor = System.Drawing.Color.Black;
            this.txtCost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCost.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtCost.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtCost.Location = new System.Drawing.Point(59, 274);
            this.txtCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtCost.Name = "txtCost";
            this.txtCost.PasswordChar = '\0';
            this.txtCost.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtCost.PlaceholderText = "1000.00";
            this.txtCost.SelectedText = "";
            this.txtCost.Size = new System.Drawing.Size(347, 40);
            this.txtCost.TabIndex = 63;
            this.txtCost.Tag = "n";
            this.txtCost.TextChanged += new System.EventHandler(this.txtCost_TextChanged);
            // 
            // lblDeliveryCost
            // 
            this.lblDeliveryCost.AutoSize = true;
            this.lblDeliveryCost.BackColor = System.Drawing.Color.Transparent;
            this.lblDeliveryCost.ForeColor = System.Drawing.Color.White;
            this.lblDeliveryCost.Location = new System.Drawing.Point(62, 248);
            this.lblDeliveryCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeliveryCost.Name = "lblDeliveryCost";
            this.lblDeliveryCost.Size = new System.Drawing.Size(144, 24);
            this.lblDeliveryCost.TabIndex = 62;
            this.lblDeliveryCost.Text = "Delivery Cost";
            // 
            // seperateDeliveryDetail
            // 
            this.seperateDeliveryDetail.FillColor = System.Drawing.Color.Black;
            this.seperateDeliveryDetail.Location = new System.Drawing.Point(3, 42);
            this.seperateDeliveryDetail.Name = "seperateDeliveryDetail";
            this.seperateDeliveryDetail.Size = new System.Drawing.Size(458, 13);
            this.seperateDeliveryDetail.TabIndex = 61;
            // 
            // lblInfoDelivery
            // 
            this.lblInfoDelivery.AutoSize = true;
            this.lblInfoDelivery.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoDelivery.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDelivery.ForeColor = System.Drawing.Color.White;
            this.lblInfoDelivery.Location = new System.Drawing.Point(62, 346);
            this.lblInfoDelivery.Name = "lblInfoDelivery";
            this.lblInfoDelivery.Size = new System.Drawing.Size(49, 24);
            this.lblInfoDelivery.TabIndex = 60;
            this.lblInfoDelivery.Text = "Info";
            // 
            // txtInfoDelivery
            // 
            this.txtInfoDelivery.AutoRoundedCorners = true;
            this.txtInfoDelivery.AutoSize = true;
            this.txtInfoDelivery.BackColor = System.Drawing.Color.Transparent;
            this.txtInfoDelivery.BorderRadius = 19;
            this.txtInfoDelivery.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInfoDelivery.DefaultText = "";
            this.txtInfoDelivery.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInfoDelivery.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInfoDelivery.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInfoDelivery.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInfoDelivery.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInfoDelivery.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtInfoDelivery.ForeColor = System.Drawing.Color.Black;
            this.txtInfoDelivery.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInfoDelivery.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtInfoDelivery.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtInfoDelivery.Location = new System.Drawing.Point(59, 369);
            this.txtInfoDelivery.Margin = new System.Windows.Forms.Padding(2);
            this.txtInfoDelivery.Name = "txtInfoDelivery";
            this.txtInfoDelivery.PasswordChar = '\0';
            this.txtInfoDelivery.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtInfoDelivery.PlaceholderText = "";
            this.txtInfoDelivery.SelectedText = "";
            this.txtInfoDelivery.Size = new System.Drawing.Size(347, 40);
            this.txtInfoDelivery.TabIndex = 59;
            this.txtInfoDelivery.Tag = "";
            // 
            // lblAddres
            // 
            this.lblAddres.AutoSize = true;
            this.lblAddres.BackColor = System.Drawing.Color.Transparent;
            this.lblAddres.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddres.ForeColor = System.Drawing.Color.White;
            this.lblAddres.Location = new System.Drawing.Point(62, 154);
            this.lblAddres.Name = "lblAddres";
            this.lblAddres.Size = new System.Drawing.Size(89, 24);
            this.lblAddres.TabIndex = 58;
            this.lblAddres.Text = "Address";
            // 
            // lblCourier
            // 
            this.lblCourier.AutoSize = true;
            this.lblCourier.BackColor = System.Drawing.Color.Transparent;
            this.lblCourier.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourier.ForeColor = System.Drawing.Color.White;
            this.lblCourier.Location = new System.Drawing.Point(62, 72);
            this.lblCourier.Name = "lblCourier";
            this.lblCourier.Size = new System.Drawing.Size(83, 24);
            this.lblCourier.TabIndex = 57;
            this.lblCourier.Text = "Courier";
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
            this.txtAddress.Location = new System.Drawing.Point(59, 177);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(347, 40);
            this.txtAddress.TabIndex = 56;
            this.txtAddress.Tag = "t";
            // 
            // comboCourier
            // 
            this.comboCourier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboCourier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboCourier.DropDownHeight = 105;
            this.comboCourier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboCourier.FormattingEnabled = true;
            this.comboCourier.IntegralHeight = false;
            this.comboCourier.Location = new System.Drawing.Point(59, 96);
            this.comboCourier.Name = "comboCourier";
            this.comboCourier.Size = new System.Drawing.Size(347, 32);
            this.comboCourier.TabIndex = 55;
            this.comboCourier.Tag = "com";
            // 
            // lblDeliveryDetail
            // 
            this.lblDeliveryDetail.AutoSize = true;
            this.lblDeliveryDetail.BackColor = System.Drawing.Color.Transparent;
            this.lblDeliveryDetail.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryDetail.ForeColor = System.Drawing.Color.White;
            this.lblDeliveryDetail.Location = new System.Drawing.Point(165, 12);
            this.lblDeliveryDetail.Name = "lblDeliveryDetail";
            this.lblDeliveryDetail.Size = new System.Drawing.Size(157, 24);
            this.lblDeliveryDetail.TabIndex = 51;
            this.lblDeliveryDetail.Text = "Delivery Detail";
            // 
            // panelOrder
            // 
            this.panelOrder.BackColor = System.Drawing.Color.Transparent;
            this.panelOrder.BorderRadius = 40;
            this.panelOrder.Controls.Add(this.btnOrder);
            this.panelOrder.Controls.Add(this.btnPrevious);
            this.panelOrder.Controls.Add(this.btnNext);
            this.panelOrder.CustomizableEdges.TopLeft = false;
            this.panelOrder.CustomizableEdges.TopRight = false;
            this.panelOrder.FillColor = System.Drawing.Color.Navy;
            this.panelOrder.Location = new System.Drawing.Point(974, 791);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(458, 121);
            this.panelOrder.TabIndex = 52;
            // 
            // btnOrder
            // 
            this.btnOrder.Animated = true;
            this.btnOrder.AutoRoundedCorners = true;
            this.btnOrder.BorderRadius = 19;
            this.btnOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrder.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOrder.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnOrder.ImageSize = new System.Drawing.Size(25, 25);
            this.btnOrder.Location = new System.Drawing.Point(170, 42);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(140, 40);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "ORDER";
            this.btnOrder.Visible = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
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
            this.btnPrevious.Location = new System.Drawing.Point(32, 31);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(60, 60);
            this.btnPrevious.TabIndex = 3;
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
            this.btnNext.Location = new System.Drawing.Point(385, 31);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(60, 60);
            this.btnNext.TabIndex = 2;
            this.btnNext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // flowMenu
            // 
            this.flowMenu.AutoScroll = true;
            this.flowMenu.BackColor = System.Drawing.Color.White;
            this.flowMenu.Location = new System.Drawing.Point(28, 317);
            this.flowMenu.Name = "flowMenu";
            this.flowMenu.Size = new System.Drawing.Size(937, 595);
            this.flowMenu.TabIndex = 53;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomer.ForeColor = System.Drawing.Color.Black;
            this.lblCustomer.Location = new System.Drawing.Point(383, 216);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(110, 24);
            this.lblCustomer.TabIndex = 55;
            this.lblCustomer.Text = "Customer";
            // 
            // comboCustomer
            // 
            this.comboCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboCustomer.DropDownHeight = 105;
            this.comboCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboCustomer.FormattingEnabled = true;
            this.comboCustomer.IntegralHeight = false;
            this.comboCustomer.Location = new System.Drawing.Point(373, 244);
            this.comboCustomer.Name = "comboCustomer";
            this.comboCustomer.Size = new System.Drawing.Size(250, 32);
            this.comboCustomer.TabIndex = 54;
            this.comboCustomer.Tag = "com";
            this.comboCustomer.SelectedIndexChanged += new System.EventHandler(this.comboCustomer_SelectedIndexChanged);
            // 
            // cbConfim
            // 
            this.cbConfim.AutoSize = true;
            this.cbConfim.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbConfim.CheckedState.BorderRadius = 0;
            this.cbConfim.CheckedState.BorderThickness = 0;
            this.cbConfim.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbConfim.ForeColor = System.Drawing.Color.Black;
            this.cbConfim.Location = new System.Drawing.Point(992, 74);
            this.cbConfim.Name = "cbConfim";
            this.cbConfim.Size = new System.Drawing.Size(167, 28);
            this.cbConfim.TabIndex = 84;
            this.cbConfim.Text = "Confirm Sales";
            this.cbConfim.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbConfim.UncheckedState.BorderRadius = 0;
            this.cbConfim.UncheckedState.BorderThickness = 0;
            this.cbConfim.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbConfim.Visible = false;
            // 
            // controlExit
            // 
            this.controlExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlExit.BackColor = System.Drawing.Color.Transparent;
            this.controlExit.FillColor = System.Drawing.Color.Red;
            this.controlExit.IconColor = System.Drawing.Color.White;
            this.controlExit.Location = new System.Drawing.Point(1422, 23);
            this.controlExit.Name = "controlExit";
            this.controlExit.Size = new System.Drawing.Size(45, 30);
            this.controlExit.TabIndex = 86;
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.BackColor = System.Drawing.Color.Transparent;
            this.lblClock.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.Color.Black;
            this.lblClock.Location = new System.Drawing.Point(988, 29);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(63, 24);
            this.lblClock.TabIndex = 87;
            this.lblClock.Text = "00:00";
            // 
            // flowShopingCart
            // 
            this.flowShopingCart.AutoScroll = true;
            this.flowShopingCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(200)))), ((int)(((byte)(248)))));
            this.flowShopingCart.Location = new System.Drawing.Point(974, 237);
            this.flowShopingCart.Name = "flowShopingCart";
            this.flowShopingCart.Size = new System.Drawing.Size(458, 543);
            this.flowShopingCart.TabIndex = 88;
            // 
            // elipsMenu
            // 
            this.elipsMenu.BorderRadius = 30;
            this.elipsMenu.TargetControl = this.flowMenu;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.AutoRoundedCorners = true;
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
            this.txtSearch.Location = new System.Drawing.Point(57, 237);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search Here";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(250, 40);
            this.txtSearch.TabIndex = 56;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pictLogo
            // 
            this.pictLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictLogo.Image = global::POS_SYSTEM.Properties.Resources.shopping_basket_color;
            this.pictLogo.ImageRotate = 0F;
            this.pictLogo.Location = new System.Drawing.Point(30, 23);
            this.pictLogo.Name = "pictLogo";
            this.pictLogo.Size = new System.Drawing.Size(60, 60);
            this.pictLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictLogo.TabIndex = 4;
            this.pictLogo.TabStop = false;
            this.pictLogo.UseTransparentBackground = true;
            // 
            // frmSaleAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 970);
            this.Controls.Add(this.flowCheckOut);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.controlExit);
            this.Controls.Add(this.cbConfim);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.comboCustomer);
            this.Controls.Add(this.flowMenu);
            this.Controls.Add(this.panelOrder);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.txtInfoTransaction);
            this.Controls.Add(this.panelGT);
            this.Controls.Add(this.txtTimeSales);
            this.Controls.Add(this.lblTimeSales);
            this.Controls.Add(this.dateSales);
            this.Controls.Add(this.lblDateSales);
            this.Controls.Add(this.pictLogo);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.flowShopingCart);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmSaleAdd";
            this.Text = "frmSaleAdd";
            this.Load += new System.EventHandler(this.frmSaleAdd_Load);
            this.panelGT.ResumeLayout(false);
            this.panelGT.PerformLayout();
            this.flowCheckOut.ResumeLayout(false);
            this.panelPayment.ResumeLayout(false);
            this.panelPayment.PerformLayout();
            this.panelLoan.ResumeLayout(false);
            this.panelLoan.PerformLayout();
            this.panelDeposit.ResumeLayout(false);
            this.panelDeposit.PerformLayout();
            this.panelShipping.ResumeLayout(false);
            this.panelShipping.PerformLayout();
            this.panelDelivery.ResumeLayout(false);
            this.panelDelivery.PerformLayout();
            this.panelOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2PictureBox pictLogo;
        public System.Windows.Forms.Label lblHeader;
        private Guna.UI2.WinForms.Guna2Elipse elipsForm;
        public Guna.UI2.WinForms.Guna2DateTimePicker dateSales;
        private System.Windows.Forms.Label lblDateSales;
        public Guna.UI2.WinForms.Guna2TextBox txtTimeSales;
        private System.Windows.Forms.Label lblTimeSales;
        private Guna.UI2.WinForms.Guna2Panel panelGT;
        private System.Windows.Forms.Label lblInformation;
        public Guna.UI2.WinForms.Guna2TextBox txtInfoTransaction;
        private Guna.UI2.WinForms.Guna2Panel panelOrder;
        private System.Windows.Forms.FlowLayoutPanel flowCheckOut;
        private System.Windows.Forms.FlowLayoutPanel flowMenu;
        private System.Windows.Forms.Label lblCustomer;
        public System.Windows.Forms.ComboBox comboCustomer;
        public Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2CheckBox cbConfim;
        public System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.Label lblGT;
        private Guna.UI2.WinForms.Guna2ControlBox controlExit;
        public System.Windows.Forms.Label lblClock;
        private Guna.UI2.WinForms.Guna2Panel panelPayment;
        private System.Windows.Forms.Label lblPaymentOption;
        private System.Windows.Forms.RadioButton radioDeposit;
        private System.Windows.Forms.RadioButton radioLoan;
        private System.Windows.Forms.RadioButton radioCash;
        private Guna.UI2.WinForms.Guna2Panel panelLoan;
        public System.Windows.Forms.Label lblInstallment;
        private System.Windows.Forms.RadioButton radio12X;
        private System.Windows.Forms.RadioButton radio6X;
        private System.Windows.Forms.RadioButton radio3X;
        private Guna.UI2.WinForms.Guna2Panel panelDeposit;
        public Guna.UI2.WinForms.Guna2TextBox txtBalance;
        public System.Windows.Forms.Label lblBalance;
        private Guna.UI2.WinForms.Guna2Panel panelShipping;
        private System.Windows.Forms.Label lblShippingOption;
        private System.Windows.Forms.RadioButton radioDelivery;
        private System.Windows.Forms.RadioButton radioSelfPick;
        private Guna.UI2.WinForms.Guna2Panel panelDelivery;
        public System.Windows.Forms.Label lblDeliveryDetail;
        private System.Windows.Forms.FlowLayoutPanel flowShopingCart;
        public System.Windows.Forms.Label lblInfoDelivery;
        public Guna.UI2.WinForms.Guna2TextBox txtInfoDelivery;
        public System.Windows.Forms.Label lblAddres;
        public System.Windows.Forms.Label lblCourier;
        public Guna.UI2.WinForms.Guna2TextBox txtAddress;
        public System.Windows.Forms.ComboBox comboCourier;
        public Guna.UI2.WinForms.Guna2Button btnNext;
        public Guna.UI2.WinForms.Guna2Button btnPrevious;
        public Guna.UI2.WinForms.Guna2Button btnOrder;
        private Guna.UI2.WinForms.Guna2Elipse elipsMenu;
        private Guna.UI2.WinForms.Guna2Separator seperatePayment;
        private Guna.UI2.WinForms.Guna2Separator seperateInstallment;
        private Guna.UI2.WinForms.Guna2Separator seperateBalance;
        private Guna.UI2.WinForms.Guna2Separator seperateShippingOption;
        private Guna.UI2.WinForms.Guna2Separator seperateDeliveryDetail;
        public Guna.UI2.WinForms.Guna2TextBox txtCost;
        private System.Windows.Forms.Label lblDeliveryCost;
    }
}