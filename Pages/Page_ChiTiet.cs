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
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using QuanLyDuAn.Dao;
using QuanLyDuAn.Dao.Dao;
using QuanLyDuAn.Forms;
using QuanLyDuAn.Models;

namespace QuanLyDuAn.Pages
{
    public partial class Page_ChiTiet : UserControl
    {
        DuAnDao dad = new DuAnDao();
        NhanVienDao nvd = new NhanVienDao();
        NhiemVuDao nhvd = new NhiemVuDao();
        NhanVienThamGiaDADao nvtgda = new NhanVienThamGiaDADao();
        string mode;
        string capNhatMieuTa; // TaiLieu, Text
        string maNhanVien;
        public Page_ChiTiet(string mode)
        {
            InitializeComponent();
            this.mode = mode;
        }
        byte[] changeFileToByte(string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                byte[] bytes = System.IO.File.ReadAllBytes(filename);
                fs.Read(bytes, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
                return bytes;
            }
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
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private string ThoiGianCapNhat(DateTime dt)
        {
            TimeSpan ts = DateTime.Now - dt;
            if (ts.TotalSeconds >= 31536000)
                return Convert.ToInt32(ts.TotalSeconds / 31536000).ToString() + " năm trước";
            else if (ts.TotalSeconds >= 2592000)
                return Convert.ToInt32(ts.TotalSeconds / 2592000).ToString() + " tháng trước";
            else if (ts.TotalSeconds >= 86400)
                return Convert.ToInt32(ts.TotalSeconds / 86400).ToString() + " ngày trước";
            else if (ts.TotalSeconds >= 3600)
                return Convert.ToInt32(ts.TotalSeconds / 3600).ToString() + " giờ trước";
            else if (ts.TotalSeconds >= 60)
                return Convert.ToInt32(ts.TotalSeconds / 60).ToString() + " phút trước";
            return Convert.ToInt32(ts.TotalSeconds).ToString() + " giây trước";   
        }
        private void Page_ChiTiet_Load(object sender, EventArgs e)
        {
            btn_HuyChiTiet.Visible = false;
            btn_HuyMieuTa.Visible = false;
            btn_LuuChiTiet.Visible = false;
            btn_LuuMieuTa.Visible = false;
            btn_Upload.Visible = false;
            rtb_MieuTa.ReadOnly = true;
           
            string fileToRead = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.StartupPath) + "/../File/x.docx";
            File.Delete(fileToRead);
            SqlDataReader reader = null;
            if (mode == "DA")
            {
                txt_NguoiSoHuu.ReadOnly = true;
                txt_TenDA.ReadOnly = true;
                reader = dad.DocDuDieuDuAnTuMaDA(Page_DA.MaDA);
                lbl_MieuTa.Text = "Miêu Tả Dự Án";
                lbl_ChiTiet.Text = "Chi Tiết Dự Án";
                lbl_Ten.Text = "Tên Dự Án";
                panelNhiemVu.Visible = false;
                panelDuAn.Visible = true;
                if (reader.Read())
                {
                    txt_TenDA.Text = reader["TenDuAn"].ToString().Trim();
                    lbl_TinhTrangMain.Text = reader["TTrang"].ToString().Trim();
                    txt_NgayBatDau.Text = reader["NgayBatDau"].ToString().Trim().Split(' ')[0];
                    txt_NgayKetThuc.Text = reader["NgayKetThuc"].ToString().Trim().Split(' ')[0];
                    txt_NguoiSoHuu.Text = reader["HoTen"].ToString().Trim();
                    pc_Anh.Image = ConvertBinaryToImage((byte[])reader["Anh"]);
                    if (reader["TaiLieu"].GetType() != typeof(DBNull))
                    {
                        capNhatMieuTa = "TaiLieu";
                        byte[] fileData = (byte[])reader["TaiLieu"];
                        File.WriteAllBytes(fileToRead, fileData);
                        Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                        Document doc = app.Documents.Open(fileToRead);
                        rtb_MieuTa.Text = doc.Content.Text;
                        app.Quit();
                    }
                    else if (reader["MieuTa"].GetType() != typeof(DBNull))
                    {
                        capNhatMieuTa = "Text";
                        rtb_MieuTa.Text = reader["MieuTa"].ToString().Trim();
                    }
                    txt_CapNhat.Text = ThoiGianCapNhat(Convert.ToDateTime(reader["NgayDuocThem"].ToString().Trim()));
                    maNhanVien = reader["MaNV"].ToString().Trim();
                }
               
                dad.dao.conn.Close();
                txt_SoNVDuDinh.Text = nvtgda.DemNhanVienThamGiaDA(Page_DA.MaDA).ToString();

                SqlDataReader cotTenNV = nvd.DocDuLieuNhanVienQLDA();
                if (cotTenNV != null)
                {
                    while (cotTenNV.Read())
                        cb_NguoiSoHuu.Items.Add("  " + cotTenNV["MaNV"].ToString().Trim() + "-" + cotTenNV["HoTen"].ToString().Trim());
                }
                nvd.dao.conn.Close();

                if (lbl_TinhTrangMain.Text == "Completed")
                    lbl_TinhTrangMain.BackColor = Color.FromArgb(0, 100, 0);
                else if (lbl_TinhTrangMain.Text == "On Hold")
                    lbl_TinhTrangMain.BackColor = Color.FromArgb(255, 165, 0);
                else if (lbl_TinhTrangMain.Text == "In Progress")
                    lbl_TinhTrangMain.BackColor = Color.FromArgb(0, 0, 255);
                else if (lbl_TinhTrangMain.Text == "Cancelled")
                    lbl_TinhTrangMain.BackColor = Color.Red;
                else if (lbl_TinhTrangMain.Text == "Not Started")
                    lbl_TinhTrangMain.BackColor = Color.DarkGray;
            }
            else if (mode == "NV")
            {
                if (Page_ThongTinNhiemVu.ChoPhepSua == true)
                {
                    btn_SuaChiTiet.Visible = true;
                    btn_SuaMieuTa.Visible = true;
                }
                else
                {
                    btn_SuaChiTiet.Visible = false;
                    btn_SuaMieuTa.Visible = false;
                }
                txt_NSH.ReadOnly = true;
                txt_TenDACuaNV.ReadOnly = true;
                txt_TenNV.ReadOnly = true;
                reader = nhvd.DocDuDieuNhiemVuTuMaNhiemVu(Page_NhiemVu.MaNV);
                lbl_MieuTa.Text = "Miêu Tả Nhiệm Vụ";
                lbl_ChiTiet.Text = "Chi Tiết Nhiệm Vụ";
                lbl_Ten.Text = "Tên Nhiệm Vụ";
                panelNhiemVu.Visible = true;
                panelDuAn.Visible = false;
                if (reader.Read())
                {
                    txt_TenDACuaNV.Text = reader["TenDuAn"].ToString().Trim();
                    txt_TenNV.Text = reader["TenNhiemVu"].ToString().Trim();
                    lbl_TinhTrangNV.Text = reader["TTrang"].ToString().Trim();
                    txt_NgayBatDauNV.Text = reader["NgayBatDau"].ToString().Trim().Split(' ')[0];
                    txt_NgayKetThucNV.Text = reader["NgayKetThuc"].ToString().Trim().Split(' ')[0];
                    txt_NSH.Text = reader["HoTen"].ToString().Trim();
                    pc_AnhNSH.Image = ConvertBinaryToImage((byte[])reader["Anh"]);
                    if (reader["TaiLieu"].GetType() != typeof(DBNull))
                    {
                        capNhatMieuTa = "TaiLieu";
                        byte[] fileData = (byte[])reader["TaiLieu"];
                        File.WriteAllBytes(fileToRead, fileData);
                        Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                        Document doc = app.Documents.Open(fileToRead);
                        rtb_MieuTa.Text = doc.Content.Text;
                        app.Quit();
                    }
                    else if (reader["MieuTa"].GetType() != typeof(DBNull))
                    {
                        capNhatMieuTa = "Text";
                        rtb_MieuTa.Text = reader["MieuTa"].ToString().Trim();
                    }
                    txt_CapNhatNV.Text = ThoiGianCapNhat(Convert.ToDateTime(reader["NgayDuocThem"].ToString().Trim()));
                    maNhanVien = reader["MaNV"].ToString().Trim();
                }
                nhvd.dao.conn.Close();
               
                SqlDataReader cotTenNV = nvd.DocDuDieuNhanVien();
                if (cotTenNV != null)
                {
                    while (cotTenNV.Read())
                        cb_NSH.Items.Add("  " + cotTenNV["MaNV"].ToString().Trim() + "-" + cotTenNV["HoTen"].ToString().Trim());
                }
                nvd.dao.conn.Close();

                if (lbl_TinhTrangNV.Text == "Completed")
                    lbl_TinhTrangNV.BackColor = Color.FromArgb(0, 100, 0);
                else if (lbl_TinhTrangNV.Text == "On Hold")
                    lbl_TinhTrangNV.BackColor = Color.FromArgb(255, 165, 0);
                else if (lbl_TinhTrangNV.Text == "In Progress")
                    lbl_TinhTrangNV.BackColor = Color.FromArgb(0, 0, 255);
                else if (lbl_TinhTrangNV.Text == "Cancelled")
                    lbl_TinhTrangNV.BackColor = Color.Red;
                else if (lbl_TinhTrangNV.Text == "Not Started")
                    lbl_TinhTrangNV.BackColor = Color.DarkGray;

            }
        }

