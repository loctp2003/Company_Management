using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using QuanLyDuAn.Dao.Dao;
using QuanLyDuAn.Dao;
using QuanLyDuAn.Forms;
using QuanLyDuAn.Tools;
using FontAwesome.Sharp;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Controls.Primitives;
using CSJ2K.Icc.Tags;
using QuanLyDuAn.Models;
using QuanLyDuAn.ChucNang;

namespace QuanLyDuAn.Pages
{
    public partial class Page_DA : UserControl
    {
        DuAnDao dad = new DuAnDao();
        NhanVienDao nvd = new NhanVienDao();
        NhiemVuDao nhvd = new NhiemVuDao();
        NhiemVuNhoDao nvnd = new NhiemVuNhoDao();
        NhanVienThamGiaDADao nvtg = new NhanVienThamGiaDADao();
        public static Page_DA pdaCopy;
        public static BunifuDataGridView dataGridViewMainCopy;
        public static BunifuTextBox txt_SearchCopy;
        public static int MaDA;
        public static Label lbl_SoDACopy;
        public static int soDACopy;
        public static Panel panelEllipsisCopy;
        public static BunifuShapes bs_EllipsisCopy;
        public static List<string> MaDAListCopy;

        int soDA = 0;
        int countSelected = 0;
        public Page_DA()
        {
            InitializeComponent();
            pdaCopy = this;
            bs_EllipsisCopy = bs_Ellipsis;
            panelEllipsisCopy = panelEllipsis;
            dataGridViewMainCopy = dataGridViewMain;
            lbl_SoDACopy = lbl_SoDA;
            soDACopy = soDA;
            MaDAListCopy = MaDAList;
            txt_SearchCopy = txt_Search;
            lbl_SoDA.Text = "0";
            countSelected = 0;
        }
        List<string> MaDAList = new List<string>();
      
