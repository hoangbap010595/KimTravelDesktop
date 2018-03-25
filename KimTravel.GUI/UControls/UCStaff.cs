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
using KimTravel.DAL;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using System.IO;

namespace KimTravel.GUI.UControls
{
    public partial class UCStaff : XtraUserControl
    {
        private StaffService objService;
        public UCStaff()
        {
            InitializeComponent();
        }

        private void loadDataGroup()
        {
            objService = new StaffService();
            var data = objService.GetList();
            gridControlData.DataSource = data;
            gridControlData.Update();
            gridControlData.Refresh();
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmActionStaff frm = new frmActionStaff();
            frm.loadData = new frmActionStaff.LoadData(loadDataGroup);
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
                        if (DialogResult.OK == MessageBox.Show("Mở file \"" + Path.GetFileName(path) + "\" ?", "", MessageBoxButtons.OKCancel))
                        {
                            System.Diagnostics.Process.Start(path);
                        }
                    }
                }
                else { MessageBox.Show("Không tìm thấy dữ liệu!"); }
            }
            catch { }
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
            frmActionStaff frm = new frmActionStaff(1, id);
            frm.loadData = new frmActionStaff.LoadData(loadDataGroup);
            frm.ShowDialog();
        }
    }
}