        private void txt_HoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_SuaMieuTa_Click(object sender, EventArgs e)
        {
            btn_LuuMieuTa.Visible = true;
            btn_HuyMieuTa.Visible = true;
            btn_SuaMieuTa.Visible = false;
            btn_Upload.Visible = true;
            rtb_MieuTa.ReadOnly = false;
            
        }

        private void btn_SuaChiTiet_Click(object sender, EventArgs e)
        {
            btn_LuuChiTiet.Visible = true;
            btn_HuyChiTiet.Visible = true;
            btn_SuaChiTiet.Visible = false;

            if (mode == "DA")
            {
                date_NgayBatDau.Visible = true;
                date_NgayKetThuc.Visible = true;
                date_NgayBatDau.Text = txt_NgayBatDau.Text;
                date_NgayKetThuc.Text = txt_NgayKetThuc.Text;
                cb_NguoiSoHuu.Visible = true;
                cb_NguoiSoHuu.Text = maNhanVien+"-"+txt_NguoiSoHuu.Text;
                txt_TenDA.ReadOnly = false;

                lbl_TinhTrangMain.Visible = true;
                txt_NgayBatDau.Visible = false;
                txt_NgayKetThuc.Visible = false;
                txt_NguoiSoHuu.Visible = false;
            }
            else if (mode == "NV")
            {
                date_NgayBatDauNV.Visible = true;
                date_NgayKetThucNV.Visible = true;
                date_NgayBatDauNV.Text = txt_NgayBatDauNV.Text;
                date_NgayKetThucNV.Text = txt_NgayKetThucNV.Text;
                cb_NSH.Visible = true;
                cb_NSH.Text = maNhanVien+"-"+txt_NSH.Text;
                txt_TenDACuaNV.ReadOnly = true;
                txt_TenNV.ReadOnly = false;

                lbl_TinhTrangNV.Visible = true;
                txt_NgayBatDauNV.Visible = false;
                txt_NgayKetThucNV.Visible = false;
                txt_NSH.Visible = false;
            }
        }

