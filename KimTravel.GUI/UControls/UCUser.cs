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

namespace KimTravel.GUI.UControls
{
    public partial class UCUser : UserControl
    {
        private ApplicationUserService objService;
        public UCUser()
        {
            InitializeComponent();
        }

        private void loadDataGroup()
        {
            objService = new ApplicationUserService();
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadDataGroup();
        }
    }
}
