namespace KimTravel.GUI
{
    partial class frmRibonMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRibonMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnQuanLyTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPhanQuyen = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnBookTour = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnListBook = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPhanXe = new DevExpress.XtraBars.BarButtonItem();
            this.barQLTour = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnGroupTour = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPartner = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnGroupPartner = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnStaff = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnService = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDataHotel = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCongNo = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnReportPartner = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnKetThuc = new DevExpress.XtraBars.BarButtonItem();
            this.lblAccount = new DevExpress.XtraBars.BarStaticItem();
            this.lblCurrent = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupHeThong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupTour = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupNghiepVu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupData = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabControlMain = new DevExpress.XtraTab.XtraTabControl();
            this.barBtnTourPrint = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barBtnQuanLyTaiKhoan,
            this.barBtnPhanQuyen,
            this.barBtnBookTour,
            this.barBtnListBook,
            this.barBtnPhanXe,
            this.barQLTour,
            this.barBtnGroupTour,
            this.barBtnPartner,
            this.barBtnGroupPartner,
            this.barBtnCar,
            this.barBtnStaff,
            this.barBtnService,
            this.barBtnDataHotel,
            this.barBtnCongNo,
            this.barBtnReportPartner,
            this.barBtnDangXuat,
            this.barBtnKetThuc,
            this.lblAccount,
            this.lblCurrent,
            this.barBtnTourPrint});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 21;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(1350, 141);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // barBtnQuanLyTaiKhoan
            // 
            this.barBtnQuanLyTaiKhoan.Caption = "Quản lý tài khoản";
            this.barBtnQuanLyTaiKhoan.Id = 1;
            this.barBtnQuanLyTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnQuanLyTaiKhoan.ImageOptions.Image")));
            this.barBtnQuanLyTaiKhoan.LargeWidth = 80;
            this.barBtnQuanLyTaiKhoan.Name = "barBtnQuanLyTaiKhoan";
            this.barBtnQuanLyTaiKhoan.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barBtnQuanLyTaiKhoan.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barBtnQuanLyTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnQuanLyTaiKhoan_ItemClick);
            // 
            // barBtnPhanQuyen
            // 
            this.barBtnPhanQuyen.Caption = "Quản lý phân quyền";
            this.barBtnPhanQuyen.Id = 2;
            this.barBtnPhanQuyen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnPhanQuyen.ImageOptions.Image")));
            this.barBtnPhanQuyen.LargeWidth = 80;
            this.barBtnPhanQuyen.Name = "barBtnPhanQuyen";
            this.barBtnPhanQuyen.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barBtnPhanQuyen.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barBtnPhanQuyen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnPhanQuyen_ItemClick);
            // 
            // barBtnBookTour
            // 
            this.barBtnBookTour.Caption = "Book Tour";
            this.barBtnBookTour.Id = 3;
            this.barBtnBookTour.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnBookTour.ImageOptions.Image")));
            this.barBtnBookTour.LargeWidth = 80;
            this.barBtnBookTour.Name = "barBtnBookTour";
            this.barBtnBookTour.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barBtnBookTour.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barBtnBookTour.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnBookTour_ItemClick);
            // 
            // barBtnListBook
            // 
            this.barBtnListBook.Caption = "Danh sách đã book";
            this.barBtnListBook.Id = 4;
            this.barBtnListBook.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnListBook.ImageOptions.Image")));
            this.barBtnListBook.LargeWidth = 80;
            this.barBtnListBook.Name = "barBtnListBook";
            this.barBtnListBook.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barBtnListBook.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barBtnListBook.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnListBook_ItemClick);
            // 
            // barBtnPhanXe
            // 
            this.barBtnPhanXe.Caption = "Phân bổ xe";
            this.barBtnPhanXe.Id = 5;
            this.barBtnPhanXe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnPhanXe.ImageOptions.Image")));
            this.barBtnPhanXe.Name = "barBtnPhanXe";
            this.barBtnPhanXe.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barBtnPhanXe.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barBtnPhanXe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnPhanXe_ItemClick);
            // 
            // barQLTour
            // 
            this.barQLTour.Caption = "Quản lý Tour";
            this.barQLTour.Id = 6;
            this.barQLTour.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barQLTour.ImageOptions.Image")));
            this.barQLTour.LargeWidth = 70;
            this.barQLTour.Name = "barQLTour";
            this.barQLTour.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barQLTour.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barQLTour.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barQLTour_ItemClick);
            // 
            // barBtnGroupTour
            // 
            this.barBtnGroupTour.Caption = "Quản lý nhóm Tour";
            this.barBtnGroupTour.Id = 7;
            this.barBtnGroupTour.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnGroupTour.ImageOptions.Image")));
            this.barBtnGroupTour.LargeWidth = 70;
            this.barBtnGroupTour.Name = "barBtnGroupTour";
            this.barBtnGroupTour.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barBtnGroupTour.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barBtnGroupTour.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnGroupTour_ItemClick);
            // 
            // barBtnPartner
            // 
            this.barBtnPartner.Caption = "Quản lý đối tác";
            this.barBtnPartner.Id = 8;
            this.barBtnPartner.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnPartner.ImageOptions.Image")));
            this.barBtnPartner.LargeWidth = 70;
            this.barBtnPartner.Name = "barBtnPartner";
            this.barBtnPartner.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barBtnPartner.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barBtnPartner.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnPartner_ItemClick);
            // 
            // barBtnGroupPartner
            // 
            this.barBtnGroupPartner.Caption = "Quản lý nhóm đối tác";
            this.barBtnGroupPartner.Id = 9;
            this.barBtnGroupPartner.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnGroupPartner.ImageOptions.Image")));
            this.barBtnGroupPartner.LargeWidth = 80;
            this.barBtnGroupPartner.Name = "barBtnGroupPartner";
            this.barBtnGroupPartner.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barBtnGroupPartner.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barBtnGroupPartner.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnGroupPartner_ItemClick);
            // 
            // barBtnCar
            // 
            this.barBtnCar.Caption = "Xe";
            this.barBtnCar.Id = 10;
            this.barBtnCar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnCar.ImageOptions.Image")));
            this.barBtnCar.LargeWidth = 80;
            this.barBtnCar.Name = "barBtnCar";
            this.barBtnCar.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barBtnCar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barBtnCar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCar_ItemClick);
            // 
            // barBtnStaff
            // 
            this.barBtnStaff.Caption = "Nhân viên";
            this.barBtnStaff.Id = 11;
            this.barBtnStaff.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnStaff.ImageOptions.Image")));
            this.barBtnStaff.LargeWidth = 80;
            this.barBtnStaff.Name = "barBtnStaff";
            this.barBtnStaff.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barBtnStaff.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barBtnStaff.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnStaff_ItemClick);
            // 
            // barBtnService
            // 
            this.barBtnService.Caption = "Dịch vụ";
            this.barBtnService.Id = 12;
            this.barBtnService.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnService.ImageOptions.Image")));
            this.barBtnService.LargeWidth = 80;
            this.barBtnService.Name = "barBtnService";
            this.barBtnService.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barBtnService.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barBtnService.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnService_ItemClick);
            // 
            // barBtnDataHotel
            // 
            this.barBtnDataHotel.Caption = "Khách sạn";
            this.barBtnDataHotel.Id = 13;
            this.barBtnDataHotel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnDataHotel.ImageOptions.Image")));
            this.barBtnDataHotel.LargeWidth = 80;
            this.barBtnDataHotel.Name = "barBtnDataHotel";
            this.barBtnDataHotel.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barBtnDataHotel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barBtnDataHotel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDataHotel_ItemClick);
            // 
            // barBtnCongNo
            // 
            this.barBtnCongNo.Caption = "Công nợ";
            this.barBtnCongNo.Id = 14;
            this.barBtnCongNo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnCongNo.ImageOptions.Image")));
            this.barBtnCongNo.LargeWidth = 70;
            this.barBtnCongNo.Name = "barBtnCongNo";
            this.barBtnCongNo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barBtnCongNo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barBtnCongNo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCongNo_ItemClick);
            // 
            // barBtnReportPartner
            // 
            this.barBtnReportPartner.Caption = "Công nợ đối tác";
            this.barBtnReportPartner.Id = 15;
            this.barBtnReportPartner.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnReportPartner.ImageOptions.Image")));
            this.barBtnReportPartner.LargeWidth = 70;
            this.barBtnReportPartner.Name = "barBtnReportPartner";
            this.barBtnReportPartner.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barBtnReportPartner.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barBtnReportPartner.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnReportPartner_ItemClick);
            // 
            // barBtnDangXuat
            // 
            this.barBtnDangXuat.Caption = "Đăng xuất";
            this.barBtnDangXuat.Id = 16;
            this.barBtnDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnDangXuat.ImageOptions.Image")));
            this.barBtnDangXuat.LargeWidth = 80;
            this.barBtnDangXuat.Name = "barBtnDangXuat";
            this.barBtnDangXuat.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barBtnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDangXuat_ItemClick);
            // 
            // barBtnKetThuc
            // 
            this.barBtnKetThuc.Caption = "Kết thúc";
            this.barBtnKetThuc.Id = 17;
            this.barBtnKetThuc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnKetThuc.ImageOptions.Image")));
            this.barBtnKetThuc.LargeWidth = 60;
            this.barBtnKetThuc.Name = "barBtnKetThuc";
            this.barBtnKetThuc.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barBtnKetThuc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnKetThuc_ItemClick);
            // 
            // lblAccount
            // 
            this.lblAccount.Caption = "HoangLC3";
            this.lblAccount.Id = 18;
            this.lblAccount.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lblAccount.ImageOptions.Image")));
            this.lblAccount.Name = "lblAccount";
            // 
            // lblCurrent
            // 
            this.lblCurrent.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.lblCurrent.Id = 19;
            this.lblCurrent.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lblCurrent.ImageOptions.Image")));
            this.lblCurrent.Name = "lblCurrent";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupHeThong,
            this.ribbonPageGroupTour,
            this.ribbonPageGroupNghiepVu,
            this.ribbonPageGroupBaoCao,
            this.ribbonPageGroup6});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Chức năng";
            // 
            // ribbonPageGroupHeThong
            // 
            this.ribbonPageGroupHeThong.ItemLinks.Add(this.barBtnQuanLyTaiKhoan);
            this.ribbonPageGroupHeThong.ItemLinks.Add(this.barBtnPhanQuyen);
            this.ribbonPageGroupHeThong.Name = "ribbonPageGroupHeThong";
            this.ribbonPageGroupHeThong.Text = "Hệ thống";
            this.ribbonPageGroupHeThong.Visible = false;
            // 
            // ribbonPageGroupTour
            // 
            this.ribbonPageGroupTour.ItemLinks.Add(this.barBtnBookTour);
            this.ribbonPageGroupTour.ItemLinks.Add(this.barBtnListBook);
            this.ribbonPageGroupTour.ItemLinks.Add(this.barBtnPhanXe);
            this.ribbonPageGroupTour.ItemLinks.Add(this.barBtnTourPrint);
            this.ribbonPageGroupTour.Name = "ribbonPageGroupTour";
            this.ribbonPageGroupTour.Text = "Tour";
            this.ribbonPageGroupTour.Visible = false;
            // 
            // ribbonPageGroupNghiepVu
            // 
            this.ribbonPageGroupNghiepVu.ItemLinks.Add(this.barQLTour);
            this.ribbonPageGroupNghiepVu.ItemLinks.Add(this.barBtnGroupTour);
            this.ribbonPageGroupNghiepVu.ItemLinks.Add(this.barBtnPartner);
            this.ribbonPageGroupNghiepVu.ItemLinks.Add(this.barBtnGroupPartner);
            this.ribbonPageGroupNghiepVu.Name = "ribbonPageGroupNghiepVu";
            this.ribbonPageGroupNghiepVu.Text = "Nghiệp vụ";
            this.ribbonPageGroupNghiepVu.Visible = false;
            // 
            // ribbonPageGroupBaoCao
            // 
            this.ribbonPageGroupBaoCao.ItemLinks.Add(this.barBtnCongNo);
            this.ribbonPageGroupBaoCao.ItemLinks.Add(this.barBtnReportPartner);
            this.ribbonPageGroupBaoCao.Name = "ribbonPageGroupBaoCao";
            this.ribbonPageGroupBaoCao.Text = "Báo cáo";
            this.ribbonPageGroupBaoCao.Visible = false;
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barBtnDangXuat);
            this.ribbonPageGroup6.ItemLinks.Add(this.barBtnKetThuc);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupData});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Dữ liệu";
            // 
            // ribbonPageGroupData
            // 
            this.ribbonPageGroupData.ItemLinks.Add(this.barBtnCar);
            this.ribbonPageGroupData.ItemLinks.Add(this.barBtnStaff);
            this.ribbonPageGroupData.ItemLinks.Add(this.barBtnService);
            this.ribbonPageGroupData.ItemLinks.Add(this.barBtnDataHotel);
            this.ribbonPageGroupData.Name = "ribbonPageGroupData";
            this.ribbonPageGroupData.Text = "Dữ liệu hệ thống";
            this.ribbonPageGroupData.Visible = false;
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.lblAccount);
            this.ribbonStatusBar1.ItemLinks.Add(this.lblCurrent);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 702);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1350, 27);
            // 
            // xtraTabControlMain
            // 
            this.xtraTabControlMain.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlMain.HeaderButtons = DevExpress.XtraTab.TabButtons.Close;
            this.xtraTabControlMain.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.Always;
            this.xtraTabControlMain.Location = new System.Drawing.Point(0, 141);
            this.xtraTabControlMain.Margin = new System.Windows.Forms.Padding(4);
            this.xtraTabControlMain.Name = "xtraTabControlMain";
            this.xtraTabControlMain.Size = new System.Drawing.Size(1350, 561);
            this.xtraTabControlMain.TabIndex = 2;
            this.xtraTabControlMain.CloseButtonClick += new System.EventHandler(this.xtraTabControlMain_CloseButtonClick);
            // 
            // barBtnTourPrint
            // 
            this.barBtnTourPrint.Caption = "Danh sách đã in";
            this.barBtnTourPrint.Id = 20;
            this.barBtnTourPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barBtnTourPrint.LargeWidth = 70;
            this.barBtnTourPrint.Name = "barBtnTourPrint";
            this.barBtnTourPrint.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barBtnTourPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnTourPrint_ItemClick);
            // 
            // frmRibonMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.xtraTabControlMain);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRibonMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kim Travel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRibonMain_FormClosing);
            this.Load += new System.EventHandler(this.frmRibonMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupHeThong;
        private DevExpress.XtraBars.BarButtonItem barBtnQuanLyTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem barBtnPhanQuyen;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupTour;
        private DevExpress.XtraBars.BarButtonItem barBtnBookTour;
        private DevExpress.XtraBars.BarButtonItem barBtnListBook;
        private DevExpress.XtraBars.BarButtonItem barBtnPhanXe;
        private DevExpress.XtraBars.BarButtonItem barQLTour;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupNghiepVu;
        private DevExpress.XtraBars.BarButtonItem barBtnGroupTour;
        private DevExpress.XtraBars.BarButtonItem barBtnPartner;
        private DevExpress.XtraBars.BarButtonItem barBtnGroupPartner;
        private DevExpress.XtraBars.BarButtonItem barBtnCar;
        private DevExpress.XtraBars.BarButtonItem barBtnStaff;
        private DevExpress.XtraBars.BarButtonItem barBtnService;
        private DevExpress.XtraBars.BarButtonItem barBtnDataHotel;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupData;
        private DevExpress.XtraBars.BarButtonItem barBtnCongNo;
        private DevExpress.XtraBars.BarButtonItem barBtnReportPartner;
        private DevExpress.XtraBars.BarButtonItem barBtnDangXuat;
        private DevExpress.XtraBars.BarButtonItem barBtnKetThuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarStaticItem lblAccount;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlMain;
        private DevExpress.XtraBars.BarStaticItem lblCurrent;
        private DevExpress.XtraBars.BarButtonItem barBtnTourPrint;
    }
}