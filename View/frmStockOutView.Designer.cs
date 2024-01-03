namespace POS_SYSTEM.View
{
    partial class frmStockOutView
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
            this.dataStockOut = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIDStockOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvConfirmValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNettPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCause = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInformation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvConfirm = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataStockOut)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Text = "Stock Out";
            // 
            // elipsTable
            // 
            this.elipsTable.BorderRadius = 30;
            this.elipsTable.TargetControl = this.dataStockOut;
            // 
            // dataStockOut
            // 
            this.dataStockOut.AllowUserToAddRows = false;
            this.dataStockOut.AllowUserToDeleteRows = false;
            this.dataStockOut.AllowUserToOrderColumns = true;
            this.dataStockOut.AllowUserToResizeColumns = false;
            this.dataStockOut.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataStockOut.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataStockOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataStockOut.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(169)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataStockOut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataStockOut.ColumnHeadersHeight = 50;
            this.dataStockOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCheck,
            this.dgvID,
            this.dgvIDStockOut,
            this.dgvConfirmValue,
            this.dgvSupplier,
            this.dgvDate,
            this.dgvTime,
            this.dgvProduct,
            this.dgvQty,
            this.dgvColi,
            this.dgvNettPrice,
            this.dgvTotalPrice,
            this.dgvCause,
            this.dgvInformation,
            this.dgvConfirm,
            this.dgvEdit,
            this.dgvDelete});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataStockOut.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataStockOut.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataStockOut.Location = new System.Drawing.Point(48, 149);
            this.dataStockOut.Name = "dataStockOut";
            this.dataStockOut.RowHeadersVisible = false;
            this.dataStockOut.Size = new System.Drawing.Size(1182, 297);
            this.dataStockOut.TabIndex = 6;
            this.dataStockOut.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataStockOut.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataStockOut.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataStockOut.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataStockOut.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataStockOut.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataStockOut.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataStockOut.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataStockOut.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataStockOut.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataStockOut.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataStockOut.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataStockOut.ThemeStyle.HeaderStyle.Height = 50;
            this.dataStockOut.ThemeStyle.ReadOnly = false;
            this.dataStockOut.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataStockOut.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataStockOut.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataStockOut.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataStockOut.ThemeStyle.RowsStyle.Height = 22;
            this.dataStockOut.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataStockOut.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataStockOut.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataStockOut_CellClick);
            this.dataStockOut.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataStockOut_CellFormatting);
            this.dataStockOut.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataStockOut_CellValueChanged);
            this.dataStockOut.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataStockOut_ColumnHeaderMouseClick);
            // 
            // dgvCheck
            // 
            this.dgvCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvCheck.FillWeight = 50F;
            this.dgvCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dgvCheck.Frozen = true;
            this.dgvCheck.HeaderText = "";
            this.dgvCheck.Name = "dgvCheck";
            this.dgvCheck.Width = 50;
            // 
            // dgvID
            // 
            this.dgvID.FillWeight = 30F;
            this.dgvID.HeaderText = "";
            this.dgvID.Name = "dgvID";
            this.dgvID.Visible = false;
            // 
            // dgvIDStockOut
            // 
            this.dgvIDStockOut.HeaderText = "";
            this.dgvIDStockOut.Name = "dgvIDStockOut";
            this.dgvIDStockOut.Visible = false;
            // 
            // dgvConfirmValue
            // 
            this.dgvConfirmValue.HeaderText = "";
            this.dgvConfirmValue.Name = "dgvConfirmValue";
            this.dgvConfirmValue.Visible = false;
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.HeaderText = "Supplier";
            this.dgvSupplier.Name = "dgvSupplier";
            // 
            // dgvDate
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dgvDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDate.FillWeight = 120F;
            this.dgvDate.HeaderText = "Date";
            this.dgvDate.Name = "dgvDate";
            // 
            // dgvTime
            // 
            this.dgvTime.HeaderText = "Time";
            this.dgvTime.Name = "dgvTime";
            // 
            // dgvProduct
            // 
            this.dgvProduct.HeaderText = "Product";
            this.dgvProduct.Name = "dgvProduct";
            // 
            // dgvQty
            // 
            this.dgvQty.HeaderText = "Qty";
            this.dgvQty.Name = "dgvQty";
            // 
            // dgvColi
            // 
            this.dgvColi.HeaderText = "Coli";
            this.dgvColi.Name = "dgvColi";
            // 
            // dgvNettPrice
            // 
            this.dgvNettPrice.HeaderText = "Nett Price";
            this.dgvNettPrice.Name = "dgvNettPrice";
            // 
            // dgvTotalPrice
            // 
            this.dgvTotalPrice.HeaderText = "Total";
            this.dgvTotalPrice.Name = "dgvTotalPrice";
            // 
            // dgvCause
            // 
            this.dgvCause.HeaderText = "Cause";
            this.dgvCause.Name = "dgvCause";
            // 
            // dgvInformation
            // 
            this.dgvInformation.HeaderText = "Info";
            this.dgvInformation.Name = "dgvInformation";
            // 
            // dgvConfirm
            // 
            this.dgvConfirm.FillWeight = 120F;
            this.dgvConfirm.HeaderText = "Confirmed";
            this.dgvConfirm.Name = "dgvConfirm";
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
            this.dgvDelete.FillWeight = 40F;
            this.dgvDelete.HeaderText = "";
            this.dgvDelete.Image = global::POS_SYSTEM.Properties.Resources.delete;
            this.dgvDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvDelete.MinimumWidth = 50;
            this.dgvDelete.Name = "dgvDelete";
            this.dgvDelete.Width = 50;
            // 
            // frmStockOutView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 520);
            this.Controls.Add(this.dataStockOut);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmStockOutView";
            this.Text = "frmStockOutView";
            this.Load += new System.EventHandler(this.frmStockOutView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataStockOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Elipse elipsTable;
        private Guna.UI2.WinForms.Guna2DataGridView dataStockOut;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIDStockOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvConfirmValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNettPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCause;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInformation;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvConfirm;
        private System.Windows.Forms.DataGridViewImageColumn dgvEdit;
        private System.Windows.Forms.DataGridViewImageColumn dgvDelete;
    }
}