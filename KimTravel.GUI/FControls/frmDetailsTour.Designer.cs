﻿namespace KimTravel.GUI.FControls
{
    partial class frmDetailsTour
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMsgPax = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSaleBook = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.numPax = new System.Windows.Forms.NumericUpDown();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnFindParnet = new System.Windows.Forms.Button();
            this.cbbPartnerID = new System.Windows.Forms.ComboBox();
            this.cbbTourID = new System.Windows.Forms.ComboBox();
            this.cbbGroupTourID = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPickup = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRoom = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCustomer = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewGroupTour = new System.Windows.Forms.DataGridView();
            this.colPartnerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServiceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.numPromotionPer = new System.Windows.Forms.NumericUpDown();
            this.txtPromotionPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label18 = new System.Windows.Forms.Label();
            this.materialSingleLineTextField5 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPartnerPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label20 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPriceVTQ = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAddServiceType = new System.Windows.Forms.Button();
            this.txtPriceSa = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPriceRe = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPax)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupTour)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPromotionPer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(630, 490);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(158, 40);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMsgPax);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSaleBook);
            this.groupBox1.Controls.Add(this.numPax);
            this.groupBox1.Controls.Add(this.dtpEndDate);
            this.groupBox1.Controls.Add(this.dtpStartDate);
            this.groupBox1.Controls.Add(this.btnFindParnet);
            this.groupBox1.Controls.Add(this.cbbPartnerID);
            this.groupBox1.Controls.Add(this.cbbTourID);
            this.groupBox1.Controls.Add(this.cbbGroupTourID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 304);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // lblMsgPax
            // 
            this.lblMsgPax.AutoSize = true;
            this.lblMsgPax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgPax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMsgPax.Location = new System.Drawing.Point(297, 232);
            this.lblMsgPax.Name = "lblMsgPax";
            this.lblMsgPax.Size = new System.Drawing.Size(54, 15);
            this.lblMsgPax.TabIndex = 0;
            this.lblMsgPax.Text = "NV Book";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(19, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số người";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(19, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày kết thúc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(19, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày bắt đầu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(19, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "NV Book";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(19, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đối tác";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(19, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên tour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhóm tour";
            // 
            // txtSaleBook
            // 
            this.txtSaleBook.Depth = 0;
            this.txtSaleBook.Hint = "Nhập tên người book";
            this.txtSaleBook.Location = new System.Drawing.Point(129, 265);
            this.txtSaleBook.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSaleBook.Name = "txtSaleBook";
            this.txtSaleBook.PasswordChar = '\0';
            this.txtSaleBook.SelectedText = "";
            this.txtSaleBook.SelectionLength = 0;
            this.txtSaleBook.SelectionStart = 0;
            this.txtSaleBook.Size = new System.Drawing.Size(300, 23);
            this.txtSaleBook.TabIndex = 7;
            this.txtSaleBook.UseSystemPasswordChar = false;
            // 
            // numPax
            // 
            this.numPax.Location = new System.Drawing.Point(129, 227);
            this.numPax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPax.Name = "numPax";
            this.numPax.Size = new System.Drawing.Size(162, 23);
            this.numPax.TabIndex = 6;
            this.numPax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "dd-MM-yyyy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(129, 187);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(162, 23);
            this.dtpEndDate.TabIndex = 5;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "dd-MM-yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(129, 148);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(162, 23);
            this.dtpStartDate.TabIndex = 5;
            // 
            // btnFindParnet
            // 
            this.btnFindParnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindParnet.Location = new System.Drawing.Point(373, 105);
            this.btnFindParnet.MaximumSize = new System.Drawing.Size(56, 26);
            this.btnFindParnet.MinimumSize = new System.Drawing.Size(56, 26);
            this.btnFindParnet.Name = "btnFindParnet";
            this.btnFindParnet.Size = new System.Drawing.Size(56, 26);
            this.btnFindParnet.TabIndex = 4;
            this.btnFindParnet.Text = "Tìm";
            this.btnFindParnet.UseVisualStyleBackColor = true;
            this.btnFindParnet.Click += new System.EventHandler(this.btnFindParnet_Click);
            // 
            // cbbPartnerID
            // 
            this.cbbPartnerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPartnerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPartnerID.FormattingEnabled = true;
            this.cbbPartnerID.ItemHeight = 16;
            this.cbbPartnerID.Location = new System.Drawing.Point(129, 106);
            this.cbbPartnerID.Name = "cbbPartnerID";
            this.cbbPartnerID.Size = new System.Drawing.Size(238, 24);
            this.cbbPartnerID.TabIndex = 3;
            // 
            // cbbTourID
            // 
            this.cbbTourID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTourID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTourID.FormattingEnabled = true;
            this.cbbTourID.ItemHeight = 16;
            this.cbbTourID.Location = new System.Drawing.Point(129, 66);
            this.cbbTourID.Name = "cbbTourID";
            this.cbbTourID.Size = new System.Drawing.Size(300, 24);
            this.cbbTourID.TabIndex = 2;
            this.cbbTourID.SelectedIndexChanged += new System.EventHandler(this.cbbTourID_SelectedIndexChanged);
            // 
            // cbbGroupTourID
            // 
            this.cbbGroupTourID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGroupTourID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGroupTourID.FormattingEnabled = true;
            this.cbbGroupTourID.ItemHeight = 16;
            this.cbbGroupTourID.Location = new System.Drawing.Point(129, 26);
            this.cbbGroupTourID.Name = "cbbGroupTourID";
            this.cbbGroupTourID.Size = new System.Drawing.Size(300, 24);
            this.cbbGroupTourID.TabIndex = 1;
            this.cbbGroupTourID.SelectedIndexChanged += new System.EventHandler(this.cbbGroupTourID_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPickup);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtRoom);
            this.groupBox2.Controls.Add(this.txtCustomer);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 383);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 147);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Khách hàng";
            // 
            // txtPickup
            // 
            this.txtPickup.Depth = 0;
            this.txtPickup.Hint = "Nhập nơi đón khách";
            this.txtPickup.Location = new System.Drawing.Point(129, 111);
            this.txtPickup.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPickup.Name = "txtPickup";
            this.txtPickup.PasswordChar = '\0';
            this.txtPickup.SelectedText = "";
            this.txtPickup.SelectionLength = 0;
            this.txtPickup.SelectionStart = 0;
            this.txtPickup.Size = new System.Drawing.Size(300, 23);
            this.txtPickup.TabIndex = 7;
            this.txtPickup.UseSystemPasswordChar = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(19, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Pick up";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(19, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Room";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(19, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên KH";
            // 
            // txtRoom
            // 
            this.txtRoom.Depth = 0;
            this.txtRoom.Hint = "Nhập số phòng khách sạn";
            this.txtRoom.Location = new System.Drawing.Point(129, 72);
            this.txtRoom.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.PasswordChar = '\0';
            this.txtRoom.SelectedText = "";
            this.txtRoom.SelectionLength = 0;
            this.txtRoom.SelectionStart = 0;
            this.txtRoom.Size = new System.Drawing.Size(300, 23);
            this.txtRoom.TabIndex = 7;
            this.txtRoom.UseSystemPasswordChar = false;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Depth = 0;
            this.txtCustomer.Hint = "Nhập tên khách khàng";
            this.txtCustomer.Location = new System.Drawing.Point(129, 28);
            this.txtCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.PasswordChar = '\0';
            this.txtCustomer.SelectedText = "";
            this.txtCustomer.SelectionLength = 0;
            this.txtCustomer.SelectionStart = 0;
            this.txtCustomer.Size = new System.Drawing.Size(300, 23);
            this.txtCustomer.TabIndex = 7;
            this.txtCustomer.UseSystemPasswordChar = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dataGridViewGroupTour);
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.materialSingleLineTextField5);
            this.groupBox3.Controls.Add(this.txtPartnerPrice);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtPriceVTQ);
            this.groupBox3.Controls.Add(this.btnAddServiceType);
            this.groupBox3.Controls.Add(this.txtPriceSa);
            this.groupBox3.Controls.Add(this.txtPriceRe);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(464, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(488, 406);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dịch vụ";
            // 
            // dataGridViewGroupTour
            // 
            this.dataGridViewGroupTour.AllowUserToAddRows = false;
            this.dataGridViewGroupTour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGroupTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGroupTour.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewGroupTour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewGroupTour.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGroupTour.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewGroupTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPartnerID,
            this.colServiceType,
            this.colPrice,
            this.colRemove});
            this.dataGridViewGroupTour.Location = new System.Drawing.Point(6, 191);
            this.dataGridViewGroupTour.MultiSelect = false;
            this.dataGridViewGroupTour.Name = "dataGridViewGroupTour";
            this.dataGridViewGroupTour.ReadOnly = true;
            this.dataGridViewGroupTour.RowHeadersWidth = 35;
            this.dataGridViewGroupTour.RowTemplate.Height = 23;
            this.dataGridViewGroupTour.RowTemplate.ReadOnly = true;
            this.dataGridViewGroupTour.Size = new System.Drawing.Size(476, 120);
            this.dataGridViewGroupTour.TabIndex = 8;
            // 
            // colPartnerID
            // 
            this.colPartnerID.DataPropertyName = "PartnerID";
            this.colPartnerID.HeaderText = "ID";
            this.colPartnerID.Name = "colPartnerID";
            this.colPartnerID.ReadOnly = true;
            this.colPartnerID.Visible = false;
            // 
            // colServiceType
            // 
            this.colServiceType.DataPropertyName = "ServiceType";
            this.colServiceType.HeaderText = "Loại dịch vụ";
            this.colServiceType.Name = "colServiceType";
            this.colServiceType.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPrice.DataPropertyName = "Price";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "#,###";
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle14;
            this.colPrice.HeaderText = "Đơn giá";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 120;
            // 
            // colRemove
            // 
            this.colRemove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.colRemove.DefaultCellStyle = dataGridViewCellStyle15;
            this.colRemove.HeaderText = "";
            this.colRemove.Name = "colRemove";
            this.colRemove.ReadOnly = true;
            this.colRemove.Text = "Xóa";
            this.colRemove.UseColumnTextForButtonValue = true;
            this.colRemove.Width = 60;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Red;
            this.txtTotal.Location = new System.Drawing.Point(292, 346);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(190, 47);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.Text = "1900000000";
            this.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.numPromotionPer);
            this.panel1.Controls.Add(this.txtPromotionPrice);
            this.panel1.Location = new System.Drawing.Point(6, 319);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 79);
            this.panel1.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Maroon;
            this.label17.Location = new System.Drawing.Point(50, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 17);
            this.label17.TabIndex = 0;
            this.label17.Text = "(%)";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label21.Location = new System.Drawing.Point(9, 44);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 17);
            this.label21.TabIndex = 0;
            this.label21.Text = "Số tiền";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(9, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 17);
            this.label16.TabIndex = 0;
            this.label16.Text = "Giảm";
            // 
            // numPromotionPer
            // 
            this.numPromotionPer.Location = new System.Drawing.Point(86, 13);
            this.numPromotionPer.Name = "numPromotionPer";
            this.numPromotionPer.Size = new System.Drawing.Size(60, 23);
            this.numPromotionPer.TabIndex = 6;
            this.numPromotionPer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtPromotionPrice
            // 
            this.txtPromotionPrice.Depth = 0;
            this.txtPromotionPrice.Hint = "(vnđ)";
            this.txtPromotionPrice.Location = new System.Drawing.Point(86, 42);
            this.txtPromotionPrice.MaximumSize = new System.Drawing.Size(188, 23);
            this.txtPromotionPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPromotionPrice.Name = "txtPromotionPrice";
            this.txtPromotionPrice.PasswordChar = '\0';
            this.txtPromotionPrice.SelectedText = "";
            this.txtPromotionPrice.SelectionLength = 0;
            this.txtPromotionPrice.SelectionStart = 0;
            this.txtPromotionPrice.Size = new System.Drawing.Size(173, 23);
            this.txtPromotionPrice.TabIndex = 7;
            this.txtPromotionPrice.UseSystemPasswordChar = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.ForestGreen;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(292, 319);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(2);
            this.label18.Size = new System.Drawing.Size(88, 24);
            this.label18.TabIndex = 0;
            this.label18.Text = "Tổng cộng";
            // 
            // materialSingleLineTextField5
            // 
            this.materialSingleLineTextField5.Depth = 0;
            this.materialSingleLineTextField5.Hint = "";
            this.materialSingleLineTextField5.Location = new System.Drawing.Point(100, 125);
            this.materialSingleLineTextField5.MaximumSize = new System.Drawing.Size(355, 23);
            this.materialSingleLineTextField5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField5.Name = "materialSingleLineTextField5";
            this.materialSingleLineTextField5.PasswordChar = '\0';
            this.materialSingleLineTextField5.SelectedText = "";
            this.materialSingleLineTextField5.SelectionLength = 0;
            this.materialSingleLineTextField5.SelectionStart = 0;
            this.materialSingleLineTextField5.Size = new System.Drawing.Size(355, 23);
            this.materialSingleLineTextField5.TabIndex = 7;
            this.materialSingleLineTextField5.UseSystemPasswordChar = false;
            // 
            // txtPartnerPrice
            // 
            this.txtPartnerPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPartnerPrice.Depth = 0;
            this.txtPartnerPrice.Hint = "(vnđ)";
            this.txtPartnerPrice.Location = new System.Drawing.Point(273, 94);
            this.txtPartnerPrice.MaximumSize = new System.Drawing.Size(182, 23);
            this.txtPartnerPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPartnerPrice.Name = "txtPartnerPrice";
            this.txtPartnerPrice.PasswordChar = '\0';
            this.txtPartnerPrice.SelectedText = "";
            this.txtPartnerPrice.SelectionLength = 0;
            this.txtPartnerPrice.SelectionStart = 0;
            this.txtPartnerPrice.Size = new System.Drawing.Size(182, 23);
            this.txtPartnerPrice.TabIndex = 7;
            this.txtPartnerPrice.UseSystemPasswordChar = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label20.Location = new System.Drawing.Point(6, 171);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 17);
            this.label20.TabIndex = 0;
            this.label20.Text = "Đính kèm";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(24, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Ghi chú";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(271, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Thu hộ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(25, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Giá VTQ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(270, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Giá bán";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(25, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Giá nhận";
            // 
            // txtPriceVTQ
            // 
            this.txtPriceVTQ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPriceVTQ.Depth = 0;
            this.txtPriceVTQ.Hint = "(vnđ)";
            this.txtPriceVTQ.Location = new System.Drawing.Point(28, 94);
            this.txtPriceVTQ.MaximumSize = new System.Drawing.Size(188, 23);
            this.txtPriceVTQ.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPriceVTQ.Name = "txtPriceVTQ";
            this.txtPriceVTQ.PasswordChar = '\0';
            this.txtPriceVTQ.SelectedText = "";
            this.txtPriceVTQ.SelectionLength = 0;
            this.txtPriceVTQ.SelectionStart = 0;
            this.txtPriceVTQ.Size = new System.Drawing.Size(188, 23);
            this.txtPriceVTQ.TabIndex = 7;
            this.txtPriceVTQ.UseSystemPasswordChar = false;
            // 
            // btnAddServiceType
            // 
            this.btnAddServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddServiceType.Location = new System.Drawing.Point(79, 169);
            this.btnAddServiceType.Name = "btnAddServiceType";
            this.btnAddServiceType.Size = new System.Drawing.Size(56, 20);
            this.btnAddServiceType.TabIndex = 4;
            this.btnAddServiceType.Text = "Thêm";
            this.btnAddServiceType.UseVisualStyleBackColor = true;
            this.btnAddServiceType.Click += new System.EventHandler(this.btnAddServiceType_Click);
            // 
            // txtPriceSa
            // 
            this.txtPriceSa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPriceSa.Depth = 0;
            this.txtPriceSa.Hint = "(vnđ)";
            this.txtPriceSa.Location = new System.Drawing.Point(274, 44);
            this.txtPriceSa.MaximumSize = new System.Drawing.Size(182, 23);
            this.txtPriceSa.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPriceSa.Name = "txtPriceSa";
            this.txtPriceSa.PasswordChar = '\0';
            this.txtPriceSa.SelectedText = "";
            this.txtPriceSa.SelectionLength = 0;
            this.txtPriceSa.SelectionStart = 0;
            this.txtPriceSa.Size = new System.Drawing.Size(182, 23);
            this.txtPriceSa.TabIndex = 7;
            this.txtPriceSa.UseSystemPasswordChar = false;
            // 
            // txtPriceRe
            // 
            this.txtPriceRe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPriceRe.Depth = 0;
            this.txtPriceRe.Hint = "(vnđ)";
            this.txtPriceRe.Location = new System.Drawing.Point(27, 44);
            this.txtPriceRe.MaximumSize = new System.Drawing.Size(188, 23);
            this.txtPriceRe.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPriceRe.Name = "txtPriceRe";
            this.txtPriceRe.PasswordChar = '\0';
            this.txtPriceRe.SelectedText = "";
            this.txtPriceRe.SelectionLength = 0;
            this.txtPriceRe.SelectionStart = 0;
            this.txtPriceRe.Size = new System.Drawing.Size(188, 23);
            this.txtPriceRe.TabIndex = 7;
            this.txtPriceRe.UseSystemPasswordChar = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Depth = 0;
            this.btnUpdate.Location = new System.Drawing.Point(470, 490);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Primary = true;
            this.btnUpdate.Size = new System.Drawing.Size(154, 40);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Depth = 0;
            this.btnBack.Location = new System.Drawing.Point(794, 490);
            this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.Primary = true;
            this.btnBack.Size = new System.Drawing.Size(158, 40);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmDetailsTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 542);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCancel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(964, 542);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(964, 542);
            this.Name = "frmDetailsTour";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin chi tiết";
            this.Load += new System.EventHandler(this.frmActionGroupTour_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPax)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupTour)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPromotionPer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMsgPax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSaleBook;
        private System.Windows.Forms.NumericUpDown numPax;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Button btnFindParnet;
        private System.Windows.Forms.ComboBox cbbPartnerID;
        private System.Windows.Forms.ComboBox cbbTourID;
        private System.Windows.Forms.ComboBox cbbGroupTourID;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPickup;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRoom;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCustomer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewGroupTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartnerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewButtonColumn colRemove;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numPromotionPer;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPromotionPrice;
        private System.Windows.Forms.Label label18;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPartnerPrice;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPriceVTQ;
        private System.Windows.Forms.Button btnAddServiceType;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPriceSa;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPriceRe;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdate;
        private MaterialSkin.Controls.MaterialRaisedButton btnBack;
    }
}