﻿using System;
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

namespace KimTravel.GUI.UControls
{
    public partial class UCPrintTour : XtraUserControl
    {
        private PrintTourService printTourService = new PrintTourService();
        private GroupTourService grTourService = new GroupTourService();
        private TourService tService = new TourService();
        public UCPrintTour()
        {
            InitializeComponent();
        }

        private void loadDataGroup()
        {
            printTourService = new PrintTourService();
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
            printTourService = new PrintTourService();
            cbbGroupTourID.DataSource = grTourService.GetListCombobox();
            cbbGroupTourID.ValueMember = "GroupID";
            cbbGroupTourID.DisplayMember = "Name";

            dtpStartDate.Value = DateTime.Now.AddDays(1);
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
        private void btnLoad_Click(object sender, EventArgs e)
        {
            btnTimKiem.PerformClick();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var tID = int.Parse(cbbTourID.SelectedValue.ToString());
            var dateStart = dtpStartDate.Value.ToString("yyyy-MM-dd");
            if (ckViewAllPartner.Checked)
                gridControlData.DataSource = printTourService.GetList(dateStart);
            else
                gridControlData.DataSource = printTourService.GetList(tID, dateStart);
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
            var PrintID = int.Parse(gridViewData.GetFocusedRowCellValue("ID").ToString());
            var TourID = int.Parse(gridViewData.GetFocusedRowCellValue("TourID").ToString());
            var StartDate = DateTime.Parse(gridViewData.GetFocusedRowCellValue("DateStart").ToString()).ToString("dd-MM-yyyy");
            var Carcode = gridViewData.GetFocusedRowCellValue("CarCode").ToString();
            var Guide1 = int.Parse(gridViewData.GetFocusedRowCellValue("Guide1").ToString());
            var Guide2 = gridViewData.GetFocusedRowCellValue("Guide2").ToString();
            var Driver1 = int.Parse(gridViewData.GetFocusedRowCellValue("Driver1").ToString());
            var Driver2 = gridViewData.GetFocusedRowCellValue("Driver2").ToString();
            //float Pax = float.Parse(gridViewData.GetFocusedRowCellValue("TotalPax").ToString());

            frmDetailsPrintAgain frm = new frmDetailsPrintAgain(PrintID, TourID, StartDate, Guide1, Guide2, Driver1, Driver2, Carcode);
            frm.ShowDialog();
        }
    }
}
