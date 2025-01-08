using QuanLyBanGiay.Controller;
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
    public partial class frmSize : Form
    {
        public frmSize()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestController.Test(1,0);
        }
    }
}
