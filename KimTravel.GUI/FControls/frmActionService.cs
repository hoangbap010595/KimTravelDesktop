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
    public partial class frmActionService : XtraForm
    {
        private ServiceTypeService gtService = new ServiceTypeService();
        ServiceType _objectData;
        private int _action = -1;
        private int _objID = -1;
        public delegate void LoadData();
        public LoadData loadData;
        public frmActionService(int action = -1, int objID = -1)
        {
            InitializeComponent();
            _action = action;
            _objID = objID;
            _objectData = gtService.GetByID(objID);
        }

        private void frmActionGroupTour_Load(object sender, EventArgs e)
        {
            txtServiceName.Focus();

            if (_action == -1)
                this.Text = "Thêm mới dịch vụ";
            else
                this.Text = "Cập nhật dịch vụ";

            if (_objectData != null)
            {
                txtServiceName.Text = _objectData.Name;
                txtPrice.Text = _objectData.Price.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtServiceName.Text == "")
            {
                XtraMessageBox.Show("Tên dịch vụ không thể để trống.");
                return;
            }
            ServiceType service = new ServiceType();
            service.ID = _objID;
            service.Name = txtServiceName.Text;
            service.Price = int.Parse(txtPrice.Text);

            var rs = false;
            var msg = "";
            if (_action == -1)
            {
                rs = this.gtService.Insert(service);
                msg = "Thêm mới thành công";
            }
            else
            {
                rs = this.gtService.Update(service);
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
                XtraMessageBox.Show("Dịch vụ đã tồn tại trong hệ thống. Vui lòng kiểm tra lại.");

        }
        private void TextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
