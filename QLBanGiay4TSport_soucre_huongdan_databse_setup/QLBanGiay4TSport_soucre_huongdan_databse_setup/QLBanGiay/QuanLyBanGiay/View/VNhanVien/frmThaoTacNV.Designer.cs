namespace QuanLyBanGiay.View.VNhanVien
{
    partial class frmThaoTacNV
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
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndNew = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(118, 195);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(270, 21);
            this.txtSDT.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 202);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "SDT:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(118, 85);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(270, 21);
            this.txtHoTen.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(28, 92);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Tên:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(118, 32);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(270, 21);
            this.txtID.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(28, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(22, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "ID:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtNgaySinh);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 282);
            this.panel1.TabIndex = 16;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Location = new System.Drawing.Point(118, 142);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(270, 21);
            this.dtNgaySinh.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ngày Sinh:";
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
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 6;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bbiSaveAndNew
            // 
            this.bbiSaveAndNew.Caption = "Save And New";
            this.bbiSaveAndNew.Id = 4;
            this.bbiSaveAndNew.ImageOptions.ImageUri.Uri = "SaveAndNew";
            this.bbiSaveAndNew.Name = "bbiSaveAndNew";
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
            this.bbiClose});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.MaxItemId = 10;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(485, 146);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // frmThaoTacNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 428);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainRibbonControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThaoTacNV";
            this.Ribbon = this.mainRibbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thao Tác Nhân Viên";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndClose;
        private DevExpress.XtraBars.BarButtonItem bbiReset;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndNew;
        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.Label label1;
    }
}