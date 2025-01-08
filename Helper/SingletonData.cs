using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanGiay.Model;

namespace QuanLyBanGiay.Helper
{
    internal class SingletonData
    {
        private static SingletonData _instance = null;

        private SingletonData()
        {
        }

        public static SingletonData Getlates()
        {
            if (_instance == null)
                _instance = new SingletonData();
            return _instance;
        }

        ///////////////
        public TaiKhoan nguoidung;
    }
}