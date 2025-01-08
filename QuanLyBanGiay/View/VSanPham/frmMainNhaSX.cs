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
    public partial class frmMainNhaSX : Form
    {
        public frmMainNhaSX()
        {
            InitializeComponent();
        }

        private string MaNSX;
        private string TenNSX;
        private string QuocGia;

        private int CurCl = 0, CurR = 0;
        private string IDmember;
        private List<NhaSanXuat> lstNhaSanXuat;
        private int i = 0;

        public void Hienthi()
        {
            lstNhaSanXuat = SanPhamController.GetDataNhaSanXuat();
            DataTable dt = ViewHelper.ToDataTable<NhaSanXuat>(lstNhaSanXuat);
            dtgNhaSX.DataSource = dt;
            dtgNhaSX.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dt.Columns["MaNSX"].ColumnName = "Mã NSX";
            dt.Columns["TenNSX"].ColumnName = "Tên nhà sản xuất";
            dt.Columns["QuocGia"].ColumnName = "Quốc gia";

            int j = 0;
            foreach (DataGridViewColumn col in dtgNhaSX.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                dtgNhaSX.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                j++;
            }
            try { dtgNhaSX.CurrentCell = dtgNhaSX[CurCl, CurR]; } catch { }
            dtgNhaSX.Refresh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThaoTacNhaSX frmThem = new frmThaoTacNhaSX(null, null, null, 1);
            frmThem.ShowDialog(); Hienthi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmThaoTacNhaSX frmThem = new frmThaoTacNhaSX(MaNSX, TenNSX, QuocGia, 2);
            frmThem.ShowDialog(); Hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (IDmember != null)
            {
                if (IDmember == "NSXDEL")
                {
                    MessageBox.Show("Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("Bạn có muốn xóa dữ liệu đã chọn", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (SanPhamController.XoaNhaSX(IDmember))
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
                MessageBox.Show("Vui lòng chọn 1 Nhà sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgNhaSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDmember = dtgNhaSX.CurrentRow.Cells[0].Value.ToString();
            CurCl = dtgNhaSX.CurrentCell.ColumnIndex;
            CurR = dtgNhaSX.CurrentCell.RowIndex;
            i = CurR;
            // show data
            txtMaNhaSX.Text = MaNSX = lstNhaSanXuat[i].MaNSX;
            txtTenNhaSX.Text = TenNSX = lstNhaSanXuat[i].TenNSX;
            txtQuocGia.Text = QuocGia = lstNhaSanXuat[i].QuocGia;
        }

        private void frmMainNhaSX_Load(object sender, EventArgs e)
        {
            Hienthi();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
        }
    }
}