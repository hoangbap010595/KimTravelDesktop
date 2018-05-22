namespace KimTravel.GUI.UControls
{
    partial class UCListBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCListBook));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.rdBinhThuong = new System.Windows.Forms.RadioButton();
            this.rdDaHuy = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.đaNhânBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tảiLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTour = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnService = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPartner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCustomName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPickUp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRoom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPartnerPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSales = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDateCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnClickViews = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumnDoneBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnIsDone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnExportExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClickViews)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(3, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày nhận booking";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.CustomFormat = "dd-MM-yyyy";
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(140, 17);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(169, 26);
            this.dtpStartDate.TabIndex = 3;
            // 
            // rdBinhThuong
            // 
            this.rdBinhThuong.AutoSize = true;
            this.rdBinhThuong.Checked = true;
            this.rdBinhThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBinhThuong.Location = new System.Drawing.Point(39, 18);
            this.rdBinhThuong.Name = "rdBinhThuong";
            this.rdBinhThuong.Size = new System.Drawing.Size(102, 21);
            this.rdBinhThuong.TabIndex = 6;
            this.rdBinhThuong.TabStop = true;
            this.rdBinhThuong.Text = "Binh thường";
            this.rdBinhThuong.UseVisualStyleBackColor = true;
            // 
            // rdDaHuy
            // 
            this.rdDaHuy.AutoSize = true;
            this.rdDaHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDaHuy.Location = new System.Drawing.Point(161, 17);
            this.rdDaHuy.Name = "rdDaHuy";
            this.rdDaHuy.Size = new System.Drawing.Size(71, 21);
            this.rdDaHuy.TabIndex = 6;
            this.rdDaHuy.Text = "Đã hủy";
            this.rdDaHuy.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đaNhânBookingToolStripMenuItem,
            this.tảiLạiToolStripMenuItem,
            this.xuấtExcelToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(168, 70);
            // 
            // đaNhânBookingToolStripMenuItem
            // 
            this.đaNhânBookingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đaNhânBookingToolStripMenuItem.Image")));
            this.đaNhânBookingToolStripMenuItem.Name = "đaNhânBookingToolStripMenuItem";
            this.đaNhânBookingToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.đaNhânBookingToolStripMenuItem.Text = "Đã Nhận Booking";
            this.đaNhânBookingToolStripMenuItem.Click += new System.EventHandler(this.đaNhânBookingToolStripMenuItem_Click);
            // 
            // tảiLạiToolStripMenuItem
            // 
            this.tảiLạiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tảiLạiToolStripMenuItem.Image")));
            this.tảiLạiToolStripMenuItem.Name = "tảiLạiToolStripMenuItem";
            this.tảiLạiToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.tảiLạiToolStripMenuItem.Text = "Tải lại";
            this.tảiLạiToolStripMenuItem.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // xuấtExcelToolStripMenuItem
            // 
            this.xuấtExcelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("xuấtExcelToolStripMenuItem.Image")));
            this.xuấtExcelToolStripMenuItem.Name = "xuấtExcelToolStripMenuItem";
            this.xuấtExcelToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.xuấtExcelToolStripMenuItem.Text = "Xuất Excel";
            this.xuấtExcelToolStripMenuItem.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBinhThuong);
            this.groupBox1.Controls.Add(this.rdDaHuy);
            this.groupBox1.Location = new System.Drawing.Point(315, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 45);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tình trạng";
            // 
            // gridControlData
            // 
            this.gridControlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlData.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControlData.Location = new System.Drawing.Point(3, 57);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnClickViews});
            this.gridControlData.Size = new System.Drawing.Size(1660, 540);
            this.gridControlData.TabIndex = 10;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // gridViewData
            // 
            this.gridViewData.ColumnPanelRowHeight = 35;
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnID,
            this.gridColumnName,
            this.gridColumnTour,
            this.gridColumnService,
            this.gridColumnPartner,
            this.gridColumnCustomName,
            this.gridColumnPickUp,
            this.gridColumnRoom,
            this.gridColumnPartnerPrice,
            this.gridColumnSales,
            this.gridColumnNote,
            this.gridColumnStartDate,
            this.gridColumnDateCreate,
            this.gridColumnEdit,
            this.gridColumnDoneBy,
            this.gridColumnIsDone});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.IndicatorWidth = 35;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsCustomization.AllowColumnMoving = false;
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.ShowAutoFilterRow = true;
            this.gridViewData.OptionsView.ShowGroupPanel = false;
            this.gridViewData.RowHeight = 25;
            this.gridViewData.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewData_CustomDrawRowIndicator);
            this.gridViewData.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewData_RowStyle);
            // 
            // gridColumnID
            // 
            this.gridColumnID.Caption = "ID";
            this.gridColumnID.FieldName = "ID";
            this.gridColumnID.Name = "gridColumnID";
            // 
            // gridColumnName
            // 
            this.gridColumnName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.gridColumnName.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.gridColumnName.AppearanceCell.Options.UseFont = true;
            this.gridColumnName.AppearanceCell.Options.UseForeColor = true;
            this.gridColumnName.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnName.AppearanceHeader.Options.UseFont = true;
            this.gridColumnName.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnName.Caption = "SL";
            this.gridColumnName.FieldName = "Pax";
            this.gridColumnName.MaxWidth = 50;
            this.gridColumnName.MinWidth = 50;
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.OptionsColumn.AllowEdit = false;
            this.gridColumnName.OptionsColumn.AllowFocus = false;
            this.gridColumnName.OptionsColumn.ReadOnly = true;
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 1;
            this.gridColumnName.Width = 50;
            // 
            // gridColumnTour
            // 
            this.gridColumnTour.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnTour.AppearanceCell.Options.UseFont = true;
            this.gridColumnTour.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnTour.AppearanceHeader.Options.UseFont = true;
            this.gridColumnTour.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnTour.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnTour.Caption = "Tour";
            this.gridColumnTour.FieldName = "TourName";
            this.gridColumnTour.MinWidth = 150;
            this.gridColumnTour.Name = "gridColumnTour";
            this.gridColumnTour.OptionsColumn.AllowEdit = false;
            this.gridColumnTour.OptionsColumn.AllowFocus = false;
            this.gridColumnTour.OptionsColumn.ReadOnly = true;
            this.gridColumnTour.Visible = true;
            this.gridColumnTour.VisibleIndex = 2;
            this.gridColumnTour.Width = 150;
            // 
            // gridColumnService
            // 
            this.gridColumnService.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnService.AppearanceCell.Options.UseFont = true;
            this.gridColumnService.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnService.AppearanceHeader.Options.UseFont = true;
            this.gridColumnService.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnService.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnService.Caption = "Dịch vụ";
            this.gridColumnService.FieldName = "ServiceName";
            this.gridColumnService.MinWidth = 150;
            this.gridColumnService.Name = "gridColumnService";
            this.gridColumnService.OptionsColumn.AllowEdit = false;
            this.gridColumnService.OptionsColumn.AllowFocus = false;
            this.gridColumnService.Visible = true;
            this.gridColumnService.VisibleIndex = 3;
            this.gridColumnService.Width = 150;
            // 
            // gridColumnPartner
            // 
            this.gridColumnPartner.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnPartner.AppearanceCell.Options.UseFont = true;
            this.gridColumnPartner.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnPartner.AppearanceHeader.Options.UseFont = true;
            this.gridColumnPartner.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnPartner.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPartner.Caption = "Đối tác";
            this.gridColumnPartner.FieldName = "PartName";
            this.gridColumnPartner.MinWidth = 180;
            this.gridColumnPartner.Name = "gridColumnPartner";
            this.gridColumnPartner.OptionsColumn.AllowEdit = false;
            this.gridColumnPartner.OptionsColumn.AllowFocus = false;
            this.gridColumnPartner.Visible = true;
            this.gridColumnPartner.VisibleIndex = 4;
            this.gridColumnPartner.Width = 180;
            // 
            // gridColumnCustomName
            // 
            this.gridColumnCustomName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnCustomName.AppearanceCell.Options.UseFont = true;
            this.gridColumnCustomName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnCustomName.AppearanceHeader.Options.UseFont = true;
            this.gridColumnCustomName.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnCustomName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnCustomName.Caption = "Khách hàng";
            this.gridColumnCustomName.FieldName = "CustomName";
            this.gridColumnCustomName.MinWidth = 140;
            this.gridColumnCustomName.Name = "gridColumnCustomName";
            this.gridColumnCustomName.Width = 140;
            // 
            // gridColumnPickUp
            // 
            this.gridColumnPickUp.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnPickUp.AppearanceCell.Options.UseFont = true;
            this.gridColumnPickUp.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnPickUp.AppearanceHeader.Options.UseFont = true;
            this.gridColumnPickUp.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnPickUp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPickUp.Caption = "Pick Up";
            this.gridColumnPickUp.FieldName = "PickUp";
            this.gridColumnPickUp.MinWidth = 200;
            this.gridColumnPickUp.Name = "gridColumnPickUp";
            this.gridColumnPickUp.OptionsColumn.AllowEdit = false;
            this.gridColumnPickUp.OptionsColumn.AllowFocus = false;
            this.gridColumnPickUp.Visible = true;
            this.gridColumnPickUp.VisibleIndex = 5;
            this.gridColumnPickUp.Width = 200;
            // 
            // gridColumnRoom
            // 
            this.gridColumnRoom.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnRoom.AppearanceCell.Options.UseFont = true;
            this.gridColumnRoom.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnRoom.AppearanceHeader.Options.UseFont = true;
            this.gridColumnRoom.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnRoom.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnRoom.Caption = "Room";
            this.gridColumnRoom.FieldName = "Room";
            this.gridColumnRoom.MinWidth = 100;
            this.gridColumnRoom.Name = "gridColumnRoom";
            this.gridColumnRoom.OptionsColumn.AllowEdit = false;
            this.gridColumnRoom.OptionsColumn.AllowFocus = false;
            this.gridColumnRoom.Visible = true;
            this.gridColumnRoom.VisibleIndex = 6;
            this.gridColumnRoom.Width = 100;
            // 
            // gridColumnPartnerPrice
            // 
            this.gridColumnPartnerPrice.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnPartnerPrice.AppearanceCell.Options.UseFont = true;
            this.gridColumnPartnerPrice.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnPartnerPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumnPartnerPrice.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnPartnerPrice.AppearanceHeader.Options.UseFont = true;
            this.gridColumnPartnerPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnPartnerPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPartnerPrice.Caption = "Thu hộ";
            this.gridColumnPartnerPrice.DisplayFormat.FormatString = "#,###";
            this.gridColumnPartnerPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnPartnerPrice.FieldName = "PartnerPrice";
            this.gridColumnPartnerPrice.MaxWidth = 120;
            this.gridColumnPartnerPrice.MinWidth = 120;
            this.gridColumnPartnerPrice.Name = "gridColumnPartnerPrice";
            this.gridColumnPartnerPrice.OptionsColumn.AllowEdit = false;
            this.gridColumnPartnerPrice.OptionsColumn.AllowFocus = false;
            this.gridColumnPartnerPrice.Visible = true;
            this.gridColumnPartnerPrice.VisibleIndex = 7;
            this.gridColumnPartnerPrice.Width = 120;
            // 
            // gridColumnSales
            // 
            this.gridColumnSales.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnSales.AppearanceCell.Options.UseFont = true;
            this.gridColumnSales.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnSales.AppearanceHeader.Options.UseFont = true;
            this.gridColumnSales.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnSales.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnSales.Caption = "NV Book";
            this.gridColumnSales.FieldName = "StaffID";
            this.gridColumnSales.MinWidth = 120;
            this.gridColumnSales.Name = "gridColumnSales";
            this.gridColumnSales.OptionsColumn.AllowEdit = false;
            this.gridColumnSales.OptionsColumn.AllowFocus = false;
            this.gridColumnSales.Visible = true;
            this.gridColumnSales.VisibleIndex = 8;
            this.gridColumnSales.Width = 120;
            // 
            // gridColumnNote
            // 
            this.gridColumnNote.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnNote.AppearanceCell.Options.UseFont = true;
            this.gridColumnNote.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnNote.AppearanceHeader.Options.UseFont = true;
            this.gridColumnNote.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnNote.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnNote.Caption = "Ghi chú";
            this.gridColumnNote.FieldName = "Note";
            this.gridColumnNote.MinWidth = 160;
            this.gridColumnNote.Name = "gridColumnNote";
            this.gridColumnNote.OptionsColumn.AllowEdit = false;
            this.gridColumnNote.OptionsColumn.AllowFocus = false;
            this.gridColumnNote.OptionsColumn.ReadOnly = true;
            this.gridColumnNote.Visible = true;
            this.gridColumnNote.VisibleIndex = 9;
            this.gridColumnNote.Width = 160;
            // 
            // gridColumnStartDate
            // 
            this.gridColumnStartDate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnStartDate.AppearanceCell.Options.UseFont = true;
            this.gridColumnStartDate.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnStartDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnStartDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnStartDate.AppearanceHeader.Options.UseFont = true;
            this.gridColumnStartDate.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnStartDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnStartDate.Caption = "Ngày đi";
            this.gridColumnStartDate.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.gridColumnStartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnStartDate.FieldName = "StartDate";
            this.gridColumnStartDate.MaxWidth = 120;
            this.gridColumnStartDate.MinWidth = 120;
            this.gridColumnStartDate.Name = "gridColumnStartDate";
            this.gridColumnStartDate.OptionsColumn.AllowEdit = false;
            this.gridColumnStartDate.OptionsColumn.AllowFocus = false;
            this.gridColumnStartDate.Visible = true;
            this.gridColumnStartDate.VisibleIndex = 0;
            this.gridColumnStartDate.Width = 120;
            // 
            // gridColumnDateCreate
            // 
            this.gridColumnDateCreate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnDateCreate.AppearanceCell.Options.UseFont = true;
            this.gridColumnDateCreate.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnDateCreate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDateCreate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnDateCreate.AppearanceHeader.Options.UseFont = true;
            this.gridColumnDateCreate.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnDateCreate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDateCreate.Caption = "Thời gian nhận";
            this.gridColumnDateCreate.DisplayFormat.FormatString = "hh:mm tt";
            this.gridColumnDateCreate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnDateCreate.FieldName = "DateCreate";
            this.gridColumnDateCreate.MaxWidth = 120;
            this.gridColumnDateCreate.MinWidth = 120;
            this.gridColumnDateCreate.Name = "gridColumnDateCreate";
            this.gridColumnDateCreate.OptionsColumn.AllowEdit = false;
            this.gridColumnDateCreate.OptionsColumn.AllowFocus = false;
            this.gridColumnDateCreate.OptionsColumn.ReadOnly = true;
            this.gridColumnDateCreate.Visible = true;
            this.gridColumnDateCreate.VisibleIndex = 10;
            this.gridColumnDateCreate.Width = 120;
            // 
            // gridColumnEdit
            // 
            this.gridColumnEdit.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnEdit.AppearanceHeader.Options.UseFont = true;
            this.gridColumnEdit.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnEdit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnEdit.Caption = "Sửa";
            this.gridColumnEdit.ColumnEdit = this.btnClickViews;
            this.gridColumnEdit.MaxWidth = 60;
            this.gridColumnEdit.MinWidth = 60;
            this.gridColumnEdit.Name = "gridColumnEdit";
            this.gridColumnEdit.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnEdit.OptionsFilter.AllowFilter = false;
            this.gridColumnEdit.Visible = true;
            this.gridColumnEdit.VisibleIndex = 12;
            this.gridColumnEdit.Width = 60;
            // 
            // btnClickViews
            // 
            this.btnClickViews.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnClickViews.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnClickViews.Name = "btnClickViews";
            this.btnClickViews.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnClickViews.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnClickViews_ButtonClick);
            // 
            // gridColumnDoneBy
            // 
            this.gridColumnDoneBy.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnDoneBy.AppearanceCell.Options.UseFont = true;
            this.gridColumnDoneBy.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnDoneBy.AppearanceHeader.Options.UseFont = true;
            this.gridColumnDoneBy.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnDoneBy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDoneBy.Caption = "Người nhận";
            this.gridColumnDoneBy.FieldName = "DoneBy";
            this.gridColumnDoneBy.MinWidth = 120;
            this.gridColumnDoneBy.Name = "gridColumnDoneBy";
            this.gridColumnDoneBy.OptionsColumn.AllowEdit = false;
            this.gridColumnDoneBy.OptionsColumn.AllowFocus = false;
            this.gridColumnDoneBy.Visible = true;
            this.gridColumnDoneBy.VisibleIndex = 11;
            this.gridColumnDoneBy.Width = 120;
            // 
            // gridColumnIsDone
            // 
            this.gridColumnIsDone.Caption = "Đã nhận";
            this.gridColumnIsDone.FieldName = "IsDone";
            this.gridColumnIsDone.Name = "gridColumnIsDone";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnExportExcel.Appearance.Options.UseFont = true;
            this.btnExportExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.ImageOptions.Image")));
            this.btnExportExcel.Location = new System.Drawing.Point(726, 17);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(136, 32);
            this.btnExportExcel.TabIndex = 6;
            this.btnExportExcel.Text = "Xuất Excel";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnTimKiem.Appearance.Options.UseFont = true;
            this.btnTimKiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.ImageOptions.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(592, 17);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(128, 32);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Lọc dữ liệu";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // UCListBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.gridControlData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpStartDate);
            this.Name = "UCListBook";
            this.Size = new System.Drawing.Size(1666, 600);
            this.Load += new System.EventHandler(this.UCGroupTour_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClickViews)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.RadioButton rdBinhThuong;
        private System.Windows.Forms.RadioButton rdDaHuy;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tảiLạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtExcelToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTour;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnService;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPartner;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPickUp;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRoom;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPartnerPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSales;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNote;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDateCreate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnClickViews;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCustomName;
        private DevExpress.XtraEditors.SimpleButton btnExportExcel;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDoneBy;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIsDone;
        private System.Windows.Forms.ToolStripMenuItem đaNhânBookingToolStripMenuItem;
    }
}
