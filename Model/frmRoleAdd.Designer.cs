namespace POS_SYSTEM.Model
{
    partial class frmRoleAdd
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
            this.lblCode = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.elipsTable = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dataPrivilege = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtInformation = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblInformation = new System.Windows.Forms.Label();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFeature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvViewValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCreateValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUpdateValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDeleteValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvExportValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvImportValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvView = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvCreate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvUpdate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvExport = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvImport = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataPrivilege)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.BackColor = System.Drawing.Color.Transparent;
            this.lblCode.ForeColor = System.Drawing.Color.Black;
            this.lblCode.Location = new System.Drawing.Point(376, 157);
            this.lblCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(69, 24);
            this.lblCode.TabIndex = 15;
            this.lblCode.Text = "Code";
            // 
            // txtName
            // 
            this.txtName.AutoRoundedCorners = true;
            this.txtName.AutoSize = true;
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.BorderRadius = 19;
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
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
            this.txtName.Location = new System.Drawing.Point(63, 183);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(250, 40);
            this.txtName.TabIndex = 14;
            this.txtName.Tag = "t";
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(73, 157);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 24);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Name";
            // 
            // txtCode
            // 
            this.txtCode.AutoRoundedCorners = true;
            this.txtCode.AutoSize = true;
            this.txtCode.BackColor = System.Drawing.Color.Transparent;
            this.txtCode.BorderRadius = 19;
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.DefaultText = "";
            this.txtCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCode.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCode.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtCode.ForeColor = System.Drawing.Color.Black;
            this.txtCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCode.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtCode.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtCode.Location = new System.Drawing.Point(359, 183);
            this.txtCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtCode.PlaceholderText = "auto complete";
            this.txtCode.ReadOnly = true;
            this.txtCode.SelectedText = "";
            this.txtCode.Size = new System.Drawing.Size(250, 40);
            this.txtCode.TabIndex = 16;
            this.txtCode.Tag = "t";
            // 
            // elipsTable
            // 
            this.elipsTable.BorderRadius = 30;
            this.elipsTable.TargetControl = this.dataPrivilege;
            // 
            // dataPrivilege
            // 
            this.dataPrivilege.AllowUserToAddRows = false;
            this.dataPrivilege.AllowUserToDeleteRows = false;
            this.dataPrivilege.AllowUserToOrderColumns = true;
            this.dataPrivilege.AllowUserToResizeColumns = false;
            this.dataPrivilege.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataPrivilege.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataPrivilege.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataPrivilege.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(169)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPrivilege.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataPrivilege.ColumnHeadersHeight = 50;
            this.dataPrivilege.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvFeature,
            this.dgvViewValue,
            this.dgvCreateValue,
            this.dgvUpdateValue,
            this.dgvDeleteValue,
            this.dgvExportValue,
            this.dgvImportValue,
            this.dgvView,
            this.dgvCreate,
            this.dgvUpdate,
            this.dgvDelete,
            this.dgvExport,
            this.dgvImport});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataPrivilege.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataPrivilege.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataPrivilege.Location = new System.Drawing.Point(63, 267);
            this.dataPrivilege.Name = "dataPrivilege";
            this.dataPrivilege.RowHeadersVisible = false;
            this.dataPrivilege.Size = new System.Drawing.Size(841, 479);
            this.dataPrivilege.TabIndex = 79;
            this.dataPrivilege.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataPrivilege.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataPrivilege.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataPrivilege.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataPrivilege.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataPrivilege.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataPrivilege.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataPrivilege.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataPrivilege.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataPrivilege.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPrivilege.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataPrivilege.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataPrivilege.ThemeStyle.HeaderStyle.Height = 50;
            this.dataPrivilege.ThemeStyle.ReadOnly = false;
            this.dataPrivilege.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataPrivilege.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataPrivilege.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPrivilege.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataPrivilege.ThemeStyle.RowsStyle.Height = 22;
            this.dataPrivilege.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataPrivilege.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataPrivilege.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataPrivilege_CellFormatting);
            this.dataPrivilege.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPrivilege_CellValueChanged);
            this.dataPrivilege.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataPrivilege_ColumnHeaderMouseClick);
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
            this.txtInformation.Location = new System.Drawing.Point(654, 183);
            this.txtInformation.Margin = new System.Windows.Forms.Padding(2);
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.PasswordChar = '\0';
            this.txtInformation.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtInformation.PlaceholderText = "";
            this.txtInformation.SelectedText = "";
            this.txtInformation.Size = new System.Drawing.Size(250, 40);
            this.txtInformation.TabIndex = 18;
            this.txtInformation.Tag = "";
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.BackColor = System.Drawing.Color.Transparent;
            this.lblInformation.ForeColor = System.Drawing.Color.Black;
            this.lblInformation.Location = new System.Drawing.Point(673, 157);
            this.lblInformation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(49, 24);
            this.lblInformation.TabIndex = 19;
            this.lblInformation.Text = "Info";
            // 
            // dgvID
            // 
            this.dgvID.FillWeight = 50F;
            this.dgvID.HeaderText = "ID";
            this.dgvID.Name = "dgvID";
            this.dgvID.Visible = false;
            // 
            // dgvFeature
            // 
            this.dgvFeature.FillWeight = 200F;
            this.dgvFeature.HeaderText = "Feature";
            this.dgvFeature.Name = "dgvFeature";
            // 
            // dgvViewValue
            // 
            this.dgvViewValue.HeaderText = "View Value";
            this.dgvViewValue.Name = "dgvViewValue";
            this.dgvViewValue.Visible = false;
            // 
            // dgvCreateValue
            // 
            this.dgvCreateValue.HeaderText = "Create Value";
            this.dgvCreateValue.Name = "dgvCreateValue";
            this.dgvCreateValue.Visible = false;
            // 
            // dgvUpdateValue
            // 
            this.dgvUpdateValue.HeaderText = "Update Value";
            this.dgvUpdateValue.Name = "dgvUpdateValue";
            this.dgvUpdateValue.Visible = false;
            // 
            // dgvDeleteValue
            // 
            this.dgvDeleteValue.HeaderText = "Delete Value";
            this.dgvDeleteValue.Name = "dgvDeleteValue";
            this.dgvDeleteValue.Visible = false;
            // 
            // dgvExportValue
            // 
            this.dgvExportValue.HeaderText = "Export Value";
            this.dgvExportValue.Name = "dgvExportValue";
            this.dgvExportValue.Visible = false;
            // 
            // dgvImportValue
            // 
            this.dgvImportValue.HeaderText = "ImportValue";
            this.dgvImportValue.Name = "dgvImportValue";
            this.dgvImportValue.Visible = false;
            // 
            // dgvView
            // 
            this.dgvView.HeaderText = "View";
            this.dgvView.Name = "dgvView";
            // 
            // dgvCreate
            // 
            this.dgvCreate.HeaderText = "Create";
            this.dgvCreate.Name = "dgvCreate";
            // 
            // dgvUpdate
            // 
            this.dgvUpdate.HeaderText = "Update";
            this.dgvUpdate.Name = "dgvUpdate";
            // 
            // dgvDelete
            // 
            this.dgvDelete.HeaderText = "Delete";
            this.dgvDelete.Name = "dgvDelete";
            // 
            // dgvExport
            // 
            this.dgvExport.HeaderText = "Export";
            this.dgvExport.Name = "dgvExport";
            // 
            // dgvImport
            // 
            this.dgvImport.HeaderText = "Import";
            this.dgvImport.Name = "dgvImport";
            // 
            // frmRoleAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 890);
            this.Controls.Add(this.dataPrivilege);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.txtInformation);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmRoleAdd";
            this.Text = "frmRoleAdd";
            this.Load += new System.EventHandler(this.frmRoleAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPrivilege)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCode;
        public Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label lblName;
        public Guna.UI2.WinForms.Guna2TextBox txtCode;
        public Guna.UI2.WinForms.Guna2Elipse elipsTable;
        public Guna.UI2.WinForms.Guna2TextBox txtInformation;
        private System.Windows.Forms.Label lblInformation;
        private Guna.UI2.WinForms.Guna2DataGridView dataPrivilege;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFeature;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvViewValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCreateValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUpdateValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDeleteValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvExportValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvImportValue;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvCreate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvUpdate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvDelete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvExport;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvImport;
    }
}