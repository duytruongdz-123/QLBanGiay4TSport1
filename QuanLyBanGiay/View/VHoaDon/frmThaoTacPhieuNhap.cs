using Dapper;
using DevExpress.XtraEditors.Controls;
using QuanLyBanGiay.Controller;
using QuanLyBanGiay.Helper;
using QuanLyBanGiay.Model;
using QuanLyBanGiay.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanGiay.View.VHoaDon
{
    public partial class frmThaoTacPhieuNhap : DevExpress.XtraBars.Ribbon.RibbonForm
    { 
        private int _state;

        private List<NhaCungCap> listNhaCungCap = new List<NhaCungCap>();
        private List<NhanVien> listNhanVien = new List<NhanVien>();

        public frmThaoTacPhieuNhap(string _MaPN, DateTime _NgayNhap, string _MaNV, string _MaNCC, int state)
        {  
            InitializeComponent();
            txtMaPN.Text = _MaPN;
            dtNgayNhap.Value = _NgayNhap;
            _state = state;

            if (_state == 1)
            {
                txtMaPN.Enabled = false;
            }

            //Mã Nhân vien
             
            ///
            using (var db = setupConection.ConnectionFactory())
            { 
                if (db.State == ConnectionState.Closed)
                    db.Open();
                listNhanVien = db.Query<NhanVien>("SELECT MaNV,HoTen FROM dbo.NhanVien").ToList();
                for (int i = 0; i < listNhanVien.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = listNhanVien[i].HoTen.ToString();
                    item.Value = listNhanVien[i].MaNV.ToString();
                    cbTenNV.Items.Add(item);
                    if (_MaNV == listNhanVien[i].HoTen)
                    {
                        cbTenNV.SelectedIndex = i;
                    }
                }
                 
                //Nhà cung cấp
                 
                listNhaCungCap = db.Query<NhaCungCap>("SELECT MaNCC,TenNCC FROM dbo.NhaCungCap").ToList();
                for (int i = 0; i < listNhaCungCap.Count; i++)
                { 
                    ComboboxItem item = new ComboboxItem();
                    item.Text = listNhaCungCap[i].TenNCC.ToString();
                    item.Value = listNhaCungCap[i].MaNCC.ToString();
                    cbTenNCC.Items.Add(item);
                    if (_MaNCC == listNhaCungCap[i].TenNCC)
                    { 
                        cbTenNCC.SelectedIndex = i;
                    }
                }
            }
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        { 
            if (HoaDonController.checkInputPhieuNhap(txtMaPN.Text.Trim(), dtNgayNhap.Value))
            { 
                string maNV = listNhanVien.Find(x => x.HoTen == cbTenNV.Text).MaNV; 
                string maNhaCC = listNhaCungCap.Find(x => x.TenNCC == cbTenNCC.Text).MaNCC;
                if (_state == 0)
                {
                    //xử lý Trùng mã
                    List<PhieuNhap> listPhieuNhap; 
                    using (var db = setupConection.ConnectionFactory())
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        listPhieuNhap = db.Query<PhieuNhap>("SELECT MaPN FROM dbo.PhieuNhap").ToList();
                    }
                    foreach (PhieuNhap pn in listPhieuNhap)
                    {
                        if (pn.MaPN == txtMaPN.Text.Trim()) 
                        {
                            MessageBox.Show("Trùng mã giày", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    if (HoaDonController.ThemPhieuNhap(txtMaPN.Text.Trim(), dtNgayNhap.Value, maNV, maNhaCC))
                    {  
                        MessageBox.Show("Thành Công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    } 
                    else
                    { 
                        MessageBox.Show("Lỗi", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    }
                }
                else if (_state == 1)
                { 
                    if (HoaDonController.SuaPhieuNhap(txtMaPN.Text.Trim(), dtNgayNhap.Value, maNV, maNhaCC)) 
                    { 
                        MessageBox.Show("Thành Công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    } 
                    else 
                    { 
                        MessageBox.Show("Lỗi", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {    
            this.Close();  
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {  
            bbiSave_ItemClick(sender, e);
            this.Close();
        }
    }
}