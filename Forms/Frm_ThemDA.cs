using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Bunifu.UI.WinForms.BunifuButton;
using QuanLyDuAn.Pages;

namespace QuanLyDuAn.Forms
{
    public partial class Frm_ThemDA : Form
    {
        public static Panel panelMainCopy;
        public static BunifuButton btn_ThongTinCopy;
        public static BunifuButton btn_PhongBanCopy;
        public static BunifuButton btn_NhiemVuCopy;
        public static Frm_ThemDA frm_ThemDACopy;
        public static Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1Copy;

        public Frm_ThemDA()
        {
            InitializeComponent();
            panelMainCopy = panelMain;
            btn_ThongTinCopy = btn_ThongTin;
            btn_PhongBanCopy = btn_PhongBan;
            btn_NhiemVuCopy = btn_NhiemVu;
            bunifuSeparator1Copy = bunifuSeparator1;
            frm_ThemDACopy = this;
            ttda = new Page_TaoThongTinDuAn();
            nvda = new Page_TaoNhiemVuDuAn();
            pbda = new Page_TaoPhongBanDuAn("DA");
        }
        public static Page_TaoThongTinDuAn ttda = new Page_TaoThongTinDuAn();
        public static Page_TaoNhiemVuDuAn nvda = new Page_TaoNhiemVuDuAn();
        public static Page_TaoPhongBanDuAn pbda = new Page_TaoPhongBanDuAn("DA");
        private void btn_ThongTin_Click(object sender, EventArgs e)
        {
            bunifuSeparator1.Location = new Point(btn_ThongTin.Location.X, bunifuSeparator1.Location.Y);
            bunifuSeparator1.Width = btn_ThongTin.Width;
            if (!panelMain.Controls.Contains(ttda))
            {
                panelMain.Controls.Clear();
                ttda.Dock = DockStyle.Fill;
                panelMain.Controls.Add(ttda);
            }

        }

        private void btn_PhongBan_Click(object sender, EventArgs e)
        {
            bunifuSeparator1.Location = new Point(btn_PhongBan.Location.X, bunifuSeparator1.Location.Y);
            bunifuSeparator1.Width = btn_PhongBan.Width;
            if (!panelMain.Controls.Contains(pbda))
            {
                panelMain.Controls.Clear();
                pbda.Dock = DockStyle.Fill;
                panelMain.Controls.Add(pbda);
            }
        }

        private void btn_NhiemVu_Click(object sender, EventArgs e)
        {
            bunifuSeparator1.Location = new Point(btn_NhiemVu.Location.X, bunifuSeparator1.Location.Y);
            bunifuSeparator1.Width = btn_NhiemVu.Width;
            if (!panelMain.Controls.Contains(nvda))
            {
                panelMain.Controls.Clear();
                nvda.Dock = DockStyle.Fill;
                panelMain.Controls.Add(nvda);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Page_TaoPhongBanDuAn.maPBList.Clear();
            Page_TaoPhongBanDuAn.tenPBList.Clear();
            Page_TaoNhiemVuDuAn.panelList.Clear();
            Page_TaoNhiemVuDuAn.panelMainCopy.Controls.Clear();
            foreach (var pb in Page_TaoPhongBanDuAn.page_pbList)
            {
                pb.cb.Checked = false;
            }
            panelMain.Controls.Clear();
            this.Close();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Frm_ThemDA_Load(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(ttda))
            {
                panelMain.Controls.Clear();
                ttda.Dock = DockStyle.Fill;
                panelMain.Controls.Add(ttda);
            }
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