        private void HienThiDSDuAnTheoTrang()
        {
            soDA = dad.DemDuAn(txt_Search.Text.Trim());
            lbl_SoDA.Text = soDA.ToString() + " Dự Án";
            HienDSTheoTrang(HienThiDSDuAn);
        }
        private void HienThiDSDuAn()
        {
            var readerTK = nvd.DocDuDieuNhanVienTuTK(Frm_DangNhap.LoaiTaiKhoan, Frm_DangNhap.txt_UsernameCopy.Text, Frm_DangNhap.txt_PasswordCopy.Text);
            string MaNV = "";
            if (readerTK.Read())
            {
                MaNV = readerTK["MaNV"].ToString();
            }
            nvd.dao.conn.Close();

            dataGridViewMain.Rows.Clear();
            SqlDataReader reader;
            if (Frm_DangNhap.LoaiTaiKhoan == "TkGiamDoc")
                reader = dad.DanhSachDuAn(txt_Search.Text.Trim(), currPTrang.trang, currPTrang.soDongMoiTrang);
            else reader = dad.DanhSachDuAnTheoTK(MaNV);
            while (reader.Read())
            {
                int maDA = Convert.ToInt32(reader["MaDA"].ToString().Trim());
                int soNV = nhvd.DemNhiemVuTheoMaDA(maDA);
                int soNVHoanThanh = nhvd.DemNhiemVuTheoMaDAHoanThanh(maDA);
                TimeSpan soNgayToanBo = Convert.ToDateTime(reader["NgayKetThuc"].ToString().Trim()) - Convert.ToDateTime(reader["NgayBatDau"].ToString().Trim());
                TimeSpan soNgayHienTai = DateTime.Now - Convert.ToDateTime(reader["NgayBatDau"].ToString().Trim());
                if (soNgayHienTai.Days < 0)
                    soNgayHienTai = DateTime.Now - DateTime.Now;
                if (soNgayHienTai.Days > soNgayToanBo.Days)
                    soNgayHienTai = soNgayToanBo;
                object[] ob = new object[] { false, reader["MaDA"].ToString().Trim(), reader["TenDuAn"].ToString().Trim(), reader["Anh"], reader["HoTen"].ToString().Trim(), reader["TTrang"].ToString().Trim(), "(" + soNgayHienTai.Days.ToString() + "/" + soNgayToanBo.Days.ToString() + ")", Convert.ToInt32(reader["TiLeHT"].ToString().Trim()), "(" + soNVHoanThanh.ToString() + "/" + soNV.ToString() +")" };
                dataGridViewMain.Rows.Add(ob);
            }
            dad.dao.conn.Close();
        }
        private void HienThiDSTheoTinhTrangTheoTrang()
        {
            soDA = dad.DemDuAnTheoTinhTrang(txt_Search.Text.Trim(), cb_TinhTrang.Text.Trim());
            lbl_SoDA.Text = soDA.ToString() + " Dự Án";
            HienDSTheoTrang(HienThiDSTheoTinhTrang);
        }
        private void HienThiDSTheoTinhTrang()
        {
            var reader = dad.DanhSachDuAnTheoTinhTrang(currPTrang.trang, currPTrang.soDongMoiTrang, txt_Search.Text.Trim(), cb_TinhTrang.Text.Trim());
            dataGridViewMain.Rows.Clear();
            while (reader.Read())
            {
                int maDA = Convert.ToInt32(reader["MaDA"].ToString().Trim());
                int soNV = nhvd.DemNhiemVuTheoMaDA(maDA);
                int soNVHoanThanh = nhvd.DemNhiemVuTheoMaDAHoanThanh(maDA);
                TimeSpan soNgayToanBo = Convert.ToDateTime(reader["NgayKetThuc"].ToString().Trim()) - Convert.ToDateTime(reader["NgayBatDau"].ToString().Trim());
                TimeSpan soNgayHienTai = DateTime.Now - Convert.ToDateTime(reader["NgayBatDau"].ToString().Trim());
                if (soNgayHienTai.Days < 0)
                    soNgayHienTai = DateTime.Now - DateTime.Now;
                if (soNgayHienTai.Days > soNgayToanBo.Days)
                    soNgayHienTai = soNgayToanBo;
                object[] ob = new object[] { false, reader["MaDA"].ToString().Trim(), reader["TenDuAn"].ToString().Trim(), reader["Anh"], reader["HoTen"].ToString().Trim(), reader["TTrang"].ToString().Trim(), "(" + soNgayHienTai.Days.ToString() + "/" + soNgayToanBo.Days.ToString() + ")", Convert.ToInt32(reader["TiLeHT"].ToString().Trim()), "(" + soNVHoanThanh.ToString() + "/" + soNV.ToString() + ")" };
                dataGridViewMain.Rows.Add(ob);
            }
            dad.dao.conn.Close();
        }
        private void HienThiDSTheoTinhTrangVaNSHTheoTrang()
        {
            soDA = dad.DemDuAnTheoTinhTrangVaNSH(txt_Search.Text.Trim(), cb_TinhTrang.Text.Trim(), cb_NguoiSoHuu.Text.Trim().Split('-')[0]);
            lbl_SoDA.Text = soDA.ToString() + " Dự Án";
            HienDSTheoTrang(HienThiDSTheoTinhTrangVaNSH);
        }
        private void HienThiDSTheoTinhTrangVaNSH()
        {
            var reader = dad.DanhSachDuAnTheoTinhTrangVaNSH(currPTrang.trang, currPTrang.soDongMoiTrang, txt_Search.Text.Trim(), cb_TinhTrang.Text.Trim(), cb_NguoiSoHuu.Text.Trim().Split('-')[0]);
            dataGridViewMain.Rows.Clear();
            while (reader.Read())
            {
                int maDA = Convert.ToInt32(reader["MaDA"].ToString().Trim());
                int soNV = nhvd.DemNhiemVuTheoMaDA(maDA);
                int soNVHoanThanh = nhvd.DemNhiemVuTheoMaDAHoanThanh(maDA);
                TimeSpan soNgayToanBo = Convert.ToDateTime(reader["NgayKetThuc"].ToString().Trim()) - Convert.ToDateTime(reader["NgayBatDau"].ToString().Trim());
                TimeSpan soNgayHienTai = DateTime.Now - Convert.ToDateTime(reader["NgayBatDau"].ToString().Trim());
                if (soNgayHienTai.Days < 0)
                    soNgayHienTai = DateTime.Now - DateTime.Now;
                if (soNgayHienTai.Days > soNgayToanBo.Days)
                    soNgayHienTai = soNgayToanBo;
                object[] ob = new object[] { false, reader["MaDA"].ToString().Trim(), reader["TenDuAn"].ToString().Trim(), reader["Anh"], reader["HoTen"].ToString().Trim(), reader["TTrang"].ToString().Trim(), "(" + soNgayHienTai.Days.ToString() + "/" + soNgayToanBo.Days.ToString() + ")", Convert.ToInt32(reader["TiLeHT"].ToString().Trim()), "(" + soNVHoanThanh.ToString() + "/" + soNV.ToString() + ")" };
                dataGridViewMain.Rows.Add(ob);
            }
            dad.dao.conn.Close();
        }
        private void HienThiDSTheoTimKiem()
        {
            string nguoiSoHuu = cb_NguoiSoHuu.Text.Trim();
            if (nguoiSoHuu == "Người Sở Hữu (Tất Cả)" && cb_TinhTrang.Text == "  Tình Trạng (Tất Cả)")
            {
                HienThiDSDuAnTheoTrang();
            }
            else if (nguoiSoHuu == "Người Sở Hữu (Tất Cả)")
            {
                HienThiDSTheoTinhTrangTheoTrang();
            }
            else
            {
                HienThiDSTheoTinhTrangVaNSHTheoTrang();
            }
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
            var pageTrang = panel3.Controls.OfType<Page_Trang>().ToList();
            if (pageTrang.Any())
            {
                var firstPageTrang = pageTrang.First();
                panel3.Controls.Remove(firstPageTrang);
            }
            
            Page_Trang ptrang = new Page_Trang(hienthi, (soDA/10) + 1, 10);
            currPTrang = ptrang;
            ptrang.Location = new Point(971, 725);
            panel3.Controls.Add(ptrang);
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
        private void Page_DA_Load(object senderLoad, EventArgs eLoad)
        {
            lbl_SoDA.Text = soDA.ToString() + " Dự Án";
            dataGridViewMain.RowTemplate.Height = 60;
            dataGridViewMain.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 192);
            dataGridViewMain.DefaultCellStyle.SelectionForeColor = Color.FromArgb(64, 64, 192);
            dataGridViewMain.ColumnHeadersHeight = 50;

            DataGridViewBadgeColumn c = new DataGridViewBadgeColumn();
            c.HeaderText = "Tình Trạng";
            c.MinimumWidth = 250;
            dataGridViewMain.Columns.Insert(5, c);
            c.DataPropertyName = "TinhTrang";

            DataGridViewImageColumn dt = new DataGridViewImageColumn();
            dt.Image = System.Drawing.Bitmap.FromFile("../../Images/ellipsis (1).png");
            dt.MinimumWidth = 80;
            dataGridViewMain.Columns.Insert(9, dt);

            HienThiDSDuAnTheoTrang();

            var reader = dad.NguoiSoHuuDuAn();
            while (reader.Read())
            {
                cb_NguoiSoHuu.Items.Add(reader["MaNV"].ToString().Trim() + "-" + reader["HoTen"].ToString().Trim());
            }
            dad.dao.conn.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dataGridViewMain_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            
        }
        
