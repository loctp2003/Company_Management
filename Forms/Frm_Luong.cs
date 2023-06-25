using QuanLyDuAn.Dao.Dao;
using QuanLyDuAn.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuAn.Forms
{
    public partial class Frm_Luong : Form
    {
        LuongDao ld = new LuongDao();
        public double luong;
        public Frm_Luong(string MaNV, string HoTen, string LuongCoBan, string NgayCong, string VangPhep, string Thuong, string Nam, string Thang, string Luong)
        {
            InitializeComponent();
            txt_MaNV.Text = MaNV;
            txt_HoTen.Text = HoTen;
            txt_LuongCoBan.Text = LuongCoBan;
            txt_NgayCong.Text = NgayCong;
            txt_VangPhep.Text = VangPhep;
            txt_Thuong.Text = Thuong;
            txt_Nam.Text = Nam;
            txt_Thang.Text = Thang;
            txt_TinhLuong.Text = Luong;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Luong_Load(object sender, EventArgs e)
        {
        }

        private void btn_TinhLuong_Click(object sender, EventArgs e)
        {
            luong = (Convert.ToInt32(txt_LuongCoBan.Text) * 
                        (Convert.ToInt32(txt_NgayCong.Text) - Convert.ToInt32(txt_VangPhep.Text) * 0.8 ) +
                        Convert.ToInt32(txt_Thuong.Text));
            txt_TinhLuong.Text = luong.ToString();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            ld.UpdateLuong(luong, txt_MaNV.Text, Convert.ToInt32(txt_Thang.Text), Convert.ToInt32(txt_Nam.Text));
            this.Close();
        }
    }
}