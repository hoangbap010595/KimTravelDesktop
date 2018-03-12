using KimTravel.DAL;
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
            lblTitle.Text = "Quản lý nhóm tour";
            UCGroupTour uc = new UCGroupTour();
            addControlToPanel(uc);
        }

        private void addControlToPanel(UserControl uControl)
        {
            panelControlMain.Controls.Clear();
            uControl.Dock = DockStyle.Fill;
            panelControlMain.Controls.Add(uControl);
        }

        private void quanLyĐôiTacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Quản lý đối tác";
            UCPartner uc = new UCPartner();
            addControlToPanel(uc);
        }

        private void quanLyNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Quản lý nhân viên";
            UCStaff uc = new UCStaff();
            addControlToPanel(uc);
        }

        private void xeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Quản lý xe vận chuyển";
            UCCar uc = new UCCar();
            addControlToPanel(uc);
        }

        private void quanLyTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Quản lý tài khoản";
            UCUser uc = new UCUser();
            addControlToPanel(uc);
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
            lblTitle.Text = "Book tour";
            UCBook uc = new UCBook();
            addControlToPanel(uc);
        }

        private void danhSachĐaBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Danh sách tour đã book";
            UCListBook uc = new UCListBook();
            addControlToPanel(uc);
        }

        private void săpXêpTourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Phân bổ xe theo tour";
            UCBookCar uc = new UCBookCar();
            addControlToPanel(uc);
        }

        private void bookTourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Quản lý tour";
            UCTour uc = new UCTour();
            addControlToPanel(uc);
        }

        private void quanLyNhomĐôiTacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Quản lý nhóm đối tác";
            UCGroupPartner uc = new UCGroupPartner();
            addControlToPanel(uc);
        }
    }
}
