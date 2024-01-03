namespace POS_SYSTEM.Model
{
    partial class frmLoanPay
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
            this.txtInvoiceID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblInvoiceID = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.txtCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtDue = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDue = new System.Windows.Forms.Label();
            this.txtInstalment = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblInstalment = new System.Windows.Forms.Label();
            this.datePaid = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblDatePaid = new System.Windows.Forms.Label();
            this.lblInformation = new System.Windows.Forms.Label();
            this.txtInfo = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.AutoRoundedCorners = true;
            this.txtInvoiceID.AutoSize = true;
            this.txtInvoiceID.BackColor = System.Drawing.Color.Transparent;
            this.txtInvoiceID.BorderRadius = 19;
            this.txtInvoiceID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInvoiceID.DefaultText = "";
            this.txtInvoiceID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInvoiceID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInvoiceID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInvoiceID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInvoiceID.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtInvoiceID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInvoiceID.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtInvoiceID.ForeColor = System.Drawing.Color.Black;
            this.txtInvoiceID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInvoiceID.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtInvoiceID.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtInvoiceID.Location = new System.Drawing.Point(92, 183);
            this.txtInvoiceID.Margin = new System.Windows.Forms.Padding(2);
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.PasswordChar = '\0';
            this.txtInvoiceID.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtInvoiceID.PlaceholderText = "auto complete";
            this.txtInvoiceID.ReadOnly = true;
            this.txtInvoiceID.SelectedText = "";
            this.txtInvoiceID.Size = new System.Drawing.Size(250, 40);
            this.txtInvoiceID.TabIndex = 55;
            this.txtInvoiceID.Tag = "t";
            // 
            // lblInvoiceID
            // 
            this.lblInvoiceID.AutoSize = true;
            this.lblInvoiceID.BackColor = System.Drawing.Color.Transparent;
            this.lblInvoiceID.ForeColor = System.Drawing.Color.Black;
            this.lblInvoiceID.Location = new System.Drawing.Point(102, 157);
            this.lblInvoiceID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvoiceID.Name = "lblInvoiceID";
            this.lblInvoiceID.Size = new System.Drawing.Size(113, 24);
            this.lblInvoiceID.TabIndex = 54;
            this.lblInvoiceID.Text = "Invoice ID";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(102, 465);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(69, 24);
            this.lblStatus.TabIndex = 57;
            this.lblStatus.Text = "Status";
            // 
            // comboStatus
            // 
            this.comboStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboStatus.DropDownHeight = 105;
            this.comboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.IntegralHeight = false;
            this.comboStatus.Items.AddRange(new object[] {
            "paid",
            "pending"});
            this.comboStatus.Location = new System.Drawing.Point(92, 500);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(250, 32);
            this.comboStatus.TabIndex = 56;
            this.comboStatus.Tag = "com";
            // 
            // txtCustomer
            // 
            this.txtCustomer.AutoRoundedCorners = true;
            this.txtCustomer.AutoSize = true;
            this.txtCustomer.BackColor = System.Drawing.Color.Transparent;
            this.txtCustomer.BorderRadius = 19;
            this.txtCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomer.DefaultText = "";
            this.txtCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomer.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomer.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtCustomer.ForeColor = System.Drawing.Color.Black;
            this.txtCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomer.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtCustomer.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtCustomer.Location = new System.Drawing.Point(92, 281);
            this.txtCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.PasswordChar = '\0';
            this.txtCustomer.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtCustomer.PlaceholderText = "auto complete";
            this.txtCustomer.ReadOnly = true;
            this.txtCustomer.SelectedText = "";
            this.txtCustomer.Size = new System.Drawing.Size(250, 40);
            this.txtCustomer.TabIndex = 59;
            this.txtCustomer.Tag = "t";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomer.ForeColor = System.Drawing.Color.Black;
            this.lblCustomer.Location = new System.Drawing.Point(102, 255);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(110, 24);
            this.lblCustomer.TabIndex = 58;
            this.lblCustomer.Text = "Customer";
            // 
            // txtAmount
            // 
            this.txtAmount.AutoRoundedCorners = true;
            this.txtAmount.AutoSize = true;
            this.txtAmount.BackColor = System.Drawing.Color.Transparent;
            this.txtAmount.BorderRadius = 19;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.DefaultText = "";
            this.txtAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtAmount.ForeColor = System.Drawing.Color.Black;
            this.txtAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtAmount.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtAmount.Location = new System.Drawing.Point(92, 385);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtAmount.PlaceholderText = "auto complete";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.SelectedText = "";
            this.txtAmount.Size = new System.Drawing.Size(250, 40);
            this.txtAmount.TabIndex = 61;
            this.txtAmount.Tag = "t";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.ForeColor = System.Drawing.Color.Black;
            this.lblAmount.Location = new System.Drawing.Point(102, 359);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(93, 24);
            this.lblAmount.TabIndex = 60;
            this.lblAmount.Text = "Amount";
            // 
            // txtDue
            // 
            this.txtDue.AutoRoundedCorners = true;
            this.txtDue.AutoSize = true;
            this.txtDue.BackColor = System.Drawing.Color.Transparent;
            this.txtDue.BorderRadius = 19;
            this.txtDue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDue.DefaultText = "";
            this.txtDue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDue.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtDue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDue.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtDue.ForeColor = System.Drawing.Color.Black;
            this.txtDue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDue.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtDue.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtDue.Location = new System.Drawing.Point(426, 183);
            this.txtDue.Margin = new System.Windows.Forms.Padding(2);
            this.txtDue.Name = "txtDue";
            this.txtDue.PasswordChar = '\0';
            this.txtDue.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtDue.PlaceholderText = "auto complete";
            this.txtDue.ReadOnly = true;
            this.txtDue.SelectedText = "";
            this.txtDue.Size = new System.Drawing.Size(250, 40);
            this.txtDue.TabIndex = 63;
            this.txtDue.Tag = "t";
            // 
            // lblDue
            // 
            this.lblDue.AutoSize = true;
            this.lblDue.BackColor = System.Drawing.Color.Transparent;
            this.lblDue.ForeColor = System.Drawing.Color.Black;
            this.lblDue.Location = new System.Drawing.Point(436, 157);
            this.lblDue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDue.Name = "lblDue";
            this.lblDue.Size = new System.Drawing.Size(53, 24);
            this.lblDue.TabIndex = 62;
            this.lblDue.Text = "Due";
            // 
            // txtInstalment
            // 
            this.txtInstalment.AutoRoundedCorners = true;
            this.txtInstalment.AutoSize = true;
            this.txtInstalment.BackColor = System.Drawing.Color.Transparent;
            this.txtInstalment.BorderRadius = 19;
            this.txtInstalment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInstalment.DefaultText = "";
            this.txtInstalment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInstalment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInstalment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInstalment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInstalment.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtInstalment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInstalment.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtInstalment.ForeColor = System.Drawing.Color.Black;
            this.txtInstalment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInstalment.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtInstalment.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtInstalment.Location = new System.Drawing.Point(426, 281);
            this.txtInstalment.Margin = new System.Windows.Forms.Padding(2);
            this.txtInstalment.Name = "txtInstalment";
            this.txtInstalment.PasswordChar = '\0';
            this.txtInstalment.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtInstalment.PlaceholderText = "auto complete";
            this.txtInstalment.ReadOnly = true;
            this.txtInstalment.SelectedText = "";
            this.txtInstalment.Size = new System.Drawing.Size(250, 40);
            this.txtInstalment.TabIndex = 65;
            this.txtInstalment.Tag = "t";
            // 
            // lblInstalment
            // 
            this.lblInstalment.AutoSize = true;
            this.lblInstalment.BackColor = System.Drawing.Color.Transparent;
            this.lblInstalment.ForeColor = System.Drawing.Color.Black;
            this.lblInstalment.Location = new System.Drawing.Point(436, 255);
            this.lblInstalment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInstalment.Name = "lblInstalment";
            this.lblInstalment.Size = new System.Drawing.Size(117, 24);
            this.lblInstalment.TabIndex = 64;
            this.lblInstalment.Text = "Instalment";
            // 
            // datePaid
            // 
            this.datePaid.AutoRoundedCorners = true;
            this.datePaid.BorderRadius = 17;
            this.datePaid.Checked = true;
            this.datePaid.FillColor = System.Drawing.Color.White;
            this.datePaid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePaid.ForeColor = System.Drawing.Color.Black;
            this.datePaid.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePaid.Location = new System.Drawing.Point(426, 385);
            this.datePaid.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datePaid.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datePaid.Name = "datePaid";
            this.datePaid.Size = new System.Drawing.Size(250, 36);
            this.datePaid.TabIndex = 67;
            this.datePaid.Value = new System.DateTime(2023, 9, 20, 14, 30, 24, 405);
            // 
            // lblDatePaid
            // 
            this.lblDatePaid.AutoSize = true;
            this.lblDatePaid.BackColor = System.Drawing.Color.Transparent;
            this.lblDatePaid.ForeColor = System.Drawing.Color.Black;
            this.lblDatePaid.Location = new System.Drawing.Point(443, 359);
            this.lblDatePaid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatePaid.Name = "lblDatePaid";
            this.lblDatePaid.Size = new System.Drawing.Size(110, 24);
            this.lblDatePaid.TabIndex = 66;
            this.lblDatePaid.Text = "Date Paid";
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.BackColor = System.Drawing.Color.Transparent;
            this.lblInformation.ForeColor = System.Drawing.Color.Black;
            this.lblInformation.Location = new System.Drawing.Point(445, 466);
            this.lblInformation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(49, 24);
            this.lblInformation.TabIndex = 105;
            this.lblInformation.Text = "Info";
            // 
            // txtInfo
            // 
            this.txtInfo.AutoRoundedCorners = true;
            this.txtInfo.AutoSize = true;
            this.txtInfo.BackColor = System.Drawing.Color.Transparent;
            this.txtInfo.BorderRadius = 19;
            this.txtInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInfo.DefaultText = "";
            this.txtInfo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInfo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInfo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInfo.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtInfo.ForeColor = System.Drawing.Color.Black;
            this.txtInfo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInfo.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtInfo.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtInfo.Location = new System.Drawing.Point(426, 492);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(2);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.PasswordChar = '\0';
            this.txtInfo.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtInfo.PlaceholderText = "";
            this.txtInfo.SelectedText = "";
            this.txtInfo.Size = new System.Drawing.Size(250, 40);
            this.txtInfo.TabIndex = 104;
            this.txtInfo.Tag = "";
            // 
            // frmLoanPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 671);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.datePaid);
            this.Controls.Add(this.lblDatePaid);
            this.Controls.Add(this.txtInstalment);
            this.Controls.Add(this.lblInstalment);
            this.Controls.Add(this.txtDue);
            this.Controls.Add(this.lblDue);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.txtInvoiceID);
            this.Controls.Add(this.lblInvoiceID);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmLoanPay";
            this.Text = "frmLoanPay";
            this.Load += new System.EventHandler(this.frmLoanPay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2TextBox txtInvoiceID;
        private System.Windows.Forms.Label lblInvoiceID;
        private System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.ComboBox comboStatus;
        public Guna.UI2.WinForms.Guna2TextBox txtCustomer;
        private System.Windows.Forms.Label lblCustomer;
        public Guna.UI2.WinForms.Guna2TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        public Guna.UI2.WinForms.Guna2TextBox txtDue;
        private System.Windows.Forms.Label lblDue;
        public Guna.UI2.WinForms.Guna2TextBox txtInstalment;
        private System.Windows.Forms.Label lblInstalment;
        public Guna.UI2.WinForms.Guna2DateTimePicker datePaid;
        private System.Windows.Forms.Label lblDatePaid;
        private System.Windows.Forms.Label lblInformation;
        public Guna.UI2.WinForms.Guna2TextBox txtInfo;
    }
}