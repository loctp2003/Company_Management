using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using FontAwesome.Sharp;
using QuanLyDuAn.Dao.Dao;
using QuanLyDuAn.Forms;
using QuanLyDuAn.Pages;

namespace QuanLyDuAn
{
    public partial class Frm_Main : Form
    {
        public static BunifuPictureBox pc_AnhMainCopy;
        public static Panel panelMainCopy;
        private NhanVienDao nvd = new NhanVienDao();
        public static string MaNhanVien = "";
        public Frm_Main()
        {
            InitializeComponent();
            pc_AnhMainCopy = pc_AnhMain;
            panelMainCopy = panelMain;
            Page_Luong pl = new Page_Luong();
            pttcn = new Page_ThongTinCaNhan("Frm_Main");
            dsnv = new Page_NhanVien();
            pnv = new Page_NhiemVu("NV");
            pda = new Page_DA();
            ptd = new Page_TuyenDung();
            ppcda = new Page_PhanCongNhiemVu();
            pcc = new Page_ChamCong();
        }
        private static Frm_Main frmm = new Frm_Main();
        private IconButton currIconButton;
        public static Page_Luong pl = new Page_Luong();
        public static Page_ThongTinCaNhan pttcn = new Page_ThongTinCaNhan("Frm_Main");
        public static Page_NhanVien dsnv = new Page_NhanVien();
        public static Page_NhiemVu pnv = new Page_NhiemVu("NV");
        public static Page_DA pda = new Page_DA();
        public static Page_TuyenDung ptd = new Page_TuyenDung();
        public static Page_PhanCongNhiemVu ppcda = new Page_PhanCongNhiemVu();
        public static Page_ChamCong pcc = new Page_ChamCong();
        private void iconButton4_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else 
                WindowState = FormWindowState.Normal;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        System.Drawing.Image ConvertBinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            iconButtonBar.IconChar = FontAwesome.Sharp.IconChar.Bars;
            InitialSubMenu();
            panelChevronDown.Visible = false;
            string MaPB = "";
            var reader = nvd.DocDuDieuNhanVienTuTK(Frm_DangNhap.LoaiTaiKhoan, Frm_DangNhap.txt_UsernameCopy.Text, Frm_DangNhap.txt_PasswordCopy.Text);
            if (reader.Read())
            {
                byte[] b = null;
                if (reader["Anh"].GetType() != typeof(DBNull))
                {
                    b = (byte[])reader["Anh"];
                    pc_AnhMain.Image = ConvertBinaryToImage(b);
                }
                MaNhanVien = reader["MaNV"].ToString().Trim();
                MaPB = reader["MaPB"].ToString().Trim();
            }
            if (Frm_DangNhap.LoaiTaiKhoan == "TkGiamDoc")
            {
                panelPhanCongDuAnMain.Visible = true;
                panelNhiemVuMain.Visible = false;
                //panelPhanCongNhiemVuMain.Visible = false;
                panelTienLuongMain.Visible = true;
                panelNhanSuMain.Visible = true;
                panelTienLuongMain.Visible = true;
                panelPhanCongDuAnMain.Visible = true;
            }
            else
            {
                panelPhanCongDuAnMain.Visible = false;
                panelPhanCongDuAn.Visible = false;
                panelNhiemVuMain.Visible = true;

                panelNhanSuMain.Visible = false;
                panelTienLuongMain.Visible = false;
                panelPhanCongDuAnMain.Visible = false;
                if (MaPB == "PB003") panelNhanSuMain.Visible = true;
                if (MaPB == "PB001") panelTienLuongMain.Visible = true;
                if (MaPB == "PB009") panelPhanCongDuAnMain.Visible = true;
                //panelPhanCongNhiemVuMain.Visible = true;
            }
            nvd.dao.conn.Close();
        }
        private void InitialSubMenu()
        {
            panelPhanCongDuAn.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                if (panelPhanCongDuAn.Visible == true)
                    panelPhanCongDuAn.Visible = false;
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;

        }
        private void ClickToChangeColor(IconButton btn)
        {
            if (btn.ForeColor == Color.Transparent)
                btn.ForeColor = Color.RoyalBlue;
            else btn.ForeColor = Color.Transparent;

            if (btn.BackColor == Color.White)
                btn.BackColor = Color.RoyalBlue;
            else btn.BackColor = Color.White;

            if (btn.IconColor == Color.White)
                btn.IconColor = Color.RoyalBlue;
            else btn.IconColor = Color.White;
        }

        
        private void btn_TienLuong_Click(object sender, EventArgs e)
        {
            if (currIconButton != null)
                ClickToChangeColor(currIconButton);
            currIconButton = btn_TienLuong;
            ClickToChangeColor(btn_TienLuong);
            
            if (!panelMain.Controls.Contains(pl))
            {
                panelMain.Controls.Clear();
                pl.Dock = DockStyle.Fill;
                panelMain.Controls.Add(pl);
                panelChevronDown.BringToFront();  
            }   
        }
        /*
        private void btn_TuyenDung_Click(object sender, EventArgs e)
        {
            if (currIconButton != null)
                ClickToChangeColor(currIconButton);
            currIconButton = btn_TuyenDung;
            ClickToChangeColor(btn_TuyenDung);

            if (!panelMain.Controls.Contains(ptd))
            {
                panelMain.Controls.Clear();
                ptd.Dock = DockStyle.Fill;
                panelMain.Controls.Add(ptd);  
            }
        }
        */
        private void iconButton4_Click_1(object sender, EventArgs e)
        {
            panelChevronDown.Visible = !panelChevronDown.Visible;
                
        }

