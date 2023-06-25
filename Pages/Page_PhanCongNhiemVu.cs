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
    public partial class Page_PhanCongNhiemVu : UserControl
    {
        DuAnDao dad = new DuAnDao();
        public static Page_PhanDuAn currPage;
        public static Panel panelMainCopy;
        public static int MaDA;
        public Page_PhanCongNhiemVu()
        {
            InitializeComponent();
            panelMainCopy = panelMain;
        }

        private void Page_PhanCongNhiemVu_Load(object sender, EventArgs e)
        {
            var reader = dad.DanhSachDuAnTheoMaNV(Frm_Main.MaNhanVien);
            int i = 0;
            while (reader.Read())
            {
                Page_PhanDuAn pda = new Page_PhanDuAn(reader["TenDuAn"].ToString().Trim(), reader["HoTen"].ToString().Trim(), (byte[])reader["Anh"], Convert.ToInt32(reader["MaDA"].ToString().Trim()));
                pda.Location = new Point(0, 0 + (pda.Height * i));
                panel_DuAn.Controls.Add(pda);
                i++;
            }
            dad.dao.conn.Close();
        }
    }
}
