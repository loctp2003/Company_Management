using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyDuAn.Dao
{
    internal class PhongBanDao
    {
        public DBConnection dao = new DBConnection();

        public SqlDataReader DocDuDieuTenPB()
        {
            try
            {
                dao.conn.Open();
                string queryPB = "Select MaPB, TenPB from PhongBan";
                SqlCommand cmd = new SqlCommand(queryPB, dao.conn);
                var reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            return null;  
        }
        public SqlDataReader DocDuLieuThongTinPhongBan()
        {
            try
            {
                dao.conn.Open();
                string query = "Select PhongBan.MaPB as MaPB, TenPB, count(MaNV) as SoNV from PhongBan inner join NhanVien  " +
                    "on PhongBan.MaPB=NhanVien.MaPB " +
                    "where not PhongBan.MaPB = 'PB000' and not PhongBan.MaPB = 'PB009' " +
                    "group by PhongBan.MaPB, TenPB ";
                string queryPB = "Select k.MaPB as MaPB, TenPB, MaNV, Anh from NhanVien inner join (" + query + ") k on NhanVien.MaPB = k.MaPB";
                SqlCommand cmd = new SqlCommand(query, dao.conn);
                var reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }
        public SqlDataReader DocDuLieuAnhNVCuaPhongBan(string MaPB)
        {
            try
            {
                dao.conn.Open();
                string query = "Select Anh from NhanVien inner join PhongBan on NhanVien.MaPB = PhongBan.MaPB where PhongBan.MaPB = '" + MaPB +"'";
                SqlCommand cmd = new SqlCommand(query, dao.conn);
                var reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }
        public SqlDataReader DocDuLieuNVCuaPhongBan(string MaPB)
        {
            try
            {
                dao.conn.Open();
                string query = "Select MaNV, HoTen from NhanVien inner join PhongBan on NhanVien.MaPB = PhongBan.MaPB where PhongBan.MaPB = '" + MaPB + "'";
                SqlCommand cmd = new SqlCommand(query, dao.conn);
                var reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }
        public SqlDataReader DocDuLieuTrPhongCuaPhongBan(string MaPB)
        {
            try
            {
                dao.conn.Open();
                string query = "Select TruongPhong, HoTen from PhongBan inner join NhanVien on PhongBan.MaPB = NhanVien.MaPB where PhongBan.MaPB = '" + MaPB + "'";
                SqlCommand cmd = new SqlCommand(query, dao.conn);
                var reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }
    }
}
