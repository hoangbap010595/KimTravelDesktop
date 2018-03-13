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
using DevExpress.XtraReports.UI;
namespace KimTravel.GUI.UControls
{
    public partial class UCReportCongNo : UserControl
    {
        private PartnerService partnerService = new PartnerService();
        private GroupTourService grTourService = new GroupTourService();
        private TourService tService = new TourService();
        private BookService objService;
        public UCReportCongNo()
        {
            InitializeComponent();
        }

        private void loadDataGroup()
        {
            objService = new BookService();
            btnTimKiem.PerformClick();
        }
        private DataTable listMonth()
        {
            DataTable data = new DataTable();
            data.Columns.Add("ID", typeof(int));
            data.Columns.Add("Month");
            for (int i = 1; i <= 12; i++)
            {
                DataRow dr = data.NewRow();
                dr["ID"] = i;
                dr["Month"] = "Tháng " + i;
                data.Rows.Add(dr);
            }
            return data;
        }
        private DataTable listYear()
        {
            DataTable data = new DataTable();
            data.Columns.Add("ID", typeof(int));
            data.Columns.Add("Year");
            for (int i = 2017; i <= 2050; i++)
            {
                DataRow dr = data.NewRow();
                dr["ID"] = i;
                dr["Year"] = "" + i;
                data.Rows.Add(dr);
            }
            return data;
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmDetailsTour frm = new frmDetailsTour();
            frm.loadData = new frmDetailsTour.LoadData(loadDataGroup);
            frm.ShowDialog();
        }

        private void UCGroupTour_Load(object sender, EventArgs e)
        {
            objService = new BookService();
            dataGridViewGroupTour.AutoGenerateColumns = false;
            cbbPartnerID.DataSource = partnerService.GetListCobobox();
            cbbPartnerID.ValueMember = "PartnerID";
            cbbPartnerID.DisplayMember = "Address";

            cbbGroupTour.DataSource = grTourService.GetListCombobox();
            cbbGroupTour.ValueMember = "GroupID";
            cbbGroupTour.DisplayMember = "Name";

            cbbMonth.DataSource = listMonth();
            cbbMonth.ValueMember = "ID";
            cbbMonth.DisplayMember = "Month";

            cbbYear.DataSource = listYear();
            cbbYear.ValueMember = "ID";
            cbbYear.DisplayMember = "Year";

            cbbMonth.SelectedValue = DateTime.Now.Month;
            cbbYear.SelectedValue = DateTime.Now.Year;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;
                var id = int.Parse(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    frmDetailsTourDone frm = new frmDetailsTourDone(id);
                    frm.loadData = new frmDetailsTourDone.LoadData(loadDataGroup);
                    frm.ShowDialog();
                }
            }
            catch { }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            btnTimKiem.PerformClick();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var tID = int.Parse(cbbPartnerID.SelectedValue.ToString());
            var groupID = int.Parse(cbbGroupTour.SelectedValue.ToString());
            var month = int.Parse(cbbMonth.SelectedValue.ToString());
            var year = int.Parse(cbbYear.SelectedValue.ToString());
            dataGridViewGroupTour.DataSource = objService.GetListBookedDone(tID, groupID, month, year, true);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExcelLibrary.ExportToExcel(dataGridViewGroupTour);
        }
        private void dataGridViewGroupTour_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridViewGroupTour.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            var tID = int.Parse(cbbPartnerID.SelectedValue.ToString());
            var groupID = int.Parse(cbbGroupTour.SelectedValue.ToString());
            var month = int.Parse(cbbMonth.SelectedValue.ToString());
            var year = int.Parse(cbbYear.SelectedValue.ToString());
            xtraRPBaoCaoCongNo rp = new xtraRPBaoCaoCongNo(tID, groupID, month,year);
            rp.ShowPreview();
        }
    }
}
