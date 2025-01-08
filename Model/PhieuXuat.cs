using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanGiay.Model
{
    public class PhieuXuat
    {
        public string MaPX { get; set; }
        public DateTime NgayXuat { get; set; }
        public string MaNV { get; set; }
        public string MaKhachHang { get; set; }

        public PhieuXuat()
        {
            MaPX = "";
            NgayXuat = DateTime.Now;
            MaNV = "";
            MaKhachHang = "";
        }

        public PhieuXuat(string _MaPX, DateTime _NgayXuat, string _MaNV, string _MaKhachHang)
        {
            MaPX = _MaPX;
            NgayXuat = _NgayXuat;
            MaNV = _MaNV;
            MaKhachHang = _MaKhachHang;
        }
    }
    public class PhieuXuatView
    {
        public string MaPX { get; set; }
        public DateTime NgayXuat { get; set; }
        public string HoTen { get; set; }
        public string TenKhachHang { get; set; }

       
    }
}