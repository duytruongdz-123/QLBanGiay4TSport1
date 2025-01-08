using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanGiay.Model
{
    public class NhaSanXuat
    {
        public string MaNSX { get; set; }
        public string TenNSX { get; set; }
        public string QuocGia { get; set; }

        public NhaSanXuat()
        {
            MaNSX = "";
            TenNSX = "";
            QuocGia = "VietNam";
        }

        public NhaSanXuat(string _MaNSX, string _TenNSX, string _QuocGia)
        {
            MaNSX = _MaNSX;
            TenNSX = _TenNSX;
            QuocGia = _QuocGia;
        }
    }
}