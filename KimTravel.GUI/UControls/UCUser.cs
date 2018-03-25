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
    public partial class UCUser : XtraUserControl
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
            gridControlData.DataSource = data;
            gridControlData.Update();
            gridControlData.Refresh();
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmActionUser frm = new frmActionUser();
            frm.loadData = new frmActionUser.LoadData(loadDataGroup);
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

        private void btnClickRole_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = int.Parse(gridViewData.GetFocusedRowCellValue("ID").ToString());
            frmActionRoles frm = new frmActionRoles(id);
            frm.loadData = new frmActionRoles.LoadData(loadDataGroup);
            frm.ShowDialog();
        }

        private void btnClickDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (DialogResult.OK == XtraMessageBox.Show("Xác nhận xóa dữ liệu ?", "Thông báo", MessageBoxButtons.OKCancel))
            {
                int id = int.Parse(gridViewData.GetFocusedRowCellValue("ID").ToString());
                objService.Delete(id);
                loadDataGroup();
            }
        }

        private void btnClickEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = int.Parse(gridViewData.GetFocusedRowCellValue("ID").ToString());
            frmActionUser frm = new frmActionUser(1, id);
            frm.loadData = new frmActionUser.LoadData(loadDataGroup);
            frm.ShowDialog();
        }
    }
}
