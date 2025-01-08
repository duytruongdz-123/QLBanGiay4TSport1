using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanGiay.Model
{
    public class PhieuNhap
    {
        public string MaPN { get; set; }
        public DateTime NgayNhap { get; set; }
        public string MaNV { get; set; }
        public string MaNCC { get; set; }

        public PhieuNhap()
        {
            MaPN = "";
            NgayNhap = DateTime.Now;
            MaNV = "";
            MaNCC = "";
        }

        public PhieuNhap(string _MaPN, DateTime _NgayNhap, string _MaNV, string _MaNCC)
        {
            MaPN = _MaPN;
            NgayNhap = _NgayNhap;
            MaNV = _MaNV;
            MaNCC = _MaNCC;
        }
    }

    public class PhieuNhapView
    {
        public string MaPN { get; set; }
        public DateTime NgayNhap { get; set; }
        public string HoTen { get; set; }
        public string TenNCC { get; set; }
    }
}