﻿using System;
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
    public partial class UCTour : UserControl
    {
        private GroupTourService grTourService = new GroupTourService();
        private TourService objService;
        public UCTour()
        {
            InitializeComponent();
        }

        private void loadDataGroup()
        {
            var gID = int.Parse(cbbGroupTour.SelectedValue.ToString());
            objService = new TourService();
            var data = objService.GetList(gID);
            dataGridViewGroupTour.DataSource = data;
            dataGridViewGroupTour.Update();
            dataGridViewGroupTour.Refresh();
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmActionTour frm = new frmActionTour();
            frm.loadData = new frmActionTour.LoadData(loadDataGroup);
            frm.ShowDialog();
        }

        private void UCGroupTour_Load(object sender, EventArgs e)
        {
            cbbGroupTour.DataSource = grTourService.GetListCombobox();
            cbbGroupTour.ValueMember = "GroupID";
            cbbGroupTour.DisplayMember = "Name";

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
                    frmActionTour frm = new frmActionTour(1, id);
                    frm.loadData = new frmActionTour.LoadData(loadDataGroup);
                    frm.ShowDialog();
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

        private void cbbGroupTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var x = cbbGroupTour.SelectedValue.ToString();
                int gID = int.Parse(x);
                dataGridViewGroupTour.DataSource = objService.GetList(gID);
            }
            catch { }
        }
    }
}
