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

// cậu ms làm à ừ
namespace QuanLyBanGiay.View.VKhachHang
{
    public partial class frmThaoTacKH : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int _state;

        public frmThaoTacKH(string _MaKH, string _TenKhacHang, string _DiaChi, string _Sdt, int state)
        {
            InitializeComponent();
            txtID.Text = _MaKH;
            txtHoTen.Text = _TenKhacHang;
            txtDiaChi.Text = _DiaChi;
            _state = state;
            txtSDT.Text = _Sdt;
            if (state == 1)
            {
                txtID.Enabled = false;
            }
        }

        private void bbiSave_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        
        {
            if (KhachHangController.checkInputKH(txtID.Text.Trim(), txtHoTen.Text.Trim(), txtDiaChi.Text.Trim(), txtSDT.Text.Trim()))
            {
                if (_state == 0)
                {
                    //xử lý Trùng mã
                    List<KhachHang> listKH;
                    using (var db = setupConection.ConnectionFactory())
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        listKH = db.Query<KhachHang>("SELECT MaKH FROM dbo.KhachHang").ToList();
                    }

                    foreach (KhachHang kh in listKH)
                    {
                        if (kh.MaKH == txtID.Text.Trim())
                        {

                            MessageBox.Show("Trùng mã khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        
                    }
                    if (KhachHangController.ThemKH(txtID.Text.Trim(), txtHoTen.Text.Trim(), txtDiaChi.Text.Trim(), txtSDT.Text.Trim()))
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
                    if (KhachHangController.SuaKH(txtID.Text.Trim(), txtHoTen.Text.Trim(), txtDiaChi.Text.Trim(), txtSDT.Text.Trim()))
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

        private void bbiSaveAndClose_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bbiSave_ItemClick_1(sender, e);
            this.Close();
        }

        private void bbiReset_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtID.Text = "";
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }

        private void bbiClose_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}