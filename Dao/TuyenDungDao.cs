using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyDuAn.Dao
{
    internal class TuyenDungDao
    {
        DBConnection dao = new DBConnection();
        private DataTable LayDuLieu(string query, object ob1, object ob2)
        {
            try
            {
                dao.conn.Open();
                string sqlStr = string.Format(query, ob1, ob2);
                if (dao.DanhSach(query).Rows.Count > 0)
                    return dao.DanhSach(query);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dao.conn.Close();
            }
            return null;
        }
        public DataTable DanhSachNhanVien()
        {
            string query = "SELECT * FROM TuyenDung";
            return LayDuLieu(query, "", "");
        }
        public DataTable TimKiemNhanVien(string ob)
        {
            string query = "SELECT * FROM TuyenDung WHERE MaTD='{1}'";
            return LayDuLieu(query, ob, "");
        }

    }
}
