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
    public partial class frmMainCTPhieuNhap : Form
    {
        public frmMainCTPhieuNhap()
        { 
            InitializeComponent();
        }

        private List<CTPhieuNhap> lstCTPhieuNhap;
        private string IDmember;
        private int CurCl, CurR;

        private string MaPN;
        private string MaGiay;
        private string TenGiay;
        private int SoLuong;
        private long ChiPhiPhatSinh;
        private long DonGia;
        private int i;

        public void Hienthi()
        { 
            lstCTPhieuNhap = HoaDonController.GetDataCTPhieuNhap();
            DataTable dt = ViewHelper.ToDataTable<CTPhieuNhap>(lstCTPhieuNhap);
            dtgCTPhieuNhap.DataSource = dt;
            dtgCTPhieuNhap.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dt.Columns["MaPN"].ColumnName = "Mã PN";
            dt.Columns["MaGiay"].ColumnName = "Mã giày";
            dt.Columns["TenGiay"].ColumnName = "Tên giày";
            dt.Columns["SoLuong"].ColumnName = "Số lượng";
            dt.Columns["ChiPhiPhatSinh"].ColumnName = "Chi Phí Phụ";
            dt.Columns["DonGia"].ColumnName = "Đơn giá";

            int i = 0;
            foreach (DataGridViewColumn col in dtgCTPhieuNhap.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                dtgCTPhieuNhap.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                i++;
            }
            try { dtgCTPhieuNhap.CurrentCell = dtgCTPhieuNhap[CurCl, CurR]; } catch { }
            dtgCTPhieuNhap.Refresh();
        }

        private void frmMainCTPhieuNhap_Load(object sender, EventArgs e)
        { 
            Hienthi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        { 
            frmThaoTacCTPhieuNhap frmThem = new frmThaoTacCTPhieuNhap(null, null, null, null, null, 0);
            frmThem.ShowDialog();
            Hienthi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        { 
            frmThaoTacCTPhieuNhap frmSua = new frmThaoTacCTPhieuNhap(MaPN, MaGiay, txtSoLuong.Text, txtDonGia.Text, txtPhiPS.Text, 1);
            frmSua.ShowDialog();
            Hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        { 
            if (MaPN != null && MaGiay != null)
            {
                if (IDmember == "CTPXDEL")
                {
                    MessageBox.Show("Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("Bạn có muốn xóa dữ liệu đã chọn", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (HoaDonController.XoaCTPhieuNhap(MaPN, MaGiay))
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
                MessageBox.Show("Vui lòng chọn 1 CT phiếu nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgCTPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            IDmember = dtgCTPhieuNhap.CurrentRow.Cells[0].Value.ToString();
            CurCl = dtgCTPhieuNhap.CurrentCell.ColumnIndex;
            CurR = dtgCTPhieuNhap.CurrentCell.RowIndex;
            i = CurR;

            // show data
            cbMaPN.Text = MaPN = lstCTPhieuNhap[i].MaPN;
            txtDonGia.Text = lstCTPhieuNhap[i].DonGia.ToString();
            DonGia = lstCTPhieuNhap[i].DonGia;
            txtSoLuong.Text = lstCTPhieuNhap[i].SoLuong.ToString();
            SoLuong = lstCTPhieuNhap[i].SoLuong;
            cbMaGiay.Text = TenGiay = lstCTPhieuNhap[i].TenGiay;
            txtPhiPS.Text = lstCTPhieuNhap[i].ChiPhiPhatSinh.ToString();
            ChiPhiPhatSinh = lstCTPhieuNhap[i].ChiPhiPhatSinh;
            MaGiay = lstCTPhieuNhap[i].MaGiay;
        }
    }
}