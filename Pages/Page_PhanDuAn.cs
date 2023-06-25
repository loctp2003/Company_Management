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

namespace QuanLyDuAn.Pages
{
    public partial class Page_PhanDuAn : UserControl
    {
        private string TenDA;
        private string TenNQL;
        private byte[] Anh;
        public int MaDA;
        public Page_PhanDuAn(string tenDA, string tenNQL, byte[] anh, int maDA)
        {
            InitializeComponent();
            TenDA = tenDA;
            TenNQL = tenNQL;
            Anh = anh;
            MaDA = maDA;
            
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
        private void lbl_MieuTa_Click(object sender, EventArgs e)
        {

        }

        private void Page_PhanDuAn_Load(object sender, EventArgs e)
        {
            lbl_TenDA.Text = TenDA;
            lbl_TenNQL.Text = TenNQL;
            pc_Anh.Image = ConvertBinaryToImage(Anh);
        }

        private void Page_PhanDuAn_Click(object sender, EventArgs e)
        {
            Page_PhanCongNhiemVu.panelMainCopy.Controls.Clear();
            Page_NhanVienDA nvda = new Page_NhanVienDA("PCNV", MaDA);
            nvda.Location = new Point(0, 0);
            nvda.Dock = DockStyle.Fill;
            Page_PhanCongNhiemVu.panelMainCopy.Controls.Add(nvda);
            Page_PhanCongNhiemVu.MaDA = MaDA;
            if (Page_PhanCongNhiemVu.currPage == null)
            {
                this.BackColor = Color.DodgerBlue;
                Page_PhanCongNhiemVu.currPage = this;
            }
            else
            {
                Page_PhanCongNhiemVu.currPage.BackColor = Color.White;
                this.BackColor = Color.DodgerBlue;
                Page_PhanCongNhiemVu.currPage = this;
            }
        }
    }
}
