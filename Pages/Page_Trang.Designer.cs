namespace QuanLyDuAn.Pages
{
    partial class Page_Trang
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
            this.panelPage = new System.Windows.Forms.Panel();
            this.btn_Next = new FontAwesome.Sharp.IconButton();
            this.btn_Prev = new FontAwesome.Sharp.IconButton();
            this.panelPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPage
            // 
            this.panelPage.Controls.Add(this.btn_Next);
            this.panelPage.Controls.Add(this.btn_Prev);
            this.panelPage.Location = new System.Drawing.Point(13, 18);
            this.panelPage.Name = "panelPage";
            this.panelPage.Size = new System.Drawing.Size(613, 45);
            this.panelPage.TabIndex = 6;
            // 
            // btn_Next
            // 
            this.btn_Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Next.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Next.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            this.btn_Next.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Next.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Next.IconSize = 25;
            this.btn_Next.Location = new System.Drawing.Point(522, 0);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(91, 45);
            this.btn_Next.TabIndex = 6;
            this.btn_Next.Text = "Next";
            this.btn_Next.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Next.UseVisualStyleBackColor = false;
            // 
            // btn_Prev
            // 
            this.btn_Prev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Prev.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Prev.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Prev.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            this.btn_Prev.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Prev.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Prev.IconSize = 25;
            this.btn_Prev.Location = new System.Drawing.Point(82, 0);
            this.btn_Prev.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(91, 45);
            this.btn_Prev.TabIndex = 0;
            this.btn_Prev.Text = "Prev";
            this.btn_Prev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Prev.UseVisualStyleBackColor = false;
            // 
            // Page_Trang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelPage);
            this.Name = "Page_Trang";
            this.Size = new System.Drawing.Size(649, 89);
            this.Load += new System.EventHandler(this.Page_Trang_Load);
            this.panelPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPage;
        private FontAwesome.Sharp.IconButton btn_Next;
        private FontAwesome.Sharp.IconButton btn_Prev;
    }
}
