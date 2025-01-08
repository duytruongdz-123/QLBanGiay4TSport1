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

namespace QuanLyBanGiay.View.VKhachHang
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private List<KhachHang> lstKhacHang;
        private string IDmember;
        private int CurCl, CurR, i;
        private string MaKH;
        private string TenKhachHang;
        private string DiaChi;
        private string Sdt;

        public void Hienthi()
        {
            lstKhacHang = KhachHangController.GetDataKhachHang();
            DataTable dt = ViewHelper.ToDataTable<KhachHang>(lstKhacHang);
            dtgKhachHang.DataSource = dt;
            dtgKhachHang.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dt.Columns["MaKH"].ColumnName = "Mã KH";
            dt.Columns["TenKhachHang"].ColumnName = "Tên KH";
            dt.Columns["DiaChi"].ColumnName = "Địa Chỉ";
            dt.Columns["Sdt"].ColumnName = "Số điện thoại";

            int i = 0;
            foreach (DataGridViewColumn col in dtgKhachHang.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                dtgKhachHang.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                i++;
            }
            try { dtgKhachHang.CurrentCell = dtgKhachHang[CurCl, CurR]; } catch { }
            dtgKhachHang.Refresh();
        }

        private void dtgKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDmember = dtgKhachHang.CurrentRow.Cells[0].Value.ToString();
            CurCl = dtgKhachHang.CurrentCell.ColumnIndex;
            CurR = dtgKhachHang.CurrentCell.RowIndex;
            i = CurR;
            // show data
            txtID.Text = MaKH = lstKhacHang[i].MaKH;
            txtTen.Text = TenKhachHang = lstKhacHang[i].TenKhachHang;
            txtDiaChi.Text = DiaChi = lstKhacHang[i].DiaChi;
            txtSDT.Text = Sdt = lstKhacHang[i].Sdt.ToString();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            Hienthi();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
        }

        private void dtgKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            frmThaoTacKH frmThem = new frmThaoTacKH(null, null, null, null, 0);
            frmThem.ShowDialog();
            Hienthi();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            frmThaoTacKH frmSua = new frmThaoTacKH(MaKH, TenKhachHang, DiaChi, Sdt, 1);
            frmSua.ShowDialog();
            Hienthi();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (IDmember != null)
            {
                if (IDmember == "KHDEL")
                {
                    MessageBox.Show("Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("Bạn có muốn xóa dữ liệu đã chọn", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (KhachHangController.XoaKH(IDmember))
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

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }
    }
}