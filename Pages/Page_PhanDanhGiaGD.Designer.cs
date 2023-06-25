namespace QuanLyDuAn.Pages
{
    partial class Page_PhanDanhGiaGD
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
            this.lbl_Ngay = new System.Windows.Forms.Label();
            this.lbl_Gio = new System.Windows.Forms.Label();
            this.br_DanhGia = new Bunifu.UI.WinForms.BunifuRating();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Ngay
            // 
            this.lbl_Ngay.AutoSize = true;
            this.lbl_Ngay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ngay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Ngay.Location = new System.Drawing.Point(20, 12);
            this.lbl_Ngay.Name = "lbl_Ngay";
            this.lbl_Ngay.Size = new System.Drawing.Size(126, 28);
            this.lbl_Ngay.TabIndex = 31;
            this.lbl_Ngay.Text = "05/03/2023";
            // 
            // lbl_Gio
            // 
            this.lbl_Gio.AutoSize = true;
            this.lbl_Gio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Gio.Location = new System.Drawing.Point(255, 12);
            this.lbl_Gio.Name = "lbl_Gio";
            this.lbl_Gio.Size = new System.Drawing.Size(96, 28);
            this.lbl_Gio.TabIndex = 32;
            this.lbl_Gio.Text = "12:00PM";
            // 
            // br_DanhGia
            // 
            this.br_DanhGia.BackColor = System.Drawing.Color.Transparent;
            this.br_DanhGia.DisabledEmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.br_DanhGia.DisabledRatedFillColor = System.Drawing.Color.DarkGray;
            this.br_DanhGia.EmptyBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.br_DanhGia.EmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.br_DanhGia.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.br_DanhGia.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.br_DanhGia.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.br_DanhGia.InnerRadius = 2F;
            this.br_DanhGia.Location = new System.Drawing.Point(130, 55);
            this.br_DanhGia.Name = "br_DanhGia";
            this.br_DanhGia.OuterRadius = 10F;
            this.br_DanhGia.RatedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.br_DanhGia.RatedFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.br_DanhGia.ReadOnly = true;
            this.br_DanhGia.RightClickToClear = true;
            this.br_DanhGia.Size = new System.Drawing.Size(121, 22);
            this.br_DanhGia.TabIndex = 33;
            this.br_DanhGia.Text = "bunifuRating1";
            this.br_DanhGia.Value = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(20, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 28);
            this.label3.TabIndex = 34;
            this.label3.Text = "Đánh Giá:";
            // 
            // Page_PhanDanhGiaGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.br_DanhGia);
            this.Controls.Add(this.lbl_Gio);
            this.Controls.Add(this.lbl_Ngay);
            this.Name = "Page_PhanDanhGiaGD";
            this.Size = new System.Drawing.Size(379, 98);
            this.Load += new System.EventHandler(this.Page_PhanDanhGiaGD_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Page_PhanDanhGiaGD_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Ngay;
        private System.Windows.Forms.Label lbl_Gio;
        private Bunifu.UI.WinForms.BunifuRating br_DanhGia;
        private System.Windows.Forms.Label label3;
    }
}
