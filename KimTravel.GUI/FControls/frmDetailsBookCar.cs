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
using DevExpress.XtraReports.UI;
using DevExpress.XtraEditors;

namespace KimTravel.GUI.FControls
{
    public partial class frmDetailsBookCar : XtraForm
    {
        private StaffService staffService = new StaffService();
        private TourService tourService = new TourService();
        //Print
        private PrintTourService printService = new PrintTourService();
        private PrintTourDetailsService printDetailService = new PrintTourDetailsService();
        private DataTable _dataTemp;
        private BookService bookService = new BookService();
        private int _tourID = 0;
        private string _tourName = "";
        private DateTime _startDate = DateTime.Now;
        private int _numCar = 0;
        public delegate void RefreshData(int numCar);
        public RefreshData refreshData;
        public frmDetailsBookCar(DataTable dt, int numCar, int tourID, string startDate)
        {
            InitializeComponent();
            _dataTemp = dt;
            _tourID = tourID;
            Tour t = tourService.GetByID(tourID);
            lblTour.Text = t.Name;
            lblDate.Text = startDate;
            _tourName = t.Name;
            _startDate = DateTime.Parse(startDate);
            _numCar = numCar;
            this.Text = "Chi tiết xe " + numCar;
            btnPrint.UseVisualStyleBackColor = true;
        }

        private void frmActionGroupTour_Load(object sender, EventArgs e)
        {
            gridControlData.DataSource = _dataTemp;

            cbbHDV.DataSource = staffService.GetStaffHDV();
            cbbHDV.DisplayMember = "Name";
            cbbHDV.ValueMember = "ID";

            cbbTaiXe.DataSource = staffService.GetStaffTaiXe();
            cbbTaiXe.DisplayMember = "Name";
            cbbTaiXe.ValueMember = "ID";

            lblTotal.Text = countPax() + " pax";
        }

        private float countPax()
        {
            float x = 0;
            for (int i = 0; i < gridViewData.RowCount; i++)
            {
                if (gridViewData.GetRowCellValue(i, "Pax").ToString() != "")
                {
                    float z = float.Parse(gridViewData.GetRowCellValue(i, "Pax").ToString());
                    x += z;
                }
            }

            return x;
        }

        private void updateStatusBooked()
        {
            for (int i = 0; i < gridViewData.RowCount; i++)
            {
                if (gridViewData.GetRowCellValue(i, "ID").ToString() != "")
                {
                    int id = int.Parse(gridViewData.GetRowCellValue(i, "ID").ToString());
                    var rs = bookService.UpdateBooked(id, true);
                }
            }
        }
        private void insertPrintDetails()
        {
            var hdvName = txtHdvName.Text;
            var txName = txtTXName.Text;
            var hdvID = cbbHDV.SelectedValue == null ? "0" : cbbHDV.SelectedValue.ToString();
            var txID = cbbTaiXe.SelectedValue == null ? "0" : cbbTaiXe.SelectedValue.ToString();
            if (hdvName != "")
                hdvID = "0";
            if (txName != "")
                txID = "0";
            var currentDate = DateTime.Now;
            PrintTour printTour = new PrintTour();
            //printTour.OrganizationID = 0;
            printTour.TourID = _tourID;
            printTour.DateStart = _startDate;
            printTour.Guide1 = int.Parse(hdvID);
            printTour.Guide2 = hdvName;
            printTour.Driver1 = int.Parse(txID);
            printTour.Driver2 = txName;
            printTour.CarCode = txtBKS.Text;
            printTour.DatePrint = currentDate;
            printTour.TotalPax = countPax();
            var printID = printService.Insert(printTour);
            for (int i = 0; i < gridViewData.RowCount; i++)
            {
                int bookID = int.Parse(gridViewData.GetRowCellValue(i, "ID").ToString());
                DetailPrintTour detail = new DetailPrintTour();
                detail.PrintID = printID;
                detail.BookID = bookID;
                detail.Date = currentDate;
                printDetailService.Insert(detail);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var hdvName = txtHdvName.Text;
            var txName = txtTXName.Text;
            var hdvID = cbbHDV.SelectedValue == null ? "0" : cbbHDV.SelectedValue.ToString();
            var txID = cbbTaiXe.SelectedValue == null ? "0" : cbbTaiXe.SelectedValue.ToString();
            Staff _objectHDV = staffService.GetByID(int.Parse(hdvID));
            Staff _objectTX = staffService.GetByID(int.Parse(txID));

            var selectNameHDV = hdvName != "" ? hdvName : _objectHDV == null ? "" : _objectHDV.Name;
            var selectNameTX = txName != "" ? txName : _objectTX == null ? "" : _objectTX.Name;
            if (String.IsNullOrEmpty(selectNameHDV))
            {
                XtraMessageBox.Show("Vui lòng nhập thông tin hướng dẫn viên.", "Thông báo"); return;
            }

            if (String.IsNullOrEmpty(selectNameTX))
            {
                XtraMessageBox.Show("Vui lòng nhập thông tin tài xế.", "Thông báo"); return;
            }

            btnPrint.Enabled = btnBack.Enabled = false;
            lblMessageProgress.Visible = true;
            var msg = XtraMessageBox.Show("Hệ thống sẽ cập nhật trạng thái tour đã được book.\nBạn muốn cập nhật dữ liệu vào hệ thống và in các bản ghi ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == msg)
            {
                insertPrintDetails();
                updateStatusBooked();
                xtraRPPrintBookTour xtra = new xtraRPPrintBookTour(_dataTemp, _tourName, _startDate.ToString("dd-MM-yyyy"), selectNameHDV, selectNameTX);
                //xtra.Print();
                //xtra.PrintDialog();
                xtra.ShowPreview();
                if (refreshData != null)
                    refreshData(_numCar);
            }
            btnBack.Enabled = true;
            lblMessageProgress.Visible = false;
        }

        private void TextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbTaiXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CarService cS = new CarService();
                var id = cbbTaiXe.SelectedValue == null ? "0" : cbbTaiXe.SelectedValue.ToString();
                int staffID = int.Parse(id);
                txtBKS.Text = cS.GetCode(staffID);
            }
            catch
            {
                txtBKS.Text = "";
            }
        }
    }
}
