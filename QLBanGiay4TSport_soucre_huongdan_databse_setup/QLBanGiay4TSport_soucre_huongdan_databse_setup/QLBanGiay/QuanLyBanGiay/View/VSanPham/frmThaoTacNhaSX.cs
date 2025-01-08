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
using QuanLyBanGiay.Controller;
using QuanLyBanGiay.Model;
using QuanLyBanGiay.Helper;
using Dapper;

namespace QuanLyBanGiay.View.VSanPham
{
    public partial class frmThaoTacNhaSX : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int state;

        public frmThaoTacNhaSX(string _MaNSX, string _TenNSX, string _QuocGia, int _state)
        {
            InitializeComponent();
            state = _state;
            txtMaNSX.Text = _MaNSX;
            txtTenNSX.Text = _TenNSX;
            txtQuocGia.Text = _QuocGia;
            if (state == 1)
            {
                txtMaNSX.Enabled = false;
            }
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (SanPhamController.checkInputNSX(txtMaNSX.Text.Trim(), txtTenNSX.Text.Trim(), txtQuocGia.Text.Trim()))
            {
                if (state == 1)
                {
                    //xử lý Trùng mã
                    List<NhaSanXuat> listMaNhaSanXuat;
                    using (var db = setupConection.ConnectionFactory())
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        listMaNhaSanXuat = db.Query<NhaSanXuat>("SELECT MaNSX FROM dbo.NhaSanXuat").ToList();
                    }
                    foreach (NhaSanXuat sp in listMaNhaSanXuat)
                    {
                        if (sp.MaNSX == txtMaNSX.Text.Trim())
                        {
                            MessageBox.Show("Trùng mã Nha San Xuat", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    if (SanPhamController.ThemNhaSX(txtMaNSX.Text.Trim(), txtTenNSX.Text.Trim(), txtQuocGia.Text.Trim()))
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
                    if (SanPhamController.SuaSanNhaSX(txtMaNSX.Text.Trim(), txtTenNSX.Text.Trim(), txtQuocGia.Text.Trim()))
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
            txtMaNSX.Text = "";
            txtTenNSX.Text = "";
            txtQuocGia.Text = "";
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmThaoTacNhaSX_Load(object sender, EventArgs e)
        {
        }
    }
}