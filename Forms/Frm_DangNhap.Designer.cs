namespace QuanLyDuAn.Forms
{
    partial class Frm_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DangNhap));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties37 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties38 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties39 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties40 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties41 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties42 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties43 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties44 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties45 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties46 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties47 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties48 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Exit = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Username = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txt_Password = new Bunifu.UI.WinForms.BunifuTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_DangNhap = new FontAwesome.Sharp.IconButton();
            this.rb_TruongPhong = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.txt_InvalidPwd = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btn_Close_InvalidPwd = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 641);
            this.panel1.TabIndex = 0;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btn_Exit.IconColor = System.Drawing.Color.RoyalBlue;
            this.btn_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Exit.IconSize = 30;
            this.btn_Exit.Location = new System.Drawing.Point(865, 0);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(46, 43);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "\r\n";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(162, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đăng Nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_Username
            // 
            this.txt_Username.AcceptsReturn = false;
            this.txt_Username.AcceptsTab = false;
            this.txt_Username.AnimationSpeed = 200;
            this.txt_Username.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Username.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Username.BackColor = System.Drawing.Color.Transparent;
            this.txt_Username.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_Username.BackgroundImage")));
            this.txt_Username.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_Username.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_Username.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_Username.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_Username.BorderRadius = 20;
            this.txt_Username.BorderThickness = 2;
            this.txt_Username.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Username.DefaultFont = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.DefaultText = "";
            this.txt_Username.FillColor = System.Drawing.Color.White;
            this.txt_Username.HideSelection = true;
            this.txt_Username.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_Username.IconLeft")));
            this.txt_Username.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Username.IconPadding = 15;
            this.txt_Username.IconRight = null;
            this.txt_Username.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Username.Lines = new string[0];
            this.txt_Username.Location = new System.Drawing.Point(52, 79);
            this.txt_Username.MaxLength = 32767;
            this.txt_Username.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_Username.Modified = false;
            this.txt_Username.Multiline = false;
            this.txt_Username.Name = "txt_Username";
            stateProperties37.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties37.FillColor = System.Drawing.Color.Empty;
            stateProperties37.ForeColor = System.Drawing.Color.Empty;
            stateProperties37.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Username.OnActiveState = stateProperties37;
            stateProperties38.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties38.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties38.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_Username.OnDisabledState = stateProperties38;
            stateProperties39.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties39.FillColor = System.Drawing.Color.Empty;
            stateProperties39.ForeColor = System.Drawing.Color.Empty;
            stateProperties39.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Username.OnHoverState = stateProperties39;
            stateProperties40.BorderColor = System.Drawing.Color.Silver;
            stateProperties40.FillColor = System.Drawing.Color.White;
            stateProperties40.ForeColor = System.Drawing.Color.Empty;
            stateProperties40.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Username.OnIdleState = stateProperties40;
            this.txt_Username.Padding = new System.Windows.Forms.Padding(3);
            this.txt_Username.PasswordChar = '\0';
            this.txt_Username.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_Username.PlaceholderText = "Enter Username";
            this.txt_Username.ReadOnly = false;
            this.txt_Username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Username.SelectedText = "";
            this.txt_Username.SelectionLength = 0;
            this.txt_Username.SelectionStart = 0;
            this.txt_Username.ShortcutsEnabled = true;
            this.txt_Username.Size = new System.Drawing.Size(476, 59);
            this.txt_Username.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_Username.TabIndex = 2;
            this.txt_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Username.TextMarginBottom = 0;
            this.txt_Username.TextMarginLeft = 20;
            this.txt_Username.TextMarginTop = 0;
            this.txt_Username.TextPlaceholder = "Enter Username";
            this.txt_Username.UseSystemPasswordChar = false;
            this.txt_Username.WordWrap = true;
            this.txt_Username.TextChanged += new System.EventHandler(this.txt_Username_TextChanged);
            // 
            // txt_Password
            // 
            this.txt_Password.AcceptsReturn = false;
            this.txt_Password.AcceptsTab = false;
            this.txt_Password.AnimationSpeed = 200;
            this.txt_Password.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Password.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Password.BackColor = System.Drawing.Color.Transparent;
            this.txt_Password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_Password.BackgroundImage")));
            this.txt_Password.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_Password.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_Password.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_Password.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_Password.BorderRadius = 20;
            this.txt_Password.BorderThickness = 2;
            this.txt_Password.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Password.DefaultFont = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.DefaultText = "";
            this.txt_Password.FillColor = System.Drawing.Color.White;
            this.txt_Password.HideSelection = true;
            this.txt_Password.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_Password.IconLeft")));
            this.txt_Password.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Password.IconPadding = 15;
            this.txt_Password.IconRight = ((System.Drawing.Image)(resources.GetObject("txt_Password.IconRight")));
            this.txt_Password.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Password.Lines = new string[0];
            this.txt_Password.Location = new System.Drawing.Point(52, 176);
            this.txt_Password.MaxLength = 32767;
            this.txt_Password.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_Password.Modified = false;
            this.txt_Password.Multiline = false;
            this.txt_Password.Name = "txt_Password";
            stateProperties41.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties41.FillColor = System.Drawing.Color.Empty;
            stateProperties41.ForeColor = System.Drawing.Color.Empty;
            stateProperties41.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Password.OnActiveState = stateProperties41;
            stateProperties42.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties42.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties42.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_Password.OnDisabledState = stateProperties42;
            stateProperties43.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties43.FillColor = System.Drawing.Color.Empty;
            stateProperties43.ForeColor = System.Drawing.Color.Empty;
            stateProperties43.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Password.OnHoverState = stateProperties43;
            stateProperties44.BorderColor = System.Drawing.Color.Silver;
            stateProperties44.FillColor = System.Drawing.Color.White;
            stateProperties44.ForeColor = System.Drawing.Color.Empty;
            stateProperties44.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Password.OnIdleState = stateProperties44;
            this.txt_Password.Padding = new System.Windows.Forms.Padding(3);
            this.txt_Password.PasswordChar = '●';
            this.txt_Password.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_Password.PlaceholderText = "Enter Password";
            this.txt_Password.ReadOnly = false;
            this.txt_Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Password.SelectedText = "";
            this.txt_Password.SelectionLength = 0;
            this.txt_Password.SelectionStart = 0;
            this.txt_Password.ShortcutsEnabled = true;
            this.txt_Password.Size = new System.Drawing.Size(476, 59);
            this.txt_Password.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_Password.TabIndex = 3;
            this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Password.TextMarginBottom = 0;
            this.txt_Password.TextMarginLeft = 20;
            this.txt_Password.TextMarginTop = 0;
            this.txt_Password.TextPlaceholder = "Enter Password";
            this.txt_Password.UseSystemPasswordChar = true;
            this.txt_Password.WordWrap = true;
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_Password_TextChanged);
            this.txt_Password.OnIconRightClick += new System.EventHandler(this.txt_Password_OnIconRightClick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.checkBox1.Location = new System.Drawing.Point(52, 293);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(155, 29);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Nhớ mật khẩu";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_DangNhap.FlatAppearance.BorderSize = 0;
            this.btn_DangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangNhap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.ForeColor = System.Drawing.Color.White;
            this.btn_DangNhap.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.btn_DangNhap.IconColor = System.Drawing.Color.White;
            this.btn_DangNhap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_DangNhap.Location = new System.Drawing.Point(369, 327);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(159, 58);
            this.btn_DangNhap.TabIndex = 5;
            this.btn_DangNhap.Text = "Đăng Nhập";
            this.btn_DangNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // rb_TruongPhong
            // 
            this.rb_TruongPhong.AutoSize = true;
            this.rb_TruongPhong.Checked = true;
            this.rb_TruongPhong.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_TruongPhong.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rb_TruongPhong.Location = new System.Drawing.Point(109, 0);
            this.rb_TruongPhong.Name = "rb_TruongPhong";
            this.rb_TruongPhong.Size = new System.Drawing.Size(122, 29);
            this.rb_TruongPhong.TabIndex = 7;
            this.rb_TruongPhong.TabStop = true;
            this.rb_TruongPhong.Text = "Nhân Viên";
            this.rb_TruongPhong.UseVisualStyleBackColor = true;
            this.rb_TruongPhong.CheckedChanged += new System.EventHandler(this.rb_NhanVien_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.radioButton3.Location = new System.Drawing.Point(352, 0);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(115, 29);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.Text = "Giám Đốc";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // txt_InvalidPwd
            // 
            this.txt_InvalidPwd.AcceptsReturn = false;
            this.txt_InvalidPwd.AcceptsTab = false;
            this.txt_InvalidPwd.AnimationSpeed = 200;
            this.txt_InvalidPwd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_InvalidPwd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_InvalidPwd.BackColor = System.Drawing.Color.Transparent;
            this.txt_InvalidPwd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_InvalidPwd.BackgroundImage")));
            this.txt_InvalidPwd.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_InvalidPwd.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_InvalidPwd.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_InvalidPwd.BorderColorIdle = System.Drawing.Color.LightCoral;
            this.txt_InvalidPwd.BorderRadius = 11;
            this.txt_InvalidPwd.BorderThickness = 1;
            this.txt_InvalidPwd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_InvalidPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_InvalidPwd.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_InvalidPwd.DefaultText = "Tên Người Dùng hoặc Mật Khẩu không hợp lệ";
            this.txt_InvalidPwd.FillColor = System.Drawing.Color.Snow;
            this.txt_InvalidPwd.ForeColor = System.Drawing.Color.Red;
            this.txt_InvalidPwd.HideSelection = true;
            this.txt_InvalidPwd.IconLeft = null;
            this.txt_InvalidPwd.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_InvalidPwd.IconPadding = 10;
            this.txt_InvalidPwd.IconRight = null;
            this.txt_InvalidPwd.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_InvalidPwd.Lines = new string[] {
        "Tên Người Dùng hoặc Mật Khẩu không hợp lệ"};
            this.txt_InvalidPwd.Location = new System.Drawing.Point(52, 3);
            this.txt_InvalidPwd.MaxLength = 32767;
            this.txt_InvalidPwd.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_InvalidPwd.Modified = false;
            this.txt_InvalidPwd.Multiline = false;
            this.txt_InvalidPwd.Name = "txt_InvalidPwd";
            stateProperties45.BorderColor = System.Drawing.Color.IndianRed;
            stateProperties45.FillColor = System.Drawing.Color.Empty;
            stateProperties45.ForeColor = System.Drawing.Color.Empty;
            stateProperties45.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_InvalidPwd.OnActiveState = stateProperties45;
            stateProperties46.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties46.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties46.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties46.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_InvalidPwd.OnDisabledState = stateProperties46;
            stateProperties47.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            stateProperties47.FillColor = System.Drawing.Color.Empty;
            stateProperties47.ForeColor = System.Drawing.Color.Empty;
            stateProperties47.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_InvalidPwd.OnHoverState = stateProperties47;
            stateProperties48.BorderColor = System.Drawing.Color.LightCoral;
            stateProperties48.FillColor = System.Drawing.Color.Snow;
            stateProperties48.ForeColor = System.Drawing.Color.Red;
            stateProperties48.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_InvalidPwd.OnIdleState = stateProperties48;
            this.txt_InvalidPwd.Padding = new System.Windows.Forms.Padding(3);
            this.txt_InvalidPwd.PasswordChar = '\0';
            this.txt_InvalidPwd.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_InvalidPwd.PlaceholderText = "";
            this.txt_InvalidPwd.ReadOnly = false;
            this.txt_InvalidPwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_InvalidPwd.SelectedText = "";
            this.txt_InvalidPwd.SelectionLength = 0;
            this.txt_InvalidPwd.SelectionStart = 0;
            this.txt_InvalidPwd.ShortcutsEnabled = true;
            this.txt_InvalidPwd.Size = new System.Drawing.Size(476, 50);
            this.txt_InvalidPwd.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_InvalidPwd.TabIndex = 9;
            this.txt_InvalidPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_InvalidPwd.TextMarginBottom = 0;
            this.txt_InvalidPwd.TextMarginLeft = 15;
            this.txt_InvalidPwd.TextMarginTop = 0;
            this.txt_InvalidPwd.TextPlaceholder = "";
            this.txt_InvalidPwd.UseSystemPasswordChar = false;
            this.txt_InvalidPwd.WordWrap = true;
            // 
            // btn_Close_InvalidPwd
            // 
            this.btn_Close_InvalidPwd.BackColor = System.Drawing.Color.Snow;
            this.btn_Close_InvalidPwd.FlatAppearance.BorderSize = 0;
            this.btn_Close_InvalidPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close_InvalidPwd.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btn_Close_InvalidPwd.IconColor = System.Drawing.Color.Red;
            this.btn_Close_InvalidPwd.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_Close_InvalidPwd.IconSize = 15;
            this.btn_Close_InvalidPwd.Location = new System.Drawing.Point(490, 18);
            this.btn_Close_InvalidPwd.Name = "btn_Close_InvalidPwd";
            this.btn_Close_InvalidPwd.Size = new System.Drawing.Size(20, 20);
            this.btn_Close_InvalidPwd.TabIndex = 10;
            this.btn_Close_InvalidPwd.UseVisualStyleBackColor = false;
            this.btn_Close_InvalidPwd.Click += new System.EventHandler(this.btn_Close_InvalidPwd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(0, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(589, 517);
            this.panel2.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txt_Username);
            this.panel5.Controls.Add(this.txt_Password);
            this.panel5.Controls.Add(this.checkBox1);
            this.panel5.Controls.Add(this.btn_DangNhap);
            this.panel5.Controls.Add(this.rb_TruongPhong);
            this.panel5.Controls.Add(this.radioButton3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 91);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(589, 426);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_Close_InvalidPwd);
            this.panel4.Controls.Add(this.txt_InvalidPwd);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(589, 91);
            this.panel4.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(321, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(590, 641);
            this.panel3.TabIndex = 12;
            // 
            // Frm_DangNhap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(911, 641);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_DangNhap";
            this.Load += new System.EventHandler(this.Frm_DangNhap_Load);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_Exit;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextBox txt_Username;
        private Bunifu.UI.WinForms.BunifuTextBox txt_Password;
        private System.Windows.Forms.CheckBox checkBox1;
        private FontAwesome.Sharp.IconButton btn_DangNhap;
        private System.Windows.Forms.RadioButton rb_TruongPhong;
        private System.Windows.Forms.RadioButton radioButton3;
        private Bunifu.UI.WinForms.BunifuTextBox txt_InvalidPwd;
        private FontAwesome.Sharp.IconButton btn_Close_InvalidPwd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}