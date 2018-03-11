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
using KimTravel.DAL;

namespace KimTravel.GUI.UControls
{
    public partial class UCBookCar : UserControl
    {
        private StaffService objService;
        public UCBookCar()
        {
            InitializeComponent();
        }

        private void loadDataGroup()
        {
            objService = new StaffService();
            var data = objService.GetList();
            dataGridViewGroupTour.DataSource = data;
            dataGridViewGroupTour.Update();
            dataGridViewGroupTour.Refresh();
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmActionStaff frm = new frmActionStaff();
            frm.loadData = new frmActionStaff.LoadData(loadDataGroup);
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

                if (senderGrid.CurrentCell.GetType() == typeof(DataGridViewCheckBoxCell))
                {
                    if (senderGrid.CurrentCell.IsInEditMode)
                    {
                        if (senderGrid.IsCurrentCellDirty)
                        {
                            senderGrid.EndEdit();
                        }
                    }
                }

            }
            catch { }
        }

        private void dataGridViewGroupTour_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.DataSource != null)
            {
                if (senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "True")
                {
                    senderGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
                    for (int i = 5; i < senderGrid.Columns.Count; i++)
                    {
                        if (i != e.ColumnIndex)
                            senderGrid[i, e.RowIndex].ReadOnly = true;
                    }
                    getTotalInCar(e.ColumnIndex, 1);
                }
                else
                {
                    senderGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    for (int i = 5; i < senderGrid.Columns.Count; i++)
                    {
                        senderGrid[i, e.RowIndex].ReadOnly = false;
                    }
                    getTotalInCar(e.ColumnIndex, -1);
                }

            }
        }
        private void getTotalInCar(int colIndex, int add)
        {
            int count = 0;
            switch (colIndex)
            {
                case 5:
                    count = int.Parse(lblTotalXe1.Text) + add;
                    lblTotalXe1.Text = count.ToString();
                    break;
                case 6:
                    count = int.Parse(lblTotalXe2.Text) + add;
                    lblTotalXe2.Text = count.ToString();
                    break;
                case 7:
                    count = int.Parse(lblTotalXe3.Text) + add;
                    lblTotalXe3.Text = count.ToString();
                    break;
                case 8:
                    count = int.Parse(lblTotalXe4.Text) + add;
                    lblTotalXe4.Text = count.ToString();
                    break;
                case 9:
                    count = int.Parse(lblTotalXe5.Text) + add;
                    lblTotalXe5.Text = count.ToString();
                    break;
                case 10:
                    count = int.Parse(lblTotalXe6.Text) + add;
                    lblTotalXe6.Text = count.ToString();
                    break;
                case 11:
                    count = int.Parse(lblTotalXe7.Text) + add;
                    lblTotalXe7.Text = count.ToString();
                    break;
                case 12:
                    count = int.Parse(lblTotalXe8.Text) + add;
                    lblTotalXe8.Text = count.ToString();
                    break;
                case 13:
                    count = int.Parse(lblTotalXe9.Text) + add;
                    lblTotalXe9.Text = count.ToString();
                    break;
                case 14:
                    count = int.Parse(lblTotalXe10.Text) + add;
                    lblTotalXe10.Text = count.ToString();
                    break;
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadDataGroup();
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

        private void btnCar1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
