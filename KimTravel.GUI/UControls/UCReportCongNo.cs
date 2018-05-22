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
using KimTravel.DAL.Models;
using KimTravel.DAL;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using System.IO;
using DevExpress.XtraEditors;

namespace KimTravel.GUI.UControls
{
    public partial class UCReportCongNo : XtraUserControl
    {
        private PartnerService partnerService = new PartnerService();
        private GroupTourService grTourService = new GroupTourService();
        private TourService tService = new TourService();
        private BookService objService;
        private int _Month = 0;
        private int _Year = 0;
        private int _PartnerID = 0;
        private int _IsPayment = -1;
        public UCReportCongNo()
        {
            InitializeComponent();
        }
        public UCReportCongNo(int partnerID, int month, int year, int typePayment)
        {
            InitializeComponent();
            this._PartnerID = partnerID;
            this._Month = month;
            this._Year = year;
            this._IsPayment = typePayment;
        }
        private void loadDataGroup()
        {
            objService = new BookService();
            if (_IsPayment == 1)
                gridControlData.DataSource = objService.GetListBookedDone(_PartnerID, _Month, _Year, true, true);
            else if (_IsPayment == 2)
            {
                btnPaymentAll.Visible = true;
                gridControlData.DataSource = objService.GetListBookedDone(_PartnerID, _Month, _Year, false, true);
            }
            else
                gridControlData.DataSource = objService.GetListBookedDone(_PartnerID, _Month, _Year, null, true);
        }
        private DataTable listMonth()
        {
            DataTable data = new DataTable();
            data.Columns.Add("ID", typeof(int));
            data.Columns.Add("Month");
            for (int i = 1; i <= 12; i++)
            {
                DataRow dr = data.NewRow();
                dr["ID"] = i;
                dr["Month"] = "Tháng " + i;
                data.Rows.Add(dr);
            }
            return data;
        }
        private DataTable listYear()
        {
            DataTable data = new DataTable();
            data.Columns.Add("ID", typeof(int));
            data.Columns.Add("Year");
            for (int i = 2017; i <= 2050; i++)
            {
                DataRow dr = data.NewRow();
                dr["ID"] = i;
                dr["Year"] = "" + i;
                data.Rows.Add(dr);
            }
            return data;
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmDetailsTour frm = new frmDetailsTour();
            frm.loadData = new frmDetailsTour.LoadData(loadDataGroup);
            frm.ShowDialog();
        }

        private void UCGroupTour_Load(object sender, EventArgs e)
        {
            btnPaymentAll.Visible = false;
            Partner p = partnerService.GetByID(_PartnerID);
            lblTenDoiTac.Text = p.Name;
            loadDataGroup();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            btnPaymentAll.PerformClick();
        }
        private void btnPaymentAll_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == XtraMessageBox.Show("Bạn muốn cập nhật trạng thái thanh toán toàn bộ đối tác ?", "Thông báo", MessageBoxButtons.OKCancel))
            {
                int count = 0;
                for (int i = 0; i < gridViewData.RowCount; i++)
                {
                    var id = int.Parse(gridViewData.GetRowCellValue(i, "ID").ToString());
                    var x = objService.UpdateBookPayment(id, true);
                    if (x)
                        count++;
                }
                if (count > 0)
                    XtraMessageBox.Show("Cập nhật thanh toán thành công " + count + " đối tác!", "Thông báo");
                else
                    XtraMessageBox.Show("Không tìm thấy đối tác cần cập nhật!", "Thông báo");
                loadDataGroup();
            }
        }
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridViewData.RowCount > 0)
                {
                    string path = "";
                    SaveFileDialog saved = new SaveFileDialog();
                    saved.Filter = "Excel (*.xlsx)|*.xlsx|Excel (*.xls)|*.xls";
                    if (DialogResult.OK == saved.ShowDialog())
                    {
                        path = saved.FileName.ToString();
                        ExportTarget excel = ExportTarget.Xlsx;
                        gridViewData.BestFitColumns(true);
                        gridViewData.OptionsPrint.AutoWidth = false;
                        gridViewData.OptionsPrint.ExpandAllDetails = true;
                        gridViewData.OptionsPrint.PrintVertLines = false;
                        gridViewData.OptionsPrint.PrintHorzLines = false;
                        gridViewData.Export(excel, path);
                        if (DialogResult.OK == XtraMessageBox.Show("Mở file \"" + Path.GetFileName(path) + "\" ?", "", MessageBoxButtons.OKCancel))
                        {
                            System.Diagnostics.Process.Start(path);
                        }
                    }
                }
                else { XtraMessageBox.Show("Không tìm thấy dữ liệu!"); }
            }
            catch { }
        }

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            xtraRPBaoCaoCongNo rp = new xtraRPBaoCaoCongNo(_PartnerID, _Month, _Year, _IsPayment);
            rp.ShowPreview();
        }

        private void btnClickViews2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var id = int.Parse(gridViewData.GetFocusedRowCellValue("ID").ToString());
            var work = bool.Parse(gridViewData.GetFocusedRowCellValue("IsCancel").ToString()) == true ? 2 : 1;
            frmDetailsTour frm = new frmDetailsTour(work, id);
            frm.loadData = new frmDetailsTour.LoadData(loadDataGroup);
            frm.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["frmPaymentDetail"];
            if (frm != null)
                frm.Close();
        }
    }
}
