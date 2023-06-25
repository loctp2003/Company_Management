using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using QuanLyDuAn.Dao.Dao;
using QuanLyDuAn.Forms;

namespace QuanLyDuAn.Pages
{
    public partial class Page_TaoThongTinDuAn : UserControl
    {
        NhanVienDao nvd = new NhanVienDao();
        public static BunifuTextBox txt_TenDuAnCopy;
        public static string fileName = "";
        public static BunifuTextBox txt_MieuTaCopy;
        public static ComboBox cb_TenNguoiQuanLyCopy;
        public static BunifuDatePicker date_NgayBatDauCopy;
        public static BunifuDatePicker date_NgayKetThucCopy;
        public static string chucNangMieuTa; // TaiLieu Text
        public Page_TaoThongTinDuAn()
        {
            InitializeComponent();
            txt_TenDuAnCopy = txt_TenDuAn;
            txt_MieuTaCopy = txt_MieuTa;
            cb_TenNguoiQuanLyCopy = cb_TenNguoiQuanLy;
            date_NgayBatDauCopy = date_NgayBatDau;
            date_NgayKetThucCopy = date_NgayKetThuc;
        }

        private void TaoThongTinDuAn_Load(object sender, EventArgs e)
        {
            var reader = nvd.DocDuLieuNhanVienQLDA();
            cb_TenNguoiQuanLy.Items.Clear();
            while (reader.Read())
            {
                cb_TenNguoiQuanLy.Items.Add("  " + reader["MaNV"].ToString().Trim() + "-" + reader["HoTen"].ToString().Trim());
            }

            rb_TaiLieu.Checked = true;
            btn_ChonFile.Enabled = true;
            txt_File.Enabled = true;
            txt_MieuTa.Enabled = false;

            chucNangMieuTa = "TaiLieu";
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

        private void btn_TiepTuc_Click(object sender, EventArgs e)
        {
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
                Frm_ThemDA.bunifuSeparator1Copy.Location = new Point(Frm_ThemDA.btn_PhongBanCopy.Location.X, Frm_ThemDA.bunifuSeparator1Copy.Location.Y);
                Frm_ThemDA.bunifuSeparator1Copy.Width = Frm_ThemDA.btn_PhongBanCopy.Width;
                if (!Frm_ThemDA.panelMainCopy.Controls.Contains(Frm_ThemDA.pbda))
                {
                    Frm_ThemDA.panelMainCopy.Controls.Clear();
                    Frm_ThemDA.pbda.Dock = DockStyle.Fill;
                    Frm_ThemDA.panelMainCopy.Controls.Add(Frm_ThemDA.pbda);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
