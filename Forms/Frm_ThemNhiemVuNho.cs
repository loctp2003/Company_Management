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
using QuanLyDuAn.Dialogs;
using QuanLyDuAn.Pages;
using QuanLyDuAn.Dao;
using QuanLyDuAn.Models;
using System.IO;
using static System.Net.WebRequestMethods;
using QuanLyDuAn.ChucNang;

namespace QuanLyDuAn.Forms
{
    public partial class Frm_ThemNhiemVuNho : Form
    {
        DuAnDao dad = new DuAnDao();
        NhiemVuDao nvd = new NhiemVuDao();
        NhiemVuNhoDao nvnd = new NhiemVuNhoDao();
        public static Frm_ThemNhiemVuNho tnvn;
        public static Panel panelMainCopy;
        public static List<Page_PhanNhiemVuNho> pnvnList = new List<Page_PhanNhiemVuNho>();
        public static List<NhiemVuNho> nvnList = new List<NhiemVuNho>();
        int num;
        string chucNang; //DA PCNV
        public Frm_ThemNhiemVuNho(int num, string chucNang)
        {
            InitializeComponent();
            this.num = num;
            tnvn = this;
            panelMainCopy = panelMain;
            this.chucNang = chucNang;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ThemNhiemVu.tnvCopy.Show();
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btn_TaoNhiemVu_Click(object sender, EventArgs e)
        {
            Page_PhanNhiemVuNho pnvn = new Page_PhanNhiemVuNho();
            pnvnList.Insert(0, pnvn);
            panelMain.Controls.Clear();
            for (int i = 0; i < pnvnList.Count; i++)
            {
                pnvnList[i].Location = new Point(10, 10 + (pnvnList[i].Height + 10) * i);
                panelMain.Controls.Add(pnvnList[i]);
            }
        }

        private void Frm_ThemNhiemVuNho_Load(object sender, EventArgs e)
        {
            pnvnList.Clear();
        }
        byte[] changeFileToByte(string filename)
        {
            if (filename != null)
            {
                using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
                {
                    byte[] bytes = System.IO.File.ReadAllBytes(filename);
                    fs.Read(bytes, 0, System.Convert.ToInt32(fs.Length));
                    fs.Close();
                    return bytes;
                }
            }
            return null;
        }

        public static int soNVMoi = 0;
        public static int soNVNhoMoi = 0;
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (chucNang == "DA")
            {
                Page_TaoNhiemVuDuAn.panelMainCopy.Controls.Clear();
                Page_TaoNhiemVuDuAn_2_ tnvda2 = new Page_TaoNhiemVuDuAn_2_(Frm_ThemNhiemVu.txt_TenNVCopy.Text, Frm_ThemNhiemVu.cb_TenNSHCopy.Text.Trim(), Frm_ThemNhiemVu.date_NgayBatDauCopy.Value.Date.ToString().Split(' ')[0]);
                Page_TaoNhiemVuDuAn.panelList.Insert(num, tnvda2);
                for (int i = 0; i < Page_TaoNhiemVuDuAn.panelList.Count; i++)
                {
                    Control panel = (Control)Page_TaoNhiemVuDuAn.panelList[i];
                    panel.Location = new Point(10, 10 + i * (panel.Height + 10));
                    Page_TaoNhiemVuDuAn.panelMainCopy.Controls.Add(panel);
                }
                int maDA = dad.MaDuAnMax();
                int maNV = nvd.MaNhiemVuMax();
                int maNVNho = nvnd.MaNhiemVuNhoMax();
                soNVMoi++;
                string tinhTrang = DateTime.Now < Convert.ToDateTime(Frm_ThemNhiemVu.date_NgayBatDauCopy.Text) ? "In Progress" : "Not Started";
                if (Frm_ThemNhiemVu.chucNangMieuTa == "TaiLieu")
                    Page_TaoNhiemVuDuAn.nhiemVuList.Add(new NhiemVu(maNV + soNVMoi, maDA + 1, Frm_ThemNhiemVu.txt_TenNVCopy.Text, null, changeFileToByte(Frm_ThemNhiemVu.fileName), Frm_ThemNhiemVu.cb_TenNSHCopy.Text.Trim().Split('-')[0], tinhTrang, Convert.ToDateTime(Frm_ThemNhiemVu.date_NgayBatDauCopy.Text), Convert.ToDateTime(Frm_ThemNhiemVu.date_NgayKetThucCopy.Text), DateTime.Now));
                else if (Frm_ThemNhiemVu.chucNangMieuTa == "Text")
                    Page_TaoNhiemVuDuAn.nhiemVuList.Add(new NhiemVu(maNV + soNVMoi, maDA + 1, Frm_ThemNhiemVu.txt_TenNVCopy.Text, Frm_ThemNhiemVu.txt_MieuTaCopy.Text, null, Frm_ThemNhiemVu.cb_TenNSHCopy.Text.Trim().Split('-')[0], tinhTrang, Convert.ToDateTime(Frm_ThemNhiemVu.date_NgayBatDauCopy.Text), Convert.ToDateTime(Frm_ThemNhiemVu.date_NgayKetThucCopy.Text), DateTime.Now));
                for (int i = 0; i < pnvnList.Count; i++)
                {
                    if (pnvnList[i].btn_CheckCopy.Visible == false)
                    {
                        soNVNhoMoi++;
                        nvnList.Add(new NhiemVuNho(maNVNho + soNVNhoMoi, maNV + soNVMoi, "In Progress", pnvnList[i].lbl_TenNVCopy.Text));
                    }
                }
                this.Close();
            }
            else if (chucNang == "PCNV")
            {
                int maNV = nvd.MaNhiemVuMax();
                int maNVNho = nvnd.MaNhiemVuNhoMax();
                soNVMoi++;

                string tinhTrang = DateTime.Now < Convert.ToDateTime(Frm_ThemNhiemVu.date_NgayBatDauCopy.Text) ? "In Progress" : "Not Started";
                if (Frm_ThemNhiemVu.chucNangMieuTa == "TaiLieu")
                    Page_TaoNhiemVuDuAn.nhiemVuList.Add(new NhiemVu(maNV + soNVMoi, Page_PhanCongNhiemVu.MaDA, Frm_ThemNhiemVu.txt_TenNVCopy.Text, null, changeFileToByte(Frm_ThemNhiemVu.fileName), Frm_ThemNhiemVu.cb_TenNSHCopy.Text.Split('-')[0], tinhTrang, Convert.ToDateTime(Frm_ThemNhiemVu.date_NgayBatDauCopy.Text), Convert.ToDateTime(Frm_ThemNhiemVu.date_NgayKetThucCopy.Text), DateTime.Now));
                else if (Frm_ThemNhiemVu.chucNangMieuTa == "Text")
                    Page_TaoNhiemVuDuAn.nhiemVuList.Add(new NhiemVu(maNV + soNVMoi, Page_PhanCongNhiemVu.MaDA, Frm_ThemNhiemVu.txt_TenNVCopy.Text, Frm_ThemNhiemVu.txt_MieuTaCopy.Text, null, Frm_ThemNhiemVu.cb_TenNSHCopy.Text.Split('-')[0], tinhTrang, Convert.ToDateTime(Frm_ThemNhiemVu.date_NgayBatDauCopy.Text), Convert.ToDateTime(Frm_ThemNhiemVu.date_NgayKetThucCopy.Text), DateTime.Now));
                for (int i = 0; i < pnvnList.Count; i++)
                {
                    if (pnvnList[i].btn_CheckCopy.Visible == false)
                    {
                        soNVNhoMoi++;
                        nvnList.Add(new NhiemVuNho(maNVNho + soNVNhoMoi, maNV + soNVMoi, "In Progress", pnvnList[i].lbl_TenNVCopy.Text));
                    }
                }
                foreach (var nv in Page_TaoNhiemVuDuAn.nhiemVuList)
                {
                    nvd.ThemNhiemVu(nv);
                }
                foreach (var nvn in Frm_ThemNhiemVuNho.nvnList)
                {
                    nvnd.ThemNhiemVuNho(nvn);
                }
                this.Close();
            }
            else if (chucNang == "NVTG")
            {
                int maNV = nvd.MaNhiemVuMax();
                int maNVNho = nvnd.MaNhiemVuNhoMax();

                string tinhTrang = DateTime.Now < Convert.ToDateTime(Frm_ThemNhiemVu.date_NgayBatDauCopy.Text) ? "In Progress" : "Not Started";
                if (Frm_ThemNhiemVu.chucNangMieuTa == "TaiLieu")
                    nvd.ThemNhiemVu(new NhiemVu(maNV + 1, Page_DA.MaDA, Frm_ThemNhiemVu.txt_TenNVCopy.Text, null, changeFileToByte(Frm_ThemNhiemVu.fileName), Frm_ThemNhiemVu.cb_TenNSHCopy.Text.Trim().Split('-')[0], tinhTrang, Convert.ToDateTime(Frm_ThemNhiemVu.date_NgayBatDauCopy.Text), Convert.ToDateTime(Frm_ThemNhiemVu.date_NgayKetThucCopy.Text), DateTime.Now));
                else if (Frm_ThemNhiemVu.chucNangMieuTa == "Text")
                    nvd.ThemNhiemVu(new NhiemVu(maNV + 1, Page_DA.MaDA, Frm_ThemNhiemVu.txt_TenNVCopy.Text, Frm_ThemNhiemVu.txt_MieuTaCopy.Text, null, Frm_ThemNhiemVu.cb_TenNSHCopy.Text.Trim().Split('-')[0], tinhTrang, Convert.ToDateTime(Frm_ThemNhiemVu.date_NgayBatDauCopy.Text), Convert.ToDateTime(Frm_ThemNhiemVu.date_NgayKetThucCopy.Text), DateTime.Now));
                for (int i = 0; i < pnvnList.Count; i++)
                {
                    if (pnvnList[i].btn_CheckCopy.Visible == false)
                    {
                        soNVNhoMoi++;
                        nvnList.Add(new NhiemVuNho(maNVNho + soNVNhoMoi, maNV + 1, "In Progress", pnvnList[i].lbl_TenNVCopy.Text));
                    }
                }
                foreach (var nvn in nvnList)
                {
                    nvnd.ThemNhiemVuNho(nvn);
                }
                this.Close();
                var pageTrang = Page_ThongTinDuAn.panelMainCopy.Controls.OfType<Page_NhiemVuDA>().ToList();
                if (pageTrang.Any())
                {
                    var firstPageTrang = pageTrang.First();
                    Page_ThongTinDuAn.panelMainCopy.Controls.Remove(firstPageTrang);
                    Page_NhiemVuDA nvda = new Page_NhiemVuDA();
                    nvda.Dock = DockStyle.Fill;
                    Page_ThongTinDuAn.nhvda = nvda;
                    Page_ThongTinDuAn.panelMainCopy.Controls.Add(nvda);
                }
                CapNhat.CapNhatTiLeHTDuAn(Page_DA.MaDA);

            }
        }
    }
}
