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
    public partial class frmActionCar : MaterialForm
    {
        private MaterialSkinManager mSkin;
        private Car _objectData;
        private CarService carService = new CarService();
        private StaffService staffService = new StaffService();
        private CarTypeService typeCarService = new CarTypeService();
        
        private int _action = -1;
        private int _objID = -1;
        public delegate void LoadData();
        public LoadData loadData;
        public frmActionCar(int action = -1, int objID = -1)
        {
            InitializeComponent();
            _action = action;
            _objID = objID;
            _objectData = carService.GetByID(objID);
        }

        private void frmActionGroupTour_Load(object sender, EventArgs e)
        {
            mSkin = MaterialSkinManager.Instance;
            mSkin.AddFormToManage(this);
            mSkin.Theme = MaterialSkinManager.Themes.LIGHT;
            mSkin.ColorScheme = new ColorScheme(Primary.Blue600, Primary.BlueGrey900, Primary.DeepPurple100, Accent.Cyan700, TextShade.WHITE);
            txtCode.Focus();

            cbbType.DataSource = typeCarService.GetListCobobox();
            cbbType.ValueMember = "ID";
            cbbType.DisplayMember = "TypeName";

            cbbKindStaff.DataSource = staffService.GetStaffTaiXe();
            cbbKindStaff.ValueMember = "ID";
            cbbKindStaff.DisplayMember = "Name";

            if (_action == -1)
                this.Text = "Thêm mới thông tin xe";
            else
                this.Text = "Cập nhật thông tin xe";

            if (_objectData != null)
            {
                txtCode.Text = _objectData.Code;
                txtMax.Text = _objectData.Max.ToString();
                cbbType.SelectedValue = _objectData.Type;
                cbbKindStaff.SelectedValue = _objectData.StaffID == null ? 0 : _objectData.StaffID;
                txtNote.Text = _objectData.Note;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "")
            {
                MessageBox.Show("Số xe(BKS) không thể để trống.");
                return;
            }
            Car car = new Car();
            car.CarID = _objID;
            car.Code = txtCode.Text;
            car.Max = int.Parse(txtMax.Text);
            car.Type = int.Parse(cbbType.SelectedValue.ToString());
            car.Note = txtNote.Text;
            var sID = cbbKindStaff.Enabled == true ? cbbKindStaff.SelectedValue.ToString() : "-1";
            car.StaffID = int.Parse(sID);

            var rs = false;
            var msg = "";
            if (_action == -1)
            {
                rs = this.carService.Insert(car);
                msg = "Thêm mới thành công";
            }
            else
            {
                rs = this.carService.Update(car);
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
                MessageBox.Show("Biển số xe tồn tại trong hệ thống. Vui lòng kiểm tra lại.");

        }

    }
}
