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
using Newtonsoft.Json;
using DevExpress.XtraEditors;

namespace KimTravel.GUI.FControls
{
    public partial class frmDetailsTourDone : XtraForm
    {
        private GroupTourService grTourService = new GroupTourService();
        private TourService tService = new TourService();
        private PartnerService pnService = new PartnerService();
        private BookService bookService = new BookService();
        private Book _objectBook;
        private DataTable tableService = new DataTable();

        public delegate void LoadData();
        public LoadData loadData;
        private int _ObjID = -1;
        public frmDetailsTourDone(int objID = -1)
        {
            InitializeComponent();
            _ObjID = objID;
            tableService.Columns.Add("ServiceType");
            tableService.Columns.Add("Price", typeof(int));
        }

        private void frmActionGroupTour_Load(object sender, EventArgs e)
        {
            _objectBook = bookService.GetByID(_ObjID);
            dtpStartDate.Value = _objectBook.StartDate.Value;

            cbbGroupTourID.DataSource = grTourService.GetListCombobox();
            cbbGroupTourID.ValueMember = "GroupID";
            cbbGroupTourID.DisplayMember = "Name";

            cbbTourID.DataSource = tService.GetListCobobox();
            cbbTourID.ValueMember = "TourID";
            cbbTourID.DisplayMember = "Name";

            cbbPartnerID.DataSource = pnService.GetList();
            cbbPartnerID.ValueMember = "PartnerID";
            cbbPartnerID.DisplayMember = "Address";

            Tour t = tService.GetByID((int)_objectBook.TourID);
            cbbGroupTourID.SelectedValue = t.GroupID;
            cbbTourID.SelectedValue = _objectBook.TourID;
            cbbPartnerID.SelectedValue = _objectBook.PartnerID;

            numPax.Value = (decimal)_objectBook.Pax.Value;
            txtSaleBook.Text = _objectBook.StaffID;

            txtCustomer.Text = _objectBook.CustomName;
            txtPickup.Text = _objectBook.PickUp == "" ? cbbPartnerID.SelectedText : _objectBook.PickUp;
            txtRoom.Text = _objectBook.Room;

            txtPriceRe.Text = _objectBook.PriceReceive.ToString();
            txtPriceSa.Text = _objectBook.PriceSale.ToString();

            txtPartnerPrice.Text = _objectBook.PartnerPrice.ToString();

            txtPromotionPrice.Text = _objectBook.PromotionMoney.ToString();
            lblTotalBook.Text = _objectBook.Total.ToString();

            parseJsonServiceType(_objectBook.ServiceType);

            ckIsPayment.Checked = _objectBook.IsPayment.Value;
            ckBookOK.Checked = _objectBook.IsBooked.Value;
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
            if (DialogResult.OK == XtraMessageBox.Show("Xác nhận cập nhật thông tin.", "Thông báo", MessageBoxButtons.OKCancel))
            {
                frmConfirm frm = new frmConfirm();
                frm.confirm = new frmConfirm.ConfirmPassword(confirmOK);
                frm.ShowDialog();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (loadData != null)
                loadData();
            this.Close();
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
            var obj = Newtonsoft.Json.Linq.JArray.Parse(data);
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
            int priceService = getTotalPriceService();
            int moneySale = 0;
            if (txtPromotionPrice.Text != "")
            {
                moneySale = int.Parse(txtPromotionPrice.Text);
            }

            float priceTotal = priceRe + priceService;
            double paxTotal = double.Parse(numPax.Value.ToString()) * priceTotal;

            double total = paxTotal - moneySale;

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

        private void numPax_ValueChanged(object sender, EventArgs e)
        {
            payment();
        }

        private void confirmOK()
        {
            var isPayMent = ckIsPayment.Checked;
            var isBooked = ckBookOK.Checked;
            var rs = bookService.UpdateBookPayment(_ObjID, isPayMent);
            var rs2 = bookService.UpdateBooked(_ObjID, isBooked);
            if (rs && rs2)
            {
                XtraMessageBox.Show("Cập nhật trạng thái thành công.", "Thông báo");
                if (loadData != null)
                    loadData();
                this.Close();
            }
            else
                XtraMessageBox.Show("Xảy ra lỗi. Vui lòng thử lại", "Thông báo");
        }
    }
}