        private void btn_LuuChiTiet_Click(object sender, EventArgs e)
        {
            btn_LuuChiTiet.Visible = false;
            btn_HuyChiTiet.Visible = false;
            btn_SuaChiTiet.Visible = true;

            if (mode == "DA")
            {
                date_NgayBatDau.Visible = false;
                date_NgayKetThuc.Visible = false;
                cb_NguoiSoHuu.Visible = false;
                txt_TenDA.ReadOnly = true;

                lbl_TinhTrangMain.Visible = true;
                txt_NgayBatDau.Visible = true;
                txt_NgayKetThuc.Visible = true;
                txt_NguoiSoHuu.Visible = true;

                dad.CapNhatDuAn(new DuAn(Page_DA.MaDA, txt_TenDA.Text, "", lbl_TinhTrangMain.Text, cb_NguoiSoHuu.Text.Trim().Split('-')[0], null, Convert.ToDateTime(date_NgayBatDau.Text), Convert.ToDateTime(date_NgayKetThuc.Text), DateTime.Now));
                
                Page_ThongTinDuAn.lbl_TenDACopy.Text = txt_TenDA.Text;
                Page_ThongTinDuAn.lbl_NguoiSoHuuCopy.Text = txt_NguoiSoHuu.Text;
                Page_ChiTiet_Load(sender, e);
                Page_DA da = new Page_DA();
                da.Dock = DockStyle.Fill;
                Frm_Main.pda = da;
            }
            else if (mode == "NV")
            {
                date_NgayBatDauNV.Visible = false;
                date_NgayKetThucNV.Visible = false;
                cb_NSH.Visible = false;
                txt_TenDACuaNV.ReadOnly = true;
                txt_TenNV.ReadOnly = true;

                lbl_TinhTrangNV.Visible = true;
                txt_NgayBatDauNV.Visible = true;
                txt_NgayKetThucNV.Visible = true;
                txt_NSH.Visible = true;

                nhvd.CapNhatNhiemVu(new NhiemVu(Page_NhiemVu.MaNV, Page_NhiemVu.MaDA, txt_TenNV.Text, "", null, Page_NhiemVu.MaNSH, lbl_TinhTrangNV.Text, Convert.ToDateTime(date_NgayBatDauNV.Text), Convert.ToDateTime(date_NgayKetThucNV.Text), DateTime.Now));

                Page_ThongTinNhiemVu.lbl_TenNhiemVuCopy.Text = txt_TenNV.Text;
                Page_ThongTinNhiemVu.lbl_NguoiSoHuuCopy.Text = txt_NSH.Text;
                Page_ChiTiet_Load(sender, e);
                Page_NhiemVu pnv = new Page_NhiemVu("NV");
                pnv.Dock = DockStyle.Fill;
                Frm_Main.pnv = pnv;
            }
        }

