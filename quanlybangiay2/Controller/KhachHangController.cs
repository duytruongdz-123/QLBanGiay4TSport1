using Dapper;
using QuanLyBanGiay.Helper;
using QuanLyBanGiay.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanGiay.Controller
{
    public class KhachHangController
    {
        public static List<KhachHang> GetDataKhachHang()
        {
            using (var db = setupConection.ConnectionFactory())
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<KhachHang>("SELECT * FROM dbo.KhachHang").ToList();
            }
        }

        //
        public static bool ThemKH(string _MaKhachHang, string _TenKhachHang, string _DiaChi, string _Sdt)
        {
            if (checkInputKH(_MaKhachHang, _TenKhachHang, _DiaChi, _Sdt))
            {
                using (var db = setupConection.ConnectionFactory())
                {
                    try
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        using (var transaction = db.BeginTransaction())
                        {
                            int Insert_KH = db.Execute("sp_InsKhacHang",
                                new
                                {
                                    MaKH = _MaKhachHang,
                                    TenKhachHang = _TenKhachHang,
                                    DiaChi = _DiaChi,
                                    Sdt = _Sdt
                                },
                                commandType: CommandType.StoredProcedure,
                                transaction: transaction);
                            transaction.Commit();
                        }
                    }
                    catch
                    {
                    }
                }
                return true;
            }
            return false;
        }

        public static bool SuaKH(string _MaKhachHang, string _TenKhachHang, string _DiaChi, string _Sdt)
        {
            if (checkInputKH(_MaKhachHang, _TenKhachHang, _DiaChi, _Sdt))
            {
                int Edit_KH = -1;
                using (var db = setupConection.ConnectionFactory())
                {
                    try
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        using (var transacsion = db.BeginTransaction())
                        {
                            Edit_KH = db.Execute("sp_UpdateKhachHang",
                                       new
                                       {
                                           MaKH = _MaKhachHang,
                                           TenKhachHang = _TenKhachHang,
                                           DiaChi = _DiaChi,
                                           Sdt = _Sdt,
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
                if (Edit_KH == 1) return true;
                else return false;
            }
            return false;
        }

        public static bool XoaKH(string _MaKhachHang)
        {
            if (_MaKhachHang == "") return false;
            int Del = -1;
            using (var db = setupConection.ConnectionFactory())
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    using (var transacsion = db.BeginTransaction())
                    {
                        Del = db.Execute("sp_DelKhachHang",
                                   new
                                   {
                                       MaKH = _MaKhachHang,
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

        public static bool checkInputKH(string _MaKhachHang, string _TenKhachHang, string _DiaChi, string _Sdt)
        {
            string errMS = "";
            if (_MaKhachHang == "") { errMS = "Trống mã khách hàng"; }
            if (_TenKhachHang == "") { errMS += "\nTrống tên khách hàng"; }
            if (_DiaChi == "") { errMS += "\nTrống Địa Chỉ"; }
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