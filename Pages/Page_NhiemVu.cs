using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using FontAwesome.Sharp;
using Nest;
using QuanLyDuAn.ChucNang;
using QuanLyDuAn.Dao;
using QuanLyDuAn.Dao.Dao;
using QuanLyDuAn.Dialogs;
using QuanLyDuAn.Forms;
using QuanLyDuAn.Models;
using QuanLyDuAn.Tools;

namespace QuanLyDuAn.Pages
{
    public partial class Page_NhiemVu : UserControl
    {
        NhiemVuDao nhvd = new NhiemVuDao();
        NhanVienDao nvd = new NhanVienDao();
        public static Page_NhiemVu pnvCopy;
        public static int MaNV;
        public static string MaNSH;
        public static int MaDA;
        public static int trangCopy;
        public static int soNVMoiTrangCopy;
        public static Label lbl_SoNVCopy;
        public static int soNVCopy;
        public static Panel panelEllipsisCopy;
        public static BunifuTextBox txt_SearchCopy;
        public static BunifuShapes bs_EllipsisCopy;
        public static List<string> MaNVListCopy;
        public static BunifuDataGridView dataGridViewMainCopy;
        int soNV = 0;
        int countSelected = 0;
        string mode;
        public Page_NhiemVu(string mode)
        {
            InitializeComponent();
            dataGridViewMainCopy = dataGridViewMain;
            pnvCopy = this;
            bs_EllipsisCopy = bs_Ellipsis;
            panelEllipsisCopy = panelEllipsis;
            txt_SearchCopy = txt_Search;
            lbl_SoNVCopy = lbl_SoNV;
            soNVCopy = soNV;
            MaNVListCopy = MaNVList;
            lbl_SoNV.Text = "0";
            countSelected = 0;
            this.mode = mode;
        }
        List<string> MaNVList = new List<string>();
        private void HienThiDSNhiemVuTheoTrang()
        {
            if (mode == "NV")
            {
                var readerTK = nvd.DocDuDieuNhanVienTuTK(Frm_DangNhap.LoaiTaiKhoan, Frm_DangNhap.txt_UsernameCopy.Text, Frm_DangNhap.txt_PasswordCopy.Text);
                string MaNV = "";
                if (readerTK.Read())
                {
                    MaNV = readerTK["MaNV"].ToString().Trim();
                }
                nvd.dao.conn.Close();
                if (Frm_DangNhap.LoaiTaiKhoan == "TkGiamDoc")
                {
                    soNV = nhvd.DemNhiemVu(txt_Search.Text.Trim());
                    lbl_SoNV.Text = soNV.ToString() + " Nhiệm Vụ";
                }
                else
                {
                    soNV = nhvd.DemNhiemVuTheoMaNV(txt_Search.Text.Trim(), MaNV);
                    lbl_SoNV.Text = soNV.ToString() + " Nhiệm Vụ"; 
                } 
            }
            else if (mode == "PCNV")
            {
                soNV = nhvd.DemNhiemVuTheoMaNV(txt_Search.Text.Trim(), Page_NhanVienDA.MaNV);
                lbl_SoNV.Text = soNV.ToString() + " Nhiệm Vụ";
            }
            HienDSTheoTrang(HienThiDSNhiemVu);
        }
        private void HienThiDSNhiemVu()
        {
            if (mode == "NV")
            {
                var readerTK = nvd.DocDuDieuNhanVienTuTK(Frm_DangNhap.LoaiTaiKhoan, Frm_DangNhap.txt_UsernameCopy.Text, Frm_DangNhap.txt_PasswordCopy.Text);
                string MaNV = "";
                if (readerTK.Read())
                {
                    MaNV = readerTK["MaNV"].ToString().Trim();
                }
                nvd.dao.conn.Close();
                SqlDataReader reader;
                if (Frm_DangNhap.LoaiTaiKhoan == "TkGiamDoc")
                {
                    reader = nhvd.DanhSachNhiemVu(txt_Search.Text.Trim(), currPTrang.trang, currPTrang.soDongMoiTrang);
                }
                else
                {
                    reader = nhvd.DocDuDieuNhiemVuTuMaNV(txt_Search.Text.Trim(), MaNV, currPTrang.trang, currPTrang.soDongMoiTrang);
                }

                dataGridViewMain.Rows.Clear();
                while (reader.Read())
                {
                    TimeSpan soNgayToanBo = Convert.ToDateTime(reader["NKetThuc"].ToString().Trim()) - Convert.ToDateTime(reader["NBatDau"].ToString().Trim());
                    TimeSpan soNgayHienTai = DateTime.Now - Convert.ToDateTime(reader["NBatDau"].ToString().Trim());
                    if (soNgayHienTai.Days < 0)
                        soNgayHienTai = DateTime.Now - DateTime.Now;
                    if (soNgayHienTai.Days > soNgayToanBo.Days)
                        soNgayHienTai = soNgayToanBo;
                    int tiLeHT = reader["TiLeHT"].ToString().Trim() == "0" ? 0 : Convert.ToInt32(reader["TiLeHT"].ToString().Trim());
                    object[] ob = new object[] { false, reader["TenDuAn"].ToString().Trim(), reader["MaNhiemVu"].ToString().Trim(), reader["TenNhiemVu"].ToString().Trim(), reader["Anh"], reader["MaNV"].ToString().Trim(), reader["HoTen"].ToString().Trim(), reader["TTrang"].ToString().Trim(), "(" + soNgayHienTai.Days.ToString() + "/" + soNgayToanBo.Days.ToString() + ")",tiLeHT , reader["MaDA"].ToString().Trim() };
                    dataGridViewMain.Rows.Add(ob);
                }
                nhvd.dao.conn.Close();
            }
            else if (mode == "PCNV")
            {
                soNV = nhvd.DemNhiemVuTheoMaNV(txt_Search.Text.Trim(), Page_NhanVienDA.MaNV);
                lbl_SoNV.Text = soNV.ToString() + " Nhiệm Vụ";
                var reader = nhvd.DocDuDieuNhiemVuTuMaNV(txt_Search.Text.Trim(), Page_NhanVienDA.MaNV, currPTrang.trang, currPTrang.soDongMoiTrang);
                
                dataGridViewMain.Rows.Clear();
                while (reader.Read())
                {
                    TimeSpan soNgayToanBo = Convert.ToDateTime(reader["NKetThuc"].ToString().Trim()) - Convert.ToDateTime(reader["NBatDau"].ToString().Trim());
                    TimeSpan soNgayHienTai = DateTime.Now - Convert.ToDateTime(reader["NBatDau"].ToString().Trim());
                    if (soNgayHienTai.Days < 0)
                        soNgayHienTai = DateTime.Now - DateTime.Now;
                    if (soNgayHienTai.Days > soNgayToanBo.Days)
                        soNgayHienTai = soNgayToanBo;
                    int tiLeHT = reader["TiLeHT"].ToString().Trim() == "0" ? 0 : Convert.ToInt32(reader["TiLeHT"].ToString().Trim());
                    object[] ob = new object[] { false, reader["TenDuAn"].ToString().Trim(), reader["MaNhiemVu"].ToString().Trim(), reader["TenNhiemVu"].ToString().Trim(), reader["Anh"], reader["MaNV"].ToString().Trim(), reader["HoTen"].ToString().Trim(), reader["TTrang"].ToString().Trim(), "(" + soNgayHienTai.Days.ToString() + "/" + soNgayToanBo.Days.ToString() + ")", tiLeHT, reader["MaDA"].ToString().Trim() };
                    dataGridViewMain.Rows.Add(ob);
                }
                nhvd.dao.conn.Close();
            }
        }
        private void HienThiDSTheoTimKiem()
        {
            string nhanVien = cb_NhanVien.Text.Trim();
            if (nhanVien == "Nhân Viên (Tất Cả)" && cb_TinhTrang.Text == "  Tình Trạng (Tất Cả)")
            {
                HienThiDSNhiemVuTheoTrang();
            }
            else if (nhanVien == "Nhân Viên (Tất Cả)")
            {
                HienThiDSTheoTinhTrangTheoTrang();
            }
            else
            {
                HienThiDSTheoTinhTrangVaNhanVienTheoTrang();
            }
        }
        private void HienThiDSTheoTinhTrangTheoTrang()
        {
            soNV = nhvd.DemNhiemVuTheoTinhTrang(cb_TinhTrang.Text.Trim(), txt_Search.Text.Trim());
            lbl_SoNV.Text = soNV.ToString() + " Nhiệm Vụ";
            HienDSTheoTrang(HienThiDSTheoTinhTrang);
        }
        private void HienThiDSTheoTinhTrang()
        {
            var reader = nhvd.DanhSachNhiemVuTheoTinhTrang(cb_TinhTrang.Text.Trim(), txt_Search.Text.Trim(), currPTrang.trang, currPTrang.soDongMoiTrang);
            dataGridViewMain.Rows.Clear();
            while (reader.Read())
            {
                TimeSpan soNgayToanBo = Convert.ToDateTime(reader["NKetThuc"].ToString().Trim()) - Convert.ToDateTime(reader["NBatDau"].ToString().Trim());
                TimeSpan soNgayHienTai = DateTime.Now - Convert.ToDateTime(reader["NBatDau"].ToString().Trim());
                if (soNgayHienTai.Days < 0)
                    soNgayHienTai = DateTime.Now - DateTime.Now;
                if (soNgayHienTai.Days > soNgayToanBo.Days)
                    soNgayHienTai = soNgayToanBo;
                int tiLeHT = reader["TiLeHT"].ToString().Trim() == "0" ? 0 : Convert.ToInt32(reader["TiLeHT"].ToString().Trim());
                object[] ob = new object[] { false, reader["TenDuAn"].ToString().Trim(), reader["MaNhiemVu"].ToString().Trim(), reader["TenNhiemVu"].ToString().Trim(), reader["Anh"], reader["MaNV"].ToString().Trim(), reader["HoTen"].ToString().Trim(), reader["TTrang"].ToString().Trim(), "(" + soNgayHienTai.Days.ToString() + "/" + soNgayToanBo.Days.ToString() + ")", tiLeHT, reader["MaDA"].ToString().Trim() };
                dataGridViewMain.Rows.Add(ob);
            }
            nhvd.dao.conn.Close();
        }
        private void HienThiDSTheoTinhTrangVaNhanVienTheoTrang()
        {
            soNV = nhvd.DemNhiemVuTheoTinhTrangVaNhanVien(cb_TinhTrang.Text.Trim(), cb_NhanVien.Text.Trim().Split('-')[0], txt_Search.Text.Trim());
            lbl_SoNV.Text = soNV.ToString() + " Nhiệm Vụ";
            HienDSTheoTrang(HienThiDSTheoTinhTrangVaNhanVien);
        }
        private void HienThiDSTheoTinhTrangVaNhanVien()
        {
            var reader = nhvd.DanhSachNhiemVuTheoTinhTrangVaNhanVien(cb_TinhTrang.Text.Trim(), cb_NhanVien.Text.Trim().Split('-')[0], txt_Search.Text.Trim(), currPTrang.trang, currPTrang.soDongMoiTrang);
            dataGridViewMain.Rows.Clear();
            while (reader.Read())
            {
                TimeSpan soNgayToanBo = Convert.ToDateTime(reader["NKetThuc"].ToString().Trim()) - Convert.ToDateTime(reader["NBatDau"].ToString().Trim());
                TimeSpan soNgayHienTai = DateTime.Now - Convert.ToDateTime(reader["NBatDau"].ToString().Trim());
                if (soNgayHienTai.Days < 0)
                    soNgayHienTai = DateTime.Now - DateTime.Now;
                if (soNgayHienTai.Days > soNgayToanBo.Days)
                    soNgayHienTai = soNgayToanBo;
                int tiLeHT = reader["TiLeHT"].ToString().Trim() == "0" ? 0 : Convert.ToInt32(reader["TiLeHT"].ToString().Trim());
                object[] ob = new object[] { false, reader["TenDuAn"].ToString().Trim(), reader["MaNhiemVu"].ToString().Trim(), reader["TenNhiemVu"].ToString().Trim(), reader["Anh"], reader["MaNV"].ToString().Trim(), reader["HoTen"].ToString().Trim(), reader["TTrang"].ToString().Trim(), "(" + soNgayHienTai.Days.ToString() + "/" + soNgayToanBo.Days.ToString() + ")", tiLeHT, reader["MaDA"].ToString().Trim() };
                dataGridViewMain.Rows.Add(ob);
            }
            nhvd.dao.conn.Close();
        }
        private void AnEllipsis()
        {
            panelEllipsis.Visible = false;
            bs_Ellipsis.Visible = false;
        }
        private void HienEllipsis()
        {
            panelEllipsis.Visible = true;
            bs_Ellipsis.Visible = true;
        }
        Page_Trang currPTrang;
        private void HienDSTheoTrang(HienThi hienthi)
        {
            var pageTrang = panel1.Controls.OfType<Page_Trang>().ToList();
            if (pageTrang.Any())
            {
                var firstPageTrang = pageTrang.First();
                panel1.Controls.Remove(firstPageTrang);
            }
           
            Page_Trang ptrang = new Page_Trang(hienthi, (soNV/10) + 1, 10);
            currPTrang = ptrang;
            ptrang.Location = new Point(971, 725);
            panel1.Controls.Add(ptrang);
            ptrang.btnList.Clear();
            hienthi();
            for (int i = 1; i <= ptrang.soTrang; i++)
            {
                IconButton btn = new IconButton();
                btn.Text = i.ToString();
                btn.Font = new Font(new FontFamily("Segoe UI Semibold"), 11, FontStyle.Regular);
                btn.ForeColor = Color.FromArgb(64, 64, 64);
                btn.BackColor = Color.WhiteSmoke;
                btn.Size = new Size(45, 45);
                btn.FlatAppearance.BorderSize = 1;
                btn.Click += new EventHandler((sender, e) =>
                {
                    ptrang.anMauTrangTruoc(ptrang.currButtonPage);
                    currPTrang.trang = Convert.ToInt32(btn.Text);
                    ptrang.HienThiCacTrang();
                    Page_Trang.btn_PrevCopy.Enabled = currPTrang.trang == 1 ? false : true;
                    Page_Trang.btn_NextCopy.Enabled = currPTrang.trang == ptrang.soTrang ? false : true;
                    hienthi();
                    ptrang.currButtonPage = btn;
                    ptrang.hienThiMauTrangHienTai(ptrang.currButtonPage);
                });
                ptrang.btnList.Add(btn);
            }
            ptrang.hienThiMauTrangHienTai(ptrang.btnList[0]);
            ptrang.HienThiCacTrang();
        }
        private void Page_NhiemVu_Load(object senderLoad, EventArgs eLoad)
        {
            DataGridViewBadgeColumn c = new DataGridViewBadgeColumn();
            c.HeaderText = "Tình Trạng";
            c.MinimumWidth = 210;
            dataGridViewMain.Columns.Insert(7, c);
            c.DataPropertyName = "TTrang";

            dataGridViewMain.RowTemplate.Height = 60;
            dataGridViewMain.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 192);
            dataGridViewMain.DefaultCellStyle.SelectionForeColor = Color.FromArgb(64, 64, 192);
            dataGridViewMain.ColumnHeadersHeight = 50;
            
