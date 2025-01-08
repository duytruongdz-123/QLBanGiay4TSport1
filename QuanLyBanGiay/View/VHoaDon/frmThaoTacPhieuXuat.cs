using Dapper;
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
    public partial class frmThaoTacPhieuXuat : DevExpress.XtraBars.Ribbon.RibbonForm
    {   
        private int _state;
        private List<KhachHang> listKhacHang = new List<KhachHang>();
        private List<NhanVien> listNhanVien = new List<NhanVien>();
         
        public frmThaoTacPhieuXuat(string _MaPX, DateTime _NgayXuat, string _TenNV, string _TenKH, int state)
        {  
            InitializeComponent();
            txtMaPX.Text = _MaPX;
            _state = state;
            if (_state == 1)
            {
                txtMaPX.Enabled = false;
            }
            //Xử lý nhân viên,Khách hàng
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
                    cbTenNhanVien.Items.Add(item);
                    if (_TenNV == listNhanVien[i].HoTen)
                    {
                        cbTenNhanVien.SelectedIndex = i;
                    }
                }
                listKhacHang = db.Query<KhachHang>("SELECT MaKH,TenKhachHang FROM dbo.KhachHang").ToList();
                for (int i = 0; i < listKhacHang.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = listKhacHang[i].TenKhachHang.ToString();
                    item.Value = listKhacHang[i].MaKH.ToString();
                    cbTenKhacHang.Items.Add(item);
                    if (_TenKH == listKhacHang[i].TenKhachHang)
                    {
                        cbTenKhacHang.SelectedIndex = i;
                    }
                }
            }
        }
         
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {  
            if (HoaDonController.checkInputPhieuXuat(txtMaPX.Text.Trim(), dtNgayXuat.Value))
            {
                string maNV = listNhanVien.Find(x => x.HoTen == cbTenNhanVien.Text).MaNV;
                string maKH = listKhacHang.Find(x => x.TenKhachHang == cbTenKhacHang.Text).MaKH;

                if (_state == 0)
                {
                    //xử lý Trùng mã
                    List<PhieuXuat> listPX;
                    using (var db = setupConection.ConnectionFactory())
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        listPX = db.Query<PhieuXuat>("SELECT MaGiay FROM dbo.Giay").ToList();
                    }
                    foreach (PhieuXuat px in listPX)
                    {
                        if (px.MaPX == txtMaPX.Text.Trim())
                        {
                            MessageBox.Show("Trùng mã phiếu xuất", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    if (HoaDonController.ThemPhieuXuat(txtMaPX.Text.Trim(), dtNgayXuat.Value, maNV, maKH))
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
                    if (HoaDonController.SuaPhieuXuat(txtMaPX.Text.Trim(), dtNgayXuat.Value, maNV, maKH))
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
         
        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {   
            bbiSave_ItemClick(sender, e);
            this.Close();
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        { 
            this.Close();
        }

        private void frmThaoTacPhieuXuat_Load(object sender, EventArgs e)
        {
        }
    }
}