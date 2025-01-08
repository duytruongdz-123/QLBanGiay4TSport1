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

namespace QuanLyBanGiay.View.VSanPham
{
    public partial class frmMainNhaCC : Form
    {
        public frmMainNhaCC()
        {
            InitializeComponent();
        }

        private string MaNCC;
        private string TenNCC;
        private string DiaChi;
        private string Sdt;

        private int CurCl = 0, CurR = 0;
        private string IDmember;
        private List<NhaCungCap> lstNhaCungCap;
        private int i = 0;

        public void Hienthi()
        {
            lstNhaCungCap = SanPhamController.GetDataNhaCungCap();
            DataTable dt = ViewHelper.ToDataTable<NhaCungCap>(lstNhaCungCap);
            dtgNhaCC.DataSource = dt;
            dtgNhaCC.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dt.Columns["MaNCC"].ColumnName = "Mã nhà CC";
            dt.Columns["TenNCC"].ColumnName = "Tên nhà cung cấp";
            dt.Columns["DiaChi"].ColumnName = "Địa chỉ";
            dt.Columns["Sdt"].ColumnName = "Số Điện Thoại";
            int j = 0;
            foreach (DataGridViewColumn col in dtgNhaCC.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                dtgNhaCC.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                j++;
            }
            try { dtgNhaCC.CurrentCell = dtgNhaCC[CurCl, CurR]; } catch { }
            dtgNhaCC.Refresh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThaoTacNhaCC frmThem = new frmThaoTacNhaCC(null, null, null, null, 1);
            frmThem.ShowDialog(); Hienthi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmThaoTacNhaCC frmThem = new frmThaoTacNhaCC(MaNCC, TenNCC, DiaChi, Sdt, 2);
            frmThem.ShowDialog(); Hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (IDmember != null)
            {
                if (IDmember == "NCCDEL")
                {
                    MessageBox.Show("Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("Bạn có muốn xóa dữ liệu đã chọn", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (SanPhamController.XoaNhaCC(IDmember))
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
                MessageBox.Show("Vui lòng chọn 1 Nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDmember = dtgNhaCC.CurrentRow.Cells[0].Value.ToString();
            CurCl = dtgNhaCC.CurrentCell.ColumnIndex;
            CurR = dtgNhaCC.CurrentCell.RowIndex;
            i = CurR;
            // show data
            txtMaNhaCC.Text = MaNCC = lstNhaCungCap[i].MaNCC;
            txtTenNhaCC.Text = TenNCC = lstNhaCungCap[i].TenNCC;
            txtDiaChi.Text = DiaChi = lstNhaCungCap[i].DiaChi;
            txtSDT.Text = Sdt = lstNhaCungCap[i].Sdt;
        }

        private void frmMainNhaCC_Load(object sender, EventArgs e)
        {
            Hienthi();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
        }
    }
}