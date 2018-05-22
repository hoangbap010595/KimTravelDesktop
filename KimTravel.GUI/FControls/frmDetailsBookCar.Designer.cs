namespace KimTravel.GUI.FControls
{
    partial class frmDetailsBookCar
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
            this.btnPrint = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblTour = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbHDV = new System.Windows.Forms.ComboBox();
            this.cbbTaiXe = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMessageProgress = new System.Windows.Forms.Label();
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPickUp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnServiceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRoom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPartnerPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtHdvName = new DevExpress.XtraEditors.TextEdit();
            this.txtTXName = new DevExpress.XtraEditors.TextEdit();
            this.txtBKS = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.gridColumnPaxChild = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblTotalPaxChild = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHdvName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTXName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBKS.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPrint.Depth = 0;
            this.btnPrint.Location = new System.Drawing.Point(893, 601);
            this.btnPrint.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Primary = true;
            this.btnPrint.Size = new System.Drawing.Size(135, 39);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblTour
            // 
            this.lblTour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTour.Location = new System.Drawing.Point(71, 28);
            this.lblTour.Name = "lblTour";
            this.lblTour.Size = new System.Drawing.Size(282, 25);
            this.lblTour.TabIndex = 0;
            this.lblTour.Text = "XE 1";
            this.lblTour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(71, 62);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(282, 25);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "XE 1";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày đi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(453, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "HDV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(453, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tài xế";
            // 
            // cbbHDV
            // 
            this.cbbHDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbHDV.FormattingEnabled = true;
            this.cbbHDV.ItemHeight = 20;
            this.cbbHDV.Location = new System.Drawing.Point(511, 24);
            this.cbbHDV.Name = "cbbHDV";
            this.cbbHDV.Size = new System.Drawing.Size(164, 28);
            this.cbbHDV.TabIndex = 1;
            // 
            // cbbTaiXe
            // 
            this.cbbTaiXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTaiXe.FormattingEnabled = true;
            this.cbbTaiXe.ItemHeight = 20;
            this.cbbTaiXe.Location = new System.Drawing.Point(511, 58);
            this.cbbTaiXe.Name = "cbbTaiXe";
            this.cbbTaiXe.Size = new System.Drawing.Size(164, 28);
            this.cbbTaiXe.TabIndex = 2;
            this.cbbTaiXe.SelectedIndexChanged += new System.EventHandler(this.cbbTaiXe_SelectedIndexChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Plum;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(11, 601);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(99, 36);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "20 pax";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBack.Depth = 0;
            this.btnBack.Location = new System.Drawing.Point(752, 601);
            this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.Primary = true;
            this.btnBack.Size = new System.Drawing.Size(135, 39);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(13, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "(Hãy kiểm tra kỹ thông tin bên dưới trước khi in)";
            // 
            // lblMessageProgress
            // 
            this.lblMessageProgress.AutoSize = true;
            this.lblMessageProgress.BackColor = System.Drawing.Color.Transparent;
            this.lblMessageProgress.ForeColor = System.Drawing.Color.Red;
            this.lblMessageProgress.Location = new System.Drawing.Point(221, 624);
            this.lblMessageProgress.Name = "lblMessageProgress";
            this.lblMessageProgress.Size = new System.Drawing.Size(136, 13);
            this.lblMessageProgress.TabIndex = 0;
            this.lblMessageProgress.Text = "Đang xử lý. Vui lòng chờ...";
            this.lblMessageProgress.Visible = false;
            // 
            // gridControlData
            // 
            this.gridControlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlData.Location = new System.Drawing.Point(11, 132);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.Size = new System.Drawing.Size(1019, 464);
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
            this.gridColumnPaxChild,
            this.gridColumnPickUp,
            this.gridColumnServiceName,
            this.gridColumnRoom,
            this.gridColumnPartnerPrice,
            this.gridColumnNote});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.IndicatorWidth = 35;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsCustomization.AllowColumnMoving = false;
            this.gridViewData.OptionsView.ShowGroupPanel = false;
            this.gridViewData.OptionsView.ShowIndicator = false;
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
            this.gridColumnPax.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnPax.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPax.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnPax.AppearanceHeader.Options.UseFont = true;
            this.gridColumnPax.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnPax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPax.Caption = "Pax";
            this.gridColumnPax.FieldName = "Pax";
            this.gridColumnPax.MaxWidth = 50;
            this.gridColumnPax.MinWidth = 50;
            this.gridColumnPax.Name = "gridColumnPax";
            this.gridColumnPax.OptionsColumn.AllowEdit = false;
            this.gridColumnPax.OptionsColumn.ReadOnly = true;
            this.gridColumnPax.Visible = true;
            this.gridColumnPax.VisibleIndex = 0;
            this.gridColumnPax.Width = 50;
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
            this.gridColumnPickUp.Name = "gridColumnPickUp";
            this.gridColumnPickUp.OptionsColumn.AllowEdit = false;
            this.gridColumnPickUp.OptionsColumn.ReadOnly = true;
            this.gridColumnPickUp.Visible = true;
            this.gridColumnPickUp.VisibleIndex = 2;
            this.gridColumnPickUp.Width = 83;
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
            this.gridColumnServiceName.MaxWidth = 160;
            this.gridColumnServiceName.MinWidth = 160;
            this.gridColumnServiceName.Name = "gridColumnServiceName";
            this.gridColumnServiceName.Visible = true;
            this.gridColumnServiceName.VisibleIndex = 4;
            this.gridColumnServiceName.Width = 160;
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
            this.gridColumnRoom.MaxWidth = 120;
            this.gridColumnRoom.MinWidth = 120;
            this.gridColumnRoom.Name = "gridColumnRoom";
            this.gridColumnRoom.OptionsColumn.AllowEdit = false;
            this.gridColumnRoom.OptionsColumn.ReadOnly = true;
            this.gridColumnRoom.Visible = true;
            this.gridColumnRoom.VisibleIndex = 3;
            this.gridColumnRoom.Width = 120;
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
            this.gridColumnPartnerPrice.MaxWidth = 130;
            this.gridColumnPartnerPrice.MinWidth = 130;
            this.gridColumnPartnerPrice.Name = "gridColumnPartnerPrice";
            this.gridColumnPartnerPrice.OptionsColumn.AllowEdit = false;
            this.gridColumnPartnerPrice.OptionsColumn.ReadOnly = true;
            this.gridColumnPartnerPrice.Visible = true;
            this.gridColumnPartnerPrice.VisibleIndex = 5;
            this.gridColumnPartnerPrice.Width = 130;
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
            this.gridColumnNote.MaxWidth = 140;
            this.gridColumnNote.MinWidth = 140;
            this.gridColumnNote.Name = "gridColumnNote";
            this.gridColumnNote.OptionsColumn.AllowEdit = false;
            this.gridColumnNote.OptionsColumn.ReadOnly = true;
            this.gridColumnNote.Visible = true;
            this.gridColumnNote.VisibleIndex = 6;
            this.gridColumnNote.Width = 140;
            // 
            // txtHdvName
            // 
            this.txtHdvName.Location = new System.Drawing.Point(681, 24);
            this.txtHdvName.Name = "txtHdvName";
            this.txtHdvName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtHdvName.Properties.Appearance.Options.UseFont = true;
            this.txtHdvName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtHdvName.Size = new System.Drawing.Size(121, 28);
            this.txtHdvName.TabIndex = 6;
            // 
            // txtTXName
            // 
            this.txtTXName.Location = new System.Drawing.Point(681, 57);
            this.txtTXName.Name = "txtTXName";
            this.txtTXName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtTXName.Properties.Appearance.Options.UseFont = true;
            this.txtTXName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtTXName.Size = new System.Drawing.Size(121, 28);
            this.txtTXName.TabIndex = 6;
            // 
            // txtBKS
            // 
            this.txtBKS.Location = new System.Drawing.Point(864, 57);
            this.txtBKS.Name = "txtBKS";
            this.txtBKS.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtBKS.Properties.Appearance.Options.UseFont = true;
            this.txtBKS.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtBKS.Size = new System.Drawing.Size(164, 28);
            this.txtBKS.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(820, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "BKS:";
            // 
            // gridColumnPaxChild
            // 
            this.gridColumnPaxChild.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnPaxChild.AppearanceCell.Options.UseFont = true;
            this.gridColumnPaxChild.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnPaxChild.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPaxChild.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnPaxChild.AppearanceHeader.Options.UseFont = true;
            this.gridColumnPaxChild.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnPaxChild.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPaxChild.Caption = "Pax TE";
            this.gridColumnPaxChild.FieldName = "PaxChild";
            this.gridColumnPaxChild.MaxWidth = 50;
            this.gridColumnPaxChild.MinWidth = 50;
            this.gridColumnPaxChild.Name = "gridColumnPaxChild";
            this.gridColumnPaxChild.OptionsColumn.AllowEdit = false;
            this.gridColumnPaxChild.OptionsColumn.ReadOnly = true;
            this.gridColumnPaxChild.Visible = true;
            this.gridColumnPaxChild.VisibleIndex = 1;
            this.gridColumnPaxChild.Width = 50;
            // 
            // lblTotalPaxChild
            // 
            this.lblTotalPaxChild.BackColor = System.Drawing.Color.Plum;
            this.lblTotalPaxChild.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalPaxChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPaxChild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalPaxChild.Location = new System.Drawing.Point(116, 602);
            this.lblTotalPaxChild.Name = "lblTotalPaxChild";
            this.lblTotalPaxChild.Size = new System.Drawing.Size(99, 36);
            this.lblTotalPaxChild.TabIndex = 0;
            this.lblTotalPaxChild.Text = "20 pax";
            this.lblTotalPaxChild.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDetailsBookCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 650);
            this.Controls.Add(this.txtBKS);
            this.Controls.Add(this.txtTXName);
            this.Controls.Add(this.txtHdvName);
            this.Controls.Add(this.gridControlData);
            this.Controls.Add(this.lblMessageProgress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbTaiXe);
            this.Controls.Add(this.cbbHDV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalPaxChild);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTour);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPrint);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(716, 689);
            this.Name = "frmDetailsBookCar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết xe đã đặt";
            this.Load += new System.EventHandler(this.frmActionGroupTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHdvName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTXName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBKS.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnPrint;
        private System.Windows.Forms.Label lblTour;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbHDV;
        private System.Windows.Forms.ComboBox cbbTaiXe;
        private System.Windows.Forms.Label lblTotal;
        private MaterialSkin.Controls.MaterialRaisedButton btnBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMessageProgress;
        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPax;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPickUp;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRoom;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPartnerPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNote;
        private DevExpress.XtraEditors.TextEdit txtHdvName;
        private DevExpress.XtraEditors.TextEdit txtTXName;
        private DevExpress.XtraEditors.TextEdit txtBKS;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnServiceName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPaxChild;
        private System.Windows.Forms.Label lblTotalPaxChild;
    }
}