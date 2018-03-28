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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KimTravel.GUI.FControls
{
    public partial class frmImportPartner : XtraForm
    {
        private DataTable dtDataTemp;
        private PartnerService service = new PartnerService();
        public frmImportPartner()
        {
            InitializeComponent();
        }

        private void frmActionGroupTour_Load(object sender, EventArgs e)
        {
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            prbUpload.Minimum = 0;
            prbUpload.Maximum = dtDataTemp.Rows.Count;
            btnUpdate.Enabled = false;
            Thread t = new Thread(new ThreadStart(() =>
            {
                foreach (DataRow item in dtDataTemp.Rows)
                {
                    Partner p = new Partner();
                    p.PartnerCode = service.GetPartnerCode();
                    p.Name = item["Name"].ToString();
                    p.Address = item["Address"].ToString();
                    p.Phone = item["Phone"].ToString();
                    p.Status = 1;
                    p.Name = item["Note"].ToString();
                    //p.Name =  item["GroupID"].ToString();
                    service.Insert(p);
                    this.Invoke((MethodInvoker)delegate
                    {
                        prbUpload.Value++;
                        if (prbUpload.Value == dtDataTemp.Rows.Count)
                        {
                            XtraMessageBox.Show("Import hoàn tất");
                            btnUpdate.Enabled = true;
                            dtDataTemp.Rows.Clear();
                            lblMessage.Text = "Hoàn tất quá trình import.";
                        }
                    });
                }
            }));
            t.Start();
        }

        private void TextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnOpenFileExcel_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "Excel .xlsx|*.xlsx|Excel .xls|*.xls";
                if (DialogResult.OK == op.ShowDialog())
                {
                    txtPath.Text = op.FileName;
                    dtDataTemp = ExcelLibrary.getDataExcelFromFileToDataTable(op.FileName);
                    lblMessage.Text = "Tìm thấy " + dtDataTemp.Rows.Count + " record(s) cần upload";
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
