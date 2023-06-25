using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyDuAn.Models
{
    public class NhanVien
    {
        public string MaNV { get; set; } 
        public string HoTen { get; set; } 
        public string ViTri { get; set; }  // Chuc Vu
        public string QueQuan { get; set; }
        public string DanToc { get; set; } 
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SDT { get; set; } 
        public string MaPB { get; set; }  // Phong Ban
        public string TinhTrang { get; set; }
        public string Email { get; set; } 
        public string HonNhan { get; set; } 
        public DateTime NgayVao { get; set; } 
        public string DiaChi { get; set; } 
        public byte[] Anh { get; set; }

        public NhanVien() { }

        public NhanVien(string maNV, string hoTen, string viTri, string queQuan, string danToc, string gioiTinh, DateTime ngaySinh, string sDT, string maPB, string tinhTrang, string email, string honNhan, DateTime ngayVao, string diaChi, byte[] anh)
        {
            MaNV = maNV;
            HoTen = hoTen;
            ViTri = viTri;
            QueQuan = queQuan;
            DanToc = danToc;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            SDT = sDT;
            MaPB = maPB;
            TinhTrang = tinhTrang;
            Email = email;
            HonNhan = honNhan;
            NgayVao = ngayVao;
            DiaChi = diaChi;
            Anh = anh;
        }
    }

}
