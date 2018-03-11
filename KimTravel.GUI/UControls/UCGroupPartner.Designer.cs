namespace KimTravel.GUI.UControls
{
    partial class UCGroupPartner
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewGroupTour = new System.Windows.Forms.DataGridView();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgGroupPartner = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddGroupPartner = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.colKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroupNamePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTourPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriceRe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupTour)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGroupPartner)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewGroupTour
            // 
            this.dataGridViewGroupTour.AllowUserToAddRows = false;
            this.dataGridViewGroupTour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGroupTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGroupTour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewGroupTour.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGroupTour.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewGroupTour.ColumnHeadersHeight = 30;
            this.dataGridViewGroupTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKey,
            this.colGroupNamePrice,
            this.colTourPrice,
            this.colPriceRe,
            this.ActionUpdate});
            this.dataGridViewGroupTour.Location = new System.Drawing.Point(6, 77);
            this.dataGridViewGroupTour.MultiSelect = false;
            this.dataGridViewGroupTour.Name = "dataGridViewGroupTour";
            this.dataGridViewGroupTour.ReadOnly = true;
            this.dataGridViewGroupTour.RowHeadersWidth = 35;
            this.dataGridViewGroupTour.RowTemplate.Height = 25;
            this.dataGridViewGroupTour.RowTemplate.ReadOnly = true;
            this.dataGridViewGroupTour.Size = new System.Drawing.Size(614, 423);
            this.dataGridViewGroupTour.TabIndex = 0;
            this.dataGridViewGroupTour.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewGroupTour.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewGroupTour_RowPostPaint);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(6, 46);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(100, 25);
            this.btnThemMoi.TabIndex = 4;
            this.btnThemMoi.Text = "Thêm";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.dtgGroupPartner);
            this.groupBox1.Controls.Add(this.btnAddGroupPartner);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 507);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhóm đối tác";
            // 
            // dtgGroupPartner
            // 
            this.dtgGroupPartner.AllowUserToAddRows = false;
            this.dtgGroupPartner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgGroupPartner.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgGroupPartner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgGroupPartner.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgGroupPartner.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgGroupPartner.ColumnHeadersHeight = 30;
            this.dtgGroupPartner.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colGroupName,
            this.dataGridViewButtonColumn1});
            this.dtgGroupPartner.Location = new System.Drawing.Point(6, 77);
            this.dtgGroupPartner.MultiSelect = false;
            this.dtgGroupPartner.Name = "dtgGroupPartner";
            this.dtgGroupPartner.ReadOnly = true;
            this.dtgGroupPartner.RowHeadersWidth = 35;
            this.dtgGroupPartner.RowTemplate.Height = 25;
            this.dtgGroupPartner.RowTemplate.ReadOnly = true;
            this.dtgGroupPartner.Size = new System.Drawing.Size(409, 424);
            this.dtgGroupPartner.TabIndex = 1;
            this.dtgGroupPartner.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgGroupPartner_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "GroupPartnerID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // colGroupName
            // 
            this.colGroupName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGroupName.DataPropertyName = "GroupName";
            this.colGroupName.HeaderText = "Tên nhóm";
            this.colGroupName.Name = "colGroupName";
            this.colGroupName.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewButtonColumn1.HeaderText = "Cập nhật";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "Sửa";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn1.Width = 80;
            // 
            // btnAddGroupPartner
            // 
            this.btnAddGroupPartner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddGroupPartner.Location = new System.Drawing.Point(6, 44);
            this.btnAddGroupPartner.Name = "btnAddGroupPartner";
            this.btnAddGroupPartner.Size = new System.Drawing.Size(100, 25);
            this.btnAddGroupPartner.TabIndex = 4;
            this.btnAddGroupPartner.Text = "Thêm mới";
            this.btnAddGroupPartner.UseVisualStyleBackColor = true;
            this.btnAddGroupPartner.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnThemMoi);
            this.groupBox2.Controls.Add(this.dataGridViewGroupTour);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(430, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(626, 506);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thiết lập bảng giá theo nhóm";
            // 
            // colKey
            // 
            this.colKey.DataPropertyName = "Key";
            this.colKey.HeaderText = "ID";
            this.colKey.Name = "colKey";
            this.colKey.ReadOnly = true;
            this.colKey.Visible = false;
            // 
            // colGroupNamePrice
            // 
            this.colGroupNamePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colGroupNamePrice.DataPropertyName = "GroupName";
            this.colGroupNamePrice.HeaderText = "Nhóm";
            this.colGroupNamePrice.Name = "colGroupNamePrice";
            this.colGroupNamePrice.ReadOnly = true;
            this.colGroupNamePrice.Width = 140;
            // 
            // colTourPrice
            // 
            this.colTourPrice.DataPropertyName = "Name";
            this.colTourPrice.HeaderText = "Tour";
            this.colTourPrice.Name = "colTourPrice";
            this.colTourPrice.ReadOnly = true;
            // 
            // colPriceRe
            // 
            this.colPriceRe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPriceRe.DataPropertyName = "PriceRe";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "#,###";
            this.colPriceRe.DefaultCellStyle = dataGridViewCellStyle2;
            this.colPriceRe.HeaderText = "Giá nhận";
            this.colPriceRe.Name = "colPriceRe";
            this.colPriceRe.ReadOnly = true;
            this.colPriceRe.Width = 120;
            // 
            // ActionUpdate
            // 
            this.ActionUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.ActionUpdate.DefaultCellStyle = dataGridViewCellStyle3;
            this.ActionUpdate.HeaderText = "Cập nhật";
            this.ActionUpdate.Name = "ActionUpdate";
            this.ActionUpdate.ReadOnly = true;
            this.ActionUpdate.Text = "Sửa";
            this.ActionUpdate.UseColumnTextForButtonValue = true;
            this.ActionUpdate.Width = 80;
            // 
            // UCGroupPartner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCGroupPartner";
            this.Size = new System.Drawing.Size(1059, 513);
            this.Load += new System.EventHandler(this.UCGroupTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupTour)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGroupPartner)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewGroupTour;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgGroupPartner;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupName;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddGroupPartner;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupNamePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTourPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriceRe;
        private System.Windows.Forms.DataGridViewButtonColumn ActionUpdate;
    }
}
