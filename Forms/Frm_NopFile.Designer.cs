namespace QuanLyDuAn.Forms
{
    partial class Frm_NopFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NopFile));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btn_Exit = new FontAwesome.Sharp.IconButton();
            this.btn_XoaTatCa = new FontAwesome.Sharp.IconButton();
            this.btn_MoFile = new FontAwesome.Sharp.IconButton();
            this.btn_Luu = new FontAwesome.Sharp.IconButton();
            this.panelFile = new System.Windows.Forms.Panel();
            this.panel_KeoTha = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel1.SuspendLayout();
            this.panelFile.SuspendLayout();
            this.panel_KeoTha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.bunifuLabel1);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1279, 59);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
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
            this.btn_Exit.Location = new System.Drawing.Point(1219, 5);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(55, 51);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "\r\n";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_XoaTatCa
            // 
            this.btn_XoaTatCa.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_XoaTatCa.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btn_XoaTatCa.FlatAppearance.BorderSize = 0;
            this.btn_XoaTatCa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaTatCa.ForeColor = System.Drawing.Color.White;
            this.btn_XoaTatCa.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btn_XoaTatCa.IconColor = System.Drawing.Color.White;
            this.btn_XoaTatCa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_XoaTatCa.IconSize = 35;
            this.btn_XoaTatCa.Location = new System.Drawing.Point(53, 189);
            this.btn_XoaTatCa.Margin = new System.Windows.Forms.Padding(0);
            this.btn_XoaTatCa.Name = "btn_XoaTatCa";
            this.btn_XoaTatCa.Size = new System.Drawing.Size(65, 65);
            this.btn_XoaTatCa.TabIndex = 9;
            this.btn_XoaTatCa.UseVisualStyleBackColor = false;
            this.btn_XoaTatCa.Click += new System.EventHandler(this.btn_XoaTatCa_Click);
            // 
            // btn_MoFile
            // 
            this.btn_MoFile.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_MoFile.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btn_MoFile.FlatAppearance.BorderSize = 0;
            this.btn_MoFile.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MoFile.ForeColor = System.Drawing.Color.White;
            this.btn_MoFile.IconChar = FontAwesome.Sharp.IconChar.FileArrowUp;
            this.btn_MoFile.IconColor = System.Drawing.Color.White;
            this.btn_MoFile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_MoFile.IconSize = 35;
            this.btn_MoFile.Location = new System.Drawing.Point(53, 109);
            this.btn_MoFile.Margin = new System.Windows.Forms.Padding(0);
            this.btn_MoFile.Name = "btn_MoFile";
            this.btn_MoFile.Size = new System.Drawing.Size(65, 65);
            this.btn_MoFile.TabIndex = 8;
            this.btn_MoFile.UseVisualStyleBackColor = false;
            this.btn_MoFile.Click += new System.EventHandler(this.btn_MoFile_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Luu.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btn_Luu.FlatAppearance.BorderSize = 0;
            this.btn_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Luu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.ForeColor = System.Drawing.Color.White;
            this.btn_Luu.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Luu.IconColor = System.Drawing.Color.White;
            this.btn_Luu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Luu.IconSize = 30;
            this.btn_Luu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Luu.Location = new System.Drawing.Point(1032, 666);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(170, 55);
            this.btn_Luu.TabIndex = 7;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // panelFile
            // 
            this.panelFile.AllowDrop = true;
            this.panelFile.AutoScroll = true;
            this.panelFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFile.Controls.Add(this.panel_KeoTha);
            this.panelFile.Location = new System.Drawing.Point(141, 109);
            this.panelFile.Name = "panelFile";
            this.panelFile.Size = new System.Drawing.Size(1061, 516);
            this.panelFile.TabIndex = 6;
            this.panelFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelFile_DragDrop);
            this.panelFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelFile_DragEnter);
            // 
            // panel_KeoTha
            // 
            this.panel_KeoTha.Controls.Add(this.label1);
            this.panel_KeoTha.Controls.Add(this.iconPictureBox1);
            this.panel_KeoTha.Location = new System.Drawing.Point(322, 161);
            this.panel_KeoTha.Name = "panel_KeoTha";
            this.panel_KeoTha.Size = new System.Drawing.Size(428, 207);
            this.panel_KeoTha.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(91, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "Kéo Thả Tập Tin Ở Đây";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.iconPictureBox1.IconColor = System.Drawing.Color.DodgerBlue;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox1.IconSize = 72;
            this.iconPictureBox1.Location = new System.Drawing.Point(176, 20);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(77, 72);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
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
            this.bunifuLabel1.Location = new System.Drawing.Point(53, 8);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(188, 37);
            this.bunifuLabel1.TabIndex = 6;
            this.bunifuLabel1.Text = "Nộp Nhiệm Vụ";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Frm_NopFile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1279, 768);
            this.Controls.Add(this.btn_XoaTatCa);
            this.Controls.Add(this.btn_MoFile);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.panelFile);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_NopFile";
            this.Text = "Frm_NopFile";
            this.Load += new System.EventHandler(this.Frm_NopFile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelFile.ResumeLayout(false);
            this.panel_KeoTha.ResumeLayout(false);
            this.panel_KeoTha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btn_Exit;
        private FontAwesome.Sharp.IconButton btn_XoaTatCa;
        private FontAwesome.Sharp.IconButton btn_MoFile;
        private FontAwesome.Sharp.IconButton btn_Luu;
        private System.Windows.Forms.Panel panelFile;
        private System.Windows.Forms.Panel panel_KeoTha;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
    }
}