﻿using KimTravel.DAL;
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
using Newtonsoft.Json;

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
        private DataTable tableService = new DataTable();

        public delegate void LoadData();
        public LoadData loadData;
        private int _WorkID = -1;
        public frmDetailsTour(int wID = 1)
        {
            InitializeComponent();
            _WorkID = wID;

            tableService.Columns.Add("ServiceType");
            tableService.Columns.Add("Price", typeof(int));
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
            dtpStartDate.Value = _objectBook.StartDate.Value;

            cbbGroupTourID.DataSource = grTourService.GetListCombobox();
            cbbGroupTourID.ValueMember = "GroupID";
            cbbGroupTourID.DisplayMember = "Name";
            cbbPartnerID.DataSource = pnService.GetList();
            cbbPartnerID.ValueMember = "PartnerID";
            cbbPartnerID.DisplayMember = "Address";

            cbbPartnerID.SelectedValue = _objectBook.PartnerID;
            cbbTourID.SelectedValue = _objectBook.TourID;
            cbbPartnerID.SelectedValue = _objectBook.PartnerID;
        
            numPax.Value = _objectBook.Pax.Value;
            txtSaleBook.Text = _objectBook.StaffID;

            txtCustomer.Text = _objectBook.CustomName;
            txtPickup.Text = _objectBook.PickUp == "" ? cbbPartnerID.SelectedText : _objectBook.PickUp;
            txtRoom.Text = _objectBook.Room;

            txtPriceRe.Text = _objectBook.PriceReceive.ToString();
            txtPriceSa.Text = _objectBook.PriceSale.ToString();
            txtPriceVTQ.Text = _objectBook.PriceVTQ.ToString();
            txtPartnerPrice.Text = _objectBook.PartnerPrice.ToString();

            txtPromotionPrice.Text = _objectBook.PromotionMoney.ToString();
            numPromotionPer.Value = _objectBook.PromotionPercent.Value;
            lblTotalBook.Text = _objectBook.Total.ToString();

            parseJsonServiceType(_objectBook.ServiceType);

        }
        private void cbbTourID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int gID = int.Parse(cbbGroupTourID.SelectedValue.ToString());
                int id = int.Parse(cbbTourID.SelectedValue.ToString());
                string date1 = dtpStartDate.Value.ToString("yyyy-MM-dd");
                Tour tour = tService.GetByID(id);
                txtPriceSa.Text = tour.PriceSale.ToString();
                txtPriceVTQ.Text = tour.PriceVTQ.ToString();

                Dictionary<string, object> dataObject = bookService.getInfoBooked(gID, id, date1);
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
            Book book = new Book();
            book.ID = _objectBook.ID;
            book.TourID = int.Parse(cbbTourID.SelectedValue.ToString());
            book.PartnerID = int.Parse(cbbPartnerID.SelectedValue.ToString());
            book.StartDate = dtpStartDate.Value;
            book.Pax = int.Parse(numPax.Value.ToString());
            book.StaffID = txtSaleBook.Text;

            //Cus
            book.CustomName = txtCustomer.Text;
            book.Room = txtRoom.Text;
            book.PickUp = txtPickup.Text;

            //Service
            book.PartnerPrice = int.Parse(txtPartnerPrice.Text == "" ? "0" : txtPartnerPrice.Text);
            book.PriceReceive = int.Parse(txtPriceRe.Text == "" ? "0" : txtPriceRe.Text);
            book.PriceSale = int.Parse(txtPriceSa.Text == "" ? "0" : txtPriceSa.Text);
            book.PriceVTQ = int.Parse(txtPriceVTQ.Text == "" ? "0" : txtPriceVTQ.Text);
            book.Note = txtNote.Text;

            book.ServiceType = getJsonServiceType();
            book.PromotionMoney = int.Parse(txtPromotionPrice.Text == "" ? "0" : txtPromotionPrice.Text);
            book.PromotionPercent = int.Parse(numPromotionPer.Value.ToString());
            book.Total = int.Parse(lblTotalBook.Text);
            book.LastUpdate = DateTime.Now;
            book.UpdateBy = Constant.CurrentSessionUser;
            //book.IsCancel = false;

            var rs = bookService.Update(book);
            MessageBox.Show("Cập nhật thành công");
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

        private void parseJsonServiceType(string data)
        {
            data = data.Trim('"');
            data = data.Replace("\\", "");
           var obj =  Newtonsoft.Json.Linq.JArray.Parse(data);
            foreach (var item in obj)
            {
                DataRow dr = tableService.NewRow();
                dr["ServiceType"] = item["ServiceType"];
                dr["Price"] = item["Price"];
                tableService.Rows.Add(dr);
            }
            tableService.AcceptChanges();
            dataGridViewGroupTour.DataSource = tableService;
            lblMoney.Text = "Total:" + String.Format("{0:#,###}", getTotalPriceService());
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
        private void TextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void PriceChanged_TextChanged(object sender, EventArgs e)
        {
            payment();
        }
        private void payment()
        {
            int priceRe = int.Parse(txtPriceRe.Text == "" ? "0" : txtPriceRe.Text);
            int priceVTQ = int.Parse(txtPriceVTQ.Text == "" ? "0" : txtPriceVTQ.Text);
            int priceService = getTotalPriceService();
            int moneySale = 0;
            if (txtPromotionPrice.Text != "")
            {
                moneySale = int.Parse(txtPromotionPrice.Text);
            }

            int pax = int.Parse(numPax.Value.ToString());

            var total = ((priceRe + priceVTQ + priceService) * pax) - moneySale;

            lblTotalBook.Text = total.ToString();
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
    }
}
