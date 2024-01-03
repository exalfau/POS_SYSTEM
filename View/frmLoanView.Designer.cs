namespace POS_SYSTEM.View
{
    partial class frmLoanView
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
            this.elipsTable = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dataLoan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInvoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDatePaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInstalment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPay = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataLoan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Text = "Loan";
            // 
            // elipsTable
            // 
            this.elipsTable.BorderRadius = 30;
            this.elipsTable.TargetControl = this.dataLoan;
            // 
            // dataLoan
            // 
            this.dataLoan.AllowUserToAddRows = false;
            this.dataLoan.AllowUserToDeleteRows = false;
            this.dataLoan.AllowUserToOrderColumns = true;
            this.dataLoan.AllowUserToResizeColumns = false;
            this.dataLoan.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataLoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataLoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataLoan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(169)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataLoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataLoan.ColumnHeadersHeight = 50;
            this.dataLoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCheck,
            this.dgvID,
            this.dgvInvoiceID,
            this.dgvCustomer,
            this.dgvAmount,
            this.dgvDue,
            this.dgvDatePaid,
            this.dgvInstalment,
            this.dgvStatus,
            this.dgvPay});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataLoan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataLoan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataLoan.Location = new System.Drawing.Point(48, 149);
            this.dataLoan.Name = "dataLoan";
            this.dataLoan.RowHeadersVisible = false;
            this.dataLoan.Size = new System.Drawing.Size(1182, 297);
            this.dataLoan.TabIndex = 6;
            this.dataLoan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataLoan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataLoan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataLoan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataLoan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataLoan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataLoan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataLoan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataLoan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataLoan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLoan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataLoan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataLoan.ThemeStyle.HeaderStyle.Height = 50;
            this.dataLoan.ThemeStyle.ReadOnly = false;
            this.dataLoan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataLoan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataLoan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLoan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataLoan.ThemeStyle.RowsStyle.Height = 22;
            this.dataLoan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataLoan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataLoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLoan_CellClick);
            this.dataLoan.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLoan_CellValueChanged);
            this.dataLoan.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataLoan_ColumnHeaderMouseClick);
            // 
            // dgvCheck
            // 
            this.dgvCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvCheck.FillWeight = 50F;
            this.dgvCheck.HeaderText = "";
            this.dgvCheck.MinimumWidth = 50;
            this.dgvCheck.Name = "dgvCheck";
            this.dgvCheck.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvCheck.Width = 50;
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
            this.dgvInvoiceID.FillWeight = 70.69971F;
            this.dgvInvoiceID.HeaderText = "Invoice ID";
            this.dgvInvoiceID.Name = "dgvInvoiceID";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.FillWeight = 70.69971F;
            this.dgvCustomer.HeaderText = "Customer";
            this.dgvCustomer.Name = "dgvCustomer";
            // 
            // dgvAmount
            // 
            this.dgvAmount.FillWeight = 70.69971F;
            this.dgvAmount.HeaderText = "Amount";
            this.dgvAmount.Name = "dgvAmount";
            // 
            // dgvDue
            // 
            this.dgvDue.FillWeight = 70.69971F;
            this.dgvDue.HeaderText = "Due";
            this.dgvDue.Name = "dgvDue";
            // 
            // dgvDatePaid
            // 
            this.dgvDatePaid.FillWeight = 70.69971F;
            this.dgvDatePaid.HeaderText = "Date Paid";
            this.dgvDatePaid.Name = "dgvDatePaid";
            // 
            // dgvInstalment
            // 
            this.dgvInstalment.FillWeight = 70.69971F;
            this.dgvInstalment.HeaderText = "Instalment";
            this.dgvInstalment.Name = "dgvInstalment";
            // 
            // dgvStatus
            // 
            this.dgvStatus.FillWeight = 70.69971F;
            this.dgvStatus.HeaderText = "Status";
            this.dgvStatus.Name = "dgvStatus";
            // 
            // dgvPay
            // 
            this.dgvPay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvPay.FillWeight = 40F;
            this.dgvPay.HeaderText = "";
            this.dgvPay.Image = global::POS_SYSTEM.Properties.Resources.pay;
            this.dgvPay.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvPay.MinimumWidth = 50;
            this.dgvPay.Name = "dgvPay";
            this.dgvPay.Width = 50;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 40F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::POS_SYSTEM.Properties.Resources.pay;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 50;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // frmLoanView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 520);
            this.Controls.Add(this.dataLoan);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmLoanView";
            this.Text = "frmLoanView";
            this.Load += new System.EventHandler(this.frmLoanView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Elipse elipsTable;
        private Guna.UI2.WinForms.Guna2DataGridView dataLoan;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInvoiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDatePaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInstalment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStatus;
        private System.Windows.Forms.DataGridViewImageColumn dgvPay;
    }
}