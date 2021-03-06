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
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using System.IO;
using DevExpress.XtraEditors;

namespace KimTravel.GUI.UControls
{
    public partial class UCReportCongNoDoiTac : XtraUserControl
    {
        private PartnerService partnerService = new PartnerService();
        private GroupTourService grTourService = new GroupTourService();
        private TourService tService = new TourService();
        private BookService objService;
        public UCReportCongNoDoiTac()
        {
            InitializeComponent();
        }

        private void loadDataGroup()
        {
            objService = new BookService();
            btnTimKiem.PerformClick();
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
            objService = new BookService();

            cbbMonth.DataSource = listMonth();
            cbbMonth.ValueMember = "ID";
            cbbMonth.DisplayMember = "Month";

            cbbYear.DataSource = listYear();
            cbbYear.ValueMember = "ID";
            cbbYear.DisplayMember = "Year";

            cbbMonth.SelectedValue = DateTime.Now.Month;
            cbbYear.SelectedValue = DateTime.Now.Year;
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            btnTimKiem.PerformClick();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var month = int.Parse(cbbMonth.SelectedValue.ToString());
            var year = int.Parse(cbbYear.SelectedValue.ToString());
            gridControlData.DataSource = objService.GetListBookedDoneReportPartner(month, year, true);
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

        private void btnClickIn_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var id = int.Parse(gridViewData.GetFocusedRowCellValue("ID").ToString());
            var month = int.Parse(cbbMonth.SelectedValue.ToString());
            var year = int.Parse(cbbYear.SelectedValue.ToString());
            xtraRPBaoCaoCongNoDoiTac rp = new xtraRPBaoCaoCongNoDoiTac(id, month, year);
            rp.ShowPreview();
        }

        private void ShowPayment(int typePayment)
        {
            var id = int.Parse(gridViewData.GetFocusedRowCellValue("ID").ToString());
            var month = int.Parse(cbbMonth.SelectedValue.ToString());
            var year = int.Parse(cbbYear.SelectedValue.ToString());
            frmPaymentDetail frm = new frmPaymentDetail(id, month, year, typePayment);
            frm.ShowDialog();
        }
        private void btnViewDetails_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmConfirmPayment frm = new frmConfirmPayment();
            frm.sendPayment = new frmConfirmPayment.SendPayment(ShowPayment);
            frm.ShowDialog();
        }
    }
}
