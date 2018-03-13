namespace KimTravel.GUI.FControls
{
    partial class frmActionRoles

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
            this.btnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ck1_PhanQuyen = new System.Windows.Forms.CheckBox();
            this.ck1_TaiKhoan = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ck2_ListBook = new System.Windows.Forms.CheckBox();
            this.ck2_SapXepXe = new System.Windows.Forms.CheckBox();
            this.ck2_Booktour = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ck3_QLDoiTac = new System.Windows.Forms.CheckBox();
            this.ck3_QLTour = new System.Windows.Forms.CheckBox();
            this.ck3_QLNhomDT = new System.Windows.Forms.CheckBox();
            this.ck3_QLNhomTour = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ck4_DLNhanVien = new System.Windows.Forms.CheckBox();
            this.ck4_DLXe = new System.Windows.Forms.CheckBox();
            this.ck4_DLDichVu = new System.Windows.Forms.CheckBox();
            this.ck4_DLKhachSan = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ck5_CongNo = new System.Windows.Forms.CheckBox();
            this.ck5_DoiTac = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Depth = 0;
            this.txtUsername.Hint = "";
            this.txtUsername.Location = new System.Drawing.Point(97, 72);
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
            this.materialLabel1.Location = new System.Drawing.Point(12, 76);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(79, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Tài khoản:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Depth = 0;
            this.btnUpdate.Location = new System.Drawing.Point(397, 431);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Primary = true;
            this.btnUpdate.Size = new System.Drawing.Size(180, 43);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ck1_PhanQuyen);
            this.groupBox1.Controls.Add(this.ck1_TaiKhoan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hệ thống";
            // 
            // ck1_PhanQuyen
            // 
            this.ck1_PhanQuyen.AutoSize = true;
            this.ck1_PhanQuyen.Location = new System.Drawing.Point(16, 59);
            this.ck1_PhanQuyen.Name = "ck1_PhanQuyen";
            this.ck1_PhanQuyen.Size = new System.Drawing.Size(103, 21);
            this.ck1_PhanQuyen.TabIndex = 0;
            this.ck1_PhanQuyen.Text = "Phân quyền";
            this.ck1_PhanQuyen.UseVisualStyleBackColor = true;
            // 
            // ck1_TaiKhoan
            // 
            this.ck1_TaiKhoan.AutoSize = true;
            this.ck1_TaiKhoan.Location = new System.Drawing.Point(16, 32);
            this.ck1_TaiKhoan.Name = "ck1_TaiKhoan";
            this.ck1_TaiKhoan.Size = new System.Drawing.Size(90, 21);
            this.ck1_TaiKhoan.TabIndex = 0;
            this.ck1_TaiKhoan.Text = "Tài khoản";
            this.ck1_TaiKhoan.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ck2_ListBook);
            this.groupBox2.Controls.Add(this.ck2_SapXepXe);
            this.groupBox2.Controls.Add(this.ck2_Booktour);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(154, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 197);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tour";
            // 
            // ck2_ListBook
            // 
            this.ck2_ListBook.AutoSize = true;
            this.ck2_ListBook.Location = new System.Drawing.Point(5, 59);
            this.ck2_ListBook.Name = "ck2_ListBook";
            this.ck2_ListBook.Size = new System.Drawing.Size(125, 21);
            this.ck2_ListBook.TabIndex = 0;
            this.ck2_ListBook.Text = "Xem danh sách";
            this.ck2_ListBook.UseVisualStyleBackColor = true;
            // 
            // ck2_SapXepXe
            // 
            this.ck2_SapXepXe.AutoSize = true;
            this.ck2_SapXepXe.Location = new System.Drawing.Point(5, 86);
            this.ck2_SapXepXe.Name = "ck2_SapXepXe";
            this.ck2_SapXepXe.Size = new System.Drawing.Size(96, 21);
            this.ck2_SapXepXe.TabIndex = 0;
            this.ck2_SapXepXe.Text = "Sắp xếp xe";
            this.ck2_SapXepXe.UseVisualStyleBackColor = true;
            // 
            // ck2_Booktour
            // 
            this.ck2_Booktour.AutoSize = true;
            this.ck2_Booktour.Location = new System.Drawing.Point(5, 32);
            this.ck2_Booktour.Name = "ck2_Booktour";
            this.ck2_Booktour.Size = new System.Drawing.Size(88, 21);
            this.ck2_Booktour.TabIndex = 0;
            this.ck2_Booktour.Text = "Book tour";
            this.ck2_Booktour.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ck3_QLDoiTac);
            this.groupBox3.Controls.Add(this.ck3_QLTour);
            this.groupBox3.Controls.Add(this.ck3_QLNhomDT);
            this.groupBox3.Controls.Add(this.ck3_QLNhomTour);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(292, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(139, 197);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nghiệp vụ";
            // 
            // ck3_QLDoiTac
            // 
            this.ck3_QLDoiTac.AutoSize = true;
            this.ck3_QLDoiTac.Location = new System.Drawing.Point(6, 59);
            this.ck3_QLDoiTac.Name = "ck3_QLDoiTac";
            this.ck3_QLDoiTac.Size = new System.Drawing.Size(94, 21);
            this.ck3_QLDoiTac.TabIndex = 0;
            this.ck3_QLDoiTac.Text = "QL Đối tác";
            this.ck3_QLDoiTac.UseVisualStyleBackColor = true;
            // 
            // ck3_QLTour
            // 
            this.ck3_QLTour.AutoSize = true;
            this.ck3_QLTour.Location = new System.Drawing.Point(6, 32);
            this.ck3_QLTour.Name = "ck3_QLTour";
            this.ck3_QLTour.Size = new System.Drawing.Size(80, 21);
            this.ck3_QLTour.TabIndex = 0;
            this.ck3_QLTour.Text = "QL Tour";
            this.ck3_QLTour.UseVisualStyleBackColor = true;
            // 
            // ck3_QLNhomDT
            // 
            this.ck3_QLNhomDT.AutoSize = true;
            this.ck3_QLNhomDT.Location = new System.Drawing.Point(6, 113);
            this.ck3_QLNhomDT.Name = "ck3_QLNhomDT";
            this.ck3_QLNhomDT.Size = new System.Drawing.Size(133, 21);
            this.ck3_QLNhomDT.TabIndex = 0;
            this.ck3_QLNhomDT.Text = "QL Nhóm đối tác";
            this.ck3_QLNhomDT.UseVisualStyleBackColor = true;
            // 
            // ck3_QLNhomTour
            // 
            this.ck3_QLNhomTour.AutoSize = true;
            this.ck3_QLNhomTour.Location = new System.Drawing.Point(6, 86);
            this.ck3_QLNhomTour.Name = "ck3_QLNhomTour";
            this.ck3_QLNhomTour.Size = new System.Drawing.Size(116, 21);
            this.ck3_QLNhomTour.TabIndex = 0;
            this.ck3_QLNhomTour.Text = "QL Nhóm tour";
            this.ck3_QLNhomTour.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ck4_DLNhanVien);
            this.groupBox4.Controls.Add(this.ck4_DLXe);
            this.groupBox4.Controls.Add(this.ck4_DLDichVu);
            this.groupBox4.Controls.Add(this.ck4_DLKhachSan);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(437, 120);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(132, 197);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dữ liệu";
            // 
            // ck4_DLNhanVien
            // 
            this.ck4_DLNhanVien.AutoSize = true;
            this.ck4_DLNhanVien.Location = new System.Drawing.Point(6, 59);
            this.ck4_DLNhanVien.Name = "ck4_DLNhanVien";
            this.ck4_DLNhanVien.Size = new System.Drawing.Size(115, 21);
            this.ck4_DLNhanVien.TabIndex = 0;
            this.ck4_DLNhanVien.Text = "DL Nhân Viên";
            this.ck4_DLNhanVien.UseVisualStyleBackColor = true;
            // 
            // ck4_DLXe
            // 
            this.ck4_DLXe.AutoSize = true;
            this.ck4_DLXe.Location = new System.Drawing.Point(6, 32);
            this.ck4_DLXe.Name = "ck4_DLXe";
            this.ck4_DLXe.Size = new System.Drawing.Size(66, 21);
            this.ck4_DLXe.TabIndex = 0;
            this.ck4_DLXe.Text = "DL Xe";
            this.ck4_DLXe.UseVisualStyleBackColor = true;
            // 
            // ck4_DLDichVu
            // 
            this.ck4_DLDichVu.AutoSize = true;
            this.ck4_DLDichVu.Location = new System.Drawing.Point(6, 86);
            this.ck4_DLDichVu.Name = "ck4_DLDichVu";
            this.ck4_DLDichVu.Size = new System.Drawing.Size(96, 21);
            this.ck4_DLDichVu.TabIndex = 0;
            this.ck4_DLDichVu.Text = "DL Dịch vụ";
            this.ck4_DLDichVu.UseVisualStyleBackColor = true;
            // 
            // ck4_DLKhachSan
            // 
            this.ck4_DLKhachSan.AutoSize = true;
            this.ck4_DLKhachSan.Location = new System.Drawing.Point(6, 113);
            this.ck4_DLKhachSan.Name = "ck4_DLKhachSan";
            this.ck4_DLKhachSan.Size = new System.Drawing.Size(116, 21);
            this.ck4_DLKhachSan.TabIndex = 0;
            this.ck4_DLKhachSan.Text = "DL Khách sạn";
            this.ck4_DLKhachSan.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ck5_DoiTac);
            this.groupBox5.Controls.Add(this.ck5_CongNo);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(16, 323);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(132, 151);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Báo cáo";
            // 
            // ck5_CongNo
            // 
            this.ck5_CongNo.AutoSize = true;
            this.ck5_CongNo.Location = new System.Drawing.Point(8, 32);
            this.ck5_CongNo.Name = "ck5_CongNo";
            this.ck5_CongNo.Size = new System.Drawing.Size(80, 21);
            this.ck5_CongNo.TabIndex = 0;
            this.ck5_CongNo.Text = "Công nợ";
            this.ck5_CongNo.UseVisualStyleBackColor = true;
            // 
            // ck5_DoiTac
            // 
            this.ck5_DoiTac.AutoSize = true;
            this.ck5_DoiTac.Location = new System.Drawing.Point(8, 59);
            this.ck5_DoiTac.Name = "ck5_DoiTac";
            this.ck5_DoiTac.Size = new System.Drawing.Size(93, 21);
            this.ck5_DoiTac.TabIndex = 0;
            this.ck5_DoiTac.Text = "BC Đối tác";
            this.ck5_DoiTac.UseVisualStyleBackColor = true;
            // 
            // frmActionRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 486);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtUsername);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmActionRoles";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân quyền tài khoản";
            this.Load += new System.EventHandler(this.frmActionGroupTour_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsername;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox ck1_PhanQuyen;
        private System.Windows.Forms.CheckBox ck1_TaiKhoan;
        private System.Windows.Forms.CheckBox ck2_ListBook;
        private System.Windows.Forms.CheckBox ck2_SapXepXe;
        private System.Windows.Forms.CheckBox ck2_Booktour;
        private System.Windows.Forms.CheckBox ck3_QLDoiTac;
        private System.Windows.Forms.CheckBox ck3_QLTour;
        private System.Windows.Forms.CheckBox ck3_QLNhomTour;
        private System.Windows.Forms.CheckBox ck3_QLNhomDT;
        private System.Windows.Forms.CheckBox ck4_DLNhanVien;
        private System.Windows.Forms.CheckBox ck4_DLXe;
        private System.Windows.Forms.CheckBox ck4_DLDichVu;
        private System.Windows.Forms.CheckBox ck4_DLKhachSan;
        private System.Windows.Forms.CheckBox ck5_CongNo;
        private System.Windows.Forms.CheckBox ck5_DoiTac;
    }
}