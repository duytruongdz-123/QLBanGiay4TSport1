namespace QuanLyBanGiay.View.VNhanVien
{
    partial class frmMainNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainNhanVien));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dtgNhanVien = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVien)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(487, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Số lượng bản ghi trên trang:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.comboBox2);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(381, 492);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(964, 62);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
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
            // dtgNhanVien
            // 
            this.dtgNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgNhanVien.Location = new System.Drawing.Point(3, 17);
            this.dtgNhanVien.Name = "dtgNhanVien";
            this.dtgNhanVien.Size = new System.Drawing.Size(958, 496);
            this.dtgNhanVien.TabIndex = 1;
            this.dtgNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgNhanVien_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtgNhanVien);
            this.groupBox4.Location = new System.Drawing.Point(387, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(964, 509);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách Nhân Viên";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(6, 31);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(226, 21);
            this.textBox8.TabIndex = 0;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(-1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 554);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateNgaySinh);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSDT);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTen);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(11, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 289);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhân viên";
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.Enabled = false;
            this.dateNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgaySinh.Location = new System.Drawing.Point(101, 166);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(210, 21);
            this.dateNgaySinh.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ngày sinh:";
            // 
            // txtSDT
            // 
            this.txtSDT.Enabled = false;
            this.txtSDT.Location = new System.Drawing.Point(101, 224);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(210, 21);
            this.txtSDT.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "SDT:";
            // 
            // txtTen
            // 
            this.txtTen.Enabled = false;
            this.txtTen.Location = new System.Drawing.Point(101, 107);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(210, 21);
            this.txtTen.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(101, 44);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(210, 21);
            this.txtID.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID:";
            // 
            // frmMainNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 554);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMainNhanVien";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.frmMainNhanVien_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVien)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dtgNhanVien;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateNgaySinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
    }
}