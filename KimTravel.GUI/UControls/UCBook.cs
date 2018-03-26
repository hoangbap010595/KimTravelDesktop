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
using KimTravel.DAL;
using DevExpress.XtraEditors;

namespace KimTravel.GUI.UControls
{
    public partial class UCBook : XtraUserControl
    {
        private PartnerService pnService = new PartnerService();
        private GroupTourService grTourService = new GroupTourService();
        private TourService tService = new TourService();
        private BookService bService = new BookService();
        private PriceService priceService = new PriceService();
        private DataTable tableService = new DataTable();

        public UCBook()
        {
            InitializeComponent();
            dtpStartDate.MinDate = DateTime.Now.AddDays(-1);
            dtpStartDate.Value = DateTime.Now.AddDays(1);
            tableService.Columns.Add("ServiceType");
            tableService.Columns.Add("Price", typeof(int));
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

            cbbPartnerID.DataSource = pnService.GetListCobobox();
            cbbPartnerID.ValueMember = "PartnerID";
            cbbPartnerID.DisplayMember = "Address";

            dtpTourBookedForPartner.AutoGenerateColumns = false;
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
                int partnerID = int.Parse(cbbPartnerID.SelectedValue.ToString());
                string date1 = dtpStartDate.Value.ToString("yyyy-MM-dd");
                Tour tour = tService.GetByID(id);
                txtPriceSa.Text = tour.PriceSale.ToString();
                txtPriceVTQ.Text = tour.PriceVTQ.ToString();

                Dictionary<string, object> dataObject = bService.getInfoBooked(gID, id, date1);
                int C1 = int.Parse(dataObject["CurrentTotal"].ToString());

                string msg = "Đã book: " + C1;
                lblMsgPax.Text = msg;

                txtPriceRe.Text = priceService.GetPriceForPartner(partnerID, id);
            }
            catch { }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                book.TourID = int.Parse(cbbTourID.SelectedValue.ToString());
                book.PartnerID = int.Parse(cbbPartnerID.SelectedValue.ToString());
                book.StartDate = dtpStartDate.Value;
                book.EndDate = dtpStartDate.Value;
                book.Pax = float.Parse(numPax.Value.ToString());
                book.StaffID = txtSaleBook.Text;

                //Cus
                book.CustomName = "";
                book.Room = txtRoom.Text;
                Partner p = pnService.GetByID(int.Parse(cbbPartnerID.SelectedValue.ToString()));
                book.PickUp = txtPickUp.Text.Trim() == "" ? p.Line  + " "+ p.Address : txtPickUp.Text;

                //Service
                book.PartnerPrice = int.Parse(txtPartnerPrice.Text == "" ? "0" : txtPartnerPrice.Text);
                book.PriceReceive = int.Parse(txtPriceRe.Text == "" ? "0" : txtPriceRe.Text);
                book.PriceSale = int.Parse(txtPriceSa.Text == "" ? "0" : txtPriceSa.Text);
                book.PriceVTQ = int.Parse(txtPriceVTQ.Text == "" ? "0" : txtPriceVTQ.Text);
                book.Note = txtNote.Text;

