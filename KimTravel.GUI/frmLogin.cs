﻿using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using KimTravel.DAL;
using KimTravel.DAL.Services;
using DevExpress.XtraEditors;

namespace KimTravel.GUI
{
    public partial class frmLogin : MaterialForm
    {
        private MaterialSkinManager mSkin;
        private readonly ApplicationUserService userService = new ApplicationUserService();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mSkin = MaterialSkinManager.Instance;
            mSkin.AddFormToManage(this);
            mSkin.Theme = ConfigApp.Themes;
            mSkin.ColorScheme = new ColorScheme(ConfigApp.Primary, ConfigApp.DarkPrimary, ConfigApp.LightPrimary, ConfigApp.Accent, ConfigApp.TextShade);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            progressLogin.Value = 0;
            try
            {
                progressLogin.Value = 85;
                string user = txtUserName.Text;
                string pass = txtPassword.Text;
                int rs = userService.CheckLogin(user, pass);

                switch (rs)
                {
                    case -1:
                        XtraMessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!\nVui lòng thử lại!");
                        break;
                    case 1:
                        Constant.CurrentSessionUser = user;
                        this.Hide();
                        //this.Close();
                        break;
                    case 2:
                        XtraMessageBox.Show("Tài khoản không có quyền truy cập vào hệ thống !\nVui lòng liên hệ người quản trị!");
                        break;
                    case 0:
                        XtraMessageBox.Show("Tài khoản đã bị khóa !\nVui lòng liên hệ người quản trị!");
                        break;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Xãy ra lỗi: " + ex.Message);
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtPassword.Focus();
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnLogin.PerformClick();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
    }
}
