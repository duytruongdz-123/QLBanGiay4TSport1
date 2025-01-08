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
using QuanLyBanGiay.Controller;
using QuanLyBanGiay.Helper;

namespace QuanLyBanGiay.View.VNhanVien
{
    public partial class frmMainNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmMainNhanVien()
        {
            InitializeComponent();
        }

        private List<NhanVien> lstNhanVien;
        private string IDmember;
        private int CurCl, CurR, i;
        private string MaNV;
        private string HoTen;
        private DateTime NgaySinh;
        private string Sdt;

        public void Hienthi()
        {
            lstNhanVien = NhanVienController.getAllDataNV();
            DataTable dt = ViewHelper.ToDataTable<NhanVien>(lstNhanVien);
            dtgNhanVien.DataSource = dt;
            dtgNhanVien.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dt.Columns["MaNV"].ColumnName = "Mã NV";
            dt.Columns["HoTen"].ColumnName = "Tên NV";
            dt.Columns["NgaySinh"].ColumnName = "Ngày Sinh";
            dt.Columns["Sdt"].ColumnName = "Số điện thoại";

            int i = 0;
            foreach (DataGridViewColumn col in dtgNhanVien.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                dtgNhanVien.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                i++;
            }
            try { dtgNhanVien.CurrentCell = dtgNhanVien[CurCl, CurR]; } catch { }
            dtgNhanVien.Refresh();
        }

        private void frmMainNhanVien_Load(object sender, EventArgs e)
        {
            Hienthi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmThaoTacNV frmThem = new frmThaoTacNV(MaNV, HoTen, NgaySinh, Sdt, 1);
            frmThem.ShowDialog();
            Hienthi();
        }

        private void dtgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDmember = dtgNhanVien.CurrentRow.Cells[0].Value.ToString();
            CurCl = dtgNhanVien.CurrentCell.ColumnIndex;
            CurR = dtgNhanVien.CurrentCell.RowIndex;
            i = CurR;
            // show data
            txtID.Text = MaNV = lstNhanVien[i].MaNV;
            txtSDT.Text = Sdt = lstNhanVien[i].Sdt;
            txtTen.Text = HoTen = lstNhanVien[i].HoTen;
            dateNgaySinh.Value = NgaySinh = lstNhanVien[i].NgaySinh;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThaoTacNV frmThem = new frmThaoTacNV(null, null, DateTime.Now, null, 0);
            frmThem.ShowDialog();
            Hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (IDmember != null)
            {
                if (IDmember == "NVDEL")
                {
                    MessageBox.Show("Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("Bạn có muốn xóa dữ liệu đã chọn", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (NhanVienController.XoaNV(IDmember))
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
                MessageBox.Show("Vui lòng chọn 1 Nhân Viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}