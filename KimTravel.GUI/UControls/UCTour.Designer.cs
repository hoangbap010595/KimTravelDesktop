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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dataGridViewGroupTour = new System.Windows.Forms.DataGridView();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.colTourID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colPriceReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriceSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriceVTQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupTour)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "Nhập nội dung tìm kiếm";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(7, 13);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(390, 23);
            this.materialSingleLineTextField1.TabIndex = 1;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGroupTour.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewGroupTour.ColumnHeadersHeight = 30;
            this.dataGridViewGroupTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTourID,
            this.colGName,
            this.colName,
            this.colDateCreate,
            this.colEnable,
            this.colPriceReceive,
            this.colPriceSale,
            this.colPriceVTQ,
            this.ActionUpdate});
            this.dataGridViewGroupTour.Location = new System.Drawing.Point(3, 42);
            this.dataGridViewGroupTour.MultiSelect = false;
            this.dataGridViewGroupTour.Name = "dataGridViewGroupTour";
            this.dataGridViewGroupTour.ReadOnly = true;
            this.dataGridViewGroupTour.RowHeadersWidth = 35;
            this.dataGridViewGroupTour.RowTemplate.Height = 25;
            this.dataGridViewGroupTour.RowTemplate.ReadOnly = true;
            this.dataGridViewGroupTour.Size = new System.Drawing.Size(1053, 468);
            this.dataGridViewGroupTour.TabIndex = 0;
            this.dataGridViewGroupTour.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewGroupTour.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewGroupTour_RowPostPaint);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMoi.Location = new System.Drawing.Point(956, 11);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(100, 25);
            this.btnThemMoi.TabIndex = 3;
            this.btnThemMoi.Text = "Thêm";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(850, 11);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 25);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Làm mới";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // colTourID
            // 
            this.colTourID.DataPropertyName = "TourID";
            this.colTourID.HeaderText = "ID";
            this.colTourID.Name = "colTourID";
            this.colTourID.ReadOnly = true;
            this.colTourID.Visible = false;
            // 
            // colGName
            // 
            this.colGName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colGName.DataPropertyName = "GName";
            this.colGName.HeaderText = "Nhóm tour";
            this.colGName.Name = "colGName";
            this.colGName.ReadOnly = true;
            this.colGName.Width = 130;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Tên tour";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colDateCreate
            // 
            this.colDateCreate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDateCreate.DataPropertyName = "DateCreate";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "dd-MM-yyyy";
            dataGridViewCellStyle2.NullValue = null;
            this.colDateCreate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDateCreate.HeaderText = "Ngày tạo";
            this.colDateCreate.Name = "colDateCreate";
            this.colDateCreate.ReadOnly = true;
            this.colDateCreate.Width = 120;
            // 
            // colEnable
            // 
            this.colEnable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colEnable.DataPropertyName = "Enable";
            this.colEnable.HeaderText = "Kích hoạt";
            this.colEnable.Name = "colEnable";
            this.colEnable.ReadOnly = true;
            this.colEnable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEnable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colEnable.Width = 120;
            // 
            // colPriceReceive
            // 
            this.colPriceReceive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPriceReceive.DataPropertyName = "PriceReceive";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "#,###";
            dataGridViewCellStyle3.NullValue = null;
            this.colPriceReceive.DefaultCellStyle = dataGridViewCellStyle3;
            this.colPriceReceive.HeaderText = "Giá nhận";
            this.colPriceReceive.Name = "colPriceReceive";
            this.colPriceReceive.ReadOnly = true;
            this.colPriceReceive.Visible = false;
            this.colPriceReceive.Width = 130;
            // 
            // colPriceSale
            // 
            this.colPriceSale.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPriceSale.DataPropertyName = "PriceSale";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "#,###";
            this.colPriceSale.DefaultCellStyle = dataGridViewCellStyle4;
            this.colPriceSale.HeaderText = "Giá bán";
            this.colPriceSale.Name = "colPriceSale";
            this.colPriceSale.ReadOnly = true;
            this.colPriceSale.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPriceSale.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPriceSale.Width = 130;
            // 
            // colPriceVTQ
            // 
            this.colPriceVTQ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPriceVTQ.DataPropertyName = "PriceVTQ";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "#,###";
            this.colPriceVTQ.DefaultCellStyle = dataGridViewCellStyle5;
            this.colPriceVTQ.HeaderText = "Giá vé tham quan";
            this.colPriceVTQ.Name = "colPriceVTQ";
            this.colPriceVTQ.ReadOnly = true;
            this.colPriceVTQ.Width = 130;
            // 
            // ActionUpdate
            // 
            this.ActionUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.ActionUpdate.DefaultCellStyle = dataGridViewCellStyle6;
            this.ActionUpdate.HeaderText = "Cập nhật";
            this.ActionUpdate.Name = "ActionUpdate";
            this.ActionUpdate.ReadOnly = true;
            this.ActionUpdate.Text = "Sửa";
            this.ActionUpdate.UseColumnTextForButtonValue = true;
            this.ActionUpdate.Width = 80;
            // 
            // UCTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewGroupTour);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Name = "UCTour";
            this.Size = new System.Drawing.Size(1059, 513);
            this.Load += new System.EventHandler(this.UCGroupTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupTour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewGroupTour;
        private System.Windows.Forms.Button button1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTourID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateCreate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colEnable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriceReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriceSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriceVTQ;
        private System.Windows.Forms.DataGridViewButtonColumn ActionUpdate;
    }
}
