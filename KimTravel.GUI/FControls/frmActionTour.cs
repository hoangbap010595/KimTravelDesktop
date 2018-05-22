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
    public partial class frmActionTour : XtraForm
    {
        private Tour _objectData;
        private TourService gtService = new TourService();
        private GroupTourService grTourService = new GroupTourService();
        private int _action = -1;
        private int _objID = -1;
        public delegate void LoadData();
        public LoadData loadData;
        public frmActionTour(int action = -1, int objID = -1)
        {
            InitializeComponent();
            _action = action;
            _objID = objID;
            _objectData = gtService.GetByID(objID);
        }

        private void frmActionGroupTour_Load(object sender, EventArgs e)
        {
            txtName.Focus();

            cbbGroupTour.DataSource = grTourService.GetListCombobox();
            cbbGroupTour.ValueMember = "GroupID";
            cbbGroupTour.DisplayMember = "Name";

            if (_action == -1)
                this.Text = "Thêm mới tour";
            else
                this.Text = "Cập nhật tour";
            
            if (_objectData != null)
            {
                txtName.Text = _objectData.Name;
                txtGiaBan.Text = _objectData.PriceSale.ToString();
                txtPriceChild.Text = _objectData.PriceSaleChild.ToString();
                txtPriceVTQ.Text = _objectData.PriceVTQ.ToString();
                ckEnabled.Checked = _objectData.Enable == true ? true : false; ;
                cbbGroupTour.SelectedValue = _objectData.GroupID;
                txtMinPax.Text = _objectData.MinPax.ToString();
                txtMaxPax.Text = _objectData.MaxPax.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "")
            {
                XtraMessageBox.Show("Tên tour không thể để trống.");
                return;
            }

            Tour groupTourNew = new Tour();
            groupTourNew.TourID = _objID;
            groupTourNew.Name = txtName.Text;
            groupTourNew.PriceSale = int.Parse(txtGiaBan.Text == "" ? "0" : txtGiaBan.Text);
            groupTourNew.PriceSaleChild = int.Parse(txtPriceChild.Text == "" ? "0" : txtPriceChild.Text);
            groupTourNew.PriceVTQ = int.Parse(txtPriceVTQ.Text == "" ? "0" : txtPriceVTQ.Text);
            groupTourNew.Enable = ckEnabled.Checked;
            groupTourNew.GroupID = int.Parse(cbbGroupTour.SelectedValue.ToString());
            groupTourNew.MaxPax = int.Parse(txtMaxPax.Text.ToString());
            groupTourNew.MinPax = int.Parse(txtMinPax.Text.ToString());
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
                XtraMessageBox.Show(msg);

                if (loadData != null)
                    loadData();
                this.Close();
            }
            else
                XtraMessageBox.Show("Tên tour tồn tại trong hệ thống. Vui lòng kiểm tra lại.");

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