        private void btn_HuyChiTiet_Click(object sender, EventArgs e)
        {
            btn_LuuChiTiet.Visible = false;
            btn_HuyChiTiet.Visible = false;
            btn_SuaChiTiet.Visible = true;
            if (mode == "DA")
            {
                date_NgayBatDau.Visible = false;
                date_NgayKetThuc.Visible = false;
                cb_NguoiSoHuu.Visible = false;
                txt_TenDA.ReadOnly = true;

                lbl_TinhTrangMain.Visible = true;
                txt_NgayBatDau.Visible = true;
                txt_NgayKetThuc.Visible = true;
                txt_NguoiSoHuu.Visible = true;
            }
            else if (mode == "NV")
            {
                date_NgayBatDauNV.Visible = false;
                date_NgayKetThucNV.Visible = false;
                cb_NSH.Visible = false;
                txt_TenDACuaNV.ReadOnly = true;
                txt_TenNV.ReadOnly = true;

                lbl_TinhTrangNV.Visible = true;
                txt_NgayBatDauNV.Visible = true;
                txt_NgayKetThucNV.Visible = true;
                txt_NSH.Visible = true;
            }
        }

        private byte[] changeTextToByte()
        {
            string fileToRead = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.StartupPath) + "/../File/k.docx";
            File.Delete(fileToRead);
            var file = File.Create(fileToRead);
            file.Close();
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document doc = app.Documents.Open(fileToRead);
            doc.Content.Text = rtb_MieuTa.Text;
            doc.Close();
            app.Quit();
            byte[] b = changeFileToByte(fileToRead);
           
            return b;
        }
        private void btn_LuuMieuTa_Click(object sender, EventArgs e)
        {
            btn_LuuMieuTa.Visible = false;
            btn_HuyMieuTa.Visible = false;
            btn_SuaMieuTa.Visible = true;
            btn_Upload.Visible = false;
            rtb_MieuTa.ReadOnly = true;
            byte[] b = changeTextToByte();
            if (mode == "DA")
            {
                if (capNhatMieuTa == "TaiLieu")
                    dad.CapNhatTaiLieuDuAn(b, Page_DA.MaDA);
                else if (capNhatMieuTa == "Text")
                    dad.CapNhatMieuTaDuAn(rtb_MieuTa.Text, Page_DA.MaDA);
            }
            else if (mode == "NV")
            {

            }
        }

        private void btn_HuyMieuTa_Click(object sender, EventArgs e)
        {
            btn_LuuMieuTa.Visible = false;
            btn_HuyMieuTa.Visible = false;
            btn_SuaMieuTa.Visible = true;
            btn_Upload.Visible = false;
            rtb_MieuTa.ReadOnly = true;
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            string fileName = "";
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Word Document|*.docx|Word 97 - 2003 Document|*.doc";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                    Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                    Document doc = app.Documents.Open(fileName);
                    rtb_MieuTa.Text = doc.Content.Text;
                    app.Quit();
                }
            }

        }

        private void lbl_TinhTrangMain_TextChanged(object sender, EventArgs e)
        {
            if (lbl_TinhTrangMain.Text == "Completed")
                lbl_TinhTrangMain.BackColor = Color.FromArgb(0, 100, 0);
            else if (lbl_TinhTrangMain.Text == "On Hold")
                lbl_TinhTrangMain.BackColor = Color.FromArgb(255, 165, 0);
            else if (lbl_TinhTrangMain.Text == "In Progress")
                lbl_TinhTrangMain.BackColor = Color.FromArgb(0, 0, 255);
            else if (lbl_TinhTrangMain.Text == "Cancelled")
                lbl_TinhTrangMain.BackColor = Color.Red;
            else if (lbl_TinhTrangMain.Text == "Not Started")
                lbl_TinhTrangMain.BackColor = Color.DarkGray;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_TinhTrangNV_Click(object sender, EventArgs e)
        {

        }

        private void lbl_TinhTrangNV_TextChanged(object sender, EventArgs e)
        {
            if (lbl_TinhTrangNV.Text == "Completed")
                lbl_TinhTrangNV.BackColor = Color.FromArgb(0, 100, 0);
            else if (lbl_TinhTrangNV.Text == "On Hold")
                lbl_TinhTrangNV.BackColor = Color.FromArgb(255, 165, 0);
            else if (lbl_TinhTrangNV.Text == "In Progress")
                lbl_TinhTrangNV.BackColor = Color.FromArgb(0, 0, 255);
            else if (lbl_TinhTrangNV.Text == "Cancelled")
                lbl_TinhTrangNV.BackColor = Color.Red;
            else if (lbl_TinhTrangNV.Text == "Not Started")
                lbl_TinhTrangNV.BackColor = Color.DarkGray;
        }

        private void lbl_TinhTrangMain_Click(object sender, EventArgs e)
        {

        }
    }
}
