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
using Dapper;
using QuanLyBanGiay.Models;
using QuanLyBanGiay.Controller;

namespace QuanLyBanGiay.View.VHoaDon
{
    public partial class frmThaoTacCTPhieuNhap : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int state;
        private List<PhieuNhap> listPN = new List<PhieuNhap>();
        private List<Giay> listGiay = new List<Giay>();
        private long Gia;

        public frmThaoTacCTPhieuNhap(string _MaPN, string _MaGiay, string _SoLuong, string _DonGia, string _ChiPhiPhatSinh, int _state)
        { 
            InitializeComponent();
            txtSoLuong.Text = _SoLuong;
            txtDonGia.Text = _DonGia;
            txtCPPS.Text = _ChiPhiPhatSinh;
            state = _state;
            if (state == 1)
            {
                cbMaPN.Enabled = false;
                cbTenGiay.Enabled = false;
            }
            //Xử lý phieu nhap,  giay
            using (var db = setupConection.ConnectionFactory())
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                listPN = db.Query<PhieuNhap>("SELECT MaPN FROM dbo.PhieuNhap").ToList();
                for (int i = 0; i < listPN.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = listPN[i].MaPN.ToString();
                    item.Value = listPN[i].MaPN.ToString();
                    cbMaPN.Items.Add(item);
                    if (_MaPN == listPN[i].MaPN)
                    {
                        cbMaPN.SelectedIndex = i;
                    }
                }

                listGiay = db.Query<Giay>("SELECT * FROM dbo.Giay").ToList();
                for (int i = 0; i < listGiay.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = listGiay[i].TenGiay.ToString();
                    item.Value = listGiay[i].MaGiay.ToString();
                    cbTenGiay.Items.Add(item);
                    if (_MaGiay == listGiay[i].MaGiay)
                    {
                        cbTenGiay.SelectedIndex = i;
                    }
                }
            }
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        { 
            if (HoaDonController.checkInput(txtSoLuong.Text, txtCPPS.Text))
            { 
                string maGiay = listGiay.Find(x => x.TenGiay == cbTenGiay.Text).MaGiay;
                long dongia = listGiay.Find(x => x.MaGiay == maGiay).GiaThanh + long.Parse(txtCPPS.Text);
                string maPN = listPN.Find(x => x.MaPN == cbMaPN.Text).MaPN;

                if (state == 0)
                { 
                    if (HoaDonController.ThemCTPhieuNhap(maPN, maGiay, txtSoLuong.Text, dongia.ToString(), txtCPPS.Text))
                    {
                        MessageBox.Show("Thành Công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (state == 1)
                { 
                    if (HoaDonController.SuaCTPhieuNhap(maPN, maGiay, txtSoLuong.Text, dongia.ToString(), txtCPPS.Text))
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

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        { 
        }
    }
}