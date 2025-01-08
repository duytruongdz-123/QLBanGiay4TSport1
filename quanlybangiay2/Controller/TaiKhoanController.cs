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
    public class TaiKhoanController
    {
        public static List<TaiKhoan> GetDataTaiKhoan()
        {
            using (var db = setupConection.ConnectionFactory())
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<TaiKhoan>("SELECT * FROM dbo.TaiKhoan").ToList();
            }
        }

        /*
         1. Query
         2. NonQuery
        */

        public static bool ThemTaiKhoan(string _TenTaiKhoan, string _MatKhau)
        {
            using (var db = setupConection.ConnectionFactory())//Kết nối cơ sở dữ liệu
            {
                try// Thử xem nó có kết nối đc không
                {
                    if (db.State == ConnectionState.Closed)//Nếu đang đóng
                        db.Open();// THì mở ra
                    using (var transaction = db.BeginTransaction())
                    {
                        int Insert_TaiKhoan = db.Execute("Insert_TaiKhoan",
                            new
                            {
                                TenTaiKhoan = _TenTaiKhoan,
                                MatKhau = _MatKhau,
                            },
                            commandType: CommandType.StoredProcedure,
                            transaction: transaction);
                        transaction.Commit();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false;
                }
            }
            return true;
        }
        public static bool checkInputTaiKhoan(string _TenTaiKhoan, string _MatKhau)
        {
            string errMS = "";
            if (_TenTaiKhoan == "") { errMS = "Trống tên tài khoản"; }

            if (_MatKhau =="" ) { errMS = "Trống mật khẩu"; }
            if (errMS != "")
            {
                MessageBox.Show(errMS, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool SuaTaiKhoan(string _TenTaiKhoan, string _MatKhau)
        {
            if (checkInputTaiKhoan(_TenTaiKhoan, _MatKhau))
            {
                using (var db = setupConection.ConnectionFactory())
                {
                    try
                    {
                        if (db.State == ConnectionState.Closed)
                        {
                            db.Open();
                        }
                        using (var transaction = db.BeginTransaction())
                        {
                            int Edit_TK = db.Execute("sp_UpdateTaiKhoan",
                                new
                                {
                                    TenTaiKhoan = _TenTaiKhoan,
                                    MatKhau = _MatKhau 
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
        public static bool XoaTK(string _TenTaiKhoan)
        {
            if (_TenTaiKhoan == "") return false;
            int Del_TK = -1;
            using (var db = setupConection.ConnectionFactory())
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    using (var transacsion = db.BeginTransaction())
                    {
                        Del_TK = db.Execute("sp_DelTaiKhoan",
                                   new
                                   {
                                       TenTaiKhoan = _TenTaiKhoan,
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
            if (Del_TK == 1) return true;
            else return false;
        }

    }
}