            lbl_SoNV.Text = soNV.ToString() + " Nhiệm Vụ";
            btn_Them.IconChar = IconChar.Plus;
            btn_Xoa.IconChar = IconChar.Minus;
            if (Frm_DangNhap.LoaiTaiKhoan != "TkGiamDoc")
            {
                btn_XoaNV.Visible = false;
                btn_ThongTin.Visible = true;
                panelEllipsis.Height = btn_ThongTin.Height;
                btn_Them.Visible = false;
                btn_Xoa.Visible = false;
                btn_Luu.Location = btn_Them.Location;
                btn_In.Location = btn_Xoa.Location;
            }
            else 
            {
                btn_XoaNV.Visible = true;
                btn_ThongTin.Visible = true;
                panelEllipsis.Height = btn_ThongTin.Height * 2;
                btn_Them.Visible = true;
                btn_Xoa.Visible = true;
            }
            HienThiDSNhiemVuTheoTrang();

            var reader = nhvd.NhanVienDuAn();
            while (reader.Read())
            {
                cb_NhanVien.Items.Add(reader["MaNV"].ToString().Trim() + "-" + reader["HoTen"].ToString().Trim());
            }
            nhvd.dao.conn.Close();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string maPB = "";
            var reader = nvd.DocDuDieuNhanVienTuTK(Frm_DangNhap.LoaiTaiKhoan, Frm_DangNhap.txt_UsernameCopy.Text, Frm_DangNhap.txt_PasswordCopy.Text);
            if (reader.Read())
            {
                maPB = reader["MaPB"].ToString().Trim();   
            }
            nvd.dao.conn.Close();
            Frm_ThemNhiemVu tnv = new Frm_ThemNhiemVu(maPB, "PCNV");
            tnv.Show();
        }

