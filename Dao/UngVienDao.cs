using QuanLyDuAn.Dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuAn.Pages
{
    internal class UngVienDao
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
            string query = "SELECT * FROM UngVien";
            return LayDuLieu(query, "", "");
        }
    }
}
