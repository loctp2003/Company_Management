using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace QuanLyDuAn.Pages
{
    public delegate void HienThi();
    public partial class Page_Trang : UserControl
    {
        private HienThi hienthi;
        public static int trangCopy;
        public static int soDongMoiTrangCopy;
        public int trang = 1;
        public int soTrang { get; set; }
        public int soDongMoiTrang { get; set; }
        public IconButton currButtonPage;
        public List<IconButton> btnList = new List<IconButton>();
        public static IconButton btn_PrevCopy;
        public static IconButton btn_NextCopy;
        public Page_Trang(HienThi hienthi, int soTrang, int soDongMoiTrang)
        {
            InitializeComponent();
            this.hienthi = hienthi;
            btn_PrevCopy = btn_Prev;
            btn_NextCopy = btn_Next;
            trang = 1;
            this.soTrang = soTrang;
            this.soDongMoiTrang = soDongMoiTrang;
            trangCopy = trang;
            soDongMoiTrangCopy = soDongMoiTrang;
        }    
        private void Page_Trang_Load(object sender, EventArgs e)
        {
            
        }
        public void HienThiCacTrang()
        {
            panelPage.Controls.Clear();
            IconButton btn_Next = new IconButton();
            btn_Next.Text = "Next";
            btn_Next.Font = new Font(new FontFamily("Segoe UI Semibold"), 11, FontStyle.Regular);
            btn_Next.IconChar = IconChar.ChevronRight;
            btn_Next.IconSize = 25;
            btn_Next.IconColor = Color.FromArgb(64, 64, 64);
            btn_Next.ImageAlign = ContentAlignment.MiddleCenter;
            btn_Next.BackColor = Color.WhiteSmoke;
            btn_Next.Size = new Size(91, 45);
            btn_Next.Location = new Point(panelPage.Width - btn_Next.Width, 0);
            btn_Next.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_Next.Click += new System.EventHandler(btn_Next_Click);
            IconButton btn_Prev = new IconButton();
            panelPage.Controls.Add(btn_Next);
            if (soTrang <= 5)
            {
                for (int i = 1; i <= soTrang; i++)
                {
                    btnList[i - 1].Location = new Point(btn_Next.Location.X - (soTrang - (i - 1)) * 45, 0);
                    panelPage.Controls.Add(btnList[i - 1]);
                }
                
                btn_Prev.Text = "Prev";
                btn_Prev.Font = new Font(new FontFamily("Segoe UI Semibold"), 11, FontStyle.Regular);
                btn_Prev.IconChar = IconChar.ChevronLeft;
                btn_Prev.IconSize = 25;
                btn_Prev.IconColor = Color.FromArgb(64, 64, 64);
                btn_Prev.ImageAlign = ContentAlignment.MiddleCenter;
                btn_Prev.BackColor = Color.WhiteSmoke;
                btn_Prev.Size = new Size(91, 45);
                btn_Prev.Location = new Point(btn_Next.Location.X - soTrang * 45 - btn_Prev.Width, 0);
                btn_Prev.TextImageRelation = TextImageRelation.ImageBeforeText;
                btn_Prev.Click += new System.EventHandler(btn_Prev_Click);
                panelPage.Controls.Add(btn_Prev);
            }
            else
            {
                int k = 1;
                btnList[soTrang - 1].Location = new Point(btn_Next.Location.X - k * 45, 0);
                k++;
                panelPage.Controls.Add(btnList[soTrang - 1]);

                IconButton btnEllipse_5TrangKe = btnEllipsis_5TrangKe();

                if (soTrang - (trang + 3) >= 2)
                {
                    btnEllipse_5TrangKe.Location = new Point(btn_Next.Location.X - k * 45, 0);
                    k++;
                    panelPage.Controls.Add(btnEllipse_5TrangKe);
                }
                else if (soTrang - (trang + 3) > 0)
                {
                    btnList[soTrang - (soTrang - (trang + 3)) - 1].Location = new Point(btn_Next.Location.X - k * 45, 0);
                    k++;
                    panelPage.Controls.Add(btnList[soTrang - (soTrang - (trang + 3)) - 1]);
                }

                for (int i = 2; i >= -2; i--)
                {
                    if (trang + i > 1 && trang + i < soTrang)
                    {
                        btnList[trang + i - 1].Location = new Point(btn_Next.Location.X - k * 45, 0);
                        k++;
                        panelPage.Controls.Add(btnList[trang + i - 1]);
                    }
                }

                IconButton btnEllipse_5TrangTruoc = btnEllipsis_5TrangTruoc();
                if ((trang - 3) - 1 >= 2)
                {
                    btnEllipse_5TrangTruoc.Location = new Point(btn_Next.Location.X - k * 45, 0);
                    k++;
                    panelPage.Controls.Add(btnEllipse_5TrangTruoc);
                }
                else if (trang - 3 - 1 > 0)
                {
                    btnList[1 + (trang - 3) - 1 - 1].Location = new Point(btn_Next.Location.X - k * 45, 0);
                    k++;
                    panelPage.Controls.Add(btnList[1 + (trang - 3) - 1 - 1]);
                }
                btnList[0].Location = new Point(btn_Next.Location.X - k * 45, 0);

                panelPage.Controls.Add(btnList[0]);
                btn_Prev.Text = "Prev";
                btn_Prev.Font = new Font(new FontFamily("Segoe UI Semibold"), 11, FontStyle.Regular);
                btn_Prev.IconChar = IconChar.ChevronLeft;
                btn_Prev.IconSize = 25;
                btn_Prev.IconColor = Color.FromArgb(64, 64, 64);
                btn_Prev.ImageAlign = ContentAlignment.MiddleCenter;
                btn_Prev.BackColor = Color.WhiteSmoke;
                btn_Prev.Size = new Size(91, 45);
                btn_Prev.Location = new Point(btn_Next.Location.X - k * 45 - btn_Prev.Width, 0);
                btn_Prev.TextImageRelation = TextImageRelation.ImageBeforeText;
                btn_Prev.Click += new System.EventHandler(btn_Prev_Click);
                panelPage.Controls.Add(btn_Prev);
            }
            btn_Prev.Enabled = trang == 1 ? false : true;
            btn_Next.Enabled = trang == soTrang ? false : true;
            hienThiMauTrangHienTai(btnList[trang - 1]);
        }
        private void btn_Prev_Click(object sender, EventArgs e)
        {
            if (trang > 1)
            {
                anMauTrangTruoc(currButtonPage);
                trang--;
                HienThiCacTrang();
                btn_Prev.Enabled = trang == 1 ? false : true;
                btn_Next.Enabled = trang == soTrang ? false : true;
                hienthi();
                currButtonPage = btnList[trang - 1];
                hienThiMauTrangHienTai(currButtonPage);
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (trang < soDongMoiTrang)
            {
                anMauTrangTruoc(currButtonPage);
                trang++;
                HienThiCacTrang();
                btn_Prev.Enabled = trang == 1 ? false : true;
                btn_Next.Enabled = trang == soTrang ? false : true;
                hienthi();
                currButtonPage = btnList[trang - 1];
                hienThiMauTrangHienTai(currButtonPage);
            }
        }
        private IconButton btnEllipsis_5TrangKe()
        {
            IconButton btnEllipsis = new IconButton();
            btnEllipsis.Text = "";
            btnEllipsis.IconChar = IconChar.Ellipsis;
            btnEllipsis.IconSize = 25;
            btnEllipsis.IconColor = Color.FromArgb(64, 64, 64);
            btnEllipsis.ImageAlign = ContentAlignment.BottomCenter;
            btnEllipsis.BackColor = Color.WhiteSmoke;
            btnEllipsis.Location = new Point(btn_Prev.Width + 3 * 45, 0);
            btnEllipsis.Size = new Size(45, 45);
            btnEllipsis.FlatAppearance.BorderSize = 1;
            btnEllipsis.Click += new System.EventHandler((sender, e) =>
            {
                anMauTrangTruoc(currButtonPage);
                trang += 5;
                HienThiCacTrang();
                btn_Prev.Enabled = trang == 1 ? false : true;
                btn_Next.Enabled = trang == soTrang ? false : true;
                hienthi();
                currButtonPage = btnList[trang - 1];
                hienThiMauTrangHienTai(currButtonPage);
            });

            return btnEllipsis;
        }
        private IconButton btnEllipsis_5TrangTruoc()
        {
            IconButton btnEllipsis = new IconButton();
            btnEllipsis.Text = "";
            btnEllipsis.IconChar = IconChar.Ellipsis;
            btnEllipsis.IconSize = 25;
            btnEllipsis.IconColor = Color.FromArgb(64, 64, 64);
            btnEllipsis.ImageAlign = ContentAlignment.BottomCenter;
            btnEllipsis.BackColor = Color.WhiteSmoke;
            btnEllipsis.Location = new Point(btn_Prev.Width + 3 * 45, 0);
            btnEllipsis.Size = new Size(45, 45);
            btnEllipsis.FlatAppearance.BorderSize = 1;
            btnEllipsis.Click += new System.EventHandler((sender, e) =>
            {
                anMauTrangTruoc(currButtonPage);
                trang -= 5;
                HienThiCacTrang();
                btn_Prev.Enabled = trang == 1 ? false : true;
                btn_Next.Enabled = trang == soTrang ? false : true;
                hienthi();
                currButtonPage = btnList[trang - 1];
                hienThiMauTrangHienTai(currButtonPage);
            });
            return btnEllipsis;
        }
        public void anMauTrangTruoc(IconButton ib)
        {
            currButtonPage = ib;
            currButtonPage.BackColor = Color.WhiteSmoke;
        }

        public void hienThiMauTrangHienTai(IconButton ib)
        {
            currButtonPage = ib;
            currButtonPage.BackColor = Color.DodgerBlue;
        }
    }
}
