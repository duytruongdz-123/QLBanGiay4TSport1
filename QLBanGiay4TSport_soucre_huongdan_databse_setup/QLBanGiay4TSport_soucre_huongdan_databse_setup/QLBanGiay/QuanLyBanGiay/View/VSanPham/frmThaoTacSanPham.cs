using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyBanGiay.Model;
using QuanLyBanGiay.Helper;
using Dapper;
using QuanLyBanGiay.Models;
using QuanLyBanGiay.Controller;

namespace QuanLyBanGiay.View.VSanPham
{
    public partial class frmThaoTacSanPham : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int _state;

        public frmThaoTacSanPham(
            string _MaGiay, string _TenGiay, string _ThongSoKT, string _TenSize,
            double _GiaThanh, string _MaLoai, string _MaNSX, string _MaNCC, int state
            )
        {
            InitializeComponent();
            txtMaGiay.Text = _MaGiay;
            txtTenGiay.Text = _TenGiay;
            txtThongSoKT.Text = _ThongSoKT;
            _state = state;
            txtGiaThanh.Text = _GiaThanh.ToString();
            if (state == 1)
            {
                txtMaGiay.Enabled = false;
            }
            #region

            //xử lý size
            ///
            using (var db = setupConection.ConnectionFactory())
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                List<SizeSP> listSize = db.Query<SizeSP>("SELECT * FROM dbo.Size").ToList();
                for (int i = 0; i < listSize.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = listSize[i].TenSize.ToString();
                    item.Value = listSize[i].MaSize.ToString();
                    cbSize.Items.Add(item);
                    if (_TenSize == listSize[i].TenSize)
                    {
                        cbSize.SelectedIndex = i;
                    }
                }
                listSize.Clear();
            }
            // Xử lý loại
            using (var db = setupConection.ConnectionFactory())
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                List<LoaiGiay> listLoai = db.Query<LoaiGiay>("SELECT MaLoai,TenLoai FROM dbo.LoaiGiay").ToList();
                for (int i = 0; i < listLoai.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = listLoai[i].TenLoai.ToString();
                    item.Value = listLoai[i].MaLoai.ToString();
                    cbLoai.Items.Add(item);
                    if (_MaLoai == listLoai[i].TenLoai)
                    {
                        cbLoai.SelectedIndex = i;
                    }
                }
            }
            //xử lý nhà cc
            using (var db = setupConection.ConnectionFactory())
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                List<NhaCungCap> listNhaCungCap = db.Query<NhaCungCap>("SELECT MaNCC,TenNCC FROM dbo.NhaCungCap").ToList();
                for (int i = 0; i < listNhaCungCap.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = listNhaCungCap[i].TenNCC.ToString();
                    item.Value = listNhaCungCap[i].MaNCC.ToString();
                    cbNhaCC.Items.Add(item);
                    if (_MaNCC == listNhaCungCap[i].TenNCC)
                    {
                        cbNhaCC.SelectedIndex = i;
                    }
                }
            }
            //Xử lý nhà sx
            using (var db = setupConection.ConnectionFactory())
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                List<NhaSanXuat> listNhaSanXuat = db.Query<NhaSanXuat>("SELECT MaNSX,TenNSX FROM dbo.NhaSanXuat").ToList();
                for (int i = 0; i < listNhaSanXuat.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = listNhaSanXuat[i].TenNSX.ToString();
                    item.Value = listNhaSanXuat[i].MaNSX.ToString();
                    cbNhaSX.Items.Add(item);
                    if (_MaNSX == listNhaSanXuat[i].TenNSX)
                    {
                        cbNhaSX.SelectedIndex = i;
                    }
                }
            }
            #endregion
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (SanPhamController.checkInputSP(txtMaGiay.Text.Trim(), txtTenGiay.Text.Trim(), txtThongSoKT.Text.Trim(), double.Parse(txtGiaThanh.Text)))
            {
                if (_state == 1)
                {
                    //xử lý Trùng mã
                    List<Giay> listMaSP;
                    using (var db = setupConection.ConnectionFactory())
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        listMaSP = db.Query<Giay>("SELECT MaGiay FROM dbo.Giay").ToList();
                    }
                    foreach (Giay sp in listMaSP)
                    {
                        if (sp.MaGiay == txtMaGiay.Text.Trim())
                        {
                            MessageBox.Show("Trùng mã giày", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    if (SanPhamController.ThemSanPham(txtMaGiay.Text.Trim(), txtTenGiay.Text.Trim(), txtThongSoKT.Text.Trim(), double.Parse(txtGiaThanh.Text), cbLoai.Text, cbNhaSX.Text, cbNhaCC.Text))
                    {
                        MessageBox.Show("Thành Công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (SanPhamController.SuaSanPham(txtMaGiay.Text.Trim(), txtTenGiay.Text.Trim(), txtThongSoKT.Text.Trim(), double.Parse(txtGiaThanh.Text), cbLoai.Text, cbNhaSX.Text, cbNhaCC.Text))
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
            txtMaGiay.Text = "";
            txtTenGiay.Text = "";
            txtThongSoKT.Text = "";
            txtGiaThanh.Text = "";
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmThaoTacSanPham_Load(object sender, EventArgs e)
        {
        }
    }
}