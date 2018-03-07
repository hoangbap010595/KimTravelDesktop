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
    public partial class frmActionTour : MaterialForm
    {
        private MaterialSkinManager mSkin;
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
            mSkin = MaterialSkinManager.Instance;
            mSkin.AddFormToManage(this);
            mSkin.Theme = ConfigApp.Themes;
            mSkin.ColorScheme = new ColorScheme(ConfigApp.Primary, ConfigApp.DarkPrimary, ConfigApp.LightPrimary, ConfigApp.Accent, ConfigApp.TextShade);
            txtName.Focus();

            cbbGroupTour.DataSource = grTourService.GetListCombobox();
            cbbGroupTour.ValueMember = "GroupID";
            cbbGroupTour.DisplayMember = "Name";

            if (_action == -1)
                this.Text = "Thêm mới đối tác";
            else
                this.Text = "Cập nhật đối tác";
            
            if (_objectData != null)
            {
                txtName.Text = _objectData.Name;
                txtGiaBan.Text = _objectData.PriceSale.ToString();
                txtGiaNhan.Text = _objectData.PriceReceive.ToString();
                txtPriceVTQ.Text = _objectData.PriceVTQ.ToString();
                ckEnabled.Checked = _objectData.Enable == true ? true : false; ;
                cbbGroupTour.SelectedValue = _objectData.GroupID;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "")
            {
                MessageBox.Show("Tên tour không thể để trống.");
                return;
            }

            Tour groupTourNew = new Tour();
            groupTourNew.TourID = _objID;
            groupTourNew.Name = txtName.Text;
            groupTourNew.PriceSale = int.Parse(txtGiaBan.Text == "" ? "0" : txtGiaBan.Text);
            groupTourNew.PriceReceive = int.Parse(txtGiaNhan.Text == "" ? "0" : txtGiaNhan.Text);
            groupTourNew.PriceVTQ = int.Parse(txtPriceVTQ.Text == "" ? "0" : txtPriceVTQ.Text);
            groupTourNew.Enable = ckEnabled.Checked;
            groupTourNew.GroupID = int.Parse(cbbGroupTour.SelectedValue.ToString());
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
                MessageBox.Show("Tên tour tồn tại trong hệ thống. Vui lòng kiểm tra lại.");

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
