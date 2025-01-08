using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanGiay.Model
{
    public class CTPhieuXuat
    {
        public string MaPX { get; set; }
        public string MaGiay { get; set; }
        public string TenGiay { get; set; }
        public int SoLuong { get; set; }
        public long ChiPhiPhatSinh { get; set; }
        public long DonGia { get; set; }

        public CTPhieuXuat()
        {
            MaPX = "";
            MaGiay = "";
            SoLuong = 0;
            DonGia = 0;
        }

        public CTPhieuXuat(string _MaPX, string _MaGiay, int _SoLuong, long _DonGia, long _ChiPhiPhatSinh)
        {
            MaPX = _MaPX;
            MaGiay = _MaGiay;
            SoLuong = _SoLuong;
            DonGia = _DonGia;
            ChiPhiPhatSinh = _ChiPhiPhatSinh;
        }
    }
}