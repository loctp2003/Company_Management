using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

namespace QuanLyDuAn.Pages
{
    public partial class Page_DanhGiaCuaCapTren : UserControl
    {
        private string Ten;
        private DateTime NgayDanhGia;
        private int SoSao;
        private byte[] Anh;
        private string LoiDanhGia;
        public Page_DanhGiaCuaCapTren(string Ten, DateTime NgayDanhGia, int SoSao, byte[] Anh, string LoiDanhGia)
        {
            InitializeComponent();
            this.Ten = Ten;
            this.NgayDanhGia = NgayDanhGia;
            this.SoSao = SoSao;
            this.Anh = Anh;
            this.LoiDanhGia = LoiDanhGia;
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
        private void Page_DanhGiaCuaCapTren_MouseHover(object sender, EventArgs e)
        {

        }

        private void Page_DanhGiaCuaCapTren_MouseLeave(object sender, EventArgs e)
        {
        }

        private void Page_DanhGiaCuaCapTren_MouseClick(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.DodgerBlue;
            br_DanhGia.BackColor = Color.DodgerBlue;
            lbl_DanhGia.BackColor = Color.DodgerBlue;
            lbl_Ten.BackColor = Color.DodgerBlue;
            if (Page_DanhGiaNV.CurrentPage == null)
            {
                Page_DanhGiaNV.CurrentPage = this;
                Page_DanhGiaNV.pc_AnhCopy.Image = pc_Anh.Image;
                Page_DanhGiaNV.lbl_DanhGiaCopy.Text = lbl_DanhGia.Text;
                Page_DanhGiaNV.lbl_CapTrenCopy.Text = lbl_Ten.Text;
                Page_DanhGiaNV.br_DanhGiaCopy.Value = br_DanhGia.Value;
            }
            else if (Page_DanhGiaNV.CurrentPage != this)
            {
                Page_DanhGiaNV.CurrentPage.BackColor = Color.White;
                Page_DanhGiaNV.CurrentPage.br_DanhGia.BackColor = Color.White;
                Page_DanhGiaNV.CurrentPage.lbl_DanhGia.BackColor = Color.White;
                Page_DanhGiaNV.CurrentPage.lbl_Ten.BackColor = Color.White;
                Page_DanhGiaNV.CurrentPage = this;
                Page_DanhGiaNV.pc_AnhCopy.Image = pc_Anh.Image;
                Page_DanhGiaNV.lbl_DanhGiaCopy.Text = lbl_DanhGia.Text;
                Page_DanhGiaNV.lbl_CapTrenCopy.Text = lbl_Ten.Text;
                Page_DanhGiaNV.br_DanhGiaCopy.Value = br_DanhGia.Value;
            }
            Page_DanhGiaNV.rtb_DanhGiaCopy.Text = LoiDanhGia;
            
        }
        private string ChuyenThoiGianSangChuoi(DateTime dt)
        {
            TimeSpan ts = DateTime.Now - dt;
            if (ts.Days > 0)
                return ts.Days + " ngày trước";
            if (ts.Hours > 0)
                return ts.Hours + " giờ trước";
            if (ts.Minutes > 0)
                return ts.Minutes + " phút trước";
            if (ts.Seconds > 0)
                return ts.Seconds + " giây trước";
            return "";
        }
        private void Page_DanhGiaCuaCapTren_Load(object sender, EventArgs e)
        {
            lbl_Ten.Text = Ten;
            lbl_ThoiGian.Text = ChuyenThoiGianSangChuoi(NgayDanhGia);
            pc_Anh.Image = ConvertBinaryToImage(Anh);
            br_DanhGia.Value = SoSao;
        }
    }
}
