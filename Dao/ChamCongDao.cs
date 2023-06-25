using Nest;
using QuanLyDuAn.Forms;
using QuanLyDuAn.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyDuAn.Dao
{
    internal class ChamCongDao
    {
        public bool checkin = false;
        public DBConnection dao = new DBConnection();
        public void InsertCheckin(ChamCong cc)
        {
            if (!checkin)
            {
                try
                {
                    string query = string.Format("INSERT INTO ChamCong(MaNV , CheckIn, CheckOut, LyDo, ChuThich, Ngay) VALUES ('{0}', '{1}', @CheckOut, @LyDo, @ChuThich, '{2}')",
                                            cc.MaNV, cc.CheckIn, cc.Ngay.Date);

                    dao.conn.Open();
                    SqlCommand cmd = new SqlCommand(query, dao.conn);
                    cmd.Parameters.AddWithValue("@CheckOut", DBNull.Value);
                    cmd.Parameters.AddWithValue("@LyDo", DBNull.Value);
                    cmd.Parameters.AddWithValue("@ChuThich", DBNull.Value);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Đã checkin thành công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("CheckIn không hợp lệ!");
                }
                finally
                {
                    dao.conn.Close();
                    checkin = true;
                }
            }
            else
            {
                MessageBox.Show("Bạn đã checkin rồi");
            }
        }
        public void UpdateCheckOut(ChamCong cc)
        {
            if (checkin)
            {
                try
                {
                    string query = string.Format("UPDATE ChamCong SET CheckOut = '{2}'WHERE MaNV = '{0}' and Ngay = '{1}'",
                                           cc.MaNV, cc.Ngay, cc.CheckOut);

                    dao.conn.Open();
                    SqlCommand cmd = new SqlCommand(query, dao.conn);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Đã checkout thành công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("CheckOut không hợp lệ!");
                }
                finally
                {
                    dao.conn.Close();
                    checkin = false;
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa checkin");
            }
        }
        public void InsertNghi(ChamCong cc)
        {
            try
            {
                string query = string.Format("INSERT INTO ChamCong(MaNV , CheckIn, CheckOut, LyDo, ChuThich, Ngay) VALUES ('{0}', @CheckIn, @CheckOut, N'{1}', N'{2}', '{3}')",
                                            cc.MaNV, cc.LyDo, cc.ChuThich, cc.Ngay.Date);

                dao.conn.Open();
                SqlCommand cmd = new SqlCommand(query, dao.conn);
                cmd.Parameters.AddWithValue("@CheckIn", DBNull.Value);
                cmd.Parameters.AddWithValue("@CheckOut", DBNull.Value);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xin nghỉ thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xin nghỉ không hợp lệ!");
            }
            finally
            {
                dao.conn.Close();
            }
        }

        public SqlDataReader ThongTinChamCong(int nam, int thang)
        {
            try
            {
                dao.conn.Open();
                string query1 = "Select NhanVien.MaNV, HoTen, Count(CheckOut) as NgayCong, Count(LyDo) as VangPhep, YEAR(Ngay) as Nam, MONTH(Ngay) as Thang " +
                                "from ChamCong inner join NHANVIEN on ChamCong.MaNV = NhanVien.MaNV group by NhanVien.MaNV, HoTen, YEAR(Ngay), MONTH(Ngay)";
                string query2 = "select * from ("+ query1 + ")k where k.Nam = " + nam + " AND k.Thang = " + thang;
                string sqlstr = string.Format(query2, nam, thang);
                SqlCommand cmd = new SqlCommand(sqlstr, dao.conn);
                var reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public SqlDataReader DocDuDieuNhanVienTuMaNV(string MaNV)
        {
            try
            {
                dao.conn.Open();
                string query = "Select NhanVien.MaNV, HoTen, CheckIn, Checkout, Lydo, ChuThich, Ngay " +
                                "from ChamCong inner join NhanVien on ChamCong.MaNV = NhanVien.MaNV where NhanVien.MaNV ='{0}'";
                string sqlStr = String.Format(query, MaNV);
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
        public SqlDataReader DocDuDieuNhanVienTuMaNVvaNgay(string MaNV, DateTime Ngay)
        {
            try
            {
                dao.conn.Open();
                string query = "Select CheckIn, Checkout, Lydo, ChuThich, Ngay from ChamCong where MaNV = '{0}' and Ngay = '{1}'";
                string sqlStr = String.Format(query, MaNV, Ngay);
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
