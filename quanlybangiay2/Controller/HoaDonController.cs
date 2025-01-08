using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanGiay.Model;
using QuanLyBanGiay.Helper;
using System.Data;
using Dapper;
using System.Windows.Forms;

namespace QuanLyBanGiay.Controller
{
    public class HoaDonController
    {
        public static List<PhieuNhapView> GetDataPhieuNhap()
        { 
            using (var db = setupConection.ConnectionFactory())
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<PhieuNhapView>("EXEC dbo.GetDataPhieuNhap").ToList();
            }
        }

        public static List<PhieuNhapView> TimKiem(string Query)
        { 
            using (var db = setupConection.ConnectionFactory())
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<PhieuNhapView>(Query).ToList();
            }
        }

        public static List<PhieuXuatView> GetDataPhieuXuat()
        { 
            using (var db = setupConection.ConnectionFactory())
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<PhieuXuatView>("EXEC dbo.GetDataPhieuXuat").ToList();
            }
        }

        public static List<CTPhieuNhap> GetDataCTPhieuNhap()
        { 
            using (var db = setupConection.ConnectionFactory())
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<CTPhieuNhap>("EXEC dbo.GetDataCTPhieuNhap").ToList();
            }
        }

        public static List<CTPhieuXuat> GetDataCTPhieuXuat()
        { 
            using (var db = setupConection.ConnectionFactory())
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<CTPhieuXuat>("EXEC dbo.GetDataCTPhieuXuat").ToList();
            }
        }

        //chức năng phiêu nhập
        public static bool ThemPhieuNhap(string _MaPN, DateTime _NgayNhap, string _MaNV, string _MaNCC)
        { 
            if (checkInputPhieuNhap(_MaPN, _NgayNhap))
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
                            int Insert_PN = db.Execute("sp_InsPhieuNhap",
                                new
                                {
                                    MaPN = _MaPN,
                                    NgayNhap = _NgayNhap,
                                    MaNV = _MaNV,
                                    MaNCC = _MaNCC
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
            return false;
        }

        public static bool SuaPhieuNhap(string _MaPN, DateTime _NgayNhap, string _MaNV, string _MaNCC)
        { 
            if (checkInputPhieuNhap(_MaPN, _NgayNhap))
            {
                int Edit_PN = -1;
                using (var db = setupConection.ConnectionFactory())
                {
                    try
                    { 
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        using (var transacsion = db.BeginTransaction())
                        {
                            Edit_PN = db.Execute("sp_UpdatePhieuNhap",
                                  new
                                  {
                                      MaPN = _MaPN,
                                      NgayNhap = _NgayNhap,
                                      MaNV = _MaNV,
                                      MaNCC = _MaNCC
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
                if (Edit_PN == 1) return true;
                else return false;
            }
            return false;
        }

        public static bool XoaPhieuNhap(string _MaPN)
        { 
            if (_MaPN == "") return false;
            int Del_PN = -1;
            using (var db = setupConection.ConnectionFactory())
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    using (var transacsion = db.BeginTransaction())
                    { 
                        Del_PN = db.Execute("sp_DelPhieuNhap",
                                   new
                                   {
                                       MaPN = _MaPN,
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
            if (Del_PN >= 1) return true;
            else return false;
        }

        public static bool checkInputPhieuNhap(string _MaPN, DateTime _NgayNhap)
        { 
            string errMS = "";
            if (_MaPN == "") { errMS = "Trống mã phiếu nhập"; }
            if (_NgayNhap.Year > DateTime.Now.Year) { errMS += "\n lỗi ngày nhập"; }
            if (errMS != "")
            {
                MessageBox.Show(errMS, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return false;
            }
            return true;
        }

        public static bool ThemPhieuXuat(string _MaPX, DateTime _NgayXuat, string _MaNV, string _MaKH)
        { 
            if (checkInputPhieuXuat(_MaPX, _NgayXuat))
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
                            int Insert_PN = db.Execute("sp_InsPhieuXuat",
                                new
                                { 
                                    MaPX = _MaPX,
                                    NgayXuat = _NgayXuat,
                                    MaNV = _MaNV,
                                    MaKH = _MaKH
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

        public static bool SuaPhieuXuat(string _MaPX, DateTime _NgayXuat, string _MaNV, string _MaKH)
        { 
            if (checkInputPhieuXuat(_MaPX, _NgayXuat))
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
                            int Edit_PN = db.Execute("sp_UpdatePhieuXuat",
                                new
                                {
                                    MaPX = _MaPX,
                                    NgayXuat = _NgayXuat,
                                    MaNV = _MaNV,
                                    MaKH = _MaKH
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

        public static bool checkInputPhieuXuat(string _MaPX, DateTime _NgayXuat)
        {
            string errMS = "";
            if (_MaPX == "") { errMS = "Trống mã phiếu xuất"; }
            if (_NgayXuat > DateTime.Now) { errMS += "\n lỗi ngày nhập"; }
            if (errMS != "")
            {
                MessageBox.Show(errMS, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool XoaPhieuXuat(string _MaPX)
        { 
            if (_MaPX == "") return false;
            int Del_PX = -1;
            using (var db = setupConection.ConnectionFactory())
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    using (var transacsion = db.BeginTransaction())
                    {
                        Del_PX = db.Execute("sp_DelPhieuXuat",
                                   new
                                   {
                                       MaPX = _MaPX,
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
            if (Del_PX >= 1) return true;
            else return false;
        }

        public static bool ThemCTPhieuNhap(string _MaPN, string _MaGiay, string _SoLuong, string _DonGia, string _ChiPhiPhatSinh)
        { 
            if (checkInput(_SoLuong, _ChiPhiPhatSinh))
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
                            int Insert_CTPN = db.Execute("sp_InsCTPhieuNhap",
                                new
                                {
                                    MaPN = _MaPN,
                                    MaGiay = _MaGiay,
                                    SoLuong = _SoLuong,
                                    DonGia = _DonGia,
                                    ChiPhiPhatSinh = _ChiPhiPhatSinh
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
            return false;
        }

        public static bool SuaCTPhieuNhap(string _MaPN, string _MaGiay, string _SoLuong, string _DonGia, string _ChiPhiPhatSinh)
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
                        int Insert_CTPN = db.Execute("sp_UpdateCTPhieuNhap",
                            new
                            {
                                MaPN = _MaPN,
                                MaGiay = _MaGiay,
                                SoLuong = _SoLuong,
                                DonGia = _DonGia,
                                ChiPhiPhatSinh = _ChiPhiPhatSinh
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

        public static bool XoaCTPhieuNhap(string _MaPN, string _MaGiay)
        { 
            if (_MaPN == "") return false;
            int Del_CTPN = -1;
            using (var db = setupConection.ConnectionFactory())
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    using (var transacsion = db.BeginTransaction())
                    {
                        Del_CTPN = db.Execute("sp_DelCTPhieuNhap",
                                   new
                                   {
                                       MaPN = _MaPN,
                                       MaGiay = _MaGiay,
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
            if (Del_CTPN >= 1) return true;
            else return false;
        }

        //chức năng CT Phieu xuat
        public static bool ThemCTPhieuXuat(string _MaPX, string _MaGiay, string _SoLuong, string _DonGia, string _ChiPhiPhatSinh)
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
                        int Insert_CTPN = db.Execute("sp_InsCTPhieuXuat",
                            new
                            {
                                MaPX = _MaPX,
                                MaGiay = _MaGiay,
                                SoLuong = _SoLuong,
                                DonGia = _DonGia,
                                ChiPhiPhatSinh = _ChiPhiPhatSinh
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

        public static bool SuaCTPhieuXuat(string _MaPX, string _MaGiay, string _SoLuong, string _DonGia, string _ChiPhiPhatSinh)
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
                        int Insert_CTPN = db.Execute("sp_UpdateCTPhieuXuat",
                            new
                            {
                                MaPX = _MaPX,
                                MaGiay = _MaGiay,
                                SoLuong = _SoLuong,
                                DonGia = _DonGia,
                                ChiPhiPhatSinh = _ChiPhiPhatSinh
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

        public static bool checkInput(string _SoLuong, string _ChiPhiPhatSinh)
        {
            string errMS = "";
            int SoLuong;
            long DonGia;
            long CPPS;
            if (!int.TryParse(_SoLuong, out SoLuong)) { errMS = "loi số lượng"; }
            if (!long.TryParse(_ChiPhiPhatSinh, out CPPS)) { errMS = "loi chi phí"; }
            if (errMS != "")
            {
                MessageBox.Show(errMS, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } 
            return true;
        }

        public static bool XoaCTPhieuXuat(string _MaPX, string _MaGiay)
        {
            if (_MaPX == "") return false;
            int Del_CTPX = -1;
            using (var db = setupConection.ConnectionFactory())
            {
                try
                { 
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    using (var transacsion = db.BeginTransaction())
                    {
                        Del_CTPX = db.Execute("sp_DelCTPhieuXuat",
                                   new
                                   {
                                       MaPX = _MaPX,
                                       MaGiay = _MaGiay,
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
            if (Del_CTPX >= 1) return true;
            else return false;
        }
    }
}