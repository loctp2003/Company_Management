

namespace QuanLyDuAn.Models
{
    public class PhongBan
    {
        public string MaPB{ get; set; }
        public string TenPB { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public NhanVien TruongPhong { get; set; }
    }
}