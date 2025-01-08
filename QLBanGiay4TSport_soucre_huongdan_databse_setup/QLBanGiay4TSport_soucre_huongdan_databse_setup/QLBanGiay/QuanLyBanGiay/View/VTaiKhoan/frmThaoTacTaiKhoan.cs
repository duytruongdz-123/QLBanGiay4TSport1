using Dapper;
using QuanLyBanGiay.Controller;
using QuanLyBanGiay.Helper;
using QuanLyBanGiay.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanGiay.View.VTaiKhoan
{
    
    public partial class frmThaoTacTaiKhoan : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int state;
        public frmThaoTacTaiKhoan(string _TenTaiKhoan, string _MatKhau, int _state)
        {
            InitializeComponent();
            txtTenTK.Text = _TenTaiKhoan;
            txtMK.Text = _MatKhau;
            state = _state;
            if (state == 1)
            {
                txtTenTK.Enabled = false;
            }
        }

        private void frmThaoTacTaiKhoan_Load(object sender, EventArgs e)
        {
            
        }

        private void txtMaNhaCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TaiKhoanController.checkInputTaiKhoan(txtTenTK.Text.Trim(), txtMK.Text.Trim()))
            {
                if (state == 0)
                {
                    //xử lý Trùng mã
                    List<TaiKhoan> lisTaiKhoan;
                    using (var db = setupConection.ConnectionFactory())
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        lisTaiKhoan = db.Query<TaiKhoan>("SELECT TenTaiKhoan FROM dbo.TaiKhoan").ToList();
                    }
                    foreach (TaiKhoan tk in lisTaiKhoan)
                    {
                        if (tk.TenTaiKhoan == txtTenTK.Text.Trim())
                        {
                            MessageBox.Show("Trùng tên tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                        if (TaiKhoanController.ThemTaiKhoan(txtTenTK.Text.Trim(), txtMK.Text.Trim()))
                        {
                            MessageBox.Show("Thành Công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else

                        {
                            MessageBox.Show("Lỗi", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (state == 1)
                    {
                        if (TaiKhoanController.SuaTaiKhoan(txtTenTK.Text.Trim(), txtMK.Text.Trim()))
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
            txtTenTK.Text = "";
            txtMK.Text = "";
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
