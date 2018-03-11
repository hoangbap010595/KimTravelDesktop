﻿using KimTravel.DAL;
using KimTravel.GUI.UControls;
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

namespace KimTravel.GUI
{
    public partial class frmMain : MaterialForm
    {
        private MaterialSkinManager mSkin;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            mSkin = MaterialSkinManager.Instance;
            mSkin.AddFormToManage(this);
            mSkin.Theme = ConfigApp.Themes;
            mSkin.ColorScheme = new ColorScheme(ConfigApp.Primary, ConfigApp.DarkPrimary, ConfigApp.LightPrimary, ConfigApp.Accent, ConfigApp.TextShade);

            frmLogin frm = new frmLogin();
            frm.ShowDialog();

            txt_bar_CurrentUser.Text = "Account: " + Constant.CurrentSessionUser;

            this.DoubleBuffered = false;
        }

        private void timerUseSystem_Tick(object sender, EventArgs e)
        {

        }

        private void kêtThucToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Kết thúc phiên làm việc ?", "Xác thực", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                Application.Exit();
        }


        private void quanLyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCGroupTour uc = new UCGroupTour();
            addControlToPanel(uc);
        }



        private void addControlToPanel(UserControl uControl)
        {
            lblTitle.Text = uControl.Name;
            panelControlMain.Controls.Clear();
            uControl.Dock = DockStyle.Fill;
            panelControlMain.Controls.Add(uControl);
        }

        private void quanLyĐôiTacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCPartner uc = new UCPartner();
            addControlToPanel(uc);
        }

        private void quanLyNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCStaff uc = new UCStaff();
            addControlToPanel(uc);
        }

        private void xeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCCar uc = new UCCar();
            addControlToPanel(uc);
        }

        private void danhSachTourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCTour uc = new UCTour();
            addControlToPanel(uc);
        }

        private void quanLyTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCUser uc = new UCUser();
            addControlToPanel(uc);
        }

        private void bookTourToolStripMenuItem1_Click(object sender, EventArgs e)
        {
       
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Kết thúc phiên làm việc ?", "Xác thực", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                //Application.Exit();
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCBook uc = new UCBook();
            addControlToPanel(uc);
        }

        private void danhSachĐaBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCListBook uc = new UCListBook();
            addControlToPanel(uc);
        }

        private void săpXêpTourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCBookCar uc = new UCBookCar();
            addControlToPanel(uc);
        }

        private void bookTourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCTour uc = new UCTour();
            addControlToPanel(uc);
        }

        private void quanLyNhomĐôiTacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCGroupPartner uc = new UCGroupPartner();
            addControlToPanel(uc);
        }
    }
}
