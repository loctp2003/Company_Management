using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDuAn.Pages;
namespace QuanLyDuAn.Forms
{
    public partial class Frm_ThemPhongBanDuAn : Form
    {
        public static Frm_ThemPhongBanDuAn tpbdaCopy;
        public Frm_ThemPhongBanDuAn()
        {
            InitializeComponent();
            tpbdaCopy = this;
        }

        private void Frm_ThemPhongBanDuAn_Load(object sender, EventArgs e)
        {
            Page_TaoPhongBanDuAn tpbda = new Page_TaoPhongBanDuAn("NVTG");
            tpbda.Dock = DockStyle.Fill;
            panel1.Controls.Add(tpbda);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
