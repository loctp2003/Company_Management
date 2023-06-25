namespace QuanLyDuAn.Pages
{
    partial class Page_FileAttachment
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
            this.lbl_TenFile = new System.Windows.Forms.Label();
            this.btn_Exit = new FontAwesome.Sharp.IconButton();
            this.btn_Download = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lbl_TenFile
            // 
            this.lbl_TenFile.AutoSize = true;
            this.lbl_TenFile.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_TenFile.Location = new System.Drawing.Point(48, 29);
            this.lbl_TenFile.Name = "lbl_TenFile";
            this.lbl_TenFile.Size = new System.Drawing.Size(116, 38);
            this.lbl_TenFile.TabIndex = 31;
            this.lbl_TenFile.Text = "Tên File";
            this.lbl_TenFile.Click += new System.EventHandler(this.lbl_TenFile_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.BackColor = System.Drawing.Color.White;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btn_Exit.IconColor = System.Drawing.Color.Red;
            this.btn_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Exit.IconSize = 35;
            this.btn_Exit.Location = new System.Drawing.Point(958, 25);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(55, 51);
            this.btn_Exit.TabIndex = 32;
            this.btn_Exit.Text = "\r\n";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Download
            // 
            this.btn_Download.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Download.BackColor = System.Drawing.Color.White;
            this.btn_Download.FlatAppearance.BorderSize = 0;
            this.btn_Download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Download.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btn_Download.IconColor = System.Drawing.Color.DarkGray;
            this.btn_Download.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Download.IconSize = 35;
            this.btn_Download.Location = new System.Drawing.Point(958, 25);
            this.btn_Download.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(55, 51);
            this.btn_Download.TabIndex = 33;
            this.btn_Download.Text = "\r\n";
            this.btn_Download.UseVisualStyleBackColor = false;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // Page_FileAttachment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_Download);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.lbl_TenFile);
            this.Name = "Page_FileAttachment";
            this.Size = new System.Drawing.Size(1039, 97);
            this.Load += new System.EventHandler(this.Page_FileAttachment_Load);
            this.Click += new System.EventHandler(this.Page_FileAttachment_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TenFile;
        private FontAwesome.Sharp.IconButton btn_Exit;
        private FontAwesome.Sharp.IconButton btn_Download;
    }
}
