namespace KimTravel.GUI.UControls
{
    partial class UCBookCar
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
            this.dataGridViewGroupTour = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPartnerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPickUp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCar1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colCar2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colCar3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colCar4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colCar5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colCar6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colCar7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colCar8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colCar9 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colCar10 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnCar1 = new System.Windows.Forms.Button();
            this.btnCar2 = new System.Windows.Forms.Button();
            this.btnCar3 = new System.Windows.Forms.Button();
            this.btnCar4 = new System.Windows.Forms.Button();
            this.btnCar5 = new System.Windows.Forms.Button();
            this.btnCar6 = new System.Windows.Forms.Button();
            this.btnCar7 = new System.Windows.Forms.Button();
            this.btnCar8 = new System.Windows.Forms.Button();
            this.btnCar9 = new System.Windows.Forms.Button();
            this.btnCar10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupTour)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridViewGroupTour.ColumnHeadersHeight = 40;
            this.dataGridViewGroupTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colPartnerName,
            this.colPickUp,
            this.colRoom,
            this.colNote,
            this.colCar1,
            this.colCar2,
            this.colCar3,
            this.colCar4,
            this.colCar5,
            this.colCar6,
            this.colCar7,
            this.colCar8,
            this.colCar9,
            this.colCar10});
            this.dataGridViewGroupTour.Location = new System.Drawing.Point(3, 42);
            this.dataGridViewGroupTour.MultiSelect = false;
            this.dataGridViewGroupTour.Name = "dataGridViewGroupTour";
            this.dataGridViewGroupTour.ReadOnly = true;
            this.dataGridViewGroupTour.RowHeadersWidth = 35;
            this.dataGridViewGroupTour.RowTemplate.Height = 25;
            this.dataGridViewGroupTour.RowTemplate.ReadOnly = true;
            this.dataGridViewGroupTour.Size = new System.Drawing.Size(1053, 409);
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
            // colPartnerName
            // 
            this.colPartnerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPartnerName.DataPropertyName = "PartnerName";
            this.colPartnerName.HeaderText = "Đối tác";
            this.colPartnerName.Name = "colPartnerName";
            this.colPartnerName.ReadOnly = true;
            this.colPartnerName.Width = 150;
            // 
            // colPickUp
            // 
            this.colPickUp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPickUp.DataPropertyName = "PickUp";
            this.colPickUp.HeaderText = "Pick Up";
            this.colPickUp.Name = "colPickUp";
            this.colPickUp.ReadOnly = true;
            this.colPickUp.Width = 150;
            // 
            // colRoom
            // 
            this.colRoom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colRoom.DataPropertyName = "Room";
            this.colRoom.HeaderText = "Room";
            this.colRoom.Name = "colRoom";
            this.colRoom.ReadOnly = true;
            this.colRoom.Width = 60;
            // 
            // colNote
            // 
            this.colNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colNote.DataPropertyName = "Note";
            this.colNote.HeaderText = "Ghi chú";
            this.colNote.Name = "colNote";
            this.colNote.ReadOnly = true;
            this.colNote.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colNote.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colNote.Width = 120;
            // 
            // colCar1
            // 
            this.colCar1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.NullValue = false;
            this.colCar1.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCar1.HeaderText = "HDV_1 Xe_1";
            this.colCar1.Name = "colCar1";
            this.colCar1.ReadOnly = true;
            this.colCar1.Width = 55;
            // 
            // colCar2
            // 
            this.colCar2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCar2.HeaderText = "HDV_2 Xe_2";
            this.colCar2.Name = "colCar2";
            this.colCar2.ReadOnly = true;
            this.colCar2.Width = 55;
            // 
            // colCar3
            // 
            this.colCar3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCar3.HeaderText = "HDV_3 Xe_3";
            this.colCar3.Name = "colCar3";
            this.colCar3.ReadOnly = true;
            this.colCar3.Width = 55;
            // 
            // colCar4
            // 
            this.colCar4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCar4.HeaderText = "HDV_4 Xe_4";
            this.colCar4.Name = "colCar4";
            this.colCar4.ReadOnly = true;
            this.colCar4.Width = 55;
            // 
            // colCar5
            // 
            this.colCar5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCar5.HeaderText = "HDV_5 Xe_5";
            this.colCar5.Name = "colCar5";
            this.colCar5.ReadOnly = true;
            this.colCar5.Width = 55;
            // 
            // colCar6
            // 
            this.colCar6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCar6.HeaderText = "HDV_6 Xe_6";
            this.colCar6.Name = "colCar6";
            this.colCar6.ReadOnly = true;
            this.colCar6.Width = 55;
            // 
            // colCar7
            // 
            this.colCar7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCar7.HeaderText = "HDV_7 Xe_7";
            this.colCar7.Name = "colCar7";
            this.colCar7.ReadOnly = true;
            this.colCar7.Width = 55;
            // 
            // colCar8
            // 
            this.colCar8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCar8.HeaderText = "HDV_8 Xe_8";
            this.colCar8.Name = "colCar8";
            this.colCar8.ReadOnly = true;
            this.colCar8.Width = 55;
            // 
            // colCar9
            // 
            this.colCar9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCar9.HeaderText = "HDV_9 Xe_9";
            this.colCar9.Name = "colCar9";
            this.colCar9.ReadOnly = true;
            this.colCar9.Width = 55;
            // 
            // colCar10
            // 
            this.colCar10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCar10.HeaderText = "HDV_10 Xe_10";
            this.colCar10.Name = "colCar10";
            this.colCar10.ReadOnly = true;
            this.colCar10.Width = 55;
            // 
            // btnCar1
            // 
            this.btnCar1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCar1.ForeColor = System.Drawing.Color.Red;
            this.btnCar1.Location = new System.Drawing.Point(3, 478);
            this.btnCar1.Name = "btnCar1";
            this.btnCar1.Size = new System.Drawing.Size(62, 32);
            this.btnCar1.TabIndex = 1;
            this.btnCar1.Text = "Xe 1";
            this.btnCar1.UseVisualStyleBackColor = true;
            // 
            // btnCar2
            // 
            this.btnCar2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCar2.Location = new System.Drawing.Point(71, 478);
            this.btnCar2.Name = "btnCar2";
            this.btnCar2.Size = new System.Drawing.Size(62, 32);
            this.btnCar2.TabIndex = 2;
            this.btnCar2.Text = "Xe 2";
            this.btnCar2.UseVisualStyleBackColor = true;
            // 
            // btnCar3
            // 
            this.btnCar3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCar3.ForeColor = System.Drawing.Color.Black;
            this.btnCar3.Location = new System.Drawing.Point(139, 478);
            this.btnCar3.Name = "btnCar3";
            this.btnCar3.Size = new System.Drawing.Size(62, 32);
            this.btnCar3.TabIndex = 3;
            this.btnCar3.Text = "Xe 3";
            this.btnCar3.UseVisualStyleBackColor = true;
            // 
            // btnCar4
            // 
            this.btnCar4.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnCar4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCar4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnCar4.Location = new System.Drawing.Point(207, 478);
            this.btnCar4.Name = "btnCar4";
            this.btnCar4.Size = new System.Drawing.Size(62, 32);
            this.btnCar4.TabIndex = 4;
            this.btnCar4.Text = "Xe 4";
            this.btnCar4.UseVisualStyleBackColor = true;
            // 
            // btnCar5
            // 
            this.btnCar5.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnCar5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCar5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCar5.ForeColor = System.Drawing.Color.Green;
            this.btnCar5.Location = new System.Drawing.Point(275, 478);
            this.btnCar5.Name = "btnCar5";
            this.btnCar5.Size = new System.Drawing.Size(62, 32);
            this.btnCar5.TabIndex = 5;
            this.btnCar5.Text = "Xe 5";
            this.btnCar5.UseVisualStyleBackColor = true;
            // 
            // btnCar6
            // 
            this.btnCar6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCar6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCar6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCar6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCar6.Location = new System.Drawing.Point(343, 478);
            this.btnCar6.Name = "btnCar6";
            this.btnCar6.Size = new System.Drawing.Size(62, 32);
            this.btnCar6.TabIndex = 6;
            this.btnCar6.Text = "Xe 6";
            this.btnCar6.UseVisualStyleBackColor = true;
            // 
            // btnCar7
            // 
            this.btnCar7.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnCar7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCar7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCar7.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnCar7.Location = new System.Drawing.Point(411, 478);
            this.btnCar7.Name = "btnCar7";
            this.btnCar7.Size = new System.Drawing.Size(62, 32);
            this.btnCar7.TabIndex = 7;
            this.btnCar7.Text = "Xe 7";
            this.btnCar7.UseVisualStyleBackColor = true;
            // 
            // btnCar8
            // 
            this.btnCar8.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnCar8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCar8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCar8.ForeColor = System.Drawing.Color.Blue;
            this.btnCar8.Location = new System.Drawing.Point(479, 478);
            this.btnCar8.Name = "btnCar8";
            this.btnCar8.Size = new System.Drawing.Size(62, 32);
            this.btnCar8.TabIndex = 8;
            this.btnCar8.Text = "Xe 8";
            this.btnCar8.UseVisualStyleBackColor = true;
            // 
            // btnCar9
            // 
            this.btnCar9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCar9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCar9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCar9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCar9.Location = new System.Drawing.Point(547, 478);
            this.btnCar9.Name = "btnCar9";
            this.btnCar9.Size = new System.Drawing.Size(62, 32);
            this.btnCar9.TabIndex = 9;
            this.btnCar9.Text = "Xe 9";
            this.btnCar9.UseVisualStyleBackColor = true;
            // 
            // btnCar10
            // 
            this.btnCar10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCar10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCar10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCar10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCar10.Location = new System.Drawing.Point(615, 478);
            this.btnCar10.Name = "btnCar10";
            this.btnCar10.Size = new System.Drawing.Size(62, 32);
            this.btnCar10.TabIndex = 10;
            this.btnCar10.Text = "Xe 10";
            this.btnCar10.UseVisualStyleBackColor = true;
            // 
            // UCBookCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCar10);
            this.Controls.Add(this.btnCar9);
            this.Controls.Add(this.btnCar8);
            this.Controls.Add(this.btnCar7);
            this.Controls.Add(this.btnCar6);
            this.Controls.Add(this.btnCar5);
            this.Controls.Add(this.btnCar4);
            this.Controls.Add(this.btnCar3);
            this.Controls.Add(this.btnCar2);
            this.Controls.Add(this.btnCar1);
            this.Controls.Add(this.dataGridViewGroupTour);
            this.Name = "UCBookCar";
            this.Size = new System.Drawing.Size(1059, 513);
            this.Load += new System.EventHandler(this.UCGroupTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupTour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewGroupTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartnerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPickUp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNote;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCar1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCar2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCar3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCar4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCar5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCar6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCar7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCar8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCar9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCar10;
        private System.Windows.Forms.Button btnCar1;
        private System.Windows.Forms.Button btnCar2;
        private System.Windows.Forms.Button btnCar3;
        private System.Windows.Forms.Button btnCar4;
        private System.Windows.Forms.Button btnCar5;
        private System.Windows.Forms.Button btnCar6;
        private System.Windows.Forms.Button btnCar7;
        private System.Windows.Forms.Button btnCar8;
        private System.Windows.Forms.Button btnCar9;
        private System.Windows.Forms.Button btnCar10;
    }
}
