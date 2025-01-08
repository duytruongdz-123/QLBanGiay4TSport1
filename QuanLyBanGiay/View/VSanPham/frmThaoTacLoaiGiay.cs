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
    public partial class frmThaoTacLoaiGiay : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int state;

        public frmThaoTacLoaiGiay(string _MaLoai, string _TenLoai, string _GhiChu, int _state)
        {
            InitializeComponent();
            state = _state;
            if (_state == 1)
            {
                txtMaLoai.Enabled = false;
            }
            txtMaLoai.Text = _MaLoai;
            txtTenLoai.Text = _TenLoai;
            txtGhiChu.Text = _GhiChu;
        }

        private void frmThaoTacLoaiGiay_Load(object sender, EventArgs e)
        {
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (SanPhamController.checkInputLoaiGiay(txtMaLoai.Text.Trim(), txtTenLoai.Text.Trim(), txtGhiChu.Text.Trim()))
            {
                if (state == 1)
                {
                    List<LoaiGiay> listMaLoaiGiay;
                    using (var db = setupConection.ConnectionFactory())
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        listMaLoaiGiay = db.Query<LoaiGiay>("SELECT MaLoai FROM dbo.LoaiGiay").ToList();
                    }
                    foreach (LoaiGiay sp in listMaLoaiGiay)
                    {
                        if (sp.MaLoai == txtMaLoai.Text.Trim())
                        {
                            MessageBox.Show("Trùng mã Ma Loai giày", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    if (SanPhamController.ThemLoaiGiay(txtMaLoai.Text.Trim(), txtTenLoai.Text.Trim(), txtGhiChu.Text.Trim()))
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
                    if (SanPhamController.SuaLoaiGiay(txtMaLoai.Text.Trim(), txtTenLoai.Text.Trim(), txtGhiChu.Text.Trim()))
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
            txtMaLoai.Text = "";
            txtTenLoai.Text = "";
            txtGhiChu.Text = "";
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}