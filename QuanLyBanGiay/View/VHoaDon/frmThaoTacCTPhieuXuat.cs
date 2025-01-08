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
    public partial class frmThaoTacCTPhieuXuat : DevExpress.XtraBars.Ribbon.RibbonForm
    {  
        private int _state;
        private List<Giay> listSanPham = new List<Giay>();
        private List<PhieuXuat> listPhieuXuat = new List<PhieuXuat>();

        public frmThaoTacCTPhieuXuat(string _MaPX, string _MaGiay, int _SoLuong, long _DonGia, long _ChiPhiPhatSinh, int state)
        { 
            InitializeComponent();
            txtChiPhiPhatSinh.Text = _ChiPhiPhatSinh.ToString();
            txtSoLuong.Text = _SoLuong.ToString();
            txtDonGia.Text = _DonGia.ToString();
            _state = state;
            if (_state == 1)
            {
                cbMaPX.Enabled = false;
                cbMaGiay.Enabled = false;
            }
            cbMaPX.Text = _MaPX;
            //Mã Nhân vien

            ///
            using (var db = setupConection.ConnectionFactory())
            { 
                if (db.State == ConnectionState.Closed)
                    db.Open();
                listSanPham = db.Query<Giay>("SELECT * FROM dbo.Giay").ToList();
                for (int i = 0; i < listSanPham.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = listSanPham[i].TenGiay.ToString();
                    item.Value = listSanPham[i].MaGiay.ToString();
                    cbMaGiay.Items.Add(item);
                    if (_MaGiay == listSanPham[i].MaGiay)
                    { 
                        cbMaGiay.SelectedIndex = i;
                    }
                }
                listPhieuXuat = db.Query<PhieuXuat>(" SELECT * FROM dbo.PhieuXuat").ToList();
                for (int i = 0; i < listSanPham.Count; i++)
                { 
                    ComboboxItem item = new ComboboxItem();
                    item.Text = listPhieuXuat[i].MaPX.ToString();
                    item.Value = listPhieuXuat[i].MaPX.ToString();
                    cbMaPX.Items.Add(item);
                }
            }
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        { 
            if (HoaDonController.checkInput(txtSoLuong.Text, txtChiPhiPhatSinh.Text))
            { 
                string maGiay = listSanPham.Find(x => x.TenGiay == cbMaGiay.Text).MaGiay;
                long dongia = listSanPham.Find(x => x.MaGiay == maGiay).GiaThanh + long.Parse(txtChiPhiPhatSinh.Text);
                 
                if (_state == 0)
                { 
                    if (HoaDonController.ThemCTPhieuXuat(cbMaPX.Text.Trim(), maGiay, txtSoLuong.Text, dongia.ToString(), txtChiPhiPhatSinh.Text))
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
                    if (HoaDonController.SuaCTPhieuXuat(cbMaPX.Text.Trim(), maGiay, txtSoLuong.Text, dongia.ToString(), txtChiPhiPhatSinh.Text))
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
    }
}