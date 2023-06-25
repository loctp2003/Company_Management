using QuanLyDuAn.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuAn.Dao
{
    public partial class Frm_UngVien : Form
    {
        UngVienDao uvd = new UngVienDao();
        public Frm_UngVien()
        {
            InitializeComponent();
        }

        private void Frm_UngVien_Load(object sender, EventArgs e)
        {
            this.dgv_UngVien.DataSource = uvd.DanhSachNhanVien();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else
                WindowState = FormWindowState.Normal;
        }
    }
}
