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
    public partial class UCGroupPartner : XtraUserControl
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
            gridControlPrice.DataSource = data;
            gridControlPrice.Update();
            gridControlPrice.Refresh();

            gpService = new GroupPartnerService();
            gridControlDataPartner.DataSource = gpService.GetList();
            gridControlDataPartner.Update();
            gridControlDataPartner.Refresh();
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmActionGroupPartner frm = new frmActionGroupPartner();
            frm.loadData = new frmActionGroupPartner.LoadData(loadDataGroup);
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

        private void btnThemMoi_Click_1(object sender, EventArgs e)
        {
            frmActionGroupPrice frm = new frmActionGroupPrice();
            frm.loadData = new frmActionGroupPrice.LoadData(loadDataGroup);
            frm.ShowDialog();
        }

        private void btnClickDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (DialogResult.OK == XtraMessageBox.Show("Xác nhận xóa dữ liệu ?", "Thông báo", MessageBoxButtons.OKCancel))
            {
                int id = int.Parse(gridViewDataPartner.GetFocusedRowCellValue("GroupPartnerID").ToString());
                gpService.Delete(id);
                loadDataGroup();
            }
        }

        private void btnClickEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = int.Parse(gridViewDataPartner.GetFocusedRowCellValue("GroupPartnerID").ToString());
            frmActionGroupPartner frm = new frmActionGroupPartner(1, id);
            frm.loadData = new frmActionGroupPartner.LoadData(loadDataGroup);
            frm.ShowDialog();
        }

        private void btnClickDeletePrice_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (DialogResult.OK == XtraMessageBox.Show("Xác nhận xóa dữ liệu ?", "Thông báo", MessageBoxButtons.OKCancel))
            {
                int id = int.Parse(gridViewPrice.GetFocusedRowCellValue("Key").ToString());
                objService.Delete(id);
                loadDataGroup();
            }
        }

        private void btnClickEditPrice_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = int.Parse(gridViewPrice.GetFocusedRowCellValue("Key").ToString());
            frmActionGroupPrice frm = new frmActionGroupPrice(1, id);
            frm.loadData = new frmActionGroupPrice.LoadData(loadDataGroup);
            frm.ShowDialog();
        }

        private void gridViewDataPartner_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var id = int.Parse(gridViewDataPartner.GetFocusedRowCellValue("GroupPartnerID").ToString());
            var data = objService.GetList(id);
            gridControlPrice.DataSource = data;
            gridControlPrice.Update();
            gridControlPrice.Refresh();
        }
    }
}
