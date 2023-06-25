namespace QuanLyDuAn.Pages
{
    partial class Page_TaoNhiemVuDuAn
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.btn_Luu = new FontAwesome.Sharp.IconButton();
            this.btn_Huy = new FontAwesome.Sharp.IconButton();
            this.panelEllipsis = new System.Windows.Forms.Panel();
            this.btn_Xoa = new FontAwesome.Sharp.IconButton();
            this.btn_CapNhat = new FontAwesome.Sharp.IconButton();
            this.bs_Ellipsis = new Bunifu.UI.WinForms.BunifuShapes();
            this.panelMain.SuspendLayout();
            this.panelEllipsis.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.Controls.Add(this.panelEllipsis);
            this.panelMain.Controls.Add(this.bs_Ellipsis);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(790, 707);
            this.panelMain.TabIndex = 0;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint_1);
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
            this.btn_Luu.Location = new System.Drawing.Point(580, 745);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(130, 49);
            this.btn_Luu.TabIndex = 75;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.AutoSize = true;
            this.btn_Huy.BackColor = System.Drawing.Color.White;
            this.btn_Huy.FlatAppearance.BorderSize = 2;
            this.btn_Huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Huy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_Huy.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Huy.IconColor = System.Drawing.Color.RoyalBlue;
            this.btn_Huy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Huy.IconSize = 30;
            this.btn_Huy.Location = new System.Drawing.Point(435, 745);
            this.btn_Huy.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(130, 49);
            this.btn_Huy.TabIndex = 74;
            this.btn_Huy.Text = "Quay Lại";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // panelEllipsis
            // 
            this.panelEllipsis.BackColor = System.Drawing.Color.Transparent;
            this.panelEllipsis.Controls.Add(this.btn_Xoa);
            this.panelEllipsis.Controls.Add(this.btn_CapNhat);
            this.panelEllipsis.Location = new System.Drawing.Point(545, 205);
            this.panelEllipsis.Name = "panelEllipsis";
            this.panelEllipsis.Size = new System.Drawing.Size(193, 117);
            this.panelEllipsis.TabIndex = 34;
            this.panelEllipsis.Visible = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Xoa.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btn_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btn_Xoa.IconColor = System.Drawing.Color.White;
            this.btn_Xoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Xoa.IconSize = 30;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(0, 55);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(193, 62);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_CapNhat.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btn_CapNhat.FlatAppearance.BorderSize = 0;
            this.btn_CapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CapNhat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.ForeColor = System.Drawing.Color.White;
            this.btn_CapNhat.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btn_CapNhat.IconColor = System.Drawing.Color.White;
            this.btn_CapNhat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_CapNhat.IconSize = 30;
            this.btn_CapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CapNhat.Location = new System.Drawing.Point(0, 0);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(0);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(193, 55);
            this.btn_CapNhat.TabIndex = 0;
            this.btn_CapNhat.Text = "Cập Nhật";
            this.btn_CapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CapNhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            // 
            // bs_Ellipsis
            // 
            this.bs_Ellipsis.Angle = 150F;
            this.bs_Ellipsis.BackColor = System.Drawing.Color.Transparent;
            this.bs_Ellipsis.BorderColor = System.Drawing.Color.Transparent;
            this.bs_Ellipsis.BorderThickness = 0;
            this.bs_Ellipsis.FillColor = System.Drawing.Color.DodgerBlue;
            this.bs_Ellipsis.FillShape = true;
            this.bs_Ellipsis.Location = new System.Drawing.Point(685, 190);
            this.bs_Ellipsis.Name = "bs_Ellipsis";
            this.bs_Ellipsis.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Polygon;
            this.bs_Ellipsis.Sides = 3;
            this.bs_Ellipsis.Size = new System.Drawing.Size(25, 26);
            this.bs_Ellipsis.TabIndex = 35;
            this.bs_Ellipsis.Text = "bunifuShapes1";
            this.bs_Ellipsis.Visible = false;
            // 
            // Page_TaoNhiemVuDuAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.panelMain);
            this.Name = "Page_TaoNhiemVuDuAn";
            this.Size = new System.Drawing.Size(790, 828);
            this.Load += new System.EventHandler(this.Page_TaoNhiemVuDuAn_Load);
            this.panelMain.ResumeLayout(false);
            this.panelEllipsis.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private FontAwesome.Sharp.IconButton btn_Luu;
        private FontAwesome.Sharp.IconButton btn_Huy;
        private System.Windows.Forms.Panel panelEllipsis;
        private FontAwesome.Sharp.IconButton btn_Xoa;
        private FontAwesome.Sharp.IconButton btn_CapNhat;
        private Bunifu.UI.WinForms.BunifuShapes bs_Ellipsis;
    }
}
