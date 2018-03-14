using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KimTravel.DAL
{
    public static class ExcelLibrary
    {
        /// <summary> 
        /// Exports the datagridview values to Excel. 
        /// </summary> 
        public static void ExportToExcel(DataGridView gridviewID)
        {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            try
            {
                //add data 
                int StartCol = 1;
                int StartRow = 1;
                int j = 0, i = 0;
                int colh = 0;
                //Write Headers
                for (j = 0; j < gridviewID.Columns.Count - 1; j++)
                {
                    if (gridviewID.Columns[j].Visible)
                    {
                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[StartRow, StartCol + colh];
                        myRange.Value2 = gridviewID.Columns[j].HeaderText;
                        colh++;
                    }
                }

                StartRow++;

                //Write datagridview content
                for (i = 0; i < gridviewID.Rows.Count; i++)
                {
                    int col = 0;
                    for (j = 0; j < gridviewID.Columns.Count - 1; j++)
                    {
                        try
                        {
                            if (gridviewID.Columns[j].Visible)
                            {
                                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[StartRow + i, StartCol + col];
                                myRange.Value2 = gridviewID[j, i].Value == null ? "" : gridviewID[j, i].Value;
                                col++;
                            }
                        }
                        catch
                        {
                        }
                    }
                }

                //Microsoft.Office.Interop.Excel.Range chartRange;
                //Microsoft.Office.Interop.Excel.ChartObjects xlCharts = (Microsoft.Office.Interop.Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
                //Microsoft.Office.Interop.Excel.ChartObject myChart = (Microsoft.Office.Interop.Excel.ChartObject)xlCharts.Add(10, 80, 300, 250);
                //Microsoft.Office.Interop.Excel.Chart chartPage = myChart.Chart;

                //chartRange = xlWorkSheet.get_Range("A1", "B" + gridviewID.Rows.Count);
                //chartPage.SetSourceData(chartRange, misValue);
                //chartPage.ChartType = Microsoft.Office.Interop.Excel.XlChartType.xlColumnClustered;
                //xlApp.Visible = true;

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 1;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    xlWorkBook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                xlApp.Quit();
                xlWorkBook = null;
                xlApp = null;
            }

        }

        public static DataTable getDataExcelFromFileToDataTable(string filePath)
        {
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                // Auto-detect format, supports:
                //  - Binary Excel files (2.0-2003 format; *.xls)
                //  - OpenXml Excel files (2007 format; *.xlsx)
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (data) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });
                    //Get all Table
                    DataTableCollection tables = result.Tables;
                    DataTable dt = tables[0];
                    return dt;
                }

            }
        }
    }
}
