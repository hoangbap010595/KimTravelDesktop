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
    public partial class frmDetailsTour : MaterialForm
    {
        private MaterialSkinManager mSkin;
        private GroupTourService grTourService = new GroupTourService();
        private TourService tService = new TourService();
        private PartnerService pnService = new PartnerService();
        private BookService bookService = new BookService();
        private Book _objectBook;
        public delegate void LoadData();
        public LoadData loadData;
        private int _WorkID = -1;
        public frmDetailsTour(int wID = 1)
        {
            InitializeComponent();
            _WorkID = wID;

            dtpEndDate.MinDate = dtpStartDate.MinDate = DateTime.Now.AddDays(-1);
            dtpStartDate.Value = dtpEndDate.Value = DateTime.Now.AddDays(1);
        }

        private void frmActionGroupTour_Load(object sender, EventArgs e)
        {
            mSkin = MaterialSkinManager.Instance;
            mSkin.AddFormToManage(this);
            mSkin.Theme = ConfigApp.Themes;
            mSkin.ColorScheme = new ColorScheme(ConfigApp.Primary, ConfigApp.DarkPrimary, ConfigApp.LightPrimary, ConfigApp.Accent, ConfigApp.TextShade);

            if (_WorkID == 1)
                btnCancel.Text = "Hủy bỏ";
            else
                btnCancel.Text = "Hoàn tác";

            _objectBook = bookService.GetByID(_WorkID);

            cbbGroupTourID.DataSource = grTourService.GetListCombobox();
            cbbGroupTourID.ValueMember = "GroupID";
            cbbGroupTourID.DisplayMember = "Name";
            cbbPartnerID.DataSource = pnService.GetList();
            cbbPartnerID.ValueMember = "PartnerID";
            cbbPartnerID.DisplayMember = "Address";

            cbbPartnerID.SelectedValue = _objectBook.PartnerID;
            cbbTourID.SelectedValue = _objectBook.TourID;
            cbbPartnerID.SelectedValue = _objectBook.PartnerID;
            dtpStartDate.Value = _objectBook.StartDate.Value;
            dtpStartDate.Value = _objectBook.EndDate.Value;
            numPax.Value = _objectBook.Pax.Value;
            txtSaleBook.Text = _objectBook.StaffID.ToString();

            txtCustomer.Text = _objectBook.CustomName;
            txtPickup.Text = _objectBook.PickUp;
            txtRoom.Text = _objectBook.Room;

            txtPriceRe.Text = _objectBook.PriceReceive.ToString();
            txtPriceSa.Text = _objectBook.PriceSale.ToString();
            txtPriceVTQ.Text = _objectBook.PriceVTQ.ToString();
            txtPartnerPrice.Text = _objectBook.PartnerPrice.ToString();

            txtPromotionPrice.Text = _objectBook.PromotionMoney.ToString();
            numPromotionPer.Value = _objectBook.PromotionPercent.Value;
            txtTotal.Text = _objectBook.Total.ToString();

        }
        private void cbbTourID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int gID = int.Parse(cbbGroupTourID.SelectedValue.ToString());
                int id = int.Parse(cbbTourID.SelectedValue.ToString());
                string date1 = dtpStartDate.Value.ToString("MM-dd-yyyy");
                string date2 = dtpEndDate.Value.ToString("MM-dd-yyyy");
                Tour tour = tService.GetByID(id);
                txtPriceRe.Text = tour.PriceReceive.ToString();
                txtPriceSa.Text = tour.PriceSale.ToString();
                txtPriceVTQ.Text = tour.PriceVTQ.ToString();

                Dictionary<string, object> dataObject = bookService.getInfoBooked(gID, id, date1, date2);
                int C1 = int.Parse(dataObject["CurrentTotal"].ToString());
                int C2 = int.Parse(dataObject["MaxPax"].ToString());
                int C3 = C2 - C1;

                string msg = "Đã book " + C1 + "/" + C2;
                lblMsgPax.Text = msg;

                numPax.Maximum = C3;
            }
            catch { }
        }
        private void choosePartner(int pid)
        {
            if (pid != -1)
                cbbPartnerID.SelectedValue = pid;
        }
        private void btnFindParnet_Click(object sender, EventArgs e)
        {
            frmFindPartner frm = new frmFindPartner();
            frm.sendData = new frmFindPartner.LoadData(choosePartner);
            frm.ShowDialog();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (loadData != null)
                loadData();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_WorkID == 1)
            {
                //Cancel = true
                if (DialogResult.OK == MessageBox.Show("Xác nhận muốn hủy bỏ tour đã book này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                {

                }
            }
            else
            {
                //Cancel = false
                if (DialogResult.OK == MessageBox.Show("Xác nhận muốn hoàn tác tour đã hủy này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                {

                }
            }
        }

        private void cbbGroupTourID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var x = cbbGroupTourID.SelectedValue.ToString();
                int gID = int.Parse(x);
                cbbTourID.DataSource = tService.GetListForGroup(gID);
                cbbTourID.ValueMember = "TourID";
                cbbTourID.DisplayMember = "Name";
            }
            catch { }
        }

        private void btnAddServiceType_Click(object sender, EventArgs e)
        {

        }
    }
}
