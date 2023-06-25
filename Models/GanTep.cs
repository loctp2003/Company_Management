using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuAn.Models
{
    internal class GanTep
    {
        public int MaGanTep { get; set; }
        public string TenTep { get; set; }
        public string LoaiGan { get; set; } = "Image";
        public int MaDA { get; set; }

        public string MieuTa { get; set; }
        public byte[] Tep { get; set; }
        public DateTime NgayDuocThem { get; set; } = DateTime.Now;
    }
}
