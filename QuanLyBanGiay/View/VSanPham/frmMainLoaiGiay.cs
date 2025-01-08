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
    public partial class frmMainLoaiGiay : Form
    {
        public frmMainLoaiGiay()
        {
            InitializeComponent();
        }

        private string MaLoai;
        private string TenLoai;
        private string GhiChu;

        private int CurCl = 0, CurR = 0;
        private string IDmember;
        private List<LoaiGiay> lstLoaiGiay;
        private int i = 0;

        public void Hienthi()
        {
            lstLoaiGiay = SanPhamController.GetDataLoaiGiay();
            DataTable dt = ViewHelper.ToDataTable<LoaiGiay>(lstLoaiGiay);
            dtgLoaiGiay.DataSource = dt;
            dtgLoaiGiay.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dt.Columns["MaLoai"].ColumnName = "Mã Loại";
            dt.Columns["TenLoai"].ColumnName = "Tên Loại";
            dt.Columns["GhiChu"].ColumnName = "Ghi Chú";

            int j = 0;
            foreach (DataGridViewColumn col in dtgLoaiGiay.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                dtgLoaiGiay.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                j++;
            }
            try { dtgLoaiGiay.CurrentCell = dtgLoaiGiay[CurCl, CurR]; } catch { }
            dtgLoaiGiay.Refresh();
        }

        private void dtgLoaiGiay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDmember = dtgLoaiGiay.CurrentRow.Cells[0].Value.ToString();
            CurCl = dtgLoaiGiay.CurrentCell.ColumnIndex;
            CurR = dtgLoaiGiay.CurrentCell.RowIndex;
            i = CurR;
            // show data
            txtMaLoai.Text = MaLoai = lstLoaiGiay[i].MaLoai;
            txtTenLoai.Text = TenLoai = lstLoaiGiay[i].TenLoai;
            txtGhiChu.Text = GhiChu = lstLoaiGiay[i].GhiChu;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThaoTacLoaiGiay frmThem = new frmThaoTacLoaiGiay(null, null, null, 1);
            frmThem.ShowDialog(); Hienthi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmThaoTacLoaiGiay frmSua = new frmThaoTacLoaiGiay(MaLoai, TenLoai, GhiChu, 2);
            frmSua.ShowDialog(); Hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (IDmember != null)
            {
                if (IDmember == "LGDEL")
                {
                    MessageBox.Show("Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("Bạn có muốn xóa dữ liệu đã chọn", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (SanPhamController.XoaLoaiGiay(IDmember))
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
                MessageBox.Show("Vui lòng chọn 1 loại giày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
        }

        private void frmMainLoaiGiay_Load(object sender, EventArgs e)
        {
            Hienthi();
        }
    }
}