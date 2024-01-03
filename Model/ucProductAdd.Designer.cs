namespace POS_SYSTEM.Model
{
    partial class ucProductAdd
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNameAdd = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.pictProductAdd = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnPlus = new Guna.UI2.WinForms.Guna2Button();
            this.btnMin = new Guna.UI2.WinForms.Guna2Button();
            this.lblStockAdd = new System.Windows.Forms.Label();
            this.lblPriceAdd = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.controlExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.txtQTY = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictProductAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameAdd
            // 
            this.lblNameAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblNameAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameAdd.ForeColor = System.Drawing.Color.Black;
            this.lblNameAdd.Location = new System.Drawing.Point(99, 20);
            this.lblNameAdd.Name = "lblNameAdd";
            this.lblNameAdd.Size = new System.Drawing.Size(143, 49);
            this.lblNameAdd.TabIndex = 3;
            this.lblNameAdd.Text = "NAME";
            this.lblNameAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblS
            // 
            this.lblS.BackColor = System.Drawing.Color.Transparent;
            this.lblS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS.ForeColor = System.Drawing.Color.Black;
            this.lblS.Location = new System.Drawing.Point(99, 69);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(71, 26);
            this.lblS.TabIndex = 4;
            this.lblS.Text = "STOCK :";
            this.lblS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQty
            // 
            this.lblQty.BackColor = System.Drawing.Color.Transparent;
            this.lblQty.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.ForeColor = System.Drawing.Color.Black;
            this.lblQty.Location = new System.Drawing.Point(319, 18);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(40, 26);
            this.lblQty.TabIndex = 8;
            this.lblQty.Text = "QTY";
            this.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictProductAdd
            // 
            this.pictProductAdd.BackColor = System.Drawing.Color.Transparent;
            this.pictProductAdd.Image = global::POS_SYSTEM.Properties.Resources.product1;
            this.pictProductAdd.ImageRotate = 0F;
            this.pictProductAdd.Location = new System.Drawing.Point(17, 23);
            this.pictProductAdd.Name = "pictProductAdd";
            this.pictProductAdd.Size = new System.Drawing.Size(70, 70);
            this.pictProductAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictProductAdd.TabIndex = 2;
            this.pictProductAdd.TabStop = false;
            this.pictProductAdd.UseTransparentBackground = true;
            // 
            // btnPlus
            // 
            this.btnPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlus.Animated = true;
            this.btnPlus.AutoRoundedCorners = true;
            this.btnPlus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(77)))), ((int)(((byte)(166)))));
            this.btnPlus.BorderRadius = 16;
            this.btnPlus.BorderThickness = 2;
            this.btnPlus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(77)))), ((int)(((byte)(166)))));
            this.btnPlus.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(77)))), ((int)(((byte)(166)))));
            this.btnPlus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(77)))), ((int)(((byte)(166)))));
            this.btnPlus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(77)))), ((int)(((byte)(166)))));
            this.btnPlus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.Color.Black;
            this.btnPlus.Image = global::POS_SYSTEM.Properties.Resources.plus;
            this.btnPlus.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPlus.Location = new System.Drawing.Point(372, 46);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(35, 35);
            this.btnPlus.TabIndex = 50;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Animated = true;
            this.btnMin.AutoRoundedCorners = true;
            this.btnMin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(77)))), ((int)(((byte)(166)))));
            this.btnMin.BorderRadius = 16;
            this.btnMin.BorderThickness = 2;
            this.btnMin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(77)))), ((int)(((byte)(166)))));
            this.btnMin.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(77)))), ((int)(((byte)(166)))));
            this.btnMin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(77)))), ((int)(((byte)(166)))));
            this.btnMin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(77)))), ((int)(((byte)(166)))));
            this.btnMin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.Black;
            this.btnMin.Image = global::POS_SYSTEM.Properties.Resources.minus;
            this.btnMin.ImageSize = new System.Drawing.Size(25, 25);
            this.btnMin.Location = new System.Drawing.Point(272, 46);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(35, 35);
            this.btnMin.TabIndex = 51;
            // 
            // lblStockAdd
            // 
            this.lblStockAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblStockAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockAdd.ForeColor = System.Drawing.Color.Black;
            this.lblStockAdd.Location = new System.Drawing.Point(173, 69);
            this.lblStockAdd.Name = "lblStockAdd";
            this.lblStockAdd.Size = new System.Drawing.Size(90, 26);
            this.lblStockAdd.TabIndex = 52;
            this.lblStockAdd.Text = "100000";
            this.lblStockAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPriceAdd
            // 
            this.lblPriceAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblPriceAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceAdd.ForeColor = System.Drawing.Color.Black;
            this.lblPriceAdd.Location = new System.Drawing.Point(347, 85);
            this.lblPriceAdd.Name = "lblPriceAdd";
            this.lblPriceAdd.Size = new System.Drawing.Size(73, 26);
            this.lblPriceAdd.TabIndex = 54;
            this.lblPriceAdd.Text = "100000";
            this.lblPriceAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblT
            // 
            this.lblT.BackColor = System.Drawing.Color.Transparent;
            this.lblT.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT.ForeColor = System.Drawing.Color.Black;
            this.lblT.Location = new System.Drawing.Point(275, 85);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(79, 26);
            this.lblT.TabIndex = 53;
            this.lblT.Text = "TOTAL : RP.";
            this.lblT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // controlExit
            // 
            this.controlExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlExit.BackColor = System.Drawing.Color.Transparent;
            this.controlExit.CustomClick = true;
            this.controlExit.FillColor = System.Drawing.Color.Red;
            this.controlExit.IconColor = System.Drawing.Color.White;
            this.controlExit.Location = new System.Drawing.Point(390, 3);
            this.controlExit.Name = "controlExit";
            this.controlExit.Size = new System.Drawing.Size(25, 25);
            this.controlExit.TabIndex = 55;
            this.controlExit.Click += new System.EventHandler(this.controlExit_Click);
            // 
            // txtQTY
            // 
            this.txtQTY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQTY.DefaultText = "";
            this.txtQTY.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQTY.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQTY.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQTY.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQTY.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQTY.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQTY.ForeColor = System.Drawing.Color.Black;
            this.txtQTY.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQTY.Location = new System.Drawing.Point(311, 45);
            this.txtQTY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQTY.Name = "txtQTY";
            this.txtQTY.PasswordChar = '\0';
            this.txtQTY.PlaceholderText = "100";
            this.txtQTY.SelectedText = "";
            this.txtQTY.Size = new System.Drawing.Size(57, 37);
            this.txtQTY.TabIndex = 56;
            this.txtQTY.TextChanged += new System.EventHandler(this.txtQTY_TextChanged);
            // 
            // ucProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.txtQTY);
            this.Controls.Add(this.controlExit);
            this.Controls.Add(this.lblPriceAdd);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.lblStockAdd);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.lblNameAdd);
            this.Controls.Add(this.pictProductAdd);
            this.Name = "ucProductAdd";
            this.Size = new System.Drawing.Size(420, 120);
            ((System.ComponentModel.ISupportInitialize)(this.pictProductAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pictProductAdd;
        public System.Windows.Forms.Label lblNameAdd;
        public System.Windows.Forms.Label lblS;
        public System.Windows.Forms.Label lblQty;
        public Guna.UI2.WinForms.Guna2Button btnPlus;
        public Guna.UI2.WinForms.Guna2Button btnMin;
        public System.Windows.Forms.Label lblStockAdd;
        public System.Windows.Forms.Label lblPriceAdd;
        public System.Windows.Forms.Label lblT;
        private Guna.UI2.WinForms.Guna2ControlBox controlExit;
        public Guna.UI2.WinForms.Guna2TextBox txtQTY;
    }
}
