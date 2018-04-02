namespace KimTravel.GUI.FControls
{
    partial class frmConfirmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfirmPayment));
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.rdAll = new System.Windows.Forms.RadioButton();
            this.rdNotPayment = new System.Windows.Forms.RadioButton();
            this.rdPayment = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnOK.Location = new System.Drawing.Point(50, 171);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(165, 39);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Xem báo cáo";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // rdAll
            // 
            this.rdAll.AutoSize = true;
            this.rdAll.Checked = true;
            this.rdAll.Font = new System.Drawing.Font("Tahoma", 12F);
            this.rdAll.Location = new System.Drawing.Point(60, 37);
            this.rdAll.Name = "rdAll";
            this.rdAll.Size = new System.Drawing.Size(101, 23);
            this.rdAll.TabIndex = 1;
            this.rdAll.TabStop = true;
            this.rdAll.Text = "Xem tất cả";
            this.rdAll.UseVisualStyleBackColor = true;
            // 
            // rdNotPayment
            // 
            this.rdNotPayment.AutoSize = true;
            this.rdNotPayment.Font = new System.Drawing.Font("Tahoma", 12F);
            this.rdNotPayment.Location = new System.Drawing.Point(60, 73);
            this.rdNotPayment.Name = "rdNotPayment";
            this.rdNotPayment.Size = new System.Drawing.Size(145, 23);
            this.rdNotPayment.TabIndex = 2;
            this.rdNotPayment.Text = "Chưa thanh toán";
            this.rdNotPayment.UseVisualStyleBackColor = true;
            // 
            // rdPayment
            // 
            this.rdPayment.AutoSize = true;
            this.rdPayment.Font = new System.Drawing.Font("Tahoma", 12F);
            this.rdPayment.Location = new System.Drawing.Point(60, 111);
            this.rdPayment.Name = "rdPayment";
            this.rdPayment.Size = new System.Drawing.Size(127, 23);
            this.rdPayment.TabIndex = 3;
            this.rdPayment.Text = "Đã thanh toán";
            this.rdPayment.UseVisualStyleBackColor = true;
            // 
            // frmConfirmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 232);
            this.Controls.Add(this.rdPayment);
            this.Controls.Add(this.rdNotPayment);
            this.Controls.Add(this.rdAll);
            this.Controls.Add(this.btnOK);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(281, 271);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(281, 271);
            this.Name = "frmConfirmPayment";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn tình trạng thanh toán";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private System.Windows.Forms.RadioButton rdAll;
        private System.Windows.Forms.RadioButton rdNotPayment;
        private System.Windows.Forms.RadioButton rdPayment;
    }
}