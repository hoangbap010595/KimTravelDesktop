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
    public partial class frmDetailsBookCar : MaterialForm
    {
        private MaterialSkinManager mSkin;
        private StaffService staffService = new StaffService();
        private TourService tourService = new TourService();
        private DataTable _dataTemp;
        private BookService bookService = new BookService();
        private string _tourName = "";
        private string _startDate = "";
        private int _numCar = 0;
        public delegate void RefreshData(int numCar);
        public RefreshData refreshData;
        public frmDetailsBookCar(DataTable dt, int numCar, int tourID, string startDate)
        {
            InitializeComponent();
            _dataTemp = dt;
            Tour t = tourService.GetByID(tourID);
            lblTour.Text = t.Name;
            lblDate.Text = startDate;
            _tourName = t.Name;
            _startDate = startDate;
            _numCar = numCar;
            this.Text = "Chi tiết xe " + numCar;
            btnPrint.UseVisualStyleBackColor = true;
        }

        private void frmActionGroupTour_Load(object sender, EventArgs e)
        {
            mSkin = MaterialSkinManager.Instance;
            mSkin.AddFormToManage(this);
            mSkin.Theme = ConfigApp.Themes;
            mSkin.ColorScheme = new ColorScheme(ConfigApp.Primary, ConfigApp.DarkPrimary, ConfigApp.LightPrimary, ConfigApp.Accent, ConfigApp.TextShade);
            gridControlData.DataSource = _dataTemp;

            cbbHDV.DataSource = staffService.GetStaffHDV();
            cbbHDV.DisplayMember = "Name";
            cbbHDV.ValueMember = "ID";

            cbbTaiXe.DataSource = staffService.GetStaffTaiXe();
            cbbTaiXe.DisplayMember = "Name";
            cbbTaiXe.ValueMember = "ID";

            countPax();
        }

        private void countPax()
        {
            float x = 0;
            for (int i = 0; i < gridViewData.RowCount; i++)
            {
                if (gridViewData.GetFocusedRowCellValue("Pax").ToString() != "")
                {
                    float z = float.Parse(gridViewData.GetFocusedRowCellValue("Pax").ToString());
                    x += z;
                }
            }

            lblTotal.Text = x + " pax";
        }

        private void updateStatusBooked()
        {
            for (int i = 0; i < gridViewData.RowCount; i++)
            {
                if (gridViewData.GetFocusedRowCellValue("ID").ToString() != "")
                {
                    int id = int.Parse(gridViewData.GetFocusedRowCellValue("ID").ToString());
                    var rs = bookService.UpdateBooked(id, true);
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnPrint.Enabled = btnBack.Enabled = false;
            lblMessageProgress.Visible = true;
            var msg = XtraMessageBox.Show("Hệ thống sẽ cập nhật trạng thái tour đã được book.\nBạn muốn cập nhật dữ liệu vào hệ thống và in các bản ghi ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == msg)
            {
                updateStatusBooked();
                Staff hdv = staffService.GetByID(int.Parse(cbbHDV.SelectedValue.ToString()));
                Staff tx = staffService.GetByID(int.Parse(cbbTaiXe.SelectedValue.ToString()));
                xtraRPPrintBookTour xtra = new xtraRPPrintBookTour(_dataTemp, _tourName, _startDate, hdv.Name, tx.Name);
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
    }
}
