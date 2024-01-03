namespace POS_SYSTEM.View
{
    partial class frmProductView
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
            this.dataProduct = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNettPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMargin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInformation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Text = "Product";
            // 
            // elipsTable
            // 
            this.elipsTable.BorderRadius = 30;
            this.elipsTable.TargetControl = this.dataProduct;
            // 
            // dataProduct
            // 
            this.dataProduct.AllowUserToAddRows = false;
            this.dataProduct.AllowUserToDeleteRows = false;
            this.dataProduct.AllowUserToOrderColumns = true;
            this.dataProduct.AllowUserToResizeColumns = false;
            this.dataProduct.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(169)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataProduct.ColumnHeadersHeight = 50;
            this.dataProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCheck,
            this.dgvID,
            this.dgvCode,
            this.dgvName,
            this.dgvUnit,
            this.dgvCategory,
            this.dgvSupplier,
            this.dgvQty,
            this.dgvColi,
            this.dgvNettPrice,
            this.dgvMargin,
            this.dgvTax,
            this.dgvDiscount,
            this.dgvSellPrice,
            this.dgvInformation,
            this.dgvEdit,
            this.dgvDelete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataProduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataProduct.Location = new System.Drawing.Point(48, 149);
            this.dataProduct.Name = "dataProduct";
            this.dataProduct.RowHeadersVisible = false;
            this.dataProduct.Size = new System.Drawing.Size(1182, 297);
            this.dataProduct.TabIndex = 6;
            this.dataProduct.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataProduct.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataProduct.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataProduct.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataProduct.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataProduct.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataProduct.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataProduct.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataProduct.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataProduct.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataProduct.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataProduct.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataProduct.ThemeStyle.HeaderStyle.Height = 50;
            this.dataProduct.ThemeStyle.ReadOnly = false;
            this.dataProduct.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataProduct.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataProduct.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataProduct.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataProduct.ThemeStyle.RowsStyle.Height = 22;
            this.dataProduct.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataProduct.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProduct_CellClick);
            this.dataProduct.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProduct_CellValueChanged);
            this.dataProduct.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataProduct_ColumnHeaderMouseClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 30F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::POS_SYSTEM.Properties.Resources.edit;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 50;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.FillWeight = 40F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::POS_SYSTEM.Properties.Resources.delete;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 50;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 50;
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
            this.dgvID.FillWeight = 30F;
            this.dgvID.HeaderText = "";
            this.dgvID.Name = "dgvID";
            this.dgvID.Visible = false;
            // 
            // dgvCode
            // 
            this.dgvCode.HeaderText = "Code";
            this.dgvCode.Name = "dgvCode";
            // 
            // dgvName
            // 
            this.dgvName.HeaderText = "Name";
            this.dgvName.Name = "dgvName";
            // 
            // dgvUnit
            // 
            this.dgvUnit.FillWeight = 50F;
            this.dgvUnit.HeaderText = "Unit";
            this.dgvUnit.Name = "dgvUnit";
            // 
            // dgvCategory
            // 
            this.dgvCategory.FillWeight = 120F;
            this.dgvCategory.HeaderText = "Category";
            this.dgvCategory.Name = "dgvCategory";
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.FillWeight = 120F;
            this.dgvSupplier.HeaderText = "Supplier";
            this.dgvSupplier.Name = "dgvSupplier";
            // 
            // dgvQty
            // 
            this.dgvQty.FillWeight = 50F;
            this.dgvQty.HeaderText = "Qty";
            this.dgvQty.Name = "dgvQty";
            // 
            // dgvColi
            // 
            this.dgvColi.FillWeight = 50F;
            this.dgvColi.HeaderText = "Coli";
            this.dgvColi.Name = "dgvColi";
            // 
            // dgvNettPrice
            // 
            this.dgvNettPrice.FillWeight = 130F;
            this.dgvNettPrice.HeaderText = "Nett Price";
            this.dgvNettPrice.Name = "dgvNettPrice";
            // 
            // dgvMargin
            // 
            this.dgvMargin.FillWeight = 70F;
            this.dgvMargin.HeaderText = "Margin";
            this.dgvMargin.Name = "dgvMargin";
            // 
            // dgvTax
            // 
            this.dgvTax.FillWeight = 70F;
            this.dgvTax.HeaderText = "Tax";
            this.dgvTax.Name = "dgvTax";
            // 
            // dgvDiscount
            // 
            this.dgvDiscount.FillWeight = 80F;
            this.dgvDiscount.HeaderText = "Discount";
            this.dgvDiscount.Name = "dgvDiscount";
            // 
            // dgvSellPrice
            // 
            this.dgvSellPrice.FillWeight = 130F;
            this.dgvSellPrice.HeaderText = "Sell Price";
            this.dgvSellPrice.Name = "dgvSellPrice";
            // 
            // dgvInformation
            // 
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
            this.dgvDelete.FillWeight = 40F;
            this.dgvDelete.HeaderText = "";
            this.dgvDelete.Image = global::POS_SYSTEM.Properties.Resources.delete;
            this.dgvDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvDelete.MinimumWidth = 50;
            this.dgvDelete.Name = "dgvDelete";
            this.dgvDelete.Width = 50;
            // 
            // frmProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 520);
            this.Controls.Add(this.dataProduct);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmProductView";
            this.Text = "frmProductView";
            this.Load += new System.EventHandler(this.frmProductView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Elipse elipsTable;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private Guna.UI2.WinForms.Guna2DataGridView dataProduct;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNettPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMargin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInformation;
        private System.Windows.Forms.DataGridViewImageColumn dgvEdit;
        private System.Windows.Forms.DataGridViewImageColumn dgvDelete;
    }
}