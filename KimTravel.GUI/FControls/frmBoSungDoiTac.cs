using DevExpress.XtraEditors;
using KimTravel.DAL;
using KimTravel.DAL.Models;
using KimTravel.DAL.Services;
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
    public partial class frmBoSungDoiTac : XtraForm
    {
        private GroupTourService grTourService = new GroupTourService();
        private TourService tService = new TourService();
        private BookService bookService;
        private string _dateStart = "";

        public delegate void ConfirmAddPartner(DataTable data);
        public ConfirmAddPartner confirm;
        public frmBoSungDoiTac(string dateStart)
        {
            InitializeComponent();
            _dateStart = dateStart;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DataTable data = GetRowsChecked();
            if (DialogResult.OK == XtraMessageBox.Show("Xác nhận bổ sung thêm " + data.Rows.Count + " đối tác", "Thông báo", MessageBoxButtons.OKCancel))
            {
                if (confirm != null)
                    confirm(data);
                this.Close();
            }

        }
        private DataTable GetRowsChecked()
        {
            var tID = cbbTourID.SelectedValue.ToString();
            Tour t = tService.GetByID(int.Parse(tID));
            DataTable data = new DataTable();
            data.Columns.Add("ID", typeof(int));
            data.Columns.Add("Pax", typeof(float));
            data.Columns.Add("PaxChild", typeof(float));
            data.Columns.Add("PickUp");
            data.Columns.Add("Room");
            data.Columns.Add("ServiceName");
            data.Columns.Add("PartnerPrice", typeof(int));
            data.Columns.Add("Note");
            for (int i = 0; i < gridViewData.SelectedRowsCount; i++)
            {
                var a = gridViewData.GetSelectedRows()[i];
                if (gridViewData.GetSelectedRows()[i] > -1)
                {
                    DataRow dr = data.NewRow();
                    dr["ID"] = int.Parse(gridViewData.GetRowCellValue(a, "ID").ToString());
                    dr["Pax"] = float.Parse(gridViewData.GetRowCellValue(a, "Pax").ToString());
                    dr["PaxChild"] = float.Parse(gridViewData.GetRowCellValue(a, "PaxChild").ToString());
                    dr["PickUp"] = gridViewData.GetRowCellValue(a, "PickUp").ToString() + " (" + t.Name + ")";
                    dr["Room"] = gridViewData.GetRowCellValue(a, "Room").ToString();
                    dr["ServiceName"] = gridViewData.GetRowCellValue(a, "ServiceName").ToString();
                    dr["PartnerPrice"] = int.Parse(gridViewData.GetRowCellValue(a, "PartnerPrice").ToString());
                    dr["Note"] = gridViewData.GetRowCellValue(a, "Note").ToString();
                    data.Rows.Add(dr);
                }
            }
            return data;
        }

        private void cbbGroupTourID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var x = cbbGroupTourID.SelectedValue.ToString();
                int gID = int.Parse(x);
                cbbTourID.DataSource = tService.GetListForGroup(gID);
                cbbTourID.ValueMember = "TourID";
                cbbTourID.DisplayMember = "Name";

                btnTimKiem.PerformClick();
            }
            catch { }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var tID = int.Parse(cbbTourID.SelectedValue.ToString());
            gridControlData.DataSource = bookService.GetListBooked(tID, _dateStart, false);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBoSungDoiTac_Load(object sender, EventArgs e)
        {
            bookService = new BookService();
            cbbGroupTourID.DataSource = grTourService.GetListCombobox();
            cbbGroupTourID.ValueMember = "GroupID";
            cbbGroupTourID.DisplayMember = "Name";
        }
    }
}
