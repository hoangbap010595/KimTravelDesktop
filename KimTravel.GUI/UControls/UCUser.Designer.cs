namespace KimTravel.GUI.UControls
{
    partial class UCUser
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCUser));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUsername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDateCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnLocked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ckEnable = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumnDateLocked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDateUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUpdateBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnClickEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumnDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnClickDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumnRole = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnClickRole = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamMOi = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckEnable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClickEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClickDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClickRole)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlData
            // 
            this.gridControlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlData.Location = new System.Drawing.Point(3, 45);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnClickDelete,
            this.btnClickEdit,
            this.ckEnable,
            this.btnClickRole});
            this.gridControlData.Size = new System.Drawing.Size(1053, 465);
            this.gridControlData.TabIndex = 10;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // gridViewData
            // 
            this.gridViewData.ColumnPanelRowHeight = 35;
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnID,
            this.gridColumnUsername,
            this.gridColumnDateCreate,
            this.gridColumnLocked,
            this.gridColumnDateLocked,
            this.gridColumnStatus,
            this.gridColumnDateUpdate,
            this.gridColumnUpdateBy,
            this.gridColumnEdit,
            this.gridColumnDelete,
            this.gridColumnRole});
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
            this.gridColumnID.FieldName = "ID";
            this.gridColumnID.Name = "gridColumnID";
            // 
            // gridColumnUsername
            // 
            this.gridColumnUsername.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnUsername.AppearanceCell.Options.UseFont = true;
            this.gridColumnUsername.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnUsername.AppearanceHeader.Options.UseFont = true;
            this.gridColumnUsername.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnUsername.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnUsername.Caption = "Username";
            this.gridColumnUsername.FieldName = "Username";
            this.gridColumnUsername.MinWidth = 160;
            this.gridColumnUsername.Name = "gridColumnUsername";
            this.gridColumnUsername.OptionsColumn.AllowEdit = false;
            this.gridColumnUsername.OptionsColumn.ReadOnly = true;
            this.gridColumnUsername.Visible = true;
            this.gridColumnUsername.VisibleIndex = 0;
            this.gridColumnUsername.Width = 160;
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
            this.gridColumnDateCreate.VisibleIndex = 1;
            this.gridColumnDateCreate.Width = 120;
            // 
            // gridColumnLocked
            // 
            this.gridColumnLocked.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.gridColumnLocked.AppearanceCell.Options.UseFont = true;
            this.gridColumnLocked.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnLocked.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnLocked.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnLocked.AppearanceHeader.Options.UseFont = true;
            this.gridColumnLocked.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnLocked.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnLocked.Caption = "Locked";
            this.gridColumnLocked.ColumnEdit = this.ckEnable;
            this.gridColumnLocked.FieldName = "Locked";
            this.gridColumnLocked.MaxWidth = 90;
            this.gridColumnLocked.MinWidth = 90;
            this.gridColumnLocked.Name = "gridColumnLocked";
            this.gridColumnLocked.Visible = true;
            this.gridColumnLocked.VisibleIndex = 2;
            this.gridColumnLocked.Width = 90;
            // 
            // ckEnable
            // 
            this.ckEnable.AutoHeight = false;
            this.ckEnable.Name = "ckEnable";
            this.ckEnable.ReadOnly = true;
            // 
            // gridColumnDateLocked
            // 
            this.gridColumnDateLocked.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnDateLocked.AppearanceCell.Options.UseFont = true;
            this.gridColumnDateLocked.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnDateLocked.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDateLocked.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnDateLocked.AppearanceHeader.Options.UseFont = true;
            this.gridColumnDateLocked.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnDateLocked.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDateLocked.Caption = "Ngày khóa";
            this.gridColumnDateLocked.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.gridColumnDateLocked.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnDateLocked.FieldName = "LockDate";
            this.gridColumnDateLocked.MaxWidth = 120;
            this.gridColumnDateLocked.MinWidth = 120;
            this.gridColumnDateLocked.Name = "gridColumnDateLocked";
            this.gridColumnDateLocked.Visible = true;
            this.gridColumnDateLocked.VisibleIndex = 3;
            this.gridColumnDateLocked.Width = 120;
            // 
            // gridColumnStatus
            // 
            this.gridColumnStatus.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnStatus.AppearanceCell.Options.UseFont = true;
            this.gridColumnStatus.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnStatus.AppearanceHeader.Options.UseFont = true;
            this.gridColumnStatus.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnStatus.Caption = "Trạng thái";
            this.gridColumnStatus.FieldName = "Status";
            this.gridColumnStatus.MaxWidth = 150;
            this.gridColumnStatus.MinWidth = 150;
            this.gridColumnStatus.Name = "gridColumnStatus";
            this.gridColumnStatus.OptionsColumn.AllowEdit = false;
            this.gridColumnStatus.OptionsColumn.ReadOnly = true;
            this.gridColumnStatus.Visible = true;
            this.gridColumnStatus.VisibleIndex = 4;
            this.gridColumnStatus.Width = 150;
            // 
            // gridColumnDateUpdate
            // 
            this.gridColumnDateUpdate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnDateUpdate.AppearanceCell.Options.UseFont = true;
            this.gridColumnDateUpdate.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnDateUpdate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDateUpdate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnDateUpdate.AppearanceHeader.Options.UseFont = true;
            this.gridColumnDateUpdate.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnDateUpdate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDateUpdate.Caption = "Ngày cập nhật";
            this.gridColumnDateUpdate.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.gridColumnDateUpdate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnDateUpdate.FieldName = "LastUpdate";
            this.gridColumnDateUpdate.MaxWidth = 120;
            this.gridColumnDateUpdate.MinWidth = 120;
            this.gridColumnDateUpdate.Name = "gridColumnDateUpdate";
            this.gridColumnDateUpdate.Visible = true;
            this.gridColumnDateUpdate.VisibleIndex = 5;
            this.gridColumnDateUpdate.Width = 120;
            // 
            // gridColumnUpdateBy
            // 
            this.gridColumnUpdateBy.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnUpdateBy.AppearanceCell.Options.UseFont = true;
            this.gridColumnUpdateBy.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnUpdateBy.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumnUpdateBy.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnUpdateBy.AppearanceHeader.Options.UseFont = true;
            this.gridColumnUpdateBy.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnUpdateBy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnUpdateBy.Caption = "Người cập nhật";
            this.gridColumnUpdateBy.FieldName = "UpdateBy";
            this.gridColumnUpdateBy.MaxWidth = 120;
            this.gridColumnUpdateBy.MinWidth = 120;
            this.gridColumnUpdateBy.Name = "gridColumnUpdateBy";
            this.gridColumnUpdateBy.OptionsColumn.AllowEdit = false;
            this.gridColumnUpdateBy.OptionsColumn.ReadOnly = true;
            this.gridColumnUpdateBy.Visible = true;
            this.gridColumnUpdateBy.VisibleIndex = 6;
            this.gridColumnUpdateBy.Width = 120;
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
            this.gridColumnEdit.VisibleIndex = 7;
            this.gridColumnEdit.Width = 60;
            // 
            // btnClickEdit
            // 
            this.btnClickEdit.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnClickEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
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
            this.gridColumnDelete.VisibleIndex = 8;
            this.gridColumnDelete.Width = 60;
            // 
            // btnClickDelete
            // 
            this.btnClickDelete.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnClickDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Xóa", -1, true, true, false, editorButtonImageOptions2)});
            this.btnClickDelete.Name = "btnClickDelete";
            this.btnClickDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnClickDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnClickDelete_ButtonClick);
            // 
            // gridColumnRole
            // 
            this.gridColumnRole.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnRole.AppearanceCell.Options.UseFont = true;
            this.gridColumnRole.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnRole.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnRole.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnRole.AppearanceHeader.Options.UseFont = true;
            this.gridColumnRole.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnRole.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnRole.Caption = "Phân quyền";
            this.gridColumnRole.ColumnEdit = this.btnClickRole;
            this.gridColumnRole.MaxWidth = 90;
            this.gridColumnRole.MinWidth = 90;
            this.gridColumnRole.Name = "gridColumnRole";
            this.gridColumnRole.Visible = true;
            this.gridColumnRole.VisibleIndex = 9;
            this.gridColumnRole.Width = 90;
            // 
            // btnClickRole
            // 
            this.btnClickRole.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.btnClickRole.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions3, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnClickRole.Name = "btnClickRole";
            this.btnClickRole.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnClickRole.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnClickRole_ButtonClick);
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
            this.simpleButton1.TabIndex = 12;
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
            this.btnLamMOi.TabIndex = 11;
            this.btnLamMOi.Text = "Làm mới";
            this.btnLamMOi.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // UCUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnLamMOi);
            this.Controls.Add(this.gridControlData);
            this.Name = "UCUser";
            this.Size = new System.Drawing.Size(1059, 513);
            this.Load += new System.EventHandler(this.UCGroupTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckEnable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClickEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClickDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClickRole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUsername;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnStatus;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUpdateBy;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDateCreate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnLocked;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ckEnable;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnClickEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnClickDelete;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRole;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnClickRole;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDateLocked;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDateUpdate;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnLamMOi;
    }
}
