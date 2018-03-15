namespace KimTravel.GUI.FControls
{
    partial class frmActionUser
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
            this.txtUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtConfirmPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.ckLock = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.btnUpdatePass = new System.Windows.Forms.Button();
            this.panelPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Depth = 0;
            this.txtUsername.Hint = "";
            this.txtUsername.Location = new System.Drawing.Point(120, 85);
            this.txtUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.Size = new System.Drawing.Size(223, 23);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(9, 88);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(77, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Username";
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Enabled = false;
            this.txtEmail.Hint = "";
            this.txtEmail.Location = new System.Drawing.Point(120, 129);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(223, 23);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Enabled = false;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(9, 132);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(40, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Data";
            // 
            // txtPassword
            // 
            this.txtPassword.Depth = 0;
            this.txtPassword.Hint = "";
            this.txtPassword.Location = new System.Drawing.Point(104, 18);
            this.txtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.Size = new System.Drawing.Size(223, 23);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(13, 21);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(71, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Mật khẩu";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Depth = 0;
            this.btnUpdate.Location = new System.Drawing.Point(85, 397);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Primary = true;
            this.btnUpdate.Size = new System.Drawing.Size(180, 39);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Depth = 0;
            this.txtConfirmPass.Hint = "";
            this.txtConfirmPass.Location = new System.Drawing.Point(104, 59);
            this.txtConfirmPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '*';
            this.txtConfirmPass.SelectedText = "";
            this.txtConfirmPass.SelectionLength = 0;
            this.txtConfirmPass.SelectionStart = 0;
            this.txtConfirmPass.Size = new System.Drawing.Size(223, 23);
            this.txtConfirmPass.TabIndex = 6;
            this.txtConfirmPass.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(13, 62);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(64, 19);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Nhập lại";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(9, 178);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(76, 19);
            this.materialLabel6.TabIndex = 0;
            this.materialLabel6.Text = "Trạng thái";
            // 
            // cbbStatus
            // 
            this.cbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.ItemHeight = 16;
            this.cbbStatus.Location = new System.Drawing.Point(120, 174);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(223, 24);
            this.cbbStatus.TabIndex = 3;
            // 
            // ckLock
            // 
            this.ckLock.AutoSize = true;
            this.ckLock.BackColor = System.Drawing.Color.Transparent;
            this.ckLock.Depth = 0;
            this.ckLock.Font = new System.Drawing.Font("Roboto", 10F);
            this.ckLock.Location = new System.Drawing.Point(120, 212);
            this.ckLock.Margin = new System.Windows.Forms.Padding(0);
            this.ckLock.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckLock.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckLock.Name = "ckLock";
            this.ckLock.Ripple = true;
            this.ckLock.Size = new System.Drawing.Size(26, 30);
            this.ckLock.TabIndex = 4;
            this.ckLock.UseVisualStyleBackColor = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(9, 218);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(42, 19);
            this.materialLabel7.TabIndex = 8;
            this.materialLabel7.Text = "Lock";
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelPassword.Controls.Add(this.btnUpdatePass);
            this.panelPassword.Controls.Add(this.txtConfirmPass);
            this.panelPassword.Controls.Add(this.txtPassword);
            this.panelPassword.Controls.Add(this.materialLabel3);
            this.panelPassword.Controls.Add(this.materialLabel4);
            this.panelPassword.Location = new System.Drawing.Point(5, 253);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(341, 132);
            this.panelPassword.TabIndex = 9;
            // 
            // btnUpdatePass
            // 
            this.btnUpdatePass.Location = new System.Drawing.Point(212, 96);
            this.btnUpdatePass.Name = "btnUpdatePass";
            this.btnUpdatePass.Size = new System.Drawing.Size(119, 30);
            this.btnUpdatePass.TabIndex = 7;
            this.btnUpdatePass.Text = "Cập nhật mật khẩu";
            this.btnUpdatePass.UseVisualStyleBackColor = true;
            this.btnUpdatePass.Click += new System.EventHandler(this.btnUpdatePass_Click);
            // 
            // frmActionUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 455);
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.ckLock);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.cbbStatus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUsername);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 455);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 455);
            this.Name = "frmActionUser";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmActionGroupTour";
            this.Load += new System.EventHandler(this.frmActionGroupTour_Load);
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsername;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdate;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtConfirmPass;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.ComboBox cbbStatus;
        private MaterialSkin.Controls.MaterialCheckBox ckLock;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.Button btnUpdatePass;
    }
}