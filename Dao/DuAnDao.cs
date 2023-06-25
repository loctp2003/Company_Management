using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using QuanLyDuAn.Models;
using System.Data;
using System.CodeDom;

namespace QuanLyDuAn.Dao
{
    internal class DuAnDao
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
       
        public SqlDataReader NguoiSoHuuDuAn()
        {
            try
            {
                dao.conn.Open();
                string query = "Select distinct MaNV, HoTen " +
                     "from DuAn inner join NhanVien " +
                     "on DuAn.MaNguoiSoHuu = NhanVien.MaNV";
                SqlCommand cmd = new SqlCommand(query, dao.conn);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public SqlDataReader NguoiSoHuuDuAnTheoTinhTrang(string tinhTrang)
        {
            try
            {
                dao.conn.Open();
                string query = "Select distinct MaNV, HoTen " +
                     "from DuAn inner join NhanVien " +
                     "on DuAn.MaNguoiSoHuu = NhanVien.MaNV " +
                     "where DuAn.TinhTrang = '{0}'";
                string sqlStr = string.Format(query, tinhTrang);
                SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public int DemDuAn(string search)
        {
            string query = "Select MaDA, TenDuAn, Anh, HoTen, DuAn.TinhTrang as TTrang, TaiLieu, NgayBatDau, NgayKetThuc, TiLeHT " +
                     "from DuAn inner join NhanVien " +
                     "on DuAn.MaNguoiSoHuu = NhanVien.MaNV where TenDuAn LIKE N'%" + search + "%'";
            return Dem(query);
        }
        public SqlDataReader DanhSachDuAn(string search, int trang, int soDAMoiTrang)
        {
            try
            {
                dao.conn.Open();
                string table = "Select MaDA, TenDuAn, MaNV, Anh, HoTen, DuAn.TinhTrang as TTrang, TaiLieu, NgayBatDau, NgayKetThuc, TiLeHT " +
                    "from DuAn inner join NhanVien " +
                    "on DuAn.MaNguoiSoHuu = NhanVien.MaNV where TenDuAn LIKE N'%" + search + "%'";
                string query = "Select MaDA, TenDuAn, MaNV, Anh, HoTen, TTrang, TaiLieu, NgayBatDau, NgayKetThuc, TiLeHT from (" + table + ") k " +
                   "order by k.MaDA " +
                   "offset " + soDAMoiTrang * (trang - 1) + " rows " +
                   "FETCH NEXT " + soDAMoiTrang + " rows only";
                SqlCommand cmd = new SqlCommand(query, dao.conn);
                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public int DemDuAnTheoTinhTrang(string search, string tinhTrang)
        {
            string query = "Select MaDA, TenDuAn, Anh, MaNV, HoTen, DuAn.TinhTrang as TTrang, TaiLieu, NgayBatDau, NgayKetThuc, TiLeHT " +
                   "from DuAn inner join NhanVien " +
                   "on DuAn.MaNguoiSoHuu = NhanVien.MaNV " +
                   "where DuAn.TinhTrang = '{0}' and TenDuAn LIKE N'%" + search + "%'";
            string sqlStr = string.Format(query, tinhTrang);
            return Dem(sqlStr);
        }
        public SqlDataReader DanhSachDuAnTheoTinhTrang(int trang, int soDAMoiTrang, string search, string tinhTrang)
        {
            try
            {
                dao.conn.Open();
                string table = "Select MaDA, TenDuAn, Anh, MaNV, HoTen, DuAn.TinhTrang as TTrang, TaiLieu, NgayBatDau, NgayKetThuc, TiLeHT " +
                    "from DuAn inner join NhanVien " +
                    "on DuAn.MaNguoiSoHuu = NhanVien.MaNV";
                string query = "Select MaDA, TenDuAn, Anh, MaNV, HoTen, TTrang, TaiLieu, NgayBatDau, NgayKetThuc, TiLeHT from (" + table + ") k " +
                   "where TTrang = '{0}' and TenDuAn LIKE N'%" + search + "%' " +
                   "order by k.MaDA " +
                   "offset " + soDAMoiTrang * (trang - 1) + " rows " +
                   "FETCH NEXT " + soDAMoiTrang + " rows only";
                string sqlStr = string.Format(query, tinhTrang);
                SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public int DemDuAnTheoTinhTrangVaNSH(string search, string tinhTrang, string maNSH)
        {
            string query = "Select MaDA, TenDuAn, Anh, MaNV, HoTen, DuAn.TinhTrang as TTrang, TaiLieu, NgayBatDau, NgayKetThuc, TiLeHT " +
                   "from DuAn inner join NhanVien " +
                   "on DuAn.MaNguoiSoHuu = NhanVien.MaNV " +
                   "where DuAn.TinhTrang = '{0}' and MaNV= '{1}' and TenDuAn LIKE N'%" + search + "%'";
            string sqlStr = string.Format(query, tinhTrang, maNSH);
            return Dem(sqlStr);
        }
        public SqlDataReader DanhSachDuAnTheoTinhTrangVaNSH(int trang, int soDAMoiTrang, string search, string tinhTrang, string maNSH)
        {
            try
            {
                dao.conn.Open();
                string table = "Select MaDA, TenDuAn, MaNV, Anh, HoTen, DuAn.TinhTrang as TTrang, TaiLieu, NgayBatDau, NgayKetThuc, TiLeHT " +
                    "from DuAn inner join NhanVien " +
                    "on DuAn.MaNguoiSoHuu = NhanVien.MaNV";
                string query = "Select MaDA, TenDuAn, MaNV, Anh, HoTen, TTrang, TaiLieu, NgayBatDau, NgayKetThuc, TiLeHT from (" + table + ") k " +
                   "where TTrang = '{0}' and MaNV= '{1}' and TenDuAn LIKE N'%" + search + "%' " +
                   "order by k.MaDA " +
                   "offset " + soDAMoiTrang * (trang - 1) + " rows " +
                   "FETCH NEXT " + soDAMoiTrang + " rows only";
                string sqlStr = string.Format(query, tinhTrang, maNSH);
                SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public SqlDataReader DanhSachDuAnTheoMaNV(string maNV)
        {
            try
            {
                dao.conn.Open();
                string query1 = "Select DuAn.MaDA as MaDA, DuAn.TenDuAn as TenDuAn, DuAn.MaNguoiSoHuu as MaNguoiSoHuu, DuAn.TinhTrang as TTrang, DuAn.TaiLieu as TaiLieu, DuAn.NgayBatDau as NgayBatDau, DuAn.NgayKetThuc as NgayKetThuc, DuAn.TiLeHT as TiLeHT " +
                               "from (Select * from NhiemVu inner join (select MaNV, Anh, HoTen from NhanVien) p on NhiemVu.MaNguoiSoHuu=p.MaNV) k inner join DuAn " +
                               "on k.MaDA=DuAn.MaDA where k.MaNV = '{0}'";
                string query2 = "Select MaDA, TenDuAn, Anh, MaNV, HoTen, TTrang, TaiLieu, NgayBatDau, NgayKetThuc, TiLeHT from (" + query1 + ") k " +
                                "inner join NhanVien " +
                                "on k.MaNguoiSoHuu = NhanVien.MaNV";
                string sqlStr = String.Format(query2, maNV);
                SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public SqlDataReader DanhSachDuAnTheoTK(string MaNV)
        {
            try
            {
                dao.conn.Open();
                string query = "Select MaDA, TenDuAn, Anh, HoTen, DuAn.TinhTrang as TTrang, TaiLieu, NgayBatDau, NgayKetThuc, TiLeHT " +
                    "from DuAn inner join NhanVien " +
                    "on DuAn.MaNguoiSoHuu = NhanVien.MaNV " +
                    "where MaNV = '{0}'";
                string sqlStr = String.Format(query, MaNV);
                SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        private void ThucThiLenh(string query, DuAn da, string chucNang)
        {
            try
            {
                dao.conn.Open();
                string sqlStr = String.Format(query, da.MaDA, da.TenDuAn, da.MieuTa, da.TinhTrang, da.MaNguoiSoHuu, da.NgayBatDau, da.NgayKetThuc, da.NgayDuocThem);
                SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
                if (chucNang == "Thêm")
                {
                    if (da.TaiLieu != null)
                        cmd.Parameters.AddWithValue("@TaiLieu", da.TaiLieu);
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

        public void ThemDuAn(DuAn da)
        {
            string query = "INSERT INTO DuAn VALUES (N'{0}', N'{1}',N'{2}',N'{3}',N'{4}',@TaiLieu, N'{5}',N'{6}',N'{7}', 0)";
            ThucThiLenh(query, da, "Thêm");
        }

        public SqlDataReader DocDuDieuDuAnTuMaDA(int maDA)
        {
            try
            {
                dao.conn.Open();
                string query = "Select MaDA, NhanVien.MaNV as MaNV, TenDuAn, MieuTa, Anh, HoTen, DuAn.TinhTrang as TTrang, TaiLieu, NgayBatDau, NgayKetThuc, NgayDuocThem, TiLeHT " +
                    "from DuAn inner join NhanVien " +
                    "on DuAn.MaNguoiSoHuu = NhanVien.MaNV " +
                    "where MaDA = {0}";
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
        
        public void CapNhatDuAn(DuAn da)
        {
            string query = "Update DuAn set TenDuAn=N'{1}', " +
            "TinhTrang=N'{3}', " +
            "MaNguoiSoHuu='{4}', " +
            "NgayBatDau='{5}', " +
            "NgayKetThuc='{6}' " +
            "where MaDA = {0}";
            ThucThiLenh(query, da, "Sửa");
        }
        public void XoaDuAn(DuAn da)
        {
            string query = "DELETE From DuAn where MaDA = {0}";
            ThucThiLenh(query, da, "Xóa");
        }
        public void CapNhatTaiLieuDuAn(byte[] file, int MaDA)
        {
            try
            {
                dao.conn.Open();
                string query = "Update DuAn set " +
                "TaiLieu=@TaiLieu " +
                "where MaDA =@MaDA ";
                SqlCommand cmd = new SqlCommand(query, dao.conn);
                cmd.Parameters.AddWithValue("@TaiLieu", file);
                cmd.Parameters.AddWithValue("@MaDA", MaDA);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa thành công");
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
        public void CapNhatMieuTaDuAn(string mieuTa, int MaDA)
        {
            try
            {
                dao.conn.Open();
                string query = "Update DuAn set " +
                "MieuTa=@MieuTa " +
                "where MaDA =@MaDA ";
                SqlCommand cmd = new SqlCommand(query, dao.conn);
                cmd.Parameters.AddWithValue("@MieuTa", mieuTa);
                cmd.Parameters.AddWithValue("@MaDA", MaDA);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa thành công");
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
        public int MaDuAnMax()
        {
            try
            {
                dao.conn.Open();
                string query = "Select * from DuAn";
                SqlCommand cmd = new SqlCommand(query, dao.conn);
                var reader = cmd.ExecuteReader();
                int max = 0;
                while (reader.Read())
                {
                    if (Convert.ToInt32(reader["MaDA"].ToString().Trim()) > max)
                    {
                        max = Convert.ToInt32(reader["MaDA"].ToString().Trim());
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
        public void CapNhatTiLeHTDuAn(DuAn da)
        {
            try
            {
                dao.conn.Open();
                string query = "Update DuAn set tiLeHT={0} where MaDA={1}";
                string sqlStr = String.Format(query, da.TiLeHT, da.MaDA);
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
        public void CapNhatTinhTrangTheoMaDA(DuAn da)
        {
            try
            {
                dao.conn.Open();
                string query = "UPDATE DuAn set TinhTrang=N'{0}' where MaDA={1}";
                string sqlStr = String.Format(query, da.TinhTrang, da.MaDA);
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
    }
}
