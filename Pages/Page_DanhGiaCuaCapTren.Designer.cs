namespace QuanLyDuAn.Pages
{
    partial class Page_DanhGiaCuaCapTren
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_DanhGiaCuaCapTren));
            this.pc_Anh = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lbl_Ten = new System.Windows.Forms.Label();
            this.br_DanhGia = new Bunifu.UI.WinForms.BunifuRating();
            this.lbl_DanhGia = new System.Windows.Forms.Label();
            this.lbl_ThoiGian = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pc_Anh)).BeginInit();
            this.SuspendLayout();
            // 
            // pc_Anh
            // 
            this.pc_Anh.AllowFocused = false;
            this.pc_Anh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pc_Anh.AutoSizeHeight = true;
            this.pc_Anh.BorderRadius = 25;
            this.pc_Anh.Image = ((System.Drawing.Image)(resources.GetObject("pc_Anh.Image")));
            this.pc_Anh.IsCircle = true;
            this.pc_Anh.Location = new System.Drawing.Point(32, 14);
            this.pc_Anh.Name = "pc_Anh";
            this.pc_Anh.Size = new System.Drawing.Size(50, 50);
            this.pc_Anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pc_Anh.TabIndex = 0;
            this.pc_Anh.TabStop = false;
            this.pc_Anh.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // lbl_Ten
            // 
            this.lbl_Ten.AutoSize = true;
            this.lbl_Ten.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Ten.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Ten.Location = new System.Drawing.Point(87, 29);
            this.lbl_Ten.Name = "lbl_Ten";
            this.lbl_Ten.Size = new System.Drawing.Size(103, 20);
            this.lbl_Ten.TabIndex = 28;
            this.lbl_Ten.Text = "Bùi Đức Long";
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
            this.br_DanhGia.Location = new System.Drawing.Point(123, 73);
            this.br_DanhGia.Name = "br_DanhGia";
            this.br_DanhGia.OuterRadius = 10F;
            this.br_DanhGia.RatedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.br_DanhGia.RatedFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.br_DanhGia.ReadOnly = true;
            this.br_DanhGia.RightClickToClear = true;
            this.br_DanhGia.Size = new System.Drawing.Size(121, 22);
            this.br_DanhGia.TabIndex = 29;
            this.br_DanhGia.Text = "bunifuRating1";
            this.br_DanhGia.Value = 2;
            // 
            // lbl_DanhGia
            // 
            this.lbl_DanhGia.AutoSize = true;
            this.lbl_DanhGia.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DanhGia.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DanhGia.ForeColor = System.Drawing.Color.Silver;
            this.lbl_DanhGia.Location = new System.Drawing.Point(29, 73);
            this.lbl_DanhGia.Name = "lbl_DanhGia";
            this.lbl_DanhGia.Size = new System.Drawing.Size(87, 23);
            this.lbl_DanhGia.TabIndex = 30;
            this.lbl_DanhGia.Text = "Đánh giá:";
            // 
            // lbl_ThoiGian
            // 
            this.lbl_ThoiGian.AutoSize = true;
            this.lbl_ThoiGian.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ThoiGian.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThoiGian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_ThoiGian.Location = new System.Drawing.Point(252, 29);
            this.lbl_ThoiGian.Name = "lbl_ThoiGian";
            this.lbl_ThoiGian.Size = new System.Drawing.Size(97, 20);
            this.lbl_ThoiGian.TabIndex = 31;
            this.lbl_ThoiGian.Text = "2 phút trước";
            // 
            // Page_DanhGiaCuaCapTren
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lbl_ThoiGian);
            this.Controls.Add(this.lbl_DanhGia);
            this.Controls.Add(this.br_DanhGia);
            this.Controls.Add(this.lbl_Ten);
            this.Controls.Add(this.pc_Anh);
            this.Name = "Page_DanhGiaCuaCapTren";
            this.Size = new System.Drawing.Size(393, 127);
            this.Load += new System.EventHandler(this.Page_DanhGiaCuaCapTren_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Page_DanhGiaCuaCapTren_MouseClick);
            this.MouseLeave += new System.EventHandler(this.Page_DanhGiaCuaCapTren_MouseLeave);
            this.MouseHover += new System.EventHandler(this.Page_DanhGiaCuaCapTren_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pc_Anh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox pc_Anh;
        private System.Windows.Forms.Label lbl_Ten;
        private Bunifu.UI.WinForms.BunifuRating br_DanhGia;
        private System.Windows.Forms.Label lbl_DanhGia;
        private System.Windows.Forms.Label lbl_ThoiGian;
    }
}
