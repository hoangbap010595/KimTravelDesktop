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
    public partial class frmFindServiceType : MaterialForm
    {
        private MaterialSkinManager mSkin;
        private ServiceTypeService gtService = new ServiceTypeService();

        public delegate void LoadData(string name, int price, int add);
        public LoadData sendData;

        private int _PartnerID = -1;
        public frmFindServiceType()
        {
            InitializeComponent();
        }

        private void frmActionGroupTour_Load(object sender, EventArgs e)
        {
            mSkin = MaterialSkinManager.Instance;
            mSkin.AddFormToManage(this);
            mSkin.Theme = ConfigApp.Themes;
            mSkin.ColorScheme = new ColorScheme(ConfigApp.Primary, ConfigApp.DarkPrimary, ConfigApp.LightPrimary, ConfigApp.Accent, ConfigApp.TextShade);
            txtPartner.Focus();
            dataGridViewGroupTour.AutoGenerateColumns = false;
            dataGridViewGroupTour.DataSource = gtService.GetList();

        }
        private void loadData()
        {
            gtService = new ServiceTypeService();
            dataGridViewGroupTour.DataSource = gtService.GetList();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPartner_KeyPress(object sender, KeyPressEventArgs e)
        {
            var content = txtPartner.Text;
            dataGridViewGroupTour.DataSource = gtService.GetListFind(content);
            dataGridViewGroupTour.Update();
            dataGridViewGroupTour.Refresh();
        }

        private void dataGridViewGroupTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewGroupTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            }
            catch { }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(DialogResult.OK == XtraMessageBox.Show("Bạn muốn xóa dịch vụ ra khỏi hệ thống ?","Xác nhận",MessageBoxButtons.OKCancel))
            {
                bool rs = gtService.Delete(_PartnerID);
                if (rs)
                {
                    gtService = new ServiceTypeService();
                    dataGridViewGroupTour.DataSource = gtService.GetList();
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

        private void dataGridViewGroupTour_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.DataSource != null)
            {
                if (senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "True")
                {
                    senderGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;

                    string service = dataGridViewGroupTour.Rows[e.RowIndex].Cells[2].Value.ToString();
                    int price = int.Parse(dataGridViewGroupTour.Rows[e.RowIndex].Cells[3].Value.ToString());
                    int add = 1;
                    if (sendData != null)
                        sendData(service, price, add);
                }
                else
                {
                    senderGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    string service = dataGridViewGroupTour.Rows[e.RowIndex].Cells[2].Value.ToString();
                    int price = int.Parse(dataGridViewGroupTour.Rows[e.RowIndex].Cells[3].Value.ToString());
                    int add = -1;
                    if (sendData != null)
                        sendData(service, price, add);
                }

            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmActionService frm = new frmActionService();
            frm.loadData = new frmActionService.LoadData(loadData);
            frm.ShowDialog();
        }
    }
}
