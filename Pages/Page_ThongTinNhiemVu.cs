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
using QuanLyDuAn.Dao;
using QuanLyDuAn.Dao.Dao;
using QuanLyDuAn.Forms;

namespace QuanLyDuAn.Pages
{
    public partial class Page_ThongTinNhiemVu : UserControl
    {
        NhanVienDao nvd = new NhanVienDao();
        NhiemVuDao nhvd = new NhiemVuDao();
        public static System.Windows.Forms.Label lbl_TenNhiemVuCopy;
        public static BunifuLabel lbl_NguoiSoHuuCopy;
        public static BunifuLabel lbl_TinhTrangCopy;
        string mode;
        public static bool ChoPhepSua;
        public Page_ThongTinNhiemVu(string mode, bool choPhepSua)
        {
            InitializeComponent();
            lbl_TenNhiemVuCopy = lbl_TenNhiemVu;
            lbl_NguoiSoHuuCopy = lbl_NguoiSoHuu;
            lbl_TinhTrangCopy = lbl_TinhTrang;
            this.mode = mode;
            ChoPhepSua = choPhepSua;
            pct = new Page_ChiTiet("NV");
            pdgnv = new Page_DanhGiaNV();
            dsnvNV = new Page_DanhSachNV("NV");
            dsnvQL = new Page_DanhSachNV("QL");
            pdggd = new Page_DanhGiaGD();
            cnnv = new Page_CapNhatNV();
        }
        public static Page_ChiTiet pct= new Page_ChiTiet("NV");
        public static Page_DanhGiaNV pdgnv = new Page_DanhGiaNV();
        public static Page_DanhSachNV dsnvNV = new Page_DanhSachNV("NV");
        public static Page_DanhSachNV dsnvQL = new Page_DanhSachNV("QL");
        public static Page_DanhGiaGD pdggd = new Page_DanhGiaGD();
        public static Page_CapNhatNV cnnv = new Page_CapNhatNV();
        private void btn_ChiTietNV_Click(object sender, EventArgs e)
        {
            bunifuSeparator1.Location = new System.Drawing.Point(btn_ChiTietNV.Location.X, bunifuSeparator1.Location.Y);
            bunifuSeparator1.BringToFront();
            if (!panelMain.Controls.Contains(pct))
            {
                panelMain.Controls.Clear();
                pct.Dock = DockStyle.Fill;
                panelMain.Controls.Add(pct);
            }
        }

        private void btn_NopFile_Click(object sender, EventArgs e)
        {
            bunifuSeparator1.Location = new System.Drawing.Point(btn_NopFile.Location.X, bunifuSeparator1.Location.Y);
            bunifuSeparator1.BringToFront();
            if (!panelMain.Controls.Contains(dsnvNV))
            {
                panelMain.Controls.Clear();
                dsnvNV.Dock = DockStyle.Fill;
                panelMain.Controls.Add(dsnvNV);
            }
        }

