using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using Microsoft.Office.Interop.Word;
using QuanLyDuAn.Dao;

namespace QuanLyDuAn.Pages
{
    public partial class Page_ThongTinDuAn : UserControl
    {
        DuAnDao dad = new DuAnDao();
        public static Label lbl_TenDACopy;
        public static BunifuLabel lbl_NguoiSoHuuCopy;
        public static BunifuLabel lbl_TinhTrangCopy;
        public static Panel panelMainCopy;
        public Page_ThongTinDuAn()
        {
            InitializeComponent();
            lbl_TenDACopy = lbl_TenDA;
            lbl_NguoiSoHuuCopy = lbl_NguoiSoHuu;
            lbl_TinhTrangCopy = lbl_TinhTrang;
            panelMainCopy = panelMain;
            ctda = new Page_ChiTiet("DA");
            nvda = new Page_NhanVienDA("DA", Page_DA.MaDA);
            nhvda = new Page_NhiemVuDA();
        }
        
        
        private void Page_ThongTinDuAn_Load(object sender, EventArgs e)
        {
            lbl_TinhTrang.Text = "";
            var reader = dad.DocDuDieuDuAnTuMaDA(Page_DA.MaDA);
            if (reader.Read())
            {
                lbl_TenDA.Text = reader["TenDuAn"].ToString().Trim();
                lbl_NguoiSoHuu.Text = reader["HoTen"].ToString().Trim();
                lbl_TinhTrang.Text = reader["TTrang"].ToString().Trim();
            }
            dad.dao.conn.Close();
            if (!panelMain.Controls.Contains(ctda))
            {
                panelMain.Controls.Clear();
                ctda.Dock = DockStyle.Fill;
                panelMain.Controls.Add(ctda);

            }
            if (lbl_TinhTrang.Text == "Completed")
                lbl_TinhTrang.BackColor = Color.FromArgb(0, 100, 0);
            else if (lbl_TinhTrang.Text == "On Hold")
                lbl_TinhTrang.BackColor = Color.FromArgb(255, 165, 0);
            else if (lbl_TinhTrang.Text == "In Progress")
                lbl_TinhTrang.BackColor = Color.FromArgb(0, 0, 255);
            else if (lbl_TinhTrang.Text == "Cancelled")
                lbl_TinhTrang.BackColor = Color.Red;
            else if (lbl_TinhTrang.Text == "Not Started")
                lbl_TinhTrang.BackColor = Color.DarkGray;
            lbl_TinhTrang.Location = new System.Drawing.Point(lbl_TenDA.Location.X + lbl_TenDA.Width + 20, lbl_TinhTrang.Location.Y - 2);
        }
        public static Page_ChiTiet ctda = new Page_ChiTiet("DA");
        public static Page_NhanVienDA nvda = new Page_NhanVienDA("DA", Page_DA.MaDA);
        public static Page_NhiemVuDA nhvda = new Page_NhiemVuDA();
        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            bunifuSeparator1.Location = new System.Drawing.Point(btn_NhanVien.Location.X, bunifuSeparator1.Location.Y);
            if (!panelMain.Controls.Contains(nvda))
            {
                panelMain.Controls.Clear();
                nvda.Dock = DockStyle.Fill;
                panelMain.Controls.Add(nvda);
            }
        }
       
        private void btn_ChiTietDA_Click(object sender, EventArgs e)
        {
            bunifuSeparator1.Location = new System.Drawing.Point(btn_ChiTietDA.Location.X, bunifuSeparator1.Location.Y);
            if (!panelMain.Controls.Contains(ctda))
            {
                panelMain.Controls.Clear();
                ctda.Dock = DockStyle.Fill;
                panelMain.Controls.Add(ctda);

            }
        }

        private void btn_NhiemVu_Click(object sender, EventArgs e)
        {
            bunifuSeparator1.Location = new System.Drawing.Point(btn_NhiemVu.Location.X, bunifuSeparator1.Location.Y);
            if (!panelMain.Controls.Contains(nhvda))
            {
                panelMain.Controls.Clear();
                nhvda.Dock = DockStyle.Fill;
                panelMain.Controls.Add(nhvda);

            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {

            if (!Frm_Main.panelMainCopy.Controls.Contains(Page_DA.pdaCopy))
            {
                Frm_Main.panelMainCopy.Controls.Clear();
                Page_DA.pdaCopy.Dock = DockStyle.Fill;
                Frm_Main.panelMainCopy.Controls.Add(Page_DA.pdaCopy);

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_TenDA_Click(object sender, EventArgs e)
        {

        }

        private void lbl_TinhTrang_TextChanged(object sender, EventArgs e)
        {
            if (lbl_TinhTrang.Text == "Completed")
                lbl_TinhTrang.BackColor = Color.FromArgb(0, 100, 0);
            else if (lbl_TinhTrang.Text == "On Hold")
                lbl_TinhTrang.BackColor = Color.FromArgb(255, 165, 0);
            else if (lbl_TinhTrang.Text == "In Progress")
                lbl_TinhTrang.BackColor = Color.FromArgb(0, 0, 255);
            else if (lbl_TinhTrang.Text == "Cancelled")
                lbl_TinhTrang.BackColor = Color.Red;
            else if (lbl_TinhTrang.Text == "Not Started")
                lbl_TinhTrang.BackColor = Color.DarkGray;
        }
    }
}
