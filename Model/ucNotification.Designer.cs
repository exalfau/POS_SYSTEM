namespace POS_SYSTEM.Model
{
    partial class ucNotification
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
            this.panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pictNotif = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictNotif)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.pictNotif);
            this.panel.Controls.Add(this.lblInfo);
            this.panel.Controls.Add(this.lblName);
            this.panel.FillColor = System.Drawing.Color.White;
            this.panel.Location = new System.Drawing.Point(3, 3);
            this.panel.Name = "panel";
            this.panel.ShadowColor = System.Drawing.Color.Black;
            this.panel.Size = new System.Drawing.Size(423, 124);
            this.panel.TabIndex = 1;
            this.panel.Click += new System.EventHandler(this.panel_Click);
            // 
            // pictNotif
            // 
            this.pictNotif.BackColor = System.Drawing.Color.Transparent;
            this.pictNotif.Image = global::POS_SYSTEM.Properties.Resources.product1;
            this.pictNotif.ImageRotate = 0F;
            this.pictNotif.Location = new System.Drawing.Point(14, 12);
            this.pictNotif.Name = "pictNotif";
            this.pictNotif.Size = new System.Drawing.Size(100, 100);
            this.pictNotif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictNotif.TabIndex = 3;
            this.pictNotif.TabStop = false;
            this.pictNotif.UseTransparentBackground = true;
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Black;
            this.lblInfo.Location = new System.Drawing.Point(137, 58);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(260, 43);
            this.lblInfo.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(137, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(260, 49);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "NAME";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panel);
            this.Name = "ucNotification";
            this.Size = new System.Drawing.Size(429, 130);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictNotif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel panel;
        public System.Windows.Forms.Label lblInfo;
        public System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2PictureBox pictNotif;
    }
}
