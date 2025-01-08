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

namespace QuanLyBanGiay.View.VSanPham
{
    public partial class frmMainSanPham : Form
    {
        public frmMainSanPham()
        {
            InitializeComponent();
            cbKeyTimKiem.Items.AddRange(
                       new ComboboxItem[] {
                           new ComboboxItem { Text = "Mã giày", Value = "MaGiay"},
                           new ComboboxItem { Text = "Tên giày", Value = "TenGiay"},
                           new ComboboxItem { Text = "Thông số", Value = "ThongSoKT"},
                           new ComboboxItem { Text = "Giá thành", Value = "GiaThanh"},
                           new ComboboxItem { Text = "Size", Value = "TenSize"},
                           new ComboboxItem { Text = "Loại", Value = "TenLoai"},
                           new ComboboxItem { Text = "Nhà sản xuất", Value = "TenNSX"},
                           new ComboboxItem { Text = "Nhà cung cấp", Value = "TenNCC"}
                     });
            cbKeyTimKiem.SelectedIndex = 0;
        }

        private List<GiayView> lstSanPham;
        private string IDmember;
        private int CurCl, CurR;
        private string MaGiay;
        private string TenGiay;
        private string ThongSoKT;
        private long GiaThanh;
        private string TenSize;
        private string TenLoai;
        private string TenNSX;
        private string TenNCC;

        public void Hienthi()
        {
            lstSanPham = SanPhamController.GetDataSanPhamView();
            DataTable dt = ViewHelper.ToDataTable<GiayView>(lstSanPham);
            dtgSanPham.DataSource = dt;
            dtgSanPham.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dt.Columns["MaGiay"].ColumnName = "Mã Giày";
            dt.Columns["TenGiay"].ColumnName = "Tên Giày";
            dt.Columns["ThongSoKT"].ColumnName = "Mô Tả";
            dt.Columns["GiaThanh"].ColumnName = "Giá thành";
            dt.Columns["TenLoai"].ColumnName = "Tên loại";
            dt.Columns["TenSize"].ColumnName = "Size";
            dt.Columns["TenNSX"].ColumnName = "Tên NSX";
            dt.Columns["TenNCC"].ColumnName = "Tên NCC";

            int i = 0;
            foreach (DataGridViewColumn col in dtgSanPham.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                dtgSanPham.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                i++;
            }
            try { dtgSanPham.CurrentCell = dtgSanPham[CurCl, CurR]; } catch { }
            dtgSanPham.Refresh();
        }

        private int i;

