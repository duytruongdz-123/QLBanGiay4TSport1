namespace QuanLyBanGiay.View.VSanPham
{
    partial class frmMainSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainSanPham));
            this.txtTenNhaCC = new System.Windows.Forms.TextBox();
            this.txtTenNhaSX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgSanPham = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cbKeyTimKiem = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGiaThanh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtThongSoKT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenGiay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaGiay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenNhaCC
            // 
            this.txtTenNhaCC.Enabled = false;
            this.txtTenNhaCC.Location = new System.Drawing.Point(108, 276);
            this.txtTenNhaCC.Name = "txtTenNhaCC";
            this.txtTenNhaCC.Size = new System.Drawing.Size(223, 20);
            this.txtTenNhaCC.TabIndex = 9;
            // 
            // txtTenNhaSX
            // 
            this.txtTenNhaSX.Enabled = false;
            this.txtTenNhaSX.Location = new System.Drawing.Point(108, 250);
            this.txtTenNhaSX.Name = "txtTenNhaSX";
            this.txtTenNhaSX.Size = new System.Drawing.Size(223, 20);
            this.txtTenNhaSX.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên nhà cung cấp:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên nhà sản xuất:";
            // 
            // dtgSanPham
            // 
            this.dtgSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgSanPham.Location = new System.Drawing.Point(3, 16);
            this.dtgSanPham.Name = "dtgSanPham";
            this.dtgSanPham.Size = new System.Drawing.Size(958, 463);
            this.dtgSanPham.TabIndex = 0;
            this.dtgSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSanPham_CellClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Size = new System.Drawing.Size(1350, 554);
            this.splitContainer1.SplitterDistance = 382;
            this.splitContainer1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 554);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(133, 480);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(112, 49);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Xuất ra File";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.cbKeyTimKiem);
            this.groupBox3.Controls.Add(this.txtTimKiem);
            this.groupBox3.Location = new System.Drawing.Point(13, 332);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 210);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "thao tác dữ liệu";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(47, 63);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(68, 63);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(137, 63);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(68, 63);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(227, 63);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(68, 63);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Delete";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cbKeyTimKiem
            // 
            this.cbKeyTimKiem.FormattingEnabled = true;
            this.cbKeyTimKiem.Location = new System.Drawing.Point(238, 31);
            this.cbKeyTimKiem.Name = "cbKeyTimKiem";
            this.cbKeyTimKiem.Size = new System.Drawing.Size(92, 21);
            this.cbKeyTimKiem.TabIndex = 1;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(6, 31);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(226, 20);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGiaThanh);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSize);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtTenNhaCC);
            this.groupBox2.Controls.Add(this.txtTenNhaSX);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtTenLoai);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtThongSoKT);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtTenGiay);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMaGiay);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 307);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm";
            // 
            // txtGiaThanh
            // 
            this.txtGiaThanh.Enabled = false;
            this.txtGiaThanh.Location = new System.Drawing.Point(108, 190);
            this.txtGiaThanh.Name = "txtGiaThanh";
            this.txtGiaThanh.Size = new System.Drawing.Size(223, 20);
            this.txtGiaThanh.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Giá:";
            // 
            // txtSize
            // 
            this.txtSize.Enabled = false;
            this.txtSize.Location = new System.Drawing.Point(108, 161);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(223, 20);
            this.txtSize.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Size:";
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Enabled = false;
            this.txtTenLoai.Location = new System.Drawing.Point(108, 222);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(223, 20);
            this.txtTenLoai.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên loại:";
            // 
            // txtThongSoKT
            // 
            this.txtThongSoKT.Enabled = false;
            this.txtThongSoKT.Location = new System.Drawing.Point(108, 71);
            this.txtThongSoKT.Multiline = true;
            this.txtThongSoKT.Name = "txtThongSoKT";
            this.txtThongSoKT.Size = new System.Drawing.Size(223, 79);
            this.txtThongSoKT.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Thông số kĩ thuật:";
            // 
            // txtTenGiay
            // 
            this.txtTenGiay.Enabled = false;
            this.txtTenGiay.Location = new System.Drawing.Point(108, 45);
            this.txtTenGiay.Name = "txtTenGiay";
            this.txtTenGiay.Size = new System.Drawing.Size(223, 20);
            this.txtTenGiay.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên giày:";
            // 
            // txtMaGiay
            // 
            this.txtMaGiay.Enabled = false;
            this.txtMaGiay.Location = new System.Drawing.Point(108, 19);
            this.txtMaGiay.Name = "txtMaGiay";
            this.txtMaGiay.Size = new System.Drawing.Size(223, 20);
            this.txtMaGiay.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã giày:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.comboBox2);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox5.Location = new System.Drawing.Point(0, 476);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(964, 78);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(201, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 44);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(268, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 44);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25"});
            this.comboBox2.Location = new System.Drawing.Point(588, 32);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(92, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(445, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Số lượng bản ghi trên trang:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtgSanPham);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(964, 509);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh Sách sản phẩm";
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1350, 554);
            this.panelControl1.TabIndex = 4;
            // 
            // frmMainSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 554);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmMainSanPham";
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.frmMainSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSanPham)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenNhaCC;
        private System.Windows.Forms.TextBox txtTenNhaSX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtgSanPham;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cbKeyTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtThongSoKT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenGiay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaGiay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiaThanh;
        private System.Windows.Forms.Label label4;
    }
}