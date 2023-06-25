using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Microsoft.Office.Core;
using QuanLyDuAn.Dao;
using QuanLyDuAn.Dialogs;
using QuanLyDuAn.Tools;

namespace QuanLyDuAn.Pages
{
    public partial class Page_NhiemVuDA : UserControl
    {
        NhiemVuDao nvd = new NhiemVuDao();
        public static Page_NhiemVuDA nvdaCopy;
        int soNV;
        public Page_NhiemVuDA()
        {
            InitializeComponent();
            nvdaCopy = this;
        }
        private void HienDSNhiemVuDATheoTrang()
        {
            soNV = nvd.DemNhiemVuTheoMaDA(Page_DA.MaDA);
            lbl_SoNV.Text = soNV.ToString();
            HienDSTheoTrang(HienDSNhiemVuDA);
        }
        private void HienDSNhiemVuDA()
        {
            var reader = nvd.DocDuDieuNhiemVuTuMaDA(Page_DA.MaDA);
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
            nvd.dao.conn.Close();
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
            
            Page_Trang ptrang = new Page_Trang(hienthi, (soNV / 6) + 1, 6);
            currPTrang = ptrang;
            ptrang.Location = new Point(971, 525);
            panel2.Controls.Add(ptrang);
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
        private void Page_NhiemVuDA_Load(object sender, EventArgs e)
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

            HienDSNhiemVuDATheoTrang();
        }
        private void dataGridViewMain_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Frm_ThemNhiemVu tnv = new Frm_ThemNhiemVu("NVTG");
            tnv.Show();
        }
    }
}
