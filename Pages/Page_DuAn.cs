using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDuAn.Forms;
using QuanLyDuAn.Tools;
//using Microsoft.Office.Interop.Word;
using System.IO;
using QuanLyDuAn.Dao;
using System.Data.SqlClient;
using Bunifu.UI.WinForms;
using System.Windows.Markup;
using System.Reflection;
using QuanLyDuAn.Dao.Dao;

namespace QuanLyDuAn.Pages
{
    public partial class Page_DuAn : UserControl
    {
        DuAnDao dad = new DuAnDao();
        NhanVienDao nvd = new NhanVienDao();
        public static BunifuDataGridView dataGridViewMainCopy;
        public Page_DuAn()
        {
            InitializeComponent();
            dataGridViewMainCopy = dataGridViewMain;
        }

        private void dataGridViewMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Page_DuAn_Load(object sender, EventArgs e)
        {
            DataGridViewBadgeColumn c = new DataGridViewBadgeColumn();
            c.HeaderText = "Tình Trạng";
            c.MinimumWidth = 200;
            dataGridViewMain.Columns.Insert(4, c);
            c.DataPropertyName = "TinhTrang";
            /*
            object[] ob = new object[] {null, "Web bán hàng", "Bill Gates", "In Progress", "Open file","0", "1/1/2022", "2/24/2022", "(26/54)", 64, "(0/1)", 70};
            object[] ob2 = new object[] { null, "Web bán hàng", "Bill Gates", "Completed", "Open file", "0", "1/1/2022", "2/24/2022", "(26/54)", 30, "(0/1)", 96 };
            object[] ob3 = new object[] { null, "Web bán hàng", "Bill Gates", "On Hold", "Open file", "0", "1/1/2022", "2/24/2022", "(26/54)", 30, "(0/1)", 96 };
            dataGridViewMain.Rows.Add(ob);
            dataGridViewMain.Rows.Add(ob2);
            dataGridViewMain.Rows.Add(ob3);
            */
            /*
            if (reader.Read())
            {
                byte[] b = null;
                if (reader["Anh"].GetType() != typeof(DBNull))
                {
                    b = (byte[])reader["Anh"];
                    pc_AnhMain.Image = ConvertBinaryToImage(b);
                }
            }
            nvd.dao.conn.Close();*/
            var readerTK = nvd.DocDuDieuNhanVienTuTK(Frm_DangNhap.LoaiTaiKhoan, Frm_DangNhap.txt_UsernameCopy.Text, Frm_DangNhap.txt_PasswordCopy.Text);
            string MaNV = "";
            if (readerTK.Read())
            {
                MaNV = readerTK["MaNV"].ToString();
            }
            nvd.dao.conn.Close();
            SqlDataReader reader;
            if (Frm_DangNhap.LoaiTaiKhoan == "TkGiamDoc")
                reader = dad.DanhSachDuAn(Page_DA.trangCopy, Page_DA.soDAMoiTrangCopy);
            else reader = dad.DanhSachDuAnTheoTK(MaNV);
            while (reader.Read())
            {
                object[] ob = new object[] { null, reader["MaDA"].ToString().Trim(), reader["TenDuAn"].ToString().Trim(), reader["HoTen"].ToString().Trim(), reader["TTrang"].ToString().Trim(), "Open file", "0", reader["NgayBatDau"].ToString().Trim().Split(' ')[0], reader["NgayKetThuc"].ToString().Trim().Split(' ')[0], "(26/54)", 64, "(0/1)", 70 };
                dataGridViewMain.Rows.Add(ob);
            }
            dad.dao.conn.Close();
            
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            
        }
        public static void SaveByteArrayToFileWithBinaryWriter(byte[] data, string filePath)
        {
            var writer = new BinaryWriter(File.OpenWrite(filePath));
            writer.Write(data);
        }
        public static string MaDA;
        //private Microsoft.Office.Interop.Word.Application wdApp = new Microsoft.Office.Interop.Word.Application();
        private void dataGridViewMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow c = dataGridViewMain.Rows[e.RowIndex];
            if (e.ColumnIndex == 5)
            {
                /*
                wdApp.Visible = true;
                var reader = dad.DocDuDieuDuAnTuMaDA(dataGridViewMain.Rows[e.RowIndex].Cells[1].Value.ToString().Trim());
                string fileName = @"C:\Users\HP\Desktop\project.docx";
                if (reader.Read())
                {
                    SaveByteArrayToFileWithBinaryWriter((byte[])reader["TaiLieu"], fileName);
                    object missing = System.Reflection.Missing.Value;
                    object isVisible = true;
                    object readOnly = false;
                    Document aDoc = wdApp.Documents.Open(fileName, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref isVisible);
                    //wdApp.Documents.Open(fileName);
                }
                dad.dao.conn.Close();*/
            }
            if (e.ColumnIndex == 13)
            {
                MaDA = dataGridViewMain.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                Frm_DuAn fda = new Frm_DuAn("Sua");
                fda.Show();
            }
            if (e.ColumnIndex > 0 && e.ColumnIndex < 13 && e.ColumnIndex != 5)
            {
                MaDA = dataGridViewMain.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                Frm_HienThiNhiemVu htnv = new Frm_HienThiNhiemVu();
                htnv.Show();
            }

        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Frm_DuAn fda = new Frm_DuAn("Them");
            fda.Show();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            dataGridViewMain.Rows.Clear();
            SqlDataReader reader = dad.DanhSachDuAn(Page_DA.trangCopy, Page_DA.soDAMoiTrangCopy);
            while (reader.Read())
            {
                object[] ob = new object[] { null, reader["MaDA"].ToString().Trim(), reader["TenDuAn"].ToString().Trim(), reader["HoTen"].ToString().Trim(), reader["TTrang"].ToString().Trim(), "Open file", "0", reader["NgayBatDau"].ToString().Trim().Split(' ')[0], reader["NgayKetThuc"].ToString().Trim().Split(' ')[0], "(26/54)", 64, "(0/1)", 70 };
                dataGridViewMain.Rows.Add(ob);
            }
            dad.dao.conn.Close();
        }

        private void cb_PhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_ViTri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
