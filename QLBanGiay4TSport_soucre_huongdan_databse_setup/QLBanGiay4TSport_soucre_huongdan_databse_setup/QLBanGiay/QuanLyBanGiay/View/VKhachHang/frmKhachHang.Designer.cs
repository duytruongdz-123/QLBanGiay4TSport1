namespace QuanLyBanGiay.View.VKhachHang
{
    partial class frmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgKhachHang = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKhachHang)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 554);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Location = new System.Drawing.Point(12, 343);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(336, 141);
            this.groupBox3.TabIndex = 2;
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
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
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
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Theo Tên",
            "Theo Lơp",
            "Theo địa chỉ",
            "Theo Mã lớp",
            ""});
            this.comboBox1.Location = new System.Drawing.Point(238, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(6, 31);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(226, 20);
            this.textBox8.TabIndex = 0;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSDT);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTen);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(11, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 289);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtSDT
            // 
            this.txtSDT.Enabled = false;
            this.txtSDT.Location = new System.Drawing.Point(110, 221);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(210, 20);
            this.txtSDT.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(110, 148);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(210, 20);
            this.txtDiaChi.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "SDT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ:";
            // 
            // txtTen
            // 
            this.txtTen.Enabled = false;
            this.txtTen.Location = new System.Drawing.Point(110, 89);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(210, 20);
            this.txtTen.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Khách Hàng:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(110, 34);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(210, 20);
            this.txtID.TabIndex = 0;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtgKhachHang);
            this.groupBox4.Location = new System.Drawing.Point(389, 1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(964, 509);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách khách hàng";
            // 
            // dtgKhachHang
            // 
            this.dtgKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgKhachHang.Location = new System.Drawing.Point(3, 16);
            this.dtgKhachHang.Name = "dtgKhachHang";
            this.dtgKhachHang.Size = new System.Drawing.Size(958, 493);
            this.dtgKhachHang.TabIndex = 1;
            this.dtgKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgKhachHang_CellClick);
            this.dtgKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgKhachHang_CellContentClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.comboBox2);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(383, 493);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(964, 62);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(243, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 44);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(310, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 44);
            this.button2.TabIndex = 4;
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
            this.comboBox2.Location = new System.Drawing.Point(630, 21);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(92, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(487, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Số lượng bản ghi trên trang:";
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 554);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKhachHang";
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgKhachHang)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtgKhachHang;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label10;
    }
}