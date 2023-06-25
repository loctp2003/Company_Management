namespace QuanLyDuAn.Pages
{
    partial class Page_NopFileNV
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
            this.panelFile = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btn_Sua = new FontAwesome.Sharp.IconButton();
            this.btn_MoFile = new FontAwesome.Sharp.IconButton();
            this.btn_XoaTatCa = new FontAwesome.Sharp.IconButton();
            this.panelFile.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFile
            // 
            this.panelFile.AllowDrop = true;
            this.panelFile.AutoScroll = true;
            this.panelFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFile.Controls.Add(this.panel2);
            this.panelFile.Location = new System.Drawing.Point(315, 70);
            this.panelFile.Name = "panelFile";
            this.panelFile.Size = new System.Drawing.Size(1061, 516);
            this.panelFile.TabIndex = 0;
            this.panelFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panelFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            this.panelFile.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Location = new System.Drawing.Point(322, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 207);
            this.panel2.TabIndex = 0;
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
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Sua.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btn_Sua.FlatAppearance.BorderSize = 0;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Sua.IconColor = System.Drawing.Color.White;
            this.btn_Sua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Sua.IconSize = 30;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Sua.Location = new System.Drawing.Point(1206, 627);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(170, 55);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Lưu";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_NopFile_Click);
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
            this.btn_MoFile.Location = new System.Drawing.Point(227, 70);
            this.btn_MoFile.Margin = new System.Windows.Forms.Padding(0);
            this.btn_MoFile.Name = "btn_MoFile";
            this.btn_MoFile.Size = new System.Drawing.Size(65, 65);
            this.btn_MoFile.TabIndex = 2;
            this.btn_MoFile.UseVisualStyleBackColor = false;
            this.btn_MoFile.Click += new System.EventHandler(this.btn_MoFile_Click);
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
            this.btn_XoaTatCa.Location = new System.Drawing.Point(227, 150);
            this.btn_XoaTatCa.Margin = new System.Windows.Forms.Padding(0);
            this.btn_XoaTatCa.Name = "btn_XoaTatCa";
            this.btn_XoaTatCa.Size = new System.Drawing.Size(65, 65);
            this.btn_XoaTatCa.TabIndex = 3;
            this.btn_XoaTatCa.UseVisualStyleBackColor = false;
            this.btn_XoaTatCa.Click += new System.EventHandler(this.btn_XoaTatCa_Click);
            // 
            // Page_NopFileNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_XoaTatCa);
            this.Controls.Add(this.btn_MoFile);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.panelFile);
            this.Name = "Page_NopFileNV";
            this.Size = new System.Drawing.Size(1662, 729);
            this.panelFile.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFile;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btn_Sua;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btn_MoFile;
        private FontAwesome.Sharp.IconButton btn_XoaTatCa;
    }
}
