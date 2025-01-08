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
    public partial class frnMainPhieuNhap : Form
    {
        public frnMainPhieuNhap()
        {
            InitializeComponent();
            cbKeyTimKiem.Items.AddRange(
                       new ComboboxItem[] {
                           new ComboboxItem { Text = "Mã Phiếu Nhập", Value = "MaPN"},
                           new ComboboxItem { Text = "Ngiày nhập", Value = "NgayNhap"},
                           new ComboboxItem { Text = "Tên Nhân Viên", Value = "HoTen"},
                           new ComboboxItem { Text = "Tên Nhà cung cấp", Value = "TenNCC"},
                     });
            cbKeyTimKiem.SelectedIndex = 0;
            dateFomat.SetMyCustomFormat(dateEND);
            dateFomat.SetMyCustomFormat(dateSearch);
            dateFomat.SetMyCustomFormat(dateNgayNhap);
            dateFomat.SetMyCustomFormat(dateStart);
        }

        private List<PhieuNhapView> lstPhieuNhap;
        private string IDmember;
        private int CurCl, CurR;
        private string MaPN;
        private DateTime NgayNhap;
        private string HoTen;
        private string TenNhaCC;
        private int i;

        public void Hienthi()
        {
            lstPhieuNhap = HoaDonController.GetDataPhieuNhap();
            DataTable dt = ViewHelper.ToDataTable<PhieuNhapView>(lstPhieuNhap);
            dtgPhieuNhap.DataSource = dt;
            dtgPhieuNhap.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dt.Columns["MaPN"].ColumnName = "Mã Phiếu Nhập";
            dt.Columns["NgayNhap"].ColumnName = "Ngày Nhập";
            dt.Columns["HoTen"].ColumnName = "Ten Nhân Viên";
            dt.Columns["TenNCC"].ColumnName = "Tên NCC";
            int i = 0;
            foreach (DataGridViewColumn col in dtgPhieuNhap.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                dtgPhieuNhap.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                i++;
            }
            try { dtgPhieuNhap.CurrentCell = dtgPhieuNhap[CurCl, CurR]; } catch { }
            dtgPhieuNhap.Refresh();
        }

        public void HienthiFind(List<PhieuNhapView> lstPhieuNhap)
        {
            DataTable dt = ViewHelper.ToDataTable<PhieuNhapView>(lstPhieuNhap);
            dtgPhieuNhap.DataSource = dt;
            dtgPhieuNhap.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dt.Columns["MaPN"].ColumnName = "Mã Phiếu Nhập";
            dt.Columns["NgayNhap"].ColumnName = "Ngày Nhập";
            dt.Columns["HoTen"].ColumnName = "Ten Nhân Viên";
            dt.Columns["TenNCC"].ColumnName = "Tên NCC";
            int i = 0;
            foreach (DataGridViewColumn col in dtgPhieuNhap.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                dtgPhieuNhap.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                i++;
            }
            try { dtgPhieuNhap.CurrentCell = dtgPhieuNhap[CurCl, CurR]; } catch { }
            dtgPhieuNhap.Refresh();
        }

        private void frmMainPhieuNhap_Load(object sender, EventArgs e)
        {
            Hienthi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThaoTacPhieuNhap frmThem = new frmThaoTacPhieuNhap(null, DateTime.Now, null, null, 0);
            frmThem.ShowDialog();
            Hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (IDmember != null)
            {
                if (IDmember == "PNDEL")
                {
                    MessageBox.Show("Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("Bạn có muốn xóa dữ liệu đã chọn", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (HoaDonController.XoaPhieuNhap(IDmember))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); Hienthi(); IDmember = null;
                    }
                    else
                    {
                        MessageBox.Show("Xóa Không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 phiếu nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDmember = dtgPhieuNhap.CurrentRow.Cells[0].Value.ToString();
            CurCl = dtgPhieuNhap.CurrentCell.ColumnIndex;
            CurR = dtgPhieuNhap.CurrentCell.RowIndex;
            i = CurR;
            // show data
            txtPN.Text = MaPN = lstPhieuNhap[i].MaPN;
            txtTenNCC.Text = TenNhaCC = lstPhieuNhap[i].TenNCC;
            txtTenNV.Text = HoTen = lstPhieuNhap[i].HoTen;
            dateNgayNhap.Value = NgayNhap = lstPhieuNhap[i].NgayNhap;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string exc = "EXEC TimKiemPhieuNhap ";
            switch (cbKeyTimKiem.SelectedIndex)
            {
                case 0:
                    exc = exc + string.Format("@MaPN = '{0}',@NgayNhap = '',@HoTen = N'', @TenNCC = N'', @case = 0", txtTimKiem.Text.Trim());
                    break;

                case 2:
                    exc = exc + string.Format("@MaPN = '',@NgayNhap = '',@HoTen = N'{0}', @TenNCC = N'', @case = 2", txtTimKiem.Text.Trim(), 2);
                    break;

                case 3:
                    exc = exc + string.Format("@MaPN = '',@NgayNhap = '',@HoTen = N'', @TenNCC = N'{0}', @case = 3", txtTimKiem.Text.Trim());
                    break;
            }
            HienthiFind(HoaDonController.TimKiem(exc));
        }

        private void cbKeyTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKeyTimKiem.SelectedIndex == 1)
            {
                txtTimKiem.Visible = false;
                dateSearch.Visible = true;
            }
            else
            {
                dateSearch.Visible = false;
                txtTimKiem.Visible = true;
            }
        }

        private void dateSearch_ValueChanged(object sender, EventArgs e)
        {
            string exc = string.Format("EXEC dbo.TimKiemPhieuNhap @MaPN = '',@NgayNhap = '{0}',@HoTen = N'', @TenNCC = N'', @case = 1", dateSearch.Value.ToString("yyyy/MM/dd"));

            HienthiFind(HoaDonController.TimKiem(exc));
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string exc = string.Format("EXEC dbo.LocPhieuNhap @StartDate = '{0}', @EndDate = '{1}' ", dateStart.Value.ToString("yyyy/MM/dd"), dateEND.Value.ToString("yyyy/MM/dd"));

            HienthiFind(HoaDonController.TimKiem(exc));
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmThaoTacPhieuNhap frmThem = new frmThaoTacPhieuNhap(MaPN, NgayNhap, HoTen, TenNhaCC, 1);
            frmThem.ShowDialog();
            Hienthi();
        }
    }
}