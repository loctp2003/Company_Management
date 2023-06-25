using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using QuanLyDuAn.Models;
using Utilities.BunifuCircleProgress.Transitions;

namespace QuanLyDuAn.Dao
{
    internal class DBConnection
    {
        public SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
        public DBConnection()
        {
            conn = new SqlConnection(Properties.Settings.Default.conn);
        }
        public DataTable DanhSach(string s)
        {
            string sqlStr = string.Format(s);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    row[i] = row[i].ToString().Trim();
                }
            }
            return dt;
        }

    }
}
