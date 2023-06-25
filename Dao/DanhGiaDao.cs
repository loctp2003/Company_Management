using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using QuanLyDuAn.Models;
using System.Data;
namespace QuanLyDuAn.Dao
{
    internal class DanhGiaDao
    {
        public DBConnection dao = new DBConnection();
        public int DemDanhGia()
        {
            try
            {
                dao.conn.Open();
                string query = "Select * from DanhGia";
                SqlCommand cmd = new SqlCommand(query, dao.conn);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dao.conn.Close();
                return dt.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dao.conn.Close();
            }
            return 0;
        }
        private void ThucThiLenh(string query, DanhGia dg, string chucNang)
        {
            try
            {
                dao.conn.Open();
                string sqlStr = String.Format(query, dg.MaDanhGia, dg.MaNhiemVu, dg.LoiDanhGia, dg.NgayDanhGia, dg.MaNguoiDG, dg.SoSao);
                SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(chucNang + " thất bại \n" + ex.Message);
            }
            finally
            {
                dao.conn.Close();
            }
        }
        public void ThemDanhGia(DanhGia dg)
        {
            string query = "INSERT INTO DanhGia VALUES ({0},{1},N'{2}',N'{3}','{4}',{5})";
            ThucThiLenh(query, dg, "Thêm");
        }
        public void XoaDanhGiaTheoMaNV(DanhGia dg)
        {
            try
            {
                dao.conn.Open();
                string query = "Delete from DanhGia where MaNhiemVu={0}";
                string sqlStr = String.Format(query, dg.MaNhiemVu);
                SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại \n" + ex.Message);
            }
            finally
            {
                dao.conn.Close();
            }
        }
        public SqlDataReader DanhSachDanhGiaTheoMaNguoiDGVaMaNV(string maNguoiDG, int maNV)
        {
            try
            {
                dao.conn.Open();
                string query = "Select * from DanhGia where MaNguoiDG = '{0}' and MaNhiemVu = {1}";
                string sqlStr = String.Format(query, maNguoiDG, maNV);
                SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public SqlDataReader DanhSachDanhGiaTheoMaNV(int maNV)
        {
            try
            {
                dao.conn.Open();
                string query = "Select * from DanhGia inner join NhanVien on MaNguoiDG=MaNV where MaNhiemVu = {0}";
                string sqlStr = String.Format(query, maNV);
                SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }


    }
}
