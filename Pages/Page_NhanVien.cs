using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using QuanLyDuAn.Dao;
using QuanLyDuAn.Dao.Dao;
using QuanLyDuAn.Forms;
using FontAwesome.Sharp;
using Bunifu.Framework.UI;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace QuanLyDuAn.Pages
{
    public partial class Page_NhanVien : UserControl
    {
        NhanVienDao nvd = new NhanVienDao();
        PhongBanDao pbd = new PhongBanDao();
        ChucVuDao cvd = new ChucVuDao();
        public static BunifuDataGridView dataGridViewMainCopy;
        public static string MaNV;
        public static Label lbl_SoNVCopy;
        public static int soNVCopy;
        public static Panel panelEllipsisCopy;
        public static BunifuShapes bs_EllipsisCopy;
        public static List<string> MaNVListCopy;
        int soNV = 0;
        int countSelected = 0;
        public Page_NhanVien()
        {
            InitializeComponent();
            bs_EllipsisCopy = bs_Ellipsis;
            panelEllipsisCopy = panelEllipsis;
            dataGridViewMainCopy = dataGridViewMain;
            lbl_SoNVCopy = lbl_SoNV;
            soNVCopy = soNV;
            MaNVListCopy = MaNVList;
            //soTrang = (soNV / 10) + 1;
            lbl_SoNV.Text = "0";
            countSelected = 0;
        }
        List<string> MaNVList = new List<string>();
        
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewMain.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    bool isChecked = (bool)row.Cells[0].Value;
                    if (isChecked)
                    {
                        DataTable dt = nvd.XoaNhanVien(row.Cells[3].Value.ToString().Trim(), txt_Search.Text.Trim(), currPTrang.trang, currPTrang.soDongMoiTrang);
                        dataGridViewMain.DataSource = nvd.DanhSachNhanVien(txt_Search.Text.Trim(), currPTrang.trang, currPTrang.soDongMoiTrang);
                    }
                }
            }
        }
        private void HienThiDSNhanVienTheoTrang()
        {
            soNV = nvd.DemDanhSachNhanVien(txt_Search.Text.Trim());
            lbl_SoNV.Text = soNV.ToString() + " Nhân Viên";
            HienDSTheoTrang(HienThiDSNhanVien);
        }
        private void HienThiDSNhanVien()
        {
            dataGridViewMain.DataSource = nvd.DanhSachNhanVien(txt_Search.Text.Trim(), currPTrang.trang, currPTrang.soDongMoiTrang);
        }
        private void HienThiDSTheoPhongBanTheoTrang()
        {
            soNV = nvd.DemDuDieuNhanVienTuPhongBan(cb_PhongBan.Text.Trim(), txt_Search.Text.Trim());
            lbl_SoNV.Text = soNV.ToString() + " Nhân Viên";
            HienDSTheoTrang(HienThiDSTheoPhongBan);
        }
        private void HienThiDSTheoPhongBan()
        {
            var ds = nvd.DocDuDieuNhanVienTuPhongBan(cb_PhongBan.Text.Trim(), txt_Search.Text.Trim(), currPTrang.trang, currPTrang.soDongMoiTrang);
            dataGridViewMain.DataSource = ds;
        }
        private void HienThiDSTheoPhongBanVaChucVuTheoTrang()
        {
            soNV = nvd.DemDuDieuNhanVienTuPhongBanVaChucVu(cb_PhongBan.Text, cb_ViTri.Text, txt_Search.Text.Trim());
            lbl_SoNV.Text = soNV.ToString() + " Nhân Viên";
        }
        private void HienThiDSTheoPhongBanVaChucVu()
        {
            var ds = nvd.DocDuDieuNhanVienTuPhongBanVaChucVu(cb_PhongBan.Text, cb_ViTri.Text, txt_Search.Text.Trim(), currPTrang.trang, currPTrang.soDongMoiTrang);
            dataGridViewMain.DataSource = ds;
            HienDSTheoTrang(HienThiDSTheoPhongBanVaChucVu);
        }
        private void HienThiDSTheoTimKiem()
        {
            string viTri = cb_ViTri.Text;
            if (viTri == "Vị Trí (Tất Cả)" && cb_PhongBan.Text == "Phòng Ban (Tất Cả)")
            {
                HienThiDSNhanVienTheoTrang();
            }
            else if (viTri == "Vị Trí (Tất Cả)")
            {
                HienThiDSTheoPhongBanTheoTrang();
            }
            else
            {
                HienThiDSTheoPhongBanVaChucVuTheoTrang();
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
            var pageTrang = panel2.Controls.OfType<Page_Trang>().ToList();
            if (pageTrang.Any())
            {
                var firstPageTrang = pageTrang.First();
                panel2.Controls.Remove(firstPageTrang);
            }
            
            Page_Trang ptrang = new Page_Trang(hienthi, (soNV/10) + 1, 10);
            currPTrang = ptrang;
            ptrang.Location = new Point(971, 725);
            panel2.Controls.Add(ptrang);
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
        private void Page_NhanVien_Load(object senderLoad, EventArgs eLoad)
        {
            HienThiDSNhanVienTheoTrang();
            foreach (DataGridViewRow row in dataGridViewMain.Rows)
            {
                row.Cells[0].Value = false;
            }
           
            dataGridViewMain.RowTemplate.Height = 60;
            dataGridViewMain.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 192);
            dataGridViewMain.DefaultCellStyle.SelectionForeColor = Color.FromArgb(64, 64, 192);
            dataGridViewMain.ColumnHeadersHeight = 50;

            DataGridViewImageColumn dt = new DataGridViewImageColumn();
            dt.Image = System.Drawing.Bitmap.FromFile("../../Images/ellipsis (1).png");
            dt.MinimumWidth = 80;
            dataGridViewMain.Columns.Insert(9, dt);

            SqlDataReader cotTenPB = pbd.DocDuDieuTenPB();
            cb_PhongBan.Items.Add("Phòng Ban (Tất Cả)");
            while (cotTenPB.Read())
                cb_PhongBan.Items.Add(cotTenPB["TenPB"].ToString().Trim());
            pbd.dao.conn.Close();


            SqlDataReader cotTenCV = cvd.DocDuDieuTenChucVu();
            cb_ViTri.Items.Add("Vị Trí (Tất Cả)");
            if (cotTenCV != null)
            {
                while (cotTenCV.Read())
                    cb_ViTri.Items.Add(cotTenCV["TenChucVu"].ToString().Trim());
            }
            cvd.dao.conn.Close();
        }
        
        private void btn_Them_Click(object sender, EventArgs e)
        {
            /*
            Frm_ThongTinNhanVien fttnv = new Frm_ThongTinNhanVien("Them");
            fttnv.Show();*/
        }

        private void cb_ViTri_SelectedIndexChanged(object sender, EventArgs e)
        {
            string viTri = cb_ViTri.Text;
            if (viTri == "Vị Trí (Tất Cả)" && cb_PhongBan.Text == "Phòng Ban (Tất Cả)")
            {
                HienThiDSNhanVienTheoTrang();
            }
            else if (viTri == "Vị Trí (Tất Cả)")
            {
                HienThiDSTheoPhongBanTheoTrang();
            }
            else
            {
                HienThiDSTheoPhongBanVaChucVuTheoTrang();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewMain_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            /*
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;

            app.Visible = true;

            worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets["Sheet1"];
            worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet;
            worksheet.Name = "Nhân Viên";

            for (int i = 1; i < dataGridViewMain.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridViewMain.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridViewMain.Rows.Count - 1; i++)
            {
                for (int j = 1; j < dataGridViewMain.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridViewMain.Rows[i].Cells[j].Value.ToString();
                }
            }
            workbook.SaveAs("./sheet1.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            */
        }
        private void dataGridViewMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (e.ColumnIndex == 1)
            {
                multiSelected = false;
                MaNV = dataGridViewMain.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
                panelEllipsis.Location = new Point(1385, 124 + (e.RowIndex) * 60);
                bs_Ellipsis.Location = new Point(1543, 114 + (e.RowIndex) * 60);
                panelEllipsis.Visible = !panelEllipsis.Visible;
                bs_Ellipsis.Visible = !bs_Ellipsis.Visible;
                
            }

            if (e.ColumnIndex >= 2 && e.ColumnIndex <= 9)
            {
                if (e.RowIndex >= 0)
                {
                    multiSelected = false;
                    MaNV = dataGridViewMain.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
                    Frm_ThongTinNhanVien ttnv = new Frm_ThongTinNhanVien(MaNV, "HienThi");
                    ttnv.Show();
                    Frm_ThongTinNhanVien.btn_ChevronLeftCopy.Enabled = false;
                    Frm_ThongTinNhanVien.btn_ChevronRightCopy.Enabled = false;
                }
            }
           
        }
        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                if (countSelected > 0) multiSelected = true;
            }

        }


        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

        }
       


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_In_Click(object sender, EventArgs e)
        {

        }
        private void cb_PhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string phongBanDuocChon = cb_PhongBan.Text;
            cb_ViTri.Items.Clear();
            SqlDataReader cotTenCV;
            if (phongBanDuocChon == "Phòng Ban (Tất Cả)")
            {
                cotTenCV = cvd.DocDuDieuTenChucVu();
            }
            else
            {
                cotTenCV = cvd.DocDuDieuTenChucVuCoDieuKien(phongBanDuocChon);
            }
            cb_ViTri.Items.Add("Vị Trí (Tất Cả)");
            cb_ViTri.Text = "Vị Trí (Tất Cả)";

            if (cotTenCV != null)
            {
                while (cotTenCV.Read())
                    cb_ViTri.Items.Add(cotTenCV["TenChucVu"].ToString().Trim());
            }
            cvd.dao.conn.Close();

            string viTri = cb_ViTri.Text;
            if (viTri == "Vị Trí (Tất Cả)" && cb_PhongBan.Text == "Phòng Ban (Tất Cả)")
            {
                HienThiDSNhanVienTheoTrang();
            }
            else if (viTri == "Vị Trí (Tất Cả)")
            {
                HienThiDSTheoPhongBanTheoTrang();
            }
            else
            {
                HienThiDSTheoPhongBanVaChucVuTheoTrang();
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

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
        private bool multiSelected = false;
        private void btn_EllipsisVertical_Click_1(object sender, EventArgs e)
        {
            multiSelected = !multiSelected;
            if (multiSelected)
            {
                bs_Ellipsis.Location = new Point(1513, 0);
                panelEllipsis.Location = new Point(1370, 10);
                HienEllipsis();
            }
            else AnEllipsis();
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (multiSelected)
            {
                if (MaNVList.Count > 0)
                {
                    txt_Search.Text = MaNVList[0];
                    Frm_ThongTinNhanVien fttnv = new Frm_ThongTinNhanVien(MaNVList[0], "Sua");
                    fttnv.Show();
                    AnEllipsis();
                    multiSelected = false;
                }
            }
            else
            {
                Frm_ThongTinNhanVien fttnv = new Frm_ThongTinNhanVien(MaNV, "Sua");
                fttnv.Show();
                Frm_ThongTinNhanVien.btn_ChevronLeftCopy.Enabled = false;
                Frm_ThongTinNhanVien.btn_ChevronRightCopy.Enabled = false;
                AnEllipsis();
            }
        }
        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
            if (multiSelected)
            {

            }
            else
            {
                /*
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    nvd.XoaNhanVien(MaNV, trang, soTrang);
                    soNV = nvd.DemSoNhanVien();
                    lbl_SoNV.Text = soNV.ToString() + " Nhân Viên";
                    HienThiDSNhanVien();
                    AnEllipsis();
                }*/
            }
        }
    }
}
