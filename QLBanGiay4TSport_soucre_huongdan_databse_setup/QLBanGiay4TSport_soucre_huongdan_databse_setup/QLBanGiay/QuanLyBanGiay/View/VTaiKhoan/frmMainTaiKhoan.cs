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

namespace QuanLyBanGiay.View.VTaiKhoan
{
    public partial class frmMainTaiKhoan : Form
    {
        public frmMainTaiKhoan()
        {
            InitializeComponent();
        }

        private List<TaiKhoan> lstTaiKhoan;
        private string IDmember;
        private int CurCl, CurR, i;
        private string TenTaiKhoan;
        private string MatKhau;

        public void Hienthi()
        {
            lstTaiKhoan = TaiKhoanController.GetDataTaiKhoan();
            DataTable dt = ViewHelper.ToDataTable<TaiKhoan>(lstTaiKhoan);
            dtgTaiKhoan.DataSource = dt;
            dtgTaiKhoan.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dt.Columns["TenTaiKhoan"].ColumnName = "Mã TK";
            dt.Columns["MatKhau"].ColumnName = "Mật Khẩu";

            int i = 0;
            foreach (DataGridViewColumn col in dtgTaiKhoan.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                dtgTaiKhoan.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                i++;
            }
            try { dtgTaiKhoan.CurrentCell = dtgTaiKhoan[CurCl, CurR]; } catch { }
            dtgTaiKhoan.Refresh();
        }

        private void frmMainTaiKhoan_Load(object sender, EventArgs e)
        {
            Hienthi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThaoTacTaiKhoan frmThem = new frmThaoTacTaiKhoan(null, null, 0);
            frmThem.ShowDialog();
            Hienthi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmThaoTacTaiKhoan frmSua = new frmThaoTacTaiKhoan(TenTaiKhoan, MatKhau, 1);
            frmSua.ShowDialog();
            Hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (IDmember != null)
            {
                if (IDmember == "NULL")
                {
                    MessageBox.Show("Thông báo", "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("Do you want delete data?", "Note", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (TaiKhoanController.XoaTK(IDmember))
                    {
                        MessageBox.Show("Thông báo", "Xóa thành công", MessageBoxButtons.OK, MessageBoxIcon.Information); Hienthi();
                    }
                    else
                    {
                        MessageBox.Show("Thông báo", "Xóa Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Information); Hienthi();
                    }
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
        }

        private void dtgTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDmember = dtgTaiKhoan.CurrentRow.Cells[0].Value.ToString();
            CurCl = dtgTaiKhoan.CurrentCell.ColumnIndex;
            CurR = dtgTaiKhoan.CurrentCell.RowIndex;
            i = CurR;
            // show data
            txtTenTK.Text = TenTaiKhoan = lstTaiKhoan[i].TenTaiKhoan;
            txtMK.Text = MatKhau = lstTaiKhoan[i].MatKhau;
        }
    }
}