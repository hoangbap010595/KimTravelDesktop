using DevExpress.XtraEditors;
using KimTravel.DAL;
using KimTravel.DAL.Services;
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
        private ApplicationUserRoleService userRoleService = new ApplicationUserRoleService();
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
            getMenuOfAccount();
        }

        private void timerUseSystem_Tick(object sender, EventArgs e)
        {

        }

        private void kêtThucToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == XtraMessageBox.Show("Kết thúc phiên làm việc ?", "Xác thực", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
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
            //if (DialogResult.Yes == XtraMessageBox.Show("Kết thúc phiên làm việc ?", "Xác thực", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            //{
            //    //Application.Exit();
            //    e.Cancel = false;
            //}
            //else
            //    e.Cancel = true;
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Book tour";
            UCBook uc = new UCBook();
            addControlToPanel(uc);
            //frmBookTour frm = new frmBookTour();
            //frm.ShowDialog();
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
            //UCBookCar uc = new UCBookCar();
            UCTempBookCar uc = new UCTempBookCar();
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

        private void côngNơToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Báo cáo công nợ";
            UCReportCongNo uc = new UCReportCongNo();
            addControlToPanel(uc);
        }
        private void bCĐôiTacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Báo cáo đối tác";
            UCReportCongNoDoiTac uc = new UCReportCongNoDoiTac();
            addControlToPanel(uc);
        }
        private void getMenuOfAccount()
        {
            quanLyTaiKhoanToolStripMenuItem.Visible = quanLyPhânQuyênToolStripMenuItem.Visible = false;
            bookToolStripMenuItem.Visible = danhSachĐaBookToolStripMenuItem.Visible = săpXêpTourToolStripMenuItem.Visible = false;
            bookTourToolStripMenuItem.Visible = quanLyĐôiTacToolStripMenuItem.Visible = quanLyToolStripMenuItem.Visible = quanLyNhomĐôiTacToolStripMenuItem.Visible = false;
            xeToolStripMenuItem.Visible = quanLyNhânViênToolStripMenuItem.Visible = loaiDichVuToolStripMenuItem.Visible = khachSanToolStripMenuItem.Visible = false;
            côngNơToolStripMenuItem.Visible = bCĐôiTacToolStripMenuItem.Visible = false;

            tourToolStripMenuItem.Visible = nghiêpVuToolStripMenuItem.Visible = dưLiêuToolStripMenuItem.Visible = baoCaoToolStripMenuItem.Visible = false;

            int menu1 = 0;
            int menu2 = 0;
            int menu3 = 0;
            int menu4 = 0;
            int menu5 = 0;
            string data = userRoleService.GetListRoles(Constant.CurrentSessionUser);
            string[] roles = data.Split(',');
            foreach (string item in roles)
            {
                int menuID = int.Parse(item);
                switch (menuID)
                {
                    #region ===Check Role
                    //Hệ thống
                    case 5:
                        quanLyTaiKhoanToolStripMenuItem.Visible = true;
                        menu1++;
                        break;
                    case 10:
                        quanLyPhânQuyênToolStripMenuItem.Visible = true;
                        menu1++;
                        break;
                    //Tour
                    case 15:
                        bookToolStripMenuItem.Visible = true;
                        menu2++;
                        break;
                    case 20:
                        danhSachĐaBookToolStripMenuItem.Visible = true;
                        menu2++;
                        break;
                    case 25:
                        săpXêpTourToolStripMenuItem.Visible = true;
                        menu2++;
                        break;
                    //Nghiệp vụ
                    case 30:
                        bookTourToolStripMenuItem.Visible = true;
                        menu3++;
                        break;
                    case 35:
                        quanLyĐôiTacToolStripMenuItem.Visible = true;
                        menu3++;
                        break;
                    case 40:
                        quanLyToolStripMenuItem.Visible = true;
                        menu3++;
                        break;
                    case 45:
                        quanLyNhomĐôiTacToolStripMenuItem.Visible = true;
                        menu3++;
                        break;
                    //Dữ liệu
                    case 50:
                        xeToolStripMenuItem.Visible = true;
                        menu4++;
                        break;
                    case 55:
                        quanLyNhânViênToolStripMenuItem.Visible = true;
                        menu4++;
                        break;
                    case 60:
                        loaiDichVuToolStripMenuItem.Visible = true;
                        menu4++;
                        break;
                    case 65:
                        khachSanToolStripMenuItem.Visible = true;
                        menu4++;
                        break;
                    //Báo cáo
                    case 70:
                        côngNơToolStripMenuItem.Visible = true;
                        menu5++;
                        break;
                    case 75:
                        bCĐôiTacToolStripMenuItem.Visible = true;
                        menu5++;
                        break;
                        #endregion End check role
                }
            }
            lblTitle.Text = "";
            panelControlMain.Controls.Clear();
            if (menu2 > 0)
            {
                tourToolStripMenuItem.Visible = true;
            }
            if (menu3 > 0)
            {
                nghiêpVuToolStripMenuItem.Visible = true;
            }
            if (menu4 > 0)
            {
                dưLiêuToolStripMenuItem.Visible = true;
            }
            if (menu5 > 0)
            {
                baoCaoToolStripMenuItem.Visible = true;
            }
        }

        private void đăngXuâtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Constant.CurrentSessionUser = "";
            frmMain_Load(sender, e);
        }

        private void quanLyPhânQuyênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Thiết lập quyền xem báo cáo";
            UCRoleViewReport uc = new UCRoleViewReport();
            addControlToPanel(uc);
        }
    }
}
