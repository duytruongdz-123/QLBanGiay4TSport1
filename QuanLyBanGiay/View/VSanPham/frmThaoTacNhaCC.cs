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
    public partial class frmThaoTacNhaCC : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int state;

        public frmThaoTacNhaCC(string _MaNCC, string _TenNCC, string _DiaChi, string _Sdt, int _state)
        {
            InitializeComponent();
            state = _state;
            txtMaNhaCC.Text = _MaNCC;
            txtTenNhaCC.Text = _TenNCC;
            txtDiaChi.Text = _DiaChi;
            txtSDT.Text = _Sdt;
            if (state == 1)
            {
                txtMaNhaCC.Enabled = false;
            }
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (SanPhamController.checkInputNCC(txtMaNhaCC.Text.Trim(), txtTenNhaCC.Text.Trim(), txtDiaChi.Text.Trim(), txtSDT.Text.Trim()))
            {
                if (state == 1)
                {
                    //xử lý Trùng mã
                    List<NhaCungCap> listMaNhaCungCap;
                    using (var db = setupConection.ConnectionFactory())
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        listMaNhaCungCap = db.Query<NhaCungCap>("SELECT MaNCC FROM dbo.NhaCungCap").ToList();
                    }
                    foreach (NhaCungCap sp in listMaNhaCungCap)
                    {
                        if (sp.MaNCC == txtMaNhaCC.Text.Trim())
                        {
                            MessageBox.Show("Trùng mã Nha cung cấp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    if (SanPhamController.ThemNhaCC(txtMaNhaCC.Text.Trim(), txtTenNhaCC.Text.Trim(), txtDiaChi.Text.Trim(), txtSDT.Text.Trim()))
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
                    if (SanPhamController.ThemNhaCC(txtMaNhaCC.Text.Trim(), txtTenNhaCC.Text.Trim(), txtDiaChi.Text.Trim(), txtSDT.Text.Trim()))
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
            txtMaNhaCC.Text = "";
            txtTenNhaCC.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmThaoTacNhaCC_Load(object sender, EventArgs e)
        {
        }
    }
}