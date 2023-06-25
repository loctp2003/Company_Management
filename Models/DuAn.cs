using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuAn.Models
{
    internal class DuAn
    {
        public int MaDA { get; set; }
        public string TenDuAn { get; set; }
        public string MieuTa { get; set; }
        public string TinhTrang { get; set; }
        public string MaNguoiSoHuu { get; set; }
        public byte[] TaiLieu { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public DateTime NgayDuocThem { get; set; } = DateTime.Now;
        public int TiLeHT { get; set; } = 0;

        public DuAn(int MaDA, string TenDuAn, string MieuTa, string TinhTrang, string MaNguoiSoHuu, byte[] TaiLieu, DateTime NgayBatDau, DateTime NgayKetThuc, DateTime NgayDuocThem)
        {
            this.MaDA = MaDA;
            this.TenDuAn = TenDuAn;
            this.MieuTa = MieuTa;
            this.TaiLieu = TaiLieu;
            this.MaNguoiSoHuu = MaNguoiSoHuu;
            this.TinhTrang = TinhTrang;
            this.NgayBatDau = NgayBatDau;
            this.NgayKetThuc = NgayKetThuc;
            this.NgayDuocThem = NgayDuocThem;
        }
        public DuAn(int MaDA, int TiLeHT)
        {
            this.MaDA = MaDA;
            this.TiLeHT = TiLeHT;
        }
        public DuAn(int MaDA, string TinhTrang)
        {
            this.MaDA = MaDA;
            this.TinhTrang = TinhTrang;
        }
        public DuAn(int MaDA)
        {
            this.MaDA = MaDA;
        }


    }
}
