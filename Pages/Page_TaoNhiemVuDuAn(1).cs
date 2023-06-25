using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDuAn.Dialogs;
using QuanLyDuAn.Forms;

namespace QuanLyDuAn.Pages
{
    public partial class Page_TaoNhiemVuDuAn_1_ : UserControl
    {
        public string tenPB;
        private string maPB;
        public static Page_TaoNhiemVuDuAn_1_ tnvda1;
        public Page_TaoNhiemVuDuAn_1_(string tenPB, string maPB)
        {
            InitializeComponent();
            this.tenPB = tenPB;
            this.maPB = maPB;
           
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            tnvda1 = this;
            Frm_ThemNhiemVu tnv = new Frm_ThemNhiemVu(maPB, "DA");
            tnv.Show();
        }

        private void lbl_TenPB_Click(object sender, EventArgs e)
        {

        }

        private void Page_TaoNhiemVuDuAn_1__Load(object sender, EventArgs e)
        {
            lbl_TenPB.Text = tenPB;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
