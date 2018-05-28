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
        private bool AllowBook = true;
        private float AllowPax = 0;
        private Book book;
        public UCBook()
        {
            InitializeComponent();
            //dtpStartDate.MinDate = DateTime.Now.AddDays(-2);
            dtpStartDate.Value = DateTime.Now.AddDays(1);
            tableService.Columns.Add("ServiceType");
            tableService.Columns.Add("Price", typeof(int));
        }

        private void LoadNewData()
        {
            int id = int.Parse(cbbTourID.SelectedValue.ToString());
            string date1 = dtpStartDate.Value.ToString("yyyy-MM-dd");
            int partnerID = int.Parse(cbbPartnerID.SelectedValue.ToString());
            //Check Số lượng PAX
            Dictionary<string, object> dataObject = bService.getInfoBooked(id, date1);
            float AllowPick = float.Parse(dataObject["AllowPick"].ToString());
            float MinPax = float.Parse(dataObject["MinPax"].ToString());
            float MaxPax = float.Parse(dataObject["MaxPax"].ToString());
            float CurrentTotal = float.Parse(dataObject["CurrentTotal"].ToString());

            AllowPax = AllowPick;
            lblMsgPax.Text = CurrentTotal + "/" + MaxPax + " (pick)";

            //
            LoadDataPartnerID_SelectedValueChanged();
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
                txtPriceSaChild.Text = tour.PriceSaleChild.ToString();
                txtPriceRe.Text = priceService.GetPriceForPartner(partnerID, id);

                //Load
                LoadNewData();
            }
            catch { }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var paxNL = float.Parse(numPax.Value.ToString());
                var paxTE = float.Parse(numPaxChild.Value.ToString());
                if (AllowPax <= 0 || AllowPax < (paxNL + paxTE))
                    AllowBook = false;
                else
                    AllowBook = true;

                if (!AllowBook)
                {
                    XtraMessageBox.Show("Số lượng người đi đã book vượt quá số lượng tour cho phép.\nVui lòng kiểm tra lại.", "Thông báo");
                    return;
                }
                book = new Book();
                book.TourID = int.Parse(cbbTourID.SelectedValue.ToString());
                book.PartnerID = int.Parse(cbbPartnerID.SelectedValue.ToString());
                book.StartDate = dtpStartDate.Value;
                book.EndDate = dtpStartDate.Value;
                book.Pax = paxNL;
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
                book.PriceReChild = int.Parse(txtPriceReChild.Text == "" ? "0" : txtPriceReChild.Text);
                book.PaxChild = paxTE;
                //book.PriceVTQ = 0;
                book.Note = txtNote.Text;

                book.ServiceType = getJsonServiceType();
                book.ServiceName = getJsonServiceName();
                book.PromotionMoney = int.Parse(txtPromotionMoney.Text == "" ? "0" : txtPromotionMoney.Text);
                book.PromotionPercent = 0;
                book.Total = int.Parse(lblTotalBook.Text);
                book.DateCreate = DateTime.Now;
                book.CreateBy = Constant.CurrentSessionUser;
                book.IsCancel = false;
                book.IsBooked = true;
                book.IsPayment = false;
                book.IsDone = false;
                if (book.StaffID == "" || book.StaffID == null) { XtraMessageBox.Show("Tên NV book không thể để trống!"); return; }

                Tour t = tService.GetByID((int)book.TourID);
                Partner partner = pnService.GetByID((int)book.PartnerID);

                frmShowConfirmBookTour frm = new frmShowConfirmBookTour(dtpStartDate.Value.ToString("dd-MM-yyyy"), t.Name, String.Format("{0:N2}", book.Pax), book.ServiceName, book.StaffID, book.PickUp, book.Room, partner.Name, String.Format("{0:N0}", book.PartnerPrice), book.Note);
                frm.okbook = new frmShowConfirmBookTour.OKBookTour(okBook);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Xảy ra lỗi: " + ex.Message);
            }
        }
        private void okBook()
        {
            var rs = bService.Insert(book);
            if (rs)
            {
                XtraMessageBox.Show("Book tour thành công!");
                txtNote.Text = txtRoom.Text = txtSaleBook.Text = txtPickUp.Text = txtPartnerPrice.Text = "";
                numPax.Value = 2;
                numPaxChild.Value = 0;
                LoadDataPartnerID_SelectedValueChanged();
                tableService.Rows.Clear();
                dataGridViewGroupTour.DataSource = tableService;
                //Load
                LoadNewData();
            }
            else
            {
                XtraMessageBox.Show("Các điều kiện không hợp lệ!. Book tour thất bại.");
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
            int _TourID = int.Parse(cbbTourID.SelectedValue.ToString());
            frmFindServiceType frm = new frmFindServiceType(_TourID);
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
            LoadDataPartnerID_SelectedValueChanged();
        }

        private void LoadDataPartnerID_SelectedValueChanged()
        {
            try
            {
                string date = dtpStartDate.Value.ToString("yyyy-MM-dd");
                int partnerID = int.Parse(cbbPartnerID.SelectedValue.ToString());
                int tourID = int.Parse(cbbTourID.SelectedValue.ToString());

                gridControlData.DataSource = bService.GetList(partnerID, date);

                txtPriceRe.Text = priceService.GetPriceForPartner(partnerID, tourID);
                txtPriceReChild.Text = priceService.GetPriceChildForPartner(partnerID, tourID);
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
                float priceSale = float.Parse(txtPriceSa.Text == "" ? "0" : txtPriceSa.Text);
                float priceRe = float.Parse(txtPriceRe.Text == "" ? "0" : txtPriceRe.Text);
                //Child
                float priceSaleChild = float.Parse(txtPriceSaChild.Text == "" ? "0" : txtPriceSaChild.Text);
                float priceReChild = float.Parse(txtPriceReChild.Text == "" ? "0" : txtPriceReChild.Text);
                //
                float pricePartner = float.Parse(txtPartnerPrice.Text == "" ? "0" : txtPartnerPrice.Text);
                float priceService = getTotalPriceService();
                float moneySale = 0;
                if (txtPromotionMoney.Text != "")
                {
                    moneySale = float.Parse(txtPromotionMoney.Text);
                }

                //Tinh tien tre em
                double priceChild = double.Parse(numPaxChild.Value.ToString()) * priceReChild;
                //Tinh tien nguoi lon
                double priceTotal = priceRe + priceService;
                double paxTotal = double.Parse(numPax.Value.ToString()) * priceTotal;
                //Tinh Tong
                double total = (priceChild + paxTotal) - moneySale;

                //
                lblFGiaBan.Text = String.Format("{0:#,###}", priceSale);
                lblFGiaNhan.Text = String.Format("{0:#,###}", priceRe);
                lblFPriceSaChild.Text = String.Format("{0:#,###}", priceSaleChild);
                lblFPriceReChild.Text = String.Format("{0:#,###}", priceReChild);
                lblFThuHo.Text = String.Format("{0:#,###}", pricePartner);
                lblMoney.Text = String.Format("{0:#,###}", priceService);
                //Total
                lblTotalNguoiLon.Text = String.Format("{0:#,###}", paxTotal);
                lblTotalTreEm.Text = String.Format("{0:#,###}", priceChild);
                //  
                lblTotalBook.Text = total.ToString();
                lblMsgBook.Text = String.Format("{0:#,###}", total);
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

        private void loadDataGroup()
        {
            string date = dtpStartDate.Value.ToString("yyyy-MM-dd");
            int partnerID = int.Parse(cbbPartnerID.SelectedValue.ToString());
            gridControlData.DataSource = bService.GetList(partnerID, date);
        }
        private void btnClickEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                int id = int.Parse(gridViewData.GetFocusedRowCellValue("ID").ToString());
                frmDetailsTour frm = new frmDetailsTour(1, id);
                frm.loadData = new frmDetailsTour.LoadData(loadDataGroup);
                frm.ShowDialog();
            }
            catch { }
        }

        private void btnClickDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (DialogResult.OK == XtraMessageBox.Show("Bạn chắc chắn muốn xóa tour ra khỏi danh sách ?", "Xác nhận", MessageBoxButtons.OKCancel))
            {
                try
                {
                    int id = int.Parse(gridViewData.GetFocusedRowCellValue("ID").ToString());
                    bService.Delete(id);
                    loadDataGroup();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }
    }
}
