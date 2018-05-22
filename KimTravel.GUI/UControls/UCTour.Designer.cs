namespace KimTravel.GUI.UControls
{
    partial class UCTour
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions7 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCTour));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions8 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.cbbGroupTour = new System.Windows.Forms.ComboBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPriceChild = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPriceSale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPriceVTQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDateCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMaxPax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEnable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ckEnable = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumnEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnClickEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumnDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnClickDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamMOi = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumnMinPax = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckEnable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClickEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClickDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbGroupTour
            // 
            this.cbbGroupTour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbbGroupTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGroupTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGroupTour.FormattingEnabled = true;
            this.cbbGroupTour.ItemHeight = 20;
            this.cbbGroupTour.Location = new System.Drawing.Point(70, 11);
            this.cbbGroupTour.Name = "cbbGroupTour";
            this.cbbGroupTour.Size = new System.Drawing.Size(239, 28);
            this.cbbGroupTour.TabIndex = 1;
            this.cbbGroupTour.SelectedIndexChanged += new System.EventHandler(this.cbbGroupTour_SelectedIndexChanged);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(10, 15);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(54, 19);
            this.materialLabel6.TabIndex = 0;
            this.materialLabel6.Text = "Nhóm:";
            // 
            // gridControlData
            // 
            this.gridControlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlData.Location = new System.Drawing.Point(3, 42);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnClickDelete,
            this.btnClickEdit,
            this.ckEnable});
            this.gridControlData.Size = new System.Drawing.Size(1053, 468);
            this.gridControlData.TabIndex = 9;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // gridViewData
            // 
            this.gridViewData.ColumnPanelRowHeight = 35;
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnID,
            this.gridColumnName,
            this.gridColumnPriceChild,
            this.gridColumnPriceSale,
            this.gridColumnPriceVTQ,
            this.gridColumnDateCreate,
            this.gridColumnMinPax,
            this.gridColumnMaxPax,
            this.gridColumnEnable,
            this.gridColumnEdit,
            this.gridColumnDelete});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.IndicatorWidth = 35;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsCustomization.AllowColumnMoving = false;
            this.gridViewData.OptionsView.ShowAutoFilterRow = true;
            this.gridViewData.OptionsView.ShowGroupPanel = false;
            this.gridViewData.RowHeight = 25;
            // 
            // gridColumnID
            // 
            this.gridColumnID.Caption = "ID";
            this.gridColumnID.FieldName = "TourID";
            this.gridColumnID.Name = "gridColumnID";
            // 
            // gridColumnName
            // 
            this.gridColumnName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnName.AppearanceCell.Options.UseFont = true;
            this.gridColumnName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnName.AppearanceHeader.Options.UseFont = true;
            this.gridColumnName.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnName.Caption = "Tour";
            this.gridColumnName.FieldName = "Name";
            this.gridColumnName.MinWidth = 160;
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.OptionsColumn.AllowEdit = false;
            this.gridColumnName.OptionsColumn.ReadOnly = true;
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 0;
            this.gridColumnName.Width = 160;
            // 
            // gridColumnPriceChild
            // 
            this.gridColumnPriceChild.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnPriceChild.AppearanceCell.Options.UseFont = true;
            this.gridColumnPriceChild.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnPriceChild.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumnPriceChild.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnPriceChild.AppearanceHeader.Options.UseFont = true;
            this.gridColumnPriceChild.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnPriceChild.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPriceChild.Caption = "Giá bán trẻ em";
            this.gridColumnPriceChild.DisplayFormat.FormatString = "#,###";
            this.gridColumnPriceChild.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnPriceChild.FieldName = "PriceSaleChild";
            this.gridColumnPriceChild.MaxWidth = 120;
            this.gridColumnPriceChild.MinWidth = 120;
            this.gridColumnPriceChild.Name = "gridColumnPriceChild";
            this.gridColumnPriceChild.Visible = true;
            this.gridColumnPriceChild.VisibleIndex = 2;
            this.gridColumnPriceChild.Width = 120;
            // 
            // gridColumnPriceSale
            // 
            this.gridColumnPriceSale.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnPriceSale.AppearanceCell.Options.UseFont = true;
            this.gridColumnPriceSale.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnPriceSale.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumnPriceSale.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnPriceSale.AppearanceHeader.Options.UseFont = true;
            this.gridColumnPriceSale.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnPriceSale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPriceSale.Caption = "Giá bán người lớn";
            this.gridColumnPriceSale.DisplayFormat.FormatString = "#,###";
            this.gridColumnPriceSale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnPriceSale.FieldName = "PriceSale";
            this.gridColumnPriceSale.MaxWidth = 140;
            this.gridColumnPriceSale.MinWidth = 140;
            this.gridColumnPriceSale.Name = "gridColumnPriceSale";
            this.gridColumnPriceSale.OptionsColumn.AllowEdit = false;
            this.gridColumnPriceSale.OptionsColumn.ReadOnly = true;
            this.gridColumnPriceSale.Visible = true;
            this.gridColumnPriceSale.VisibleIndex = 1;
            this.gridColumnPriceSale.Width = 140;
            // 
            // gridColumnPriceVTQ
            // 
            this.gridColumnPriceVTQ.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnPriceVTQ.AppearanceCell.Options.UseFont = true;
            this.gridColumnPriceVTQ.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnPriceVTQ.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumnPriceVTQ.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnPriceVTQ.AppearanceHeader.Options.UseFont = true;
            this.gridColumnPriceVTQ.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnPriceVTQ.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPriceVTQ.Caption = "Giá VTQ";
            this.gridColumnPriceVTQ.DisplayFormat.FormatString = "#,###";
            this.gridColumnPriceVTQ.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnPriceVTQ.FieldName = "PriceVTQ";
            this.gridColumnPriceVTQ.MaxWidth = 130;
            this.gridColumnPriceVTQ.MinWidth = 130;
            this.gridColumnPriceVTQ.Name = "gridColumnPriceVTQ";
            this.gridColumnPriceVTQ.OptionsColumn.AllowEdit = false;
            this.gridColumnPriceVTQ.OptionsColumn.ReadOnly = true;
            this.gridColumnPriceVTQ.Visible = true;
            this.gridColumnPriceVTQ.VisibleIndex = 3;
            this.gridColumnPriceVTQ.Width = 130;
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
            this.gridColumnDateCreate.Caption = "Ngày tạo";
            this.gridColumnDateCreate.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.gridColumnDateCreate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnDateCreate.FieldName = "DateCreate";
            this.gridColumnDateCreate.MaxWidth = 120;
            this.gridColumnDateCreate.MinWidth = 120;
            this.gridColumnDateCreate.Name = "gridColumnDateCreate";
            this.gridColumnDateCreate.OptionsColumn.AllowEdit = false;
            this.gridColumnDateCreate.OptionsColumn.ReadOnly = true;
            this.gridColumnDateCreate.Visible = true;
            this.gridColumnDateCreate.VisibleIndex = 6;
            this.gridColumnDateCreate.Width = 120;
            // 
            // gridColumnMaxPax
            // 
            this.gridColumnMaxPax.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnMaxPax.AppearanceCell.Options.UseFont = true;
            this.gridColumnMaxPax.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnMaxPax.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnMaxPax.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnMaxPax.AppearanceHeader.Options.UseFont = true;
            this.gridColumnMaxPax.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnMaxPax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnMaxPax.Caption = "Max Pax";
            this.gridColumnMaxPax.DisplayFormat.FormatString = "#,###";
            this.gridColumnMaxPax.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnMaxPax.FieldName = "MaxPax";
            this.gridColumnMaxPax.MaxWidth = 65;
            this.gridColumnMaxPax.MinWidth = 65;
            this.gridColumnMaxPax.Name = "gridColumnMaxPax";
            this.gridColumnMaxPax.Visible = true;
            this.gridColumnMaxPax.VisibleIndex = 5;
            this.gridColumnMaxPax.Width = 65;
            // 
            // gridColumnEnable
            // 
            this.gridColumnEnable.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.gridColumnEnable.AppearanceCell.Options.UseFont = true;
            this.gridColumnEnable.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnEnable.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnEnable.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnEnable.AppearanceHeader.Options.UseFont = true;
            this.gridColumnEnable.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnEnable.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnEnable.Caption = "Kích hoạt";
            this.gridColumnEnable.ColumnEdit = this.ckEnable;
            this.gridColumnEnable.FieldName = "Enable";
            this.gridColumnEnable.MaxWidth = 90;
            this.gridColumnEnable.MinWidth = 90;
            this.gridColumnEnable.Name = "gridColumnEnable";
            this.gridColumnEnable.Visible = true;
            this.gridColumnEnable.VisibleIndex = 7;
            this.gridColumnEnable.Width = 90;
            // 
            // ckEnable
            // 
            this.ckEnable.AutoHeight = false;
            this.ckEnable.Name = "ckEnable";
            this.ckEnable.ReadOnly = true;
            // 
            // gridColumnEdit
            // 
            this.gridColumnEdit.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnEdit.AppearanceHeader.Options.UseFont = true;
            this.gridColumnEdit.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnEdit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnEdit.Caption = "Sửa";
            this.gridColumnEdit.ColumnEdit = this.btnClickEdit;
            this.gridColumnEdit.MaxWidth = 60;
            this.gridColumnEdit.MinWidth = 60;
            this.gridColumnEdit.Name = "gridColumnEdit";
            this.gridColumnEdit.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnEdit.OptionsFilter.AllowFilter = false;
            this.gridColumnEdit.Visible = true;
            this.gridColumnEdit.VisibleIndex = 8;
            this.gridColumnEdit.Width = 60;
            // 
            // btnClickEdit
            // 
            this.btnClickEdit.AutoHeight = false;
            editorButtonImageOptions7.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions7.Image")));
            this.btnClickEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions7, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnClickEdit.Name = "btnClickEdit";
            this.btnClickEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnClickEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnClickEdit_ButtonClick);
            // 
            // gridColumnDelete
            // 
            this.gridColumnDelete.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridColumnDelete.AppearanceCell.Options.UseFont = true;
            this.gridColumnDelete.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnDelete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDelete.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnDelete.AppearanceHeader.Options.UseFont = true;
            this.gridColumnDelete.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnDelete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDelete.Caption = "Xóa";
            this.gridColumnDelete.ColumnEdit = this.btnClickDelete;
            this.gridColumnDelete.CustomizationCaption = "Xóa";
            this.gridColumnDelete.MaxWidth = 60;
            this.gridColumnDelete.MinWidth = 60;
            this.gridColumnDelete.Name = "gridColumnDelete";
            this.gridColumnDelete.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnDelete.OptionsFilter.AllowFilter = false;
            this.gridColumnDelete.Visible = true;
            this.gridColumnDelete.VisibleIndex = 9;
            this.gridColumnDelete.Width = 60;
            // 
            // btnClickDelete
            // 
            this.btnClickDelete.AutoHeight = false;
            editorButtonImageOptions8.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions8.Image")));
            this.btnClickDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Xóa", -1, true, true, false, editorButtonImageOptions8)});
            this.btnClickDelete.Name = "btnClickDelete";
            this.btnClickDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnClickDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnClickDelete_ButtonClick);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(942, 7);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(114, 32);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Thêm mới";
            this.simpleButton1.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnLamMOi
            // 
            this.btnLamMOi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMOi.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnLamMOi.Appearance.Options.UseFont = true;
            this.btnLamMOi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMOi.ImageOptions.Image")));
            this.btnLamMOi.Location = new System.Drawing.Point(822, 7);
            this.btnLamMOi.Name = "btnLamMOi";
            this.btnLamMOi.Size = new System.Drawing.Size(114, 32);
            this.btnLamMOi.TabIndex = 2;
            this.btnLamMOi.Text = "Làm mới";
            this.btnLamMOi.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // gridColumnMinPax
            // 
            this.gridColumnMinPax.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnMinPax.AppearanceCell.Options.UseFont = true;
            this.gridColumnMinPax.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnMinPax.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnMinPax.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnMinPax.AppearanceHeader.Options.UseFont = true;
            this.gridColumnMinPax.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnMinPax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnMinPax.Caption = "Min Pax";
            this.gridColumnMinPax.DisplayFormat.FormatString = "#,###";
            this.gridColumnMinPax.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumnMinPax.FieldName = "MinPax";
            this.gridColumnMinPax.MaxWidth = 65;
            this.gridColumnMinPax.MinWidth = 65;
            this.gridColumnMinPax.Name = "gridColumnMinPax";
            this.gridColumnMinPax.Visible = true;
            this.gridColumnMinPax.VisibleIndex = 4;
            this.gridColumnMinPax.Width = 65;
            // 
            // UCTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnLamMOi);
            this.Controls.Add(this.gridControlData);
            this.Controls.Add(this.cbbGroupTour);
            this.Controls.Add(this.materialLabel6);
            this.Name = "UCTour";
            this.Size = new System.Drawing.Size(1059, 513);
            this.Load += new System.EventHandler(this.UCGroupTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckEnable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClickEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClickDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbGroupTour;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPriceSale;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPriceVTQ;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDateCreate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEnable;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ckEnable;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnClickEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnClickDelete;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnLamMOi;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPriceChild;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMaxPax;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMinPax;
    }
}
