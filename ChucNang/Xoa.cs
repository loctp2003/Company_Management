using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDuAn.Dao;

namespace QuanLyDuAn.ChucNang
{
    internal class Xoa
    {
        private static NhanVienThamGiaDADao nvtgd = new NhanVienThamGiaDADao();
        private static NhiemVuNhoDao nvnd = new NhiemVuNhoDao();
        private static NhiemVuDao nvd = new NhiemVuDao();
        private static DuAnDao dad = new DuAnDao();
        private static NopFileDao nfd = new NopFileDao();
        private static DanhGiaDao dgd = new DanhGiaDao();

        public static void XoaNhiemVuNho(int maNVNho, int maNV, int maDA)
        {
            nfd.XoaFileTheoMaNVNho(new NopFile(maNVNho));
            nvnd.XoaNhiemVuNho(new NhiemVuNho(maNVNho));
            CapNhat.CapNhatTiLeHTNhiemVu(maNV);
            CapNhat.CapNhatTiLeHTDuAn(maDA);
        }
        public static void XoaNhiemVu(int maNV, int maDA)
        {
            List<int> maNVNhoList = new List<int>();
            var reader = nvnd.DocDuLieuNhiemVuNhoTheoMaNV(maNV);
            while (reader.Read())
            {
                int maNVNho = Convert.ToInt32(reader["MaNhiemVuNho"].ToString().Trim());
                maNVNhoList.Add(maNVNho);
               
            }
            nvnd.dao.conn.Close();
            foreach(int maNVNho in maNVNhoList)
            {
                XoaNhiemVuNho(maNVNho, maNV, maDA);
            }
            dgd.XoaDanhGiaTheoMaNV(new Models.DanhGia(0, maNV));
            nvd.XoaNhiemVu(new Models.NhiemVu(maNV));
            CapNhat.CapNhatTiLeHTDuAn(maDA);
        }
        public static void XoaDuAn(int maDA)
        {
            List<int> maNVList = new List<int>();
            var reader = nvd.CacNhiemVuCuaDuAn(maDA);
            while (reader.Read())
            {
                int maNV = Convert.ToInt32(reader["MaNhiemVu"].ToString().Trim());
                maNVList.Add(maNV);
                
            }
            nvd.dao.conn.Close();
            foreach (int maNV in maNVList)
            {
                XoaNhiemVu(maNV, maDA);
            }
            nvtgd.XoaNhanVienThamGiaDA(new Models.NhanVienThamGiaDA(maDA));
            dad.XoaDuAn(new Models.DuAn(maDA));
        }
    }
}
