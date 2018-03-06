namespace KimTravel.GUI.UControls
{
    partial class UCGroupTour
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
            this.button1 = new System.Windows.Forms.Button();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dataGridViewGroupTour = new System.Windows.Forms.DataGridView();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.GroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinPax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxPax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnLoad = new System.Windows.Forms.Button();
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
            this.GroupID,
            this.GroupName,
            this.MinPax,
            this.MaxPax,
            this.DateCreate,
            this.Enable,
            this.Note,
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
            // GroupID
            // 
            this.GroupID.DataPropertyName = "GroupID";
            this.GroupID.HeaderText = "ID";
            this.GroupID.Name = "GroupID";
            this.GroupID.ReadOnly = true;
            this.GroupID.Visible = false;
            // 
            // GroupName
            // 
            this.GroupName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GroupName.DataPropertyName = "Name";
            this.GroupName.HeaderText = "Tên nhóm";
            this.GroupName.Name = "GroupName";
            this.GroupName.ReadOnly = true;
            this.GroupName.Width = 200;
            // 
            // MinPax
            // 
            this.MinPax.DataPropertyName = "MinPax";
            this.MinPax.HeaderText = "Số người tối thiểu";
            this.MinPax.Name = "MinPax";
            this.MinPax.ReadOnly = true;
            // 
            // MaxPax
            // 
            this.MaxPax.DataPropertyName = "MaxPax";
            this.MaxPax.HeaderText = "Số người tối đa";
            this.MaxPax.Name = "MaxPax";
            this.MaxPax.ReadOnly = true;
            // 
            // DateCreate
            // 
            this.DateCreate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DateCreate.DataPropertyName = "DateCreate";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "dd-MM-yyyy";
            dataGridViewCellStyle2.NullValue = null;
            this.DateCreate.DefaultCellStyle = dataGridViewCellStyle2;
            this.DateCreate.HeaderText = "Ngày tạo";
            this.DateCreate.Name = "DateCreate";
            this.DateCreate.ReadOnly = true;
            this.DateCreate.Width = 120;
            // 
            // Enable
            // 
            this.Enable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Enable.DataPropertyName = "Enable";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = false;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Enable.DefaultCellStyle = dataGridViewCellStyle3;
            this.Enable.HeaderText = "Kích hoạt";
            this.Enable.Name = "Enable";
            this.Enable.ReadOnly = true;
            this.Enable.Width = 80;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Ghi chú";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Note.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ActionUpdate
            // 
            this.ActionUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.ActionUpdate.DefaultCellStyle = dataGridViewCellStyle4;
            this.ActionUpdate.HeaderText = "Cập nhật";
            this.ActionUpdate.Name = "ActionUpdate";
            this.ActionUpdate.ReadOnly = true;
            this.ActionUpdate.Text = "Sửa";
            this.ActionUpdate.UseColumnTextForButtonValue = true;
            this.ActionUpdate.Width = 80;
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
            // UCGroupTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewGroupTour);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Name = "UCGroupTour";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinPax;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxPax;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCreate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Enable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewButtonColumn ActionUpdate;
        private System.Windows.Forms.Button btnLoad;
    }
}
