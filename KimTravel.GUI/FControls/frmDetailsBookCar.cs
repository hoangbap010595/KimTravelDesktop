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

namespace KimTravel.GUI.FControls
{
    public partial class frmDetailsBookCar : MaterialForm
    {
        private MaterialSkinManager mSkin;
        private StaffService staffService = new StaffService();
        private TourService tourService = new TourService();
        private DataTable _dataTemp;
        private string _tourName = "";
        private string _startDate = "";
        public frmDetailsBookCar(DataTable dt, int numCar, int tourID, string startDate)
        {
            InitializeComponent();
            _dataTemp = dt;
            Tour t = tourService.GetByID(tourID);
            lblTour.Text = t.Name;
            lblDate.Text = startDate;
            _tourName = t.Name;
            _startDate = startDate;
            this.Text = "Chi tiết xe " + numCar;
            btnPrint.UseVisualStyleBackColor = true;
            dataGridViewGroupTour.AutoGenerateColumns = false;
        }

        private void frmActionGroupTour_Load(object sender, EventArgs e)
        {
            mSkin = MaterialSkinManager.Instance;
            mSkin.AddFormToManage(this);
            mSkin.Theme = ConfigApp.Themes;
            mSkin.ColorScheme = new ColorScheme(ConfigApp.Primary, ConfigApp.DarkPrimary, ConfigApp.LightPrimary, ConfigApp.Accent, ConfigApp.TextShade);
            dataGridViewGroupTour.DataSource = _dataTemp;

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
            int x = 0;
            foreach (DataGridViewRow row in dataGridViewGroupTour.Rows)
            {
                if (row.Cells["colPax"].Value != null)
                {
                    int z = int.Parse(row.Cells["colPax"].Value.ToString());
                    x += z;
                }
            }
            lblTotal.Text = x + " pax";
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Staff hdv = staffService.GetByID(int.Parse(cbbHDV.SelectedValue.ToString()));
            Staff tx = staffService.GetByID(int.Parse(cbbTaiXe.SelectedValue.ToString()));
            xtraRPPrintBookTour xtra = new xtraRPPrintBookTour(_dataTemp, _tourName, _startDate, hdv.Name, tx.Name);
            //xtra.Print();
            //xtra.PrintDialog();
            xtra.ShowPreview();
        }

        private void TextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
