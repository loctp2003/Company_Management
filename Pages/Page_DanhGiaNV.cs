using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.SessionState;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using QuanLyDuAn.Dao;

namespace QuanLyDuAn.Pages
{
    public partial class Page_DanhGiaNV : UserControl
    {
        DanhGiaDao dgd = new DanhGiaDao();
        public static Page_DanhGiaCuaCapTren CurrentPage = null;
        public static Label lbl_CapTrenCopy;
        public static Label lbl_DanhGiaCopy;
        public static BunifuPictureBox pc_AnhCopy;
        public static BunifuRating br_DanhGiaCopy;
        public static RichTextBox rtb_DanhGiaCopy;
        public Page_DanhGiaNV()
        {
            InitializeComponent();
            lbl_CapTrenCopy = lbl_CapTren;
            lbl_DanhGiaCopy = lbl_DanhGia;
            pc_AnhCopy = pc_Anh;
            br_DanhGiaCopy = br_DanhGia;
            rtb_DanhGiaCopy = rtb_DanhGia;
        }

        private void Page_DanhGia_Load(object sender, EventArgs e)
        {
            var reader = dgd.DanhSachDanhGiaTheoMaNV(Page_NhiemVu.MaNV);
            int i = 0;
            while (reader.Read())
            {
                Page_DanhGiaCuaCapTren pdg = new Page_DanhGiaCuaCapTren(reader["HoTen"].ToString().Trim(), Convert.ToDateTime(reader["NgayDanhGia"].ToString().Trim()), Convert.ToInt32(reader["SoSao"].ToString().Trim()), (byte[])reader["Anh"], reader["LoiDanhGia"].ToString().Trim());
                pdg.Location = new Point(0, 0 + pdg.Height * i);
                panel_NguoiDanhGia.Controls.Add(pdg);
                i++;
            }
            dgd.dao.conn.Close();
        }

        private void rtb_DanhGia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
