using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuAn.Models
{
    internal class DanhGia
    {
        public int MaDanhGia { get; set; }
        public int MaNhiemVu { get; set; }
        public string LoiDanhGia { get; set; }
        public DateTime NgayDanhGia { get; set; }
        public string MaNguoiDG { get; set; }
        public int SoSao { get; set; }
        public DanhGia(int maDanhGia, int maNhiemVu, string maNguoiDG, string loiDanhGia, DateTime ngayDanhGia, int soSao)
        {
            MaDanhGia = maDanhGia;
            MaNhiemVu = maNhiemVu;
            MaNguoiDG = maNguoiDG; 
            LoiDanhGia = loiDanhGia;
            NgayDanhGia = ngayDanhGia;
            SoSao = soSao;
        }

        public DanhGia(int maDanhGia)
        {
            MaDanhGia = maDanhGia;
        }
        public DanhGia(int maDanhGia, int maNhiemVu)
        {
            MaNhiemVu = maNhiemVu;
        }




    }
}
