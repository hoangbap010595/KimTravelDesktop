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
        private BookService bService = new BookService();
        private BookService objService;
        public UCListBook()
        {
            InitializeComponent();
        }

        private void loadDataGroup()
        {
            objService = new BookService();
            var data = objService.GetList();
            dataGridViewGroupTour.DataSource = data;
            dataGridViewGroupTour.Update();
            dataGridViewGroupTour.Refresh();
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmActionUser frm = new frmActionUser();
            frm.loadData = new frmActionUser.LoadData(loadDataGroup);
            frm.ShowDialog();
        }

        private void UCGroupTour_Load(object sender, EventArgs e)
        {
            dataGridViewGroupTour.AutoGenerateColumns = false;
            loadDataGroup();

            cbbGroupTourID.DataSource = grTourService.GetListCombobox();
            cbbGroupTourID.ValueMember = "GroupID";
            cbbGroupTourID.DisplayMember = "Name";

            dtpStartDate.Value = dtpEndDate.Value = DateTime.Now.AddDays(1);
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
                    frmActionUser frm = new frmActionUser(1, id);
                    frm.loadData = new frmActionUser.LoadData(loadDataGroup);
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
            }
            catch { }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadDataGroup();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var gID = int.Parse(cbbGroupTourID.SelectedValue.ToString());
            var tID = int.Parse(cbbTourID.SelectedValue.ToString());
            var dateStart = dtpStartDate.Value.ToString("MM-dd-yyyy");
            var dateEnd = dtpEndDate.Value.ToString("MM-dd-yyyy");
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExcelLibrary.ExportToExcel(dataGridViewGroupTour);
        }
    }
}
