using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimTravel.GUI.FControls;
using KimTravel.DAL.Services;
using KimTravel.DAL.Models;

namespace KimTravel.GUI.UControls
{
    public partial class UCBook : UserControl
    {
        private PartnerService pnService = new PartnerService();
        private GroupTourService grTourService = new GroupTourService();
        private TourService tService = new TourService();
        private BookService bService = new BookService();
        public UCBook()
        {
            InitializeComponent();
        }

        private void choosePartner(int pid)
        {
            if (pid != -1)
                cbbPartnerID.SelectedValue = pid;
        }

        private void UCGroupTour_Load(object sender, EventArgs e)
        {
            cbbGroupTourID.DataSource = grTourService.GetListCombobox();
            cbbGroupTourID.ValueMember = "GroupID";
            cbbGroupTourID.DisplayMember = "Name";

            cbbTourID.DataSource = tService.GetListCobobox();
            cbbTourID.ValueMember = "TourID";
            cbbTourID.DisplayMember = "Name";

            cbbPartnerID.DataSource = pnService.GetList();
            cbbPartnerID.ValueMember = "PartnerID";
            cbbPartnerID.DisplayMember = "Address";

            dtpEndDate.MinDate = dtpStartDate.MinDate = DateTime.Now;
            dtpStartDate.Value = dtpEndDate.Value = DateTime.Now.AddDays(1);
        }

        private void btnFindParnet_Click(object sender, EventArgs e)
        {
            frmFindPartner frm = new frmFindPartner();
            frm.sendData = new frmFindPartner.LoadData(choosePartner);
            frm.ShowDialog();
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

        private void TextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
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

                Dictionary<string, object> dataObject = bService.getInfoBooked(gID, id, date1, date2);
                int C1 = int.Parse(dataObject["CurrentTotal"].ToString());
                int C2 = int.Parse(dataObject["MaxPax"].ToString());
                int C3 = C2 - C1;

                string msg = "Đã book " + C1 + "/" + C2;
                lblMsgPax.Text = msg;

                numPax.Maximum = C3;
            }
            catch { }
        }
    }
}