        private void dataGridViewMain_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = dataGridViewMain.Rows[e.RowIndex];
                row.Cells[0].Value = !Convert.ToBoolean(row.Cells[0].Value);
                bool isChecked = Convert.ToBoolean(row.Cells[0].Value);
                if (isChecked)
                {
                    countSelected++;
                    MaNVList.Add(row.Cells[3].Value.ToString().Trim());
                }
                else
                {
                    countSelected--;
                    MaNVList.Remove(row.Cells[3].Value.ToString().Trim());
                };
                lbl_CountSelected.Text = countSelected.ToString();
            }
        }

        private void dataGridViewMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (Frm_DangNhap.LoaiTaiKhoan != "TkGiamDoc")
            {
                if (e.ColumnIndex > 0 && e.ColumnIndex <= 10)
                {
                    MaNV = Convert.ToInt32(dataGridViewMain.Rows[e.RowIndex].Cells[2].Value);
                    MaNSH = dataGridViewMain.Rows[e.RowIndex].Cells[5].Value.ToString().Trim();
                    MaDA = Convert.ToInt32(dataGridViewMain.Rows[e.RowIndex].Cells[10].Value);
                    Page_ThongTinNhiemVu ttnv = new Page_ThongTinNhiemVu("Main", false);
                    if (!Frm_Main.panelMainCopy.Controls.Contains(ttnv))
                    {
                        Frm_Main.panelMainCopy.Controls.Clear();
                        ttnv.Dock = DockStyle.Fill;
                        Frm_Main.panelMainCopy.Controls.Add(ttnv);
                    }  
                }
                if (e.ColumnIndex == 11)
                {
                    MaNV = Convert.ToInt32(dataGridViewMain.Rows[e.RowIndex].Cells[2].Value);
                    MaNSH = dataGridViewMain.Rows[e.RowIndex].Cells[5].Value.ToString().Trim();
                    MaDA = Convert.ToInt32(dataGridViewMain.Rows[e.RowIndex].Cells[10].Value);
                    panelEllipsis.Location = new Point(1387, 124 + (e.RowIndex) * 60);
                    bs_Ellipsis.Location = new Point(1545, 114 + (e.RowIndex) * 60);
                    panelEllipsis.Visible = !panelEllipsis.Visible;
                    bs_Ellipsis.Visible = !bs_Ellipsis.Visible;
                }
            }
            else
            {
                if (e.ColumnIndex > 0 && e.ColumnIndex <= 10)
                {
                    MaNV = Convert.ToInt32(dataGridViewMain.Rows[e.RowIndex].Cells[2].Value);
                    MaNSH = dataGridViewMain.Rows[e.RowIndex].Cells[5].Value.ToString().Trim();
                    MaDA = Convert.ToInt32(dataGridViewMain.Rows[e.RowIndex].Cells[10].Value);
                    Page_ThongTinNhiemVu ttnv = new Page_ThongTinNhiemVu("NhiemVu", true);
                    if (!Frm_Main.panelMainCopy.Controls.Contains(ttnv)) 
                    {
                        Frm_Main.panelMainCopy.Controls.Clear();
                        ttnv.Dock = DockStyle.Fill;
                        Frm_Main.panelMainCopy.Controls.Add(ttnv);
                    }
                }
                if (e.ColumnIndex == 11)
                {
                    MaNV = Convert.ToInt32(dataGridViewMain.Rows[e.RowIndex].Cells[2].Value);
                    MaNSH = dataGridViewMain.Rows[e.RowIndex].Cells[5].Value.ToString().Trim();
                    MaDA = Convert.ToInt32(dataGridViewMain.Rows[e.RowIndex].Cells[10].Value);
                    panelEllipsis.Location = new Point(1387, 124 + (e.RowIndex) * 60);
                    bs_Ellipsis.Location = new Point(1545, 114 + (e.RowIndex) * 60);
                    panelEllipsis.Visible = !panelEllipsis.Visible;
                    bs_Ellipsis.Visible = !bs_Ellipsis.Visible;
                }
            }
           
        }
        private void btn_ThongTin_Click(object sender, EventArgs e)
        {
            if (mode == "NV")
            {
                Page_ThongTinNhiemVu ttnv = new Page_ThongTinNhiemVu("Main", false);
                if (!Frm_Main.panelMainCopy.Controls.Contains(ttnv))
                {
                    Frm_Main.panelMainCopy.Controls.Clear();
                    ttnv.Dock = DockStyle.Fill;
                    Frm_Main.panelMainCopy.Controls.Add(ttnv);
                }
            }
            else if (mode == "PCNV")
            {
                Page_ThongTinNhiemVu ttnv = new Page_ThongTinNhiemVu("NhiemVu", true);
                if (!Frm_NhiemVu.panelMainCopy.Controls.Contains(ttnv))
                {
                    Frm_NhiemVu.panelMainCopy.Controls.Clear();
                    ttnv.Dock = DockStyle.Fill;
                    Frm_NhiemVu.panelMainCopy.Controls.Add(ttnv);
                }
            }
        }

        private void btn_EllipseVertical_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Search_OnIconLeftClick(object sender, EventArgs e)
        {
            HienDSTheoTrang(HienThiDSTheoTimKiem);
        }

        private void txt_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txt_Search_OnIconLeftClick(sender, e);
        }

        private void cb_TinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_NhanVien.Items.Clear();
            SqlDataReader cotNV;
            if (cb_TinhTrang.Text.Trim() == "Tình Trạng (Tất Cả)")
            {
                cotNV = nhvd.NhanVienDuAn();
            }
            else
            {
                cotNV = nhvd.NhanVienDuAnTheoTinhTrang(cb_TinhTrang.Text.Trim());
            }
            cb_NhanVien.Items.Add("  Người Sở Hữu (Tất Cả)");


            if (cotNV != null)
            {
                while (cotNV.Read())
                    cb_NhanVien.Items.Add("  " + cotNV["MaNV"].ToString().Trim() + "-" + cotNV["HoTen"].ToString().Trim());
            }
            nhvd.dao.conn.Close();
            cb_NhanVien.Text = "  Nhân Viên (Tất Cả)";

            string nhanVien = cb_NhanVien.Text.Trim();
            if (nhanVien == "Nhân Viên (Tất Cả)" && cb_TinhTrang.Text == "  Tình Trạng (Tất Cả)")
            {
                HienThiDSNhiemVuTheoTrang();
            }
            else if (nhanVien == "Nhân Viên (Tất Cả)")
            {
                HienThiDSTheoTinhTrangTheoTrang();
            }
            else
            {
                HienThiDSTheoTinhTrangVaNhanVienTheoTrang();
            }
        }

        private void cb_NhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nhanVien = cb_NhanVien.Text.Trim();
            if (nhanVien == "Nhân Viên (Tất Cả)" && cb_TinhTrang.Text == "  Tình Trạng (Tất Cả)")
            {
                HienThiDSNhiemVuTheoTrang();
            }
            else if (nhanVien == "Nhân Viên (Tất Cả)")
            {
                HienThiDSTheoTinhTrangTheoTrang();
            }
            else
            {
                HienThiDSTheoTinhTrangVaNhanVienTheoTrang();
            }
        }

        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
            Xoa.XoaNhiemVu(MaNV, MaDA);
            AnEllipsis();
            HienThiDSNhiemVuTheoTrang();
        }
    }
}
