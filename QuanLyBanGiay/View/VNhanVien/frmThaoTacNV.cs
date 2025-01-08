using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QuanLyBanGiay.Controller;
using QuanLyBanGiay.Model;
using QuanLyBanGiay.Helper;
using Dapper;

namespace QuanLyBanGiay.View.VNhanVien
{
    public partial class frmThaoTacNV : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        int _state;
        public frmThaoTacNV(string _MaNV, string _HoTen, DateTime _NgaySinh, string _Sdt, int state)
        {
            InitializeComponent();
            txtHoTen.Text = _HoTen;
            txtID.Text = _MaNV;
            dtNgaySinh.Value = _NgaySinh;
            txtSDT.Text = _Sdt;
            _state = state;
            if (_state == 1)
            {
                txtID.Enabled = false;
            }

        }

        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (NhanVienController.checkInputNV(txtID.Text.Trim(), txtHoTen.Text.Trim(), dtNgaySinh.Value, txtSDT.Text.Trim()))
            {
                if (_state == 0)
                {
                    //xử lý Trùng mã
                    List<NhanVien> listNhanVien;
                    using (var db = setupConection.ConnectionFactory())
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        listNhanVien = db.Query<NhanVien>("SELECT MaNV FROM dbo.NhanVien").ToList();
                    }
                    if (listNhanVien.FindIndex(x => x.MaNV == txtID.Text.Trim()) == 1)
                    {
                        MessageBox.Show("Trùng mã nhân viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (NhanVienController.ThemNV(txtID.Text.Trim(), txtHoTen.Text.Trim(), dtNgaySinh.Value, txtSDT.Text.Trim()))
                    {
                        MessageBox.Show("Thành Công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (_state == 1)
                {
                    if (NhanVienController.SuaNV(txtID.Text.Trim(), txtHoTen.Text.Trim(), dtNgaySinh.Value, txtSDT.Text.Trim()))
                    {
                        MessageBox.Show("Thành Công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void bbiClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbiSaveAndClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            bbiSave_ItemClick(sender, e);
            this.Close();
        }

        private void bbiReset_ItemClick(object sender, ItemClickEventArgs e)
        {
            txtID.Text = "";
            txtHoTen.Text = "";
            dtNgaySinh.Text = "";
            txtSDT.Text = "";
        }
    }
}