using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDuAn.Models;
using System.Windows.Forms;
using System.Data;
namespace QuanLyDuAn.Dao
{
    internal class NopFileDao
    {
        public DBConnection dao = new DBConnection();
        private void ThucThiLenh(string query, NopFile nf, string chucNang)
        {
            try
            {
                dao.conn.Open();
                string sqlStr = String.Format(query, nf.MaNhiemVuNho, nf.MaNguoiSoHuu, nf.Filter, nf.TenFile, nf.MaNopFile);

                SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
                if (chucNang == "Thêm" || chucNang == "Sửa")
                    cmd.Parameters.Add("@TaiLieu", nf.TaiLieu);
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
        public void ThemFile(NopFile nf)
        {
            string query = "INSERT INTO FileNop VALUES ({0},'{1}', @TaiLieu,'{2}',N'{3}',{4})";
            ThucThiLenh(query, nf, "Thêm");
        }
        public void XoaFileTheoMaNVNho(NopFile nf)
        {
            string query = "Delete from FileNop where MaNhiemVuNho={0}";
            ThucThiLenh(query, nf, "Xóa");
        }
        public SqlDataReader DanhSachFileTheoMaNVVaMaNSH(int maNV, string maNSH)
        {
            try
            {
                dao.conn.Open();
                string query = "Select * from FileNop where MaNhiemVuNho={0} and MaNguoiSoHuu='{1}'";
                string sqlStr = String.Format(query, maNV, maNSH);
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
        public int MaFileNopMax()
        {
            try
            {
                dao.conn.Open();
                string query = "Select * from FileNop";
                SqlCommand cmd = new SqlCommand(query, dao.conn);
                var reader = cmd.ExecuteReader();
                int max = 0;
                while (reader.Read())
                {
                    if (Convert.ToInt32(reader["MaFileNop"].ToString().Trim()) > max)
                    {
                        max = Convert.ToInt32(reader["MaFileNop"].ToString().Trim());
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
        public SqlDataReader DocDuLieuNopFileTuMaNVNho(int maNVNho)
        {
            try
            {
                dao.conn.Open();
                string query = "Select * from FileNop where MaNhiemVuNho={0}";
                string sqlStr = String.Format(query, maNVNho);
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
