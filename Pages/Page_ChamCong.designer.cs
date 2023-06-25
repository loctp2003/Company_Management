namespace QuanLyDuAn.Pages
{
    partial class Page_ChamCong
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
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.lbl_MaNV = new System.Windows.Forms.Label();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.txt_CheckOut = new System.Windows.Forms.TextBox();
            this.txt_CheckIn = new System.Windows.Forms.TextBox();
            this.btn_VangPhep = new System.Windows.Forms.Button();
            this.btn_CheckOut = new System.Windows.Forms.Button();
            this.btn_CheckIn = new System.Windows.Forms.Button();
            this.btn_HomNay = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_ThangSau = new System.Windows.Forms.Button();
            this.btn_ChuNhat = new System.Windows.Forms.Button();
            this.btn_Thu7 = new System.Windows.Forms.Button();
            this.btn_Thu6 = new System.Windows.Forms.Button();
            this.btn_Thu5 = new System.Windows.Forms.Button();
            this.btn_Thu4 = new System.Windows.Forms.Button();
            this.btn_Thu3 = new System.Windows.Forms.Button();
            this.btn_ThangTruoc = new System.Windows.Forms.Button();
            this.btn_Thu2 = new System.Windows.Forms.Button();
            this.pnl_Matrix = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NgayCong = new System.Windows.Forms.TextBox();
            this.txt_VangPhep = new System.Windows.Forms.TextBox();
            this.gb_LyDo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ChuThich = new System.Windows.Forms.TextBox();
            this.cb_LyDo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.gb_LyDo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Enabled = false;
            this.txt_HoTen.Location = new System.Drawing.Point(617, 59);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(209, 22);
            this.txt_HoTen.TabIndex = 3;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Enabled = false;
            this.txt_MaNV.Location = new System.Drawing.Point(212, 59);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(209, 22);
            this.txt_MaNV.TabIndex = 2;
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.Location = new System.Drawing.Point(523, 65);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(67, 16);
            this.lbl_HoTen.TabIndex = 1;
            this.lbl_HoTen.Text = "Họ và tên:";
            // 
            // lbl_MaNV
            // 
            this.lbl_MaNV.AutoSize = true;
            this.lbl_MaNV.Location = new System.Drawing.Point(108, 65);
            this.lbl_MaNV.Name = "lbl_MaNV";
            this.lbl_MaNV.Size = new System.Drawing.Size(89, 16);
            this.lbl_MaNV.TabIndex = 0;
            this.lbl_MaNV.Text = "Mã nhân viên:";
            // 
            // dtpkDate
            // 
            this.dtpkDate.Location = new System.Drawing.Point(257, 23);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(231, 22);
            this.dtpkDate.TabIndex = 9;
            this.dtpkDate.ValueChanged += new System.EventHandler(this.dtpkDate_ValueChanged);
            // 
            // txt_CheckOut
            // 
            this.txt_CheckOut.Enabled = false;
            this.txt_CheckOut.Location = new System.Drawing.Point(152, 87);
            this.txt_CheckOut.Name = "txt_CheckOut";
            this.txt_CheckOut.Size = new System.Drawing.Size(168, 22);
            this.txt_CheckOut.TabIndex = 8;
            this.txt_CheckOut.Text = "  ";
            // 
            // txt_CheckIn
            // 
            this.txt_CheckIn.Enabled = false;
            this.txt_CheckIn.Location = new System.Drawing.Point(152, 21);
            this.txt_CheckIn.Name = "txt_CheckIn";
            this.txt_CheckIn.Size = new System.Drawing.Size(168, 22);
            this.txt_CheckIn.TabIndex = 7;
            // 
            // btn_VangPhep
            // 
            this.btn_VangPhep.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_VangPhep.Location = new System.Drawing.Point(526, 160);
            this.btn_VangPhep.Name = "btn_VangPhep";
            this.btn_VangPhep.Size = new System.Drawing.Size(130, 43);
            this.btn_VangPhep.TabIndex = 4;
            this.btn_VangPhep.Text = "Vắng phép";
            this.btn_VangPhep.UseVisualStyleBackColor = false;
            this.btn_VangPhep.Click += new System.EventHandler(this.btn_VangPhep_Click);
            // 
            // btn_CheckOut
            // 
            this.btn_CheckOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_CheckOut.Location = new System.Drawing.Point(16, 77);
            this.btn_CheckOut.Name = "btn_CheckOut";
            this.btn_CheckOut.Size = new System.Drawing.Size(130, 43);
            this.btn_CheckOut.TabIndex = 3;
            this.btn_CheckOut.Text = "Check out";
            this.btn_CheckOut.UseVisualStyleBackColor = false;
            this.btn_CheckOut.Click += new System.EventHandler(this.btn_CheckOut_Click);
            // 
            // btn_CheckIn
            // 
            this.btn_CheckIn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_CheckIn.Location = new System.Drawing.Point(16, 11);
            this.btn_CheckIn.Name = "btn_CheckIn";
            this.btn_CheckIn.Size = new System.Drawing.Size(130, 43);
            this.btn_CheckIn.TabIndex = 2;
            this.btn_CheckIn.Text = "Check in";
            this.btn_CheckIn.UseVisualStyleBackColor = false;
            this.btn_CheckIn.Click += new System.EventHandler(this.btn_CheckIn_Click);
            // 
            // btn_HomNay
            // 
            this.btn_HomNay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_HomNay.Location = new System.Drawing.Point(526, 14);
            this.btn_HomNay.Name = "btn_HomNay";
            this.btn_HomNay.Size = new System.Drawing.Size(110, 31);
            this.btn_HomNay.TabIndex = 1;
            this.btn_HomNay.Text = "Hôm nay";
            this.btn_HomNay.UseVisualStyleBackColor = false;
            this.btn_HomNay.Click += new System.EventHandler(this.btn_HomNay_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_ThangSau);
            this.panel5.Controls.Add(this.btn_ChuNhat);
            this.panel5.Controls.Add(this.btn_Thu7);
            this.panel5.Controls.Add(this.btn_Thu6);
            this.panel5.Controls.Add(this.btn_Thu5);
            this.panel5.Controls.Add(this.btn_Thu4);
            this.panel5.Controls.Add(this.btn_Thu3);
            this.panel5.Controls.Add(this.btn_ThangTruoc);
            this.panel5.Controls.Add(this.btn_Thu2);
            this.panel5.Location = new System.Drawing.Point(4, 336);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(955, 74);
            this.panel5.TabIndex = 7;
            // 
            // btn_ThangSau
            // 
            this.btn_ThangSau.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ThangSau.Location = new System.Drawing.Point(844, 3);
            this.btn_ThangSau.Name = "btn_ThangSau";
            this.btn_ThangSau.Size = new System.Drawing.Size(98, 68);
            this.btn_ThangSau.TabIndex = 2;
            this.btn_ThangSau.Text = "Tháng sau";
            this.btn_ThangSau.UseVisualStyleBackColor = false;
            this.btn_ThangSau.Click += new System.EventHandler(this.btn_ThangSau_Click);
            // 
            // btn_ChuNhat
            // 
            this.btn_ChuNhat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ChuNhat.Location = new System.Drawing.Point(740, 3);
            this.btn_ChuNhat.Name = "btn_ChuNhat";
            this.btn_ChuNhat.Size = new System.Drawing.Size(98, 68);
            this.btn_ChuNhat.TabIndex = 2;
            this.btn_ChuNhat.Text = "Chủ nhật";
            this.btn_ChuNhat.UseVisualStyleBackColor = false;
            // 
            // btn_Thu7
            // 
            this.btn_Thu7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Thu7.Location = new System.Drawing.Point(636, 3);
            this.btn_Thu7.Name = "btn_Thu7";
            this.btn_Thu7.Size = new System.Drawing.Size(98, 68);
            this.btn_Thu7.TabIndex = 2;
            this.btn_Thu7.Text = "Thứ 7";
            this.btn_Thu7.UseVisualStyleBackColor = false;
            // 
            // btn_Thu6
            // 
            this.btn_Thu6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Thu6.Location = new System.Drawing.Point(532, 3);
            this.btn_Thu6.Name = "btn_Thu6";
            this.btn_Thu6.Size = new System.Drawing.Size(98, 68);
            this.btn_Thu6.TabIndex = 2;
            this.btn_Thu6.Text = "Thứ 6";
            this.btn_Thu6.UseVisualStyleBackColor = false;
            // 
            // btn_Thu5
            // 
            this.btn_Thu5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Thu5.Location = new System.Drawing.Point(428, 3);
            this.btn_Thu5.Name = "btn_Thu5";
            this.btn_Thu5.Size = new System.Drawing.Size(98, 68);
            this.btn_Thu5.TabIndex = 2;
            this.btn_Thu5.Text = "Thứ 5";
            this.btn_Thu5.UseVisualStyleBackColor = false;
            // 
            // btn_Thu4
            // 
            this.btn_Thu4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Thu4.Location = new System.Drawing.Point(324, 3);
            this.btn_Thu4.Name = "btn_Thu4";
            this.btn_Thu4.Size = new System.Drawing.Size(98, 68);
            this.btn_Thu4.TabIndex = 2;
            this.btn_Thu4.Text = "Thứ 4";
            this.btn_Thu4.UseVisualStyleBackColor = false;
            // 
            // btn_Thu3
            // 
            this.btn_Thu3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Thu3.Location = new System.Drawing.Point(220, 3);
            this.btn_Thu3.Name = "btn_Thu3";
            this.btn_Thu3.Size = new System.Drawing.Size(98, 68);
            this.btn_Thu3.TabIndex = 1;
            this.btn_Thu3.Text = "Thứ 3";
            this.btn_Thu3.UseVisualStyleBackColor = false;
            // 
            // btn_ThangTruoc
            // 
            this.btn_ThangTruoc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ThangTruoc.Location = new System.Drawing.Point(15, 3);
            this.btn_ThangTruoc.Name = "btn_ThangTruoc";
            this.btn_ThangTruoc.Size = new System.Drawing.Size(98, 68);
            this.btn_ThangTruoc.TabIndex = 0;
            this.btn_ThangTruoc.Text = "Tháng trước";
            this.btn_ThangTruoc.UseVisualStyleBackColor = false;
            this.btn_ThangTruoc.Click += new System.EventHandler(this.btn_ThangTruoc_Click);
            // 
            // btn_Thu2
            // 
            this.btn_Thu2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Thu2.Location = new System.Drawing.Point(116, 3);
            this.btn_Thu2.Name = "btn_Thu2";
            this.btn_Thu2.Size = new System.Drawing.Size(98, 68);
            this.btn_Thu2.TabIndex = 0;
            this.btn_Thu2.Text = "Thứ 2";
            this.btn_Thu2.UseVisualStyleBackColor = false;
            // 
            // pnl_Matrix
            // 
            this.pnl_Matrix.Location = new System.Drawing.Point(120, 416);
            this.pnl_Matrix.Name = "pnl_Matrix";
            this.pnl_Matrix.Size = new System.Drawing.Size(722, 369);
            this.pnl_Matrix.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ngày công:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Vắng phép:";
            // 
            // txt_NgayCong
            // 
            this.txt_NgayCong.Enabled = false;
            this.txt_NgayCong.Location = new System.Drawing.Point(212, 110);
            this.txt_NgayCong.Name = "txt_NgayCong";
            this.txt_NgayCong.Size = new System.Drawing.Size(209, 22);
            this.txt_NgayCong.TabIndex = 12;
            // 
            // txt_VangPhep
            // 
            this.txt_VangPhep.Enabled = false;
            this.txt_VangPhep.Location = new System.Drawing.Point(617, 113);
            this.txt_VangPhep.Name = "txt_VangPhep";
            this.txt_VangPhep.Size = new System.Drawing.Size(209, 22);
            this.txt_VangPhep.TabIndex = 13;
            // 
            // gb_LyDo
            // 
            this.gb_LyDo.Controls.Add(this.label3);
            this.gb_LyDo.Controls.Add(this.txt_ChuThich);
            this.gb_LyDo.Controls.Add(this.cb_LyDo);
            this.gb_LyDo.Location = new System.Drawing.Point(526, 210);
            this.gb_LyDo.Name = "gb_LyDo";
            this.gb_LyDo.Size = new System.Drawing.Size(342, 114);
            this.gb_LyDo.TabIndex = 17;
            this.gb_LyDo.TabStop = false;
            this.gb_LyDo.Text = "Lý do";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chú thích";
            // 
            // txt_ChuThich
            // 
            this.txt_ChuThich.Location = new System.Drawing.Point(19, 73);
            this.txt_ChuThich.Name = "txt_ChuThich";
            this.txt_ChuThich.Size = new System.Drawing.Size(297, 22);
            this.txt_ChuThich.TabIndex = 3;
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
            this.cb_LyDo.Location = new System.Drawing.Point(19, 23);
            this.cb_LyDo.Name = "cb_LyDo";
            this.cb_LyDo.Size = new System.Drawing.Size(297, 24);
            this.cb_LyDo.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_CheckIn);
            this.panel1.Controls.Add(this.txt_CheckIn);
            this.panel1.Controls.Add(this.btn_CheckOut);
            this.panel1.Controls.Add(this.txt_CheckOut);
            this.panel1.Location = new System.Drawing.Point(95, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 145);
            this.panel1.TabIndex = 18;
            // 
            // Page_ChamCong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gb_LyDo);
            this.Controls.Add(this.btn_VangPhep);
            this.Controls.Add(this.txt_VangPhep);
            this.Controls.Add(this.txt_NgayCong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.dtpkDate);
            this.Controls.Add(this.lbl_HoTen);
            this.Controls.Add(this.txt_MaNV);
            this.Controls.Add(this.pnl_Matrix);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lbl_MaNV);
            this.Controls.Add(this.btn_HomNay);
            this.Name = "Page_ChamCong";
            this.Size = new System.Drawing.Size(978, 853);
            this.Load += new System.EventHandler(this.Page_ChamCong_Load);
            this.panel5.ResumeLayout(false);
            this.gb_LyDo.ResumeLayout(false);
            this.gb_LyDo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.Label lbl_MaNV;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.TextBox txt_CheckOut;
        private System.Windows.Forms.TextBox txt_CheckIn;
        private System.Windows.Forms.Button btn_VangPhep;
        private System.Windows.Forms.Button btn_CheckOut;
        private System.Windows.Forms.Button btn_CheckIn;
        private System.Windows.Forms.Button btn_HomNay;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_ThangSau;
        private System.Windows.Forms.Button btn_ChuNhat;
        private System.Windows.Forms.Button btn_Thu7;
        private System.Windows.Forms.Button btn_Thu6;
        private System.Windows.Forms.Button btn_Thu5;
        private System.Windows.Forms.Button btn_Thu4;
        private System.Windows.Forms.Button btn_Thu3;
        private System.Windows.Forms.Button btn_ThangTruoc;
        private System.Windows.Forms.Button btn_Thu2;
        private System.Windows.Forms.Panel pnl_Matrix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NgayCong;
        private System.Windows.Forms.TextBox txt_VangPhep;
        private System.Windows.Forms.GroupBox gb_LyDo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ChuThich;
        private System.Windows.Forms.ComboBox cb_LyDo;
        private System.Windows.Forms.Panel panel1;
    }
}
