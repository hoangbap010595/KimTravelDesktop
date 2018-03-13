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
    public partial class frmActionRoles : MaterialForm
    {
        private MaterialSkinManager mSkin;
        private ApplicationUser _objectData;
        private ApplicationUserService gtService = new ApplicationUserService();
        private ApplicationUserRoleService userRoleService = new ApplicationUserRoleService();
        private int _objID = -1;
        public delegate void LoadData();
        public LoadData loadData;
        public frmActionRoles(int objID = -1)
        {
            InitializeComponent();
            _objID = objID;
            _objectData = gtService.GetByID(objID);
        }
        private void loadRole()
        {
            var data = userRoleService.GetListRoles(Constant.CurrentSessionUser);
            string[] roles = data.Split(',');
            foreach (string item in roles)
            {
                int menuID = int.Parse(item);
                switch (menuID)
                {
                    //Hệ thống
                    case 5:
                        ck1_TaiKhoan.Checked = true;
                        break;
                    case 10:
                        ck1_PhanQuyen.Checked = true;
                        break;
                    //Tour
                    case 15:
                        ck2_Booktour.Checked = true;
                        break;
                    case 20:
                        ck2_ListBook.Checked = true;
                        break;
                    case 25:
                        ck2_SapXepXe.Checked = true;
                        break;
                    //Nghiệp vụ
                    case 30:
                        ck3_QLTour.Checked = true;
                        break;
                    case 35:
                        ck3_QLDoiTac.Checked = true;
                        break;
                    case 40:
                        ck3_QLNhomTour.Checked = true;
                        break;
                    case 45:
                        ck3_QLNhomDT.Checked = true;
                        break;
                    //Dữ liệu
                    case 50:
                        ck4_DLXe.Checked = true;
                        break;
                    case 55:
                        ck4_DLNhanVien.Checked = true;
                        break;
                    case 60:
                        ck4_DLDichVu.Checked = true;
                        break;
                    case 65:
                        ck4_DLKhachSan.Checked = true;
                        break;
                    //Báo cáo
                    case 70:
                        ck5_CongNo.Checked = true;
                        break;
                }
            }
        }
        private void frmActionGroupTour_Load(object sender, EventArgs e)
        {
            mSkin = MaterialSkinManager.Instance;
            mSkin.AddFormToManage(this);
            mSkin.Theme = ConfigApp.Themes;
            mSkin.ColorScheme = new ColorScheme(ConfigApp.Primary, ConfigApp.DarkPrimary, ConfigApp.LightPrimary, ConfigApp.Accent, ConfigApp.TextShade);
            txtUsername.Focus();
            txtUsername.Text = _objectData.Username;
            loadRole();
        }
        private string getStringRole()
        {
            var role = "0";
            if (ck1_TaiKhoan.Checked)
                role += ",5";
            if (ck1_PhanQuyen.Checked)
                role += ",10";
            if (ck2_Booktour.Checked)
                role += ",15";
            if (ck2_ListBook.Checked)
                role += ",20";
            if (ck2_SapXepXe.Checked)
                role += ",25";
            if (ck3_QLTour.Checked)
                role += ",30";
            if (ck3_QLDoiTac.Checked)
                role += ",35";
            if (ck3_QLNhomTour.Checked)
                role += ",40";
            if (ck3_QLNhomDT.Checked)
                role += ",45";
            if (ck4_DLXe.Checked)
                role += ",50";
            if (ck4_DLNhanVien.Checked)
                role += ",55";
            if (ck4_DLDichVu.Checked)
                role += ",60";
            if (ck4_DLKhachSan.Checked)
                role += ",65";
            if (ck5_CongNo.Checked)
                role += ",70";
            return role;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Xác nhận cập nhật phân quyền cho tài khoản ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                var rs = userRoleService.Update(Constant.CurrentSessionUser, getStringRole());
                if (rs)
                {
                    MessageBox.Show("Cập nhật thành công");
                    if (loadData != null)
                        loadData();
                    this.Close();
                }
                else
                    MessageBox.Show("Cập nhật thất bại");
            }

        }

        private void btnUpdatePass_Click(object sender, EventArgs e)
        {

        }
    }
}
