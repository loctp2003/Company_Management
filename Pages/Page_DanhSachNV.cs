using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nest;
using QuanLyDuAn.Dao;
using QuanLyDuAn.Models;
namespace QuanLyDuAn.Pages
{
    public partial class Page_DanhSachNV : UserControl
    {
        NhiemVuNhoDao nvnd = new NhiemVuNhoDao();
        NhiemVuDao nvd = new NhiemVuDao();
        public static List<Page_DanhSachNV_1_> dsnv1List = new List<Page_DanhSachNV_1_>();
        public static List<Page_DanhSachNV_2_> dsnv2List = new List<Page_DanhSachNV_2_>();
        public static Panel panelMainCopy;
        int maNVNho;
        string mode; // NV QL
        public Page_DanhSachNV(string mode)
        {
            InitializeComponent();
            panelMainCopy = panelMain;
            maNVNho = nvnd.MaNhiemVuNhoMax();
            this.mode = mode;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
      
        private void Page_DanhSachNV_Load(object sender, EventArgs e)
        {
            if (mode == "QL")
            {
                btn_Them.Visible = true;
                dsnv1List.Clear();
                var reader = nvnd.DocDuLieuNhiemVuNhoTheoMaNV(Page_NhiemVu.MaNV);
                while (reader.Read())
                {
                    Page_DanhSachNV_1_ dsnv1 = new Page_DanhSachNV_1_(reader["TinhTrang"].ToString().Trim(), Convert.ToInt32(reader["MaNhiemVuNho"].ToString().Trim()), reader["Ten"].ToString().Trim());
                    dsnv1List.Add(dsnv1);
                }
                nvnd.dao.conn.Close();
                panelMain.Controls.Clear();
                for (int i = 0; i < dsnv1List.Count; i++)
                {
                    dsnv1List[i].Location = new Point(10, 10 + (dsnv1List[i].Height + 10) * i);
                    panelMain.Controls.Add(dsnv1List[i]);
                }
            }
            else if (mode == "NV")
            {
                btn_Them.Visible = false;
                dsnv2List.Clear();
                var reader = nvnd.DocDuLieuNhiemVuNhoTheoMaNV(Page_NhiemVu.MaNV);
                while (reader.Read())
                {
                    Page_DanhSachNV_2_ dsnv2 = new Page_DanhSachNV_2_(Convert.ToInt32(reader["MaNhiemVuNho"].ToString().Trim()), reader["Ten"].ToString().Trim(), reader["TinhTrang"].ToString().Trim());
                    dsnv2List.Add(dsnv2);
                }
                nvnd.dao.conn.Close();
                panelMain.Controls.Clear();
                for (int i = 0; i < dsnv2List.Count; i++)
                {
                    dsnv2List[i].Location = new Point(10, 10 + (dsnv2List[i].Height + 10) * i);
                    panelMain.Controls.Add(dsnv2List[i]);
                }
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            maNVNho = maNVNho + 1;
            Page_DanhSachNV_1_ dsnv1 = new Page_DanhSachNV_1_("Them", maNVNho);
            dsnv1List.Insert(0, dsnv1);
            panelMain.Controls.Clear();
            for (int i = 0; i < dsnv1List.Count; i++)
            {
                dsnv1List[i].Location = new Point(10, 10 + (dsnv1List[i].Height + 10) * i);
                panelMain.Controls.Add(dsnv1List[i]);
            }
            
        }
    }
}
