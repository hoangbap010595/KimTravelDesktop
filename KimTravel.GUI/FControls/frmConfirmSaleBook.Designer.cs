namespace KimTravel.GUI.FControls
{
    partial class frmConfirmSaleBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfirmSaleBook));
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenNguoiBook = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNguoiBook.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnConfirm.Appearance.Options.UseFont = true;
            this.btnConfirm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.ImageOptions.Image")));
            this.btnConfirm.Location = new System.Drawing.Point(85, 48);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(114, 35);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtTenNguoiBook
            // 
            this.txtTenNguoiBook.Location = new System.Drawing.Point(12, 14);
            this.txtTenNguoiBook.Name = "txtTenNguoiBook";
            this.txtTenNguoiBook.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtTenNguoiBook.Properties.Appearance.Options.UseFont = true;
            this.txtTenNguoiBook.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtTenNguoiBook.Size = new System.Drawing.Size(260, 28);
            this.txtTenNguoiBook.TabIndex = 3;
            // 
            // frmConfirmSaleBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 91);
            this.Controls.Add(this.txtTenNguoiBook);
            this.Controls.Add(this.btnConfirm);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 130);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 130);
            this.Name = "frmConfirmSaleBook";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập tên người book";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConfirm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNguoiBook.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
        private DevExpress.XtraEditors.TextEdit txtTenNguoiBook;
    }
}