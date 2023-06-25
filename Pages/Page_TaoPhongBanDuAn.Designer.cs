namespace QuanLyDuAn.Pages
{
    partial class Page_TaoPhongBanDuAn
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_CountSelected = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_TiepTuc = new FontAwesome.Sharp.IconButton();
            this.btn_QuayLai = new FontAwesome.Sharp.IconButton();
            this.btn_Them = new FontAwesome.Sharp.IconButton();
            this.btn_Huy = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_CountSelected);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 75);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_CountSelected
            // 
            this.lbl_CountSelected.AutoSize = true;
            this.lbl_CountSelected.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.lbl_CountSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_CountSelected.Location = new System.Drawing.Point(29, 15);
            this.lbl_CountSelected.Name = "lbl_CountSelected";
            this.lbl_CountSelected.Size = new System.Drawing.Size(38, 45);
            this.lbl_CountSelected.TabIndex = 32;
            this.lbl_CountSelected.Text = "0";
            this.lbl_CountSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_CountSelected.Click += new System.EventHandler(this.lbl_CountSelected_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(70, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 31);
            this.label1.TabIndex = 31;
            this.label1.Text = "Selected";
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Location = new System.Drawing.Point(0, 75);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(790, 651);
            this.panelMain.TabIndex = 2;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 623);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 28);
            this.panel2.TabIndex = 0;
            // 
            // btn_TiepTuc
            // 
            this.btn_TiepTuc.AutoSize = true;
            this.btn_TiepTuc.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_TiepTuc.FlatAppearance.BorderSize = 0;
            this.btn_TiepTuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TiepTuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TiepTuc.ForeColor = System.Drawing.Color.Transparent;
            this.btn_TiepTuc.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_TiepTuc.IconColor = System.Drawing.Color.White;
            this.btn_TiepTuc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_TiepTuc.IconSize = 30;
            this.btn_TiepTuc.Location = new System.Drawing.Point(580, 745);
            this.btn_TiepTuc.Margin = new System.Windows.Forms.Padding(0);
            this.btn_TiepTuc.Name = "btn_TiepTuc";
            this.btn_TiepTuc.Size = new System.Drawing.Size(130, 49);
            this.btn_TiepTuc.TabIndex = 73;
            this.btn_TiepTuc.Text = "Tiếp Tục";
            this.btn_TiepTuc.UseVisualStyleBackColor = false;
            this.btn_TiepTuc.Click += new System.EventHandler(this.btn_TiepTuc_Click);
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
            this.btn_QuayLai.Location = new System.Drawing.Point(435, 745);
            this.btn_QuayLai.Margin = new System.Windows.Forms.Padding(0);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(130, 49);
            this.btn_QuayLai.TabIndex = 72;
            this.btn_QuayLai.Text = "Quay Lại";
            this.btn_QuayLai.UseVisualStyleBackColor = false;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.AutoSize = true;
            this.btn_Them.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Them.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Them.IconColor = System.Drawing.Color.White;
            this.btn_Them.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Them.IconSize = 30;
            this.btn_Them.Location = new System.Drawing.Point(283, 745);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(130, 49);
            this.btn_Them.TabIndex = 74;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
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
            this.btn_Huy.Location = new System.Drawing.Point(138, 745);
            this.btn_Huy.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(130, 49);
            this.btn_Huy.TabIndex = 75;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // Page_TaoPhongBanDuAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_TiepTuc);
            this.Controls.Add(this.btn_QuayLai);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMain);
            this.Name = "Page_TaoPhongBanDuAn";
            this.Size = new System.Drawing.Size(790, 828);
            this.Load += new System.EventHandler(this.Page_TaoPhongBanDuAn_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_CountSelected;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btn_TiepTuc;
        private FontAwesome.Sharp.IconButton btn_QuayLai;
        private FontAwesome.Sharp.IconButton btn_Them;
        private FontAwesome.Sharp.IconButton btn_Huy;
    }
}
