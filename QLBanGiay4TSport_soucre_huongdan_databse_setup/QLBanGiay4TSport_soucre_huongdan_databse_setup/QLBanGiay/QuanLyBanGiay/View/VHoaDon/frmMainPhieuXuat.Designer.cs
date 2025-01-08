namespace QuanLyBanGiay.View.VHoaDon
{
    partial class frmMainPhieuXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainPhieuXuat));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cbKeyTimKiem = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaPX = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.dateNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtgPhieuXuat = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhieuXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(-1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 554);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(138, 491);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(112, 49);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Xuất ra File";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.cbKeyTimKiem);
            this.groupBox3.Controls.Add(this.txtTimKiem);
            this.groupBox3.Location = new System.Drawing.Point(13, 330);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 141);
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
            this.cbKeyTimKiem.Items.AddRange(new object[] {
            "Theo Tên",
            "Theo Lơp",
            "Theo địa chỉ",
            "Theo Mã lớp",
            ""});
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
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaPX);
            this.groupBox2.Controls.Add(this.txtTenNV);
            this.groupBox2.Controls.Add(this.txtTenKH);
            this.groupBox2.Controls.Add(this.dateNgayXuat);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 289);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phiêu xuất";
            // 
            // txtMaPX
            // 
            this.txtMaPX.Enabled = false;
            this.txtMaPX.Location = new System.Drawing.Point(105, 33);
            this.txtMaPX.Name = "txtMaPX";
            this.txtMaPX.Size = new System.Drawing.Size(225, 20);
            this.txtMaPX.TabIndex = 13;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Enabled = false;
            this.txtTenNV.Location = new System.Drawing.Point(105, 175);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(225, 20);
            this.txtTenNV.TabIndex = 12;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Enabled = false;
            this.txtTenKH.Location = new System.Drawing.Point(105, 235);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(225, 20);
            this.txtTenKH.TabIndex = 11;
            // 
            // dateNgayXuat
            // 
            this.dateNgayXuat.Enabled = false;
            this.dateNgayXuat.Location = new System.Drawing.Point(107, 102);
            this.dateNgayXuat.Name = "dateNgayXuat";
            this.dateNgayXuat.Size = new System.Drawing.Size(223, 20);
            this.dateNgayXuat.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên khách hàng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tên nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày xuất:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã PX:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.dtgPhieuXuat);
            this.groupBox4.Location = new System.Drawing.Point(387, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(964, 481);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách phiếu xuất:";
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(3, 476);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(946, 78);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // dtgPhieuXuat
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPhieuXuat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgPhieuXuat.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgPhieuXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgPhieuXuat.Location = new System.Drawing.Point(3, 16);
            this.dtgPhieuXuat.Name = "dtgPhieuXuat";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPhieuXuat.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgPhieuXuat.Size = new System.Drawing.Size(958, 463);
            this.dtgPhieuXuat.TabIndex = 1;
            this.dtgPhieuXuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPhieuXuat_CellClick);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(522, 495);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 44);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(589, 495);
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
            this.comboBox2.Location = new System.Drawing.Point(909, 507);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(92, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(766, 510);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Số lượng bản ghi trên trang:";
            // 
            // frmMainPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 554);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMainPhieuXuat";
            this.Text = "Phiếu xuất";
            this.Load += new System.EventHandler(this.frmMainPhieuXuat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhieuXuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cbKeyTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtgPhieuXuat;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateNgayXuat;
        private System.Windows.Forms.TextBox txtMaPX;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtTenKH;
    }
}