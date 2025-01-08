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
    public class SanPhamController
    {
        // get data
        public static List<Giay> GetDataSanPham()
        {
            using (var db = setupConection.ConnectionFactory())
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<Giay>("EXEC GetDataSanPham").ToList();
            }
        }

        public static List<GiayView> GetDataSanPhamView()
        {
            using (var db = setupConection.ConnectionFactory())
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<GiayView>("EXEC GetDataSanPhamView").ToList();
            }
        }

        public static List<GiayView> SearchProduct(string query)
        {
            using (var db = setupConection.ConnectionFactory())
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<GiayView>(query).ToList();
            }
        }

        public static List<LoaiGiay> GetDataLoaiGiay()
        {
            using (var db = setupConection.ConnectionFactory())
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<LoaiGiay>("EXEC GetDataLoaiGiay").ToList();
            }
        }

        public static List<NhaCungCap> GetDataNhaCungCap()
        {
            using (var db = setupConection.ConnectionFactory())
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<NhaCungCap>("EXEC GetDataNhaCC").ToList();
            }
        }

        public static List<NhaSanXuat> GetDataNhaSanXuat()
        {
            using (var db = setupConection.ConnectionFactory())
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<NhaSanXuat>("EXEC GetDataNhaSanXuat").ToList();
            }
        }

        // Query Chức năng Loại giày
        public static bool ThemLoaiGiay(string _MaLoai, string _TenLoai, string _GhiChu)
        {
            if (checkInputLoaiGiay(_MaLoai, _TenLoai, _GhiChu))
            {
                int Insert_LoaiGiay = -1;
                using (var db = setupConection.ConnectionFactory())
                {
                    try
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        using (var transaction = db.BeginTransaction())
                        {
                            Insert_LoaiGiay = db.Execute("sp_InsLoaiGiay",
                                new
                                {
                                    MaLoai = _MaLoai,
                                    TenLoai = _TenLoai,
                                    GhiChu = _GhiChu
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
                if (Insert_LoaiGiay == 1) return true;
                else return false;
            }
            return false;
        }

        public static bool SuaLoaiGiay(string _MaLoai, string _TenLoai, string _GhiChu)
        {
            if (checkInputLoaiGiay(_MaLoai, _TenLoai, _GhiChu))
            {
                using (var db = setupConection.ConnectionFactory())
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    using (var transacsion = db.BeginTransaction())
                    {
                        int Edit_LoaiGiay = db.Execute("sp_UpdateLoaiGiay",
                                   new
                                   {
                                       MaLoai = _MaLoai,
                                       TenLoai = _TenLoai,
                                       GhiChu = _GhiChu
                                   },
                                   commandType: CommandType.StoredProcedure,
                                   transaction: transacsion);
                        transacsion.Commit();
                    }
                }
            }
            return true;
        }

        public static bool checkInputLoaiGiay(string _MaLoai, string _TenLoai, string _GhiChu)
        {
            string errMS = "";
            if (_MaLoai == "") { errMS = "Trống mã mã loại"; }
            if (_TenLoai == "") { errMS += "\nTrống tên loại"; }
            if (_GhiChu == "") { errMS += "\nTrống ghi chú"; }
            if (errMS != "")
            {
                MessageBox.Show(errMS, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool XoaLoaiGiay(string _MaLoai)
        {
            if (_MaLoai == "") return false;
            int Del_SP = -1;
            using (var db = setupConection.ConnectionFactory())
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    using (var transacsion = db.BeginTransaction())
                    {
                        Del_SP = db.Execute("sp_DelLoaiGiay",
                                   new
                                   {
                                       MaLoai = _MaLoai,
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
            if (Del_SP >= 1) return true;
            else return false;
        }

        // Chức năng nhà Sản xuất
        public static bool ThemNhaSX(string _MaNSX, string _TenNSX, string _QuocGia)
        {
            if (checkInputNSX(_MaNSX, _TenNSX, _QuocGia))
            {
                int Insert_NSX = -1;
                using (var db = setupConection.ConnectionFactory())
                {
                    try
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        using (var transaction = db.BeginTransaction())
                        {
                            Insert_NSX = db.Execute("sp_InsNhaSanXuat",
                               new
                               {
                                   MaNSX = _MaNSX,
                                   TenNSX = _TenNSX,
                                   QuocGia = _QuocGia
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
                if (Insert_NSX == 1) return true;
                else return false;
            }
            return false;
        }

        public static bool SuaSanNhaSX(string _MaNSX, string _TenNSX, string _QuocGia)
        {
            if (checkInputNSX(_MaNSX, _TenNSX, _QuocGia))
            {
                int Edit_NSX = -1;
                using (var db = setupConection.ConnectionFactory())
                {
                    try
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        using (var transacsion = db.BeginTransaction())
                        {
                            Edit_NSX = db.Execute("sp_UpdateNhaSanXuat",
                                       new
                                       {
                                           MaNSX = _MaNSX,
                                           TenNSX = _TenNSX,
                                           QuocGia = _QuocGia
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
                if (Edit_NSX == 1) return true;
                else return false;
            }
            return false;
        }

        public static bool checkInputNSX(string _MaNSX, string _TenNSX, string _QuocGia)
        {
            string errMS = "";
            if (_MaNSX == "") { errMS = "Trống nhà sản xuất"; }
            if (_TenNSX == "") { errMS += "\nTrống tên nhà sản xuất"; }
            if (_QuocGia == "") { errMS += "\nTrống quốc gia"; }
            if (errMS != "")
            {
                MessageBox.Show(errMS, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool XoaNhaSX(string _MaNSX)
        {
            if (_MaNSX == "") return false;
            int Del = -1;
            using (var db = setupConection.ConnectionFactory())
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    using (var transacsion = db.BeginTransaction())
                    {
                        Del = db.Execute("sp_DelNhaSanXuat",
                                   new
                                   {
                                       MaNSX = _MaNSX,
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

        //Chức năng nhà cung cấp
        public static bool ThemNhaCC(string _MaNhaCC, string _TenNhaCC, string _DiaChi, string _Sdt)
        {
            if (checkInputNCC(_MaNhaCC, _TenNhaCC, _DiaChi, _Sdt))
            {
                int Insert_NhaCC = -1;
                using (var db = setupConection.ConnectionFactory())
                {
                    try
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        using (var transaction = db.BeginTransaction())
                        {
                            Insert_NhaCC = db.Execute("sp_InsNhaCungCap",
                               new
                               {
                                   MaNCC = _MaNhaCC,
                                   TenNCC = _TenNhaCC,
                                   DiaChi = _DiaChi,
                                   Sdt = _Sdt
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
                if (Insert_NhaCC == 1) return true;
                else return false;
            }
            return false;
        }

        public static bool SuaSanNhaCC(string _MaNhaCC, string _TenNhaCC, string _DiaChi, string _Sdt)
        {
            if (checkInputNCC(_MaNhaCC, _TenNhaCC, _DiaChi, _Sdt))
            {
                int Edit_NhaCC = -1;
                using (var db = setupConection.ConnectionFactory())
                {
                    try
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        using (var transacsion = db.BeginTransaction())
                        {
                            Edit_NhaCC = db.Execute("sp_UpdateNhaCungCap",
                                       new
                                       {
                                           MaNCC = _MaNhaCC,
                                           TenNCC = _TenNhaCC,
                                           DiaChi = _DiaChi,
                                           Sdt = _Sdt
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
                if (Edit_NhaCC == 1) return true;
                else return false;
            }
            return false;
        }

        public static bool checkInputNCC(string _MaNhaCC, string _TenNhaCC, string _DiaChi, string _Sdt)
        {
            string errMS = "";
            if (_MaNhaCC == "") { errMS = "Trống mã nhà cung cấp"; }
            if (_TenNhaCC == "") { errMS += "\nTrống tên nhà cung cấp"; }
            if (_DiaChi == "") { errMS += "\nTrống địa chỉ"; }
            if (_Sdt == "") { errMS += "\nSai số điện thoại"; }
            if (errMS != "")
            {
                MessageBox.Show(errMS, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool XoaNhaCC(string _MaNhaCC)
        {
            if (_MaNhaCC == "") return false;
            int Del = -1;
            using (var db = setupConection.ConnectionFactory())
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    using (var transacsion = db.BeginTransaction())
                    {
                        Del = db.Execute("sp_DelNhaCungCap",
                                   new
                                   {
                                       MaNhaCC = _MaNhaCC,
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

        // query Chức năng sản phẩn
        public static bool ThemSanPham(string _MaGiay, string _TenGiay, string _ThongSoKT, double _GiaThanh, string _MaLoai, string _MaNSX, string _MaNCC)
        {
            if (checkInputSP(_MaGiay, _TenGiay, _ThongSoKT, _GiaThanh))
            {
                int Insert_SP = -1;
                using (var db = setupConection.ConnectionFactory())
                {
                    try
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        using (var transaction = db.BeginTransaction())
                        {
                            Insert_SP = db.Execute("sp_InsGiay",
                               new
                               {
                                   MaGiay = _MaGiay,
                                   TenGiay = _TenGiay,
                                   GiaThanh = _GiaThanh,
                                   MaLoai = _MaLoai,
                                   MaNSX = _MaNSX,
                                   MaNCC = _MaNCC,
                                   ThongSoKT = _ThongSoKT
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
                if (Insert_SP == 1) return true;
                else return false;
            }
            return false;
        }

        public static bool SuaSanPham(string _MaGiay, string _TenGiay, string _ThongSoKT, double _GiaThanh, string _MaLoai, string _MaNSX, string _MaNCC)
        {
            if (checkInputSP(_MaGiay, _TenGiay, _ThongSoKT, _GiaThanh))
            {
                int Edit_SP = -1;
                using (var db = setupConection.ConnectionFactory())
                {
                    try
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        using (var transacsion = db.BeginTransaction())
                        {
                            Edit_SP = db.Execute("sp_UpdateGiay",
                                       new
                                       {
                                           MaGiay = _MaGiay,
                                           TenGiay = _TenGiay,
                                           GiaThanh = _GiaThanh,
                                           MaLoai = _MaLoai,
                                           MaNSX = _MaNSX,
                                           MaNCC = _MaNCC,
                                           ThongSoKT = _ThongSoKT
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
                if (Edit_SP == 1) return true;
                else return false;
            }
            return false;
        }

        public static bool checkInputSP(string _MaGiay, string _TenGiay, string _ThongSoKT, double _GiaThanh)
        {
            string errMS = "";
            if (_MaGiay == "") { errMS = "Trống mã mã giày"; }
            if (_TenGiay == "") { errMS += "\nTrống tên giày"; }
            if (_ThongSoKT == "") { errMS += "\nTrống thông số kĩ thuật"; }
            if (_GiaThanh < 0) { errMS += "\nSai giá thành"; }
            if (errMS != "")
            {
                MessageBox.Show(errMS, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool XoaSanPham(string _MaGiay)
        {
            if (_MaGiay == "") return false;
            int Del_SP = -1;
            using (var db = setupConection.ConnectionFactory())
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    using (var transacsion = db.BeginTransaction())
                    {
                        Del_SP = db.Execute("sp_DelGiay",
                                   new
                                   {
                                       MaGay = _MaGiay,
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
            if (Del_SP >= 1) return true;
            else return false;
        }
    }
}