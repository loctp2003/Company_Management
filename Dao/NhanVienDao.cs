using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyDuAn.Models;
using System.Windows.Controls;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;

namespace QuanLyDuAn.Dao.Dao
{
    internal class NhanVienDao
    {
        public DBConnection dao = new DBConnection();
        private void ThucThiLenh(string query, NhanVien nv, string chucNang)
        {
            try
            {
                dao.conn.Open();
                string sqlStr = String.Format(query, nv.MaNV, nv.HoTen, nv.GioiTinh, nv.HonNhan,nv.DiaChi, nv.QueQuan, nv.NgaySinh, nv.SDT, nv.DanToc,
                    nv.TinhTrang, nv.Email, nv.MaPB, nv.ViTri, nv.NgayVao);
                SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
                cmd.Parameters.AddWithValue("@Image", nv.Anh);
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
        public int DemDanhSachNhanVien(string search)
        {
            string query = "Select MaNV, Anh, HoTen, GioiTinh , TenPB, TenChucVu ,TinhTrang, NgayVao from (Select * from NhanVien inner join ChucVu " +
                                    "on NhanVien.ViTri=ChucVu.MaChucVu) k inner join PhongBan on k.MaPB=Phongban.MaPB where HoTen LIKE N'%" + search + "%'";
            return Dem(query);
        }
        public DataTable DanhSachNhanVien(string search, int trang, int soNVMoiTrang)
        {
            try
            {
                dao.conn.Open();
                string table = "Select MaNV, Anh, HoTen, GioiTinh , TenPB, TenChucVu ,TinhTrang, NgayVao from (Select * from NhanVien inner join ChucVu " +
                                    "on NhanVien.ViTri=ChucVu.MaChucVu) k inner join PhongBan on k.MaPB=Phongban.MaPB where HoTen LIKE N'%" + search + "%'";
                                    
                string query = "Select Anh, MaNV, HoTen, GioiTinh , TenPB, TenChucVu ,TinhTrang, NgayVao from ( " + table +" ) k " +
                                "order by k.MaNV " +
                                "offset "+ soNVMoiTrang * (trang - 1) +" rows " +
                                "FETCH NEXT " + soNVMoiTrang + " rows only";
                SqlCommand cmd = new SqlCommand(query, dao.conn);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                foreach (DataRow row in dt.Rows)
                {
                    for (int i = 1; i <  dt.Columns.Count; i++)
                    {
                        if (row[i].ToString() != null)
                        {
                            row[i] = row[i].ToString().Trim();
                        }
                    }
                }
                dao.conn.Close();
                return dt;
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
        public void CapNhatNhanVien(NhanVien nv)
        {
            string query = "Update NhanVien set HoTen=N'{1}', " +
            "GIoiTinh=N'{2}', " +
            "HonNhan=N'{3}', " +
            "DiaChi=N'{4}', " +
            "QueQuan=N'{5}', " +
            "NgaySinh='{6}', " +
            "SoDienThoai='{7}', " +
            "DanToc='{8}', " +
            "TinhTrang=N'{9}', " +
            "Email=N'{10}', " +
            "MaPB=N'{11}', " +
            "ViTri=N'{12}', "+
            "NgayVao=N'{13}',  " +
            "Anh=@Image " +
            "where MaNV = '{0}'";
            ThucThiLenh(query, nv, "Lưu");
        }
        public SqlDataReader DocDuDieuNhanVienTuTK(string loaiTk, string username, string password)
        {
            try
            {
                string loaiMa = "";
                if (loaiTk == "TkGiamDoc")
                    loaiMa = "GD";
                else loaiMa = "NVTK";

                
                dao.conn.Open();
                string query = "Select * from (Select * from (Select * " +
                                "from {2} inner join NhanVien " +
                                "on {2}.Ma{3} = NhanVien.MaNV where Username = '{0}' and Pass_word = '{1}') p inner join ChucVu " +
                                "on p.ViTri=ChucVu.MaChucVu) k inner join PhongBan on k.MaPB=Phongban.MaPB";
                string sqlStr = String.Format(query, username, password, loaiTk, loaiMa);
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
        public SqlDataReader DocDuDieuNhanVien()
        {
            try
            {
                dao.conn.Open();
                string query = "Select * from (Select * from NhanVien p inner join ChucVu " +
                                "on p.ViTri=ChucVu.MaChucVu) k inner join PhongBan on k.MaPB=Phongban.MaPB";
                string sqlStr = String.Format(query);
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
        public SqlDataReader DocDuDieuNhanVienTuMaNV(string MaNV)
        {
            try
            {
                dao.conn.Open();
                string query = "Select * from (Select * from NhanVien p inner join ChucVu " +
                                "on p.ViTri=ChucVu.MaChucVu) k inner join PhongBan on k.MaPB=Phongban.MaPB where MaNV ='{0}'";
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
        public SqlDataReader DocDuDieuNhanVienTuMaPB(string MaPB)
        {
            try
            {
                dao.conn.Open();
                string query = "Select * from (Select * from NhanVien p inner join ChucVu " +
                                "on p.ViTri=ChucVu.MaChucVu) k inner join PhongBan on k.MaPB=Phongban.MaPB where Phongban.MaPB ='{0}'";
                string sqlStr = String.Format(query, MaPB);
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
        public SqlDataReader DocDuLieuNhanVienQLDA()
        {
            try
            {
                dao.conn.Open();
                string query = "Select * from (Select * from NhanVien p inner join ChucVu " +
                                "on p.ViTri=ChucVu.MaChucVu) k inner join PhongBan on k.MaPB=Phongban.MaPB where k.MaPB = 'PB000' or k.MaPB = 'PB009'";
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
        public int DemDuDieuNhanVienTuPhongBan(string phongBan, string search)
        {
            string query = "Select Anh, MaNV, HoTen, GioiTinh , TenPB, TenChucVu ,TinhTrang, NgayVao from (Select * from NhanVien p inner join ChucVu " +
                                "on p.ViTri=ChucVu.MaChucVu) k inner join PhongBan on k.MaPB=Phongban.MaPB where TenPB=N'" + phongBan + "'  and HoTen LIKE N'%" + search + "%'";
            return Dem(query);
        }
        public DataTable DocDuDieuNhanVienTuPhongBan(string phongBan, string search, int trang, int soNVMoiTrang)
        {
            try
            {
                dao.conn.Open();
                string table = "Select Anh, MaNV, HoTen, GioiTinh , TenPB, TenChucVu ,TinhTrang, NgayVao from (Select * from NhanVien p inner join ChucVu " +
                                "on p.ViTri=ChucVu.MaChucVu) k inner join PhongBan on k.MaPB=Phongban.MaPB where TenPB=N'" + phongBan + "' and HoTen LIKE N'%" + search + "%'";
                string query = "Select Anh, MaNV, HoTen, GioiTinh , TenPB, TenChucVu ,TinhTrang, NgayVao from ( " + table + " ) k " +
                              "order by k.MaNV " +
                              "offset " + soNVMoiTrang * (trang - 1) + " rows " +
                              "FETCH NEXT " + soNVMoiTrang + " rows only";
                SqlCommand cmd = new SqlCommand(query, dao.conn);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                foreach (DataRow row in dt.Rows)
                {
                    for (int i = 1; i < dt.Columns.Count; i++)
                    {
                        if (row[i].ToString() != null)
                        {
                            row[i] = row[i].ToString().Trim();
                        }
                    }
                }
                dao.conn.Close();
                return dt;
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
        public int DemDuDieuNhanVienTuPhongBanVaChucVu(string phongBan, string chucVu, string search)
        {
            string query = "Select Anh, MaNV, HoTen, GioiTinh , TenPB, TenChucVu ,TinhTrang, NgayVao from (Select * from NhanVien p inner join ChucVu " +
                              "on p.ViTri=ChucVu.MaChucVu) k inner join PhongBan on k.MaPB=Phongban.MaPB where TenPB=N'" + phongBan + "' and TenChucVu = N'" + chucVu + "'  and HoTen LIKE N'%" + search + "%'";
            return Dem(query);
        }
        public DataTable DocDuDieuNhanVienTuPhongBanVaChucVu(string phongBan, string chucVu, string search, int trang, int soNVMoiTrang)
        {
            try
            {
                dao.conn.Open();
                string table = "Select Anh, MaNV, HoTen, GioiTinh , TenPB, TenChucVu ,TinhTrang, NgayVao from (Select * from NhanVien p inner join ChucVu " +
                               "on p.ViTri=ChucVu.MaChucVu) k inner join PhongBan on k.MaPB=Phongban.MaPB where TenPB=N'" + phongBan + "' and TenChucVu = N'" + chucVu + "'  and HoTen LIKE N'%" + search + "%'";
                string query = "Select Anh, MaNV, HoTen, GioiTinh , TenPB, TenChucVu ,TinhTrang, NgayVao from ( " + table + " ) k " +
                             "order by k.MaNV " +
                             "offset " + soNVMoiTrang * (trang - 1) + " rows " +
                             "FETCH NEXT " + soNVMoiTrang + " rows only";
                SqlCommand cmd = new SqlCommand(query, dao.conn);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                foreach (DataRow row in dt.Rows)
                {
                    for (int i = 1; i < dt.Columns.Count; i++)
                    {
                        if (row[i].ToString() != null)
                        {
                            row[i] = row[i].ToString().Trim();
                        }
                    }
                }
                dao.conn.Close();
                return dt;
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
        public SqlDataReader DocDuLieuNhanVienTuMaChucVu(string maCV)
        {
            try
            {
                dao.conn.Open();
                string query = "Select * from NhanVien where ViTri='{0}'";
                string sqlStr = String.Format(query, maCV);
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
        public DataTable XoaNhanVien(object ob, string search, int trang, int soNVMoiTrang)
        {
            try
            {
                dao.conn.Open();
                string query = "DELETE FROM NhanVien WHERE MaNV='{0}'";
                string sqlStr = string.Format(query, ob);
                SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    dao.conn.Close();
                    return this.DanhSachNhanVien(search, trang, soNVMoiTrang);
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
            return null;
        }
        
        public void ThemNhanVien(NhanVien nv)
        {
            string query = "INSERT INTO NhanVien VALUES (N'{0}', N'{1}',N'{2}',N'{3}',N'{4}', N'{5}', N'{6}',N'{7}',N'{8}',N'{9}', N'{10}', N'{11}',N'{12}',N'{13}',N'{14}',N'{15}', N'{16}',N'{17}',N'{18}',N'{19}',@Anh)";
            ThucThiLenh(query, nv, "Thêm");
        }
        


    }
}
