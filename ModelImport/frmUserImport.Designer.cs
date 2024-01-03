namespace POS_SYSTEM.ModelImport
{
    partial class frmUserImport
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
            this.comboSheet = new System.Windows.Forms.ComboBox();
            this.txtFileName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSheet = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.dataImport = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvStaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elipsTable = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnBrowse = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataImport)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClock
            // 
            this.lblClock.Visible = false;
            // 
            // comboSheet
            // 
            this.comboSheet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboSheet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboSheet.DropDownHeight = 105;
            this.comboSheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboSheet.FormattingEnabled = true;
            this.comboSheet.IntegralHeight = false;
            this.comboSheet.Location = new System.Drawing.Point(133, 580);
            this.comboSheet.Name = "comboSheet";
            this.comboSheet.Size = new System.Drawing.Size(250, 32);
            this.comboSheet.TabIndex = 23;
            this.comboSheet.Tag = "com";
            this.comboSheet.SelectedIndexChanged += new System.EventHandler(this.comboSheet_SelectedIndexChanged);
            // 
            // txtFileName
            // 
            this.txtFileName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFileName.DefaultText = "";
            this.txtFileName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFileName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFileName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFileName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFileName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFileName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFileName.Location = new System.Drawing.Point(133, 528);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.PasswordChar = '\0';
            this.txtFileName.PlaceholderText = "";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.SelectedText = "";
            this.txtFileName.Size = new System.Drawing.Size(725, 35);
            this.txtFileName.TabIndex = 22;
            this.txtFileName.Tag = "t";
            // 
            // lblSheet
            // 
            this.lblSheet.AutoSize = true;
            this.lblSheet.Location = new System.Drawing.Point(53, 580);
            this.lblSheet.Name = "lblSheet";
            this.lblSheet.Size = new System.Drawing.Size(68, 24);
            this.lblSheet.TabIndex = 21;
            this.lblSheet.Text = "Sheet";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(53, 528);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(42, 24);
            this.lblFileName.TabIndex = 20;
            this.lblFileName.Text = "File";
            // 
            // dataImport
            // 
            this.dataImport.AllowUserToAddRows = false;
            this.dataImport.AllowUserToDeleteRows = false;
            this.dataImport.AllowUserToOrderColumns = true;
            this.dataImport.AllowUserToResizeColumns = false;
            this.dataImport.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataImport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataImport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataImport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(169)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataImport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataImport.ColumnHeadersHeight = 50;
            this.dataImport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvStaffID,
            this.dgvUsername,
            this.dgvPassword,
            this.dgvInfo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataImport.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataImport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataImport.Location = new System.Drawing.Point(57, 171);
            this.dataImport.Name = "dataImport";
            this.dataImport.ReadOnly = true;
            this.dataImport.RowHeadersVisible = false;
            this.dataImport.Size = new System.Drawing.Size(971, 334);
            this.dataImport.TabIndex = 19;
            this.dataImport.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataImport.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataImport.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataImport.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataImport.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataImport.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataImport.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataImport.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataImport.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataImport.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataImport.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataImport.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataImport.ThemeStyle.HeaderStyle.Height = 50;
            this.dataImport.ThemeStyle.ReadOnly = true;
            this.dataImport.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataImport.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataImport.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataImport.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataImport.ThemeStyle.RowsStyle.Height = 22;
            this.dataImport.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataImport.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dgvStaffID
            // 
            this.dgvStaffID.HeaderText = "Staff ID";
            this.dgvStaffID.Name = "dgvStaffID";
            this.dgvStaffID.ReadOnly = true;
            // 
            // dgvUsername
            // 
            this.dgvUsername.HeaderText = "Username";
            this.dgvUsername.Name = "dgvUsername";
            this.dgvUsername.ReadOnly = true;
            // 
            // dgvPassword
            // 
            this.dgvPassword.HeaderText = "Password";
            this.dgvPassword.Name = "dgvPassword";
            this.dgvPassword.ReadOnly = true;
            // 
            // dgvInfo
            // 
            this.dgvInfo.HeaderText = "Info";
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.ReadOnly = true;
            // 
            // elipsTable
            // 
            this.elipsTable.BorderRadius = 30;
            this.elipsTable.TargetControl = this.dataImport;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Animated = true;
            this.btnBrowse.BackColor = System.Drawing.Color.Transparent;
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
            this.btnBrowse.Location = new System.Drawing.Point(888, 528);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(140, 35);
            this.btnBrowse.TabIndex = 31;
            this.btnBrowse.Text = "...";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // frmUserImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 753);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.comboSheet);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblSheet);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.dataImport);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmUserImport";
            this.Text = "frmUserImport";
            this.Load += new System.EventHandler(this.frmUserImport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataImport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox comboSheet;
        private Guna.UI2.WinForms.Guna2TextBox txtFileName;
        private System.Windows.Forms.Label lblSheet;
        private System.Windows.Forms.Label lblFileName;
        private Guna.UI2.WinForms.Guna2DataGridView dataImport;
        public Guna.UI2.WinForms.Guna2Elipse elipsTable;
        public Guna.UI2.WinForms.Guna2Button btnBrowse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInfo;
    }
}