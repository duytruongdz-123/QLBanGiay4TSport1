using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanGiay.Model
{
    public class NhaCungCap
    {
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }

        public NhaCungCap()
        {
            MaNCC = "";
            TenNCC = "";
            DiaChi = "";
            Sdt = "";
        }

        public NhaCungCap(string _MaNCC, string _TenNCC, string _DiaChi, string _Sdt)
        {
            MaNCC = _MaNCC;
            TenNCC = _TenNCC;
            DiaChi = _DiaChi;
            Sdt = _Sdt;
        }
    }

}