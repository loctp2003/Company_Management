using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDuAn.Dao;

namespace QuanLyDuAn.Pages
{
    public partial class Page_CapNhatNV : UserControl
    {
        NhiemVuNhoDao nvnd = new NhiemVuNhoDao();
        List<Page_CapNhatNV_1_> cnnv1List = new List<Page_CapNhatNV_1_>();
        public static List<int> tiLeHTList = new List<int>();
        public Page_CapNhatNV()
        {
            InitializeComponent();
        }

        private void Page_CapNhatNV_Load(object sender, EventArgs e)
        {
            var reader = nvnd.DocDuLieuNhiemVuNhoTheoMaNV(Page_NhiemVu.MaNV);
            int k = 0;
            cnnv1List.Clear();
            tiLeHTList.Clear();
            while (reader.Read())
            {
                Page_CapNhatNV_1_ cnnv1 = new Page_CapNhatNV_1_(k, Convert.ToInt32(reader["MaNhiemVuNho"].ToString().Trim()), reader["Ten"].ToString().Trim());
                cnnv1List.Add(cnnv1);
                k++;
                tiLeHTList.Add(Convert.ToInt32(reader["TiLeHT"].ToString().Trim()));
            }
            nvnd.dao.conn.Close();
            panelMain.Controls.Clear();
            for (int i = 0; i < cnnv1List.Count; i++)
            {
                cnnv1List[i].Location = new Point(10, 10 + (cnnv1List[i].Height + 10) * i);
                panelMain.Controls.Add(cnnv1List[i]);
            }
            
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
