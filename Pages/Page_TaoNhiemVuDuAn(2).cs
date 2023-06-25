using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDuAn.Dao.Dao;
using QuanLyDuAn.Dialogs;

namespace QuanLyDuAn.Pages
{
    public partial class Page_TaoNhiemVuDuAn_2_ : UserControl
    {
        NhanVienDao nvd = new NhanVienDao();
        private string tenNV;
        private string tenNSH;
        private string ngayBatDau;
        public Page_TaoNhiemVuDuAn_2_(string tenNV, string tenNSH, string ngayBatDau)
        {
            InitializeComponent();
            this.tenNV = tenNV;
            this.tenNSH = tenNSH;
            this.ngayBatDau = ngayBatDau;
        }

        private void btn_EllipseVertical_Click(object sender, EventArgs e)
        {
            /*
            Frm_ThemNhiemVu tnv = new Frm_ThemNhiemVu();
            tnv.Show();*/
        }
        System.Drawing.Image ConvertBinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                System.Drawing.Image image = Image.FromStream(ms);
                ms.Close();
                return image;
            }
        }
        private void Page_TaoNhiemVuDuAn_2__Load(object sender, EventArgs e)
        {
            lbl_TenNV.Text = tenNV;
            lbl_TenNSH.Text = tenNSH.Split('-')[1];
            lbl_NgayBatDau.Text = ngayBatDau;
            byte[] b = null;
            var reader = nvd.DocDuDieuNhanVienTuMaNV(tenNSH.Split('-')[0]);
            if (reader.Read())
            {
                b = (byte[])reader["Anh"];
            }
            pc_Anh.Image = ConvertBinaryToImage(b);
        }

        private void lbl_TenNSH_Click(object sender, EventArgs e)
        {

        }
    }
}
