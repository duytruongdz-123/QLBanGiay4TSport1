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

namespace QuanLyBanGiay.View.VHoaDon
{
    public partial class frmMainPhieuXuat : Form
    {
        public frmMainPhieuXuat()
        { 
            InitializeComponent();
        }

        private List<PhieuXuatView> lstPhieuXuat;
        private string IDmember;
        private int CurCl, CurR;

        private string MaPX;
        private DateTime NgayXuat;
        private string HoTen;
        private string TenKhachHang;
        private int i;

        public void Hienthi()
        { 
            lstPhieuXuat = HoaDonController.GetDataPhieuXuat();
            DataTable dt = ViewHelper.ToDataTable<PhieuXuatView>(lstPhieuXuat);
            dtgPhieuXuat.DataSource = dt;
            dtgPhieuXuat.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dt.Columns["MaPX"].ColumnName = "Mã Phiếu Xuấtp";
            dt.Columns["NgayXuat"].ColumnName = "Ngày Xuất";
            dt.Columns["HoTen"].ColumnName = "Ten Nhân Viên";
            dt.Columns["TenKhachHang"].ColumnName = "Ten Khach Hang";

            int i = 0;
            foreach (DataGridViewColumn col in dtgPhieuXuat.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                dtgPhieuXuat.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                i++;
            }
            try { dtgPhieuXuat.CurrentCell = dtgPhieuXuat[CurCl, CurR]; } catch { }
            dtgPhieuXuat.Refresh();
        }

        private void frmMainPhieuXuat_Load(object sender, EventArgs e)
        { 
            Hienthi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        { 
            frmThaoTacPhieuXuat frmThem = new frmThaoTacPhieuXuat(null, DateTime.Now, null, null, 0);
            frmThem.ShowDialog();
            Hienthi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        { 
            frmThaoTacPhieuXuat frmSua = new frmThaoTacPhieuXuat(MaPX, NgayXuat, HoTen, TenKhachHang, 1);
            frmSua.ShowDialog();
            Hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        { 
            if (IDmember != null)
            {
                if (IDmember == "PXDEL")
                {
                    MessageBox.Show("Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("Bạn có muốn xóa dữ liệu đã chọn", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (HoaDonController.XoaPhieuXuat(IDmember))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); Hienthi(); IDmember = null;
                    }
                    else
                    {
                        MessageBox.Show("Xóa Không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            { 
                MessageBox.Show("Vui lòng chọn 1 phiếu xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            IDmember = dtgPhieuXuat.CurrentRow.Cells[0].Value.ToString();
            CurCl = dtgPhieuXuat.CurrentCell.ColumnIndex;
            CurR = dtgPhieuXuat.CurrentCell.RowIndex;
            i = CurR;
            // show data
            txtMaPX.Text = MaPX = lstPhieuXuat[i].MaPX;
            dateNgayXuat.Value = NgayXuat = lstPhieuXuat[i].NgayXuat;
            txtTenNV.Text = HoTen = lstPhieuXuat[i].HoTen;
            txtTenKH.Text = TenKhachHang = lstPhieuXuat[i].TenKhachHang;
        }
    }
}