        private void btn_DanhGia_Click(object sender, EventArgs e)
        {
            bunifuSeparator1.Location = new System.Drawing.Point(btn_DanhGiaNV.Location.X, bunifuSeparator1.Location.Y);
            bunifuSeparator1.BringToFront();
            if (!panelMain.Controls.Contains(pdgnv))
            {
                panelMain.Controls.Clear();
                pdgnv.Dock = DockStyle.Fill;
                panelMain.Controls.Add(pdgnv);
            }
        }
        private void btn_PhanLam_Click(object sender, EventArgs e)
        {
            bunifuSeparator1.Location = new System.Drawing.Point(btn_DanhSach.Location.X, bunifuSeparator1.Location.Y);
            bunifuSeparator1.BringToFront();
            if (!panelMain.Controls.Contains(dsnvQL))
            {
                panelMain.Controls.Clear();
                dsnvQL.Dock = DockStyle.Fill;
                panelMain.Controls.Add(dsnvQL);
            }
        }
        private void btn_DanhGiaGD_Click(object sender, EventArgs e)
        {
            bunifuSeparator1.Location = new System.Drawing.Point(btn_DanhGiaGD.Location.X, bunifuSeparator1.Location.Y);
            bunifuSeparator1.BringToFront();
            if (!panelMain.Controls.Contains(pdggd))
            {
                panelMain.Controls.Clear();
                pdggd.Dock = DockStyle.Fill;
                panelMain.Controls.Add(pdggd);
            }
        }
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            bunifuSeparator1.Location = new System.Drawing.Point(btn_CapNhat.Location.X, bunifuSeparator1.Location.Y);
            bunifuSeparator1.BringToFront();
            if (!panelMain.Controls.Contains(cnnv))
            {
                panelMain.Controls.Clear();
                cnnv.Dock = DockStyle.Fill;
                panelMain.Controls.Add(cnnv);
            }
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            if (mode == "Main")
            {
                if (!Frm_Main.panelMainCopy.Controls.Contains(Page_NhiemVu.pnvCopy))
                {
                    Frm_Main.panelMainCopy.Controls.Clear();
                    Page_NhiemVu.pnvCopy.Dock = DockStyle.Fill;
                    Frm_Main.panelMainCopy.Controls.Add(Page_NhiemVu.pnvCopy);

                }
            }
            else if (mode == "NhiemVu")
            {
                if (!Frm_Main.panelMainCopy.Controls.Contains(Page_NhiemVu.pnvCopy))
                {
                    Frm_Main.panelMainCopy.Controls.Clear();
                    Page_NhiemVu.pnvCopy.Dock = DockStyle.Fill;
                    Frm_Main.panelMainCopy.Controls.Add(Page_NhiemVu.pnvCopy);

                }
            }
        }
      

        private void Page_ThongTinNhiemVu_Load(object sender, EventArgs e)
        {
            lbl_TinhTrang.Text = "";
            List<string> MaNVQLDA = new List<string>(); 
            var readerQLDA = nvd.DocDuLieuNhanVienTuMaChucVu("CV025");
            while (readerQLDA.Read())
            {
                MaNVQLDA.Add(readerQLDA["MaNV"].ToString().Trim());
            }
            nvd.dao.conn.Close();
            if (Frm_DangNhap.LoaiTaiKhoan == "TkGiamDoc" || MaNVQLDA.Contains(Frm_Main.MaNhanVien) || mode == "NhiemVu")
            {
                btn_DanhSach.Visible = true;
                btn_DanhGiaGD.Visible = true;
                btn_NopFile.Visible = false;
                btn_DanhGiaNV.Visible = false;
                btn_CapNhat.Visible = false;
            }
            else
            {
                btn_DanhSach.Visible = false;
                btn_DanhGiaGD.Visible = false;
                btn_NopFile.Visible = true;
                btn_DanhGiaNV.Visible = true;
                btn_CapNhat.Visible = true;
            }
            var reader = nhvd.DocDuDieuNhiemVuTuMaNhiemVu(Page_NhiemVu.MaNV);
            if (reader.Read())
            {
                lbl_TenNhiemVu.Text = reader["TenNhiemVu"].ToString().Trim();
                lbl_NguoiSoHuu.Text = reader["HoTen"].ToString().Trim();
                lbl_TinhTrang.Text = reader["TTrang"].ToString().Trim();
            }
            nhvd.dao.conn.Close();
            bunifuSeparator1.Location = new System.Drawing.Point(btn_ChiTietNV.Location.X, bunifuSeparator1.Location.Y);
            if (!panelMain.Controls.Contains(pct))
            {
                panelMain.Controls.Clear();
                pct.Dock = DockStyle.Fill;
                panelMain.Controls.Add(pct);

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
            lbl_TinhTrang.Location = new System.Drawing.Point(lbl_TenNhiemVu.Location.X + lbl_TenNhiemVu.Width + 20, lbl_TinhTrang.Location.Y - 2);
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
