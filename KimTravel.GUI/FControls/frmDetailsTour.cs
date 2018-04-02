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
    public partial class frmDetailsTour : XtraForm
    {
        private GroupTourService grTourService = new GroupTourService();
        private TourService tService = new TourService();
        private PartnerService pnService = new PartnerService();
        private BookService bookService = new BookService();
        private PriceService priceService = new PriceService();
        private Book _objectBook;
        private DataTable tableService = new DataTable();

        public delegate void LoadData();
        public LoadData loadData;
        private int _WorkID = -1;
        private int _ObjID = -1;
        public frmDetailsTour(int wID = 1, int objID = -1)
        {
            InitializeComponent();
            _WorkID = wID;
            _ObjID = objID;
            tableService.Columns.Add("ServiceType");
            tableService.Columns.Add("Price", typeof(int));
            _objectBook = new Book();
        }

        private void frmActionGroupTour_Load(object sender, EventArgs e)
        {
            if (_WorkID == 1)
                btnCancel.Text = "Hủy bỏ";
            else
                btnCancel.Text = "Hoàn tác";

            _objectBook = bookService.GetByID(_ObjID);
            dtpStartDate.Value = _objectBook.StartDate.Value;

            cbbGroupTourID.DataSource = grTourService.GetListCombobox();
            cbbGroupTourID.ValueMember = "GroupID";
            cbbGroupTourID.DisplayMember = "Name";

            cbbPartnerID.DataSource = pnService.GetListCobobox();
            cbbPartnerID.ValueMember = "PartnerID";
            cbbPartnerID.DisplayMember = "Address";

            Tour t = tService.GetByID((int)_objectBook.TourID);
            cbbGroupTourID.SelectedValue = t.GroupID;
            cbbPartnerID.SelectedValue = _objectBook.PartnerID;
            cbbTourID.SelectedValue = _objectBook.TourID;
            cbbPartnerID.SelectedValue = _objectBook.PartnerID;

            numPax.Value = (decimal)_objectBook.Pax.Value;
            txtSaleBook.Text = _objectBook.StaffID;

            //Tre em
            numPaxChild.Value = (decimal)_objectBook.PaxChild.Value;
            txtPriceReChild.Text = _objectBook.PriceReChild.ToString();

            //txtCustomer.Text = _objectBook.CustomName;
            txtPickUp.Text = _objectBook.PickUp;
            txtRoom.Text = _objectBook.Room;

            txtPriceRe.Text = _objectBook.PriceReceive.ToString();
            txtPriceSa.Text = _objectBook.PriceSale.ToString();
            txtPartnerPrice.Text = _objectBook.PartnerPrice.ToString();
            txtNote.Text = _objectBook.Note;

            txtPromotionPrice.Text = _objectBook.PromotionMoney.ToString();
            lblTotalBookFinal.Text = _objectBook.Total.ToString();

            parseJsonServiceType(_objectBook.ServiceType);

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

                Dictionary<string, object> dataObject = bookService.getInfoBooked(gID, id, date1);
                int C1 = int.Parse(dataObject["CurrentTotal"].ToString());

                string msg = "Đã book: " + C1;
                //lblMsgPax.Text = msg;

                txtPriceRe.Text = priceService.GetPriceForPartner(partnerID, id);
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
            try
            {
                Book book = new Book();
                book.ID = _objectBook.ID;
                book.TourID = int.Parse(cbbTourID.SelectedValue.ToString());
                book.PartnerID = int.Parse(cbbPartnerID.SelectedValue.ToString());
                book.StartDate = dtpStartDate.Value;
                book.Pax = float.Parse(numPax.Value.ToString());
                book.StaffID = txtSaleBook.Text;

                //Cus
                book.CustomName = "";
                book.Room = txtRoom.Text;
                Partner p = pnService.GetByID(int.Parse(cbbPartnerID.SelectedValue.ToString()));
                book.PickUp = txtPickUp.Text.Trim() == "" ? p.Line + " " + p.Address : txtPickUp.Text;

                //Service
                book.PartnerPrice = int.Parse(txtPartnerPrice.Text == "" ? "0" : txtPartnerPrice.Text);
                book.PriceReceive = int.Parse(txtPriceRe.Text == "" ? "0" : txtPriceRe.Text);
                book.PriceSale = int.Parse(txtPriceSa.Text == "" ? "0" : txtPriceSa.Text);

                //Tre em
                book.PaxChild = float.Parse(numPaxChild.Value.ToString());
                book.PriceReChild = int.Parse(txtPriceReChild.Text == "" ? "0" : txtPriceReChild.Text);

                //book.PriceVTQ = 0;
                book.Note = txtNote.Text;

                book.ServiceType = getJsonServiceType();
                book.ServiceName = getJsonServiceName();
                book.PromotionMoney = int.Parse(txtPromotionPrice.Text == "" ? "0" : txtPromotionPrice.Text);
                book.PromotionPercent = 0;
                book.Total = int.Parse(lblTotalBookFinal.Text);
                book.LastUpdate = DateTime.Now;
                book.UpdateBy = Constant.CurrentSessionUser;
                //book.IsCancel = false;
                book.IsBooked = false;

                if (book.StaffID == "" || book.StaffID == null) { XtraMessageBox.Show("Tên NV book không thể để trống!"); return; }

                var rs = bookService.Update(book);
                if (rs)
                {
                    XtraMessageBox.Show("Cập nhật thành công");
                    if (loadData != null)
                        loadData();
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("Xảy ra lỗi vui lòng kiểm tra lại.");
                }
            }
            catch (Exception ex) { XtraMessageBox.Show("Xảy ra lỗi: " + ex.Message); }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (loadData != null)
                loadData();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_WorkID == 1)
            {
                //Cancel = true
                if (DialogResult.OK == XtraMessageBox.Show("Xác nhận muốn hủy bỏ tour đã book này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                {
                    bookService.UpdateBookCancel(_ObjID, true);
                    XtraMessageBox.Show("Tour đã hủy thành công!");
                    _WorkID = 2;
                }
            }
            else
            {
                //Cancel = false
                if (DialogResult.OK == XtraMessageBox.Show("Xác nhận muốn hoàn tác tour đã hủy này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                {
                    bookService.UpdateBookCancel(_ObjID, false);
                    XtraMessageBox.Show("Hoàn tác thành công!");
                    _WorkID = 1;
                }
            }

            if (_WorkID == 1)
                btnCancel.Text = "Hủy bỏ";
            else
                btnCancel.Text = "Hoàn tác";
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
            float priceSale = float.Parse(txtPriceSa.Text == "" ? "0" : txtPriceSa.Text);
            float priceRe = float.Parse(txtPriceRe.Text == "" ? "0" : txtPriceRe.Text);
            //Child
            float priceSaleChild = float.Parse(txtPriceSaChild.Text == "" ? "0" : txtPriceSaChild.Text);
            float priceReChild = float.Parse(txtPriceReChild.Text == "" ? "0" : txtPriceReChild.Text);
            //
            float pricePartner = float.Parse(txtPartnerPrice.Text == "" ? "0" : txtPartnerPrice.Text);
            float priceService = getTotalPriceService();
            float moneySale = 0;
            if (txtPromotionPrice.Text != "")
            {
                moneySale = float.Parse(txtPromotionPrice.Text);
            }
            //Tinh tien tre em
            double priceChild = double.Parse(numPaxChild.Value.ToString()) * priceReChild;
            //Tinh tien nguoi lon
            double priceTotal = priceRe + priceService;
            double paxTotal = double.Parse(numPax.Value.ToString()) * priceTotal;
            //Tinh Tong
            double total = (priceChild + paxTotal) - moneySale;

            lblTotalBookFinal.Text = total.ToString();
            lblFGiaBan.Text = String.Format("{0:#,###}", priceSale);
            lblFGiaNhan.Text = String.Format("{0:#,###}", priceRe);
            lblFPriceSaChild.Text = String.Format("{0:#,###}", priceSaleChild);
            lblFPriceReChild.Text = String.Format("{0:#,###}", priceReChild);
            lblFThuHo.Text = String.Format("{0:#,###}", pricePartner);
            lblMoney.Text = String.Format("{0:#,###}", priceService);
            lblTotalBook.Text = String.Format("{0:#,###}", total);
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
        private void txtFindPartner_TextChanged(object sender, EventArgs e)
        {
            string content = txtFindPartner.Text.Trim();
            cbbPartnerID.DataSource = pnService.GetListCobobox(content);
            cbbPartnerID.ValueMember = "PartnerID";
            cbbPartnerID.DisplayMember = "Address";
        }
    }
}
