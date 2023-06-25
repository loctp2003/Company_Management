using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.BunifuCheckBox.Transitions;

namespace QuanLyDuAn.Pages
{
    public partial class Page_PhanDanhGiaGD : UserControl
    {
        string NgayDanhGia = "";
        int SoSao;
        string LoiDanhGia = "";
        public Page_PhanDanhGiaGD(string ngayDanhGia, int soSao, string loiDanhGia)
        {
            InitializeComponent();
            NgayDanhGia = ngayDanhGia;
            SoSao = soSao;
            LoiDanhGia = loiDanhGia;
        }

        private void Page_PhanDanhGiaGD_Load(object sender, EventArgs e)
        {
            br_DanhGia.ReadOnly = true;
            lbl_Ngay.Text = NgayDanhGia.Split(' ')[0];
            lbl_Gio.Text = NgayDanhGia.Split(' ')[1].Split(':')[0] + ":" + NgayDanhGia.Split(' ')[1].Split(':')[1] + " " + NgayDanhGia.Split(' ')[2];
            br_DanhGia.Value = SoSao;
        }

        private void Page_PhanDanhGiaGD_MouseClick(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.DodgerBlue;
            br_DanhGia.BackColor = Color.DodgerBlue;
            lbl_Ngay.BackColor = Color.DodgerBlue;
            lbl_Gio.BackColor = Color.DodgerBlue;
            if (Page_DanhGiaGD.CurrentPage == null)
            {
                Page_DanhGiaGD.CurrentPage = this;
                Page_DanhGiaGD.br_DanhGiaCopy.Value = SoSao;
                Page_DanhGiaGD.rtx_LoiDanhGiaCopy.Text = LoiDanhGia;
            }
            else if (Page_DanhGiaGD.CurrentPage != this)
            {
                Page_DanhGiaGD.CurrentPage.BackColor = Color.White;
                Page_DanhGiaGD.CurrentPage.br_DanhGia.BackColor= Color.White;
                Page_DanhGiaGD.CurrentPage.lbl_Ngay.BackColor = Color.White;
                Page_DanhGiaGD.CurrentPage.lbl_Gio.BackColor = Color.White;
                Page_DanhGiaGD.CurrentPage = this;
                Page_DanhGiaGD.br_DanhGiaCopy.Value = SoSao;
                Page_DanhGiaGD.rtx_LoiDanhGiaCopy.Text = LoiDanhGia;
            }
        }
    }
}
