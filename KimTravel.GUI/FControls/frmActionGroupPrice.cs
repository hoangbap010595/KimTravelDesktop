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
    public partial class frmActionGroupPrice : MaterialForm
    {
        private MaterialSkinManager mSkin;
        private Price _objectData;
        private PriceService priceService = new PriceService();
        private GroupPartnerService groupService = new GroupPartnerService();
        private TourService tourService = new TourService();
        
        private int _action = -1;
        private int _objID = -1;
        public delegate void LoadData();
        public LoadData loadData;
        public frmActionGroupPrice(int action = -1, int objID = -1)
        {
            InitializeComponent();
            _action = action;
            _objID = objID;
            _objectData = priceService.GetByID(objID);
        }

        private void frmActionGroupTour_Load(object sender, EventArgs e)
        {
            mSkin = MaterialSkinManager.Instance;
            mSkin.AddFormToManage(this);
            mSkin.Theme = ConfigApp.Themes;
            mSkin.ColorScheme = new ColorScheme(ConfigApp.Primary, ConfigApp.DarkPrimary, ConfigApp.LightPrimary, ConfigApp.Accent, ConfigApp.TextShade);
            txtPriceRe.Focus();

            cbbGroupPartner.DataSource = groupService.GetList();
            cbbGroupPartner.ValueMember = "GroupPartnerID";
            cbbGroupPartner.DisplayMember = "GroupName";

            cbbTour.DataSource = tourService.GetListCobobox();
            cbbTour.ValueMember = "TourID";
            cbbTour.DisplayMember = "Name";

            if (_action == -1)
                this.Text = "Thêm mới giá nhận theo tour";
            else
                this.Text = "Cập nhật giá nhận theo tour";

            if (_objectData != null)
            {
                txtPriceRe.Text = _objectData.PriceRe.ToString();
                cbbGroupPartner.SelectedValue = _objectData.GroupID;
                cbbTour.SelectedValue = _objectData.TourID;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPriceRe.Text == "")
            {
                MessageBox.Show("Giá nhận không thể để trống.");
                return;
            }
            Price price = new Price();
            price.Key = _objID;
            price.GroupID = int.Parse(cbbGroupPartner.SelectedValue.ToString());
            price.TourID = int.Parse(cbbTour.SelectedValue.ToString());
            price.PriceRe = int.Parse(txtPriceRe.Text);

            var rs = false;
            var msg = "";
            if (_action == -1)
            {
                rs = this.priceService.Insert(price);
                msg = "Thêm mới thành công";
            }
            else
            {
                rs = this.priceService.Update(price);
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
                MessageBox.Show("Giá tour đã được thiết lập trong hệ thống. Vui lòng kiểm tra lại.");

        }

    }
}