        private void dtgSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDmember = dtgSanPham.CurrentRow.Cells[0].Value.ToString();
            CurCl = dtgSanPham.CurrentCell.ColumnIndex;
            CurR = dtgSanPham.CurrentCell.RowIndex;
            i = CurR;
            // show data
            txtMaGiay.Text = MaGiay = lstSanPham[i].MaGiay;
            txtTenGiay.Text = TenGiay = lstSanPham[i].TenGiay;
            txtThongSoKT.Text = ThongSoKT = lstSanPham[i].ThongSoKT;
            txtTenLoai.Text = TenLoai = lstSanPham[i].TenLoai;
            txtGiaThanh.Text = lstSanPham[i].GiaThanh.ToString(); GiaThanh = lstSanPham[i].GiaThanh;
            txtSize.Text = TenSize = lstSanPham[i].TenSize;
            txtTenNhaCC.Text = TenNCC = lstSanPham[i].TenNCC;
            txtTenNhaSX.Text = TenNSX = lstSanPham[i].TenNSX;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThaoTacSanPham frmThem = new frmThaoTacSanPham(null, null, null, null, 0, null, null, null, 0);
            frmThem.ShowDialog();
            Hienthi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmThaoTacSanPham frmThem = new frmThaoTacSanPham(MaGiay, TenGiay, ThongSoKT, TenSize, GiaThanh, TenLoai, TenNSX, TenNCC, 1);
            frmThem.ShowDialog(); Hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (IDmember != null)
            {
                if (IDmember == "SPDEL")
                {
                    MessageBox.Show("Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("Bạn có muốn xóa dữ liệu đã chọn", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (SanPhamController.XoaSanPham(IDmember))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); Hienthi();
                        IDmember = null;
                    }
                    else
                    {
                        MessageBox.Show("Xóa Không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string exc = "EXEC SearchProduct ";
            switch (cbKeyTimKiem.SelectedIndex)
            {
                case 0:
                    exc = exc + string.Format("@MaGiay = '{0}',@TenGiay = N'',@ThongSoKT = N'',@GiaThanh = 0, @TenSize = '', @TenLoai = '',@TenNSX = '',@TenNCC = '', @case = {1}", txtTimKiem.Text.Trim(), 0);
                    break;

                case 1:
                    exc = exc + string.Format("@MaGiay = '',@TenGiay = N'{0}',@ThongSoKT = N'',@GiaThanh = 0, @TenSize = '', @TenLoai = '',@TenNSX = '',@TenNCC = '', @case = {1}", txtTimKiem.Text.Trim(), 1);
                    break;

                case 2:
                    exc = exc + string.Format("@MaGiay = '',@TenGiay = N'',@ThongSoKT = N'{0}',@GiaThanh = 0, @TenSize = '', @TenLoai = '',@TenNSX = '',@TenNCC = '', @case = {1}", txtTimKiem.Text.Trim(), 2);
                    break;

                case 3:
                    long gia = 0;
                    if (!long.TryParse(txtTimKiem.Text.Trim(), out gia))
                    {
                        MessageBox.Show("Lỗi input");
                        gia = 0;
                    }
                    exc = exc + string.Format("@MaGiay = '',@TenGiay = N'',@ThongSoKT = N'',@GiaThanh = {0}, @TenSize = '', @TenLoai = '',@TenNSX = '',@TenNCC = '', @case = {1}", gia, 3);
                    break;

                case 4:
                    exc = exc + string.Format("@MaGiay = '',@TenGiay = N'',@ThongSoKT = N'',@GiaThanh = 0, @TenSize = '{0}', @TenLoai = '',@TenNSX = '',@TenNCC = '', @case = {1}", txtTimKiem.Text.Trim(), 4);
                    break;

                case 5:
                    exc = exc + string.Format("@MaGiay = '',@TenGiay = N'',@ThongSoKT = N'',@GiaThanh = 0, @TenSize = '', @TenLoai = '{0}',@TenNSX = '',@TenNCC = '', @case = {1}", txtTimKiem.Text.Trim(), 5);
                    break;

                case 6:
                    exc = exc + string.Format("@MaGiay = '',@TenGiay = N'',@ThongSoKT = N'',@GiaThanh = 0, @TenSize = '', @TenLoai = '',@TenNSX = '{0}',@TenNCC = '', @case = {1}", txtTimKiem.Text.Trim(), 6);
                    break;

                case 7:
                    exc = exc + string.Format("@MaGiay = '',@TenGiay = N'',@ThongSoKT = N'',@GiaThanh = 0, @TenSize = '', @TenLoai = '',@TenNSX = '',@TenNCC = '{0}', @case = {1}", txtTimKiem.Text.Trim(), 7);
                    break;
            }
            HienthiFind(SanPhamController.SearchProduct(exc));
        }

        private void frmMainSanPham_Load(object sender, EventArgs e)
        {
            Hienthi();
        }

        public void HienthiFind(List<GiayView> TK)
        {
            lstSanPham = SanPhamController.GetDataSanPhamView();
            DataTable dt = ViewHelper.ToDataTable<GiayView>(TK);
            dtgSanPham.DataSource = dt;
            dtgSanPham.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dt.Columns["MaGiay"].ColumnName = "Mã Giày";
            dt.Columns["TenGiay"].ColumnName = "Tên Giày";
            dt.Columns["ThongSoKT"].ColumnName = "Mô Tả";
            dt.Columns["GiaThanh"].ColumnName = "Giá thành";
            dt.Columns["TenLoai"].ColumnName = "Tên loại";
            dt.Columns["TenSize"].ColumnName = "Size";
            dt.Columns["TenNSX"].ColumnName = "Tên NSX";
            dt.Columns["TenNCC"].ColumnName = "Tên NCC";

            int i = 0;
            foreach (DataGridViewColumn col in dtgSanPham.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                dtgSanPham.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                i++;
            }
            try { dtgSanPham.CurrentCell = dtgSanPham[CurCl, CurR]; } catch { }
            dtgSanPham.Refresh();
        }
    }
}