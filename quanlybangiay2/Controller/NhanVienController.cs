using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanGiay.Model;
using System.Data;
using System.Data.SqlClient;
using QuanLyBanGiay.Helper;
using Dapper;
using System.Windows.Forms;

namespace QuanLyBanGiay.Controller
{
    partial class NhanVienController
    {
        public static List<NhanVien> getAllDataNV()
        {
            using (var db = setupConection.ConnectionFactory())
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<NhanVien>("SELECT * FROM dbo.NhanVien").ToList();
            }
        }

        public static bool ThemNV(string _MaNV, string _HoTen, DateTime _NgaySinh, string _Sdt)
        {
            if (checkInputNV(_MaNV, _HoTen, _NgaySinh, _Sdt))
            {
                using (var db = setupConection.ConnectionFactory())
                {
                    try
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        using (var transaction = db.BeginTransaction())
                        {
                            int Insert_NV = db.Execute("sp_InsNhanVien",
                                new
                                {
                                    MaNV = _MaNV,
                                    HoTen = _HoTen,
                                    NgaySinh = _NgaySinh,
                                    Sdt = _Sdt
                                },
                                commandType: CommandType.StoredProcedure,
                                transaction: transaction);
                            transaction.Commit();
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return true;
            }
            return false;
        }

        public static bool SuaNV(string _MaNV, string _HoTen, DateTime _NgaySinh, string _Sdt)
        {
            if (checkInputNV(_MaNV, _HoTen, _NgaySinh, _Sdt))
            {
                using (var db = setupConection.ConnectionFactory())
                {
                    try
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        using (var transaction = db.BeginTransaction())
                        {
                            int Insert_NV = db.Execute("sp_UpdateNhanVien",
                                new
                                {
                                    MaNV = _MaNV,
                                    HoTen = _HoTen,
                                    NgaySinh = _NgaySinh,
                                    Sdt = _Sdt
                                },
                                commandType: CommandType.StoredProcedure,
                                transaction: transaction);
                            transaction.Commit();
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return true;
            }
            return false;
        }

        public static bool XoaNV(string _MaNhanVien)
        {
            if (_MaNhanVien == "") return false;
            int Del = -1;
            using (var db = setupConection.ConnectionFactory())
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    using (var transacsion = db.BeginTransaction())
                    {
                        Del = db.Execute("sp_DelNhanVien",
                                   new
                                   {
                                       MaNV = _MaNhanVien,
                                   },
                                   commandType: CommandType.StoredProcedure,
                                   transaction: transacsion);
                        transacsion.Commit();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false;
                }
            }
            if (Del >= 1) return true;
            else return false;
        }

        public static bool checkInputNV(string _MaNV, string _HoTen, DateTime _NgaySinh, string _Sdt)
        {
            string errMS = "";
            if (_MaNV == "") { errMS = "Trống mã nhân viên"; }
            if (_HoTen == "") { errMS += "\nTrống họ tên"; }
            if (_NgaySinh.Year > DateTime.Now.Year) { errMS += "\nLỗi ngày sinh"; }
            if (_Sdt.Length > 15 || _Sdt.Length == 0) { errMS += "\nLỗi số điện thoại"; }
            if (errMS != "")
            {
                MessageBox.Show(errMS, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}