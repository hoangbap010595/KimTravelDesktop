namespace KimTravel.GUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txt_bar_CurrentUser = new MaterialSkin.Controls.MaterialLabel();
            this.panelStatusBar = new System.Windows.Forms.Panel();
            this.txt_bar_TimeUsed = new MaterialSkin.Controls.MaterialLabel();
            this.timerUseSystem = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hêThôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyTaiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyPhânQuyênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuâtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kêtThucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSachĐaBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.săpXêpTourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nghiêpVuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookTourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyĐôiTacToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyNhomĐôiTacToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dưLiêuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loaiDichVuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khachSanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.côngNơToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giupĐơToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hươngDânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelControlMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.đaTourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelStatusBar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_bar_CurrentUser
            // 
            this.txt_bar_CurrentUser.AutoSize = true;
            this.txt_bar_CurrentUser.BackColor = System.Drawing.Color.Transparent;
            this.txt_bar_CurrentUser.Depth = 0;
            this.txt_bar_CurrentUser.Font = new System.Drawing.Font("Roboto", 11F);
            this.txt_bar_CurrentUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_bar_CurrentUser.Location = new System.Drawing.Point(9, 4);
            this.txt_bar_CurrentUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_bar_CurrentUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_bar_CurrentUser.Name = "txt_bar_CurrentUser";
            this.txt_bar_CurrentUser.Size = new System.Drawing.Size(117, 19);
            this.txt_bar_CurrentUser.TabIndex = 0;
            this.txt_bar_CurrentUser.Text = "bar_CurrentUser";
            // 
            // panelStatusBar
            // 
            this.panelStatusBar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelStatusBar.Controls.Add(this.txt_bar_TimeUsed);
            this.panelStatusBar.Controls.Add(this.txt_bar_CurrentUser);
            this.panelStatusBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStatusBar.Location = new System.Drawing.Point(2, 655);
            this.panelStatusBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelStatusBar.Name = "panelStatusBar";
            this.panelStatusBar.Size = new System.Drawing.Size(1293, 26);
            this.panelStatusBar.TabIndex = 6;
            // 
            // txt_bar_TimeUsed
            // 
            this.txt_bar_TimeUsed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_bar_TimeUsed.BackColor = System.Drawing.Color.Transparent;
            this.txt_bar_TimeUsed.Depth = 0;
            this.txt_bar_TimeUsed.Font = new System.Drawing.Font("Roboto", 11F);
            this.txt_bar_TimeUsed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_bar_TimeUsed.Location = new System.Drawing.Point(1210, 3);
            this.txt_bar_TimeUsed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_bar_TimeUsed.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_bar_TimeUsed.Name = "txt_bar_TimeUsed";
            this.txt_bar_TimeUsed.Size = new System.Drawing.Size(73, 20);
            this.txt_bar_TimeUsed.TabIndex = 0;
            this.txt_bar_TimeUsed.Text = "00:00:00";
            this.txt_bar_TimeUsed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerUseSystem
            // 
            this.timerUseSystem.Interval = 1000;
            this.timerUseSystem.Tick += new System.EventHandler(this.timerUseSystem_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hêThôngToolStripMenuItem,
            this.tourToolStripMenuItem,
            this.nghiêpVuToolStripMenuItem,
            this.dưLiêuToolStripMenuItem,
            this.baoCaoToolStripMenuItem,
            this.giupĐơToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1297, 25);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hêThôngToolStripMenuItem
            // 
            this.hêThôngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyTaiKhoanToolStripMenuItem,
            this.quanLyPhânQuyênToolStripMenuItem,
            this.đăngXuâtToolStripMenuItem,
            this.kêtThucToolStripMenuItem});
            this.hêThôngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hêThôngToolStripMenuItem.Image")));
            this.hêThôngToolStripMenuItem.Name = "hêThôngToolStripMenuItem";
            this.hêThôngToolStripMenuItem.Size = new System.Drawing.Size(95, 25);
            this.hêThôngToolStripMenuItem.Text = "Hệ thống";
            // 
            // quanLyTaiKhoanToolStripMenuItem
            // 
            this.quanLyTaiKhoanToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quanLyTaiKhoanToolStripMenuItem.Image")));
            this.quanLyTaiKhoanToolStripMenuItem.Name = "quanLyTaiKhoanToolStripMenuItem";
            this.quanLyTaiKhoanToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.quanLyTaiKhoanToolStripMenuItem.Text = "Quản lý Tài khoản";
            this.quanLyTaiKhoanToolStripMenuItem.Click += new System.EventHandler(this.quanLyTaiKhoanToolStripMenuItem_Click);
            // 
            // quanLyPhânQuyênToolStripMenuItem
            // 
            this.quanLyPhânQuyênToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quanLyPhânQuyênToolStripMenuItem.Image")));
            this.quanLyPhânQuyênToolStripMenuItem.Name = "quanLyPhânQuyênToolStripMenuItem";
            this.quanLyPhânQuyênToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.quanLyPhânQuyênToolStripMenuItem.Text = "Quản lý Phân quyền";
            // 
            // đăngXuâtToolStripMenuItem
            // 
            this.đăngXuâtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đăngXuâtToolStripMenuItem.Image")));
            this.đăngXuâtToolStripMenuItem.Name = "đăngXuâtToolStripMenuItem";
            this.đăngXuâtToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.đăngXuâtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // kêtThucToolStripMenuItem
            // 
            this.kêtThucToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kêtThucToolStripMenuItem.Image")));
            this.kêtThucToolStripMenuItem.Name = "kêtThucToolStripMenuItem";
            this.kêtThucToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.kêtThucToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.kêtThucToolStripMenuItem.Text = "Kết thúc";
            this.kêtThucToolStripMenuItem.Click += new System.EventHandler(this.kêtThucToolStripMenuItem_Click);
            // 
            // tourToolStripMenuItem
            // 
            this.tourToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem,
            this.danhSachĐaBookToolStripMenuItem,
            this.săpXêpTourToolStripMenuItem,
            this.đaTourToolStripMenuItem});
            this.tourToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tourToolStripMenuItem.Image")));
            this.tourToolStripMenuItem.Name = "tourToolStripMenuItem";
            this.tourToolStripMenuItem.Size = new System.Drawing.Size(64, 25);
            this.tourToolStripMenuItem.Text = "Tour";
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bookToolStripMenuItem.Image")));
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.bookToolStripMenuItem.Text = "Book";
            this.bookToolStripMenuItem.Click += new System.EventHandler(this.bookToolStripMenuItem_Click);
            // 
            // danhSachĐaBookToolStripMenuItem
            // 
            this.danhSachĐaBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("danhSachĐaBookToolStripMenuItem.Image")));
            this.danhSachĐaBookToolStripMenuItem.Name = "danhSachĐaBookToolStripMenuItem";
            this.danhSachĐaBookToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.danhSachĐaBookToolStripMenuItem.Text = "Danh sách đã book";
            this.danhSachĐaBookToolStripMenuItem.Click += new System.EventHandler(this.danhSachĐaBookToolStripMenuItem_Click);
            // 
            // săpXêpTourToolStripMenuItem
            // 
            this.săpXêpTourToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("săpXêpTourToolStripMenuItem.Image")));
            this.săpXêpTourToolStripMenuItem.Name = "săpXêpTourToolStripMenuItem";
            this.săpXêpTourToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.săpXêpTourToolStripMenuItem.Text = "Phân bổ xe theo tour";
            this.săpXêpTourToolStripMenuItem.Click += new System.EventHandler(this.săpXêpTourToolStripMenuItem_Click);
            // 
            // nghiêpVuToolStripMenuItem
            // 
            this.nghiêpVuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookTourToolStripMenuItem,
            this.quanLyĐôiTacToolStripMenuItem,
            this.quanLyToolStripMenuItem,
            this.quanLyNhomĐôiTacToolStripMenuItem});
            this.nghiêpVuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nghiêpVuToolStripMenuItem.Image")));
            this.nghiêpVuToolStripMenuItem.Name = "nghiêpVuToolStripMenuItem";
            this.nghiêpVuToolStripMenuItem.Size = new System.Drawing.Size(100, 25);
            this.nghiêpVuToolStripMenuItem.Text = "Nghiệp vụ";
            // 
            // bookTourToolStripMenuItem
            // 
            this.bookTourToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bookTourToolStripMenuItem.Image")));
            this.bookTourToolStripMenuItem.Name = "bookTourToolStripMenuItem";
            this.bookTourToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.bookTourToolStripMenuItem.Text = "Quản lý Tour";
            this.bookTourToolStripMenuItem.Click += new System.EventHandler(this.bookTourToolStripMenuItem_Click);
            // 
            // quanLyĐôiTacToolStripMenuItem
            // 
            this.quanLyĐôiTacToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quanLyĐôiTacToolStripMenuItem.Image")));
            this.quanLyĐôiTacToolStripMenuItem.Name = "quanLyĐôiTacToolStripMenuItem";
            this.quanLyĐôiTacToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.quanLyĐôiTacToolStripMenuItem.Text = "Quản lý đối tác";
            this.quanLyĐôiTacToolStripMenuItem.Click += new System.EventHandler(this.quanLyĐôiTacToolStripMenuItem_Click);
            // 
            // quanLyToolStripMenuItem
            // 
            this.quanLyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quanLyToolStripMenuItem.Image")));
            this.quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            this.quanLyToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.quanLyToolStripMenuItem.Text = "Quản lý nhóm tour";
            this.quanLyToolStripMenuItem.Click += new System.EventHandler(this.quanLyToolStripMenuItem_Click);
            // 
            // quanLyNhomĐôiTacToolStripMenuItem
            // 
            this.quanLyNhomĐôiTacToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quanLyNhomĐôiTacToolStripMenuItem.Image")));
            this.quanLyNhomĐôiTacToolStripMenuItem.Name = "quanLyNhomĐôiTacToolStripMenuItem";
            this.quanLyNhomĐôiTacToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.quanLyNhomĐôiTacToolStripMenuItem.Text = "Quản lý nhóm đối tác";
            this.quanLyNhomĐôiTacToolStripMenuItem.Click += new System.EventHandler(this.quanLyNhomĐôiTacToolStripMenuItem_Click);
            // 
            // dưLiêuToolStripMenuItem
            // 
            this.dưLiêuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xeToolStripMenuItem,
            this.quanLyNhânViênToolStripMenuItem,
            this.loaiDichVuToolStripMenuItem,
            this.khachSanToolStripMenuItem});
            this.dưLiêuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dưLiêuToolStripMenuItem.Image")));
            this.dưLiêuToolStripMenuItem.Name = "dưLiêuToolStripMenuItem";
            this.dưLiêuToolStripMenuItem.Size = new System.Drawing.Size(80, 25);
            this.dưLiêuToolStripMenuItem.Text = "Dữ liệu";
            // 
            // xeToolStripMenuItem
            // 
            this.xeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("xeToolStripMenuItem.Image")));
            this.xeToolStripMenuItem.Name = "xeToolStripMenuItem";
            this.xeToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.xeToolStripMenuItem.Text = "Xe";
            this.xeToolStripMenuItem.Click += new System.EventHandler(this.xeToolStripMenuItem_Click);
            // 
            // quanLyNhânViênToolStripMenuItem
            // 
            this.quanLyNhânViênToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quanLyNhânViênToolStripMenuItem.Image")));
            this.quanLyNhânViênToolStripMenuItem.Name = "quanLyNhânViênToolStripMenuItem";
            this.quanLyNhânViênToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.quanLyNhânViênToolStripMenuItem.Text = "Nhân viên";
            this.quanLyNhânViênToolStripMenuItem.Click += new System.EventHandler(this.quanLyNhânViênToolStripMenuItem_Click);
            // 
            // loaiDichVuToolStripMenuItem
            // 
            this.loaiDichVuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loaiDichVuToolStripMenuItem.Image")));
            this.loaiDichVuToolStripMenuItem.Name = "loaiDichVuToolStripMenuItem";
            this.loaiDichVuToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.loaiDichVuToolStripMenuItem.Text = "Loại dịch vụ";
            // 
            // khachSanToolStripMenuItem
            // 
            this.khachSanToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("khachSanToolStripMenuItem.Image")));
            this.khachSanToolStripMenuItem.Name = "khachSanToolStripMenuItem";
            this.khachSanToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.khachSanToolStripMenuItem.Text = "Khách sạn";
            // 
            // baoCaoToolStripMenuItem
            // 
            this.baoCaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.côngNơToolStripMenuItem});
            this.baoCaoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("baoCaoToolStripMenuItem.Image")));
            this.baoCaoToolStripMenuItem.Name = "baoCaoToolStripMenuItem";
            this.baoCaoToolStripMenuItem.Size = new System.Drawing.Size(85, 25);
            this.baoCaoToolStripMenuItem.Text = "Báo cáo";
            // 
            // côngNơToolStripMenuItem
            // 
            this.côngNơToolStripMenuItem.Name = "côngNơToolStripMenuItem";
            this.côngNơToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.côngNơToolStripMenuItem.Text = "Công nợ";
            // 
            // giupĐơToolStripMenuItem
            // 
            this.giupĐơToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hươngDânToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
            this.giupĐơToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("giupĐơToolStripMenuItem.Image")));
            this.giupĐơToolStripMenuItem.Name = "giupĐơToolStripMenuItem";
            this.giupĐơToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.giupĐơToolStripMenuItem.Text = "Giúp đỡ";
            // 
            // hươngDânToolStripMenuItem
            // 
            this.hươngDânToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hươngDânToolStripMenuItem.Image")));
            this.hươngDânToolStripMenuItem.Name = "hươngDânToolStripMenuItem";
            this.hươngDânToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.hươngDânToolStripMenuItem.Text = "Hướng dẫn";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thôngTinToolStripMenuItem.Image")));
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelControlMain);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 27);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1293, 624);
            this.panel2.TabIndex = 8;
            // 
            // panelControlMain
            // 
            this.panelControlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlMain.Location = new System.Drawing.Point(0, 36);
            this.panelControlMain.Name = "panelControlMain";
            this.panelControlMain.Size = new System.Drawing.Size(1293, 588);
            this.panelControlMain.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1293, 36);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblTitle.Location = new System.Drawing.Point(10, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 20);
            this.lblTitle.TabIndex = 0;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.panelStatusBar, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(2, 66);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1297, 683);
            this.tableLayoutPanelMain.TabIndex = 9;
            // 
            // đaTourToolStripMenuItem
            // 
            this.đaTourToolStripMenuItem.Name = "đaTourToolStripMenuItem";
            this.đaTourToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.đaTourToolStripMenuItem.Text = "Đã tour";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 750);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1300, 736);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kim Travel Version 1.0.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelStatusBar.ResumeLayout(false);
            this.panelStatusBar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel txt_bar_CurrentUser;
        private System.Windows.Forms.Panel panelStatusBar;
        private MaterialSkin.Controls.MaterialLabel txt_bar_TimeUsed;
        private System.Windows.Forms.Timer timerUseSystem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hêThôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyTaiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyPhânQuyênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuâtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kêtThucToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nghiêpVuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookTourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyĐôiTacToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dưLiêuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loaiDichVuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khachSanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baoCaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem côngNơToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giupĐơToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hươngDânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelControlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolStripMenuItem quanLyNhomĐôiTacToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSachĐaBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem săpXêpTourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đaTourToolStripMenuItem;
    }
}

