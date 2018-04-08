namespace KimTravel.GUI.FControls
{
    partial class frmBoSungDoiTac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBoSungDoiTac));
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPickUp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRoom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPartnerPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbbTourID = new System.Windows.Forms.ComboBox();
            this.cbbGroupTourID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumnServiceName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnConfirm.Appearance.Options.UseFont = true;
            this.btnConfirm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.ImageOptions.Image")));
            this.btnConfirm.Location = new System.Drawing.Point(858, 404);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(114, 35);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // gridControlData
            // 
            this.gridControlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlData.Location = new System.Drawing.Point(12, 55);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.Size = new System.Drawing.Size(960, 343);
            this.gridControlData.TabIndex = 5;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // gridViewData
            // 
            this.gridViewData.ColumnPanelRowHeight = 35;
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnID,
            this.gridColumnPax,
            this.gridColumnPickUp,
            this.gridColumnRoom,
            this.gridColumnServiceName,
            this.gridColumnPartnerPrice,
            this.gridColumnNote});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.IndicatorWidth = 35;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsCustomization.AllowColumnMoving = false;
            this.gridViewData.OptionsSelection.MultiSelect = true;
            this.gridViewData.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
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
            // gridColumnPax
            // 
            this.gridColumnPax.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnPax.AppearanceCell.Options.UseFont = true;
            this.gridColumnPax.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnPax.AppearanceHeader.Options.UseFont = true;
            this.gridColumnPax.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnPax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPax.Caption = "Pax";
            this.gridColumnPax.FieldName = "Pax";
            this.gridColumnPax.MaxWidth = 60;
            this.gridColumnPax.MinWidth = 60;
            this.gridColumnPax.Name = "gridColumnPax";
            this.gridColumnPax.OptionsColumn.AllowEdit = false;
            this.gridColumnPax.OptionsColumn.ReadOnly = true;
            this.gridColumnPax.Visible = true;
            this.gridColumnPax.VisibleIndex = 1;
            this.gridColumnPax.Width = 60;
            // 
            // gridColumnPickUp
            // 
            this.gridColumnPickUp.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnPickUp.AppearanceCell.Options.UseFont = true;
            this.gridColumnPickUp.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnPickUp.AppearanceHeader.Options.UseFont = true;
            this.gridColumnPickUp.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnPickUp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPickUp.Caption = "PickUp";
            this.gridColumnPickUp.FieldName = "PickUp";
            this.gridColumnPickUp.MinWidth = 300;
            this.gridColumnPickUp.Name = "gridColumnPickUp";
            this.gridColumnPickUp.OptionsColumn.AllowEdit = false;
            this.gridColumnPickUp.OptionsColumn.ReadOnly = true;
            this.gridColumnPickUp.Visible = true;
            this.gridColumnPickUp.VisibleIndex = 2;
            this.gridColumnPickUp.Width = 300;
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
            this.gridColumnRoom.MaxWidth = 100;
            this.gridColumnRoom.MinWidth = 100;
            this.gridColumnRoom.Name = "gridColumnRoom";
            this.gridColumnRoom.Visible = true;
            this.gridColumnRoom.VisibleIndex = 3;
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
            this.gridColumnPartnerPrice.MaxWidth = 111;
            this.gridColumnPartnerPrice.MinWidth = 111;
            this.gridColumnPartnerPrice.Name = "gridColumnPartnerPrice";
            this.gridColumnPartnerPrice.Visible = true;
            this.gridColumnPartnerPrice.VisibleIndex = 5;
            this.gridColumnPartnerPrice.Width = 111;
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
            this.gridColumnNote.MaxWidth = 150;
            this.gridColumnNote.MinWidth = 150;
            this.gridColumnNote.Name = "gridColumnNote";
            this.gridColumnNote.Visible = true;
            this.gridColumnNote.VisibleIndex = 6;
            this.gridColumnNote.Width = 150;
            // 
            // cbbTourID
            // 
            this.cbbTourID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTourID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTourID.FormattingEnabled = true;
            this.cbbTourID.ItemHeight = 16;
            this.cbbTourID.Location = new System.Drawing.Point(213, 25);
            this.cbbTourID.Name = "cbbTourID";
            this.cbbTourID.Size = new System.Drawing.Size(209, 24);
            this.cbbTourID.TabIndex = 9;
            // 
            // cbbGroupTourID
            // 
            this.cbbGroupTourID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGroupTourID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGroupTourID.FormattingEnabled = true;
            this.cbbGroupTourID.ItemHeight = 16;
            this.cbbGroupTourID.Location = new System.Drawing.Point(12, 25);
            this.cbbGroupTourID.Name = "cbbGroupTourID";
            this.cbbGroupTourID.Size = new System.Drawing.Size(191, 24);
            this.cbbGroupTourID.TabIndex = 8;
            this.cbbGroupTourID.SelectedIndexChanged += new System.EventHandler(this.cbbGroupTourID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(210, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chọn tour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chọn nhóm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnTimKiem.Appearance.Options.UseFont = true;
            this.btnTimKiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.ImageOptions.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(439, 17);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(142, 32);
            this.btnTimKiem.TabIndex = 10;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnBack
            // 
            this.btnBack.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnBack.Appearance.Options.UseFont = true;
            this.btnBack.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.ImageOptions.Image")));
            this.btnBack.Location = new System.Drawing.Point(738, 404);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 35);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Quay lại";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gridColumnServiceName
            // 
            this.gridColumnServiceName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnServiceName.AppearanceCell.Options.UseFont = true;
            this.gridColumnServiceName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnServiceName.AppearanceHeader.Options.UseFont = true;
            this.gridColumnServiceName.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnServiceName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnServiceName.Caption = "Dịch vụ";
            this.gridColumnServiceName.FieldName = "ServiceName";
            this.gridColumnServiceName.MinWidth = 120;
            this.gridColumnServiceName.Name = "gridColumnServiceName";
            this.gridColumnServiceName.Visible = true;
            this.gridColumnServiceName.VisibleIndex = 4;
            this.gridColumnServiceName.Width = 120;
            // 
            // frmBoSungDoiTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 451);
            this.ControlBox = false;
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.cbbTourID);
            this.Controls.Add(this.cbbGroupTourID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControlData);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnConfirm);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 490);
            this.Name = "frmBoSungDoiTac";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bổ sung thêm";
            this.Load += new System.EventHandler(this.frmBoSungDoiTac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPax;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPickUp;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRoom;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPartnerPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNote;
        private System.Windows.Forms.ComboBox cbbTourID;
        private System.Windows.Forms.ComboBox cbbGroupTourID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnServiceName;
    }
}