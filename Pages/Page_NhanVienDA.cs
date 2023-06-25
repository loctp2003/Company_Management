using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using FontAwesome.Sharp;
using QuanLyDuAn.Dao;
using QuanLyDuAn.Forms;
using QuanLyDuAn.Pages;

namespace QuanLyDuAn.Pages
{
    public partial class Page_NhanVienDA : UserControl
    {
        NhanVienThamGiaDADao nvtgd = new NhanVienThamGiaDADao();
        NhiemVuDao nvd = new NhiemVuDao();
        public static BunifuDataGridView dataGridViewMainCopy;
        string mode;
        int maDA;
        int soNV = 0;
        public static string MaNV;
        public static HashSet<String> maPBSet = new HashSet<string>();
        public Page_NhanVienDA(string mode, int maDA)
        {
            InitializeComponent();
            dataGridViewMainCopy = dataGridViewMain;
            this.mode = mode;
            this.maDA = maDA;
            maPBSet.Clear();
            var reader3 = nvtgd.CacPhongBanThamGiaDA(maDA);
            while (reader3.Read())
            {
                maPBSet.Add(reader3["MaPB"].ToString().Trim());
            }
            nvtgd.dao.conn.Close();
        }
        private void HienDSNhanVienThamGiaTheoTrang()
        {
            soNV = nvtgd.DemNhanVienThamGiaDA(maDA);
            lbl_SoNV.Text = soNV.ToString();
            HienDSTheoTrang(HienDSNhanVienThamGia);
        }
        private void HienDSNhanVienThamGia()
        {
            dataGridViewMain.Rows.Clear();
            List<string> soNVHoanThanhList = new List<string>();
            var reader1 = nvtgd.SoNVHoanThanh(maDA, currPTrang.trang, currPTrang.soDongMoiTrang);
            while (reader1.Read())
            {
                soNVHoanThanhList.Add(reader1["SoNhiemVu"].ToString().Trim());
            }
            nvtgd.dao.conn.Close();
            
          
            int i = 0;
            var reader2 = nvtgd.CacNhanVienThamGiaDA(maDA, currPTrang.trang, currPTrang.soDongMoiTrang);
            while (reader2.Read())
            {
                object[] ob = new object[] { false, reader2["Anh"], reader2["MaNV"].ToString().Trim(), reader2["HoTen"].ToString().Trim(), reader2["MaPB"].ToString().Trim(), reader2["TenPB"].ToString().Trim(), Convert.ToInt32(reader2["SoNhiemVu"].ToString().Trim()), Convert.ToInt32(soNVHoanThanhList[i]) };
                dataGridViewMain.Rows.Add(ob);
                i++;
            }
            nvtgd.dao.conn.Close();
            

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
            
            Page_Trang ptrang = new Page_Trang(hienthi, (soNV / 7) + 1, 7);
            currPTrang = ptrang;
            ptrang.Location = new Point(755, 520);
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
        private void Page_NhanVienDA_Load(object sender, EventArgs e)
        {
            if (mode == "PCNV")
            {
                Page_NhanVienDA.dataGridViewMainCopy.Columns[5].Visible = false;
                Page_NhanVienDA.dataGridViewMainCopy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                Page_NhanVienDA.dataGridViewMainCopy.Columns[0].Width = 100;
                Page_NhanVienDA.dataGridViewMainCopy.Columns[1].Width = 140;
                Page_NhanVienDA.dataGridViewMainCopy.Columns[3].Width = 256;
            }
            else if (mode == "DA")
            {
                Page_NhanVienDA.dataGridViewMainCopy.Columns[5].Visible = true;
                Page_NhanVienDA.dataGridViewMainCopy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                Page_NhanVienDA.dataGridViewMainCopy.Columns[0].Width = 100;
                Page_NhanVienDA.dataGridViewMainCopy.Columns[1].Width = 140;
                Page_NhanVienDA.dataGridViewMainCopy.Columns[3].Width = 256;
            }
            dataGridViewMain.RowTemplate.Height = 60;
            dataGridViewMain.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 192);
            dataGridViewMain.DefaultCellStyle.SelectionForeColor = Color.FromArgb(64, 64, 192);
            dataGridViewMain.ColumnHeadersHeight = 50;

            HienDSNhanVienThamGiaTheoTrang();
          
        }

        private void dataGridViewMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (mode == "PCNV")
            {
                if (e.RowIndex >= 0)
                {
                    MaNV = dataGridViewMain.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
                    Frm_NhiemVu nv = new Frm_NhiemVu();
                    nv.Show();
                }
            }

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Frm_ThemPhongBanDuAn tpbda = new Frm_ThemPhongBanDuAn();
            tpbda.Show();
        }
    }
}
