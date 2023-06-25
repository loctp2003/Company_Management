using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDuAn.Dao.Dao;
using QuanLyDuAn.Forms;

namespace QuanLyDuAn.Pages
{
    public partial class Page_Luong : UserControl
    {
        LuongDao ld = new LuongDao();
        public Page_Luong()
        {
            InitializeComponent();
        }
        private void cb_ChonNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_ChonThang.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                cb_ChonThang.Items.Add(i + "/" + cb_ChonNam.Text);
            }
        }
        private void Page_Luong_Load(object sender, EventArgs e)
        {
            foreach (DataRow row in ld.DanhSachLuong().Rows)
            {
                int nam = (Int32)row["Nam"];
                if (!cb_ChonNam.Items.Contains(nam))
                {
                    cb_ChonNam.Items.Add(nam);
                    cb_ChonNam.Sorted = true;
                }
            }
            int Nam = DateTime.Now.Year;
            int Thang = DateTime.Now.Month;
            var ds = ld.DanhSachLuongTheoThangNam(Thang, Nam);
            dgv_Luong.DataSource = ds;
        }
        private void dgv_Luong_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Luong.Rows[e.RowIndex];
                string MaNV = row.Cells[0].Value.ToString();
                string HoTen = row.Cells[1].Value.ToString();
                string LuongCoBan = row.Cells[2].Value.ToString();
                string NgayCong = row.Cells[3].Value.ToString();
                string VangPhep = row.Cells[4].Value.ToString();
                string Thuong = row.Cells[5].Value.ToString();
                string Nam = row.Cells[6].Value.ToString();
                string Thang = row.Cells[7].Value.ToString();
                string Luong = row.Cells[8].Value.ToString();
                Frm_Luong frml = new Frm_Luong(MaNV, HoTen, LuongCoBan, NgayCong, VangPhep, Thuong, Nam, Thang, Luong);
                frml.ShowDialog();
            }
        }

        private void cb_ChonThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] str = cb_ChonThang.Text.Split('/');
            int thang = Convert.ToInt32(str[0]);
            int nam = Convert.ToInt32(str[1]);
            var ds = ld.DanhSachLuongTheoThangNam(thang, nam);
            dgv_Luong.DataSource = ds;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            var ds = ld.TimKiemNhanVien(txt_Search.Text);
            dgv_Luong.DataSource = ds;
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            int Nam = DateTime.Now.Year;
            int Thang = DateTime.Now.Month;
            var ds = ld.DanhSachLuongTheoThangNam(Thang, Nam);
            dgv_Luong.DataSource = ds;
        }

        private void btn_TinhLuong_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_Luong.Rows)
            {
                if (!row.IsNewRow)
                {
                    int LuongCoBan = Convert.ToInt32(row.Cells[2].Value);
                    int NgayCong = Convert.ToInt32(row.Cells[3].Value);
                    int VangPhep = Convert.ToInt32(row.Cells[4].Value);
                    int Thuong = Convert.ToInt32(row.Cells[5].Value);
                    row.Cells[8].Value = LuongCoBan * (NgayCong - VangPhep * 0.8) + Thuong;
                }
            }
        }
    }
}
