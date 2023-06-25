using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuAn.Models
{
    internal class NhanVienThamGiaDA
    {
        public int MaDA { get; set; }
        public string MaNV { get; set; }

        public NhanVienThamGiaDA(int maDA, string maNV)
        {
            MaDA = maDA;
            MaNV = maNV;
        } 
        public NhanVienThamGiaDA(int maDA)
        {
            MaDA = maDA;
        }
    }
}
