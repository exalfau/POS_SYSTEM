namespace POS_SYSTEM
{
    partial class reportViewer
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
            this.panelControl = new Guna.UI2.WinForms.Guna2Panel();
            this.controlMin = new Guna.UI2.WinForms.Guna2ControlBox();
            this.controlExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(200)))), ((int)(((byte)(248)))));
            this.panelControl.Controls.Add(this.controlMin);
            this.panelControl.Controls.Add(this.controlExit);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(825, 40);
            this.panelControl.TabIndex = 1;
            // 
            // controlMin
            // 
            this.controlMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlMin.BackColor = System.Drawing.Color.Transparent;
            this.controlMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.controlMin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(77)))), ((int)(((byte)(166)))));
            this.controlMin.IconColor = System.Drawing.Color.White;
            this.controlMin.Location = new System.Drawing.Point(723, 5);
            this.controlMin.Name = "controlMin";
            this.controlMin.Size = new System.Drawing.Size(45, 30);
            this.controlMin.TabIndex = 14;
            // 
            // controlExit
            // 
            this.controlExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlExit.BackColor = System.Drawing.Color.Transparent;
            this.controlExit.FillColor = System.Drawing.Color.Red;
            this.controlExit.IconColor = System.Drawing.Color.White;
            this.controlExit.Location = new System.Drawing.Point(774, 5);
            this.controlExit.Name = "controlExit";
            this.controlExit.Size = new System.Drawing.Size(45, 30);
            this.controlExit.TabIndex = 13;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 40);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowCopyButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.ShowRefreshButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(825, 437);
            this.crystalReportViewer1.TabIndex = 2;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // reportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 477);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panelControl);
            this.Name = "reportViewer";
            this.Text = "reportViewr";
            this.Load += new System.EventHandler(this.reportViewr_Load);
            this.panelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelControl;
        private Guna.UI2.WinForms.Guna2ControlBox controlMin;
        private Guna.UI2.WinForms.Guna2ControlBox controlExit;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}