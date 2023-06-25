using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuAn.Models
{
    internal class ChamCong
    {
        public string MaNV { get; set; }
        public DateTime? CheckIn { get; set; } = null;
        public DateTime? CheckOut { get; set; } = null;
        public string LyDo { get; set; }
        public string ChuThich { get; set; }
        public DateTime Ngay { get; set; }
        public ChamCong()
        {

        }
        public ChamCong(string maNV, DateTime? checkIn, DateTime? checkOut, string lyDo, string chuThich, DateTime ngay)
        {
            MaNV = maNV;
            CheckIn = checkIn;
            CheckOut = checkOut;
            LyDo = lyDo;
            ChuThich = chuThich;
            Ngay = ngay;
        }
    }
}
