namespace QuanLyDuAn.Pages
{
    partial class Page_PhanDuAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_PhanDuAn));
            this.lbl_TenDA = new System.Windows.Forms.Label();
            this.pc_Anh = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lbl_TenNQL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pc_Anh)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TenDA
            // 
            this.lbl_TenDA.AutoSize = true;
            this.lbl_TenDA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenDA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_TenDA.Location = new System.Drawing.Point(29, 23);
            this.lbl_TenDA.Name = "lbl_TenDA";
            this.lbl_TenDA.Size = new System.Drawing.Size(111, 28);
            this.lbl_TenDA.TabIndex = 19;
            this.lbl_TenDA.Text = "Tên Dự Án";
            this.lbl_TenDA.Click += new System.EventHandler(this.lbl_MieuTa_Click);
            // 
            // pc_Anh
            // 
            this.pc_Anh.AllowFocused = false;
            this.pc_Anh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pc_Anh.AutoSizeHeight = true;
            this.pc_Anh.BorderRadius = 20;
            this.pc_Anh.Image = ((System.Drawing.Image)(resources.GetObject("pc_Anh.Image")));
            this.pc_Anh.IsCircle = true;
            this.pc_Anh.Location = new System.Drawing.Point(33, 64);
            this.pc_Anh.Name = "pc_Anh";
            this.pc_Anh.Size = new System.Drawing.Size(41, 41);
            this.pc_Anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pc_Anh.TabIndex = 20;
            this.pc_Anh.TabStop = false;
            this.pc_Anh.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // lbl_TenNQL
            // 
            this.lbl_TenNQL.AutoSize = true;
            this.lbl_TenNQL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenNQL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_TenNQL.Location = new System.Drawing.Point(85, 71);
            this.lbl_TenNQL.Name = "lbl_TenNQL";
            this.lbl_TenNQL.Size = new System.Drawing.Size(193, 28);
            this.lbl_TenNQL.TabIndex = 21;
            this.lbl_TenNQL.Text = "Tên Người Quản Lý";
            // 
            // Page_PhanDuAn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_TenNQL);
            this.Controls.Add(this.pc_Anh);
            this.Controls.Add(this.lbl_TenDA);
            this.Name = "Page_PhanDuAn";
            this.Size = new System.Drawing.Size(354, 119);
            this.Load += new System.EventHandler(this.Page_PhanDuAn_Load);
            this.Click += new System.EventHandler(this.Page_PhanDuAn_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pc_Anh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TenDA;
        private Bunifu.UI.WinForms.BunifuPictureBox pc_Anh;
        private System.Windows.Forms.Label lbl_TenNQL;
    }
}
