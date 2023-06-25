namespace QuanLyDuAn.Dao
{
    partial class Frm_UngVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_UngVien));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties25 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties26 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties27 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties28 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Minimize = new FontAwesome.Sharp.IconButton();
            this.btn_Maximize = new FontAwesome.Sharp.IconButton();
            this.btn_Exit = new FontAwesome.Sharp.IconButton();
            this.btn_Reload = new FontAwesome.Sharp.IconButton();
            this.btn_Search = new FontAwesome.Sharp.IconButton();
            this.txt_Search = new Bunifu.UI.WinForms.BunifuTextBox();
            this.dgv_UngVien = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.MaUV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenUV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DanhGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UngVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btn_Minimize);
            this.panel1.Controls.Add(this.btn_Maximize);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.btn_Reload);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.txt_Search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 65);
            this.panel1.TabIndex = 2;
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimize.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btn_Minimize.IconColor = System.Drawing.Color.White;
            this.btn_Minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Minimize.IconSize = 25;
            this.btn_Minimize.Location = new System.Drawing.Point(825, 0);
            this.btn_Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(43, 40);
            this.btn_Minimize.TabIndex = 10;
            this.btn_Minimize.Text = "\r\n";
            this.btn_Minimize.UseVisualStyleBackColor = false;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximize.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Maximize.FlatAppearance.BorderSize = 0;
            this.btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btn_Maximize.IconColor = System.Drawing.Color.White;
            this.btn_Maximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Maximize.IconSize = 25;
            this.btn_Maximize.Location = new System.Drawing.Point(868, 0);
            this.btn_Maximize.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(43, 40);
            this.btn_Maximize.TabIndex = 9;
            this.btn_Maximize.Text = "\r\n";
            this.btn_Maximize.UseVisualStyleBackColor = false;
            this.btn_Maximize.Click += new System.EventHandler(this.btn_Maximize_Click);
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
            this.btn_Exit.Location = new System.Drawing.Point(911, 0);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(43, 40);
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Text = "\r\n";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
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
            stateProperties25.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties25.FillColor = System.Drawing.Color.Empty;
            stateProperties25.ForeColor = System.Drawing.Color.Empty;
            stateProperties25.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Search.OnActiveState = stateProperties25;
            stateProperties26.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties26.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties26.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_Search.OnDisabledState = stateProperties26;
            stateProperties27.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties27.FillColor = System.Drawing.Color.Empty;
            stateProperties27.ForeColor = System.Drawing.Color.Empty;
            stateProperties27.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Search.OnHoverState = stateProperties27;
            stateProperties28.BorderColor = System.Drawing.Color.Silver;
            stateProperties28.FillColor = System.Drawing.Color.White;
            stateProperties28.ForeColor = System.Drawing.Color.Empty;
            stateProperties28.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Search.OnIdleState = stateProperties28;
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
            // dgv_UngVien
            // 
            this.dgv_UngVien.AllowCustomTheming = false;
            this.dgv_UngVien.AllowUserToAddRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            this.dgv_UngVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dgv_UngVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_UngVien.BackgroundColor = System.Drawing.Color.White;
            this.dgv_UngVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_UngVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_UngVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_UngVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgv_UngVien.ColumnHeadersHeight = 40;
            this.dgv_UngVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaUV,
            this.TenUV,
            this.SDT,
            this.Email,
            this.DanhGia,
            this.MaTD});
            this.dgv_UngVien.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgv_UngVien.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_UngVien.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_UngVien.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_UngVien.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_UngVien.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgv_UngVien.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_UngVien.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_UngVien.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgv_UngVien.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_UngVien.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgv_UngVien.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_UngVien.CurrentTheme.Name = null;
            this.dgv_UngVien.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_UngVien.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_UngVien.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_UngVien.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_UngVien.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_UngVien.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgv_UngVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_UngVien.EnableHeadersVisualStyles = false;
            this.dgv_UngVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_UngVien.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_UngVien.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgv_UngVien.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_UngVien.Location = new System.Drawing.Point(0, 65);
            this.dgv_UngVien.Name = "dgv_UngVien";
            this.dgv_UngVien.RowHeadersVisible = false;
            this.dgv_UngVien.RowHeadersWidth = 51;
            this.dgv_UngVien.RowTemplate.Height = 40;
            this.dgv_UngVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_UngVien.Size = new System.Drawing.Size(954, 597);
            this.dgv_UngVien.TabIndex = 3;
            this.dgv_UngVien.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // MaUV
            // 
            this.MaUV.DataPropertyName = "MaUV";
            this.MaUV.HeaderText = "Mã ứng viên";
            this.MaUV.MinimumWidth = 6;
            this.MaUV.Name = "MaUV";
            // 
            // TenUV
            // 
            this.TenUV.DataPropertyName = "TenUV";
            this.TenUV.HeaderText = "Tên ứng viên";
            this.TenUV.MinimumWidth = 6;
            this.TenUV.Name = "TenUV";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            // 
            // DanhGia
            // 
            this.DanhGia.DataPropertyName = "DanhGia";
            this.DanhGia.HeaderText = "Đánh giá";
            this.DanhGia.MinimumWidth = 6;
            this.DanhGia.Name = "DanhGia";
            // 
            // MaTD
            // 
            this.MaTD.DataPropertyName = "MaTD";
            this.MaTD.HeaderText = "Mã tuyển dụng";
            this.MaTD.MinimumWidth = 6;
            this.MaTD.Name = "MaTD";
            this.MaTD.Visible = false;
            // 
            // Frm_UngVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(954, 662);
            this.Controls.Add(this.dgv_UngVien);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_UngVien";
            this.Text = "UngVien";
            this.Load += new System.EventHandler(this.Frm_UngVien_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UngVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_Minimize;
        private FontAwesome.Sharp.IconButton btn_Maximize;
        private FontAwesome.Sharp.IconButton btn_Exit;
        private FontAwesome.Sharp.IconButton btn_Reload;
        private FontAwesome.Sharp.IconButton btn_Search;
        private Bunifu.UI.WinForms.BunifuTextBox txt_Search;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv_UngVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaUV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenUV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DanhGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTD;
    }
}