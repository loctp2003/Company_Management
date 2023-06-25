namespace QuanLyDuAn.Forms
{
    partial class Frm_ThemNhiemVuNho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ThemNhiemVuNho));
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btn_Exit = new FontAwesome.Sharp.IconButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btn_TaoNhiemVu = new FontAwesome.Sharp.IconButton();
            this.btn_QuayLai = new FontAwesome.Sharp.IconButton();
            this.btn_Luu = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.bunifuLabel1);
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.btn_Exit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 60);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(57, 10);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(181, 37);
            this.bunifuLabel1.TabIndex = 2;
            this.bunifuLabel1.Text = "Tạo Nhiệm Vụ";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(13, 5);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(49, 40);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "\r\n";
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btn_Exit.IconColor = System.Drawing.Color.White;
            this.btn_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Exit.IconSize = 30;
            this.btn_Exit.Location = new System.Drawing.Point(696, 5);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(49, 40);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "\r\n";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.Location = new System.Drawing.Point(0, 140);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(750, 609);
            this.panelMain.TabIndex = 4;
            // 
            // btn_TaoNhiemVu
            // 
            this.btn_TaoNhiemVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_TaoNhiemVu.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoNhiemVu.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btn_TaoNhiemVu.IconColor = System.Drawing.Color.DodgerBlue;
            this.btn_TaoNhiemVu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_TaoNhiemVu.Location = new System.Drawing.Point(0, 60);
            this.btn_TaoNhiemVu.Name = "btn_TaoNhiemVu";
            this.btn_TaoNhiemVu.Size = new System.Drawing.Size(750, 82);
            this.btn_TaoNhiemVu.TabIndex = 56;
            this.btn_TaoNhiemVu.Text = "Tạo Nhiệm Vụ";
            this.btn_TaoNhiemVu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TaoNhiemVu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TaoNhiemVu.UseVisualStyleBackColor = true;
            this.btn_TaoNhiemVu.Click += new System.EventHandler(this.btn_TaoNhiemVu_Click);
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.AutoSize = true;
            this.btn_QuayLai.BackColor = System.Drawing.Color.White;
            this.btn_QuayLai.FlatAppearance.BorderSize = 2;
            this.btn_QuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuayLai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuayLai.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_QuayLai.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_QuayLai.IconColor = System.Drawing.Color.RoyalBlue;
            this.btn_QuayLai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_QuayLai.IconSize = 30;
            this.btn_QuayLai.Location = new System.Drawing.Point(414, 813);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(130, 49);
            this.btn_QuayLai.TabIndex = 55;
            this.btn_QuayLai.Text = "Quay Lại";
            this.btn_QuayLai.UseVisualStyleBackColor = false;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
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
            this.btn_Luu.Location = new System.Drawing.Point(560, 813);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(130, 49);
            this.btn_Luu.TabIndex = 54;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // Frm_ThemNhiemVuNho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 920);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_QuayLai);
            this.Controls.Add(this.btn_TaoNhiemVu);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ThemNhiemVuNho";
            this.Text = "Frm_ThemNhiemVuNho";
            this.Load += new System.EventHandler(this.Frm_ThemNhiemVuNho_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btn_Exit;
        private System.Windows.Forms.Panel panelMain;
        private FontAwesome.Sharp.IconButton btn_QuayLai;
        private FontAwesome.Sharp.IconButton btn_Luu;
        private FontAwesome.Sharp.IconButton btn_TaoNhiemVu;
    }
}