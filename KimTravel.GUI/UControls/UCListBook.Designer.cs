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
            this.label6 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.cbbTourID = new System.Windows.Forms.ComboBox();
            this.cbbGroupTourID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdBinhThuong = new System.Windows.Forms.RadioButton();
            this.rdDaHuy = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tảiLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTourID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPartnerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TourName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPickUp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPartnerPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriceReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriceSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriceVTQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPromotionMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPromotionPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupTour)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(756, 10);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 38);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
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
            this.colTourID,
            this.colPartnerID,
            this.TourName,
            this.colStartDate,
            this.colEndDate,
            this.colPax,
            this.colCustomName,
            this.colRoom,
            this.colPickUp,
            this.colDateCreate,
            this.colPartnerPrice,
            this.colPriceReceive,
            this.colPriceSale,
            this.colPriceVTQ,
            this.colPromotionMoney,
            this.colPromotionPercent,
            this.colTotal,
            this.colStaff,
            this.colNote,
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(378, 5);
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
            this.dtpStartDate.Location = new System.Drawing.Point(381, 25);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(133, 23);
            this.dtpStartDate.TabIndex = 3;
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
            // rdBinhThuong
            // 
            this.rdBinhThuong.AutoSize = true;
            this.rdBinhThuong.Checked = true;
            this.rdBinhThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBinhThuong.Location = new System.Drawing.Point(8, 18);
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
            this.rdDaHuy.Location = new System.Drawing.Point(130, 17);
            this.rdDaHuy.Name = "rdDaHuy";
            this.rdDaHuy.Size = new System.Drawing.Size(71, 21);
            this.rdDaHuy.TabIndex = 6;
            this.rdDaHuy.Text = "Đã hủy";
            this.rdDaHuy.UseVisualStyleBackColor = true;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBinhThuong);
            this.groupBox1.Controls.Add(this.rdDaHuy);
            this.groupBox1.Location = new System.Drawing.Point(530, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 45);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tình trạng";
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
            // TourName
            // 
            this.TourName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TourName.DataPropertyName = "TourName";
            this.TourName.HeaderText = "Tour";
            this.TourName.Name = "TourName";
            this.TourName.ReadOnly = true;
            this.TourName.Width = 120;
            // 
            // colStartDate
            // 
            this.colStartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colStartDate.DataPropertyName = "StartDate";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "dd-MM-yyyy";
            this.colStartDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colStartDate.HeaderText = "Ngày đi";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.ReadOnly = true;
            // 
            // colEndDate
            // 
            this.colEndDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colEndDate.DataPropertyName = "EndDate";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "dd-MM-yyyy";
            this.colEndDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.colEndDate.HeaderText = "Ngày kết thúc";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.ReadOnly = true;
            this.colEndDate.Visible = false;
            // 
            // colPax
            // 
            this.colPax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPax.DataPropertyName = "Pax";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.NullValue = null;
            this.colPax.DefaultCellStyle = dataGridViewCellStyle4;
            this.colPax.HeaderText = "Số người";
            this.colPax.Name = "colPax";
            this.colPax.ReadOnly = true;
            this.colPax.Width = 120;
            // 
            // colCustomName
            // 
            this.colCustomName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCustomName.DataPropertyName = "CustomName";
            this.colCustomName.HeaderText = "Khách hàng";
            this.colCustomName.Name = "colCustomName";
            this.colCustomName.ReadOnly = true;
            this.colCustomName.Width = 160;
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
            // colPickUp
            // 
            this.colPickUp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPickUp.DataPropertyName = "PickUp";
            this.colPickUp.HeaderText = "PickUp";
            this.colPickUp.Name = "colPickUp";
            this.colPickUp.ReadOnly = true;
            this.colPickUp.Width = 160;
            // 
            // colDateCreate
            // 
            this.colDateCreate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDateCreate.DataPropertyName = "DateCreate";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "dd-MM-yyyy";
            dataGridViewCellStyle5.NullValue = null;
            this.colDateCreate.DefaultCellStyle = dataGridViewCellStyle5;
            this.colDateCreate.HeaderText = "Ngày tạo";
            this.colDateCreate.Name = "colDateCreate";
            this.colDateCreate.ReadOnly = true;
            this.colDateCreate.Width = 120;
            // 
            // colPartnerPrice
            // 
            this.colPartnerPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPartnerPrice.DataPropertyName = "PartnerPrice";
            dataGridViewCellStyle6.Format = "#,###";
            this.colPartnerPrice.DefaultCellStyle = dataGridViewCellStyle6;
            this.colPartnerPrice.HeaderText = "Thu hộ";
            this.colPartnerPrice.Name = "colPartnerPrice";
            this.colPartnerPrice.ReadOnly = true;
            // 
            // colPriceReceive
            // 
            this.colPriceReceive.DataPropertyName = "PriceReceive";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Format = "#,###";
            this.colPriceReceive.DefaultCellStyle = dataGridViewCellStyle7;
            this.colPriceReceive.HeaderText = "Giá nhận";
            this.colPriceReceive.Name = "colPriceReceive";
            this.colPriceReceive.ReadOnly = true;
            this.colPriceReceive.Width = 75;
            // 
            // colPriceSale
            // 
            this.colPriceSale.DataPropertyName = "PriceSale";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Format = "#,###";
            this.colPriceSale.DefaultCellStyle = dataGridViewCellStyle8;
            this.colPriceSale.HeaderText = "Giá bán";
            this.colPriceSale.Name = "colPriceSale";
            this.colPriceSale.ReadOnly = true;
            this.colPriceSale.Width = 69;
            // 
            // colPriceVTQ
            // 
            this.colPriceVTQ.DataPropertyName = "PriceVTQ";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.Format = "#,###";
            this.colPriceVTQ.DefaultCellStyle = dataGridViewCellStyle9;
            this.colPriceVTQ.HeaderText = "Giá VTQ";
            this.colPriceVTQ.Name = "colPriceVTQ";
            this.colPriceVTQ.ReadOnly = true;
            this.colPriceVTQ.Width = 73;
            // 
            // colPromotionMoney
            // 
            this.colPromotionMoney.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPromotionMoney.DataPropertyName = "PromotionMoney";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.Format = "#,###";
            this.colPromotionMoney.DefaultCellStyle = dataGridViewCellStyle10;
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
            // 
            // colTotal
            // 
            this.colTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTotal.DataPropertyName = "Total";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "#,###";
            this.colTotal.DefaultCellStyle = dataGridViewCellStyle11;
            this.colTotal.HeaderText = "Tổng tiền";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
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
            // UCListBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbbTourID);
            this.Controls.Add(this.cbbGroupTourID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.dataGridViewGroupTour);
            this.Controls.Add(this.btnTimKiem);
            this.Name = "UCListBook";
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.ComboBox cbbTourID;
        private System.Windows.Forms.ComboBox cbbGroupTourID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdBinhThuong;
        private System.Windows.Forms.RadioButton rdDaHuy;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tảiLạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtExcelToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTourID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartnerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TourName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPickUp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartnerPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriceReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriceSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriceVTQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPromotionMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPromotionPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNote;
        private System.Windows.Forms.DataGridViewButtonColumn ActionUpdate;
    }
}
