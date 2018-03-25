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
    public partial class UCGroupTour : XtraUserControl
    {
        private GroupTourService gtService;
        public UCGroupTour()
        {
            InitializeComponent();
        }

        private void loadDataGroup()
        {
            gtService = new GroupTourService();
            var data = gtService.GetList();
            gridControlData.DataSource = data;
            gridControlData.Update();
            gridControlData.Refresh();
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmActionGroupTour frm = new frmActionGroupTour();
            frm.loadData = new frmActionGroupTour.LoadData(loadDataGroup);
            frm.ShowDialog();
        }

        private void UCGroupTour_Load(object sender, EventArgs e)
        {
            loadDataGroup();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadDataGroup();
        }

        private void btnClickDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var id = int.Parse(gridViewData.GetFocusedRowCellValue("GroupID").ToString());
            if (DialogResult.OK == XtraMessageBox.Show("Xác nhận xóa dữ liệu ?", "Thông báo", MessageBoxButtons.OKCancel))
            {
                gtService.Delete(id);
                loadDataGroup();
            }
        }

        private void btnClickEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var id = int.Parse(gridViewData.GetFocusedRowCellValue("GroupID").ToString());
            frmActionGroupTour frm = new frmActionGroupTour(1, id);
            frm.loadData = new frmActionGroupTour.LoadData(loadDataGroup);
            frm.ShowDialog();
        }
    }
}
