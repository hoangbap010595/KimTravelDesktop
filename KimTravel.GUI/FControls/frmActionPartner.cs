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
    public partial class frmActionPartner : MaterialForm
    {
        private MaterialSkinManager mSkin;
        private Partner _objectData;
        private PartnerService gtService = new PartnerService();
        private int _action = -1;
        private int _objID = -1;
        public delegate void LoadData();
        public LoadData loadData;
        public frmActionPartner(int action = -1, int objID = -1)
        {
            InitializeComponent();
            _action = action;
            _objID = objID;
            _objectData = gtService.GetByID(objID);
        }

        private void frmActionGroupTour_Load(object sender, EventArgs e)
        {
            mSkin = MaterialSkinManager.Instance;
            mSkin.AddFormToManage(this);
            mSkin.Theme = MaterialSkinManager.Themes.LIGHT;
            mSkin.ColorScheme = new ColorScheme(Primary.Blue600, Primary.BlueGrey900, Primary.DeepPurple100, Accent.Cyan700, TextShade.WHITE);
            txtPartnerCode.Focus();

            cbbStatus.DataSource = Constant.getListStatus();
            cbbStatus.ValueMember = "ID";
            cbbStatus.DisplayMember = "Name";

            if (_action == -1)
                this.Text = "Thêm mới đối tác";
            else
                this.Text = "Cập nhật đối tác";
            
            if (_objectData != null)
            {
                txtPartnerCode.Text = _objectData.PartnerCode;
                txtName.Text = _objectData.Name;
                txtAddress.Text = _objectData.Address;
                txtPhone.Text = _objectData.Phone;
                txtNote.Text = _objectData.Note;
                cbbStatus.SelectedValue = _objectData.Status;
            }else
            {
                txtPartnerCode.Text = gtService.GetPartnerCode();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtPartnerCode.Text == "")
            {
                MessageBox.Show("Mã đơn vị không thể để trống.");
                return;
            }
            if (txtName.Text == "")
            {
                MessageBox.Show("Tên đơn vị không thể để trống.");
                return;
            }
            Partner groupTourNew = new Partner();
            groupTourNew.PartnerID = _objID;
            groupTourNew.PartnerCode = txtPartnerCode.Text;
            groupTourNew.Name = txtName.Text;
            groupTourNew.Address = txtAddress.Text;
            groupTourNew.Phone = txtPhone.Text;
            groupTourNew.Status = int.Parse(cbbStatus.SelectedValue.ToString());
            groupTourNew.Note = txtNote.Text;
            var rs = false;
            var msg = "";
            if (_action == -1)
            {
                rs = this.gtService.Insert(groupTourNew);
                msg = "Thêm mới thành công";
            }
            else
            {
                rs = this.gtService.Update(groupTourNew);
                msg = "Cập nhật thành công";
            }
            if (rs)
            {
                MessageBox.Show(msg);

                if (loadData != null)
                    loadData();
                this.Close();
            }
            else
                MessageBox.Show("Tên đối tồn tại trong hệ thống. Vui lòng kiểm tra lại.");

        }

    }
}
