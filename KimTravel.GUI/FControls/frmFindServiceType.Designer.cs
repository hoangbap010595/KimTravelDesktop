namespace KimTravel.GUI.FControls
{
    partial class frmFindServiceType
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtPartner = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridViewGroupTour = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNameService = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupTour)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPartner
            // 
            this.txtPartner.Depth = 0;
            this.txtPartner.Hint = "Tìm kiếm theo tên dịch vụ";
            this.txtPartner.Location = new System.Drawing.Point(12, 83);
            this.txtPartner.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPartner.Name = "txtPartner";
            this.txtPartner.PasswordChar = '\0';
            this.txtPartner.SelectedText = "";
            this.txtPartner.SelectionLength = 0;
            this.txtPartner.SelectionStart = 0;
            this.txtPartner.Size = new System.Drawing.Size(481, 23);
            this.txtPartner.TabIndex = 1;
            this.txtPartner.UseSystemPasswordChar = false;
            this.txtPartner.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPartner_KeyPress);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.Depth = 0;
            this.btnUpdate.Location = new System.Drawing.Point(353, 409);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Primary = true;
            this.btnUpdate.Size = new System.Drawing.Size(135, 39);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Chọn";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridViewGroupTour
            // 
            this.dataGridViewGroupTour.AllowUserToAddRows = false;
            this.dataGridViewGroupTour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGroupTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewGroupTour.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewGroupTour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewGroupTour.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGroupTour.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewGroupTour.ColumnHeadersHeight = 30;
            this.dataGridViewGroupTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colPrice});
            this.dataGridViewGroupTour.Location = new System.Drawing.Point(12, 112);
            this.dataGridViewGroupTour.MultiSelect = false;
            this.dataGridViewGroupTour.Name = "dataGridViewGroupTour";
            this.dataGridViewGroupTour.ReadOnly = true;
            this.dataGridViewGroupTour.RowHeadersWidth = 35;
            this.dataGridViewGroupTour.RowTemplate.Height = 25;
            this.dataGridViewGroupTour.RowTemplate.ReadOnly = true;
            this.dataGridViewGroupTour.Size = new System.Drawing.Size(481, 202);
            this.dataGridViewGroupTour.TabIndex = 0;
            this.dataGridViewGroupTour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGroupTour_CellClick);
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
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Tên dịch vụ";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPrice.DataPropertyName = "Price";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "#,###";
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle6;
            this.colPrice.HeaderText = "Giá";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 145;
            // 
            // txtNameService
            // 
            this.txtNameService.Depth = 0;
            this.txtNameService.Hint = "Nhập tên dịch vụ";
            this.txtNameService.Location = new System.Drawing.Point(111, 327);
            this.txtNameService.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNameService.Name = "txtNameService";
            this.txtNameService.PasswordChar = '\0';
            this.txtNameService.SelectedText = "";
            this.txtNameService.SelectionLength = 0;
            this.txtNameService.SelectionStart = 0;
            this.txtNameService.Size = new System.Drawing.Size(210, 23);
            this.txtNameService.TabIndex = 2;
            this.txtNameService.UseSystemPasswordChar = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(12, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tên dịch vụ";
            // 
            // txtPrice
            // 
            this.txtPrice.Depth = 0;
            this.txtPrice.Hint = "Nhập đơn giá";
            this.txtPrice.Location = new System.Drawing.Point(111, 356);
            this.txtPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.Size = new System.Drawing.Size(210, 23);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.UseSystemPasswordChar = false;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giá";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.Depth = 0;
            this.btnBack.Location = new System.Drawing.Point(12, 409);
            this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.Primary = true;
            this.btnBack.Size = new System.Drawing.Size(135, 39);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(339, 328);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoi.TabIndex = 4;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(339, 356);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(418, 328);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 51);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmFindServiceType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 460);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtNameService);
            this.Controls.Add(this.dataGridViewGroupTour);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtPartner);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 460);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 460);
            this.Name = "frmFindServiceType";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn loại dịch vụ";
            this.Load += new System.EventHandler(this.frmActionGroupTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupTour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtPartner;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdate;
        private System.Windows.Forms.DataGridView dataGridViewGroupTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNameService;
        private System.Windows.Forms.Label label9;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrice;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton btnBack;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
    }
}