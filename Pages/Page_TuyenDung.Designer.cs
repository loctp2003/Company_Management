namespace QuanLyDuAn.Pages
{
    partial class Page_TuyenDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_TuyenDung));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_Search = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btn_Search = new FontAwesome.Sharp.IconButton();
            this.btn_Reload = new FontAwesome.Sharp.IconButton();
            this.btn_Them = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_TuyenDung = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.MaTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MucLuongTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MucLuongDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanTuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhThucLamViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiLamViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Xem = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TuyenDung)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Search
            // 
            this.txt_Search.AcceptsReturn = false;
            this.txt_Search.AcceptsTab = false;
            this.txt_Search.AnimationSpeed = 200;
            this.txt_Search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Search.BackColor = System.Drawing.Color.Transparent;
            this.txt_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_Search.BackgroundImage")));
            this.txt_Search.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_Search.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_Search.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_Search.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_Search.BorderRadius = 1;
            this.txt_Search.BorderThickness = 1;
            this.txt_Search.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_Search.DefaultText = "";
            this.txt_Search.FillColor = System.Drawing.Color.White;
            this.txt_Search.HideSelection = true;
            this.txt_Search.IconLeft = null;
            this.txt_Search.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.IconPadding = 10;
            this.txt_Search.IconRight = null;
            this.txt_Search.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.Lines = new string[0];
            this.txt_Search.Location = new System.Drawing.Point(13, 14);
            this.txt_Search.MaxLength = 32767;
            this.txt_Search.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_Search.Modified = false;
            this.txt_Search.Multiline = false;
            this.txt_Search.Name = "txt_Search";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Search.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_Search.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Search.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Search.OnIdleState = stateProperties4;
            this.txt_Search.Padding = new System.Windows.Forms.Padding(3);
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_Search.PlaceholderText = "Enter text";
            this.txt_Search.ReadOnly = false;
            this.txt_Search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Search.SelectedText = "";
            this.txt_Search.SelectionLength = 0;
            this.txt_Search.SelectionStart = 0;
            this.txt_Search.ShortcutsEnabled = true;
            this.txt_Search.Size = new System.Drawing.Size(260, 40);
            this.txt_Search.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_Search.TabIndex = 0;
            this.txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Search.TextMarginBottom = 0;
            this.txt_Search.TextMarginLeft = 3;
            this.txt_Search.TextMarginTop = 0;
            this.txt_Search.TextPlaceholder = "Enter text";
            this.txt_Search.UseSystemPasswordChar = false;
            this.txt_Search.WordWrap = true;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Search.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btn_Search.IconColor = System.Drawing.Color.White;
            this.btn_Search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Search.IconSize = 30;
            this.btn_Search.Location = new System.Drawing.Point(279, 14);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(42, 35);
            this.btn_Search.TabIndex = 6;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Reload
            // 
            this.btn_Reload.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Reload.FlatAppearance.BorderSize = 0;
            this.btn_Reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reload.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Reload.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btn_Reload.IconColor = System.Drawing.Color.White;
            this.btn_Reload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Reload.IconSize = 30;
            this.btn_Reload.Location = new System.Drawing.Point(327, 14);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(42, 35);
            this.btn_Reload.TabIndex = 7;
            this.btn_Reload.UseVisualStyleBackColor = false;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(375, 14);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(111, 40);
            this.btn_Them.TabIndex = 8;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Controls.Add(this.btn_Reload);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.txt_Search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 65);
            this.panel1.TabIndex = 0;
            // 
            // dgv_TuyenDung
            // 
            this.dgv_TuyenDung.AllowCustomTheming = false;
            this.dgv_TuyenDung.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_TuyenDung.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_TuyenDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_TuyenDung.BackgroundColor = System.Drawing.Color.White;
            this.dgv_TuyenDung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_TuyenDung.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TuyenDung.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TuyenDung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_TuyenDung.ColumnHeadersHeight = 40;
            this.dgv_TuyenDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTD,
            this.TenTD,
            this.ViTri,
            this.PhongBan,
            this.MucLuongTu,
            this.MucLuongDen,
            this.HanTuyen,
            this.HinhThucLamViec,
            this.NoiLamViec,
            this.btn_Xem});
            this.dgv_TuyenDung.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgv_TuyenDung.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_TuyenDung.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_TuyenDung.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_TuyenDung.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_TuyenDung.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgv_TuyenDung.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_TuyenDung.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_TuyenDung.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgv_TuyenDung.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_TuyenDung.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgv_TuyenDung.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_TuyenDung.CurrentTheme.Name = null;
            this.dgv_TuyenDung.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TuyenDung.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_TuyenDung.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_TuyenDung.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_TuyenDung.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TuyenDung.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_TuyenDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_TuyenDung.EnableHeadersVisualStyles = false;
            this.dgv_TuyenDung.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_TuyenDung.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_TuyenDung.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgv_TuyenDung.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_TuyenDung.Location = new System.Drawing.Point(0, 65);
            this.dgv_TuyenDung.Name = "dgv_TuyenDung";
            this.dgv_TuyenDung.RowHeadersVisible = false;
            this.dgv_TuyenDung.RowHeadersWidth = 51;
            this.dgv_TuyenDung.RowTemplate.Height = 40;
            this.dgv_TuyenDung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TuyenDung.Size = new System.Drawing.Size(1099, 643);
            this.dgv_TuyenDung.TabIndex = 1;
            this.dgv_TuyenDung.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgv_TuyenDung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TuyenDung_CellContentClick);
            // 
            // MaTD
            // 
            this.MaTD.DataPropertyName = "MaTD";
            this.MaTD.HeaderText = "Mã tuyển dụng";
            this.MaTD.MinimumWidth = 6;
            this.MaTD.Name = "MaTD";
            this.MaTD.Width = 179;
            // 
            // TenTD
            // 
            this.TenTD.DataPropertyName = "TenTD";
            this.TenTD.HeaderText = "Tên tuyển dụng";
            this.TenTD.MinimumWidth = 6;
            this.TenTD.Name = "TenTD";
            this.TenTD.Width = 183;
            // 
            // ViTri
            // 
            this.ViTri.DataPropertyName = "ViTri";
            this.ViTri.HeaderText = "Vị trí";
            this.ViTri.MinimumWidth = 6;
            this.ViTri.Name = "ViTri";
            this.ViTri.Width = 82;
            // 
            // PhongBan
            // 
            this.PhongBan.DataPropertyName = "PhongBan";
            this.PhongBan.HeaderText = "Phòng ban";
            this.PhongBan.MinimumWidth = 6;
            this.PhongBan.Name = "PhongBan";
            this.PhongBan.Width = 139;
            // 
            // MucLuongTu
            // 
            this.MucLuongTu.DataPropertyName = "MucLuongTu";
            this.MucLuongTu.HeaderText = "Mức lương (từ)";
            this.MucLuongTu.MinimumWidth = 6;
            this.MucLuongTu.Name = "MucLuongTu";
            this.MucLuongTu.Width = 176;
            // 
            // MucLuongDen
            // 
            this.MucLuongDen.DataPropertyName = "MucLuongDen";
            this.MucLuongDen.HeaderText = "Mức lương (đến)";
            this.MucLuongDen.MinimumWidth = 6;
            this.MucLuongDen.Name = "MucLuongDen";
            this.MucLuongDen.Width = 192;
            // 
            // HanTuyen
            // 
            this.HanTuyen.DataPropertyName = "HanTuyen";
            this.HanTuyen.HeaderText = "Hạn tuyển";
            this.HanTuyen.MinimumWidth = 6;
            this.HanTuyen.Name = "HanTuyen";
            this.HanTuyen.Width = 134;
            // 
            // HinhThucLamViec
            // 
            this.HinhThucLamViec.DataPropertyName = "HinhThucLamViec";
            this.HinhThucLamViec.HeaderText = "Hình thức làm việc";
            this.HinhThucLamViec.MinimumWidth = 6;
            this.HinhThucLamViec.Name = "HinhThucLamViec";
            this.HinhThucLamViec.Width = 209;
            // 
            // NoiLamViec
            // 
            this.NoiLamViec.DataPropertyName = "NoiLamViec";
            this.NoiLamViec.HeaderText = "Nơi làm việc";
            this.NoiLamViec.MinimumWidth = 6;
            this.NoiLamViec.Name = "NoiLamViec";
            this.NoiLamViec.Width = 151;
            // 
            // btn_Xem
            // 
            this.btn_Xem.DataPropertyName = "btn_Xem";
            this.btn_Xem.HeaderText = "Ứng Viên";
            this.btn_Xem.MinimumWidth = 6;
            this.btn_Xem.Name = "btn_Xem";
            this.btn_Xem.Text = "Xem";
            this.btn_Xem.UseColumnTextForButtonValue = true;
            this.btn_Xem.Width = 102;
            // 
            // Page_TuyenDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.Controls.Add(this.dgv_TuyenDung);
            this.Controls.Add(this.panel1);
            this.Name = "Page_TuyenDung";
            this.Size = new System.Drawing.Size(1099, 708);
            this.Load += new System.EventHandler(this.Page_TuyenDung_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TuyenDung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuTextBox txt_Search;
        private FontAwesome.Sharp.IconButton btn_Search;
        private FontAwesome.Sharp.IconButton btn_Reload;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv_TuyenDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MucLuongTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MucLuongDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanTuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhThucLamViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiLamViec;
        private System.Windows.Forms.DataGridViewButtonColumn btn_Xem;
    }
}
