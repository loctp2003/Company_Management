namespace QuanLyDuAn.Pages
{
    partial class Page_PhanCongNhiemVu
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
            this.panel_DuAn = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_DuAn
            // 
            this.panel_DuAn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_DuAn.AutoScroll = true;
            this.panel_DuAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_DuAn.Location = new System.Drawing.Point(30, 36);
            this.panel_DuAn.Name = "panel_DuAn";
            this.panel_DuAn.Size = new System.Drawing.Size(356, 721);
            this.panel_DuAn.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Location = new System.Drawing.Point(413, 36);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1218, 721);
            this.panelMain.TabIndex = 1;
            // 
            // Page_PhanCongNhiemVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel_DuAn);
            this.Name = "Page_PhanCongNhiemVu";
            this.Size = new System.Drawing.Size(1662, 793);
            this.Load += new System.EventHandler(this.Page_PhanCongNhiemVu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_DuAn;
        private System.Windows.Forms.Panel panelMain;
    }
}
