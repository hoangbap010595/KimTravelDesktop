﻿using DevExpress.XtraEditors;
using KimTravel.DAL;
using KimTravel.DAL.Models;
using KimTravel.DAL.Services;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KimTravel.GUI.FControls
{
    public partial class frmActionUser : XtraForm
    {
        private ApplicationUser _objectData;
        private ApplicationUserService gtService = new ApplicationUserService();

        private int _action = -1;
        private int _objID = -1;
        public delegate void LoadData();
        public LoadData loadData;
        public frmActionUser(int action = -1, int objID = -1)
        {
            InitializeComponent();
            _action = action;
            _objID = objID;
            _objectData = gtService.GetByID(objID);
        }

        private void frmActionGroupTour_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();

            cbbStatus.DataSource = Constant.getListStatusUser();
            cbbStatus.ValueMember = "ID";
            cbbStatus.DisplayMember = "Name";

            if (_action == -1)
                this.Text = "Thêm mới tài khoản";
            else
                this.Text = "Cập nhật tài khoản";

            if (_objectData != null)
            {
                txtUsername.Text = _objectData.Username;

                ckLock.Checked = _objectData.Locked == true ? true : false; ;
                cbbStatus.SelectedValue = _objectData.Status;
            }
            else
                btnUpdatePass.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                XtraMessageBox.Show("Tên đăng nhập không thể để trống.");
                return;
            }
           

            ApplicationUser user = new ApplicationUser();
            user.ID = _objID;
            user.Username = txtUsername.Text;
            user.Email = "";
            user.Locked = ckLock.Checked;
            user.Status = int.Parse(cbbStatus.SelectedValue.ToString());

            if(_objectData == null)
            {
                string pass1 = txtPassword.Text;
                string pass2 = txtConfirmPass.Text;
                if (pass1 != pass2)
                {
                    XtraMessageBox.Show("Mật khẩu không trùng khớp. Vui lòng nhập lại");
                    txtPassword.Text = "";
                    txtConfirmPass.Text = "";
                    txtPassword.Focus();
                    return;
                }
                user.Password = pass1;
            }

            var rs = false;
            var msg = "";
            if (_action == -1)
            {
                rs = this.gtService.Insert(user);
                msg = "Thêm mới thành công";
            }
            else
            {
                rs = this.gtService.Update(user);
                msg = "Cập nhật thành công";
            }
            if (rs)
            {
                XtraMessageBox.Show(msg);

                if (loadData != null)
                    loadData();
                this.Close();
            }
            else
                XtraMessageBox.Show("Tên tài khoản tồn tại trong hệ thống. Vui lòng kiểm tra lại.");

        }

        private void btnUpdatePass_Click(object sender, EventArgs e)
        {
            string pass1 = txtPassword.Text;
            string pass2 = txtConfirmPass.Text;

            if (pass1 == "" || pass2 == "")
            {
                XtraMessageBox.Show("Hãy nhập đầy đủ thông tin");
                return;
            } 
            if(pass1 != pass2)
            {
                XtraMessageBox.Show("Mật khẩu không trùng khớp. Vui lòng nhập lại");
                txtPassword.Text = "";
                txtConfirmPass.Text = "";
                txtPassword.Focus();
                return;
            }
            var rs = false;
            if (_objectData != null)
               rs = gtService.UpdatePassword(_objectData, pass1);
            if (rs)
            {
                XtraMessageBox.Show("Cập nhật mật khẩu thành công");
            }else
            {
                XtraMessageBox.Show("Cập nhật mật khẩu không thành công. Vui lòng thử lại");
            }
        }
    }
}
