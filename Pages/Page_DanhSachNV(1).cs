using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDuAn.Forms;
using QuanLyDuAn.Dao;
using QuanLyDuAn.Models;
using QuanLyDuAn.ChucNang;

namespace QuanLyDuAn.Pages
{
    public partial class Page_DanhSachNV_1_ : UserControl
    {
        NhanVienThamGiaDADao nvtgd = new NhanVienThamGiaDADao();
        DuAnDao dad = new DuAnDao();
        NhiemVuNhoDao nvnd = new NhiemVuNhoDao();
        NhiemVuDao nvd = new NhiemVuDao();
        NopFileDao nfd = new NopFileDao();
        string mode; //Them, Completed, In Progress
        int maNVNho;
        string ten;
        public Page_DanhSachNV_1_(string mode, int maNVNho)
        {
            InitializeComponent();
            this.mode = mode;
            this.maNVNho = maNVNho;
        }        
        public Page_DanhSachNV_1_(string mode, int maNVNho, string ten)
        {
            InitializeComponent();
            this.mode = mode;
            this.maNVNho = maNVNho;
            this.ten = ten;
        }

        private void Page_DanhSachNV_1__Load(object sender, EventArgs e)
        {
            if (mode == "Them" || mode == "Sua")
            {
                txt_TenNV.Visible = true;
                btn_XMark.Visible = true;
                btn_Check.Visible = true;
                btn_Sua.Visible = false;
                lbl_TenNV.Visible = false;
                ibtn_HoanThanh.Visible = false;
                btn_XemFile.Visible = false;
            }
            else if (mode == "Completed" || mode == "In Progress")
            {
                txt_TenNV.Visible = false;
                btn_XMark.Visible = false;
                btn_Check.Visible = false;
                btn_Sua.Visible = true;
                lbl_TenNV.Visible = true;
                lbl_TenNV.Text = ten;
                ibtn_HoanThanh.Visible = true;
                ibtn_HoanThanh.Text = mode.ToString();
                btn_XemFile.Visible = true;
            }
        }

        private void btn_XMark_Click(object sender, EventArgs e)
        {
            if (mode == "Them")
            {
                Page_DanhSachNV.dsnv1List.Remove(this);
                Page_DanhSachNV.panelMainCopy.Controls.Clear();
                for (int i = 0; i < Page_DanhSachNV.dsnv1List.Count; i++)
                {
                    Page_DanhSachNV.dsnv1List[i].Location = new Point(10, 10 + (Page_DanhSachNV.dsnv1List[i].Height + 10) * i);
                    Page_DanhSachNV.panelMainCopy.Controls.Add(Page_DanhSachNV.dsnv1List[i]);
                }
            }
            else if (mode == "Sửa")
            {
                mode = "In Progress";
                Page_DanhSachNV_1__Load(sender, e);
            }
        }
        private void btn_Check_Click(object sender, EventArgs e)
        {
            int maNVNhoMax = nvnd.MaNhiemVuNhoMax();
            lbl_TenNV.Text = txt_TenNV.Text;
            if (mode == "Them")
            {
                ten = txt_TenNV.Text;
                nvnd.ThemNhiemVuNho(new NhiemVuNho(maNVNhoMax + 1, Page_NhiemVu.MaNV, "In Progress", txt_TenNV.Text));
            }
            else if (mode == "Sua")
                nvnd.CapNhatNhiemVuNho(new NhiemVuNho(maNVNho, Page_NhiemVu.MaNV, "In Progress", txt_TenNV.Text));
            mode = "In Progress";
            Page_DanhSachNV_1__Load(sender, e);
        }

        private void ibtn_HoanThanh_TextChanged(object sender, EventArgs e)
        {
            if (ibtn_HoanThanh.Text == "Completed")
            {
                ibtn_HoanThanh.Width = 183;
                ibtn_HoanThanh.IconChar = FontAwesome.Sharp.IconChar.Check;
                ibtn_HoanThanh.BackColor = Color.FromArgb(0, 100, 0);
            }
            else if (ibtn_HoanThanh.Text == "In Progress")
            {
                ibtn_HoanThanh.Width = 183;
                ibtn_HoanThanh.IconChar = FontAwesome.Sharp.IconChar.HourglassStart;
                ibtn_HoanThanh.BackColor = Color.FromArgb(0, 0, 255);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            mode = "Sua";
            Page_DanhSachNV_1__Load(sender, e);
        }

        private void btn_XemFile_Click(object sender, EventArgs e)
        {
            Frm_NopFile nf = new Frm_NopFile("Xem", maNVNho);
            nf.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Page_DanhSachNV.dsnv1List.Remove(this);
            Xoa.XoaNhiemVuNho(maNVNho, Page_NhiemVu.MaNV, Page_NhiemVu.MaDA);
            Page_DanhSachNV.panelMainCopy.Controls.Clear();
            for (int i = 0; i < Page_DanhSachNV.dsnv1List.Count; i++)
            {
                Page_DanhSachNV.dsnv1List[i].Location = new Point(10, 10 + (Page_DanhSachNV.dsnv1List[i].Height + 10) * i);
                Page_DanhSachNV.panelMainCopy.Controls.Add(Page_DanhSachNV.dsnv1List[i]);
            }
        }
    }
}
