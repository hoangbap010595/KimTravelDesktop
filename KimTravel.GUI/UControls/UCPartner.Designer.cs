namespace KimTravel.GUI.UControls
{
    partial class UCPartner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPartner));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnGroupName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPartnerCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnClickEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumnDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnClickDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamMOi = new DevExpress.XtraEditors.SimpleButton();
            this.bntImport = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClickEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClickDelete)).BeginInit();
            this.SuspendLayout();
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
            this.btnClickEdit});
            this.gridControlData.Size = new System.Drawing.Size(1603, 468);
            this.gridControlData.TabIndex = 6;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // gridViewData
            // 
            this.gridViewData.ColumnPanelRowHeight = 35;
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnID,
            this.gridColumnGroupName,
            this.gridColumnPartnerCode,
            this.gridColumnName,
            this.gridColumnAddress,
            this.gridColumnPhone,
            this.gridColumnStatus,
            this.gridColumnNote,
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
            this.gridColumnID.FieldName = "PartnerID";
            this.gridColumnID.Name = "gridColumnID";
            // 
            // gridColumnGroupName
            // 
            this.gridColumnGroupName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnGroupName.AppearanceCell.Options.UseFont = true;
            this.gridColumnGroupName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnGroupName.AppearanceHeader.Options.UseFont = true;
            this.gridColumnGroupName.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnGroupName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnGroupName.Caption = "Nhóm";
            this.gridColumnGroupName.FieldName = "GroupName";
            this.gridColumnGroupName.MinWidth = 160;
            this.gridColumnGroupName.Name = "gridColumnGroupName";
            this.gridColumnGroupName.OptionsColumn.AllowEdit = false;
            this.gridColumnGroupName.OptionsColumn.ReadOnly = true;
            this.gridColumnGroupName.Visible = true;
            this.gridColumnGroupName.VisibleIndex = 0;
            this.gridColumnGroupName.Width = 160;
            // 
            // gridColumnPartnerCode
            // 
            this.gridColumnPartnerCode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnPartnerCode.AppearanceCell.Options.UseFont = true;
            this.gridColumnPartnerCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnPartnerCode.AppearanceHeader.Options.UseFont = true;
            this.gridColumnPartnerCode.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnPartnerCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPartnerCode.Caption = "Mã đối tác";
            this.gridColumnPartnerCode.FieldName = "PartnerCode";
            this.gridColumnPartnerCode.MaxWidth = 150;
            this.gridColumnPartnerCode.MinWidth = 150;
            this.gridColumnPartnerCode.Name = "gridColumnPartnerCode";
            this.gridColumnPartnerCode.OptionsColumn.AllowEdit = false;
            this.gridColumnPartnerCode.OptionsColumn.ReadOnly = true;
            this.gridColumnPartnerCode.Visible = true;
            this.gridColumnPartnerCode.VisibleIndex = 1;
            this.gridColumnPartnerCode.Width = 150;
            // 
            // gridColumnName
            // 
            this.gridColumnName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnName.AppearanceCell.Options.UseFont = true;
            this.gridColumnName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnName.AppearanceHeader.Options.UseFont = true;
            this.gridColumnName.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnName.Caption = "Tên đối tác";
            this.gridColumnName.FieldName = "Name";
            this.gridColumnName.MinWidth = 170;
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.OptionsColumn.AllowEdit = false;
            this.gridColumnName.OptionsColumn.ReadOnly = true;
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 2;
            this.gridColumnName.Width = 170;
            // 
            // gridColumnAddress
            // 
            this.gridColumnAddress.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnAddress.AppearanceCell.Options.UseFont = true;
            this.gridColumnAddress.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnAddress.AppearanceHeader.Options.UseFont = true;
            this.gridColumnAddress.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnAddress.Caption = "Địa chỉ";
            this.gridColumnAddress.FieldName = "Address2";
            this.gridColumnAddress.MinWidth = 200;
            this.gridColumnAddress.Name = "gridColumnAddress";
            this.gridColumnAddress.OptionsColumn.AllowEdit = false;
            this.gridColumnAddress.OptionsColumn.ReadOnly = true;
            this.gridColumnAddress.Visible = true;
            this.gridColumnAddress.VisibleIndex = 3;
            this.gridColumnAddress.Width = 200;
            // 
            // gridColumnPhone
            // 
            this.gridColumnPhone.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnPhone.AppearanceCell.Options.UseFont = true;
            this.gridColumnPhone.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnPhone.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPhone.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnPhone.AppearanceHeader.Options.UseFont = true;
            this.gridColumnPhone.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnPhone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPhone.Caption = "Điện thoại";
            this.gridColumnPhone.FieldName = "Phone";
            this.gridColumnPhone.MaxWidth = 150;
            this.gridColumnPhone.MinWidth = 140;
            this.gridColumnPhone.Name = "gridColumnPhone";
            this.gridColumnPhone.Visible = true;
            this.gridColumnPhone.VisibleIndex = 4;
            this.gridColumnPhone.Width = 140;
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
            this.gridColumnStatus.MinWidth = 140;
            this.gridColumnStatus.Name = "gridColumnStatus";
            this.gridColumnStatus.Visible = true;
            this.gridColumnStatus.VisibleIndex = 5;
            this.gridColumnStatus.Width = 140;
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
            this.gridColumnNote.Name = "gridColumnNote";
            this.gridColumnNote.OptionsColumn.AllowEdit = false;
            this.gridColumnNote.OptionsColumn.ReadOnly = true;
            this.gridColumnNote.Visible = true;
            this.gridColumnNote.VisibleIndex = 6;
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
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1492, 4);
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
            this.btnLamMOi.Location = new System.Drawing.Point(1372, 4);
            this.btnLamMOi.Name = "btnLamMOi";
            this.btnLamMOi.Size = new System.Drawing.Size(114, 32);
            this.btnLamMOi.TabIndex = 2;
            this.btnLamMOi.Text = "Làm mới";
            this.btnLamMOi.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // bntImport
            // 
            this.bntImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntImport.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bntImport.Appearance.Options.UseFont = true;
            this.bntImport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bntImport.ImageOptions.Image")));
            this.bntImport.Location = new System.Drawing.Point(1252, 4);
            this.bntImport.Name = "bntImport";
            this.bntImport.Size = new System.Drawing.Size(114, 32);
            this.bntImport.TabIndex = 1;
            this.bntImport.Text = "Import";
            this.bntImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // UCPartner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.bntImport);
            this.Controls.Add(this.btnLamMOi);
            this.Controls.Add(this.gridControlData);
            this.Name = "UCPartner";
            this.Size = new System.Drawing.Size(1609, 513);
            this.Load += new System.EventHandler(this.UCGroupTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClickEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClickDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnGroupName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPartnerCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAddress;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPhone;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnStatus;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNote;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnClickEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnClickDelete;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnLamMOi;
        private DevExpress.XtraEditors.SimpleButton bntImport;
    }
}
