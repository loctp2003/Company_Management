namespace QuanLyDuAn.Pages
{
    partial class Page_DanhGiaNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_DanhGiaNV));
            this.panel_NguoiDanhGia = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel_TextDanhGia = new System.Windows.Forms.Panel();
            this.rtb_DanhGia = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_DanhGia = new System.Windows.Forms.Label();
            this.br_DanhGia = new Bunifu.UI.WinForms.BunifuRating();
            this.lbl_CapTren = new System.Windows.Forms.Label();
            this.pc_Anh = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.panelMain.SuspendLayout();
            this.panel_TextDanhGia.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_Anh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_NguoiDanhGia
            // 
            this.panel_NguoiDanhGia.AutoScroll = true;
            this.panel_NguoiDanhGia.AutoScrollMinSize = new System.Drawing.Size(0, 2);
            this.panel_NguoiDanhGia.BackColor = System.Drawing.Color.White;
            this.panel_NguoiDanhGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_NguoiDanhGia.Location = new System.Drawing.Point(26, 38);
            this.panel_NguoiDanhGia.Name = "panel_NguoiDanhGia";
            this.panel_NguoiDanhGia.Size = new System.Drawing.Size(395, 656);
            this.panel_NguoiDanhGia.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panel_TextDanhGia);
            this.panelMain.Controls.Add(this.panel3);
            this.panelMain.Location = new System.Drawing.Point(449, 38);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1154, 656);
            this.panelMain.TabIndex = 1;
            // 
            // panel_TextDanhGia
            // 
            this.panel_TextDanhGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_TextDanhGia.Controls.Add(this.rtb_DanhGia);
            this.panel_TextDanhGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_TextDanhGia.Location = new System.Drawing.Point(0, 85);
            this.panel_TextDanhGia.Name = "panel_TextDanhGia";
            this.panel_TextDanhGia.Size = new System.Drawing.Size(1154, 571);
            this.panel_TextDanhGia.TabIndex = 1;
            // 
            // rtb_DanhGia
            // 
            this.rtb_DanhGia.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_DanhGia.Location = new System.Drawing.Point(23, 30);
            this.rtb_DanhGia.Name = "rtb_DanhGia";
            this.rtb_DanhGia.Size = new System.Drawing.Size(1106, 513);
            this.rtb_DanhGia.TabIndex = 0;
            this.rtb_DanhGia.Text = "";
            this.rtb_DanhGia.TextChanged += new System.EventHandler(this.rtb_DanhGia_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbl_DanhGia);
            this.panel3.Controls.Add(this.br_DanhGia);
            this.panel3.Controls.Add(this.lbl_CapTren);
            this.panel3.Controls.Add(this.pc_Anh);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1154, 85);
            this.panel3.TabIndex = 0;
            // 
            // lbl_DanhGia
            // 
            this.lbl_DanhGia.AutoSize = true;
            this.lbl_DanhGia.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DanhGia.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DanhGia.ForeColor = System.Drawing.Color.Silver;
            this.lbl_DanhGia.Location = new System.Drawing.Point(386, 31);
            this.lbl_DanhGia.Name = "lbl_DanhGia";
            this.lbl_DanhGia.Size = new System.Drawing.Size(87, 23);
            this.lbl_DanhGia.TabIndex = 31;
            this.lbl_DanhGia.Text = "Đánh giá:";
            // 
            // br_DanhGia
            // 
            this.br_DanhGia.BackColor = System.Drawing.Color.Transparent;
            this.br_DanhGia.DisabledEmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.br_DanhGia.DisabledRatedFillColor = System.Drawing.Color.DarkGray;
            this.br_DanhGia.EmptyBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.br_DanhGia.EmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.br_DanhGia.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.br_DanhGia.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.br_DanhGia.InnerRadius = 2F;
            this.br_DanhGia.Location = new System.Drawing.Point(479, 31);
            this.br_DanhGia.Name = "br_DanhGia";
            this.br_DanhGia.OuterRadius = 10F;
            this.br_DanhGia.RatedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.br_DanhGia.RatedFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.br_DanhGia.ReadOnly = false;
            this.br_DanhGia.RightClickToClear = true;
            this.br_DanhGia.Size = new System.Drawing.Size(121, 22);
            this.br_DanhGia.TabIndex = 30;
            this.br_DanhGia.Text = "bunifuRating1";
            this.br_DanhGia.Value = 2;
            // 
            // lbl_CapTren
            // 
            this.lbl_CapTren.AutoSize = true;
            this.lbl_CapTren.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CapTren.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CapTren.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_CapTren.Location = new System.Drawing.Point(87, 24);
            this.lbl_CapTren.Name = "lbl_CapTren";
            this.lbl_CapTren.Size = new System.Drawing.Size(51, 31);
            this.lbl_CapTren.TabIndex = 29;
            this.lbl_CapTren.Text = "Tên";
            // 
            // pc_Anh
            // 
            this.pc_Anh.AllowFocused = false;
            this.pc_Anh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pc_Anh.AutoSizeHeight = true;
            this.pc_Anh.BorderRadius = 24;
            this.pc_Anh.Image = ((System.Drawing.Image)(resources.GetObject("pc_Anh.Image")));
            this.pc_Anh.IsCircle = true;
            this.pc_Anh.Location = new System.Drawing.Point(23, 18);
            this.pc_Anh.Name = "pc_Anh";
            this.pc_Anh.Size = new System.Drawing.Size(49, 49);
            this.pc_Anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pc_Anh.TabIndex = 0;
            this.pc_Anh.TabStop = false;
            this.pc_Anh.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // Page_DanhGiaNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel_NguoiDanhGia);
            this.Name = "Page_DanhGiaNV";
            this.Size = new System.Drawing.Size(1662, 729);
            this.Load += new System.EventHandler(this.Page_DanhGia_Load);
            this.panelMain.ResumeLayout(false);
            this.panel_TextDanhGia.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_Anh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_NguoiDanhGia;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel_TextDanhGia;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.UI.WinForms.BunifuPictureBox pc_Anh;
        private System.Windows.Forms.Label lbl_CapTren;
        private Bunifu.UI.WinForms.BunifuRating br_DanhGia;
        private System.Windows.Forms.RichTextBox rtb_DanhGia;
        private System.Windows.Forms.Label lbl_DanhGia;
    }
}
