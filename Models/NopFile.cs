using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuAn.Dao
{
    internal class NopFile
    {
        public int MaNopFile { get; set; }
        public int MaNhiemVuNho { get; set; }
        public string MaNguoiSoHuu { get; set; }
        public byte[] TaiLieu { get; set; }
        public string Filter { get; set; }
        public string TenFile { get; set; }
        public NopFile(int maNopFile, int maNhiemVuNho, string maNguoiSoHuu, byte[] taiLieu, string filter, string tenFile)
        {
            MaNopFile = maNopFile;
            MaNhiemVuNho = maNhiemVuNho;
            MaNguoiSoHuu = maNguoiSoHuu;
            TaiLieu = taiLieu;
            Filter = filter;
            TenFile = tenFile;
        }
        public NopFile(int maNhiemVuNho)
        {
            MaNhiemVuNho = maNhiemVuNho;
        }
    }
}
