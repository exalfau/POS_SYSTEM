namespace POS_SYSTEM.View
{
    partial class frmStaffview
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.elipsTable = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dataStaff = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvJoinDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInformation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Text = "Staff";
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
            this.dgvCheck,
            this.dgvID,
            this.dgvStaffID,
            this.dgvName,
            this.dgvJoinDate,
            this.dgvGender,
            this.dgvRole,
            this.dgvPhone,
            this.dgvAddress,
            this.dgvInformation,
            this.dgvEdit,
            this.dgvDelete});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataStaff.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataStaff.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataStaff.Location = new System.Drawing.Point(63, 144);
            this.dataStaff.Name = "dataStaff";
            this.dataStaff.RowHeadersVisible = false;
            this.dataStaff.Size = new System.Drawing.Size(1182, 297);
            this.dataStaff.TabIndex = 2;
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
            this.dataStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataStaff_CellClick);
            this.dataStaff.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataStaff_CellValueChanged);
            this.dataStaff.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataStaff_ColumnHeaderMouseClick);
            this.dataStaff.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataStaff_DataBindingComplete);
            // 
            // dgvCheck
            // 
            this.dgvCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvCheck.FillWeight = 50F;
            this.dgvCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dgvCheck.HeaderText = "";
            this.dgvCheck.Name = "dgvCheck";
            this.dgvCheck.Width = 50;
            // 
            // dgvID
            // 
            this.dgvID.HeaderText = "";
            this.dgvID.Name = "dgvID";
            this.dgvID.Visible = false;
            // 
            // dgvStaffID
            // 
            this.dgvStaffID.FillWeight = 130F;
            this.dgvStaffID.HeaderText = "Staff ID";
            this.dgvStaffID.Name = "dgvStaffID";
            // 
            // dgvName
            // 
            this.dgvName.FillWeight = 110.2915F;
            this.dgvName.HeaderText = "Name";
            this.dgvName.Name = "dgvName";
            // 
            // dgvJoinDate
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dgvJoinDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvJoinDate.HeaderText = "Join Date";
            this.dgvJoinDate.Name = "dgvJoinDate";
            // 
            // dgvGender
            // 
            this.dgvGender.FillWeight = 65F;
            this.dgvGender.HeaderText = "Gender";
            this.dgvGender.Name = "dgvGender";
            // 
            // dgvRole
            // 
            this.dgvRole.FillWeight = 60F;
            this.dgvRole.HeaderText = "Role";
            this.dgvRole.Name = "dgvRole";
            // 
            // dgvPhone
            // 
            this.dgvPhone.HeaderText = "Phone";
            this.dgvPhone.Name = "dgvPhone";
            // 
            // dgvAddress
            // 
            this.dgvAddress.HeaderText = "Address";
            this.dgvAddress.Name = "dgvAddress";
            // 
            // dgvInformation
            // 
            this.dgvInformation.FillWeight = 73.52769F;
            this.dgvInformation.HeaderText = "Info";
            this.dgvInformation.Name = "dgvInformation";
            // 
            // dgvEdit
            // 
            this.dgvEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvEdit.FillWeight = 30F;
            this.dgvEdit.HeaderText = "";
            this.dgvEdit.Image = global::POS_SYSTEM.Properties.Resources.edit;
            this.dgvEdit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvEdit.MinimumWidth = 50;
            this.dgvEdit.Name = "dgvEdit";
            this.dgvEdit.Width = 50;
            // 
            // dgvDelete
            // 
            this.dgvDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvDelete.FillWeight = 30F;
            this.dgvDelete.HeaderText = "";
            this.dgvDelete.Image = global::POS_SYSTEM.Properties.Resources.delete;
            this.dgvDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvDelete.MinimumWidth = 50;
            this.dgvDelete.Name = "dgvDelete";
            this.dgvDelete.Width = 50;
            // 
            // frmStaffview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 520);
            this.Controls.Add(this.dataStaff);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmStaffview";
            this.Text = "frmStaffview";
            this.Load += new System.EventHandler(this.frmStaffview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataStaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Elipse elipsTable;
        private Guna.UI2.WinForms.Guna2DataGridView dataStaff;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvJoinDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInformation;
        private System.Windows.Forms.DataGridViewImageColumn dgvEdit;
        private System.Windows.Forms.DataGridViewImageColumn dgvDelete;
    }
}