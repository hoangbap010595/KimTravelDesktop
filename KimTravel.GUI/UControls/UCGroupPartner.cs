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
    public partial class UCGroupPartner : UserControl
    {
        private PriceService objService;
        private GroupPartnerService gpService = new GroupPartnerService();
        public UCGroupPartner()
        {
            InitializeComponent();
        }

        private void loadDataGroup()
        {
            objService = new PriceService();
            var data = objService.GetList();
            dataGridViewGroupTour.DataSource = data;
            dataGridViewGroupTour.Update();
            dataGridViewGroupTour.Refresh();

            gpService = new GroupPartnerService();
            dtgGroupPartner.DataSource = gpService.GetList();
            dtgGroupPartner.Update();
            dtgGroupPartner.Refresh();
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmActionGroupPartner frm = new frmActionGroupPartner();
            frm.loadData = new frmActionGroupPartner.LoadData(loadDataGroup);
            frm.ShowDialog();
        }

        private void UCGroupTour_Load(object sender, EventArgs e)
        {
            dataGridViewGroupTour.AutoGenerateColumns = false;
            dtgGroupPartner.AutoGenerateColumns = false;
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
                    if (senderGrid.Columns[e.ColumnIndex].Name != "colDelete")
                    {
                        frmActionGroupPrice frm = new frmActionGroupPrice(1, id);
                        frm.loadData = new frmActionGroupPrice.LoadData(loadDataGroup);
                        frm.ShowDialog();
                    }
                    else
                    {
                        if (DialogResult.OK == MessageBox.Show("Xác nhận xóa dữ liệu ?", "Thông báo", MessageBoxButtons.OKCancel))
                        {
                            objService.Delete(id);
                            loadDataGroup();
                        }
                    }
                }
            }
            catch { }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadDataGroup();
        }
        private void dataGridViewGroupTour_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridViewGroupTour.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void dtgGroupPartner_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;
                var id = int.Parse(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    if (senderGrid.Columns[e.ColumnIndex].Name != "colDeleteGroup")
                    {
                        frmActionGroupPartner frm = new frmActionGroupPartner(1, id);
                        frm.loadData = new frmActionGroupPartner.LoadData(loadDataGroup);
                        frm.ShowDialog();
                    }
                    else
                    {
                        if (DialogResult.OK == MessageBox.Show("Xác nhận xóa dữ liệu ?", "Thông báo", MessageBoxButtons.OKCancel))
                        {
                            gpService.Delete(id);
                            loadDataGroup();
                        }
                    }
                }
            }
            catch { }
        }

        private void btnThemMoi_Click_1(object sender, EventArgs e)
        {
            frmActionGroupPrice frm = new frmActionGroupPrice();
            frm.loadData = new frmActionGroupPrice.LoadData(loadDataGroup);
            frm.ShowDialog();
        }
    }
}
