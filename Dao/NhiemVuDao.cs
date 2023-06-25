using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows;
using QuanLyDuAn.Models;

namespace QuanLyDuAn.Dao
{
    internal class NhiemVuDao
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
        public int DemNhiemVu(string search)
        {
            string query = "Select DuAn.MaDA as MaDA, TenDuAn, MaNhiemVu, TenNhiemVu, Anh, MaNV, HoTen, k.MieuTa as MieuTa, k.TinhTrang as TTrang,k.NgayBatDau as NBatDau, k.NgayKetThuc as NKetThuc, k.NgayDuocThem as NgayDuocThem, k.TiLeHT as TiLeHT  " +
                               "from (Select * from NhiemVu inner join (select MaNV, Anh, HoTen from NhanVien) p on NhiemVu.MaNguoiSoHuu=p.MaNV) k inner join DuAn " +
                               "on k.MaDA=DuAn.MaDA where TenNhiemVu LIKE N'%" + search + "%'";
            return Dem(query);
        }
        public SqlDataReader DanhSachNhiemVu(string search, int trang, int soNVMoiTrang)
        {
            try
            {
                dao.conn.Open();
                string table = "Select DuAn.MaDA as MaDA, TenDuAn, MaNhiemVu, TenNhiemVu, Anh, MaNV, HoTen, k.MieuTa as MieuTa, k.TinhTrang as TTrang,k.NgayBatDau as NBatDau, k.NgayKetThuc as NKetThuc, k.NgayDuocThem as NgayDuocThem, k.TiLeHT as TiLeHT " +
                               "from (Select * from NhiemVu inner join (select MaNV, Anh, HoTen from NhanVien) p on NhiemVu.MaNguoiSoHuu=p.MaNV) k inner join DuAn " +
                               "on k.MaDA=DuAn.MaDA where TenNhiemVu LIKE N'%" + search + "%'";

                string query = "Select MaDA, TenDuAn, MaNhiemVu, TenNhiemVu, Anh, MaNV, HoTen, TTrang, NBatDau, NKetThuc, TiLeHT from (" + table +") k "+
                                "order by k.TenDuAn " +
                               "offset " + soNVMoiTrang * (trang - 1) + " rows " +
                               "FETCH NEXT " + soNVMoiTrang + " rows only";
                SqlCommand cmd = new SqlCommand(query, dao.conn);
                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public int DemNhiemVuTheoTinhTrang(string tinhtrang, string search)
        {
            string query = "Select DuAn.MaDA as MaDA, TenDuAn, MaNhiemVu, TenNhiemVu, Anh, MaNV, HoTen, k.MieuTa as MieuTa, k.TinhTrang as TTrang,k.NgayBatDau as NBatDau, k.NgayKetThuc as NKetThuc, k.NgayDuocThem as NgayDuocThem, k.TiLeHT as TiLeHT " +
                               "from (Select * from NhiemVu inner join (select MaNV, Anh, HoTen from NhanVien) p on NhiemVu.MaNguoiSoHuu=p.MaNV) k inner join DuAn " +
                               "on k.MaDA=DuAn.MaDA where k.TinhTrang = '" + tinhtrang + "' and TenNhiemVu LIKE N'%" + search + "%'";
            return Dem(query);
        }
        public SqlDataReader DanhSachNhiemVuTheoTinhTrang(string tinhtrang, string search, int trang, int soNVMoiTrang)
        {
            try
            {
                dao.conn.Open();
                string table = "Select DuAn.MaDA as MaDA, TenDuAn, MaNhiemVu, TenNhiemVu, Anh, MaNV, HoTen, k.MieuTa as MieuTa, k.TinhTrang as TTrang,k.NgayBatDau as NBatDau, k.NgayKetThuc as NKetThuc, k.NgayDuocThem as NgayDuocThem, k.TiLeHT as TiLeHT " +
                               "from (Select * from NhiemVu inner join (select MaNV, Anh, HoTen from NhanVien) p on NhiemVu.MaNguoiSoHuu=p.MaNV) k inner join DuAn " +
                               "on k.MaDA=DuAn.MaDA where k.TinhTrang = '"+ tinhtrang +"' and TenNhiemVu LIKE N'%" + search + "%'";

                string query = "Select MaDA, TenDuAn, MaNhiemVu, TenNhiemVu, Anh, MaNV, HoTen, TTrang, NBatDau, NKetThuc, TiLeHT from (" + table + ") k " +
                                "order by k.TenDuAn " +
                               "offset " + soNVMoiTrang * (trang - 1) + " rows " +
                               "FETCH NEXT " + soNVMoiTrang + " rows only";
                SqlCommand cmd = new SqlCommand(query, dao.conn);
                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public int DemNhiemVuTheoTinhTrangVaNhanVien(string tinhtrang, string maNV, string search)
        {
            string query = "Select DuAn.MaDA as MaDA, TenDuAn, MaNhiemVu, TenNhiemVu, Anh, MaNV, HoTen, k.MieuTa as MieuTa, k.TinhTrang as TTrang,k.NgayBatDau as NBatDau, k.NgayKetThuc as NKetThuc, k.NgayDuocThem as NgayDuocThem, k.TiLeHT as TiLeHT " +
                               "from (Select * from NhiemVu inner join (select MaNV, Anh, HoTen from NhanVien) p on NhiemVu.MaNguoiSoHuu=p.MaNV) k inner join DuAn " +
                               "on k.MaDA=DuAn.MaDA where k.TinhTrang = '" + tinhtrang + "' and MaNV = '" + maNV + "' and TenNhiemVu LIKE N'%" + search + "%'";
            return Dem(query);
        }
        public SqlDataReader DanhSachNhiemVuTheoTinhTrangVaNhanVien(string tinhtrang, string maNV, string search, int trang, int soNVMoiTrang)
        {
            try
            {
                dao.conn.Open();
                string table = "Select DuAn.MaDA as MaDA, TenDuAn, MaNhiemVu, TenNhiemVu, Anh, MaNV, HoTen,k.MieuTa as MieuTa, k.TinhTrang as TTrang,k.NgayBatDau as NBatDau, k.NgayKetThuc as NKetThuc, k.NgayDuocThem as NgayDuocThem, k.TiLeHT as TiLeHT " +
                               "from (Select * from NhiemVu inner join (select MaNV, Anh, HoTen from NhanVien) p on NhiemVu.MaNguoiSoHuu=p.MaNV) k inner join DuAn " +
                               "on k.MaDA=DuAn.MaDA where k.TinhTrang = '" + tinhtrang + "' and MaNV = '"+ maNV +"' and TenNhiemVu LIKE N'%" + search + "%'";

                string query = "Select MaDA, TenDuAn, MaNhiemVu, TenNhiemVu, Anh, MaNV, HoTen, TTrang, NBatDau, NKetThuc, TiLeHT from (" + table + ") k " +
                                "order by k.TenDuAn " +
                               "offset " + soNVMoiTrang * (trang - 1) + " rows " +
                               "FETCH NEXT " + soNVMoiTrang + " rows only";
                SqlCommand cmd = new SqlCommand(query, dao.conn);
                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public int DemNhiemVuTheoMaNV(string search, string maNV)
        {
            string query = "Select DuAn.MaDA as MaDA, TenDuAn, MaNhiemVu, TenNhiemVu, Anh, MaNV, HoTen, k.MieuTa as MieuTa, k.TinhTrang as TTrang,k.NgayBatDau as NBatDau, k.NgayKetThuc as NKetThuc, k.NgayDuocThem as NgayDuocThem, k.TiLeHT as TiLeHT  " +
                              "from (Select * from NhiemVu inner join (select MaNV, Anh, HoTen from NhanVien) p on NhiemVu.MaNguoiSoHuu=p.MaNV) k inner join DuAn " +
                              "on k.MaDA=DuAn.MaDA where MaNV='{0}' and TenNhiemVu LIKE N'%" + search + "%'";
            string sqlStr = String.Format(query, maNV);
            return Dem(sqlStr);
        }
        public SqlDataReader DocDuDieuNhiemVuTuMaNV(string search, string maNV, int trang, int soNVMoiTrang)
        {
            try
            {
                dao.conn.Open();
                string table = "Select DuAn.MaDA as MaDA, TenDuAn, MaNhiemVu, TenNhiemVu, Anh, MaNV, HoTen, k.MieuTa as MieuTa, k.TinhTrang as TTrang,k.NgayBatDau as NBatDau, k.NgayKetThuc as NKetThuc, k.NgayDuocThem as NgayDuocThem, k.TiLeHT as TiLeHT " +
                               "from (Select * from NhiemVu inner join (select MaNV, Anh, HoTen from NhanVien) p on NhiemVu.MaNguoiSoHuu=p.MaNV) k inner join DuAn " +
                               "on k.MaDA=DuAn.MaDA where k.MaNV = '{0}' and TenNhiemVu LIKE N'%" + search + "%'";
                string query = "Select MaDA, TenDuAn, MaNhiemVu, TenNhiemVu, Anh, MaNV, HoTen, TTrang, NBatDau, NKetThuc, TiLeHT  from (" + table + ") k " +
                              "order by k.TenDuAn " +
                             "offset " + soNVMoiTrang * (trang - 1) + " rows " +
                             "FETCH NEXT " + soNVMoiTrang + " rows only";
                string sqlStr = String.Format(query, maNV);
                SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
                var reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }
       
        
        
        public SqlDataReader DocDuDieuNhiemVuTuMaDA(int maDA)
        {
            try
            {
                dao.conn.Open();
                string query = "Select DuAn.MaDA as MaDA, TenDuAn, MaNhiemVu, TenNhiemVu, Anh, MaNV, HoTen, k.MieuTa as MieuTa, k.TinhTrang as TTrang,k.NgayBatDau as NBatDau, k.NgayKetThuc as NKetThuc, k.NgayDuocThem as NgayDuocThem, k.TiLeHT as TiLeHT " +
                               "from (Select * from NhiemVu inner join (select MaNV, Anh, HoTen from NhanVien) p on NhiemVu.MaNguoiSoHuu=p.MaNV) k inner join DuAn " +
                               "on k.MaDA=DuAn.MaDA where DuAn.MaDA = {0}";
               
                string sqlStr = String.Format(query, maDA);
                SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
                var reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }     
        public SqlDataReader DocDuDieuNhiemVuTuMaNhiemVu(int maNhiemVu)
        {
            try
            {
                dao.conn.Open();
                string query = "Select DuAn.MaDA as MaDA, TenDuAn, MaNhiemVu, TenNhiemVu, Anh, MaNV, HoTen, k.MieuTa as MieuTa, k.TinhTrang as TTrang, k.TaiLieu as TaiLieu, k.NgayBatDau as NgayBatDau, k.NgayKetThuc as NgayKetThuc, k.NgayDuocThem as NgayDuocThem, k.TiLeHT as TiLeHT " +
                               "from (Select * from NhiemVu inner join (select MaNV, Anh, HoTen from NhanVien) p on NhiemVu.MaNguoiSoHuu=p.MaNV) k inner join DuAn " +
                               "on k.MaDA=DuAn.MaDA where MaNhiemVu = '{0}'";
                string sqlStr = String.Format(query, maNhiemVu);
                SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
                var reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }
        private void ThucThiLenh(string query, NhiemVu nv , string chucNang)
        {
            try
            {
                dao.conn.Open();
                string sqlStr = String.Format(query, nv.MaNhiemVu, nv.MaDuAn, nv.TenNhiemVu, nv.MieuTa, nv.MaNguoiSoHuu, nv.TinhTrang, nv.NgayBatDau, nv.NgayKetThuc, nv.NgayDuocThem);
                SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
                if (chucNang == "Thêm")
                {
                    if (nv.TaiLieu != null)
                        cmd.Parameters.AddWithValue("@TaiLieu", nv.TaiLieu);
                    else cmd.Parameters.Add("@TaiLieu", System.Data.SqlDbType.VarBinary).Value = DBNull.Value;
                }
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show(chucNang + " thành công");
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
        public void ThemNhiemVu(NhiemVu nv)
        {
            string query = "INSERT INTO NhiemVu VALUES ({0}, {1} , N'{2}', N'{3}','{4}', N'{5}',N'{6}',N'{7}',N'{8}', @TaiLieu, 0)";
            ThucThiLenh(query, nv, "Thêm");
        }
        public void CapNhatNhiemVu(NhiemVu nv)
        {
            string query = "Update NhiemVu set MaDA={1}, " +
            "TenNhiemVu=N'{2}', " +
            "MieuTa=N'{3}', " +
            "MaNguoiSoHuu='{4}', " +
            "TinhTrang=N'{5}', " +
            "NgayBatDau='{6}', " +
            "NgayKetThuc='{7}' " +
            "where MaNhiemVu = {0}";
            ThucThiLenh(query, nv, "Sửa");
        }
        public void CapNhatTinhTrangTheoMaNV(NhiemVu nv)
        {
            try
            {
                dao.conn.Open();
                string query = "UPDATE NhiemVu set TinhTrang=N'{0}' where MaNhiemVu={1}";
                string sqlStr = String.Format(query, nv.TinhTrang, nv.MaNhiemVu);
                SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại \n" + ex.Message);
            }
            finally
            {
                dao.conn.Close();
            }
        }
        public void XoaNhiemVu(NhiemVu nv)
        {
            string query = "DELETE FROM NhiemVu where MaNhiemVu = {0}";
            ThucThiLenh(query, nv, "Xóa");
        }
        public void XoaNhiemVuTheoMaDA(int maDA)
        {
            try
            {
                dao.conn.Open();
                string query = "DELETE FROM NhiemVu where MaDA = {0}";
                string sqlStr = String.Format(query, maDA);
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
        public int DemNhiemVuTheoMaDA(int maDA)
        {
            string query = "Select * from NhiemVu where MaDa={0}";
            string sqlStr = String.Format(query, maDA);
            return Dem(sqlStr);
        }
        public int DemNhiemVuTheoMaDAHoanThanh(int maDA)
        {
            string query = "Select * from NhiemVu where MaDa={0} and TinhTrang='Completed'";
            string sqlStr = String.Format(query, maDA);
            return Dem(sqlStr);
        }
        public SqlDataReader CacNhiemVuCuaDuAn(int maDA)
        {
            try
            {
                dao.conn.Open();
                string query = "Select * from NhiemVu where MaDA={0}";
                string sqlStr = String.Format(query, maDA);
                SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
                var reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public int MaNhiemVuMax()
        {
            try
            {
                dao.conn.Open();
                string query = "Select * from NhiemVu";
                SqlCommand cmd = new SqlCommand(query, dao.conn);
                var reader = cmd.ExecuteReader();
                int max = 0;
                while (reader.Read())
                {
                    if (Convert.ToInt32(reader["MaNhiemVu"].ToString().Trim()) > max)
                    {
                        max = Convert.ToInt32(reader["MaNhiemVu"].ToString().Trim());
                    }
                }
                dao.conn.Close();
                return max;
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
        
        public SqlDataReader TiLeHTCuaNhiemVu(int maDA)
        {
            try
            {
                dao.conn.Open();
                string query = "Select TiLeHT from NhiemVu where MaDa={0}";
                string sqlStr = String.Format(query, maDA);
                SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
                var reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public void CapNhatTiLeHTNhiemVu(NhiemVu nv)
        {
            try
            {
                dao.conn.Open();
                string query = "Update NhiemVu set tiLeHT={0} where MaNhiemVu={1}";
                string sqlStr = String.Format(query, nv.TiLeHT, nv.MaNhiemVu);
                SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại \n" + ex.Message);
            }
            finally
            {
                dao.conn.Close();
            }
        }
        public SqlDataReader NhanVienDuAn()
        {
            try
            {
                dao.conn.Open();
                string query = "Select distinct HoTen, MaNV from NhiemVu inner join NhanVien on MaNguoiSoHuu=MaNV";
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
        public SqlDataReader NhanVienDuAnTheoTinhTrang(string tinhTrang)
        {
            try
            {
                dao.conn.Open();
                string query = "Select distinct HoTen, MaNV from NhiemVu inner join NhanVien on MaNguoiSoHuu=MaNV where NhiemVu.TinhTrang = '{0}'";
                string sqlStr = String.Format(query, tinhTrang);
                SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
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
