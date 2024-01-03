namespace POS_SYSTEM.View
{
    partial class frmStockInView
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
            this.dataStockIn = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvConfirmValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNettPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInformation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvConfirm = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataStockIn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Text = "Stock In";
            // 
            // elipsTable
            // 
            this.elipsTable.BorderRadius = 30;
            this.elipsTable.TargetControl = this.dataStockIn;
            // 
            // dataStockIn
            // 
            this.dataStockIn.AllowUserToAddRows = false;
            this.dataStockIn.AllowUserToDeleteRows = false;
            this.dataStockIn.AllowUserToOrderColumns = true;
            this.dataStockIn.AllowUserToResizeColumns = false;
            this.dataStockIn.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataStockIn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataStockIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataStockIn.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(169)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataStockIn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataStockIn.ColumnHeadersHeight = 50;
            this.dataStockIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCheck,
            this.dgvConfirmValue,
            this.dgvID,
            this.dgvSupplier,
            this.dgvDate,
            this.dgvTime,
            this.dgvProduct,
            this.dgvQty,
            this.dgvColi,
            this.dgvNettPrice,
            this.dgvTotalPrice,
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
            this.dataStockIn.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataStockIn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataStockIn.Location = new System.Drawing.Point(48, 149);
            this.dataStockIn.Name = "dataStockIn";
            this.dataStockIn.RowHeadersVisible = false;
            this.dataStockIn.Size = new System.Drawing.Size(1182, 297);
            this.dataStockIn.TabIndex = 5;
            this.dataStockIn.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataStockIn.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataStockIn.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataStockIn.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataStockIn.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataStockIn.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataStockIn.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataStockIn.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataStockIn.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataStockIn.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataStockIn.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataStockIn.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataStockIn.ThemeStyle.HeaderStyle.Height = 50;
            this.dataStockIn.ThemeStyle.ReadOnly = false;
            this.dataStockIn.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataStockIn.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataStockIn.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataStockIn.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataStockIn.ThemeStyle.RowsStyle.Height = 22;
            this.dataStockIn.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataStockIn.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataStockIn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataStockIn_CellClick);
            this.dataStockIn.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataStockIn_CellFormatting);
            this.dataStockIn.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataStockIn_CellValueChanged);
            this.dataStockIn.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataStockIn_ColumnHeaderMouseClick);
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
            // dgvConfirmValue
            // 
            this.dgvConfirmValue.HeaderText = "";
            this.dgvConfirmValue.Name = "dgvConfirmValue";
            this.dgvConfirmValue.Visible = false;
            // 
            // dgvID
            // 
            this.dgvID.FillWeight = 30F;
            this.dgvID.HeaderText = "";
            this.dgvID.Name = "dgvID";
            this.dgvID.Visible = false;
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
            // frmStockInView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 520);
            this.Controls.Add(this.dataStockIn);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmStockInView";
            this.Text = "frmStockInView";
            this.Load += new System.EventHandler(this.frmStockInView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataStockIn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Elipse elipsTable;
        private Guna.UI2.WinForms.Guna2DataGridView dataStockIn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvConfirmValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNettPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInformation;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvConfirm;
        private System.Windows.Forms.DataGridViewImageColumn dgvEdit;
        private System.Windows.Forms.DataGridViewImageColumn dgvDelete;
    }
}