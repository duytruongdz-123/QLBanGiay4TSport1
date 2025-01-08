using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanGiay.Model
{
    public class LoaiGiay
    {
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public string GhiChu { get; set; }

        public LoaiGiay()
        {
            MaLoai = "";
            TenLoai = "";
            GhiChu = "";
        }

        public LoaiGiay(string _MaLoai, string _TenLoai, string _GhiChu)
        {
            MaLoai = "";
            TenLoai = "";
            GhiChu = "";
        }
    }
}