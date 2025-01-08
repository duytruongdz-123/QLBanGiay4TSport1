using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanGiay.Model
{
    public class KhachHang
    {
        public string MaKH { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }

        public KhachHang()
        {
            MaKH = "";
            TenKhachHang = "";
            DiaChi = "";
            Sdt = "";
        }

        public KhachHang(string _MaKH, string _TenKhacHang, string _DiaChi, string _Sdt)
        {
            MaKH = _MaKH;
            TenKhachHang = _TenKhacHang;
            DiaChi = _DiaChi;
            Sdt = _Sdt;
        }
    }
    public class KhachHangView
    {
        public string MaKH { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }

    }
}