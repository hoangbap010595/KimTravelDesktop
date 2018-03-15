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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewGroupTour = new System.Windows.Forms.DataGridView();
            this.colTourID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colPriceReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriceSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriceVTQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.cbbGroupTour = new System.Windows.Forms.ComboBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupTour)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGroupTour
            // 
            this.dataGridViewGroupTour.AllowUserToAddRows = false;
            this.dataGridViewGroupTour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGroupTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGroupTour.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewGroupTour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewGroupTour.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGroupTour.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
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
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.Format = "dd-MM-yyyy";
            dataGridViewCellStyle20.NullValue = null;
            this.colDateCreate.DefaultCellStyle = dataGridViewCellStyle20;
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
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle21.Format = "#,###";
            dataGridViewCellStyle21.NullValue = null;
            this.colPriceReceive.DefaultCellStyle = dataGridViewCellStyle21;
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
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Format = "#,###";
            this.colPriceSale.DefaultCellStyle = dataGridViewCellStyle22;
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
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle23.Format = "#,###";
            this.colPriceVTQ.DefaultCellStyle = dataGridViewCellStyle23;
            this.colPriceVTQ.HeaderText = "Giá vé tham quan";
            this.colPriceVTQ.Name = "colPriceVTQ";
            this.colPriceVTQ.ReadOnly = true;
            this.colPriceVTQ.Width = 130;
            // 
            // ActionUpdate
            // 
            this.ActionUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.ActionUpdate.DefaultCellStyle = dataGridViewCellStyle24;
            this.ActionUpdate.HeaderText = "Cập nhật";
            this.ActionUpdate.Name = "ActionUpdate";
            this.ActionUpdate.ReadOnly = true;
            this.ActionUpdate.Text = "Sửa";
            this.ActionUpdate.UseColumnTextForButtonValue = true;
            this.ActionUpdate.Width = 80;
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
            // cbbGroupTour
            // 
            this.cbbGroupTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGroupTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGroupTour.FormattingEnabled = true;
            this.cbbGroupTour.ItemHeight = 16;
            this.cbbGroupTour.Location = new System.Drawing.Point(97, 12);
            this.cbbGroupTour.Name = "cbbGroupTour";
            this.cbbGroupTour.Size = new System.Drawing.Size(223, 24);
            this.cbbGroupTour.TabIndex = 8;
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
            this.materialLabel6.Size = new System.Drawing.Size(81, 19);
            this.materialLabel6.TabIndex = 0;
            this.materialLabel6.Text = "Nhóm tour";
            // 
            // UCTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbbGroupTour);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.dataGridViewGroupTour);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnThemMoi);
            this.Name = "UCTour";
            this.Size = new System.Drawing.Size(1059, 513);
            this.Load += new System.EventHandler(this.UCGroupTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupTour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewGroupTour;
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
        private System.Windows.Forms.ComboBox cbbGroupTour;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
    }
}
