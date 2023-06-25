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
    public partial class Page_PhanLam : UserControl
    {
        NopFileDao nfd = new NopFileDao();
        public Page_PhanLam()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelFile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Page_PhanLam_Load(object sender, EventArgs e)
        {
           
            var reader = nfd.DanhSachFileTheoMaNVVaMaNSH(Page_NhiemVu.MaNV, Page_NhiemVu.MaNSH);
            int i = 0;
            while (reader.Read())
            {
                Page_FileAttachment pfa = new Page_FileAttachment(reader["TenFile"].ToString().Trim(), reader["Filter"].ToString().Trim(), (byte[])reader["TaiLieu"]);
                pfa.Location = new Point(10, 10 + (pfa.Height + 10) * i);
                panelFile.Controls.Add(pfa);
                i++;
            }
            nfd.dao.conn.Close();
            if (i > 0)
            {
                panel2.Visible = false;
            }
            else panel2.Visible = true;
        }
    }
}
