using QuanLyDuAn.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using UserControl = System.Windows.Forms.UserControl;

namespace QuanLyDuAn.Pages
{
    public partial class Page_TuyenDung : UserControl
    {
        TuyenDungDao tdd = new TuyenDungDao();
        public Page_TuyenDung()
        {
            InitializeComponent();
        }

        private void Page_TuyenDung_Load(object sender, EventArgs e)
        {
            this.dgv_TuyenDung.DataSource = tdd.DanhSachNhanVien();
        }
        private void btn_Reload_Click(object sender, EventArgs e)
        {
            dgv_TuyenDung.Columns.Clear();
            dgv_TuyenDung.DataSource = tdd.DanhSachNhanVien();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            var ds = tdd.TimKiemNhanVien(txt_Search.Text);
            dgv_TuyenDung.DataSource = ds;
        }

        private void dgv_TuyenDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgv_TuyenDung.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                Frm_UngVien uv = new Frm_UngVien();
                uv.Show();
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Frm_ThemTD ttd = new Frm_ThemTD();
            ttd.Show();
        }
    }
}