                book.ServiceType = getJsonServiceType();
                book.ServiceName = getJsonServiceName();
                book.PromotionMoney = int.Parse(txtPromotionMoney.Text == "" ? "0" : txtPromotionMoney.Text);
                book.PromotionPercent = 0;
                book.Total = int.Parse(lblTotalBook.Text);
                book.DateCreate = DateTime.Now;
                book.CreateBy = Constant.CurrentSessionUser;
                book.IsCancel = false;
                book.IsBooked = false;
                book.IsPayment = false;
                if (book.StaffID == "" || book.StaffID == null) { XtraMessageBox.Show("Tên NV book không thể để trống!"); return; }
                var rs = bService.Insert(book);
                if (rs)
                {
                    XtraMessageBox.Show("Book tour thành công!");
                    txtNote.Text = txtRoom.Text = txtSaleBook.Text = txtPickUp.Text = txtPartnerPrice.Text = "";
                    numPax.Value = 2;
                    cbbPartnerID_SelectedValueChanged(sender, e);
                    tableService.Rows.Clear();
                    dataGridViewGroupTour.DataSource = tableService;
                }else
                {
                    XtraMessageBox.Show("Các điều kiện không hợp lệ!. Book tour thất bại.");
                }
              
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Xảy ra lỗi: " + ex.Message);
            }
        }
        private string getJsonServiceName()
        {
            string data = "";
            foreach (DataRow item in tableService.Rows)
            {
                data += item["ServiceType"].ToString() + ",";
            }
            data = data.TrimEnd(',');
            return data;
        }
        private string getJsonServiceType()
        {
            string data = "[";
            foreach (DataRow item in tableService.Rows)
            {
                string d = "{\"ServiceType\":\"" + item["ServiceType"].ToString() + "\",\"Price\":" + int.Parse(item["Price"].ToString()) + "},";
                data += d;
            }
            data = data.TrimEnd(',') + "]";
            return data;
        }

        private int getTotalPriceService()
        {
            int price = 0;
            foreach (DataRow item in tableService.Rows)
            {
                price += int.Parse(item["Price"].ToString());
            }
            return price;
        }
        private void getService(string name, int price, int add)
        {
            if (add == 1)
            {
                DataRow dr = tableService.NewRow();
                dr["ServiceType"] = name;
                dr["Price"] = price;

                tableService.Rows.Add(dr);
            }
           
            tableService.AcceptChanges();
            dataGridViewGroupTour.DataSource = tableService;
            lblMoney.Text = "Total:" + String.Format("{0:#,###}", getTotalPriceService());
            payment();
        }
        private void btnAddServiceType_Click(object sender, EventArgs e)
        {
            frmFindServiceType frm = new frmFindServiceType();
            frm.sendData = new frmFindServiceType.LoadData(getService);
            frm.Show();
        }

        private void dataGridViewGroupTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    tableService.Rows.RemoveAt(e.RowIndex);
                    tableService.AcceptChanges();
                    dataGridViewGroupTour.DataSource = tableService;
                    payment();
                }
            }
            catch { }
        }

        private void cbbPartnerID_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string date = dtpStartDate.Value.ToString("yyyy-MM-dd");
                int partnerID = int.Parse(cbbPartnerID.SelectedValue.ToString());
                int tourID = int.Parse(cbbTourID.SelectedValue.ToString());

                dtpTourBookedForPartner.DataSource = bService.GetList(partnerID, date);
                dtpTourBookedForPartner.Update();
                dtpTourBookedForPartner.Refresh();
                txtPriceRe.Text = priceService.GetPriceForPartner(partnerID, tourID);
            }
            catch { }
        }

        private void PriceChanged_TextChanged(object sender, EventArgs e)
        {
            payment();
        }

        private void payment()
        {
            try
            {
                int priceSale = int.Parse(txtPriceSa.Text == "" ? "0" : txtPriceSa.Text);
                int priceRe = int.Parse(txtPriceRe.Text == "" ? "0" : txtPriceRe.Text);
                int priceVTQ = int.Parse(txtPriceVTQ.Text == "" ? "0" : txtPriceVTQ.Text);
                int pricePartner = int.Parse(txtPartnerPrice.Text == "" ? "0" : txtPartnerPrice.Text);
                int priceService = getTotalPriceService();
                int moneySale = 0;
                if (txtPromotionMoney.Text != "")
                {
                    moneySale = int.Parse(txtPromotionMoney.Text);
                }

                float pax = float.Parse(numPax.Value.ToString());

                var total = ((priceRe + priceVTQ + priceService) * pax) - moneySale;

                lblTotalBook.Text = total.ToString();
                lblFGiaBan.Text = String.Format("{0:#,###}", priceSale);
                lblFGiaNhan.Text = String.Format("{0:#,###}", priceRe);
                lblFGiaVTQ.Text = String.Format("{0:#,###}", priceVTQ);
                lblFThuHo.Text = String.Format("{0:#,###}", pricePartner);
                lblMoney.Text = String.Format("{0:#,###}", priceService);
            }
            catch
            {

            }
        }

        private void numPax_ValueChanged(object sender, EventArgs e)
        {
            payment();
        }

        private void txtFindPartner_TextChanged(object sender, EventArgs e)
        {
            string content = txtFindPartner.Text.Trim();
            cbbPartnerID.DataSource = pnService.GetListCobobox(content);
            cbbPartnerID.ValueMember = "PartnerID";
            cbbPartnerID.DisplayMember = "Address";
        }

        private void loadDataPartner()
        {
            pnService = new PartnerService();
            string content = txtFindPartner.Text.Trim();
            cbbPartnerID.DataSource = pnService.GetListCobobox(content);
            cbbPartnerID.ValueMember = "PartnerID";
            cbbPartnerID.DisplayMember = "Address";
        }
        private void btnAddPartner_Click(object sender, EventArgs e)
        {
            frmActionPartner frm = new frmActionPartner();
            frm.loadData = new frmActionPartner.LoadData(loadDataPartner);
            frm.ShowDialog();
        }
    }
}
