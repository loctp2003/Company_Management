using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Nest;
using System.Runtime.InteropServices;
using QuanLyDuAn.Models;

namespace QuanLyDuAn.Dao.Dao
{
    internal class LuongDao
    {
        public DBConnection dao = new DBConnection();
        string query()
        {
            string query1 = "Select NhanVien.MaNV, HoTen, Count(CheckOut) as NgayCong, Count(LyDo) as VangPhep, YEAR(Ngay) as Nam, MONTH(Ngay) as Thang " +
                                "from ChamCong inner join NHANVIEN on ChamCong.MaNV = NhanVien.MaNV group by NhanVien.MaNV, HoTen, YEAR(Ngay), MONTH(Ngay)";
            string query2 = "SELECT Luong.MaNV, HoTen, LuongCoBan, NgayCong, VangPhep, Thuong, Nam, Thang, LuongNhan " +
                            "FROM (" + query1 + ")k INNER JOIN Luong ON k.MaNV = Luong.MaNV";
            return query2;
        }
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
        public DataTable TimKiemNhanVien(string ob)
        {
            string query1 = "select * from (" + query() + ")q where q.MaNV = '{0}'";
            return LayDuLieu(query1, ob, "");
        }
        public DataTable DanhSachLuong()
        {
            return LayDuLieu(query(), "", "");
        }
        public DataTable DanhSachLuongTheoThangNam(int thang, int nam)
        {
            string query1 = "select * from (" + query() + ")q where q.Thang = " + thang + "and q.Nam = " + nam;
            return LayDuLieu(query1, thang, nam);
        }
        public void UpdateLuong(double luong, string maNV, int thang, int nam)
        {
            try
            {
                string sqlstr = string.Format("UPDATE T SET T.LuongNhan = '{0}' FROM ({1}) AS T WHERE T.MaNV = '{2}' AND T.Thang = '{3}' AND T.Nam = '{4}'", luong, query(), maNV, thang, nam);
                dao.conn.Open();
                SqlCommand cmd = new SqlCommand(sqlstr, dao.conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Đã tính lương cho nhân viên");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dao.conn.Close();
            }
        }
    }
}
