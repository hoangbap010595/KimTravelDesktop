namespace KimTravel.GUI.UControls
{
    partial class UCRoleViewReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgPartner = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgAccount = new System.Windows.Forms.DataGridView();
            this.colPartnerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblText = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPartner)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgPartner
            // 
            this.dtgPartner.AllowUserToAddRows = false;
            this.dtgPartner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgPartner.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPartner.BackgroundColor = System.Drawing.Color.White;
            this.dtgPartner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgPartner.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPartner.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgPartner.ColumnHeadersHeight = 30;
            this.dtgPartner.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPartnerID,
            this.colName,
            this.colAddress,
            this.colCheck});
            this.dtgPartner.Location = new System.Drawing.Point(244, 53);
            this.dtgPartner.MultiSelect = false;
            this.dtgPartner.Name = "dtgPartner";
            this.dtgPartner.RowHeadersWidth = 35;
            this.dtgPartner.RowTemplate.Height = 25;
            this.dtgPartner.Size = new System.Drawing.Size(610, 448);
            this.dtgPartner.TabIndex = 0;
            this.dtgPartner.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPartner_CellValueChanged);
            this.dtgPartner.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewGroupTour_RowPostPaint);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.lblText);
            this.groupBox1.Controls.Add(this.dtgAccount);
            this.groupBox1.Controls.Add(this.dtgPartner);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 507);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phân quyền";
            // 
            // dtgAccount
            // 
            this.dtgAccount.AllowUserToAddRows = false;
            this.dtgAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAccount.BackgroundColor = System.Drawing.Color.White;
            this.dtgAccount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgAccount.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgAccount.ColumnHeadersHeight = 30;
            this.dtgAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUID,
            this.colUserName});
            this.dtgAccount.Location = new System.Drawing.Point(6, 53);
            this.dtgAccount.MultiSelect = false;
            this.dtgAccount.Name = "dtgAccount";
            this.dtgAccount.ReadOnly = true;
            this.dtgAccount.RowHeadersWidth = 35;
            this.dtgAccount.RowTemplate.Height = 25;
            this.dtgAccount.RowTemplate.ReadOnly = true;
            this.dtgAccount.Size = new System.Drawing.Size(232, 448);
            this.dtgAccount.TabIndex = 1;
            this.dtgAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAccount_CellClick);
            // 
            // colPartnerID
            // 
            this.colPartnerID.DataPropertyName = "PartnerID";
            this.colPartnerID.HeaderText = "ID";
            this.colPartnerID.Name = "colPartnerID";
            this.colPartnerID.Visible = false;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Tên đối tác";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 140;
            // 
            // colAddress
            // 
            this.colAddress.DataPropertyName = "Address";
            this.colAddress.HeaderText = "Địa chỉ";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            // 
            // colCheck
            // 
            this.colCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCheck.HeaderText = "Xem báo cáo";
            this.colCheck.Name = "colCheck";
            this.colCheck.Width = 120;
            // 
            // colUID
            // 
            this.colUID.DataPropertyName = "ID";
            this.colUID.HeaderText = "ID";
            this.colUID.Name = "colUID";
            this.colUID.ReadOnly = true;
            this.colUID.Visible = false;
            // 
            // colUserName
            // 
            this.colUserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUserName.DataPropertyName = "Username";
            this.colUserName.HeaderText = "Tên tài khoản";
            this.colUserName.Name = "colUserName";
            this.colUserName.ReadOnly = true;
            // 
            // lblText
            // 
            this.lblText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblText.Location = new System.Drawing.Point(182, 21);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(154, 29);
            this.lblText.TabIndex = 0;
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(710, 21);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 29);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thiết lập quyền account:";
            // 
            // UCRoleViewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UCRoleViewReport";
            this.Size = new System.Drawing.Size(1059, 513);
            this.Load += new System.EventHandler(this.UCGroupTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPartner)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgPartner;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartnerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
    }
}
