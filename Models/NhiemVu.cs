using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuAn.Models
{
    public class NhiemVu
    {
        public int MaNhiemVu {get;set;}
        public int MaDuAn { get; set; }

        public string TenNhiemVu { get; set; }
        public string MieuTa { get; set; } 
        public byte[] TaiLieu { get; set; }
        public string MaNguoiSoHuu { get; set; }
        public string TinhTrang { get; set; } = "In Progress";
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }

        public DateTime NgayDuocThem { get; set; } = DateTime.Now;
        public int TiLeHT { get; set; } = 0;

        public NhiemVu(int MaNhiemVu, int MaDuAn, string TenNhiemVu, string MieuTa, byte[] TaiLieu, string MaNguoiSoHuu, string TinhTrang, DateTime NgayBatDau, DateTime NgayKetThuc, DateTime NgayDuocThem)
        {
            this.MaNhiemVu  = MaNhiemVu;
            this.MaNguoiSoHuu = MaNguoiSoHuu;
            this.MaDuAn = MaDuAn;
            this.TenNhiemVu = TenNhiemVu;
            this.TaiLieu = TaiLieu;
            this.MieuTa = MieuTa;
            this.TinhTrang = TinhTrang;
            this.NgayBatDau = NgayBatDau;
            this.NgayKetThuc = NgayKetThuc;
            this.NgayDuocThem = NgayDuocThem;
        }
        public NhiemVu(int MaNhiemVu, int TiLeHT)
        {
            this.MaNhiemVu = MaNhiemVu;
            this.TiLeHT = TiLeHT;
        }
        public NhiemVu(int MaNhiemVu)
        {
            this.MaNhiemVu = MaNhiemVu;
        }
        public NhiemVu(int MaNhiemVu, string tinhTrang)
        {
            this.MaNhiemVu = MaNhiemVu;
            this.TinhTrang = tinhTrang;
        }

        

    }
}
