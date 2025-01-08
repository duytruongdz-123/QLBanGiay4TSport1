using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanGiay.Model
{
    public class NhanVien
    {
        public string MaNV  { get; set; }
        public string HoTen  { get; set; }
        public DateTime NgaySinh  { get; set; }
        public string Sdt  { get; set; }

        public NhanVien()
        {  
            MaNV = "";
            HoTen = "";
            NgaySinh = DateTime.Parse("01/01/1997");
            Sdt = "0980000000";
        }

        public NhanVien(string _MaNV, string _HoTen, DateTime _NgaySinh, string _Sdt)
        { 
            MaNV = _MaNV;
            HoTen = _HoTen;
            NgaySinh = _NgaySinh;
            Sdt = _Sdt;
        }
    }
}