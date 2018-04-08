using DevExpress.XtraEditors;
using KimTravel.DAL;
using KimTravel.DAL.Models;
using KimTravel.DAL.Services;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KimTravel.GUI.FControls
{
    public partial class frmFindServiceType : XtraForm
    {
        private ServiceTypeService serviceType = new ServiceTypeService();

        public delegate void LoadData(string name, int price, int add);
        public LoadData sendData;

        private int _PartnerID = -1;
        private int _TourID = 0;
        public frmFindServiceType(int tourID)
        {
            InitializeComponent();
            _TourID = tourID;
        }

        private void frmActionGroupTour_Load(object sender, EventArgs e)
        {
            txtPartner.Focus();
            gridDataControl.DataSource = serviceType.GetList(_TourID);

        }
        private void loadData()
        {
            serviceType = new ServiceTypeService();
            gridDataControl.DataSource = serviceType.GetList(_TourID);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (sendData != null)
                for (int i = 0; i < gridViewData.SelectedRowsCount; i++)
                {
                    var a = gridViewData.GetSelectedRows()[i];

                    if (gridViewData.GetSelectedRows()[i] > -1)
                    {
                        string service = gridViewData.GetRowCellValue(a, "Name").ToString();
                        int price = int.Parse(gridViewData.GetRowCellValue(a, "Price").ToString());
                        sendData(service, price, 1);
                    }
                }
            this.Close();
        }

        private void txtPartner_KeyPress(object sender, KeyPressEventArgs e)
        {
            var content = txtPartner.Text;
            gridDataControl.DataSource = serviceType.GetListFind(content, _TourID);
            gridDataControl.Update();
            gridDataControl.Refresh();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == XtraMessageBox.Show("Bạn muốn xóa dịch vụ ra khỏi hệ thống ?", "Xác nhận", MessageBoxButtons.OKCancel))
            {
                bool rs = serviceType.Delete(_PartnerID);
                if (rs)
                {
                    serviceType = new ServiceTypeService();
                    gridDataControl.DataSource = serviceType.GetList(_TourID);
                }
                else
                {
                    XtraMessageBox.Show("Không tìm thấy thông tin");
                }
            }
        }

        private void TextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmActionService frm = new frmActionService();
            frm.loadData = new frmActionService.LoadData(loadData);
            frm.ShowDialog();
        }

        private void btnEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = int.Parse(gridViewData.GetFocusedRowCellValue("ID").ToString());
            frmActionService frm = new frmActionService(1, id);
            frm.loadData = new frmActionService.LoadData(loadData);
            frm.ShowDialog();
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = int.Parse(gridViewData.GetFocusedRowCellValue("ID").ToString());
            if (DialogResult.OK == XtraMessageBox.Show("Bạn muốn xóa dịch vụ ?", "Thông báo", MessageBoxButtons.OKCancel))
            {
                serviceType.Delete(id);
                loadData();
            }
        }
    }
}
