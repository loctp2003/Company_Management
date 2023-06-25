using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using QuanLyDuAn.Models;

namespace QuanLyDuAn.Dao
{
    internal class NhanVienThamGiaDADao
    {
        public DBConnection dao = new DBConnection();
        public int Dem(string query)
        {
            try
            {
                dao.conn.Open();
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
        public SqlDataReader SoNVHoanThanh(int maDA, int trang, int soDongMoiTrang)
        {
            try
            {
                dao.conn.Open();
                string query1 = "Select distinct NhanVien.MaNV as MaNV, MaPB from NhanVienThamGiaDA inner join NhanVien on NhanVienThamGiaDA.MaNV=NhanVien.MaNV where MaDA = " + maDA;
                string query2 = "Select MaNV, TenPB from (" + query1 + ") k inner join PhongBan on k.MaPB = PhongBan.MaPB";
                string query3 = "Select MaNV, TenPB, count(MaNhiemVu) as SoNhiemVu  from (" + query2 + ") k left outer join (Select * from NhiemVu where MaDA = " + maDA + " and TinhTrang='Completed') p on k.MaNV = p.MaNguoiSoHuu group by MaNV, TenPB";
                string query4 = "Select NhanVien.MaNV, SoNhiemVu from (" + query3 + ") k inner join NhanVien on k.MaNV = NhanVien.MaNV " +
                   "order by NhanVien.MaNV " +
                   "offset " + soDongMoiTrang * (trang - 1) + " rows " +
                   "FETCH NEXT " + soDongMoiTrang + " rows only"; ;
                SqlCommand cmd = new SqlCommand(query4, dao.conn);
                var reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }
        public int DemNhanVienThamGiaDA(int maDA)
        {
            string query1 = "Select distinct NhanVien.MaNV as MaNV, MaPB from NhanVienThamGiaDA inner join NhanVien on NhanVienThamGiaDA.MaNV=NhanVien.MaNV where MaDA = " + maDA;
            string query2 = "Select MaNV, TenPB from (" + query1 + ") k inner join PhongBan on k.MaPB = PhongBan.MaPB";
            string query3 = "Select MaNV, TenPB, count(MaNhiemVu) as SoNhiemVu  from (" + query2 + ") k left outer join (Select * from NhiemVu where MaDA = " + maDA + ") p on k.MaNV = p.MaNguoiSoHuu group by MaNV, TenPB";
            string query4 = "Select NhanVien.MaNV, TenPB, HoTen, Anh, SoNhiemVu from (" + query3 + ") k inner join NhanVien on k.MaNV = NhanVien.MaNV";
            return Dem(query4);
        }
        public SqlDataReader CacPhongBanThamGiaDA(int maDA)
        {
            try
            {
                dao.conn.Open();
                string query1 = "Select distinct NhanVien.MaNV as MaNV, MaPB from NhanVienThamGiaDA inner join NhanVien on NhanVienThamGiaDA.MaNV=NhanVien.MaNV where MaDA = " + maDA;
                string query2 = "Select MaNV, PhongBan.MaPB as MaPB, TenPB from (" + query1 + ") k inner join PhongBan on k.MaPB = PhongBan.MaPB";
                string query3 = "Select MaNV, MaPB, TenPB, count(MaNhiemVu) as SoNhiemVu  from (" + query2 + ") k left outer join (Select * from NhiemVu where MaDA = " + maDA + ") p on k.MaNV = p.MaNguoiSoHuu group by MaNV, TenPB, MaPB";
                string query4 = "Select distinct k.MaPB as MaPB from (" + query3 + ") k inner join NhanVien on k.MaNV = NhanVien.MaNV ";
                SqlCommand cmd = new SqlCommand(query4, dao.conn);
                var reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public SqlDataReader CacNhanVienThamGiaDA(int maDA, int trang, int soDongMoiTrang)
        {
            try
            {
                dao.conn.Open();
                string query1 = "Select distinct NhanVien.MaNV as MaNV, MaPB from NhanVienThamGiaDA inner join NhanVien on NhanVienThamGiaDA.MaNV=NhanVien.MaNV where MaDA = " + maDA;
                string query2 = "Select MaNV, PhongBan.MaPB as MaPB, TenPB from (" + query1 + ") k inner join PhongBan on k.MaPB = PhongBan.MaPB";
                string query3 = "Select MaNV, MaPB, TenPB, count(MaNhiemVu) as SoNhiemVu  from (" + query2 + ") k left outer join (Select * from NhiemVu where MaDA = " +maDA +") p on k.MaNV = p.MaNguoiSoHuu group by MaNV, TenPB, MaPB";
                string query4 = "Select NhanVien.MaNV, k.MaPB as MaPB, TenPB, HoTen, Anh, SoNhiemVu from (" + query3 + ") k inner join NhanVien on k.MaNV = NhanVien.MaNV " +
                   "order by NhanVien.MaNV " +
                   "offset " + soDongMoiTrang * (trang - 1) + " rows " +
                   "FETCH NEXT " + soDongMoiTrang + " rows only";
                SqlCommand cmd = new SqlCommand(query4, dao.conn);
                var reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }
        private void ThucThiLenh(string query, NhanVienThamGiaDA nvtg, string chucNang)
        {
            try
            {
                dao.conn.Open();
                string sqlStr = String.Format(query, nvtg.MaDA, nvtg.MaNV);
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
        public void ThemNhanVienThamGiaDA(NhanVienThamGiaDA nvtg)
        {
            string query = "Insert into NhanVienThamGiaDA values({0}, '{1}')";
            ThucThiLenh(query, nvtg, "Thêm");
        }
        public void XoaNhanVienThamGiaDA(NhanVienThamGiaDA nvtg)
        {
            string query = "Delete from NhanVienThamGiaDA where MaDA={0}";
            ThucThiLenh(query, nvtg, "Xóa");
        }
    }
}
