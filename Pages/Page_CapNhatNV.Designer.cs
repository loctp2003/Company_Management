namespace QuanLyDuAn.Pages
{
    partial class Page_CapNhatNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_CapNhatNV));
            this.lbl_TenNV = new Bunifu.UI.WinForms.BunifuLabel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbl_TenNV
            // 
            this.lbl_TenNV.AllowParentOverrides = false;
            this.lbl_TenNV.AutoEllipsis = false;
            this.lbl_TenNV.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_TenNV.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_TenNV.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_TenNV.Location = new System.Drawing.Point(130, 25);
            this.lbl_TenNV.Name = "lbl_TenNV";
            this.lbl_TenNV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_TenNV.Size = new System.Drawing.Size(308, 45);
            this.lbl_TenNV.TabIndex = 52;
            this.lbl_TenNV.Text = "Cập Nhật Nhiệm Vụ";
            this.lbl_TenNV.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_TenNV.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMain.Location = new System.Drawing.Point(130, 100);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1388, 564);
            this.panelMain.TabIndex = 51;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // Page_CapNhatNV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lbl_TenNV);
            this.Controls.Add(this.panelMain);
            this.Name = "Page_CapNhatNV";
            this.Size = new System.Drawing.Size(1662, 729);
            this.Load += new System.EventHandler(this.Page_CapNhatNV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel lbl_TenNV;
        private System.Windows.Forms.Panel panelMain;
    }
}
