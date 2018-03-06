namespace KimTravel.GUI.FControls
{
    partial class frmActionGroupTour
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
            this.txtGroupName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMinPax = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMaxPax = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.ckEnabled = new MaterialSkin.Controls.MaterialCheckBox();
            this.txtNote = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.btnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // txtGroupName
            // 
            this.txtGroupName.Depth = 0;
            this.txtGroupName.Hint = "";
            this.txtGroupName.Location = new System.Drawing.Point(102, 92);
            this.txtGroupName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.PasswordChar = '\0';
            this.txtGroupName.SelectedText = "";
            this.txtGroupName.SelectionLength = 0;
            this.txtGroupName.SelectionStart = 0;
            this.txtGroupName.Size = new System.Drawing.Size(223, 23);
            this.txtGroupName.TabIndex = 1;
            this.txtGroupName.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 95);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(76, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Tên nhóm";
            // 
            // txtMinPax
            // 
            this.txtMinPax.Depth = 0;
            this.txtMinPax.Hint = "";
            this.txtMinPax.Location = new System.Drawing.Point(102, 136);
            this.txtMinPax.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMinPax.Name = "txtMinPax";
            this.txtMinPax.PasswordChar = '\0';
            this.txtMinPax.SelectedText = "";
            this.txtMinPax.SelectionLength = 0;
            this.txtMinPax.SelectionStart = 0;
            this.txtMinPax.Size = new System.Drawing.Size(223, 23);
            this.txtMinPax.TabIndex = 2;
            this.txtMinPax.Text = "0";
            this.txtMinPax.UseSystemPasswordChar = false;
            this.txtMinPax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 139);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(62, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Min Pax";
            // 
            // txtMaxPax
            // 
            this.txtMaxPax.Depth = 0;
            this.txtMaxPax.Hint = "";
            this.txtMaxPax.Location = new System.Drawing.Point(102, 178);
            this.txtMaxPax.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMaxPax.Name = "txtMaxPax";
            this.txtMaxPax.PasswordChar = '\0';
            this.txtMaxPax.SelectedText = "";
            this.txtMaxPax.SelectionLength = 0;
            this.txtMaxPax.SelectionStart = 0;
            this.txtMaxPax.Size = new System.Drawing.Size(223, 23);
            this.txtMaxPax.TabIndex = 3;
            this.txtMaxPax.Text = "10";
            this.txtMaxPax.UseSystemPasswordChar = false;
            this.txtMaxPax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 181);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(65, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Max Pax";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 223);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(72, 19);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Kích hoạt";
            // 
            // ckEnabled
            // 
            this.ckEnabled.AutoSize = true;
            this.ckEnabled.BackColor = System.Drawing.Color.Transparent;
            this.ckEnabled.Checked = true;
            this.ckEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckEnabled.Depth = 0;
            this.ckEnabled.Font = new System.Drawing.Font("Roboto", 10F);
            this.ckEnabled.Location = new System.Drawing.Point(102, 214);
            this.ckEnabled.Margin = new System.Windows.Forms.Padding(0);
            this.ckEnabled.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckEnabled.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckEnabled.Name = "ckEnabled";
            this.ckEnabled.Ripple = true;
            this.ckEnabled.Size = new System.Drawing.Size(26, 30);
            this.ckEnabled.TabIndex = 4;
            this.ckEnabled.UseVisualStyleBackColor = false;
            // 
            // txtNote
            // 
            this.txtNote.Depth = 0;
            this.txtNote.Hint = "";
            this.txtNote.Location = new System.Drawing.Point(102, 258);
            this.txtNote.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNote.Name = "txtNote";
            this.txtNote.PasswordChar = '\0';
            this.txtNote.SelectedText = "";
            this.txtNote.SelectionLength = 0;
            this.txtNote.SelectionStart = 0;
            this.txtNote.Size = new System.Drawing.Size(223, 23);
            this.txtNote.TabIndex = 5;
            this.txtNote.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(12, 261);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(59, 19);
            this.materialLabel5.TabIndex = 0;
            this.materialLabel5.Text = "Ghi chú";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Depth = 0;
            this.btnUpdate.Location = new System.Drawing.Point(83, 330);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Primary = true;
            this.btnUpdate.Size = new System.Drawing.Size(180, 39);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmActionGroupTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 420);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.ckEnabled);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtMaxPax);
            this.Controls.Add(this.txtMinPax);
            this.Controls.Add(this.txtGroupName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 420);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 420);
            this.Name = "frmActionGroupTour";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmActionGroupTour";
            this.Load += new System.EventHandler(this.frmActionGroupTour_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtGroupName;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMinPax;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMaxPax;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialCheckBox ckEnabled;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNote;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdate;
    }
}