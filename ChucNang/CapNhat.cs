using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDuAn.Dao;
using QuanLyDuAn.Models;
using QuanLyDuAn.Pages;

namespace QuanLyDuAn.ChucNang
{
    internal class CapNhat
    {
        private static NhiemVuNhoDao nvnd = new NhiemVuNhoDao();
        private static NhiemVuDao nvd = new NhiemVuDao();
        private static DuAnDao dad = new DuAnDao();
        public static void CapNhatTinhTrangNhiemVuNho(int val, int maNVNho)
        {
            if (val == 100)
                nvnd.CapNhatTinhTrangTheoMaNVNho(new NhiemVuNho(maNVNho, "Completed"));
            else nvnd.CapNhatTinhTrangTheoMaNVNho(new NhiemVuNho(maNVNho, "In Progress"));
        }
        public static void CapNhatTinhTrangNhiemVu(int val, int maNV)
        {
            if (val == 100)
                nvd.CapNhatTinhTrangTheoMaNV(new NhiemVu(maNV, "Completed"));
            else nvd.CapNhatTinhTrangTheoMaNV(new NhiemVu(maNV, "In Progress"));
        }
        public static void CapNhatTinhTrangDuAn(int val, int maDA)
        {
            if (val == 100)
                dad.CapNhatTinhTrangTheoMaDA(new DuAn(maDA, "Completed"));
            else dad.CapNhatTinhTrangTheoMaDA(new DuAn(maDA, "In Progress"));
        }
       
        public static void CapNhatTiLeHTNhiemVuNho(int maNVNho, int val)
        {
            nvnd.CapNhatTiLeHTTheoMaNVNho(new NhiemVuNho(maNVNho, val));
            CapNhatTinhTrangNhiemVuNho(val, maNVNho);

        }
        public static void CapNhatTiLeHTNhiemVu(int maNV)
        {
            int k = nvnd.DemNhiemVuNhoTheoMaNV(maNV);
            var reader = nvnd.DocDuLieuNhiemVuNhoTheoMaNV(maNV);
            int sum = 0;
            while (reader.Read())
            {
                sum += Convert.ToInt32(reader["TiLeHT"].ToString().Trim());
            }
            nvnd.dao.conn.Close();
            if (k > 0)
            {
                int tiLeHTNV = (sum / k);
                nvd.CapNhatTiLeHTNhiemVu(new NhiemVu(maNV, tiLeHTNV));
                CapNhatTinhTrangNhiemVu(tiLeHTNV, maNV);
            }
        }
        public static void CapNhatTiLeHTDuAn(int maDA)
        {
            int p = nvd.DemNhiemVuTheoMaDA(maDA);
            var reader = nvd.CacNhiemVuCuaDuAn(maDA);
            int sum = 0;
            while (reader.Read())
            {
                sum += Convert.ToInt32(reader["TiLeHT"].ToString().Trim());
            }
            nvd.dao.conn.Close();
            if (p > 0)
            {
                int tiLeHTDA = (sum / p);
                dad.CapNhatTiLeHTDuAn(new DuAn(maDA, tiLeHTDA));
                CapNhatTinhTrangDuAn(tiLeHTDA, maDA);
            }
        }
        
    }
}
