﻿using System;
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

namespace KimTravel.GUI.UControls
{
    public partial class UCBook : UserControl
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
            txtCustomName.Text = txtNote.Text = txtRoom.Text = txtSaleBook.Text = txtPickUp.Text = txtPartnerPrice.Text = "";
            tableService.Rows.Clear();
            dataGridViewGroupTour.DataSource = tableService;

            cbbGroupTourID.DataSource = grTourService.GetListCombobox();
            cbbGroupTourID.ValueMember = "GroupID";
            cbbGroupTourID.DisplayMember = "Name";

            cbbTourID.DataSource = tService.GetListCobobox();
            cbbTourID.ValueMember = "TourID";
            cbbTourID.DisplayMember = "Name";

            cbbPartnerID.DataSource = pnService.GetListCobobox();
            cbbPartnerID.ValueMember = "PartnerID";
            cbbPartnerID.DisplayMember = "Address";

            dtpTourBookedForPartner.AutoGenerateColumns = false;
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
                int partnerID = int.Parse(cbbPartnerID.SelectedValue.ToString());
                string date1 = dtpStartDate.Value.ToString("yyyy-MM-dd");
                Tour tour = tService.GetByID(id);
                txtPriceSa.Text = tour.PriceSale.ToString();
                txtPriceVTQ.Text = tour.PriceVTQ.ToString();

                Dictionary<string, object> dataObject = bService.getInfoBooked(gID, id, date1);
                int C1 = int.Parse(dataObject["CurrentTotal"].ToString());
                int C2 = int.Parse(dataObject["MaxPax"].ToString());
                int C3 = C2 - C1;

                string msg = "Đã book " + C1 + "/" + C2;
                lblMsgPax.Text = msg;

                //numPax.Maximum = C3;
                txtPriceRe.Text = priceService.GetPriceForPartner(partnerID, id);
            }
            catch { }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.TourID = int.Parse(cbbTourID.SelectedValue.ToString());
            book.PartnerID = int.Parse(cbbPartnerID.SelectedValue.ToString());
            book.StartDate = dtpStartDate.Value;
            book.EndDate = dtpStartDate.Value;
            book.Pax = int.Parse(numPax.Value.ToString());
            book.StaffID = txtSaleBook.Text;

            //Cus
            book.CustomName = txtCustomName.Text;
            book.Room = txtRoom.Text;
            book.PickUp = txtPickUp.Text == "" ? cbbPartnerID.SelectedText : txtPickUp.Text;

            //Service
            book.PartnerPrice = int.Parse(txtPartnerPrice.Text == "" ? "0" : txtPartnerPrice.Text);
            book.PriceReceive = int.Parse(txtPriceRe.Text == "" ? "0" : txtPriceRe.Text);
            book.PriceSale = int.Parse(txtPriceSa.Text == "" ? "0" : txtPriceSa.Text);
            book.PriceVTQ = int.Parse(txtPriceVTQ.Text == "" ? "0" : txtPriceVTQ.Text);
            book.Note = txtNote.Text;

            book.ServiceType = getJsonServiceType();
            book.PromotionMoney = int.Parse(txtPromotionMoney.Text == "" ? "0" : txtPromotionMoney.Text);
            book.PromotionPercent = int.Parse(numPromotionPercent.Value.ToString());
            book.Total = int.Parse(lblTotalBook.Text);
            book.DateCreate = DateTime.Now;
            book.CreateBy = Constant.CurrentSessionUser;
            book.IsCancel = false;

            var rs = bService.Insert(book);
            MessageBox.Show("Book tour thành công!");
            UCGroupTour_Load(sender, e);
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
        private void getService(string name, int price)
        {
            DataRow dr = tableService.NewRow();
            dr["ServiceType"] = name;
            dr["Price"] = price;

            tableService.Rows.Add(dr);
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

        private void numPromotionPercent_ValueChanged(object sender, EventArgs e)
        {
            int per = int.Parse(numPromotionPercent.Value.ToString());
            if (per == 0)
            {
                txtPromotionMoney.Text = "0";
                return;
            }
            int total = int.Parse(lblTotalBook.Text);
            int moneySale = (per * total) / 100;
            int result = total - moneySale;

            lblTotalBook.Text = result.ToString();
            txtPromotionMoney.Text = moneySale.ToString();
        }

        private void payment()
        {
            int priceRe = int.Parse(txtPriceRe.Text == "" ? "0" : txtPriceRe.Text);
            int priceVTQ = int.Parse(txtPriceVTQ.Text == "" ? "0" : txtPriceVTQ.Text);
            int priceService = getTotalPriceService();
            int moneySale = 0;
            if (txtPromotionMoney.Text != "")
            {
                moneySale = int.Parse(txtPromotionMoney.Text);
            }

            int pax = int.Parse(numPax.Value.ToString());

            var total = ((priceRe + priceVTQ + priceService) * pax) - moneySale;

            lblTotalBook.Text = total.ToString();
        }
    }
}