        private void iconButtonBar_Click(object sender, EventArgs e)
        {

        }

        private void btn_NhanSu_Click(object sender, EventArgs e)
        {
            if (currIconButton != null)
                ClickToChangeColor(currIconButton);
            currIconButton = btn_NhanSu;
            ClickToChangeColor(btn_NhanSu);

            if (!panelMain.Controls.Contains(dsnv))
            {
                panelMain.Controls.Clear();
                dsnv.Dock = DockStyle.Fill;
                panelMain.Controls.Add(dsnv);
            }

        }

        private void btn_ChamCong_Click(object sender, EventArgs e)
        {
            if (currIconButton != null)
                ClickToChangeColor(currIconButton);
            currIconButton = btn_ChamCong;
            ClickToChangeColor(btn_ChamCong);

            if (!panelMain.Controls.Contains(pcc))
            {
                panelMain.Controls.Clear();
                pcc.Dock = DockStyle.Fill;
                panelMain.Controls.Add(pcc);
            }
        }

        private void btn_PhanCongDuAn_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPhanCongDuAn);
            if (currIconButton != null)
                ClickToChangeColor(currIconButton);
            currIconButton = btn_PhanCongDuAn;
            ClickToChangeColor(btn_PhanCongDuAn);
        }
        private void btn_NhiemVuNV_Click(object sender, EventArgs e)
        {
            if (currIconButton != null)
                ClickToChangeColor(currIconButton);
            currIconButton = btn_NhiemVuNV;
            ClickToChangeColor(btn_NhiemVuNV);

            if (!panelMain.Controls.Contains(pnv))
            {
                panelMain.Controls.Clear();
                pnv.Dock = DockStyle.Fill;
                panelMain.Controls.Add(pnv);

            }
        }
        /*
        private void btn_PhanCongNhiemVu_Click(object sender, EventArgs e)
        {

            if (currIconButton != null)
                ClickToChangeColor(currIconButton);
            currIconButton = btn_PhanCongNhiemVu;
            ClickToChangeColor(btn_PhanCongNhiemVu);

            if (!panelMain.Controls.Contains(ppcda))
            {
                panelMain.Controls.Clear();
                ppcda.Dock = DockStyle.Fill;
                panelMain.Controls.Add(ppcda);

            }
        }*/
        private void btn_TTNV_Click(object sender, EventArgs e)
        {
            if (currIconButton != null)
                ClickToChangeColor(currIconButton);
            currIconButton = btn_TTNV;
            ClickToChangeColor(btn_TTNV);

            if (!panelMain.Controls.Contains(pttcn))
            {
                panelMain.Controls.Clear();
                pttcn.Dock = DockStyle.Fill;
                panelMain.Controls.Add(pttcn);

            }
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox2_Click(object sender, EventArgs e)
        {
            
            if (!panelMain.Controls.Contains(pttcn))
            {
                panelMain.Controls.Clear();
                pttcn.Dock = DockStyle.Fill;
                panelMain.Controls.Add(pttcn);
                
            }
          
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_DangNhap f = new Frm_DangNhap();
            f.Show();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
           
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void iconButton19_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_CaiDat_Click(object sender, EventArgs e)
        {

        }

        private void btn_NhiemVu_Click(object sender, EventArgs e)
        {
            panelPhanCongDuAn.Visible = false;

            if (!panelMain.Controls.Contains(pnv))
            {
                panelMain.Controls.Clear();
                pnv.Dock = DockStyle.Fill;
                panelMain.Controls.Add(pnv);

            }
        }

        private void btn_DuAn_Click(object sender, EventArgs e)
        {
            panelPhanCongDuAn.Visible = false;

            if (!panelMain.Controls.Contains(pda))
            {
                panelMain.Controls.Clear();
                pda.Dock = DockStyle.Fill;
                panelMain.Controls.Add(pda);

            }
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        
    }
}
