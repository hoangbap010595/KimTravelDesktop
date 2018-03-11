namespace KimTravel.GUI.FControls
{
    partial class frmActionGroupPartner
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
            this.txtGroupPartner = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // txtGroupPartner
            // 
            this.txtGroupPartner.Depth = 0;
            this.txtGroupPartner.Hint = "";
            this.txtGroupPartner.Location = new System.Drawing.Point(31, 118);
            this.txtGroupPartner.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtGroupPartner.Name = "txtGroupPartner";
            this.txtGroupPartner.PasswordChar = '\0';
            this.txtGroupPartner.SelectedText = "";
            this.txtGroupPartner.SelectionLength = 0;
            this.txtGroupPartner.SelectionStart = 0;
            this.txtGroupPartner.Size = new System.Drawing.Size(282, 23);
            this.txtGroupPartner.TabIndex = 1;
            this.txtGroupPartner.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(27, 94);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(76, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Tên nhóm";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Depth = 0;
            this.btnUpdate.Location = new System.Drawing.Point(85, 171);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Primary = true;
            this.btnUpdate.Size = new System.Drawing.Size(180, 39);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmActionGroupPartner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 235);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtGroupPartner);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmActionGroupPartner";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmActionGroupTour";
            this.Load += new System.EventHandler(this.frmActionGroupTour_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtGroupPartner;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdate;
    }
}