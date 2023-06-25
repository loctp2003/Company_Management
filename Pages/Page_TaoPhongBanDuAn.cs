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
using Bunifu.Framework.UI;
using QuanLyDuAn.Dao;
using QuanLyDuAn.Forms;
using QuanLyDuAn.Models;

namespace QuanLyDuAn.Pages
{
    public partial class Page_TaoPhongBanDuAn : UserControl
    {
        NhanVienThamGiaDADao nvtgd = new NhanVienThamGiaDADao();
        PhongBanDao pbd = new PhongBanDao();
        public static Label lbl_CountSelectedCopy;
        public static List<Page_PhongBan> page_pbList = new List<Page_PhongBan>();
        public static List<string> maPBList = new List<string>();
        public static List<string> tenPBList = new List<string>();
        string chucNang; // DA, NVTG
        public Page_TaoPhongBanDuAn(string chucNang)
        {
            InitializeComponent();
            lbl_CountSelectedCopy = lbl_CountSelected;
            this.chucNang = chucNang;
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
        System.Drawing.Image ConvertBinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                System.Drawing.Image image = Image.FromStream(ms);
                ms.Close();
                return image;
            }
        }
        private void Page_TaoPhongBanDuAn_Load(object sender, EventArgs e)
        {
            if (chucNang == "DA")
            {
                btn_TiepTuc.Visible = true;
                btn_QuayLai.Visible = true;
                btn_Them.Visible = false;
                btn_Huy.Visible = false;
            }
            else if (chucNang == "NVTG")
            {
                btn_TiepTuc.Visible = false;
                btn_QuayLai.Visible = false;
                btn_Them.Visible = true;
                btn_Huy.Visible = true;
            }

            List<object[]> obList = new List<object[]>();
            var readerTT = pbd.DocDuLieuThongTinPhongBan();
            while (readerTT.Read())
            {
                obList.Add(new object[] { readerTT["MaPB"].ToString().Trim(), readerTT["TenPB"].ToString().Trim(), Convert.ToInt32(readerTT["SoNV"].ToString().Trim()) });
            }
            pbd.dao.conn.Close();
            int count = 0;
            for (int i = 0; i < obList.Count; i++)
            {
                Image[] obImg = new Image[5];
                var reader = pbd.DocDuLieuAnhNVCuaPhongBan(obList[i][0].ToString());
                int k = 0;
                while (reader.Read())
                {
                    if (reader["Anh"].GetType() != typeof(DBNull))
                    {
                        obImg[k] = ConvertBinaryToImage((byte[])reader["Anh"]);
                        k++;
                    }
                }
                pbd.dao.conn.Close();
                if (chucNang == "DA")
                {
                    Page_PhongBan page_PhongBan = new Page_PhongBan(chucNang, obList[i][0].ToString(), obList[i][1].ToString(), Convert.ToInt32(obList[i][2].ToString()), obImg);
                    page_PhongBan.Location = new Point(23, 25 + i * (page_PhongBan.Height + 10));
                    panelMain.Controls.Add(page_PhongBan);
                    page_pbList.Add(page_PhongBan);
                }
                else if (chucNang == "NVTG")
                {
                    if (!Page_NhanVienDA.maPBSet.Contains(obList[i][0].ToString()))
                    {
                        Page_PhongBan page_PhongBan = new Page_PhongBan(chucNang, obList[i][0].ToString(), obList[i][1].ToString(), Convert.ToInt32(obList[i][2].ToString()), obImg);
                        page_PhongBan.Location = new Point(23, 25 + count * (page_PhongBan.Height + 10));
                        count++;
                        panelMain.Controls.Add(page_PhongBan);
                        page_pbList.Add(page_PhongBan);
                    }
                }
            }
        }

        private void lbl_CountSelected_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        { 
            Frm_ThemDA.bunifuSeparator1Copy.Location = new Point(Frm_ThemDA.btn_ThongTinCopy.Location.X, Frm_ThemDA.bunifuSeparator1Copy.Location.Y);
            Frm_ThemDA.bunifuSeparator1Copy.Width = Frm_ThemDA.btn_ThongTinCopy.Width;
            if (!Frm_ThemDA.panelMainCopy.Controls.Contains(Frm_ThemDA.ttda))
            {
                Frm_ThemDA.panelMainCopy.Controls.Clear();
                Frm_ThemDA.ttda.Dock = DockStyle.Fill;
                Frm_ThemDA.panelMainCopy.Controls.Add(Frm_ThemDA.ttda);
            }
        }

        private void btn_TiepTuc_Click(object sender, EventArgs e)
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

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Frm_ThemPhongBanDuAn.tpbdaCopy.Close();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            foreach (string maPB in Page_TaoPhongBanDuAn.maPBList)
            {
                List<string> maNVList = new List<string>();
                var reader1 = pbd.DocDuLieuNVCuaPhongBan(maPB);
                while (reader1.Read())
                {
                    maNVList.Add(reader1["MaNV"].ToString().Trim());
                }
                pbd.dao.conn.Close();
                foreach (string maNV in maNVList)
                {
                    nvtgd.ThemNhanVienThamGiaDA(new NhanVienThamGiaDA(Page_DA.MaDA, maNV));
                }
            }
            var pageTrang = Page_ThongTinDuAn.panelMainCopy.Controls.OfType<Page_NhanVienDA>().ToList();
            if (pageTrang.Any())
            {
                var firstPageTrang = pageTrang.First();
                Page_ThongTinDuAn.panelMainCopy.Controls.Remove(firstPageTrang);
                Page_NhanVienDA nvda = new Page_NhanVienDA("DA", Page_DA.MaDA);
                nvda.Dock = DockStyle.Fill;
                Page_ThongTinDuAn.nvda = nvda;
                Page_ThongTinDuAn.panelMainCopy.Controls.Add(nvda);
            }
            Frm_ThemPhongBanDuAn.tpbdaCopy.Close();
        }
    }
}
