using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanGiay.Model
{
    public class TaiKhoan
    {
        //TenTaiKhoan
        //MatKhau
        public string TenTaiKhoan { get; set; }

        public string MatKhau { get; set; }

        public TaiKhoan()
        {
            TenTaiKhoan = "";
            MatKhau = "";
        }
        public TaiKhoan(string _TenTaiKhoan, string _MatKhau)
        {
            TenTaiKhoan = _TenTaiKhoan;
            MatKhau = _MatKhau; 
        }
    }
    public class TaiKhoanView
    {
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
    }
}