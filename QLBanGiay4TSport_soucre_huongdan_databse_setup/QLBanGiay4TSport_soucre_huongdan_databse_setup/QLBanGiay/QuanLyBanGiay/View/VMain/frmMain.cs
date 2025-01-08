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
using QuanLyBanGiay.View;
using QuanLyBanGiay.Helper;
using QuanLyBanGiay.Model;

namespace QuanLyBanGiay.View.VMain
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private bool ExitsForm(Form form)
        {
            foreach (var child in MdiChildren)
            {
                if (child.Name == form.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var frmGioiThieu = new VMain.GioiThieu();
            if (ExitsForm(frmGioiThieu)) return;
            frmGioiThieu.MdiParent = this;
            frmGioiThieu.Show();
            VisibleAll(false);
        }

        private void btnSanPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formSP = new VSanPham.frmMainSanPham();
            if (ExitsForm(formSP)) return;
            formSP.MdiParent = this;
            formSP.Show();
        }

        private void btnLoaiGiay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formLoaiGiay = new VSanPham.frmMainLoaiGiay();
            if (ExitsForm(formLoaiGiay)) return;
            formLoaiGiay.MdiParent = this;
            formLoaiGiay.Show();
        }

        private void barNhaSanXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formNhaSX = new VSanPham.frmMainNhaSX();
            if (ExitsForm(formNhaSX)) return;
            formNhaSX.MdiParent = this;
            formNhaSX.Show();
        }

        private void barNhaCungCap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formNhaCC = new VSanPham.frmMainNhaCC();
            if (ExitsForm(formNhaCC)) return;
            formNhaCC.MdiParent = this;
            formNhaCC.Show();
        }

        private void btnPhieuNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formPhieuNhap = new VHoaDon.frnMainPhieuNhap();
            if (ExitsForm(formPhieuNhap)) return;
            formPhieuNhap.MdiParent = this;
            formPhieuNhap.Show();
        }

        private void btnChiTietPhieuXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formChiTietPhieuXuat = new VHoaDon.frmMainCTPhieuXuat();
            if (ExitsForm(formChiTietPhieuXuat)) return;
            formChiTietPhieuXuat.MdiParent = this;
            formChiTietPhieuXuat.Show();
        }

        private void btnChiTietPhieuNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formChiTietPhieuNhap = new VHoaDon.frmMainCTPhieuNhap();
            if (ExitsForm(formChiTietPhieuNhap)) return;
            formChiTietPhieuNhap.MdiParent = this;
            formChiTietPhieuNhap.Show();
        }

        private void btnPhieuXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formPhieuXuat = new VHoaDon.frmMainPhieuXuat();
            if (ExitsForm(formPhieuXuat)) return;
            formPhieuXuat.MdiParent = this;
            formPhieuXuat.Show();
        }

        private void btnKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formKhachHang = new VKhachHang.frmKhachHang();
            if (ExitsForm(formKhachHang)) return;
            formKhachHang.MdiParent = this;
            formKhachHang.Show();
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formNhanVien = new VNhanVien.frmMainNhanVien();
            if (ExitsForm(formNhanVien)) return;
            formNhanVien.MdiParent = this;
            formNhanVien.Show();
        }

        private void btnThongKe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void btnHuongDan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void btnDieuKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void btnBanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formTaiKhoan = new VTaiKhoan.frmMainTaiKhoan();
            if (ExitsForm(formTaiKhoan)) return;
            formTaiKhoan.MdiParent = this;
            formTaiKhoan.Show();
        }

        private void btnSQL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDataBase load = new LoadDataBase();
            load.ShowDialog();
        }

        public void VisibleAll(bool val)
        {
            menuQuanLySanPham.Visible = val;
            mnuQuanLyHoaDon.Visible = val;
            menuQLKH.Visible = val;
            mnuQuanLyNhanVien.Visible = val;
            mnuThongKe.Visible = val;
            btnLogout.Enabled = val;
        }

        private TaiKhoan nd;

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            nd = new TaiKhoan();
            frmLogin login = new frmLogin();
            login.ShowDialog();
            nd = SingletonData.Getlates().nguoidung;
            if (nd != null)
            {
                btnLogin.Enabled = false;
                VisibleAll(true);
            }
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            nd = null;
            btnLogin.Enabled = true;
            VisibleAll(false);
            MessageBox.Show("Đăng Xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
    }
}