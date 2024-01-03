namespace POS_SYSTEM.Model
{
    partial class frmCourierAdd
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
            this.lblStaffID = new System.Windows.Forms.Label();
            this.comboStaffID = new System.Windows.Forms.ComboBox();
            this.lblInformation = new System.Windows.Forms.Label();
            this.txtInformation = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLP = new System.Windows.Forms.Label();
            this.txtLicensePlate = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.BackColor = System.Drawing.Color.Transparent;
            this.lblStaffID.ForeColor = System.Drawing.Color.Black;
            this.lblStaffID.Location = new System.Drawing.Point(62, 163);
            this.lblStaffID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(76, 24);
            this.lblStaffID.TabIndex = 22;
            this.lblStaffID.Text = "StaffID";
            // 
            // comboStaffID
            // 
            this.comboStaffID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboStaffID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboStaffID.DropDownHeight = 105;
            this.comboStaffID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboStaffID.FormattingEnabled = true;
            this.comboStaffID.IntegralHeight = false;
            this.comboStaffID.Location = new System.Drawing.Point(45, 189);
            this.comboStaffID.Name = "comboStaffID";
            this.comboStaffID.Size = new System.Drawing.Size(250, 32);
            this.comboStaffID.TabIndex = 21;
            this.comboStaffID.Tag = "com";
            this.comboStaffID.SelectedIndexChanged += new System.EventHandler(this.comboID_SelectedIndexChanged);
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.BackColor = System.Drawing.Color.Transparent;
            this.lblInformation.ForeColor = System.Drawing.Color.Black;
            this.lblInformation.Location = new System.Drawing.Point(404, 263);
            this.lblInformation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(49, 24);
            this.lblInformation.TabIndex = 49;
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
            this.txtInformation.Location = new System.Drawing.Point(387, 289);
            this.txtInformation.Margin = new System.Windows.Forms.Padding(2);
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.PasswordChar = '\0';
            this.txtInformation.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtInformation.PlaceholderText = "";
            this.txtInformation.SelectedText = "";
            this.txtInformation.Size = new System.Drawing.Size(250, 40);
            this.txtInformation.TabIndex = 48;
            this.txtInformation.Tag = "";
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
            this.txtName.Location = new System.Drawing.Point(387, 189);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtName.PlaceholderText = "auto complete";
            this.txtName.ReadOnly = true;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(250, 40);
            this.txtName.TabIndex = 47;
            this.txtName.Tag = "t";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(404, 163);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 24);
            this.lblName.TabIndex = 46;
            this.lblName.Text = "Name";
            // 
            // lblLP
            // 
            this.lblLP.AutoSize = true;
            this.lblLP.BackColor = System.Drawing.Color.Transparent;
            this.lblLP.ForeColor = System.Drawing.Color.Black;
            this.lblLP.Location = new System.Drawing.Point(62, 263);
            this.lblLP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLP.Name = "lblLP";
            this.lblLP.Size = new System.Drawing.Size(144, 24);
            this.lblLP.TabIndex = 51;
            this.lblLP.Text = "License Plate";
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.AutoRoundedCorners = true;
            this.txtLicensePlate.AutoSize = true;
            this.txtLicensePlate.BackColor = System.Drawing.Color.Transparent;
            this.txtLicensePlate.BorderRadius = 19;
            this.txtLicensePlate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLicensePlate.DefaultText = "";
            this.txtLicensePlate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLicensePlate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLicensePlate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLicensePlate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLicensePlate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLicensePlate.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtLicensePlate.ForeColor = System.Drawing.Color.Black;
            this.txtLicensePlate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLicensePlate.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtLicensePlate.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtLicensePlate.Location = new System.Drawing.Point(45, 289);
            this.txtLicensePlate.Margin = new System.Windows.Forms.Padding(2);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.PasswordChar = '\0';
            this.txtLicensePlate.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtLicensePlate.PlaceholderText = "BK XXXX XXX";
            this.txtLicensePlate.SelectedText = "";
            this.txtLicensePlate.Size = new System.Drawing.Size(250, 40);
            this.txtLicensePlate.TabIndex = 50;
            this.txtLicensePlate.Tag = "lp";
            // 
            // frmCourierAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 486);
            this.Controls.Add(this.lblLP);
            this.Controls.Add(this.txtLicensePlate);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.txtInformation);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblStaffID);
            this.Controls.Add(this.comboStaffID);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmCourierAdd";
            this.Text = "frmCourierAdd";
            this.Load += new System.EventHandler(this.frmCourierAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStaffID;
        public System.Windows.Forms.ComboBox comboStaffID;
        private System.Windows.Forms.Label lblInformation;
        public Guna.UI2.WinForms.Guna2TextBox txtInformation;
        public Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLP;
        public Guna.UI2.WinForms.Guna2TextBox txtLicensePlate;
    }
}