using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuAn.Models
{
    internal class UngVien
    {
        public string MaUV { get; set; }
        public string TenUV { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string DanhGia { get; set; }
        public TuyenDung MaTD { get; set; }
        public UngVien()
        {

        }
        public UngVien(string maUV, string tenUV, string sDT, string email, string danhGia, TuyenDung maTD)
        {
            MaUV = maUV;
            TenUV = tenUV;
            SDT = sDT;
            Email = email;
            DanhGia = danhGia;
            MaTD = maTD;
        }
    }
}
