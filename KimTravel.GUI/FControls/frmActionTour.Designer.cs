namespace KimTravel.GUI.FControls
{
    partial class frmActionTour
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
            this.txtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtGiaBan = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtGiaNhan = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtPriceVTQ = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.cbbGroupTour = new System.Windows.Forms.ComboBox();
            this.ckEnabled = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Depth = 0;
            this.txtName.Hint = "";
            this.txtName.Location = new System.Drawing.Point(120, 139);
            this.txtName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(223, 23);
            this.txtName.TabIndex = 1;
            this.txtName.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(9, 142);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(65, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Tên tour";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Depth = 0;
            this.txtGiaBan.Hint = "";
            this.txtGiaBan.Location = new System.Drawing.Point(120, 183);
            this.txtGiaBan.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.PasswordChar = '\0';
            this.txtGiaBan.SelectedText = "";
            this.txtGiaBan.SelectionLength = 0;
            this.txtGiaBan.SelectionStart = 0;
            this.txtGiaBan.Size = new System.Drawing.Size(223, 23);
            this.txtGiaBan.TabIndex = 2;
            this.txtGiaBan.Text = "0";
            this.txtGiaBan.UseSystemPasswordChar = false;
            this.txtGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(9, 186);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(59, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Giá bán";
            // 
            // txtGiaNhan
            // 
            this.txtGiaNhan.Depth = 0;
            this.txtGiaNhan.Hint = "";
            this.txtGiaNhan.Location = new System.Drawing.Point(120, 225);
            this.txtGiaNhan.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtGiaNhan.Name = "txtGiaNhan";
            this.txtGiaNhan.PasswordChar = '\0';
            this.txtGiaNhan.SelectedText = "";
            this.txtGiaNhan.SelectionLength = 0;
            this.txtGiaNhan.SelectionStart = 0;
            this.txtGiaNhan.Size = new System.Drawing.Size(223, 23);
            this.txtGiaNhan.TabIndex = 3;
            this.txtGiaNhan.Text = "0";
            this.txtGiaNhan.UseSystemPasswordChar = false;
            this.txtGiaNhan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(9, 228);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(67, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Giá nhận";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Depth = 0;
            this.btnUpdate.Location = new System.Drawing.Point(85, 379);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Primary = true;
            this.btnUpdate.Size = new System.Drawing.Size(180, 39);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtPriceVTQ
            // 
            this.txtPriceVTQ.Depth = 0;
            this.txtPriceVTQ.Hint = "";
            this.txtPriceVTQ.Location = new System.Drawing.Point(120, 266);
            this.txtPriceVTQ.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPriceVTQ.Name = "txtPriceVTQ";
            this.txtPriceVTQ.PasswordChar = '\0';
            this.txtPriceVTQ.SelectedText = "";
            this.txtPriceVTQ.SelectionLength = 0;
            this.txtPriceVTQ.SelectionStart = 0;
            this.txtPriceVTQ.Size = new System.Drawing.Size(223, 23);
            this.txtPriceVTQ.TabIndex = 4;
            this.txtPriceVTQ.Text = "0";
            this.txtPriceVTQ.UseSystemPasswordChar = false;
            this.txtPriceVTQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(9, 269);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(64, 19);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Giá VTQ";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(9, 95);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(80, 19);
            this.materialLabel6.TabIndex = 0;
            this.materialLabel6.Text = "Group tour";
            // 
            // cbbGroupTour
            // 
            this.cbbGroupTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGroupTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGroupTour.FormattingEnabled = true;
            this.cbbGroupTour.ItemHeight = 16;
            this.cbbGroupTour.Location = new System.Drawing.Point(120, 92);
            this.cbbGroupTour.Name = "cbbGroupTour";
            this.cbbGroupTour.Size = new System.Drawing.Size(223, 24);
            this.cbbGroupTour.TabIndex = 6;
            // 
            // ckEnabled
            // 
            this.ckEnabled.AutoSize = true;
            this.ckEnabled.BackColor = System.Drawing.Color.Transparent;
            this.ckEnabled.Depth = 0;
            this.ckEnabled.Font = new System.Drawing.Font("Roboto", 10F);
            this.ckEnabled.Location = new System.Drawing.Point(120, 304);
            this.ckEnabled.Margin = new System.Windows.Forms.Padding(0);
            this.ckEnabled.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckEnabled.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckEnabled.Name = "ckEnabled";
            this.ckEnabled.Ripple = true;
            this.ckEnabled.Size = new System.Drawing.Size(26, 30);
            this.ckEnabled.TabIndex = 9;
            this.ckEnabled.UseVisualStyleBackColor = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(9, 309);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(72, 19);
            this.materialLabel7.TabIndex = 8;
            this.materialLabel7.Text = "Kích hoạt";
            // 
            // frmActionTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 455);
            this.Controls.Add(this.ckEnabled);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.cbbGroupTour);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtPriceVTQ);
            this.Controls.Add(this.txtGiaNhan);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.txtName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 455);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 455);
            this.Name = "frmActionTour";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmActionGroupTour";
            this.Load += new System.EventHandler(this.frmActionGroupTour_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtName;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtGiaBan;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtGiaNhan;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdate;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPriceVTQ;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.ComboBox cbbGroupTour;
        private MaterialSkin.Controls.MaterialCheckBox ckEnabled;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
    }
}