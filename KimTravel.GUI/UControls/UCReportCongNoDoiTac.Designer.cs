namespace KimTravel.GUI.UControls
{
    partial class UCReportCongNoDoiTac
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCReportCongNoDoiTac));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.cbbMonth = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tảiLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbbYear = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPartner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSLTour = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPriceNotPayment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPricePayment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnClickIn = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumnDetails = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnViewDetails = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClickIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnViewDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbMonth
            // 
            this.cbbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMonth.FormattingEnabled = true;
            this.cbbMonth.ItemHeight = 16;
            this.cbbMonth.Location = new System.Drawing.Point(12, 33);
            this.cbbMonth.Name = "cbbMonth";
            this.cbbMonth.Size = new System.Drawing.Size(81, 24);
            this.cbbMonth.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(9, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tháng:";
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
            // cbbYear
            // 
            this.cbbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbYear.FormattingEnabled = true;
            this.cbbYear.ItemHeight = 16;
            this.cbbYear.Location = new System.Drawing.Point(99, 33);
            this.cbbYear.Name = "cbbYear";
            this.cbbYear.Size = new System.Drawing.Size(81, 24);
            this.cbbYear.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(96, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Năm:";
            // 
            // gridControlData
            // 
            this.gridControlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlData.Location = new System.Drawing.Point(186, 3);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnClickIn,
            this.btnViewDetails});
            this.gridControlData.Size = new System.Drawing.Size(870, 507);
            this.gridControlData.TabIndex = 11;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // gridViewData
            // 
            this.gridViewData.ColumnPanelRowHeight = 35;
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnID,
            this.gridColumnPartner,
            this.gridColumnSLTour,
            this.gridColumnPriceNotPayment,
            this.gridColumnPricePayment,
            this.gridColumnEdit,
            this.gridColumnDetails});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.IndicatorWidth = 35;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsCustomization.AllowColumnMoving = false;
            this.gridViewData.OptionsView.ShowAutoFilterRow = true;
            this.gridViewData.OptionsView.ShowFooter = true;
            this.gridViewData.OptionsView.ShowGroupPanel = false;
            this.gridViewData.RowHeight = 25;
            // 
            // gridColumnID
            // 
            this.gridColumnID.Caption = "ID";
            this.gridColumnID.FieldName = "ID";
            this.gridColumnID.Name = "gridColumnID";
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
            this.gridColumnPartner.FieldName = "PartnerName";
            this.gridColumnPartner.MinWidth = 180;
            this.gridColumnPartner.Name = "gridColumnPartner";
            this.gridColumnPartner.OptionsColumn.AllowEdit = false;
            this.gridColumnPartner.OptionsColumn.AllowFocus = false;
            this.gridColumnPartner.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "PartnerName", "Tổng: {0}")});
            this.gridColumnPartner.Visible = true;
            this.gridColumnPartner.VisibleIndex = 0;
            this.gridColumnPartner.Width = 180;
            // 
            // gridColumnSLTour
            // 
            this.gridColumnSLTour.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnSLTour.AppearanceCell.Options.UseFont = true;
            this.gridColumnSLTour.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnSLTour.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnSLTour.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnSLTour.AppearanceHeader.Options.UseFont = true;
            this.gridColumnSLTour.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnSLTour.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnSLTour.Caption = "Tổng SL Khách";
            this.gridColumnSLTour.DisplayFormat.FormatString = "#,###";
            this.gridColumnSLTour.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnSLTour.FieldName = "CountPax";
            this.gridColumnSLTour.MaxWidth = 120;
            this.gridColumnSLTour.MinWidth = 120;
            this.gridColumnSLTour.Name = "gridColumnSLTour";
            this.gridColumnSLTour.OptionsColumn.AllowEdit = false;
            this.gridColumnSLTour.OptionsColumn.AllowFocus = false;
            this.gridColumnSLTour.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CountPax", "{0:#,###}")});
            this.gridColumnSLTour.Visible = true;
            this.gridColumnSLTour.VisibleIndex = 1;
            this.gridColumnSLTour.Width = 120;
            // 
            // gridColumnPriceNotPayment
            // 
            this.gridColumnPriceNotPayment.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnPriceNotPayment.AppearanceCell.Options.UseFont = true;
            this.gridColumnPriceNotPayment.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnPriceNotPayment.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumnPriceNotPayment.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnPriceNotPayment.AppearanceHeader.Options.UseFont = true;
            this.gridColumnPriceNotPayment.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnPriceNotPayment.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPriceNotPayment.Caption = "Chưa thanh toán";
            this.gridColumnPriceNotPayment.DisplayFormat.FormatString = "#,###";
            this.gridColumnPriceNotPayment.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnPriceNotPayment.FieldName = "NotPayment";
            this.gridColumnPriceNotPayment.MaxWidth = 150;
            this.gridColumnPriceNotPayment.MinWidth = 150;
            this.gridColumnPriceNotPayment.Name = "gridColumnPriceNotPayment";
            this.gridColumnPriceNotPayment.OptionsColumn.AllowEdit = false;
            this.gridColumnPriceNotPayment.OptionsColumn.AllowFocus = false;
            this.gridColumnPriceNotPayment.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NotPayment", "{0:#,###}")});
            this.gridColumnPriceNotPayment.Visible = true;
            this.gridColumnPriceNotPayment.VisibleIndex = 2;
            this.gridColumnPriceNotPayment.Width = 150;
            // 
            // gridColumnPricePayment
            // 
            this.gridColumnPricePayment.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnPricePayment.AppearanceCell.Options.UseFont = true;
            this.gridColumnPricePayment.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnPricePayment.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumnPricePayment.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnPricePayment.AppearanceHeader.Options.UseFont = true;
            this.gridColumnPricePayment.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnPricePayment.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPricePayment.Caption = "Đã thanh toán";
            this.gridColumnPricePayment.DisplayFormat.FormatString = "#,###";
            this.gridColumnPricePayment.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnPricePayment.FieldName = "Payment";
            this.gridColumnPricePayment.MaxWidth = 150;
            this.gridColumnPricePayment.MinWidth = 150;
            this.gridColumnPricePayment.Name = "gridColumnPricePayment";
            this.gridColumnPricePayment.OptionsColumn.AllowEdit = false;
            this.gridColumnPricePayment.OptionsColumn.AllowFocus = false;
            this.gridColumnPricePayment.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Payment", "{0:#,###}")});
            this.gridColumnPricePayment.Visible = true;
            this.gridColumnPricePayment.VisibleIndex = 3;
            this.gridColumnPricePayment.Width = 150;
            // 
            // gridColumnEdit
            // 
            this.gridColumnEdit.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnEdit.AppearanceHeader.Options.UseFont = true;
            this.gridColumnEdit.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnEdit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnEdit.Caption = "In";
            this.gridColumnEdit.ColumnEdit = this.btnClickIn;
            this.gridColumnEdit.MaxWidth = 100;
            this.gridColumnEdit.MinWidth = 100;
            this.gridColumnEdit.Name = "gridColumnEdit";
            this.gridColumnEdit.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnEdit.OptionsFilter.AllowFilter = false;
            this.gridColumnEdit.Visible = true;
            this.gridColumnEdit.VisibleIndex = 4;
            this.gridColumnEdit.Width = 100;
            // 
            // btnClickIn
            // 
            this.btnClickIn.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnClickIn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnClickIn.Name = "btnClickIn";
            this.btnClickIn.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnClickIn.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnClickIn_ButtonClick);
            // 
            // gridColumnDetails
            // 
            this.gridColumnDetails.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnDetails.AppearanceHeader.Options.UseFont = true;
            this.gridColumnDetails.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnDetails.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDetails.Caption = "Chi tiết";
            this.gridColumnDetails.ColumnEdit = this.btnViewDetails;
            this.gridColumnDetails.MaxWidth = 100;
            this.gridColumnDetails.MinWidth = 100;
            this.gridColumnDetails.Name = "gridColumnDetails";
            this.gridColumnDetails.Visible = true;
            this.gridColumnDetails.VisibleIndex = 5;
            this.gridColumnDetails.Width = 100;
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnViewDetails.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions2, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnViewDetails.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnViewDetails_ButtonClick);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 115);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(168, 32);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Xuất Excel";
            this.simpleButton1.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnTimKiem.Appearance.Options.UseFont = true;
            this.btnTimKiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.ImageOptions.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(12, 77);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(168, 32);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Lọc dữ liệu";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // UCReportCongNoDoiTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.gridControlData);
            this.Controls.Add(this.cbbYear);
            this.Controls.Add(this.cbbMonth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "UCReportCongNoDoiTac";
            this.Size = new System.Drawing.Size(1059, 513);
            this.Load += new System.EventHandler(this.UCGroupTour_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClickIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnViewDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tảiLạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtExcelToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbbYear;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPartner;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSLTour;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPricePayment;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnClickIn;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPriceNotPayment;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDetails;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnViewDetails;
    }
}
