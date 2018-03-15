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

namespace KimTravel.GUI.UControls
{
    public partial class UCListBook : UserControl
    {
        private GroupTourService grTourService = new GroupTourService();
        private TourService tService = new TourService();
        private BookService objService;
        public UCListBook()
        {
            InitializeComponent();
        }

        private void loadDataGroup()
        {
            objService = new BookService();
            //var data = objService.GetList();
            //dataGridViewGroupTour.DataSource = data;
            //dataGridViewGroupTour.Update();
            //dataGridViewGroupTour.Refresh();
            btnTimKiem.PerformClick();
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
            cbbGroupTourID.DataSource = grTourService.GetListCombobox();
            cbbGroupTourID.ValueMember = "GroupID";
            cbbGroupTourID.DisplayMember = "Name";

            dtpStartDate.Value = DateTime.Now.AddDays(1);
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
                    int work = rdBinhThuong.Checked == true ? 1 : 2;
                    frmDetailsTour frm = new frmDetailsTour(work, id);
                    frm.loadData = new frmDetailsTour.LoadData(loadDataGroup);
                    frm.ShowDialog();
                }
            }
            catch { }
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

                btnTimKiem.PerformClick();
            }
            catch { }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            btnTimKiem.PerformClick();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var tID = int.Parse(cbbTourID.SelectedValue.ToString());
            var dateStart = dtpStartDate.Value.ToString("yyyy-MM-dd");
            var isCancel = rdBinhThuong.Checked == true ? false : true;

            dataGridViewGroupTour.DataSource = objService.GetListBooked(tID, dateStart, isCancel);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if(dataGridViewGroupTour.RowCount == 0)
            {
                MessageBox.Show("Không tìm thấy dữ liệu.");
                return;
            }
            ExcelLibrary.ExportToExcel(dataGridViewGroupTour);
        }

    }
}
