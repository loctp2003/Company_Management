using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuAn.Models
{
    internal class Luong
    {
        public string MaNV { get; set; }
        public int LuongCoBan { get; set; }
        public int Thuong { get; set; }
        public int LuongNhan { get; set; }
        public Luong()
        {

        }
        public Luong(string maNV, int luongCoBan, int thuong, int luongNhan)
        {
            MaNV = maNV;
            LuongCoBan = luongCoBan;
            Thuong = thuong;
            LuongNhan = luongNhan;
        }
    }
}
