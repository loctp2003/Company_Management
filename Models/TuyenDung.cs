using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuAn.Models
{
    internal class TuyenDung
    {
        public string MaTD { get; set; }
        public string TenTD { get; set; }
        public string ViTri { get; set; }
        public string PhongBan { get; set; }
        public int MucLuongTu { get; set; }
        public int MucLuongDen { get; set; }
        public DateTime HanTuyen { get; set; }
        public string HinhThucLV { get; set; }
        public string NoiLV { get; set; }
        public TuyenDung()
        {

        }
        public TuyenDung(string maTD, string tenTD, string viTri, string phongBan, int mucLuongTu, int mucLuongDen, DateTime hanTuyen, string hinhThucLV, string noiLV)
        {
            MaTD = maTD;
            TenTD = tenTD;
            ViTri = viTri;
            PhongBan = phongBan;
            MucLuongTu = mucLuongTu;
            MucLuongDen = mucLuongDen;
            HanTuyen = hanTuyen;
            HinhThucLV = hinhThucLV;
            NoiLV = noiLV;
        }
    }
}
