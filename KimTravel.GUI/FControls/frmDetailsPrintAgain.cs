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
    public partial class frmDetailsPrintAgain : MaterialForm
    {
        private MaterialSkinManager mSkin;
        private StaffService staffService = new StaffService();
        private TourService tourService = new TourService();
        private PrintTourDetailsService printDetailService = new PrintTourDetailsService();
        //Print
        private DataTable _dataTemp;

        private int _TourID = 0;

        public frmDetailsPrintAgain(int PrintID, int tourID, string startDate, int guide1, string guide2, int driver1, string driver2, string carcode)
        {
            InitializeComponent();
            cbbHDV.DataSource = staffService.GetStaffHDV();
            cbbHDV.DisplayMember = "Name";
            cbbHDV.ValueMember = "ID";

            cbbTaiXe.DataSource = staffService.GetStaffTaiXe();
            cbbTaiXe.DisplayMember = "Name";
            cbbTaiXe.ValueMember = "ID";

            this.Text = "Chi tiết xe " + carcode;
            txtBKS.Text = carcode;
            _TourID = tourID;
            Tour t = tourService.GetByID(_TourID);
            lblTour.Text = t.Name;
            lblDate.Text = startDate;
            cbbHDV.SelectedValue = guide1;
            txtHdvName.Text = guide2;
            cbbTaiXe.SelectedValue = driver1;
            txtTXName.Text = driver2;
            gridControlData.DataSource = printDetailService.GetList(PrintID);
        }

        private void frmActionGroupTour_Load(object sender, EventArgs e)
        {
            mSkin = MaterialSkinManager.Instance;
            mSkin.AddFormToManage(this);
            mSkin.Theme = ConfigApp.Themes;
            mSkin.ColorScheme = new ColorScheme(ConfigApp.Primary, ConfigApp.DarkPrimary, ConfigApp.LightPrimary, ConfigApp.Accent, ConfigApp.TextShade);
           

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
                //xtraRPPrintBookTour xtra = new xtraRPPrintBookTour(_dataTemp, _tourName, _startDate.ToString("dd-MM-yyyy"), selectNameHDV, selectNameTX);
                //xtra.Print();
                //xtra.PrintDialog();
                //xtra.ShowPreview();
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
