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
    public partial class UCRoleViewReport : XtraUserControl
    {
        private PartnerService partnerService;
        private ApplicationUserService userService = new ApplicationUserService();
        private int _currentUserID = 0;
        public UCRoleViewReport()
        {
            InitializeComponent();
        }

        private void loadDataGroup()
        {
            partnerService = new PartnerService();
            var data = partnerService.GetList();
            gridControlData.DataSource = data;
            gridControlData.Update();
            gridControlData.Refresh();

            userService = new ApplicationUserService();
            gridControlAccount.DataSource = userService.GetList();
            gridControlAccount.Update();
            gridControlAccount.Refresh();
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

        private void gridViewAccount_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var id = int.Parse(gridViewAccount.GetFocusedRowCellValue("ID").ToString());
            var username = gridViewAccount.GetFocusedRowCellValue(gridColumnUsername).ToString();
            _currentUserID = id;
            lblText.Text = username;

            var data = userService.GetPartnerViewReport(username);
            SetRowsChecked(data);
        }

        private string GetRowsChecked()
        {
            string rs = "";
            for (int i = 0; i < gridViewData.SelectedRowsCount; i++)
            {
                var a = gridViewData.GetSelectedRows()[i];

                if (gridViewData.GetSelectedRows()[i] > -1)
                {
                    rs += int.Parse(gridViewData.GetRowCellValue(a, "PartnerID").ToString()) + ",";
                }
            }
            return rs;
        }
        private void SetRowsChecked(string data)
        {
            var datas = data.Split(',');
            List<int> lsPartner = new List<int>();
            foreach (var item in datas)
            {
                if (item != "")
                    lsPartner.Add(int.Parse(item));
            }
            for (int i = 0; i < gridViewData.RowCount; i++)
            {
                var id = int.Parse(gridViewData.GetRowCellValue(i, "PartnerID").ToString());
                if (lsPartner.Contains(id))
                {
                    gridViewData.SelectRow(i);
                }
                else
                    gridViewData.UnselectRow(i);
            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_currentUserID == 0)
            {
                XtraMessageBox.Show("Bạn chưa chọn tài khoản để thiết lập.");
                return;
            }
            if (DialogResult.Yes == XtraMessageBox.Show("Cập nhật phân quyền xem báo cáo cho tài khoản \"" + lblText.Text + "\"", "Thông báo", MessageBoxButtons.YesNo))
            {
                string data = GetRowsChecked();
                var rs = userService.UpdateRoleViewReport(_currentUserID, data);
                if (rs)
                    XtraMessageBox.Show("Cập nhật thành công.");
                else
                    XtraMessageBox.Show("Xảy ra lỗi. Cập nhật thất bại.");
            }
        }

       
    }
}
