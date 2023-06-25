using System;
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
using QuanLyDuAn.Dao;
using QuanLyDuAn.Forms;
using QuanLyDuAn.Models;


namespace QuanLyDuAn.Pages
{

    public partial class Page_TaoNhiemVuDuAn : UserControl
    {
        DuAnDao dad = new DuAnDao();
        NhiemVuDao nvd = new NhiemVuDao();
        NhiemVuNhoDao nvnd = new NhiemVuNhoDao();
        PhongBanDao pbd = new PhongBanDao();
        NhanVienThamGiaDADao nvtgd = new NhanVienThamGiaDADao();
        public static Panel panelMainCopy;
        public static Page_TaoNhiemVuDuAn tnvda;
        public static List<object> panelList = new List<object>();
        public static List<NhiemVu> nhiemVuList = new List<NhiemVu>();
        public static BunifuShapes bs_EllipsisCopy;
        public static Panel panel_EllipsisCopy;
        public Page_TaoNhiemVuDuAn()
        {
            InitializeComponent();
            panelMainCopy = panelMain;
            bs_EllipsisCopy = bs_Ellipsis;
            panel_EllipsisCopy = panelEllipsis;
            tnvda = this;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Page_TaoNhiemVuDuAn_Load(object sender, EventArgs e)
        {


        }

        private void panelMain_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            Frm_ThemDA.bunifuSeparator1Copy.Location = new Point(Frm_ThemDA.btn_NhiemVuCopy.Location.X, Frm_ThemDA.bunifuSeparator1Copy.Location.Y);
            Frm_ThemDA.bunifuSeparator1Copy.Width = Frm_ThemDA.btn_NhiemVuCopy.Width;
            if (!Frm_ThemDA.panelMainCopy.Controls.Contains(Frm_ThemDA.nvda))
            {
                Frm_ThemDA.panelMainCopy.Controls.Clear();
                Frm_ThemDA.nvda.Dock = DockStyle.Fill;
                Frm_ThemDA.panelMainCopy.Controls.Add(Frm_ThemDA.nvda);

            }
        }
        byte[] changeFileToByte(string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                byte[] bytes = System.IO.File.ReadAllBytes(filename);
                fs.Read(bytes, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
                return bytes;
            }
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            int maDA = dad.MaDuAnMax();
            string tenDA = Page_TaoThongTinDuAn.txt_TenDuAnCopy.Text.Trim();
            string mieuTa = Page_TaoThongTinDuAn.txt_MieuTaCopy.Text.Trim();
            string tenNQL = Page_TaoThongTinDuAn.cb_TenNguoiQuanLyCopy.Text.Trim();
            DateTime date_NgayBD = Convert.ToDateTime(Page_TaoThongTinDuAn.date_NgayBatDauCopy.Text);
            DateTime date_NgayKT = Convert.ToDateTime(Page_TaoThongTinDuAn.date_NgayKetThucCopy.Text);
            string tinhTrang = DateTime.Now < date_NgayBD ? "Not Started" : "In Progress";
            if (Page_TaoThongTinDuAn.chucNangMieuTa == "TaiLieu")
            {
                byte[] file = changeFileToByte(Page_TaoThongTinDuAn.fileName);
                dad.ThemDuAn(new Models.DuAn(maDA + 1, tenDA, null, tinhTrang, tenNQL.Split('-')[0], file, date_NgayBD, date_NgayKT, DateTime.Now));
            }
            else if (Page_TaoThongTinDuAn.chucNangMieuTa == "Text")
            {
                dad.ThemDuAn(new Models.DuAn(maDA + 1, tenDA, mieuTa, tinhTrang, tenNQL.Split('-')[0], null, date_NgayBD, date_NgayKT, DateTime.Now));
            }

            foreach (var nv in nhiemVuList)
            {
                nvd.ThemNhiemVu(nv);
            }
            foreach (var nvn in Frm_ThemNhiemVuNho.nvnList)
            {
                nvnd.ThemNhiemVuNho(nvn);
            }
            foreach (string maPB in Page_TaoPhongBanDuAn.maPBList)
            {
                List<string> maNVList = new List<string>();
                var reader1 = pbd.DocDuLieuNVCuaPhongBan(maPB);
                while (reader1.Read())
                {
                    maNVList.Add(reader1["MaNV"].ToString().Trim());
                }
                pbd.dao.conn.Close();
                foreach(string maNV in maNVList)
                {
                    nvtgd.ThemNhanVienThamGiaDA(new NhanVienThamGiaDA(maDA + 1, maNV));
                }
            }
            nhiemVuList.Clear();
            Frm_ThemNhiemVuNho.nvnList.Clear();
            Page_TaoPhongBanDuAn.maPBList.Clear();
            Page_TaoNhiemVuDuAn.panelList.Clear();
            Frm_ThemDA.frm_ThemDACopy.Close();

            var pageTrang = Frm_Main.panelMainCopy.Controls.OfType<Page_DA>().ToList();
            if (pageTrang.Any())
            {
                var firstPageTrang = pageTrang.First();
                Frm_Main.panelMainCopy.Controls.Remove(firstPageTrang);
                Page_DA pda = new Page_DA();
                pda.Dock = DockStyle.Fill;
                Page_DA.pdaCopy = pda;
                Frm_Main.panelMainCopy.Controls.Add(pda);
            }
        }
    }
}
