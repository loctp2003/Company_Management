namespace QuanLyDuAn.Pages
{
    partial class Page_DanhGiaGD
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
            this.btn_Luu = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel_PhanDG = new System.Windows.Forms.Panel();
            this.btn_ThemDanhGia = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.br_DanhGia = new Bunifu.UI.WinForms.BunifuRating();
            this.label2 = new System.Windows.Forms.Label();
            this.rtx_LoiDanhGia = new System.Windows.Forms.RichTextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel_PhanDG.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Luu
            // 
            this.btn_Luu.AutoSize = true;
            this.btn_Luu.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Luu.FlatAppearance.BorderSize = 0;
            this.btn_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Luu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Luu.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Luu.IconColor = System.Drawing.Color.White;
            this.btn_Luu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Luu.IconSize = 30;
            this.btn_Luu.Location = new System.Drawing.Point(1378, 636);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(152, 50);
            this.btn_Luu.TabIndex = 51;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Location = new System.Drawing.Point(312, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 207);
            this.panel2.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(45, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "Bạn Chưa Có Lời Đánh Giá Nào";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Comments;
            this.iconPictureBox1.IconColor = System.Drawing.Color.DodgerBlue;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox1.IconSize = 72;
            this.iconPictureBox1.Location = new System.Drawing.Point(176, 33);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(77, 72);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel_PhanDG
            // 
            this.panel_PhanDG.AutoScroll = true;
            this.panel_PhanDG.BackColor = System.Drawing.Color.White;
            this.panel_PhanDG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_PhanDG.Controls.Add(this.btn_ThemDanhGia);
            this.panel_PhanDG.Location = new System.Drawing.Point(32, 41);
            this.panel_PhanDG.Name = "panel_PhanDG";
            this.panel_PhanDG.Size = new System.Drawing.Size(381, 645);
            this.panel_PhanDG.TabIndex = 53;
            // 
            // btn_ThemDanhGia
            // 
            this.btn_ThemDanhGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ThemDanhGia.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemDanhGia.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btn_ThemDanhGia.IconColor = System.Drawing.Color.DodgerBlue;
            this.btn_ThemDanhGia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ThemDanhGia.Location = new System.Drawing.Point(0, 0);
            this.btn_ThemDanhGia.Name = "btn_ThemDanhGia";
            this.btn_ThemDanhGia.Size = new System.Drawing.Size(379, 98);
            this.btn_ThemDanhGia.TabIndex = 0;
            this.btn_ThemDanhGia.Text = "Đánh Giá Mới";
            this.btn_ThemDanhGia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ThemDanhGia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ThemDanhGia.UseVisualStyleBackColor = true;
            this.btn_ThemDanhGia.Click += new System.EventHandler(this.btn_ThemDanhGia_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.br_DanhGia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.rtx_LoiDanhGia);
            this.panel1.Location = new System.Drawing.Point(454, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 576);
            this.panel1.TabIndex = 54;
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
            this.br_DanhGia.Location = new System.Drawing.Point(157, 27);
            this.br_DanhGia.Name = "br_DanhGia";
            this.br_DanhGia.OuterRadius = 14F;
            this.br_DanhGia.RatedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.br_DanhGia.RatedFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.br_DanhGia.ReadOnly = false;
            this.br_DanhGia.RightClickToClear = false;
            this.br_DanhGia.Size = new System.Drawing.Size(161, 30);
            this.br_DanhGia.TabIndex = 54;
            this.br_DanhGia.Text = "bunifuRating1";
            this.br_DanhGia.Value = 5;
            this.br_DanhGia.ValueChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuRating.ValueChangedEventArgs>(this.br_DanhGia_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(24, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 31);
            this.label2.TabIndex = 53;
            this.label2.Text = "Đánh Giá:";
            // 
            // rtx_LoiDanhGia
            // 
            this.rtx_LoiDanhGia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtx_LoiDanhGia.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtx_LoiDanhGia.Location = new System.Drawing.Point(0, 80);
            this.rtx_LoiDanhGia.Name = "rtx_LoiDanhGia";
            this.rtx_LoiDanhGia.Size = new System.Drawing.Size(1075, 494);
            this.rtx_LoiDanhGia.TabIndex = 2;
            this.rtx_LoiDanhGia.Text = "";
            this.rtx_LoiDanhGia.TextChanged += new System.EventHandler(this.rtx_LoiDanhGia_TextChanged);
            // 
            // Page_DanhGiaGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_PhanDG);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.panel1);
            this.Name = "Page_DanhGiaGD";
            this.Size = new System.Drawing.Size(1662, 729);
            this.Load += new System.EventHandler(this.Page_DanhGiaGD_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel_PhanDG.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btn_Luu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel_PhanDG;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuRating br_DanhGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtx_LoiDanhGia;
        private FontAwesome.Sharp.IconButton btn_ThemDanhGia;
    }
}
