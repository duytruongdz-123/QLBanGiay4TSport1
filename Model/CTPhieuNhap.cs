using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanGiay.Model
{
    public class CTPhieuNhap
    {
        public string MaPN { get; set; }
        public string MaGiay { get; set; }
        public string TenGiay { get; set; }
        public int SoLuong { get; set; }
        public long DonGia { get; set; }
        public long ChiPhiPhatSinh { get; set; }
        /*
         Đơn giá bằng (Giá Thành + chi phí phát sinh)/ số lượng
             */
        public CTPhieuNhap()
        {
            MaPN = "";
            MaGiay = "";
            SoLuong = 0;
            DonGia = 0;
            ChiPhiPhatSinh = 0;
        }

        public CTPhieuNhap(string _MaPN, string _MaGiay, int _SoLuong, long _DonGia, long _ChiPhiPhatSinh)
        {
            MaPN = _MaPN;
            MaGiay = _MaGiay;
            SoLuong = _SoLuong;
            DonGia = _DonGia;
        }
    }
}