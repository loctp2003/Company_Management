using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using QuanLyDuAn.Models;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyDuAn.Dao
{
    internal class DangNhapDao
    {
        DBConnection dao = new DBConnection();
        public void KiemTraSDT(string sdt)
        {
            string vn_regex = "((09|03|07|08|05)+([0-9]{8})$)";
            Regex regex = new Regex(vn_regex);
            if (!regex.IsMatch(sdt))
                throw new Exception("Số điện thoại không hợp lệ");
        }
        public bool KiemTraEmail(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void KiemTraDangNhap(string username, string password, string query)
        {
            dao.conn.Open();
            SqlCommand cmd = new SqlCommand(query, dao.conn);
            var danhmuc1 = new SqlParameter("@usernameLogIn", username);
            var danhmuc2 = new SqlParameter("@pass_word", password);
            cmd.Parameters.Add(danhmuc1);
            cmd.Parameters.Add(danhmuc2);
            if (!cmd.ExecuteReader().HasRows)
            {
                dao.conn.Close();
                throw new Exception("");
            }
            else dao.conn.Close();

        }
    }
}
