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
using QuanLyDuAn.Pages;
using QuanLyDuAn.Models;
using System.IO;
using QuanLyDuAn.Dialogs;
using QuanLyDuAn.Forms;
using Bunifu.UI.WinForms;
using QuanLyDuAn.Dao.Dao;

namespace QuanLyDuAn.Dialogs
{
    public partial class Frm_ThemNhiemVu : Form
    {
        PhongBanDao pbd = new PhongBanDao();
        NhiemVuDao nhvd = new NhiemVuDao();
        NhanVienDao nvd = new NhanVienDao();
        DuAnDao dad = new DuAnDao();
        public static Frm_ThemNhiemVu tnvCopy;
        public static BunifuTextBox txt_TenNVCopy;
        public static ComboBox cb_TenNSHCopy;
        public static BunifuTextBox txt_MieuTaCopy;
        public static BunifuDatePicker date_NgayBatDauCopy;
        public static BunifuDatePicker date_NgayKetThucCopy;
        public static string chucNangMieuTa;
        string maPB;
        string chucNang; // PB All
        public Frm_ThemNhiemVu(string maPB,string chucNang)
        {
            InitializeComponent();
            this.maPB = maPB;
            this.chucNang = chucNang;
            tnvCopy = this;
            txt_TenNVCopy = txt_TenNV;
            cb_TenNSHCopy = cb_TenNSH;
            txt_MieuTaCopy = txt_MieuTa;
            date_NgayBatDauCopy = date_NgayBatDau;
            date_NgayKetThucCopy = date_NgayKetThuc;  
        }
        public Frm_ThemNhiemVu(string chucNang)
        {
            InitializeComponent();
            this.chucNang = chucNang;
            tnvCopy = this;
            txt_TenNVCopy = txt_TenNV;
            cb_TenNSHCopy = cb_TenNSH;
            txt_MieuTaCopy = txt_MieuTa;
            date_NgayBatDauCopy = date_NgayBatDau;
            date_NgayKetThucCopy = date_NgayKetThuc;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Bars;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void btn_TiepTuc_Click(object sender, EventArgs e)
        {
            int num = 0;
            for (int i = 0; i < Page_TaoNhiemVuDuAn.panelList.Count; i++)
            {
                if ((Control)Page_TaoNhiemVuDuAn.panelList[i] == Page_TaoNhiemVuDuAn_1_.tnvda1)
                {
                    num = i + 1;
                    break;
                }
            }
            try
            {
                if (chucNangMieuTa == "TaiLieu")
                {
                    if (txt_File.Text == "No File Choosen" || txt_File.Text == "")
                    {
                        throw new Exception("Thiếu Nhập Miêu Tả");
                    }
                }
                else if (chucNangMieuTa == "Text")
                {
                    if (txt_MieuTa.Text == "")
                    {
                        throw new Exception("Thiếu Nhập Miêu Tả");
                    }
                }
                Frm_ThemNhiemVuNho tnvn = new Frm_ThemNhiemVuNho(num, chucNang);
                tnvn.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public static string fileName = "";
        private void btn_ChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Word File (.docx ,.doc)|*.docx;*.doc|All files (*.*)|*.*";
            dlg.ShowDialog();
            if (dlg.FileName != null)
            {
                fileName = dlg.FileName;
                string[] s = fileName.Split('\\');
                txt_File.Text = s[s.Length - 1];
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SortComboBoxItems(ComboBox comboBox)
        {
            List<string> itemsList = new List<string>();
            foreach (string item in comboBox.Items)
            {
                itemsList.Add(item);
            }
            itemsList.Sort();

            comboBox.Items.Clear();

            foreach (string item in itemsList)
            {
                comboBox.Items.Add(item);
            }
        }

        private void Frm_ThemNhiemVu_Load(object sender, EventArgs e)
        {
            chucNangMieuTa = "TaiLieu";
            if (chucNang == "DA")
            {
                var reader = nvd.DocDuDieuNhanVienTuMaPB(maPB);
                while (reader.Read())
                {
                    cb_TenNSH.Items.Add("  " + reader["MaNV"].ToString().Trim() + "-" + reader["HoTen"].ToString().Trim());
                }
                nvd.dao.conn.Close();
            }
            /*
            else if (chucNang == "PCNV")
            {
                var reader = nvd.DocDuDieuNhanVienTuMaNV(Page_NhanVienDA.MaNV);
                while (reader.Read())
                {
                    cb_TenNSH.Items.Add("  " + reader["MaNV"].ToString().Trim() + "-" + reader["HoTen"].ToString().Trim());
                }
                nvd.dao.conn.Close();
            }*/
            else if (chucNang == "NVTG")
            {
                foreach (string maPB in Page_NhanVienDA.maPBSet)
                {
                    var reader = nvd.DocDuDieuNhanVienTuMaPB(maPB);
                    while (reader.Read())
                    {
                        cb_TenNSH.Items.Add("  " + reader["MaNV"].ToString().Trim() + "-" + reader["HoTen"].ToString().Trim());
                    }
                    nvd.dao.conn.Close();
                }
                SortComboBoxItems(cb_TenNSH);
            }
            rb_TaiLieu.Checked = true;
            btn_ChonFile.Enabled = true;
            txt_File.Enabled = true;
            txt_MieuTa.Enabled = false;
        }

        private void rb_TaiLieu_CheckedChanged(object sender, EventArgs e)
        {
            btn_ChonFile.Enabled = rb_TaiLieu.Checked;
            txt_File.Enabled = rb_TaiLieu.Checked;
            if (rb_TaiLieu.Checked) chucNangMieuTa = "TaiLieu";
        }

        private void rb_Text_CheckedChanged(object sender, EventArgs e)
        {
            txt_MieuTa.Enabled = rb_Text.Checked;
            if (rb_Text.Checked) chucNangMieuTa = "Text";
        }

        private void date_NgayBatDau_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
