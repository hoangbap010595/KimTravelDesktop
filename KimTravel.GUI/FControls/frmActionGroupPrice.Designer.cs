namespace KimTravel.GUI.FControls
{
    partial class frmActionGroupPrice
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
            this.txtPriceRe = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.cbbGroupPartner = new System.Windows.Forms.ComboBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.cbbTour = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtPriceRe
            // 
            this.txtPriceRe.Depth = 0;
            this.txtPriceRe.Hint = "";
            this.txtPriceRe.Location = new System.Drawing.Point(115, 160);
            this.txtPriceRe.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPriceRe.Name = "txtPriceRe";
            this.txtPriceRe.PasswordChar = '\0';
            this.txtPriceRe.SelectedText = "";
            this.txtPriceRe.SelectionLength = 0;
            this.txtPriceRe.SelectionStart = 0;
            this.txtPriceRe.Size = new System.Drawing.Size(223, 23);
            this.txtPriceRe.TabIndex = 1;
            this.txtPriceRe.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(5, 164);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(67, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Giá nhận";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Depth = 0;
            this.btnUpdate.Location = new System.Drawing.Point(84, 220);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Primary = true;
            this.btnUpdate.Size = new System.Drawing.Size(180, 39);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(5, 87);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(50, 19);
            this.materialLabel6.TabIndex = 0;
            this.materialLabel6.Text = "Nhóm";
            // 
            // cbbGroupPartner
            // 
            this.cbbGroupPartner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGroupPartner.FormattingEnabled = true;
            this.cbbGroupPartner.ItemHeight = 13;
            this.cbbGroupPartner.Location = new System.Drawing.Point(115, 88);
            this.cbbGroupPartner.Name = "cbbGroupPartner";
            this.cbbGroupPartner.Size = new System.Drawing.Size(223, 21);
            this.cbbGroupPartner.TabIndex = 6;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(5, 122);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(40, 19);
            this.materialLabel7.TabIndex = 0;
            this.materialLabel7.Text = "Tour";
            // 
            // cbbTour
            // 
            this.cbbTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTour.FormattingEnabled = true;
            this.cbbTour.ItemHeight = 13;
            this.cbbTour.Location = new System.Drawing.Point(115, 123);
            this.cbbTour.Name = "cbbTour";
            this.cbbTour.Size = new System.Drawing.Size(223, 21);
            this.cbbTour.TabIndex = 6;
            // 
            // frmActionGroupPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 301);
            this.Controls.Add(this.cbbTour);
            this.Controls.Add(this.cbbGroupPartner);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtPriceRe);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 301);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 301);
            this.Name = "frmActionGroupPrice";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmActionGroupTour";
            this.Load += new System.EventHandler(this.frmActionGroupTour_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtPriceRe;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdate;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.ComboBox cbbGroupPartner;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.ComboBox cbbTour;
    }
}