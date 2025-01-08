using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanGiay.Model
{
    public class Giay
    {
        public string MaGiay { get; set; }
        public string TenGiay { get; set; }
        public string ThongSoKT { get; set; }
        public long GiaThanh { get; set; }
        public string MaLoai { get; set; }
        public string MaSize { get; set; }
        public string TenSize { get; set; }
        public string TenLoai { get; set; }
        public string MaNSX { get; set; }
        public string TenNSX { get; set; }
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }

        public Giay()
        {
            MaGiay = "";
            TenGiay = "";
            ThongSoKT = "";
            GiaThanh = 0;
            MaLoai = "";
            TenLoai = "";
            MaNCC = "";
            TenNCC = "";
            MaNSX = "";
            TenNSX = "";
            MaSize = "";
            TenSize = "";
        }

        public Giay(string _MaGiay, string _TenGiay, string _ThongSoKT, long _GiaThanh, string _MaLoai, string _MaNSX, string _MaNCC)
        {
            MaGiay = _MaGiay;
            TenGiay = _TenGiay;
            ThongSoKT = _ThongSoKT;
            GiaThanh = _GiaThanh;
            MaLoai = _MaLoai;
            MaNSX = _MaNSX;
            MaNCC = _MaNCC;
        }
    }

    public class GiayView
    {
        public string MaGiay { get; set; }
        public string TenGiay { get; set; }
        public string ThongSoKT { get; set; }
        public long GiaThanh { get; set; }
        public string TenSize { get; set; }
        public string TenLoai { get; set; }
        public string TenNSX { get; set; }
        public string TenNCC { get; set; }
    }
}