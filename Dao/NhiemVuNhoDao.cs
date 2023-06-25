using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using QuanLyDuAn.Models;
using System.Data;
using Nest;

namespace QuanLyDuAn.Dao
{
    internal class NhiemVuNhoDao
    {
        public DBConnection dao = new DBConnection();
        public int MaNhiemVuNhoMax()
        {
            try
            {
                dao.conn.Open();
                string query = "Select * from NhiemVuNho";
                SqlCommand cmd = new SqlCommand(query, dao.conn);
                var reader = cmd.ExecuteReader();
                int max = 0;
                while (reader.Read())
                {
                    if (Convert.ToInt32(reader["MaNhiemVuNho"].ToString().Trim()) > max)
                    {
                        max = Convert.ToInt32(reader["MaNhiemVuNho"].ToString().Trim());
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
        private void ThucThiLenh(string query, NhiemVuNho nv, string chucNang)
        {
            try
            {
                dao.conn.Open();
                string sqlStr = String.Format(query, nv.MaNhiemVuNho, nv.MaNhiemVu, nv.TinhTrang, nv.Ten, nv.TiLeHT);
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
        public void ThemNhiemVuNho(NhiemVuNho nv)
        {
            string query = "INSERT INTO NhiemVuNho VALUES ({0}, {1}, N'{2}', N'{3}', 0)";
            ThucThiLenh(query, nv, "Thêm");
        }
        public void XoaNhiemVuNho(NhiemVuNho nv)
        {
            string query = "DELETE FROM NhiemVuNho where MaNhiemVuNho = {0}";
            ThucThiLenh(query, nv, "Xóa");
        }
        public void XoaNhiemVuNhoTheoMaNV(int maNV)
        {
            try
            {
                dao.conn.Open();
                string query = "DELETE FROM NhiemVuNho where MaNhiemVu = {0}";
                string sqlStr = String.Format(query, maNV);
                SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa thành công");
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
        public void CapNhatNhiemVuNho(NhiemVuNho nv)
        {
            string query = "UPDATE NhiemVuNho set MaNhiemVuNho={0}, MaNhiemVu={1}, TinhTrang=N'{2}', Ten=N'{3}'";
            ThucThiLenh(query, nv, "Sửa");
        }
        public void CapNhatTinhTrangTheoMaNVNho(NhiemVuNho nv)
        {
            try
            {
                dao.conn.Open();
                string query = "UPDATE NhiemVuNho set TinhTrang=N'{0}' where MaNhiemVuNho={1}";
                string sqlStr = String.Format(query, nv.TinhTrang, nv.MaNhiemVuNho);
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
        public void CapNhatTiLeHTTheoMaNVNho(NhiemVuNho nv)
        {
            try
            {
                dao.conn.Open();
                string query = "UPDATE NhiemVuNho set TiLeHT={0} where MaNhiemVuNho={1}";
                string sqlStr = String.Format(query, nv.TiLeHT, nv.MaNhiemVuNho);
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
        public SqlDataReader LayDuLieuTiLeHTTuMaNVN(int maNVN)
        {
            try
            {
                dao.conn.Open();
                string query = "Select TiLeHT from NhiemVuNho where MaNhiemVuNho={0}";
                string sqlStr = String.Format(query, maNVN);
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
        public SqlDataReader DocDuLieuNhiemVuNhoTheoMaNV(int maNV)
        {
            try
            {
                dao.conn.Open();
                string query = "Select * from NhiemVuNho where MaNhiemVu={0}";

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
        public int DemNhiemVuNhoTheoMaNV(int maNV)
        {
            try
            {
                dao.conn.Open();
                string query = "Select * from NhiemVuNho where MaNhiemVu={0}";
                string sqlStr = String.Format(query, maNV);
                SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
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
        public int DemNhiemVuNhoTheoMaNVHoanThanh(int maNV)
        {
            try
            {
                dao.conn.Open();
                string query = "Select * from NhiemVuNho where MaNhiemVu={0} and TinhTrang=N'Hoàn Thành'";
                string sqlStr = String.Format(query, maNV);
                SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
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

    }
}
