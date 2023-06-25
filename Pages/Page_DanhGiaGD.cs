using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using QuanLyDuAn.Dao;
using QuanLyDuAn.Forms;
using QuanLyDuAn.Models;

namespace QuanLyDuAn.Pages
{
    public partial class Page_DanhGiaGD : UserControl
    {
        DanhGiaDao dgd = new DanhGiaDao();
        public static Page_PhanDanhGiaGD CurrentPage = null;
        public static BunifuRating br_DanhGiaCopy;
        public static RichTextBox rtx_LoiDanhGiaCopy;
        public Page_DanhGiaGD()
        {
            InitializeComponent();
            br_DanhGiaCopy = br_DanhGia;
            rtx_LoiDanhGiaCopy = rtx_LoiDanhGia;
        }


        private void btn_Luu_Click(object sender, EventArgs e)
        {
            int maDGMoi = dgd.DemDanhGia() + 1;
            dgd.ThemDanhGia(new DanhGia(maDGMoi, Page_NhiemVu.MaNV, Frm_Main.MaNhanVien, rtx_LoiDanhGia.Text, DateTime.Now, Convert.ToInt32(br_DanhGia.Value)));
            Page_DanhGiaGD_Load(sender, e);
        }

        private void Page_DanhGiaGD_Load(object sender, EventArgs e)
        {
            var reader = dgd.DanhSachDanhGiaTheoMaNguoiDGVaMaNV(Frm_Main.MaNhanVien, Page_NhiemVu.MaNV);
            int i = 0;
            while (reader.Read())
            {
                Page_PhanDanhGiaGD pdggd = new Page_PhanDanhGiaGD(reader["NgayDanhGia"].ToString().Trim(), Convert.ToInt32(reader["SoSao"].ToString().Trim()), reader["LoiDanhGia"].ToString().Trim());
                pdggd.Location = new Point(0, pdggd.Height + (i * pdggd.Height));
                panel_PhanDG.Controls.Add(pdggd);
                i++;
            }
            dgd.dao.conn.Close();
        }

        private void btn_ThemDanhGia_Click(object sender, EventArgs e)
        {
            br_DanhGia.Value = 5;
            rtx_LoiDanhGia.Text = "";
        }

        private void br_DanhGia_ValueChanged(object sender, Bunifu.UI.WinForms.BunifuRating.ValueChangedEventArgs e)
        {

        }

        private void rtx_LoiDanhGia_TextChanged(object sender, EventArgs e)
        {
            if (rtx_LoiDanhGia.Text.Length > 0)
            {
                panel2.Visible = false;
            }
            else panel2.Visible = true;
        }
    }
}
