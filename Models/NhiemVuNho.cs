using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuAn.Dao
{
    public class NhiemVuNho
    {
        public int MaNhiemVuNho { get; set; }
        public int MaNhiemVu { get; set; }
        public string TinhTrang { get; set; }
        public string Ten { get; set; }
        public int TiLeHT { get; set; }
        public NhiemVuNho(int maNhiemVuNho, int maNhiemVu, string tinhTrang, string ten)
        {
            MaNhiemVuNho = maNhiemVuNho;
            MaNhiemVu = maNhiemVu;
            TinhTrang = tinhTrang;
            Ten = ten;
        }
        public NhiemVuNho(int maNhiemVuNho)
        {
            MaNhiemVuNho = maNhiemVuNho;
        }
        public NhiemVuNho(int maNhiemVuNho, string tinhTrang)
        {
            MaNhiemVuNho = maNhiemVuNho;
            TinhTrang = tinhTrang;
        }
        public NhiemVuNho(int maNhiemVuNho, int tiLeHT)
        {
            MaNhiemVuNho = maNhiemVuNho;
            TiLeHT = tiLeHT;
        }
        
    }
}
