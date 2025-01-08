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
    public partial class frmMainCTPhieuXuat : Form
    {
        public frmMainCTPhieuXuat()
        {
            InitializeComponent();
        }

        private List<CTPhieuXuat> lstCTPhieuXuat;
        private string IDmember;
        private int CurCl, CurR;
        private string MaPX;
        private string TenGiay;
        private string MaGiay;
        private int SoLuong;
        private long ChiPhiPhatSinh;
        private long DonGia;
        private int i;

        public void Hienthi()
        {
            lstCTPhieuXuat = HoaDonController.GetDataCTPhieuXuat();
            DataTable dt = ViewHelper.ToDataTable<CTPhieuXuat>(lstCTPhieuXuat);
            dtgCTPhieuXuat.DataSource = dt;
            dtgCTPhieuXuat.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dt.Columns["MaPX"].ColumnName = "Mã PN";
            dt.Columns["MaGiay"].ColumnName = "Mã giày";
            dt.Columns["TenGiay"].ColumnName = "Tên giày";
            dt.Columns["SoLuong"].ColumnName = "Số lượng";
            dt.Columns["ChiPhiPhatSinh"].ColumnName = "Chi Phí Phụ";
            dt.Columns["DonGia"].ColumnName = "Đơn giá";

            int i = 0;
            foreach (DataGridViewColumn col in dtgCTPhieuXuat.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                dtgCTPhieuXuat.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                i++;
            }
            try { dtgCTPhieuXuat.CurrentCell = dtgCTPhieuXuat[CurCl, CurR]; } catch { }
            dtgCTPhieuXuat.Refresh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        { 
            if (MaPX != null && MaGiay != null)
            {
                if (IDmember == "CTPXDEL")
                {
                    MessageBox.Show("Không thể xóa bản ghi này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("Bạn có muốn xóa dữ liệu đã chọn", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (HoaDonController.XoaCTPhieuXuat(MaPX, MaGiay))
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
                MessageBox.Show("Vui lòng chọn 1 CT phiếu xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        { 
            frmThaoTacCTPhieuXuat frmSua = new frmThaoTacCTPhieuXuat(MaPX, MaGiay, SoLuong, DonGia, ChiPhiPhatSinh, 1);
            frmSua.ShowDialog();
            Hienthi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        { 
            frmThaoTacCTPhieuXuat frmThem = new frmThaoTacCTPhieuXuat(null, null, 0, 0, 0, 0);
            frmThem.ShowDialog();
            Hienthi();
        }

        private void dtgCTPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDmember = dtgCTPhieuXuat.CurrentRow.Cells[0].Value.ToString();
            CurCl = dtgCTPhieuXuat.CurrentCell.ColumnIndex;
            CurR = dtgCTPhieuXuat.CurrentCell.RowIndex;
            i = CurR;
            // show data
            cbMaPX.Text = MaPX = lstCTPhieuXuat[i].MaPX;
            txtDonGia.Text = lstCTPhieuXuat[i].DonGia.ToString();
            DonGia = lstCTPhieuXuat[i].DonGia;
            txtSoLuong.Text = lstCTPhieuXuat[i].SoLuong.ToString();
            SoLuong = lstCTPhieuXuat[i].SoLuong;
            cbMaGiay.Text = TenGiay = lstCTPhieuXuat[i].TenGiay;
            MaGiay = lstCTPhieuXuat[i].MaGiay;
            txtPhiPS.Text = lstCTPhieuXuat[i].ChiPhiPhatSinh.ToString();
            ChiPhiPhatSinh = lstCTPhieuXuat[i].ChiPhiPhatSinh;
        }

        private void cbMaGiay_TextChanged(object sender, EventArgs e)
        {
        }

        private void frmMainCTPhieuXuat_Load(object sender, EventArgs e)
        {
            Hienthi();
        }
    }
}