        private void dataGridViewMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    MaDAList.Add(row.Cells[3].Value.ToString().Trim());
                }
                else
                {
                    countSelected--;
                    MaDAList.Remove(row.Cells[3].Value.ToString().Trim());
                };
                lbl_CountSelected.Text = countSelected.ToString();
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_TinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_NguoiSoHuu.Items.Clear();
            SqlDataReader cotNSH;
            if (cb_TinhTrang.Text.Trim() == "Tình Trạng (Tất Cả)")
            {
                cotNSH = dad.NguoiSoHuuDuAn();
            }
            else
            {
                cotNSH = dad.NguoiSoHuuDuAnTheoTinhTrang(cb_TinhTrang.Text.Trim());
            }
            cb_NguoiSoHuu.Items.Add("  Người Sở Hữu (Tất Cả)");
            

            if (cotNSH != null)
            {
                while (cotNSH.Read())
                    cb_NguoiSoHuu.Items.Add("  " + cotNSH["MaNV"].ToString().Trim() + "-" + cotNSH["HoTen"].ToString().Trim());
            }
            dad.dao.conn.Close();
            cb_NguoiSoHuu.Text = "  Người Sở Hữu (Tất Cả)";

            string nguoiSoHuu = cb_NguoiSoHuu.Text.Trim();
            if (nguoiSoHuu == "Người Sở Hữu (Tất Cả)" && cb_TinhTrang.Text == "  Tình Trạng (Tất Cả)")
            {
                HienThiDSDuAnTheoTrang();
            }
            else if (nguoiSoHuu == "Người Sở Hữu (Tất Cả)")
            {
                HienThiDSTheoTinhTrangTheoTrang();
            }
            else
            {
                HienThiDSTheoTinhTrangVaNSHTheoTrang();
            }
        }

        private void cb_NguoiSoHuu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nguoiSoHuu = cb_NguoiSoHuu.Text.Trim();
            if (nguoiSoHuu == "Người Sở Hữu (Tất Cả)" && cb_TinhTrang.Text == "  Tình Trạng (Tất Cả)")
            {
                HienThiDSDuAnTheoTrang();
            }
            else if (nguoiSoHuu == "Người Sở Hữu (Tất Cả)")
            {
                HienThiDSTheoTinhTrangTheoTrang();
            }
            else
            {
                HienThiDSTheoTinhTrangVaNSHTheoTrang();
            }
        }

        private void txt_Search_OnIconLeftClick(object sender, EventArgs e)
        {
            HienDSTheoTrang(HienThiDSTheoTimKiem);
        }
        private void txt_Search_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txt_Search_OnIconLeftClick(sender, e);
        }

        private void btn_ThemDA_Click(object sender, EventArgs e)
        {
            Frm_ThemDA da = new Frm_ThemDA();
            da.Show();
        }

        private void btn_ThongTin_Click(object sender, EventArgs e)
        {
            Page_ThongTinDuAn ttda = new Page_ThongTinDuAn();
            if (!Frm_Main.panelMainCopy.Controls.Contains(ttda))
            {
                Frm_Main.panelMainCopy.Controls.Clear();
                ttda.Dock = DockStyle.Fill;
                Frm_Main.panelMainCopy.Controls.Add(ttda);
            }
        }
        private bool multiSelected = false;
        private void btn_EllipseVertical_Click(object sender, EventArgs e)
        {
            multiSelected = !multiSelected;
            if (multiSelected)
            {
                bs_Ellipsis.Location = new Point(1526, 0);
                panelEllipsis.Location = new Point(1383, 10);
                HienEllipsis();
            }
            else AnEllipsis();
        }

        private void lbl_CountSelected_Click(object sender, EventArgs e)
        {

        }
        private void btn_XoaDA_Click(object sender, EventArgs e)
        {
            Xoa.XoaDuAn(MaDA);
            AnEllipsis();
            HienThiDSDuAnTheoTrang();
        }

        private void dataGridViewMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            
            if (e.ColumnIndex > 0 && e.ColumnIndex <= 8)
            {
                MaDA = Convert.ToInt32(dataGridViewMain.Rows[e.RowIndex].Cells[1].Value);
                Page_ThongTinDuAn ttda = new Page_ThongTinDuAn();
                if (!Frm_Main.panelMainCopy.Controls.Contains(ttda))
                {
                    Frm_Main.panelMainCopy.Controls.Clear();
                    ttda.Dock = DockStyle.Fill;
                    Frm_Main.panelMainCopy.Controls.Add(ttda);
                }
            }
            if (e.ColumnIndex == 9)
            {
                MaDA = Convert.ToInt32(dataGridViewMain.Rows[e.RowIndex].Cells[1].Value);
                panelEllipsis.Location = new Point(1382, 124 + (e.RowIndex) * 60);
                bs_Ellipsis.Location = new Point(1540, 114 + (e.RowIndex) * 60);
                panelEllipsis.Visible = !panelEllipsis.Visible;
                bs_Ellipsis.Visible = !bs_Ellipsis.Visible;
            }
        }
    }
}
