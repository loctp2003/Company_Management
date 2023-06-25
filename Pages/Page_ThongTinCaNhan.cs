using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using QuanLyDuAn.Dao.Dao;
using QuanLyDuAn.Forms;
using QuanLyDuAn.Models;

namespace QuanLyDuAn.Pages
{
    public partial class Page_ThongTinCaNhan : UserControl
    {
        NhanVienDao nvd = new NhanVienDao();
        private string thongtin { get; set; }
        private string chucNang;
        public Page_ThongTinCaNhan(string tt)
        {
            this.thongtin = tt;
            InitializeComponent();
            

        }
        public Page_ThongTinCaNhan(string tt, string chucNang)
        {
            this.thongtin = tt;
            this.chucNang = chucNang;
            InitializeComponent();
   
        }


        private void bunifuTextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel13_Click(object sender, EventArgs e)
        {

        }
        System.Drawing.Image ConvertBinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        string ThietLapMaNVMoi()
        {
            SqlDataReader reader = nvd.DocDuDieuNhanVien();
            int Max = 0;
            while (reader.Read())
            {
                string s = reader["MaNV"].ToString();
                string substr = s.Substring(2);
                int val = Convert.ToInt32(substr);
                Max = Math.Max(Max, val);
            }
            int newval = Max + 1;
            string strVal = Convert.ToString(newval);
            string newMaNVval = "NV" + strVal.PadLeft(3, '0');
            return newMaNVval;

        }
        private string MaCV;
        private string MaPB;
        private void Page_ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            if (thongtin == "Frm_Main")
            {
                btn_Luu.Visible = false;
                btn_Them.Visible = false;
                btn_Huy.Visible = false;
                btn_CapNhatAnh.Visible = false;
                var reader = nvd.DocDuDieuNhanVienTuTK(Frm_DangNhap.LoaiTaiKhoan ,Frm_DangNhap.txt_UsernameCopy.Text, Frm_DangNhap.txt_PasswordCopy.Text);
                if (reader.Read())
                {
                    MaCV = reader["ViTri"].ToString().Trim();
                    MaPB = reader["MaPB"].ToString().Trim();
                    txt_MaNV.Text = reader["MaNV"].ToString().Trim();
                    txt_HoVaTen.Text = reader["HoTen"].ToString().Trim();
                    date_NgaySinh.Text = reader["NgaySinh"].ToString().Trim();
                    cb_GioiTinh.Text = reader["GioiTinh"].ToString().Trim();
                    txt_QueQuan.Text = reader["QueQuan"].ToString().Trim();
                    txt_HonNhan.Text = reader["HonNhan"].ToString().Trim();
                    txt_SoCMND.Text = reader["SoCMND"].ToString().Trim();
                    txt_NoiCap.Text = reader["NoiCap"].ToString().Trim();
                    date_NgayCap.Text = reader["NgayCap"].ToString().Trim();
                    txt_DanToc.Text = reader["DanToc"].ToString().Trim();
                    txt_TonGiao.Text = reader["TonGiao"].ToString().Trim();
                    date_NgayVao.Text = reader["NgayVao"].ToString().Trim();
                    txt_TinhTrang.Text = reader["TinhTrang"].ToString().Trim();
                    txt_GhiChu.Text = reader["GhiChu"].ToString().Trim();
                    txt_ViTri.Text = reader["TenChucVu"].ToString().Trim();
                    txt_PhongBan.Text = reader["TenPB"].ToString().Trim();
                    txt_SDT.Text = reader["SoDienThoai"].ToString().Trim();
                    txt_Email.Text = reader["Email"].ToString().Trim();
                    txt_DiaChi.Text = reader["Diachi"].ToString().Trim();
                    txt_Facebook.Text = reader["Facebook"].ToString().Trim();
                    byte[] b = null;
                    if (reader["Anh"].GetType() != typeof(DBNull))
                    {
                        b = (byte[])reader["Anh"];
                        pb_Anh.Image = ConvertBinaryToImage(b);
                    }
                }
                nvd.dao.conn.Close();
                txt_MaNV.ReadOnly = true;
                txt_HoVaTen.ReadOnly = true;
                date_NgaySinh.Enabled = false;
                cb_GioiTinh.Enabled = false;
                txt_QueQuan.ReadOnly = true;
                txt_HonNhan.ReadOnly = true;
                txt_SoCMND.ReadOnly = true;
                txt_NoiCap.ReadOnly = true;
                date_NgayCap.Enabled = false;
                txt_DanToc.ReadOnly = true;
                txt_TonGiao.ReadOnly = true;
                date_NgayVao.Enabled = false;
                txt_TinhTrang.ReadOnly = true;
                txt_GhiChu.ReadOnly = true;
                txt_ViTri.ReadOnly = true;
                txt_PhongBan.ReadOnly = true;
                txt_SDT.ReadOnly = true;
                txt_Email.ReadOnly = true;
                txt_DiaChi.ReadOnly = true;
                txt_Facebook.ReadOnly = true;
                
            }
            else if (thongtin == "Frm_ThongTinNhanVien")
            {
                if (chucNang == "HienThi")
                {
                    btn_Luu.Visible = false;
                    btn_Them.Visible = false;
                    btn_Huy.Visible = false;
                    btn_CapNhatAnh.Visible = false;
                    var reader = nvd.DocDuDieuNhanVienTuMaNV(Page_NhanVien.MaNV);
                    if (reader.Read())
                    {
                        MaCV = reader["ViTri"].ToString().Trim();
                        MaPB = reader["MaPB"].ToString().Trim();
                        txt_MaNV.Text = reader["MaNV"].ToString().Trim();
                        txt_HoVaTen.Text = reader["HoTen"].ToString().Trim();
                        date_NgaySinh.Text = reader["NgaySinh"].ToString().Trim();
                        cb_GioiTinh.Text = reader["GioiTinh"].ToString().Trim();
                        txt_QueQuan.Text = reader["QueQuan"].ToString().Trim();
                        txt_HonNhan.Text = reader["HonNhan"].ToString().Trim();
                        txt_SoCMND.Text = reader["SoCMND"].ToString().Trim();
                        txt_NoiCap.Text = reader["NoiCap"].ToString().Trim();
                        date_NgayCap.Text = reader["NgayCap"].ToString().Trim();
                        txt_DanToc.Text = reader["DanToc"].ToString().Trim();
                        txt_TonGiao.Text = reader["TonGiao"].ToString().Trim();
                        date_NgayVao.Text = reader["NgayVao"].ToString().Trim();
                        txt_TinhTrang.Text = reader["TinhTrang"].ToString().Trim();
                        txt_GhiChu.Text = reader["GhiChu"].ToString().Trim();
                        txt_ViTri.Text = reader["TenChucVu"].ToString().Trim();
                        txt_PhongBan.Text = reader["TenPB"].ToString().Trim();
                        txt_SDT.Text = reader["SoDienThoai"].ToString().Trim();
                        txt_Email.Text = reader["Email"].ToString().Trim();
                        txt_DiaChi.Text = reader["Diachi"].ToString().Trim();
                        txt_Facebook.Text = reader["Facebook"].ToString().Trim();
                        byte[] b = null;
                        if (reader["Anh"].GetType() != typeof(DBNull))
                        {
                            b = (byte[])reader["Anh"];
                            pb_Anh.Image = ConvertBinaryToImage(b);

                        }

                    }
                    txt_MaNV.ReadOnly = true;
                    txt_HoVaTen.ReadOnly = true;
                    date_NgaySinh.Enabled = false;
                    cb_GioiTinh.Enabled = false;
                    txt_QueQuan.ReadOnly = true;
                    txt_HonNhan.ReadOnly = true;
                    txt_SoCMND.ReadOnly = true;
                    txt_NoiCap.ReadOnly = true;
                    date_NgayCap.Enabled = false;
                    txt_DanToc.ReadOnly = true;
                    txt_TonGiao.ReadOnly = true;
                    date_NgayVao.Enabled = false;
                    txt_TinhTrang.ReadOnly = true;
                    txt_GhiChu.ReadOnly = true;
                    txt_ViTri.ReadOnly = true;
                    txt_PhongBan.ReadOnly = true;
                    txt_SDT.ReadOnly = true;
                    txt_Email.ReadOnly = true;
                    txt_DiaChi.ReadOnly = true;
                    txt_Facebook.ReadOnly = true;

                    nvd.dao.conn.Close();
                }
                else if (chucNang == "Them")
                {
                    txt_MaNV.Text = ThietLapMaNVMoi();
                    txt_MaNV.ReadOnly = true;
                    btn_Them.Visible = true;
                    btn_CapNhatAnh.Visible = true;
                    btn_Luu.Visible = false;
                    btn_Huy.Visible = true;
                }
            }
        }
        string imageUrl = null;
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (chucNang == "Them") btn_CapNhatAnh.Text = "Chọn Ảnh";
            else if (chucNang == "HienThi") btn_CapNhatAnh.Text = "Cập Nhật Ảnh";
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imageUrl = ofd.FileName;
                    pb_Anh.Image = Image.FromFile(imageUrl);
                }
            }
        }
        private void pb_Anh_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Luu_Click_1(object sender, EventArgs e)
        {
            Image img = pb_Anh.Image;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
            try
            {
                nvd.dao.conn.Open();
                SqlCommand cmd = new SqlCommand("Update NhanVien set Anh = @Image where MaNV = @MaNV", nvd.dao.conn);
                cmd.Parameters.AddWithValue("@Image", arr);
                cmd.Parameters.AddWithValue("@MaNV", txt_MaNV.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Lưu thành công");

                SqlCommand cmd2 = new SqlCommand("Select Anh, MaNV, HoTen, TenChucVu, TenPB ,GioiTinh ,NgaySinh, TinhTrang, NgayVao from (Select * from NhanVien inner join ChucVu " +
                                "on NhanVien.ViTri=ChucVu.MaChucVu) k inner join PhongBan on k.MaPB=Phongban.MaPB", nvd.dao.conn);
                DataTable dt = new DataTable();
                dt.Load(cmd2.ExecuteReader());
                Page_NhanVien.dataGridViewMainCopy.DataSource = dt;


                string query = "Select * from (Select * from (Select * " +
                                "from TKTruongPhong inner join NhanVien " +
                                "on TKTruongPhong.MaTP = NhanVien.MaNV where Username = '{0}' and Pass_word = '{1}') p inner join ChucVu " +
                                "on p.ViTri=ChucVu.MaChucVu) k inner join PhongBan on k.MaPB=Phongban.MaPB";
                string sqlStr = String.Format(query, Frm_DangNhap.txt_UsernameCopy.Text, Frm_DangNhap.txt_PasswordCopy.Text);
                SqlCommand cmd3 = new SqlCommand(sqlStr, nvd.dao.conn);
                var reader = cmd3.ExecuteReader();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                nvd.dao.conn.Close();
            }
        }
        
        private void btn_Them_Click(object sender, EventArgs e)
        {
            /*  
            Image img = pb_Anh.Image;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));*/
            /*public NhanVien(string maNV, string hoTen, string viTri, string queQuan, string danToc, string gioiTinh, DateTime ngaySinh, string sDT, string maPB, string tinhTrang, string email, string honNhan, string soCMND, DateTime ngayCap, string noiCap, string tonGiao, DateTime ngayVao, string diaChi, string facebook, string ghiChu, byte[] anh)*/
            /*nvd.ThemNhanVien(new NhanVien(txt_MaNV.Text, txt_HoVaTen.Text, txt_ViTri.Text, txt_QueQuan.Text, txt_DanToc.Text, cb_GioiTinh.Text,
                                                Convert.ToDateTime(date_NgaySinh.Text), txt_SDT.Text, txt_PhongBan.Text, txt_TinhTrang.Text, txt_Email.Text, txt_HonNhan.Text,txt_SoCMND.Text, Convert.ToDateTime(date_NgayCap.Text), txt_NoiCap.Text, txt_TonGiao.Text,
                                                Convert.ToDateTime(date_NgayVao.Text), txt_DiaChi.Text, txt_Facebook.Text, txt_GhiChu.Text,
                                                 arr));
            Page_NhanVien.dataGridViewMainCopy.DataSource = nvd.DanhSachNhanVien(1, 10);*/
            
        }

        private void txt_MaNV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
