namespace KimTravel.GUI.UControls
{
    partial class UCReportCongNo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dataGridViewGroupTour = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TourName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPartnerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPickUp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPartnerPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTourID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPartnerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriceReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriceSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriceVTQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPromotionMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPromotionPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbbMonth = new System.Windows.Forms.ComboBox();
            this.cbbPartnerID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tảiLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnXuatBaoCao = new System.Windows.Forms.Button();
            this.cbbYear = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbGroupTour = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdDaThanhToan = new System.Windows.Forms.RadioButton();
            this.rdChuaThanhToan = new System.Windows.Forms.RadioButton();
            this.rdALL = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupTour)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(843, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(110, 50);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Lọc dữ liệu";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dataGridViewGroupTour
            // 
            this.dataGridViewGroupTour.AllowUserToAddRows = false;
            this.dataGridViewGroupTour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGroupTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewGroupTour.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewGroupTour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewGroupTour.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGroupTour.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewGroupTour.ColumnHeadersHeight = 30;
            this.dataGridViewGroupTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colPax,
            this.TourName,
            this.colServiceName,
            this.colPartnerName,
            this.colPickUp,
            this.colRoom,
            this.colPartnerPrice,
            this.colStaff,
            this.colNote,
            this.colTourID,
            this.colPartnerID,
            this.colStartDate,
            this.colEndDate,
            this.colCustomName,
            this.colPriceReceive,
            this.colPriceSale,
            this.colPriceVTQ,
            this.colPromotionMoney,
            this.colPromotionPercent,
            this.colTotal,
            this.colDateCreate,
            this.ActionUpdate});
            this.dataGridViewGroupTour.Location = new System.Drawing.Point(3, 58);
            this.dataGridViewGroupTour.MultiSelect = false;
            this.dataGridViewGroupTour.Name = "dataGridViewGroupTour";
            this.dataGridViewGroupTour.ReadOnly = true;
            this.dataGridViewGroupTour.RowHeadersWidth = 35;
            this.dataGridViewGroupTour.RowTemplate.Height = 25;
            this.dataGridViewGroupTour.RowTemplate.ReadOnly = true;
            this.dataGridViewGroupTour.Size = new System.Drawing.Size(1053, 452);
            this.dataGridViewGroupTour.TabIndex = 0;
            this.dataGridViewGroupTour.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewGroupTour.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewGroupTour_RowPostPaint);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            this.colID.Width = 43;
            // 
            // colPax
            // 
            this.colPax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPax.DataPropertyName = "Pax";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = null;
            this.colPax.DefaultCellStyle = dataGridViewCellStyle2;
            this.colPax.HeaderText = "SL";
            this.colPax.Name = "colPax";
            this.colPax.ReadOnly = true;
            this.colPax.Width = 50;
            // 
            // TourName
            // 
            this.TourName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TourName.DataPropertyName = "TourName";
            this.TourName.HeaderText = "Tour";
            this.TourName.Name = "TourName";
            this.TourName.ReadOnly = true;
            this.TourName.Width = 120;
            // 
            // colServiceName
            // 
            this.colServiceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colServiceName.DataPropertyName = "ServiceName";
            this.colServiceName.HeaderText = "Dịch vụ";
            this.colServiceName.Name = "colServiceName";
            this.colServiceName.ReadOnly = true;
            // 
            // colPartnerName
            // 
            this.colPartnerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPartnerName.DataPropertyName = "PartnerName";
            this.colPartnerName.HeaderText = "Tên đối tác";
            this.colPartnerName.Name = "colPartnerName";
            this.colPartnerName.ReadOnly = true;
            this.colPartnerName.Width = 120;
            // 
            // colPickUp
            // 
            this.colPickUp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPickUp.DataPropertyName = "PickUp";
            this.colPickUp.HeaderText = "PickUp";
            this.colPickUp.Name = "colPickUp";
            this.colPickUp.ReadOnly = true;
            this.colPickUp.Width = 160;
            // 
            // colRoom
            // 
            this.colRoom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colRoom.DataPropertyName = "Room";
            this.colRoom.HeaderText = "Room";
            this.colRoom.Name = "colRoom";
            this.colRoom.ReadOnly = true;
            this.colRoom.Width = 80;
            // 
            // colPartnerPrice
            // 
            this.colPartnerPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPartnerPrice.DataPropertyName = "PartnerPrice";
            dataGridViewCellStyle3.Format = "#,###";
            this.colPartnerPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.colPartnerPrice.HeaderText = "Thu hộ";
            this.colPartnerPrice.Name = "colPartnerPrice";
            this.colPartnerPrice.ReadOnly = true;
            // 
            // colStaff
            // 
            this.colStaff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colStaff.DataPropertyName = "StaffID";
            this.colStaff.HeaderText = "NV Book";
            this.colStaff.Name = "colStaff";
            this.colStaff.ReadOnly = true;
            // 
            // colNote
            // 
            this.colNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colNote.DataPropertyName = "Note";
            this.colNote.HeaderText = "Ghi chú";
            this.colNote.Name = "colNote";
            this.colNote.ReadOnly = true;
            this.colNote.Width = 300;
            // 
            // colTourID
            // 
            this.colTourID.DataPropertyName = "TourID";
            this.colTourID.HeaderText = "TourID";
            this.colTourID.Name = "colTourID";
            this.colTourID.ReadOnly = true;
            this.colTourID.Visible = false;
            this.colTourID.Width = 65;
            // 
            // colPartnerID
            // 
            this.colPartnerID.DataPropertyName = "PartnerID";
            this.colPartnerID.HeaderText = "PartnerID";
            this.colPartnerID.Name = "colPartnerID";
            this.colPartnerID.ReadOnly = true;
            this.colPartnerID.Visible = false;
            this.colPartnerID.Width = 77;
            // 
            // colStartDate
            // 
            this.colStartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colStartDate.DataPropertyName = "StartDate";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "dd-MM-yyyy";
            this.colStartDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.colStartDate.HeaderText = "Ngày đi";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.ReadOnly = true;
            // 
            // colEndDate
            // 
            this.colEndDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colEndDate.DataPropertyName = "EndDate";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "dd-MM-yyyy";
            this.colEndDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.colEndDate.HeaderText = "Ngày kết thúc";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.ReadOnly = true;
            this.colEndDate.Visible = false;
            // 
            // colCustomName
            // 
            this.colCustomName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCustomName.DataPropertyName = "CustomName";
            this.colCustomName.HeaderText = "Khách hàng";
            this.colCustomName.Name = "colCustomName";
            this.colCustomName.ReadOnly = true;
            this.colCustomName.Visible = false;
            this.colCustomName.Width = 160;
            // 
            // colPriceReceive
            // 
            this.colPriceReceive.DataPropertyName = "PriceReceive";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "#,###";
            this.colPriceReceive.DefaultCellStyle = dataGridViewCellStyle6;
            this.colPriceReceive.HeaderText = "Giá nhận";
            this.colPriceReceive.Name = "colPriceReceive";
            this.colPriceReceive.ReadOnly = true;
            this.colPriceReceive.Width = 75;
            // 
            // colPriceSale
            // 
            this.colPriceSale.DataPropertyName = "PriceSale";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "#,###";
            this.colPriceSale.DefaultCellStyle = dataGridViewCellStyle7;
            this.colPriceSale.HeaderText = "Giá bán";
            this.colPriceSale.Name = "colPriceSale";
            this.colPriceSale.ReadOnly = true;
            this.colPriceSale.Width = 69;
            // 
            // colPriceVTQ
            // 
            this.colPriceVTQ.DataPropertyName = "PriceVTQ";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "#,###";
            this.colPriceVTQ.DefaultCellStyle = dataGridViewCellStyle8;
            this.colPriceVTQ.HeaderText = "Giá VTQ";
            this.colPriceVTQ.Name = "colPriceVTQ";
            this.colPriceVTQ.ReadOnly = true;
            this.colPriceVTQ.Width = 73;
            // 
            // colPromotionMoney
            // 
            this.colPromotionMoney.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPromotionMoney.DataPropertyName = "PromotionMoney";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.Format = "#,###";
            this.colPromotionMoney.DefaultCellStyle = dataGridViewCellStyle9;
            this.colPromotionMoney.HeaderText = "Giá KM (vnđ)";
            this.colPromotionMoney.Name = "colPromotionMoney";
            this.colPromotionMoney.ReadOnly = true;
            // 
            // colPromotionPercent
            // 
            this.colPromotionPercent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPromotionPercent.DataPropertyName = "PromotionPercent";
            this.colPromotionPercent.HeaderText = "Giảm giá (%)";
            this.colPromotionPercent.Name = "colPromotionPercent";
            this.colPromotionPercent.ReadOnly = true;
            this.colPromotionPercent.Visible = false;
            // 
            // colTotal
            // 
            this.colTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTotal.DataPropertyName = "Total";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "#,###";
            this.colTotal.DefaultCellStyle = dataGridViewCellStyle10;
            this.colTotal.HeaderText = "Tổng tiền";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colDateCreate
            // 
            this.colDateCreate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDateCreate.DataPropertyName = "DateCreate";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Format = "dd-MM-yyyy";
            dataGridViewCellStyle11.NullValue = null;
            this.colDateCreate.DefaultCellStyle = dataGridViewCellStyle11;
            this.colDateCreate.HeaderText = "Ngày tạo";
            this.colDateCreate.Name = "colDateCreate";
            this.colDateCreate.ReadOnly = true;
            this.colDateCreate.Width = 120;
            // 
            // ActionUpdate
            // 
            this.ActionUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.ActionUpdate.DefaultCellStyle = dataGridViewCellStyle12;
            this.ActionUpdate.HeaderText = "Xem";
            this.ActionUpdate.Name = "ActionUpdate";
            this.ActionUpdate.ReadOnly = true;
            this.ActionUpdate.Text = "Xem";
            this.ActionUpdate.UseColumnTextForButtonValue = true;
            this.ActionUpdate.Width = 80;
            // 
            // cbbMonth
            // 
            this.cbbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMonth.FormattingEnabled = true;
            this.cbbMonth.ItemHeight = 16;
            this.cbbMonth.Location = new System.Drawing.Point(391, 25);
            this.cbbMonth.Name = "cbbMonth";
            this.cbbMonth.Size = new System.Drawing.Size(68, 24);
            this.cbbMonth.TabIndex = 2;
            // 
            // cbbPartnerID
            // 
            this.cbbPartnerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPartnerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPartnerID.FormattingEnabled = true;
            this.cbbPartnerID.ItemHeight = 16;
            this.cbbPartnerID.Location = new System.Drawing.Point(8, 25);
            this.cbbPartnerID.Name = "cbbPartnerID";
            this.cbbPartnerID.Size = new System.Drawing.Size(213, 24);
            this.cbbPartnerID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đối tác:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(388, 5);
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
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(955, 3);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(100, 25);
            this.btnExportExcel.TabIndex = 9;
            this.btnExportExcel.Text = "Xuất Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnXuatBaoCao
            // 
            this.btnXuatBaoCao.Location = new System.Drawing.Point(955, 30);
            this.btnXuatBaoCao.Name = "btnXuatBaoCao";
            this.btnXuatBaoCao.Size = new System.Drawing.Size(100, 25);
            this.btnXuatBaoCao.TabIndex = 9;
            this.btnXuatBaoCao.Text = "In báo cáo";
            this.btnXuatBaoCao.UseVisualStyleBackColor = true;
            this.btnXuatBaoCao.Click += new System.EventHandler(this.btnXuatBaoCao_Click);
            // 
            // cbbYear
            // 
            this.cbbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbYear.FormattingEnabled = true;
            this.cbbYear.ItemHeight = 16;
            this.cbbYear.Location = new System.Drawing.Point(462, 25);
            this.cbbYear.Name = "cbbYear";
            this.cbbYear.Size = new System.Drawing.Size(68, 24);
            this.cbbYear.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(464, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Năm:";
            // 
            // cbbGroupTour
            // 
            this.cbbGroupTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGroupTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGroupTour.FormattingEnabled = true;
            this.cbbGroupTour.ItemHeight = 16;
            this.cbbGroupTour.Location = new System.Drawing.Point(226, 25);
            this.cbbGroupTour.Name = "cbbGroupTour";
            this.cbbGroupTour.Size = new System.Drawing.Size(160, 24);
            this.cbbGroupTour.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(223, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhóm:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdALL);
            this.groupBox1.Controls.Add(this.rdDaThanhToan);
            this.groupBox1.Controls.Add(this.rdChuaThanhToan);
            this.groupBox1.Location = new System.Drawing.Point(536, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 45);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tình trạng";
            // 
            // rdDaThanhToan
            // 
            this.rdDaThanhToan.AutoSize = true;
            this.rdDaThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDaThanhToan.Location = new System.Drawing.Point(76, 17);
            this.rdDaThanhToan.Name = "rdDaThanhToan";
            this.rdDaThanhToan.Size = new System.Drawing.Size(102, 19);
            this.rdDaThanhToan.TabIndex = 6;
            this.rdDaThanhToan.Text = "Đã thanh toán";
            this.rdDaThanhToan.UseVisualStyleBackColor = true;
            // 
            // rdChuaThanhToan
            // 
            this.rdChuaThanhToan.AutoSize = true;
            this.rdChuaThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdChuaThanhToan.Location = new System.Drawing.Point(182, 17);
            this.rdChuaThanhToan.Name = "rdChuaThanhToan";
            this.rdChuaThanhToan.Size = new System.Drawing.Size(115, 19);
            this.rdChuaThanhToan.TabIndex = 6;
            this.rdChuaThanhToan.Text = "Chưa thanh toán";
            this.rdChuaThanhToan.UseVisualStyleBackColor = true;
            // 
            // rdALL
            // 
            this.rdALL.AutoSize = true;
            this.rdALL.Checked = true;
            this.rdALL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdALL.Location = new System.Drawing.Point(6, 17);
            this.rdALL.Name = "rdALL";
            this.rdALL.Size = new System.Drawing.Size(58, 19);
            this.rdALL.TabIndex = 6;
            this.rdALL.Text = "Tất cả";
            this.rdALL.UseVisualStyleBackColor = true;
            // 
            // UCReportCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbbGroupTour);
            this.Controls.Add(this.btnXuatBaoCao);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.cbbYear);
            this.Controls.Add(this.cbbMonth);
            this.Controls.Add(this.cbbPartnerID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewGroupTour);
            this.Controls.Add(this.btnTimKiem);
            this.Name = "UCReportCongNo";
            this.Size = new System.Drawing.Size(1059, 513);
            this.Load += new System.EventHandler(this.UCGroupTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupTour)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewGroupTour;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cbbMonth;
        private System.Windows.Forms.ComboBox cbbPartnerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tảiLạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtExcelToolStripMenuItem;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnXuatBaoCao;
        private System.Windows.Forms.ComboBox cbbYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbGroupTour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPax;
        private System.Windows.Forms.DataGridViewTextBoxColumn TourName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartnerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPickUp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartnerPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTourID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartnerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriceReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriceSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriceVTQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPromotionMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPromotionPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateCreate;
        private System.Windows.Forms.DataGridViewButtonColumn ActionUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdDaThanhToan;
        private System.Windows.Forms.RadioButton rdChuaThanhToan;
        private System.Windows.Forms.RadioButton rdALL;
    }
}
