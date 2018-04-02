using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using KimTravel.DAL;
using KimTravel.DAL.Services;
using KimTravel.GUI.UControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KimTravel.GUI
{
    public partial class frmRibonMain : XtraForm
    {
        private ApplicationUserRoleService userRoleService = new ApplicationUserRoleService();
        public frmRibonMain()
        {
            InitializeComponent();
        }
        private void addTab(XtraUserControl xtraUserControl)
        {
            XtraTabPage xtraTabPage = new XtraTabPage();
            xtraTabPage.Name = xtraUserControl.Name;
            xtraTabPage.Size = new System.Drawing.Size(860, 376);
            xtraTabPage.Text = xtraUserControl.Text;
            if (xtraTabControlMain.TabPages.Count == 0)
            {
                xtraTabPage.Controls.Add(xtraUserControl);
                xtraTabControlMain.TabPages.Add(xtraTabPage);
            }
            else
            {
                int newTab = 0;
                foreach (XtraTabPage item in xtraTabControlMain.TabPages)
                {
                    if (item.Text == xtraTabPage.Text)
                    {
                        xtraTabControlMain.SelectedTabPage = item;
                        newTab = 1;
                        break;
                    }
                }
                if (newTab == 0)
                {
                    xtraTabPage.Controls.Add(xtraUserControl);
                    xtraTabControlMain.TabPages.Add(xtraTabPage);
                    xtraTabControlMain.Refresh();
                    xtraTabControlMain.SelectedTabPage = xtraTabPage;
                }
            }

        }

        private void barBtnQuanLyTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraUserControl xtraUserControl = new UCUser();
            xtraUserControl.Name = barBtnQuanLyTaiKhoan.Name + "UControl";
            xtraUserControl.Text = barBtnQuanLyTaiKhoan.Caption;
            xtraUserControl.Dock = DockStyle.Fill;
            lblCurrent.Caption = "Quản lý tài khoản";
            addTab(xtraUserControl);
        }

        private void barBtnPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraUserControl xtraUserControl = new UCRoleViewReport();
            xtraUserControl.Name = barBtnPhanQuyen.Name + "UControl";
            xtraUserControl.Text = barBtnPhanQuyen.Caption;
            xtraUserControl.Dock = DockStyle.Fill;
            lblCurrent.Caption = "Quản lý phân quyền";
            addTab(xtraUserControl);
        }

        private void barBtnBookTour_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraUserControl xtraUserControl = new UCBook();
            xtraUserControl.Name = barBtnBookTour.Name + "UControl";
            xtraUserControl.Text = barBtnBookTour.Caption;
            xtraUserControl.Dock = DockStyle.Fill;
            lblCurrent.Caption = "Book Tour";
            addTab(xtraUserControl);
        }

        private void barBtnListBook_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraUserControl xtraUserControl = new UCListBook();
            xtraUserControl.Name = barBtnListBook.Name + "UControl";
            xtraUserControl.Text = barBtnListBook.Caption;
            xtraUserControl.Dock = DockStyle.Fill;
            lblCurrent.Caption = "Danh sách đã book";
            addTab(xtraUserControl);
        }

        private void barBtnPhanXe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraUserControl xtraUserControl = new UCBookCar();
            xtraUserControl.Name = barBtnPhanXe.Name + "UControl";
            xtraUserControl.Text = barBtnPhanXe.Caption;
            xtraUserControl.Dock = DockStyle.Fill;
            lblCurrent.Caption = "Phân bổ xe theo tour";
            addTab(xtraUserControl);

        }
        private void barBtnTourPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraUserControl xtraUserControl = new UCPrintTour();
            xtraUserControl.Name = barBtnTourPrint.Name + "UControl";
            xtraUserControl.Text = barBtnTourPrint.Caption;
            xtraUserControl.Dock = DockStyle.Fill;
            lblCurrent.Caption = "Danh sách tour đã in";
            addTab(xtraUserControl);
        }
        private void barQLTour_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            XtraUserControl xtraUserControl = new UCTour();
            xtraUserControl.Name = barQLTour.Name + "UControl";
            xtraUserControl.Text = barQLTour.Caption;
            xtraUserControl.Dock = DockStyle.Fill;
            lblCurrent.Caption = "Quản lý tour";
            addTab(xtraUserControl);
        }

        private void barBtnGroupTour_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraUserControl xtraUserControl = new UCGroupTour();
            xtraUserControl.Name = barBtnGroupTour.Name + "UControl";
            xtraUserControl.Text = barBtnGroupTour.Caption;
            xtraUserControl.Dock = DockStyle.Fill;
            lblCurrent.Caption = "Quản lý nhóm tour";
            addTab(xtraUserControl);
        }

        private void barBtnPartner_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraUserControl xtraUserControl = new UCPartner();
            xtraUserControl.Name = barBtnPartner.Name + "UControl";
            xtraUserControl.Text = barBtnPartner.Caption;
            xtraUserControl.Dock = DockStyle.Fill;
            lblCurrent.Caption = "Quản lý đối tác";
            addTab(xtraUserControl);
        }

        private void barBtnGroupPartner_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraUserControl xtraUserControl = new UCGroupPartner();
            xtraUserControl.Name = barBtnGroupPartner.Name + "UControl";
            xtraUserControl.Text = barBtnGroupPartner.Caption;
            xtraUserControl.Dock = DockStyle.Fill;
            lblCurrent.Caption = "Quản lý nhóm đối tác";
            addTab(xtraUserControl);
        }

        private void barBtnCongNo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraUserControl xtraUserControl = new UCReportCongNo();
            xtraUserControl.Name = barBtnCongNo.Name + "UControl";
            xtraUserControl.Text = barBtnCongNo.Caption;
            xtraUserControl.Dock = DockStyle.Fill;
            lblCurrent.Caption = "Báo cáo công nợ";
            addTab(xtraUserControl);
        }

        private void barBtnReportPartner_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraUserControl xtraUserControl = new UCReportCongNoDoiTac();
            xtraUserControl.Name = barBtnReportPartner.Name + "UControl";
            xtraUserControl.Text = barBtnReportPartner.Caption;
            xtraUserControl.Dock = DockStyle.Fill;
            lblCurrent.Caption = "Báo cáo công nợ đối tác";
            addTab(xtraUserControl);

        }
        private void barBtnCar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraUserControl xtraUserControl = new UCCar();
            xtraUserControl.Name = barBtnCar.Name + "UControl";
            xtraUserControl.Text = barBtnCar.Caption;
            xtraUserControl.Dock = DockStyle.Fill;
            lblCurrent.Caption = "Dữ liệu xe";
            addTab(xtraUserControl);
        }
        private void barBtnStaff_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraUserControl xtraUserControl = new UCStaff();
            xtraUserControl.Name = barBtnStaff.Name + "UControl";
            xtraUserControl.Text = barBtnStaff.Caption;
            xtraUserControl.Dock = DockStyle.Fill;
            lblCurrent.Caption = "Dữ liệu xe";
            addTab(xtraUserControl);
        }
        private void barBtnService_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barBtnDataHotel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barBtnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Constant.CurrentSessionUser = "";
            frmRibonMain_Load(sender, e);
        }

        private void barBtnKetThuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmRibonMain_Load(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();

            lblAccount.Caption = "" + Constant.CurrentSessionUser;
            getMenuOfAccount();
            barBtnCongNo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        }

        private void frmRibonMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Yes == XtraMessageBox.Show("Kết thúc phiên làm việc ?", "Xác thực", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void xtraTabControlMain_CloseButtonClick(object sender, EventArgs e)
        {
            ClosePageButtonEventArgs arg = e as ClosePageButtonEventArgs;
            XtraTabPage page = (arg.Page as XtraTabPage);
            xtraTabControlMain.TabPages.Remove(page);
        }

        private void getMenuOfAccount()
        {
            barBtnQuanLyTaiKhoan.Visibility = barBtnPhanQuyen.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            barBtnBookTour.Visibility = barBtnListBook.Visibility = barBtnPhanXe.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            barQLTour.Visibility = barBtnGroupTour.Visibility = barBtnPartner.Visibility = barBtnGroupPartner.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            barBtnCar.Visibility = barBtnStaff.Visibility = barBtnService.Visibility = barBtnDataHotel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            barBtnReportPartner.Visibility = barBtnCongNo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            ribbonPageGroupHeThong.Visible = ribbonPageGroupTour.Visible = ribbonPageGroupNghiepVu.Visible = ribbonPageGroupData.Visible = ribbonPageGroupBaoCao.Visible = false;

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
                        barBtnQuanLyTaiKhoan.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        menu1++;
                        break;
                    case 10:
                        barBtnPhanQuyen.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        menu1++;
                        break;
                    //Tour
                    case 15:
                        barBtnBookTour.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        menu2++;
                        break;
                    case 20:
                        barBtnListBook.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        menu2++;
                        break;
                    case 25:
                        barBtnPhanXe.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        menu2++;
                        break;
                    //Nghiệp vụ
                    case 30:
                        barQLTour.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        menu3++;
                        break;
                    case 35:
                        barBtnGroupTour.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        menu3++;
                        break;
                    case 40:
                        barBtnPartner.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        menu3++;
                        break;
                    case 45:
                        barBtnGroupPartner.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        menu3++;
                        break;
                    //Dữ liệu
                    case 50:
                        barBtnCar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        menu4++;
                        break;
                    case 55:
                        barBtnStaff.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        menu4++;
                        break;
                    case 60:
                        barBtnService.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        menu4++;
                        break;
                    case 65:
                        barBtnDataHotel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        menu4++;
                        break;
                    //Báo cáo
                    case 70:
                        barBtnCongNo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        menu5++;
                        break;
                    case 75:
                        barBtnReportPartner.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        menu5++;
                        break;
                        #endregion End check role
                }
            }

            xtraTabControlMain.TabPages.Clear();
            if (menu1 > 0)
            {
                ribbonPageGroupHeThong.Visible = true;
            }
            if (menu2 > 0)
            {
                ribbonPageGroupTour.Visible = true;
            }
            if (menu3 > 0)
            {
                ribbonPageGroupNghiepVu.Visible = true;
            }
            if (menu4 > 0)
            {
                ribbonPageGroupData.Visible = true;
            }
            if (menu5 > 0)
            {
                ribbonPageGroupBaoCao.Visible = true;
            }
            if (Constant.CurrentSessionUser == "")
                barBtnDangXuat.Caption = "Đăng nhập";
            else
                barBtnDangXuat.Caption = "Đăng xuất";
        }

        private void barBtnCheckUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string fileNameUpdate = "\\kimtravel_updater.exe";
                string appPath = Path.GetDirectoryName(Application.ExecutablePath);
                var filePath = String.Concat(appPath, fileNameUpdate);
                System.Diagnostics.Process.Start(filePath);
            }
            catch (Exception exx)
            {
                XtraMessageBox.Show(exx.Message);
            }
        }
    }
}
