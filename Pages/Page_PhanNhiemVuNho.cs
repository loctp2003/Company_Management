using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using FontAwesome.Sharp;
using QuanLyDuAn.Forms;

namespace QuanLyDuAn.Pages
{
    public partial class Page_PhanNhiemVuNho : UserControl
    {
        public BunifuLabel lbl_TenNVCopy;
        public IconButton btn_CheckCopy;
        public Page_PhanNhiemVuNho()
        {
            InitializeComponent();
            lbl_TenNVCopy = lbl_TenNV;
            btn_CheckCopy = btn_Check;
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            txt_TenNV.Visible = false;
            btn_Check.Visible = false;
            btn_XMark.Visible = false;
            lbl_TenNV.Visible = true;
            btn_Sua.Visible = true;
            lbl_TenNV.Text = txt_TenNV.Text;
        }

        private void btn_XMark_Click(object sender, EventArgs e)
        {
            Frm_ThemNhiemVuNho.pnvnList.Remove(this);
            Frm_ThemNhiemVuNho.panelMainCopy.Controls.Clear();
            for (int i = 0; i < Frm_ThemNhiemVuNho.pnvnList.Count; i++)
            {
                Frm_ThemNhiemVuNho.pnvnList[i].Location = new Point(10, 10 + (Frm_ThemNhiemVuNho.pnvnList[i].Height + 10) * i);
                Frm_ThemNhiemVuNho.panelMainCopy.Controls.Add(Frm_ThemNhiemVuNho.pnvnList[i]);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            txt_TenNV.Visible = true;
            btn_Check.Visible = true;
            btn_XMark.Visible = true;
            lbl_TenNV.Visible = false;
            btn_Sua.Visible = false;
        }

        private void Page_PhanNhiemVuNho_Load(object sender, EventArgs e)
        {
            txt_TenNV.Visible = true;
            btn_Check.Visible = true;
            btn_XMark.Visible = true;
            lbl_TenNV.Visible = false;
            btn_Sua.Visible = false;
        }

        private void txt_TenNV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
