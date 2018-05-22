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
using DevExpress.XtraPrinting;
using System.IO;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

namespace KimTravel.GUI.UControls
{
    public partial class UCListBook : XtraUserControl
    {
        private GroupTourService grTourService = new GroupTourService();
        private TourService tService = new TourService();
        private BookService objService;
        public UCListBook()
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
            frmDetailsTour frm = new frmDetailsTour();
            frm.loadData = new frmDetailsTour.LoadData(loadDataGroup);
            frm.ShowDialog();
        }

        private void UCGroupTour_Load(object sender, EventArgs e)
        {
            objService = new BookService();
        }

        private void cbbGroupTourID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                btnTimKiem.PerformClick();
            }
            catch { }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            btnTimKiem.PerformClick();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var dateStart = dtpStartDate.Value.ToString("yyyy-MM-dd");
            bool isCancel = rdBinhThuong.Checked == true ? false : true;
            gridControlData.DataSource = objService.GetListBooked(dateStart, isCancel);
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

        private void btnClickViews_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var id = int.Parse(gridViewData.GetFocusedRowCellValue("ID").ToString());
            int work = rdBinhThuong.Checked == true ? 1 : 2;
            frmDetailsTour frm = new frmDetailsTour(work, id);
            frm.loadData = new frmDetailsTour.LoadData(loadDataGroup);
            frm.ShowDialog();
        }

        private void gridViewData_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                GridView View = sender as GridView;
                if (e.RowHandle >= 0)
                {
                    var v = View.GetRowCellValue(e.RowHandle, "IsDone");
                    bool isDone = (bool)v;
                    if (isDone)
                    {
                        e.Appearance.BackColor = Color.LightBlue;
                    }
                }
            }
            catch { }
        }
        private void confirmSaleBook(string value)
        {
            int BookID = int.Parse(gridViewData.GetFocusedRowCellValue("ID").ToString());
            var rs = objService.UpdateDone(BookID, true, value);
            if (rs)
                XtraMessageBox.Show("Xác nhận hoàn tất thành công.\nHãy làm mới lại dữ liệu để hiển thị.", "Thông báo");
        }
        private void đaNhânBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == XtraMessageBox.Show("Bạn muốn hoàn tất tour này ?", "Thông báo", MessageBoxButtons.OKCancel))
            {
                frmConfirmSaleBook frm = new frmConfirmSaleBook();
                frm.confirm = new frmConfirmSaleBook.ConfirmSaleBook(confirmSaleBook);
                frm.ShowDialog();
            }
        }

        private void gridViewData_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            GridView gw = sender as GridView;
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
    }
}
