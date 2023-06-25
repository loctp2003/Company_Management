using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using QuanLyDuAn.Dao;
using QuanLyDuAn.Dao.Dao;
using QuanLyDuAn.Pages;

namespace QuanLyDuAn.Forms
{
    public partial class Frm_ThongTinNhanVien : Form
    {
        private string MaNV;
        private string ChucNang;
        private NhanVienDao nvd = new NhanVienDao();
        private PhongBanDao pbd = new PhongBanDao();
        private ChucVuDao cvd = new ChucVuDao();
        public static IconButton btn_ChevronLeftCopy;
        public static IconButton btn_ChevronRightCopy;
        public Frm_ThongTinNhanVien(string MaNV, string ChucNang)
        {
            InitializeComponent();
            btn_ChevronLeft.Enabled = false;
            this.MaNV = MaNV; 
            this.ChucNang = ChucNang;
            btn_ChevronLeftCopy = btn_ChevronLeft;
            btn_ChevronRightCopy = btn_ChevronRight;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            


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
        private void ReadOnly()
        {
            txt_HoTen.ReadOnly = true;
            txt_GioiTinh.ReadOnly = true;
            txt_TinhTrangHN.ReadOnly = true;
            txt_DiaChi.ReadOnly = true;
            txt_QueQuan.ReadOnly = true;
            txt_NgaySinh.ReadOnly = true;
            txt_DanToc.ReadOnly = true;

            txt_MaNV.ReadOnly = true;
            txt_HinhThucLV.ReadOnly = true;
            txt_NgayVao.ReadOnly = true;
            txt_ViTri.ReadOnly = true;
            txt_PhongBan.ReadOnly = true;
            txt_TinhTrangLV.ReadOnly = true;
        }
        private void NoReadOnly()
        {
            txt_HoTen.ReadOnly = false;
            txt_GioiTinh.ReadOnly = false;
            txt_TinhTrangHN.ReadOnly = false;
            txt_DiaChi.ReadOnly = false;
            txt_QueQuan.ReadOnly = false;
            txt_NgaySinh.ReadOnly = false;
            txt_DanToc.ReadOnly = false;

            txt_MaNV.ReadOnly = false;
            txt_HinhThucLV.ReadOnly = false;
            txt_NgayVao.ReadOnly = false;
            txt_ViTri.ReadOnly = false;
            txt_PhongBan.ReadOnly = false;
            txt_TinhTrangLV.ReadOnly = false;
        }
        private void CheDoSua()
        {
            NoReadOnly();
            btn_Luu.Show();
            btn_Huy.Show();
            btn_Xoa.Hide();
            btn_Sua.Hide();
            btn_CapNhatAnh.Visible = true;

            txt_GioiTinh.Visible = false;
            txt_QueQuan.Visible = false;
            txt_NgaySinh.Visible = false;
            txt_TinhTrangHN.Visible = false;
            txt_DanToc.Visible = false;
            txt_ViTri.Visible = false;
            txt_PhongBan.Visible = false;
            txt_HinhThucLV.Visible = false;
            txt_NgayVao.Visible = false;
            txt_TinhTrangLV.Visible = false;

            cb_GioiTinh.Visible = true;
            cb_QueQuan.Visible = true;
            date_NgaySinh.Visible = true;
            cb_HonNhan.Visible = true;
            cb_DanToc.Visible = true;
            cb_ViTri.Visible = true;
            cb_PhongBan.Visible = true;
            cb_HinhThucLV.Visible = true;
            date_NgayVao.Visible = true;
            cb_TinhTrangLV.Visible = true;

            cb_GioiTinh.Text = "  " + txt_GioiTinh.Text;
            cb_QueQuan.Text = "  " + txt_QueQuan.Text;
            date_NgaySinh.Text = "  " + txt_NgaySinh.Text;
            cb_HonNhan.Text = "  " + txt_TinhTrangHN.Text;
            cb_DanToc.Text = "  " + txt_DanToc.Text;
            cb_HinhThucLV.Text = "  " + txt_HinhThucLV.Text;
            date_NgayVao.Text = "  " + txt_NgayVao.Text;
            cb_TinhTrangLV.Text = "  " + txt_TinhTrangLV.Text;

           
            string[] danTocVN = new string[]
            {
                    "Ba Na", "Bố Y","Brâu","Bru - Vân Kiều",
                    "Chăm", "Chu Ru","Chứt","Cờ Ho","Co","Cơ Tu",
                    "Dao",
                    "E Đê",
                    "Giáy","Gie Triêng",
                    "Hà Nhì","Hrê",
                    "Kháng","Khơ Mú","Kinh",
                    "La Chí","La Ha","La Hủ","Lạch","Lao","Lô Lô",
                    "Mạ","Mảng","Mường",
                    "Ngái","Nùng",
                    "Ô Đu",
                    "Pa Then","Phù Lá","Phù Lá (tên gọi khác)","Pu Péo",
                    "Rơ Măm","Ra Glai",
                    "Sán Chay","Sán Dìu","Si La","Sơ Đăng",
                    "Tày","Thái","Thổ",
                    "Vân Kiều",
                    "Võ",
                    "Xinh Mun","Xơ Đăng","X'tiêng",
                    "Ya",
                    "Zay"
            };
            Array.Sort(danTocVN);
            foreach (var item in danTocVN)
            {
                cb_DanToc.Items.Add("  " + item);
            }

            string[] allTinhThanh = new string[]
            {
                    "An Giang",
                    "Bà Rịa - Vũng Tàu","Bắc Giang","Bắc Kạn","Bạc Liêu","Bắc Ninh","Bến Tre","Bình Định","Bình Dương","Bình Phước","Bình Thuận",
                    "Cà Mau","Cao Bằng",
                    "Đắk Lắk","Đắk Nông","Điện Biên","Đồng Nai","Đồng Tháp",
                    "Gia Lai",
                    "Hà Giang","Hà Nam","Hà Tĩnh","Hải Dương","Hậu Giang","Hòa Bình","Hưng Yên","Khánh Hòa","Kiên Giang","Kon Tum",
                    "Lai Châu","Lâm Đồng","Lạng Sơn","Lào Cai","Long An",
                    "Nam Định","Nghệ An","Ninh Bình","Ninh Thuận",
                    "Phú Thọ",
                    "Quảng Bình","Quảng Nam","Quảng Ngãi","Quảng Ninh","Quảng Trị",
                    "Sóc Trăng","Sơn La",
                    "Tây Ninh","Thái Bình","Thái Nguyên","Thanh Hóa","Thừa Thiên Huế","Tiền Giang","Trà Vinh","Tuyên Quang",
                    "Vĩnh Long","Vĩnh Phúc",
                    "Yên Bái","Phú Yên",
                    "Cần Thơ",
                    "Đà Nẵng",
                    "Hải Phòng",
                    "Hà Nội",
                    "Hồ Chí Minh"
            };

            cb_QueQuan.Items.Add("  Tất cả");

            foreach (string item in allTinhThanh)
            {
                cb_QueQuan.Items.Add("  " + item);
            }

            SqlDataReader cotTenPB = pbd.DocDuDieuTenPB();
            while (cotTenPB.Read())
                cb_PhongBan.Items.Add("  " + cotTenPB["MaPB"].ToString().Trim() + "-" + cotTenPB["TenPB"].ToString().Trim());
            pbd.dao.conn.Close();


            SqlDataReader cotTenCV = cvd.DocDuDieuTenChucVu();
            if (cotTenCV != null)
            {
                while (cotTenCV.Read())
                    cb_ViTri.Items.Add("  " + cotTenCV["MaChucVu"].ToString().Trim() + "-" + cotTenCV["TenChucVu"].ToString().Trim());
            }
            cvd.dao.conn.Close();
            for (int i = 0; i < cb_ViTri.Items.Count; i++)
            {
                if (cb_ViTri.Items[i].ToString().Trim().Split('-')[1] == txt_ViTri.Text.Trim())
                {
                    cb_ViTri.Text = cb_ViTri.Items[i].ToString();
                    break;
                }
            }
            foreach (var item in cb_PhongBan.Items)
            {
                if (item.ToString().Trim().Split('-')[1] == txt_PhongBan.Text.Trim())
                {
                    cb_PhongBan.Text = item.ToString();
                    break;
                }
            }
        }
        private void CheDoHienThi()
        {
            ReadOnly();
            btn_Luu.Hide();
            btn_Huy.Hide();
            btn_Xoa.Show();
            btn_Sua.Show();
            btn_CapNhatAnh.Visible = false;

            txt_GioiTinh.Visible = true;
            txt_QueQuan.Visible = true;
            txt_NgaySinh.Visible = true;
            txt_TinhTrangHN.Visible = true;
            txt_DanToc.Visible = true;
            txt_ViTri.Visible = true;
            txt_PhongBan.Visible = true;
            txt_HinhThucLV.Visible = true;
            txt_NgayVao.Visible = true;
            txt_TinhTrangLV.Visible = true;

            cb_GioiTinh.Visible = false;
            cb_QueQuan.Visible = false;
            date_NgaySinh.Visible = false;
            cb_HonNhan.Visible = false;
            cb_DanToc.Visible = false;
            cb_ViTri.Visible = false;
            cb_PhongBan.Visible = false;
            cb_HinhThucLV.Visible = false;
            date_NgayVao.Visible = false;
            cb_TinhTrangLV.Visible = false;
        }
        private void Frm_ThongTinNhanVien_Load(object sender, EventArgs e)
        {

            var reader = nvd.DocDuDieuNhanVienTuMaNV(MaNV);
            if (reader.Read())
            {
                lbl_TenNVMain.Text = reader["HoTen"].ToString().Trim();
                lbl_TinhTrangMain.Text = reader["TinhTrang"].ToString().Trim();
                lbl_ViTriMain.Text = reader["TenChucVu"].ToString().Trim();
                txt_PhongBanMain.Text = reader["TenPB"].ToString().Trim();
                txt_NgayVaoMain.Text = reader["NgayVao"].ToString().Trim().Split(' ')[0];
                txt_GmailMain.Text = reader["Email"].ToString().Trim();
                txt_SDTMain.Text = reader["SoDienThoai"].ToString().Trim();

                txt_HoTen.Text = reader["HoTen"].ToString().Trim();
                txt_GioiTinh.Text = reader["GioiTinh"].ToString().Trim();
                txt_TinhTrangHN.Text = reader["HonNhan"].ToString().Trim();
                txt_DiaChi.Text = reader["Diachi"].ToString().Trim();
                txt_QueQuan.Text = reader["QueQuan"].ToString().Trim();
                txt_NgaySinh.Text = reader["NgaySinh"].ToString().Trim().Split(' ')[0];
                txt_DanToc.Text = reader["DanToc"].ToString().Trim();

                txt_MaNV.Text = reader["MaNV"].ToString().Trim();
                txt_HinhThucLV.Text = "Fulltime";
                txt_NgayVao.Text = reader["NgayVao"].ToString().Trim().Split(' ')[0];
                txt_ViTri.Text = reader["TenChucVu"].ToString().Trim();
                txt_PhongBan.Text = reader["TenPB"].ToString().Trim();
                txt_TinhTrangLV.Text = reader["TinhTrang"].ToString().Trim();
                
                byte[] b = null;
                if (reader["Anh"].GetType() != typeof(DBNull))
                {
                    b = (byte[])reader["Anh"];
                    pb_Anh.Image = ConvertBinaryToImage(b);

                }
                lbl_TinhTrangMain.Location = new Point(lbl_TenNVMain.Location.X + lbl_TenNVMain.Width + 20, lbl_TenNVMain.Location.Y + 5);
            }
            nvd.dao.conn.Close();
            if (ChucNang == "Sua")
            {
                CheDoSua();
            }
            else if (ChucNang == "HienThi")
            {
                CheDoHienThi();

            }
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Frm_ThongTinNhanVien_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuLabel9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            CheDoSua();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            /*
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                nvd.XoaNhanVien(MaNV, Page_NhanVien.trangCopy, Page_NhanVien.soNVMoiTrangCopy);
                Page_NhanVien.soNVCopy = nvd.DemSoNhanVien();
                Page_NhanVien.lbl_SoNVCopy.Text = Page_NhanVien.soNVCopy.ToString() + " Nhân Viên";
                Page_NhanVien.trangCopy = 1;
                Page_NhanVien.dataGridViewMainCopy.DataSource = nvd.DanhSachNhanVien(Page_NhanVien.trangCopy, Page_NhanVien.soNVMoiTrangCopy);
                Page_NhanVien.panelEllipsisCopy.Visible = false;
                Page_NhanVien.bs_EllipsisCopy.Visible = false;
                this.Close();
            }*/
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            if (ChucNang == "HienThi")
            {
                CheDoHienThi();
            }
            else if (ChucNang == "Sua")
            {
                this.Close();
            }
            
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            Image img = pb_Anh.Image;
            byte[] arr = null;
            if (img != null)
            {
                using (Bitmap bmb = new Bitmap(img))
                {
                    MemoryStream m = new MemoryStream();
                    bmb.Save(m, ImageFormat.Bmp);
                    arr = m.ToArray();
                }
            }
            nvd.CapNhatNhanVien(new Models.NhanVien(txt_MaNV.Text, txt_HoTen.Text, cb_ViTri.Text.Trim().Split('-')[0], cb_QueQuan.Text,
                        cb_DanToc.Text, cb_GioiTinh.Text, Convert.ToDateTime(date_NgaySinh.Text), txt_SDTMain.Text, cb_PhongBan.Text.Trim().Split('-')[0],
                        cb_TinhTrangLV.Text, txt_GmailMain.Text, cb_HonNhan.Text, Convert.ToDateTime(date_NgayVao.Text), txt_DiaChi.Text, arr));

            var reader = nvd.DocDuDieuNhanVienTuTK(Frm_DangNhap.LoaiTaiKhoan, Frm_DangNhap.txt_UsernameCopy.Text, Frm_DangNhap.txt_PasswordCopy.Text);
            if (reader.Read())
            {
                byte[] b = null;
                if (reader["Anh"].GetType() != typeof(DBNull))
                {
                    b = (byte[])reader["Anh"];
                    Frm_Main.pc_AnhMainCopy.Image = ConvertBinaryToImage(b);
                }
            }
            nvd.dao.conn.Close();
            ChucNang = "HienThi";
            Frm_ThongTinNhanVien_Load(sender, e);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        int NVSelected = 0;
        private void btn_ChevronLeft_Click(object sender, EventArgs e)
        {
            if (NVSelected > 0)
            {
                NVSelected -= 1;
                btn_ChevronLeft.Enabled = true;
                btn_ChevronRight.Enabled = true;
            }
            if (NVSelected == 0)
                btn_ChevronLeft.Enabled = false;
            MaNV = Page_NhanVien.MaNVListCopy[NVSelected];
            Frm_ThongTinNhanVien_Load(sender, e);
        }

        private void btn_ChevronRight_Click(object sender, EventArgs e)
        {
            if (NVSelected < Page_NhanVien.MaNVListCopy.Count - 1)
            {
                NVSelected += 1;
                btn_ChevronRight.Enabled = true;
                btn_ChevronLeft.Enabled = true;
            }
            if (NVSelected == Page_NhanVien.MaNVListCopy.Count - 1)
                btn_ChevronRight.Enabled = false;
            MaNV = Page_NhanVien.MaNVListCopy[NVSelected];
            Frm_ThongTinNhanVien_Load(sender, e);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        string imageUrl = null;
        private void btn_CapNhatAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imageUrl = ofd.FileName;
                    pb_Anh.Image = Image.FromFile(imageUrl);
                }
            }
        }
        int k = 0;
        private void cb_PhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (k == 0)
            {
                string phongBanDuocChon = cb_PhongBan.Text.Split('-')[1];
                cb_ViTri.Items.Clear();
                SqlDataReader cotTenCV = cvd.DocDuDieuTenChucVuCoDieuKien(phongBanDuocChon);
                if (cotTenCV != null)
                {
                    while (cotTenCV.Read())
                        cb_ViTri.Items.Add("  " + cotTenCV["MaChucVu"].ToString().Trim() + "-" + cotTenCV["TenChucVu"].ToString().Trim());
                }
                cvd.dao.conn.Close();
            }
            k = 1 - k;

        }

        private void cb_ViTri_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = " ";
            string viTriDuocChon = cb_ViTri.Text.Split('-')[1];
            SqlDataReader tenPB = cvd.XuatTenPBTuChucVu(viTriDuocChon);
            if (tenPB != null)
            {
                if (tenPB.Read())
                {
                     text = "  " + tenPB["MaPB"].ToString().Trim() + "-" + tenPB["TenPB"].ToString().Trim();  
                }
            }
            cvd.dao.conn.Close();
            k = 1 - k;
            cb_PhongBan.Text = text;


        }

        private void pb_Anh_Click(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
