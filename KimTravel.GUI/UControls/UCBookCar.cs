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
using DevExpress.XtraEditors;
using KimTravel.DAL.Models;
using System.Reflection;

namespace KimTravel.GUI.UControls
{
    public partial class UCBookCar : XtraUserControl
    {
        private GroupTourService grTourService = new GroupTourService();
        private TourService tService = new TourService();
        private BookService objService;
        private List<Control> listControl;
        private List<DataTable> listTablePick;
        private DataTable _tableTemp = new DataTable();
        private int _TourID = 0;
        private float _Selected = 0;
        private int _indexTourSelected = 0;
        public UCBookCar()
        {
            InitializeComponent();
        }

        private void loadDataGroup()
        {
            objService = new BookService();
            btnTimKiem.PerformClick();
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmActionStaff frm = new frmActionStaff();
            frm.loadData = new frmActionStaff.LoadData(loadDataGroup);
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
            rdCar05.Checked = true;

            _tableTemp.Columns.Add("ID", typeof(int));
            _tableTemp.Columns.Add("Pax", typeof(float));
            _tableTemp.Columns.Add("PickUp");
            _tableTemp.Columns.Add("Room");
            _tableTemp.Columns.Add("PartnerPrice", typeof(int));
            _tableTemp.Columns.Add("Note");
            _tableTemp.Columns.Add("colCar1", typeof(bool));
            _tableTemp.Columns.Add("colCar2", typeof(bool));
            _tableTemp.Columns.Add("colCar3", typeof(bool));
            _tableTemp.Columns.Add("colCar4", typeof(bool));
            _tableTemp.Columns.Add("colCar5", typeof(bool));
            _tableTemp.Columns.Add("colCar6", typeof(bool));
            _tableTemp.Columns.Add("colCar7", typeof(bool));
            _tableTemp.Columns.Add("colCar8", typeof(bool));
            _tableTemp.Columns.Add("colCar9", typeof(bool));
            _tableTemp.Columns.Add("colCar10", typeof(bool));
            listControl = new List<Control> { lblTotalXe1, lblTotalXe2, lblTotalXe3, lblTotalXe4, lblTotalXe5, lblTotalXe6, lblTotalXe7, lblTotalXe8, lblTotalXe9, lblTotalXe10 };
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
                    for (int i = 7; i < senderGrid.Columns.Count; i++)
                    {
                        if (i != e.ColumnIndex)
                            senderGrid[i, e.RowIndex].ReadOnly = true;
                    }
                    float pax = float.Parse(senderGrid.Rows[e.RowIndex].Cells["colPax"].Value.ToString());
                    getTotalInCar(senderGrid.Columns[e.ColumnIndex].Name, pax);
                    _Selected -= pax;
                    listTablePick[_indexTourSelected].Rows[e.RowIndex][e.ColumnIndex] = true;
                }
                else
                {
                    senderGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    for (int i = 7; i < senderGrid.Columns.Count; i++)
                    {
                        senderGrid[i, e.RowIndex].ReadOnly = false;
                    }
                    float pax = float.Parse(senderGrid.Rows[e.RowIndex].Cells["colPax"].Value.ToString());
                    getTotalInCar(senderGrid.Columns[e.ColumnIndex].Name, -pax);
                    _Selected += pax;
                    listTablePick[_indexTourSelected].Rows[e.RowIndex][e.ColumnIndex] = false;
                }
                lblSelected.Text = _Selected.ToString();
            }
        }
        private void getTotalInCar(string colName, float add)
        {
            float count = 0;
            switch (colName)
            {
                case "colCar1":
                    count = float.Parse(lblTotalXe1.Text) + add;
                    lblTotalXe1.Text = count.ToString();
                    break;
                case "colCar2":
                    count = float.Parse(lblTotalXe2.Text) + add;
                    lblTotalXe2.Text = count.ToString();
                    break;
                case "colCar3":
                    count = float.Parse(lblTotalXe3.Text) + add;
                    lblTotalXe3.Text = count.ToString();
                    break;
                case "colCar4":
                    count = float.Parse(lblTotalXe4.Text) + add;
                    lblTotalXe4.Text = count.ToString();
                    break;
                case "colCar5":
                    count = float.Parse(lblTotalXe5.Text) + add;
                    lblTotalXe5.Text = count.ToString();
                    break;
                case "colCar6":
                    count = float.Parse(lblTotalXe6.Text) + add;
                    lblTotalXe6.Text = count.ToString();
                    break;
                case "colCar7":
                    count = float.Parse(lblTotalXe7.Text) + add;
                    lblTotalXe7.Text = count.ToString();
                    break;
                case "colCar8":
                    count = float.Parse(lblTotalXe8.Text) + add;
                    lblTotalXe8.Text = count.ToString();
                    break;
                case "colCar9":
                    count = float.Parse(lblTotalXe9.Text) + add;
                    lblTotalXe9.Text = count.ToString();
                    break;
                case "colCar10":
                    count = float.Parse(lblTotalXe10.Text) + add;
                    lblTotalXe10.Text = count.ToString();
                    break;
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadDataGroup();
        }

        private void cbbGroupTourID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                btnTimKiem.PerformClick();
            }
            catch { }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            listTablePick = new List<DataTable>();
            var x = cbbGroupTourID.SelectedValue.ToString();
            int gID = int.Parse(x);
            var dateStart = dtpStartDate.Value.ToString("yyyy-MM-dd");
            gridControlData.DataSource = objService.GetListBookedNotInCar(gID, dateStart);
            for (int i = 0; i < gridViewData.RowCount; i++)
            {
                listTablePick.Add(new DataTable());
            }
            for (int i = 0; i < gridViewData.RowCount; i++)
            {
                int tID = int.Parse(gridViewData.GetRowCellValue(i, "TourID").ToString());
                if (i == 0)
                    _TourID = tID;
                var listData = objService.GetListBooked(tID, dateStart, false);
                DataTable table = _tableTemp.Clone();
                foreach (var item in listData)
                {
                    DataRow dr = table.NewRow();
                    Type myType = item.GetType();
                    IList<PropertyInfo> props = new List<PropertyInfo>(myType.GetProperties());
                    foreach (PropertyInfo prop in props)
                    {
                        var key = prop.Name;
                        object propValue = prop.GetValue(item, null);
                        switch (key)
                        {
                            case "ID":
                                dr["ID"] = int.Parse(propValue.ToString());
                                break;
                            case "Pax":
                                dr["Pax"] = float.Parse(propValue.ToString());
                                break;
                            case "PickUp":
                                dr["PickUp"] = propValue.ToString();
                                break;
                            case "Room":
                                dr["Room"] = propValue.ToString();
                                break;
                            case "PartnerPrice":
                                dr["PartnerPrice"] = int.Parse(propValue.ToString());
                                break;
                            case "Note":
                                dr["Note"] = propValue.ToString();
                                break;
                            default:
                                break;
                        }
                    }
                    dr["colCar1"] = false;
                    dr["colCar2"] = false;
                    dr["colCar3"] = false;
                    dr["colCar4"] = false;
                    dr["colCar5"] = false;
                    dr["colCar6"] = false;
                    dr["colCar7"] = false;
                    dr["colCar8"] = false;
                    dr["colCar9"] = false;
                    dr["colCar10"] = false;
                    table.Rows.Add(dr);
                }
                listTablePick[i] = table;
            }
            if (listTablePick.Count > 0)
            {
                dataGridViewGroupTour.DataSource = listTablePick[_indexTourSelected];
                dataGridViewGroupTour_DataBindingComplete();
                //_Selected = listTablePick[_indexTourSelected].Rows.Count;
                //lblSelected.Text = listTablePick[_indexTourSelected].Rows.Count.ToString();
            }
        }

        private void rdCar05_CheckedChanged(object sender, EventArgs e)
        {
            var check = rdCar05.Checked;
            if (check)
            {
                colCar6.Visible = colCar7.Visible = colCar8.Visible = colCar9.Visible = colCar10.Visible = false;
                btnCar6.Visible = btnCar7.Visible = btnCar8.Visible = btnCar9.Visible = btnCar10.Visible = false;
                lblTotalXe6.Visible = lblTotalXe7.Visible = lblTotalXe8.Visible = lblTotalXe9.Visible = lblTotalXe10.Visible = false;
            }
            else
            {
                colCar6.Visible = colCar7.Visible = colCar8.Visible = colCar9.Visible = colCar10.Visible = true;
                btnCar6.Visible = btnCar7.Visible = btnCar8.Visible = btnCar9.Visible = btnCar10.Visible = true;
                lblTotalXe6.Visible = lblTotalXe7.Visible = lblTotalXe8.Visible = lblTotalXe9.Visible = lblTotalXe10.Visible = true;
            }
        }

        private void getDataRowChecked(string colName, int numCar)
        {
            DataTable data = new DataTable();
            data.Columns.Add("ID", typeof(int));
            data.Columns.Add("PickUp");
            data.Columns.Add("Room");
            data.Columns.Add("Pax", typeof(float));
            data.Columns.Add("PartnerPrice", typeof(int));
            data.Columns.Add("Note");
            foreach (DataGridViewRow row in dataGridViewGroupTour.Rows)
            {
                if (row.Cells[colName].Value != null && (bool)row.Cells[colName].Value)
                {
                    DataRow dr = data.NewRow();
                    dr["ID"] = int.Parse(row.Cells["colID"].Value.ToString());
                    dr["PickUp"] = row.Cells["colPickUp"].Value.ToString();
                    dr["Room"] = row.Cells["colRoom"].Value.ToString();
                    dr["Pax"] = float.Parse(row.Cells["colPax"].Value.ToString());
                    dr["PartnerPrice"] = int.Parse(row.Cells["colPartnerPrice"].Value.ToString());
                    dr["Note"] = row.Cells["colNote"].Value.ToString();

                    data.Rows.Add(dr);
                }
            }
            if (data.Rows.Count > 0)
            {
                string startDate = dtpStartDate.Value.ToString("yyyy-MM-dd");
                frmDetailsBookCar frm = new frmDetailsBookCar(data, numCar, _TourID, startDate);
                frm.refreshData = new frmDetailsBookCar.RefreshData(refreshData);
                frm.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Không tìm thấy thông tin xe được book.");
            }
        }
        private void refreshData(int numCar)
        {
            var colName = "colCar" + numCar;

            for (int i = 0; i < dataGridViewGroupTour.RowCount; i++)
            {
                if (dataGridViewGroupTour.Rows[i].Cells[colName].Value != null && (bool)dataGridViewGroupTour.Rows[i].Cells[colName].Value)
                {
                    dataGridViewGroupTour.Rows.RemoveAt(i);
                    i--;
                }
            }
            dataGridViewGroupTour.Update();
            dataGridViewGroupTour.Refresh();
            listControl[numCar - 1].Text = "0";
        }
        #region ====Car
        private void btnCar1_Click(object sender, EventArgs e)
        {
            getDataRowChecked("colCar1", 1);
        }

        private void btnCar2_Click(object sender, EventArgs e)
        {
            getDataRowChecked("colCar2", 2);
        }
        private void btnCar3_Click(object sender, EventArgs e)
        {
            getDataRowChecked("colCar3", 3);
        }

        private void btnCar4_Click(object sender, EventArgs e)
        {
            getDataRowChecked("colCar4", 4);
        }

        private void btnCar5_Click(object sender, EventArgs e)
        {
            getDataRowChecked("colCar5", 5);
        }

        private void btnCar6_Click(object sender, EventArgs e)
        {
            getDataRowChecked("colCar6", 6);
        }

        private void btnCar7_Click(object sender, EventArgs e)
        {
            getDataRowChecked("colCar7", 7);
        }

        private void btnCar8_Click(object sender, EventArgs e)
        {
            getDataRowChecked("colCar8", 8);
        }

        private void btnCar9_Click(object sender, EventArgs e)
        {
            getDataRowChecked("colCar9", 9);
        }

        private void btnCar10_Click(object sender, EventArgs e)
        {
            getDataRowChecked("colCar10", 10);
        }
        #endregion
        private void gridViewData_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            _TourID = int.Parse(gridViewData.GetFocusedRowCellValue("TourID").ToString());
            _indexTourSelected = e.RowHandle;
            dataGridViewGroupTour.DataSource = listTablePick[_indexTourSelected];
            dataGridViewGroupTour_DataBindingComplete();
        }

        private void boSungDoiTac(DataTable data)
        {
            DataTable dt = listTablePick[_indexTourSelected];
            foreach (DataRow item in data.Rows)
            {
                DataRow dr = dt.NewRow();
                dr["ID"] = int.Parse(item["ID"].ToString());
                dr["Pax"] = float.Parse(item["Pax"].ToString());
                dr["PickUp"] = item["PickUp"].ToString();
                dr["Room"] = item["Room"].ToString();
                dr["PartnerPrice"] = int.Parse(item["PartnerPrice"].ToString());
                dr["Note"] = item["Note"].ToString();
                dr["colCar1"] = false;
                dr["colCar2"] = false;
                dr["colCar3"] = false;
                dr["colCar4"] = false;
                dr["colCar5"] = false;
                dr["colCar6"] = false;
                dr["colCar7"] = false;
                dr["colCar8"] = false;
                dr["colCar9"] = false;
                dr["colCar10"] = false;
                dt.Rows.Add(dr);
            }
            listTablePick[_indexTourSelected] = dt;
            listTablePick[_indexTourSelected].AcceptChanges();
            dataGridViewGroupTour.DataSource = listTablePick[_indexTourSelected];
            dataGridViewGroupTour_DataBindingComplete();
        }
        private void btnBoSungDoiTac_Click(object sender, EventArgs e)
        {
            var dateStart = dtpStartDate.Value.ToString("yyyy-MM-dd");
            frmBoSungDoiTac frm = new frmBoSungDoiTac(dateStart);
            frm.confirm = new frmBoSungDoiTac.ConfirmAddPartner(boSungDoiTac);
            frm.ShowDialog();
        }
        private void setLabelCar()
        {
            foreach (Control item in listControl)
            {
                item.Text = "0";
            }

        }
        private void dataGridViewGroupTour_DataBindingComplete()
        {
            setLabelCar();
            float total = 0;
            foreach (DataGridViewRow row in dataGridViewGroupTour.Rows)
            {
                float pax = float.Parse(row.Cells["colPax"].Value.ToString());
                bool check = false;
                for (int i = 6; i < dataGridViewGroupTour.Columns.Count; i++)
                {

                    bool colCar = bool.Parse(row.Cells[i].Value.ToString());
                    if (colCar)
                    {
                        getTotalInCar(dataGridViewGroupTour.Columns[i].Name, pax);
                        check = true;
                        row.DefaultCellStyle.BackColor = Color.LightGray;
                        row.Cells[i].ReadOnly = false;
                    }
                    else
                    {
                        row.Cells[i].ReadOnly = true;
                    }
                }
                if (!check)
                {
                    for (int i = 6; i < dataGridViewGroupTour.Columns.Count; i++)
                    {
                        row.Cells[i].ReadOnly = false;
                    }

                    total += pax;
                }
            }
            _Selected = total;
            lblSelected.Text = total.ToString();
        }

        private void xoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var index = dataGridViewGroupTour.CurrentRow.Index;
            listTablePick[_indexTourSelected].Rows.RemoveAt(index);
            listTablePick[_indexTourSelected].AcceptChanges();
            dataGridViewGroupTour.DataSource = listTablePick[_indexTourSelected];
            dataGridViewGroupTour_DataBindingComplete();
        }

        private void bôSungThêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnBoSungDoiTac.PerformClick();
        }

        private void lamMơiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == XtraMessageBox.Show("Bạn muốn xóa tất cả các đối tác đã chọn. Sắp xếp lại từ đầu ?", "Xác nhận", MessageBoxButtons.OKCancel))
            {
                DataTable dt = _tableTemp.Clone();
                foreach (DataGridViewRow row in dataGridViewGroupTour.Rows)
                {
                    DataRow dr = dt.NewRow();
                    dr["ID"] = int.Parse(row.Cells["colID"].Value.ToString());
                    dr["Pax"] = float.Parse(row.Cells["colPax"].Value.ToString());
                    dr["PickUp"] = row.Cells["colPickUp"].Value.ToString();
                    dr["Room"] = row.Cells["colRoom"].Value.ToString();
                    dr["PartnerPrice"] = int.Parse(row.Cells["colPartnerPrice"].Value.ToString());
                    dr["Note"] = row.Cells["colNote"].Value.ToString();
                    dr["colCar1"] = false;
                    dr["colCar2"] = false;
                    dr["colCar3"] = false;
                    dr["colCar4"] = false;
                    dr["colCar5"] = false;
                    dr["colCar6"] = false;
                    dr["colCar7"] = false;
                    dr["colCar8"] = false;
                    dr["colCar9"] = false;
                    dr["colCar10"] = false;
                    dt.Rows.Add(dr);
                }
                listTablePick[_indexTourSelected] = dt;
                listTablePick[_indexTourSelected].AcceptChanges();
                dataGridViewGroupTour.DataSource = listTablePick[_indexTourSelected];
                dataGridViewGroupTour_DataBindingComplete();
            }
        }
    }
}
