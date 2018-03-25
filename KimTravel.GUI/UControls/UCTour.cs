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

namespace KimTravel.GUI.UControls
{
    public partial class UCTour : XtraUserControl
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
            gridControlData.DataSource = data;
            gridControlData.Update();
            gridControlData.Refresh();
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

            loadDataGroup();
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadDataGroup();
        }

        private void cbbGroupTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var x = cbbGroupTour.SelectedValue.ToString();
                int gID = int.Parse(x);
                gridControlData.DataSource = objService.GetList(gID);
            }
            catch { }
        }

        private void btnClickDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (DialogResult.OK == XtraMessageBox.Show("Xác nhận xóa dữ liệu ?", "Thông báo", MessageBoxButtons.OKCancel))
            {
                var id = int.Parse(gridViewData.GetFocusedRowCellValue("TourID").ToString());
                objService.Delete(id);
                loadDataGroup();
            }
        }

        private void btnClickEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var id = int.Parse(gridViewData.GetFocusedRowCellValue("TourID").ToString());
            frmActionTour frm = new frmActionTour(1, id);
            frm.loadData = new frmActionTour.LoadData(loadDataGroup);
            frm.ShowDialog();
        }
    }
}
