namespace KimTravel.GUI.FControls
{
    partial class frmFindPartner
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtPartner = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridViewGroupTour = new System.Windows.Forms.DataGridView();
            this.colPartnerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPartnerCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupTour)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPartner
            // 
            this.txtPartner.Depth = 0;
            this.txtPartner.Hint = "Mã đối tác hoặc tên đối tác";
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
            this.btnUpdate.Depth = 0;
            this.btnUpdate.Location = new System.Drawing.Point(160, 268);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Primary = true;
            this.btnUpdate.Size = new System.Drawing.Size(180, 39);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Xác nhận";
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
            this.colPartnerID,
            this.colPartnerCode,
            this.colName,
            this.colAddress});
            this.dataGridViewGroupTour.Location = new System.Drawing.Point(12, 112);
            this.dataGridViewGroupTour.MultiSelect = false;
            this.dataGridViewGroupTour.Name = "dataGridViewGroupTour";
            this.dataGridViewGroupTour.ReadOnly = true;
            this.dataGridViewGroupTour.RowHeadersWidth = 35;
            this.dataGridViewGroupTour.RowTemplate.Height = 25;
            this.dataGridViewGroupTour.RowTemplate.ReadOnly = true;
            this.dataGridViewGroupTour.Size = new System.Drawing.Size(481, 150);
            this.dataGridViewGroupTour.TabIndex = 4;
            this.dataGridViewGroupTour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGroupTour_CellClick);
            // 
            // colPartnerID
            // 
            this.colPartnerID.DataPropertyName = "PartnerID";
            this.colPartnerID.HeaderText = "ID";
            this.colPartnerID.Name = "colPartnerID";
            this.colPartnerID.ReadOnly = true;
            this.colPartnerID.Visible = false;
            this.colPartnerID.Width = 43;
            // 
            // colPartnerCode
            // 
            this.colPartnerCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPartnerCode.DataPropertyName = "PartnerCode";
            this.colPartnerCode.HeaderText = "Mã ĐT";
            this.colPartnerCode.Name = "colPartnerCode";
            this.colPartnerCode.ReadOnly = true;
            this.colPartnerCode.Width = 80;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Tên";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 145;
            // 
            // colAddress
            // 
            this.colAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colAddress.DataPropertyName = "Address";
            this.colAddress.HeaderText = "Địa chỉ";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            this.colAddress.Width = 200;
            // 
            // frmFindPartner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 315);
            this.Controls.Add(this.dataGridViewGroupTour);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtPartner);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 315);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 315);
            this.Name = "frmFindPartner";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn đối tác";
            this.Load += new System.EventHandler(this.frmActionGroupTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupTour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtPartner;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdate;
        private System.Windows.Forms.DataGridView dataGridViewGroupTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartnerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartnerCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
    }
}