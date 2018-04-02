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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActionGroupPrice));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.cbbGroupPartner = new System.Windows.Forms.ComboBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.cbbTour = new System.Windows.Forms.ComboBox();
            this.txtPriceRe = new DevExpress.XtraEditors.TextEdit();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPriceReChild = new DevExpress.XtraEditors.TextEdit();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.cbbGroupTour = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriceRe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriceReChild.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(5, 168);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(156, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Giá nhận người lớn:";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // materialLabel6
            // 
            this.materialLabel6.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(5, 32);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(104, 19);
            this.materialLabel6.TabIndex = 0;
            this.materialLabel6.Text = "Nhóm:";
            this.materialLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbGroupPartner
            // 
            this.cbbGroupPartner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGroupPartner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGroupPartner.FormattingEnabled = true;
            this.cbbGroupPartner.ItemHeight = 20;
            this.cbbGroupPartner.Location = new System.Drawing.Point(115, 28);
            this.cbbGroupPartner.Name = "cbbGroupPartner";
            this.cbbGroupPartner.Size = new System.Drawing.Size(223, 28);
            this.cbbGroupPartner.TabIndex = 1;
            // 
            // materialLabel7
            // 
            this.materialLabel7.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(5, 112);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(104, 19);
            this.materialLabel7.TabIndex = 0;
            this.materialLabel7.Text = "Tour:";
            this.materialLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbTour
            // 
            this.cbbTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTour.FormattingEnabled = true;
            this.cbbTour.ItemHeight = 20;
            this.cbbTour.Location = new System.Drawing.Point(115, 108);
            this.cbbTour.Name = "cbbTour";
            this.cbbTour.Size = new System.Drawing.Size(223, 28);
            this.cbbTour.TabIndex = 2;
            // 
            // txtPriceRe
            // 
            this.txtPriceRe.EditValue = "";
            this.txtPriceRe.Location = new System.Drawing.Point(167, 163);
            this.txtPriceRe.Name = "txtPriceRe";
            this.txtPriceRe.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPriceRe.Properties.Appearance.Options.UseFont = true;
            this.txtPriceRe.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtPriceRe.Size = new System.Drawing.Size(171, 28);
            this.txtPriceRe.TabIndex = 3;
            this.txtPriceRe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTimKiem.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnTimKiem.Appearance.Options.UseFont = true;
            this.btnTimKiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.ImageOptions.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(85, 246);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(180, 39);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Cập nhật";
            this.btnTimKiem.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(5, 202);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(156, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Giá nhận trẻ em:";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPriceReChild
            // 
            this.txtPriceReChild.EditValue = "";
            this.txtPriceReChild.Location = new System.Drawing.Point(167, 197);
            this.txtPriceReChild.Name = "txtPriceReChild";
            this.txtPriceReChild.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPriceReChild.Properties.Appearance.Options.UseFont = true;
            this.txtPriceReChild.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtPriceReChild.Size = new System.Drawing.Size(171, 28);
            this.txtPriceReChild.TabIndex = 3;
            this.txtPriceReChild.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // materialLabel3
            // 
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(5, 73);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(104, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Nhóm Tour:";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbGroupTour
            // 
            this.cbbGroupTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGroupTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGroupTour.FormattingEnabled = true;
            this.cbbGroupTour.ItemHeight = 20;
            this.cbbGroupTour.Location = new System.Drawing.Point(115, 69);
            this.cbbGroupTour.Name = "cbbGroupTour";
            this.cbbGroupTour.Size = new System.Drawing.Size(223, 28);
            this.cbbGroupTour.TabIndex = 2;
            this.cbbGroupTour.SelectedIndexChanged += new System.EventHandler(this.cbbGroupTour_SelectedIndexChanged);
            // 
            // frmActionGroupPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 301);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtPriceReChild);
            this.Controls.Add(this.txtPriceRe);
            this.Controls.Add(this.cbbGroupTour);
            this.Controls.Add(this.cbbTour);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.cbbGroupPartner);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(366, 340);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(366, 340);
            this.Name = "frmActionGroupPrice";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmActionGroupTour";
            this.Load += new System.EventHandler(this.frmActionGroupTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPriceRe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriceReChild.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.ComboBox cbbGroupPartner;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.ComboBox cbbTour;
        private DevExpress.XtraEditors.TextEdit txtPriceRe;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private DevExpress.XtraEditors.TextEdit txtPriceReChild;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ComboBox cbbGroupTour;
    }
}