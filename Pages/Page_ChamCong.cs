using QuanLyDuAn.Dao;
using QuanLyDuAn.Dao.Dao;
using QuanLyDuAn.Forms;
using QuanLyDuAn.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuAn.Pages
{
    public partial class Page_ChamCong : UserControl
    {
        ChamCongDao ccd = new ChamCongDao();
        NhanVienDao nvd = new NhanVienDao();
        public static string ma;

        private List<List<Button>> matrix;
        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }
        public Page_ChamCong()
        {
            InitializeComponent();
            CreateMatrixDay();
               
            var reader1 = nvd.DocDuDieuNhanVienTuTK(Frm_DangNhap.LoaiTaiKhoan, Frm_DangNhap.txt_UsernameCopy.Text, Frm_DangNhap.txt_PasswordCopy.Text);
            if (reader1.Read())
            {
                txt_MaNV.Text = reader1["MaNV"].ToString().Trim();
                ma = txt_MaNV.Text;
                txt_HoTen.Text = reader1["HoTen"].ToString().Trim();
            }
            txt_MaNV.ReadOnly = true;
            txt_HoTen.ReadOnly = true;
            cb_LyDo.Enabled = false;
            txt_ChuThich.Enabled = false;
            nvd.dao.conn.Close();
        }
        private void Page_ChamCong_Load(object sender, EventArgs e)
        {
        }
        void CreateMatrixDay()
        {
            Matrix = new List<List<Button>>();

            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, 0) };
            for (int i = 0; i < Cons.DayOfColumn; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.DayOfWeek; j++)
                {
                    Button btn = new Button() { Width = Cons.dateButtonWidth, Height = Cons.dateButtonHeight };
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + Cons.margin, oldBtn.Location.Y);
                    btn.Click += Btn_Click;

                    pnl_Matrix.Controls.Add(btn);
                    Matrix[i].Add(btn);

                    oldBtn = btn;
                }
                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, oldBtn.Location.Y + Cons.dateButtonHeight) };
            }
            SetDefaultDate();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as Button).Text))
                return;
            DateTime dt = new DateTime(dtpkDate.Value.Year, dtpkDate.Value.Month, Convert.ToInt32((sender as Button).Text));
            dtpkDate.Value = dt;
            var reader = ccd.DocDuDieuNhanVienTuMaNVvaNgay(ma, dt);
            if (reader.Read())
            {
                txt_CheckIn.Text = reader["CheckIn"].ToString().Trim();
                txt_CheckOut.Text = reader["CheckOut"].ToString().Trim();
                cb_LyDo.Text = reader["LyDo"].ToString().Trim();
                txt_ChuThich.Text = reader["ChuThich"].ToString().Trim();
            }
            else
            {
                txt_CheckIn.Text = "";
                txt_CheckOut.Text = "";
                cb_LyDo.Text = "";
                txt_ChuThich.Text = "";
            }
            txt_CheckIn.ReadOnly = true;
            txt_CheckOut.ReadOnly = true;
            cb_LyDo.Enabled = false;
            txt_ChuThich.Enabled = false;

            ccd.dao.conn.Close();
        }
        void AddNumberIntoMatrixByDate(DateTime date)
        {
            ClearMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);
            int line = 0;
            List<string> dateOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            for (int i = 1; i <= Utils.DayOfMonth(date); i++)
            {
                int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                Button btn = Matrix[line][column];
                btn.Text = i.ToString();
                if (isEqualDate(useDate, DateTime.Now))
                {
                    btn.BackColor = Color.Yellow;
                }
                if (isEqualDate(useDate, date))
                {
                    btn.BackColor = Color.Aqua;
                }
                if (column == 6)
                {
                    btn.BackColor = Color.Orange;
                }
                var reader = ccd.DocDuDieuNhanVienTuMaNV(ma);
                while (reader.Read())
                {
                    DateTime dt = reader.GetDateTime(reader.GetOrdinal("Ngay"));
                    if (isEqualDate(useDate, dt))
                    {
                        if (!reader.IsDBNull(reader.GetOrdinal("CheckOut")))
                        {
                            btn.BackColor = Color.Green;
                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("LyDo")))
                        {
                            btn.BackColor = Color.Red;
                        }
                    }
                }
                ccd.dao.conn.Close();
                if (column >= 6)
                    line++;
                useDate = useDate.AddDays(1);
            }
        }
        bool isEqualDate(DateTime dateA, DateTime dateB)
        {
            return dateA.Year == dateB.Year && dateA.Month == dateB.Month && dateA.Day == dateB.Day;
        }
        void ClearMatrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.WhiteSmoke;
                }
            }
        }
        void SetDefaultDate()
        {
            dtpkDate.Value = DateTime.Now;
        }

        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            AddNumberIntoMatrixByDate((sender as DateTimePicker).Value);
            var reader2 = ccd.ThongTinChamCong(dtpkDate.Value.Year, dtpkDate.Value.Month);
            if (reader2.Read())
            {
                txt_NgayCong.Text = reader2["NgayCong"].ToString().Trim();
                txt_VangPhep.Text = reader2["VangPhep"].ToString().Trim();
            }
            else
            {
                txt_NgayCong.Text = "0";
                txt_VangPhep.Text = "0";
            }
            ccd.dao.conn.Close();
        }

        private void btn_ThangSau_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(1);
        }

        private void btn_ThangTruoc_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(-1);
        }

        private void btn_HomNay_Click(object sender, EventArgs e)
        {
            SetDefaultDate();
        }

        private void btn_VangPhep_Click(object sender, EventArgs e)
        {
            Frm_VangPhep fvp = new Frm_VangPhep(new DateTime(dtpkDate.Value.Year, dtpkDate.Value.Month, dtpkDate.Value.Day), ma);
            fvp.ShowDialog();
        }
        private void btn_CheckIn_Click(object sender, EventArgs e)
        {
            ChamCong cc = new ChamCong(txt_MaNV.Text, dtpkDate.Value, null, null, null, dtpkDate.Value);
            ccd.InsertCheckin(cc);
        }
        private void btn_CheckOut_Click(object sender, EventArgs e)
        {
            ChamCong cc = new ChamCong(txt_MaNV.Text, null, dtpkDate.Value, null, null, dtpkDate.Value);
            ccd.UpdateCheckOut(cc);
        }
    }
}
