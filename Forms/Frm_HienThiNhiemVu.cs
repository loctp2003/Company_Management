using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDuAn.Dao;
using QuanLyDuAn.Pages;
using QuanLyDuAn.Tools;

namespace QuanLyDuAn.Forms
{
    public partial class Frm_HienThiNhiemVu : Form
    {
        NhiemVuDao nhvd = new NhiemVuDao();
        public Frm_HienThiNhiemVu()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frm_HienThiNhiemVu_Load(object sender, EventArgs e)
        {
            DataGridViewBadgeColumn c = new DataGridViewBadgeColumn();
            c.HeaderText = "Tình Trạng";
            c.MinimumWidth = 200;
            dataGridViewMain.Columns.Insert(4, c);
            c.DataPropertyName = "TTrang";

            SqlDataReader reader = nhvd.DocDuDieuNhiemVuTuMaDA(Convert.ToInt32(Page_DuAn.MaDA));

            while (reader.Read())
            {
                object[] ob = new object[] { null, reader["TenDuAn"].ToString().Trim(), reader["TenNhiemVu"].ToString().Trim(), reader["HoTen"].ToString().Trim(), reader["TTrang"].ToString().Trim(), reader["NBatDau"].ToString().Trim().Split(' ')[0], reader["NKetThuc"].ToString().Trim().Split(' ')[0], "(45/54)", 64 };
                dataGridViewMain.Rows.Add(ob);
            }
            nhvd.dao.conn.Close();
        }
    }
}
