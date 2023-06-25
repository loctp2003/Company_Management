using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDuAn.Dao;
using Bunifu.UI.WinForms;
using QuanLyDuAn.Models;
using System.Runtime.CompilerServices;
using System.Web.Configuration;
using QuanLyDuAn.ChucNang;

namespace QuanLyDuAn.Pages
{
    public partial class Page_CapNhatNV_1_ : UserControl
    {
        NopFileDao nfd = new NopFileDao();
        DuAnDao dad = new DuAnDao();
        NhiemVuNhoDao nvnd = new NhiemVuNhoDao();
        NhiemVuDao nvd = new NhiemVuDao();
        int num;
        int maNVNho;
        string ten;
        public Page_CapNhatNV_1_(int num, int maNVNho, string ten)
        {
            InitializeComponent();
            this.maNVNho = maNVNho;
            this.ten = ten;
            this.num = num;
            lbl_TenNV.Text = "";
        }

        private async void Page_CapNhatNV_1__Load(object sender, EventArgs e)
        {
            var reader2 = nfd.DocDuLieuNopFileTuMaNVNho(maNVNho);
            int i = 0;
            while (reader2.Read())
            {
                i++;
            }
            nfd.dao.conn.Close();
            if (i == 0)
                this.Enabled = false;
            else this.Enabled = true;
            await Task.Delay(400);
            var reader = nvnd.LayDuLieuTiLeHTTuMaNVN(maNVNho);
            if (reader.Read())
            {
                nud_CapNhat.Value = Convert.ToInt32(reader["TiLeHT"].ToString().Trim());
                brg_TienDo.Value = Convert.ToInt32(nud_CapNhat.Value);
                bunifuHSlider1.Value = brg_TienDo.Value;
            }
            nvnd.dao.conn.Close();
            lbl_TenNV.Text = ten;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            brg_TienDo.Value = Convert.ToInt32(nud_CapNhat.Value);
            bunifuHSlider1.Value = brg_TienDo.Value;
        }

        private void bunifuHSlider1_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            brg_TienDo.Value = bunifuHSlider1.Value;
            nud_CapNhat.Value = brg_TienDo.Value;
        }

        private void brg_TienDo_ValueChanged(object sender, BunifuRadialGauge.ValueChangedEventArgs e)
        {

        }
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            Page_CapNhatNV.tiLeHTList[num] = Convert.ToInt32(nud_CapNhat.Value);
            CapNhat.CapNhatTiLeHTNhiemVuNho(maNVNho, Convert.ToInt32(nud_CapNhat.Value));
            CapNhat.CapNhatTiLeHTNhiemVu(Page_NhiemVu.MaNV);
            CapNhat.CapNhatTiLeHTDuAn(Page_NhiemVu.MaDA);   
        }

        private void lbl_TenNV_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void brg_TienDo_Load(object sender, EventArgs e)
        {
           
        }
    }
}
