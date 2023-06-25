namespace QuanLyDuAn.Forms
{
    partial class Frm_VangPhep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_VangPhep));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Exit = new FontAwesome.Sharp.IconButton();
            this.lbl_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_LyDo = new System.Windows.Forms.GroupBox();
            this.txt_ChuThich = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_LyDo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_XinNghi = new FontAwesome.Sharp.IconButton();
            this.startDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.endDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.txt_MaNV = new Bunifu.UI.WinForms.BunifuTextBox();
            this.panel1.SuspendLayout();
            this.gb_LyDo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 45);
            this.panel1.TabIndex = 4;
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
            this.btn_Exit.IconSize = 25;
            this.btn_Exit.Location = new System.Drawing.Point(515, 0);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(43, 40);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "\r\n";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(14, 11);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(120, 26);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Vắng Phép";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã nhân viên: ";
            // 
            // gb_LyDo
            // 
            this.gb_LyDo.Controls.Add(this.txt_ChuThich);
            this.gb_LyDo.Controls.Add(this.label3);
            this.gb_LyDo.Controls.Add(this.cb_LyDo);
            this.gb_LyDo.Location = new System.Drawing.Point(87, 128);
            this.gb_LyDo.Name = "gb_LyDo";
            this.gb_LyDo.Size = new System.Drawing.Size(376, 171);
            this.gb_LyDo.TabIndex = 18;
            this.gb_LyDo.TabStop = false;
            this.gb_LyDo.Text = "Lý do";
            // 
            // txt_ChuThich
            // 
            this.txt_ChuThich.AcceptsReturn = false;
            this.txt_ChuThich.AcceptsTab = false;
            this.txt_ChuThich.AnimationSpeed = 200;
            this.txt_ChuThich.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_ChuThich.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_ChuThich.BackColor = System.Drawing.Color.Transparent;
            this.txt_ChuThich.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_ChuThich.BackgroundImage")));
            this.txt_ChuThich.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_ChuThich.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_ChuThich.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_ChuThich.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_ChuThich.BorderRadius = 1;
            this.txt_ChuThich.BorderThickness = 1;
            this.txt_ChuThich.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_ChuThich.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ChuThich.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_ChuThich.DefaultText = "";
            this.txt_ChuThich.Enabled = false;
            this.txt_ChuThich.FillColor = System.Drawing.Color.White;
            this.txt_ChuThich.HideSelection = true;
            this.txt_ChuThich.IconLeft = null;
            this.txt_ChuThich.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ChuThich.IconPadding = 10;
            this.txt_ChuThich.IconRight = null;
            this.txt_ChuThich.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ChuThich.Lines = new string[0];
            this.txt_ChuThich.Location = new System.Drawing.Point(19, 95);
            this.txt_ChuThich.MaxLength = 32767;
            this.txt_ChuThich.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_ChuThich.Modified = false;
            this.txt_ChuThich.Multiline = false;
            this.txt_ChuThich.Name = "txt_ChuThich";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_ChuThich.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_ChuThich.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_ChuThich.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_ChuThich.OnIdleState = stateProperties4;
            this.txt_ChuThich.Padding = new System.Windows.Forms.Padding(3);
            this.txt_ChuThich.PasswordChar = '\0';
            this.txt_ChuThich.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_ChuThich.PlaceholderText = "Enter text";
            this.txt_ChuThich.ReadOnly = false;
            this.txt_ChuThich.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ChuThich.SelectedText = "";
            this.txt_ChuThich.SelectionLength = 0;
            this.txt_ChuThich.SelectionStart = 0;
            this.txt_ChuThich.ShortcutsEnabled = true;
            this.txt_ChuThich.Size = new System.Drawing.Size(338, 41);
            this.txt_ChuThich.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_ChuThich.TabIndex = 19;
            this.txt_ChuThich.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ChuThich.TextMarginBottom = 0;
            this.txt_ChuThich.TextMarginLeft = 3;
            this.txt_ChuThich.TextMarginTop = 0;
            this.txt_ChuThich.TextPlaceholder = "Enter text";
            this.txt_ChuThich.UseSystemPasswordChar = false;
            this.txt_ChuThich.WordWrap = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chú thích";
            // 
            // cb_LyDo
            // 
            this.cb_LyDo.FormattingEnabled = true;
            this.cb_LyDo.Items.AddRange(new object[] {
            "Bị ốm",
            "Có lịch hẹn khám bệnh",
            "Đi du lịch cùng người thân",
            "Giải quyết công việc gia đình",
            "Khác"});
            this.cb_LyDo.Location = new System.Drawing.Point(19, 31);
            this.cb_LyDo.Name = "cb_LyDo";
            this.cb_LyDo.Size = new System.Drawing.Size(338, 24);
            this.cb_LyDo.TabIndex = 2;
            this.cb_LyDo.SelectedIndexChanged += new System.EventHandler(this.cb_LyDo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Thời gian bắt đầu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Thời gian kết thúc: ";
            // 
            // btn_XinNghi
            // 
            this.btn_XinNghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XinNghi.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_XinNghi.IconColor = System.Drawing.Color.Black;
            this.btn_XinNghi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_XinNghi.Location = new System.Drawing.Point(419, 470);
            this.btn_XinNghi.Name = "btn_XinNghi";
            this.btn_XinNghi.Size = new System.Drawing.Size(102, 61);
            this.btn_XinNghi.TabIndex = 21;
            this.btn_XinNghi.Text = "Xin nghỉ";
            this.btn_XinNghi.UseVisualStyleBackColor = true;
            this.btn_XinNghi.Click += new System.EventHandler(this.btn_XinNghi_Click);
            // 
            // startDate
            // 
            this.startDate.BackColor = System.Drawing.Color.Transparent;
            this.startDate.BorderRadius = 1;
            this.startDate.Color = System.Drawing.Color.Silver;
            this.startDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.startDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.startDate.DisabledColor = System.Drawing.Color.Gray;
            this.startDate.DisplayWeekNumbers = false;
            this.startDate.DPHeight = 0;
            this.startDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.startDate.FillDatePicker = false;
            this.startDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.startDate.ForeColor = System.Drawing.Color.Black;
            this.startDate.Icon = ((System.Drawing.Image)(resources.GetObject("startDate.Icon")));
            this.startDate.IconColor = System.Drawing.Color.Gray;
            this.startDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.startDate.LeftTextMargin = 5;
            this.startDate.Location = new System.Drawing.Point(257, 327);
            this.startDate.MinimumSize = new System.Drawing.Size(0, 32);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(241, 32);
            this.startDate.TabIndex = 23;
            // 
            // endDate
            // 
            this.endDate.BackColor = System.Drawing.Color.Transparent;
            this.endDate.BorderRadius = 1;
            this.endDate.Color = System.Drawing.Color.Silver;
            this.endDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.endDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.endDate.DisabledColor = System.Drawing.Color.Gray;
            this.endDate.DisplayWeekNumbers = false;
            this.endDate.DPHeight = 0;
            this.endDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.endDate.FillDatePicker = false;
            this.endDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.endDate.ForeColor = System.Drawing.Color.Black;
            this.endDate.Icon = ((System.Drawing.Image)(resources.GetObject("endDate.Icon")));
            this.endDate.IconColor = System.Drawing.Color.Gray;
            this.endDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.endDate.LeftTextMargin = 5;
            this.endDate.Location = new System.Drawing.Point(257, 402);
            this.endDate.MinimumSize = new System.Drawing.Size(0, 32);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(241, 32);
            this.endDate.TabIndex = 24;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.AcceptsReturn = false;
            this.txt_MaNV.AcceptsTab = false;
            this.txt_MaNV.AnimationSpeed = 200;
            this.txt_MaNV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_MaNV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_MaNV.BackColor = System.Drawing.Color.Transparent;
            this.txt_MaNV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_MaNV.BackgroundImage")));
            this.txt_MaNV.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_MaNV.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_MaNV.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_MaNV.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_MaNV.BorderRadius = 1;
            this.txt_MaNV.BorderThickness = 1;
            this.txt_MaNV.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_MaNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaNV.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_MaNV.DefaultText = "";
            this.txt_MaNV.FillColor = System.Drawing.Color.White;
            this.txt_MaNV.HideSelection = true;
            this.txt_MaNV.IconLeft = null;
            this.txt_MaNV.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaNV.IconPadding = 10;
            this.txt_MaNV.IconRight = null;
            this.txt_MaNV.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaNV.Lines = new string[0];
            this.txt_MaNV.Location = new System.Drawing.Point(257, 60);
            this.txt_MaNV.MaxLength = 32767;
            this.txt_MaNV.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_MaNV.Modified = false;
            this.txt_MaNV.Multiline = false;
            this.txt_MaNV.Name = "txt_MaNV";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_MaNV.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_MaNV.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_MaNV.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_MaNV.OnIdleState = stateProperties8;
            this.txt_MaNV.Padding = new System.Windows.Forms.Padding(3);
            this.txt_MaNV.PasswordChar = '\0';
            this.txt_MaNV.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_MaNV.PlaceholderText = "Enter text";
            this.txt_MaNV.ReadOnly = false;
            this.txt_MaNV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_MaNV.SelectedText = "";
            this.txt_MaNV.SelectionLength = 0;
            this.txt_MaNV.SelectionStart = 0;
            this.txt_MaNV.ShortcutsEnabled = true;
            this.txt_MaNV.Size = new System.Drawing.Size(152, 41);
            this.txt_MaNV.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_MaNV.TabIndex = 22;
            this.txt_MaNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_MaNV.TextMarginBottom = 0;
            this.txt_MaNV.TextMarginLeft = 3;
            this.txt_MaNV.TextMarginTop = 0;
            this.txt_MaNV.TextPlaceholder = "Enter text";
            this.txt_MaNV.UseSystemPasswordChar = false;
            this.txt_MaNV.WordWrap = true;
            // 
            // Frm_VangPhep
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(558, 546);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.txt_MaNV);
            this.Controls.Add(this.btn_XinNghi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gb_LyDo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_VangPhep";
            this.Text = "Frm_VangPhep";
            this.Load += new System.EventHandler(this.Frm_VangPhep_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_LyDo.ResumeLayout(false);
            this.gb_LyDo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_Exit;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_LyDo;
        private Bunifu.UI.WinForms.BunifuTextBox txt_ChuThich;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_LyDo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btn_XinNghi;
        private Bunifu.UI.WinForms.BunifuDatePicker startDate;
        private Bunifu.UI.WinForms.BunifuDatePicker endDate;
        private Bunifu.UI.WinForms.BunifuTextBox txt_MaNV;
    }
}