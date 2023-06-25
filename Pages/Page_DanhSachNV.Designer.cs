namespace QuanLyDuAn.Pages
{
    partial class Page_DanhSachNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_DanhSachNV));
            this.panelMain = new System.Windows.Forms.Panel();
            this.btn_Them = new FontAwesome.Sharp.IconButton();
            this.lbl_TenNV = new Bunifu.UI.WinForms.BunifuLabel();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMain.Location = new System.Drawing.Point(130, 100);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1388, 564);
            this.panelMain.TabIndex = 0;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btn_Them.IconColor = System.Drawing.Color.Gray;
            this.btn_Them.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Them.Location = new System.Drawing.Point(1458, 25);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(60, 60);
            this.btn_Them.TabIndex = 34;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
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
            this.lbl_TenNV.Size = new System.Drawing.Size(327, 45);
            this.lbl_TenNV.TabIndex = 50;
            this.lbl_TenNV.Text = "Danh Sách Nhiệm Vụ";
            this.lbl_TenNV.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_TenNV.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Page_DanhSachNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_TenNV);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.panelMain);
            this.Name = "Page_DanhSachNV";
            this.Size = new System.Drawing.Size(1662, 729);
            this.Load += new System.EventHandler(this.Page_DanhSachNV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private FontAwesome.Sharp.IconButton btn_Them;
        private Bunifu.UI.WinForms.BunifuLabel lbl_TenNV;
    }
}
