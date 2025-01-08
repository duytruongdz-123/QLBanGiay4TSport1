namespace QuanLyBanGiay.View.VSanPham
{
    partial class frmThaoTacSanPham
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThaoTacSanPham));
            this.erPr = new System.Windows.Forms.ErrorProvider(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.bbiSaveAndNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtGiaThanh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNhaCC = new System.Windows.Forms.ComboBox();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNhaSX = new System.Windows.Forms.ComboBox();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtThongSoKT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenGiay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaGiay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.grQuanLySanPham = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnLoaiGiay = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.erPr)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // erPr
            // 
            this.erPr.ContainerControl = this;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // bbiSaveAndNew
            // 
            this.bbiSaveAndNew.Caption = "Save And New";
            this.bbiSaveAndNew.Id = 4;
            this.bbiSaveAndNew.ImageOptions.ImageUri.Uri = "SaveAndNew";
            this.bbiSaveAndNew.Name = "bbiSaveAndNew";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 6;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mainRibbonPageGroup});
            this.mainRibbonPage.MergeOrder = 0;
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "Home";
            // 
            // mainRibbonPageGroup
            // 
            this.mainRibbonPageGroup.AllowTextClipping = false;
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiSave);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiSaveAndClose);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiReset);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiClose);
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.ShowCaptionButton = false;
            this.mainRibbonPageGroup.Text = "Tasks";
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Id = 2;
            this.bbiSave.ImageOptions.ImageUri.Uri = "Save";
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // bbiSaveAndClose
            // 
            this.bbiSaveAndClose.Caption = "Save And Close";
            this.bbiSaveAndClose.Id = 3;
            this.bbiSaveAndClose.ImageOptions.ImageUri.Uri = "SaveAndClose";
            this.bbiSaveAndClose.Name = "bbiSaveAndClose";
            this.bbiSaveAndClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSaveAndClose_ItemClick);
            // 
            // bbiReset
            // 
            this.bbiReset.Caption = "Reset Changes";
            this.bbiReset.Id = 5;
            this.bbiReset.ImageOptions.ImageUri.Uri = "Reset";
            this.bbiReset.Name = "bbiReset";
            this.bbiReset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReset_ItemClick);
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Close";
            this.bbiClose.Id = 7;
            this.bbiClose.ImageOptions.ImageUri.Uri = "Close";
            this.bbiClose.Name = "bbiClose";
            this.bbiClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiClose_ItemClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtGiaThanh);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbNhaCC);
            this.panel2.Controls.Add(this.cbSize);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbNhaSX);
            this.panel2.Controls.Add(this.cbLoai);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtThongSoKT);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtTenGiay);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtMaGiay);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 261);
            this.panel2.TabIndex = 8;
            // 
            // txtGiaThanh
            // 
            this.txtGiaThanh.Location = new System.Drawing.Point(494, 39);
            this.txtGiaThanh.Name = "txtGiaThanh";
            this.txtGiaThanh.Size = new System.Drawing.Size(223, 21);
            this.txtGiaThanh.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Giá Thành:";
            // 
            // cbNhaCC
            // 
            this.cbNhaCC.FormattingEnabled = true;
            this.cbNhaCC.Location = new System.Drawing.Point(494, 214);
            this.cbNhaCC.Name = "cbNhaCC";
            this.cbNhaCC.Size = new System.Drawing.Size(223, 21);
            this.cbNhaCC.TabIndex = 25;
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Location = new System.Drawing.Point(494, 79);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(223, 21);
            this.cbSize.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Size:";
            // 
            // cbNhaSX
            // 
            this.cbNhaSX.FormattingEnabled = true;
            this.cbNhaSX.Location = new System.Drawing.Point(494, 163);
            this.cbNhaSX.Name = "cbNhaSX";
            this.cbNhaSX.Size = new System.Drawing.Size(223, 21);
            this.cbNhaSX.TabIndex = 22;
            // 
            // cbLoai
            // 
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Location = new System.Drawing.Point(494, 120);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(223, 21);
            this.cbLoai.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(393, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tên nhà cung cấp:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tên nhà sản xuất:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(393, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tên loại:";
            // 
            // txtThongSoKT
            // 
            this.txtThongSoKT.Location = new System.Drawing.Point(118, 126);
            this.txtThongSoKT.Multiline = true;
            this.txtThongSoKT.Name = "txtThongSoKT";
            this.txtThongSoKT.Size = new System.Drawing.Size(223, 108);
            this.txtThongSoKT.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Thông số kĩ thuật:";
            // 
            // txtTenGiay
            // 
            this.txtTenGiay.Location = new System.Drawing.Point(118, 79);
            this.txtTenGiay.Name = "txtTenGiay";
            this.txtTenGiay.Size = new System.Drawing.Size(223, 21);
            this.txtTenGiay.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên giày:";
            // 
            // txtMaGiay
            // 
            this.txtMaGiay.Location = new System.Drawing.Point(118, 38);
            this.txtMaGiay.Name = "txtMaGiay";
            this.txtMaGiay.Size = new System.Drawing.Size(223, 21);
            this.txtMaGiay.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã giày:";
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.bbiSave,
            this.bbiSaveAndClose,
            this.bbiSaveAndNew,
            this.bbiReset,
            this.bbiDelete,
            this.bbiClose,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.MaxItemId = 13;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage,
            this.ribbonPage1});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(785, 146);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Quản lý loại giày";
            this.barButtonItem1.Id = 10;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Quản lý nhà sản xuất";
            this.barButtonItem2.Id = 11;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Nhà cung cấp";
            this.barButtonItem3.Id = 12;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản lý sản phẩm";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Loại giày";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Nhà sản xuất";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Nhà cung cấp";
            // 
            // grQuanLySanPham
            // 
            this.grQuanLySanPham.Name = "grQuanLySanPham";
            this.grQuanLySanPham.Text = "Quản lý sản phẩm";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Quản lý sản phẩm";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Quản lý sản phẩm";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Quản lý sản phẩm";
            // 
            // btnLoaiGiay
            // 
            this.btnLoaiGiay.Caption = "Loại giày";
            this.btnLoaiGiay.Id = 5;
            this.btnLoaiGiay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoaiGiay.ImageOptions.Image")));
            this.btnLoaiGiay.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLoaiGiay.ImageOptions.LargeImage")));
            this.btnLoaiGiay.Name = "btnLoaiGiay";
            // 
            // frmThaoTacSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 407);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mainRibbonControl);
            this.MaximizeBox = false;
            this.Name = "frmThaoTacSanPham";
            this.Ribbon = this.mainRibbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thao tác sản phẩm";
            this.Load += new System.EventHandler(this.frmThaoTacSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erPr)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider erPr;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndClose;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndNew;
        private DevExpress.XtraBars.BarButtonItem bbiReset;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtThongSoKT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaGiay;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup grQuanLySanPham;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnLoaiGiay;
        private System.Windows.Forms.ComboBox cbNhaSX;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.TextBox txtTenGiay;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNhaCC;
        private System.Windows.Forms.TextBox txtGiaThanh;
        private System.Windows.Forms.Label label4;
    }
}