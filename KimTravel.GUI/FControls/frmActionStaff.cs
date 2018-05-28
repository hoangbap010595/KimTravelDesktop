using DevExpress.XtraEditors;
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
    public partial class frmActionStaff : XtraForm
    {
        private Staff _objectData;
        private StaffService gtService = new StaffService();
        private PartnerService pnService = new PartnerService();
        private ApplicationUserService userService = new ApplicationUserService();
        private int _action = -1;
        private int _objID = -1;
        public delegate void LoadData();
        public LoadData loadData;
        public frmActionStaff(int action = -1, int objID = -1)
        {
            InitializeComponent();
            _action = action;
            _objID = objID;
            _objectData = gtService.GetByID(objID);
        }

        private void frmActionGroupTour_Load(object sender, EventArgs e)
        {
            txtPSID.Focus();

            cbbStatus.DataSource = Constant.getListStatus();
            cbbStatus.ValueMember = "ID";
            cbbStatus.DisplayMember = "Name";

            cbbKindStaff.DataSource = Constant.getListKindStaff();
            cbbKindStaff.ValueMember = "ID";
            cbbKindStaff.DisplayMember = "Name";

            cbbPartnerID.DataSource = pnService.GetList();
            cbbPartnerID.ValueMember = "PartnerID";
            cbbPartnerID.DisplayMember = "Address";

            if (_action == -1)
                this.Text = "Thêm mới nhân viên";
            else
            {
                this.Text = "Cập nhật nhân viên";
                groupBoxAccount.Enabled = false;
            } 

            if (_objectData != null)
            {
                txtPSID.Text = _objectData.PSID;
                txtName.Text = _objectData.Name;
                txtAddress.Text = _objectData.Address;
                txtPhone.Text = _objectData.Phone;
                txtNote.Text = _objectData.Note;
                cbbStatus.SelectedValue = _objectData.Status;
                cbbKindStaff.SelectedValue = _objectData.Kind;
                cbbPartnerID.SelectedValue = _objectData.PartnerID == null ? 0 : _objectData.PartnerID;
            }
            else
            {
                txtPSID.Text = gtService.GetPSID();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPSID.Text == "")
            {
                XtraMessageBox.Show("Mã nhân viên không thể để trống.");
                return;
            }
            if (txtName.Text == "")
            {
                XtraMessageBox.Show("Tên nhân viên không thể để trống.");
                return;
            }
            if (userService.checkExistsUsername(txtUsername.Text))
            {
                XtraMessageBox.Show("Tên đăng nhập đã tồn tại trong hệ thống. Vui lòng thử với 1 tên khác.");
                return;
            }
            Staff staff = new Staff();
            staff.ID = _objID;
            staff.PSID = txtPSID.Text;
            staff.Name = txtName.Text;
            staff.Address = txtAddress.Text;
            staff.Phone = txtPhone.Text;
            staff.Status = int.Parse(cbbStatus.SelectedValue.ToString());
            staff.Kind = int.Parse(cbbKindStaff.SelectedValue.ToString());

            var partnerID = cbbPartnerID.Enabled == true ? cbbPartnerID.SelectedValue.ToString() : "-1";
            staff.PartnerID = int.Parse(partnerID);
            staff.Note = txtNote.Text;

            Dictionary<string, object> objAccount = null;
            if (partnerID != "-1" && _action == -1)
            {
                objAccount = new Dictionary<string, object>();
                objAccount.Add("PartnerID", partnerID);
                objAccount.Add("PartnerCode", txtCodePartner.Text);
                objAccount.Add("Username", txtUsername.Text);
                objAccount.Add("Password", txtPassword.Text);
            }
            var rs = false;
            var msg = "";
            if (_action == -1)
            {
                rs = this.gtService.Insert(staff, objAccount);
                msg = "Thêm mới thành công";
            }
            else
            {
                rs = this.gtService.Update(staff);
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
                XtraMessageBox.Show("Mã nhân viên tồn tại trong hệ thống. Vui lòng kiểm tra lại.");

        }

        private void cbbKindStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(cbbKindStaff.SelectedValue.ToString());
                if (id == 5)
                {
                    cbbPartnerID.Enabled = true;
                    txtFindPartner.Enabled = true;
                }
                else
                {
                    cbbPartnerID.Enabled = false;
                    txtFindPartner.Enabled = false;
                }
            }
            catch { }
        }

        private void txtFindPartner_TextChanged(object sender, EventArgs e)
        {
            string content = txtFindPartner.Text.Trim();
            cbbPartnerID.DataSource = pnService.GetListCobobox(content);
            cbbPartnerID.ValueMember = "PartnerID";
            cbbPartnerID.DisplayMember = "Address";
        }

        private void cbbPartnerID_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int pID = int.Parse(cbbPartnerID.SelectedValue.ToString());
                Partner p = pnService.GetByID(pID);
                txtCodePartner.Text = p.PartnerCode;
                int id = int.Parse(cbbKindStaff.SelectedValue.ToString());
                if (id != 5)
                {
                    txtCodePartner.Text = "";
                }
            }
            catch
            {

            }
        }
    }
}
