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
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

namespace KimTravel.GUI.UControls
{
    public partial class UCPartner : XtraUserControl
    {
        private PartnerService objService;
        public UCPartner()
        {
            InitializeComponent();
        }

        private void loadDataGroup()
        {
            objService = new PartnerService();
            var data = objService.GetList();
            gridControlData.DataSource = data;
            gridControlData.Update();
            gridControlData.Refresh();
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmActionPartner frm = new frmActionPartner();
            frm.loadData = new frmActionPartner.LoadData(loadDataGroup);
            frm.ShowDialog();
        }

        private void UCGroupTour_Load(object sender, EventArgs e)
        {
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
                    if (senderGrid.Columns[e.ColumnIndex].Name == "colDelete")
                    {
                        
                    }
                    else
                    {
                        
                    }
                }
            }
            catch { }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadDataGroup();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            frmImportPartner frm = new frmImportPartner();
            frm.ShowDialog();
        }

        private void btnClickDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var id = int.Parse(gridViewData.GetFocusedRowCellValue("PartnerID").ToString());
            if (DialogResult.OK == XtraMessageBox.Show("Xác nhận xóa dữ liệu ?", "Thông báo", MessageBoxButtons.OKCancel))
            {
                objService.Delete(id);
                loadDataGroup();
            }
        }

        private void btnClickEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var id = int.Parse(gridViewData.GetFocusedRowCellValue("PartnerID").ToString());
            frmActionPartner frm = new frmActionPartner(1, id);
            frm.loadData = new frmActionPartner.LoadData(loadDataGroup);
            frm.ShowDialog();
        }
        private void gridViewData_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            GridView gw = sender as GridView;
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
    }
}
