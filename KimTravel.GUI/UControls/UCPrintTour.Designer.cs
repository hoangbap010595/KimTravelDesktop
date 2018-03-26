namespace KimTravel.GUI.UControls
{
    partial class UCPrintTour
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPrintTour));
            this.label6 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.cbbTourID = new System.Windows.Forms.ComboBox();
            this.cbbGroupTourID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tảiLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnPax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTourName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCarCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnHDV1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnHDV2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDriver1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDriver2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDatePrint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnClickViews = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnExportExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumnTourID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ckViewAllPartner = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
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
            this.label6.Location = new System.Drawing.Point(500, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày đi";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.CustomFormat = "dd-MM-yyyy";
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(503, 25);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(133, 23);
            this.dtpStartDate.TabIndex = 4;
            // 
            // cbbTourID
            // 
            this.cbbTourID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTourID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTourID.FormattingEnabled = true;
            this.cbbTourID.ItemHeight = 16;
            this.cbbTourID.Location = new System.Drawing.Point(193, 25);
            this.cbbTourID.Name = "cbbTourID";
            this.cbbTourID.Size = new System.Drawing.Size(164, 24);
            this.cbbTourID.TabIndex = 2;
            // 
            // cbbGroupTourID
            // 
            this.cbbGroupTourID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGroupTourID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGroupTourID.FormattingEnabled = true;
            this.cbbGroupTourID.ItemHeight = 16;
            this.cbbGroupTourID.Location = new System.Drawing.Point(13, 25);
            this.cbbGroupTourID.Name = "cbbGroupTourID";
            this.cbbGroupTourID.Size = new System.Drawing.Size(164, 24);
            this.cbbGroupTourID.TabIndex = 1;
            this.cbbGroupTourID.SelectedIndexChanged += new System.EventHandler(this.cbbGroupTourID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn nhóm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(190, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chọn tour";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tảiLạiToolStripMenuItem,
            this.xuấtExcelToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 48);
            // 
            // tảiLạiToolStripMenuItem
            // 
            this.tảiLạiToolStripMenuItem.Name = "tảiLạiToolStripMenuItem";
            this.tảiLạiToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.tảiLạiToolStripMenuItem.Text = "Tải lại";
            this.tảiLạiToolStripMenuItem.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // xuấtExcelToolStripMenuItem
            // 
            this.xuấtExcelToolStripMenuItem.Name = "xuấtExcelToolStripMenuItem";
            this.xuấtExcelToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.xuấtExcelToolStripMenuItem.Text = "Xuất Excel";
            this.xuấtExcelToolStripMenuItem.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // gridControlData
            // 
            this.gridControlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlData.Location = new System.Drawing.Point(3, 56);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnClickViews});
            this.gridControlData.Size = new System.Drawing.Size(1278, 454);
            this.gridControlData.TabIndex = 10;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // gridViewData
            // 
            this.gridViewData.ColumnPanelRowHeight = 35;
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnPax,
            this.gridColumnTourID,
            this.gridColumnID,
            this.gridColumnTourName,
            this.gridColumnStartDate,
            this.gridColumnCarCode,
            this.gridColumnHDV1,
            this.gridColumnHDV2,
            this.gridColumnDriver1,
            this.gridColumnDriver2,
            this.gridColumnDatePrint,
            this.gridColumnEdit});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.IndicatorWidth = 35;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsCustomization.AllowColumnMoving = false;
            this.gridViewData.OptionsView.ShowAutoFilterRow = true;
            this.gridViewData.OptionsView.ShowGroupPanel = false;
            this.gridViewData.RowHeight = 25;
            // 
            // gridColumnPax
            // 
            this.gridColumnPax.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnPax.AppearanceCell.Options.UseFont = true;
            this.gridColumnPax.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnPax.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPax.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnPax.AppearanceHeader.Options.UseFont = true;
            this.gridColumnPax.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnPax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPax.Caption = "Pax";
            this.gridColumnPax.FieldName = "TotalPax";
            this.gridColumnPax.MaxWidth = 60;
            this.gridColumnPax.MinWidth = 60;
            this.gridColumnPax.Name = "gridColumnPax";
            this.gridColumnPax.Visible = true;
            this.gridColumnPax.VisibleIndex = 0;
            this.gridColumnPax.Width = 60;
            // 
            // gridColumnID
            // 
            this.gridColumnID.Caption = "ID";
            this.gridColumnID.FieldName = "ID";
            this.gridColumnID.Name = "gridColumnID";
            // 
            // gridColumnTourName
            // 
            this.gridColumnTourName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnTourName.AppearanceCell.Options.UseFont = true;
            this.gridColumnTourName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnTourName.AppearanceHeader.Options.UseFont = true;
            this.gridColumnTourName.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnTourName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnTourName.Caption = "Tour";
            this.gridColumnTourName.FieldName = "Name";
            this.gridColumnTourName.MinWidth = 150;
            this.gridColumnTourName.Name = "gridColumnTourName";
            this.gridColumnTourName.Visible = true;
            this.gridColumnTourName.VisibleIndex = 1;
            this.gridColumnTourName.Width = 150;
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
            this.gridColumnStartDate.FieldName = "DateStart";
            this.gridColumnStartDate.MaxWidth = 120;
            this.gridColumnStartDate.MinWidth = 120;
            this.gridColumnStartDate.Name = "gridColumnStartDate";
            this.gridColumnStartDate.Visible = true;
            this.gridColumnStartDate.VisibleIndex = 2;
            this.gridColumnStartDate.Width = 120;
            // 
            // gridColumnCarCode
            // 
            this.gridColumnCarCode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnCarCode.AppearanceCell.Options.UseFont = true;
            this.gridColumnCarCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnCarCode.AppearanceHeader.Options.UseFont = true;
            this.gridColumnCarCode.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnCarCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnCarCode.Caption = "Số xe";
            this.gridColumnCarCode.FieldName = "CarCode";
            this.gridColumnCarCode.MaxWidth = 120;
            this.gridColumnCarCode.MinWidth = 120;
            this.gridColumnCarCode.Name = "gridColumnCarCode";
            this.gridColumnCarCode.Visible = true;
            this.gridColumnCarCode.VisibleIndex = 3;
            this.gridColumnCarCode.Width = 120;
            // 
            // gridColumnHDV1
            // 
            this.gridColumnHDV1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnHDV1.AppearanceCell.Options.UseFont = true;
            this.gridColumnHDV1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnHDV1.AppearanceHeader.Options.UseFont = true;
            this.gridColumnHDV1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnHDV1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnHDV1.Caption = "HDV 1";
            this.gridColumnHDV1.FieldName = "GuideName1";
            this.gridColumnHDV1.MinWidth = 120;
            this.gridColumnHDV1.Name = "gridColumnHDV1";
            this.gridColumnHDV1.Visible = true;
            this.gridColumnHDV1.VisibleIndex = 4;
            this.gridColumnHDV1.Width = 120;
            // 
            // gridColumnHDV2
            // 
            this.gridColumnHDV2.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnHDV2.AppearanceCell.Options.UseFont = true;
            this.gridColumnHDV2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnHDV2.AppearanceHeader.Options.UseFont = true;
            this.gridColumnHDV2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnHDV2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnHDV2.Caption = "HDV 2";
            this.gridColumnHDV2.FieldName = "Guide2";
            this.gridColumnHDV2.MinWidth = 120;
            this.gridColumnHDV2.Name = "gridColumnHDV2";
            this.gridColumnHDV2.OptionsColumn.AllowEdit = false;
            this.gridColumnHDV2.OptionsColumn.ReadOnly = true;
            this.gridColumnHDV2.Visible = true;
            this.gridColumnHDV2.VisibleIndex = 5;
            this.gridColumnHDV2.Width = 160;
            // 
            // gridColumnDriver1
            // 
            this.gridColumnDriver1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnDriver1.AppearanceCell.Options.UseFont = true;
            this.gridColumnDriver1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnDriver1.AppearanceHeader.Options.UseFont = true;
            this.gridColumnDriver1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnDriver1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDriver1.Caption = "Tài xế 1";
            this.gridColumnDriver1.FieldName = "DriverName1";
            this.gridColumnDriver1.MinWidth = 120;
            this.gridColumnDriver1.Name = "gridColumnDriver1";
            this.gridColumnDriver1.Visible = true;
            this.gridColumnDriver1.VisibleIndex = 6;
            this.gridColumnDriver1.Width = 120;
            // 
            // gridColumnDriver2
            // 
            this.gridColumnDriver2.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnDriver2.AppearanceCell.Options.UseFont = true;
            this.gridColumnDriver2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnDriver2.AppearanceHeader.Options.UseFont = true;
            this.gridColumnDriver2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnDriver2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDriver2.Caption = "Tài xế 2";
            this.gridColumnDriver2.FieldName = "Driver2";
            this.gridColumnDriver2.MinWidth = 120;
            this.gridColumnDriver2.Name = "gridColumnDriver2";
            this.gridColumnDriver2.Visible = true;
            this.gridColumnDriver2.VisibleIndex = 7;
            this.gridColumnDriver2.Width = 120;
            // 
            // gridColumnDatePrint
            // 
            this.gridColumnDatePrint.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnDatePrint.AppearanceCell.Options.UseFont = true;
            this.gridColumnDatePrint.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnDatePrint.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDatePrint.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnDatePrint.AppearanceHeader.Options.UseFont = true;
            this.gridColumnDatePrint.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnDatePrint.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDatePrint.Caption = "Ngày In";
            this.gridColumnDatePrint.DisplayFormat.FormatString = "dd-MM-yyyy HH:mm";
            this.gridColumnDatePrint.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnDatePrint.FieldName = "DatePrint";
            this.gridColumnDatePrint.MaxWidth = 150;
            this.gridColumnDatePrint.MinWidth = 150;
            this.gridColumnDatePrint.Name = "gridColumnDatePrint";
            this.gridColumnDatePrint.OptionsColumn.AllowEdit = false;
            this.gridColumnDatePrint.OptionsColumn.ReadOnly = true;
            this.gridColumnDatePrint.Visible = true;
            this.gridColumnDatePrint.VisibleIndex = 8;
            this.gridColumnDatePrint.Width = 150;
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
            this.gridColumnEdit.VisibleIndex = 9;
            this.gridColumnEdit.Width = 60;
            // 
            // btnClickViews
            // 
            this.btnClickViews.AutoHeight = false;
            editorButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions4.Image")));
            this.btnClickViews.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions4, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnClickViews.Name = "btnClickViews";
            this.btnClickViews.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnClickViews.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnClickViews_ButtonClick);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnExportExcel.Appearance.Options.UseFont = true;
            this.btnExportExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.ImageOptions.Image")));
            this.btnExportExcel.Location = new System.Drawing.Point(768, 17);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(114, 32);
            this.btnExportExcel.TabIndex = 6;
            this.btnExportExcel.Text = "Xuất Excel";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnTimKiem.Appearance.Options.UseFont = true;
            this.btnTimKiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.ImageOptions.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(648, 17);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(114, 32);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // gridColumnTourID
            // 
            this.gridColumnTourID.Caption = "TourID";
            this.gridColumnTourID.FieldName = "TourID";
            this.gridColumnTourID.Name = "gridColumnTourID";
            // 
            // ckViewAllPartner
            // 
            this.ckViewAllPartner.AutoSize = true;
            this.ckViewAllPartner.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ckViewAllPartner.Location = new System.Drawing.Point(374, 25);
            this.ckViewAllPartner.Name = "ckViewAllPartner";
            this.ckViewAllPartner.Size = new System.Drawing.Size(93, 21);
            this.ckViewAllPartner.TabIndex = 3;
            this.ckViewAllPartner.Text = "Xem tất cả";
            this.ckViewAllPartner.UseVisualStyleBackColor = true;
            // 
            // UCPrintTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ckViewAllPartner);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.gridControlData);
            this.Controls.Add(this.cbbTourID);
            this.Controls.Add(this.cbbGroupTourID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpStartDate);
            this.Name = "UCPrintTour";
            this.Size = new System.Drawing.Size(1284, 513);
            this.Load += new System.EventHandler(this.UCGroupTour_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClickViews)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.ComboBox cbbTourID;
        private System.Windows.Forms.ComboBox cbbGroupTourID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tảiLạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtExcelToolStripMenuItem;
        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTourName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCarCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnHDV1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnHDV2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDatePrint;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnClickViews;
        private DevExpress.XtraEditors.SimpleButton btnExportExcel;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDriver1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDriver2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPax;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTourID;
        private System.Windows.Forms.CheckBox ckViewAllPartner;
    }
}
