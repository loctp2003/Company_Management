using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms.BunifuButton;
using FontAwesome.Sharp;
using QuanLyDuAn.Dao;
using QuanLyDuAn.Forms;
using QuanLyDuAn.Tools;

namespace QuanLyDuAn.Pages
{
    public partial class Page_DanhSachNV_2_ : UserControl
    {
        NopFileDao nfd = new NopFileDao();
        NhiemVuNhoDao nvnd = new NhiemVuNhoDao();
        public static IconButton ibtn_HoanThanhCopy;
        public static BunifuButton btn_NopFileCopy;
        public static IconButton btn_SuaCopy;
        int maNVNho;
        string ten;
        string tinhTrang;
        public Page_DanhSachNV_2_(int maNVNho, string ten, string tinhTrang)
        {
            InitializeComponent();
            this.maNVNho = maNVNho;
            this.ten = ten;
            this.tinhTrang = tinhTrang;
            
        }

       
        private async void Page_DanhSachNV_2__Load(object sender, EventArgs e)
        {
            await Task.Delay(400);
            lbl_TenNV.Text = ten;
            var reader = nvnd.LayDuLieuTiLeHTTuMaNVN(maNVNho);
            while (reader.Read())
            {
                brg_TienDo.Value = Convert.ToInt32(reader["TiLeHT"].ToString().Trim());
            }
            nvnd.dao.conn.Close();
            var reader2 = nfd.DocDuLieuNopFileTuMaNVNho(maNVNho);
            int i = 0;
            while (reader2.Read())
            {
                i++;
            }
            nfd.dao.conn.Close();
            if (i == 0)
            {
                btn_NopFile.Text = "Nộp File";
                btn_Sua.Visible = false;
            }
            else
            {
                btn_NopFile.Text = "Xem File";
                btn_Sua.Visible = true;
            }
           
        }

        private void btn_NopFile_Click(object sender, EventArgs e)
        {
            if (btn_NopFile.Text == "Nộp File")
            {
               // ibtn_HoanThanhCopy = ibtn_HoanThanh;
                btn_NopFileCopy = btn_NopFile;
                btn_SuaCopy = btn_Sua;
                Frm_NopFile nf = new Frm_NopFile("Nop", maNVNho);
                nf.Show();
            }
            else if (btn_NopFile.Text == "Xem File")
            {
                Frm_NopFile nf = new Frm_NopFile("Xem", maNVNho);
                nf.Show();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            btn_NopFile.Text = "Nộp File";
        }
    }
}
