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

        public delegate void LoadData(string name, int price);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPrice.Text == "" || txtNameService.Text == "")
            {
                MessageBox.Show("Không có dịch vụ nào được chọn. Vui lòng thử lại");
                return;
            }
            if (sendData != null)
                sendData(txtNameService.Text, int.Parse(txtPrice.Text));
            //this.Close();
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
                var x = dataGridViewGroupTour.Rows[e.RowIndex].Cells[0].Value.ToString();
                _PartnerID = int.Parse(x);
                txtNameService.Text = dataGridViewGroupTour.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPrice.Text = dataGridViewGroupTour.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch { }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            ServiceType s = new ServiceType();
            s.Name = txtNameService.Text;
            s.Price = int.Parse(txtPrice.Text);

            bool rs = gtService.Insert(s);
            if (rs)
            {
                gtService = new ServiceTypeService();
                dataGridViewGroupTour.DataSource = gtService.GetList();
            }
            else {
                MessageBox.Show("Tên dịch vụ đã tồn tại trong hệ thống");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            ServiceType s = new ServiceType();
            s.ID = _PartnerID;
            s.Name = txtNameService.Text;
            s.Price = int.Parse(txtPrice.Text);

            bool rs = gtService.Update(s);
            if (rs)
            {
                gtService = new ServiceTypeService();
                dataGridViewGroupTour.DataSource = gtService.GetList();
            }
            else
            {
                MessageBox.Show("Tên dịch vụ đã tồn tại trong hệ thống");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(DialogResult.OK == MessageBox.Show("Bạn muốn xóa dịch vụ ra khỏi hệ thống ?","Xác nhận",MessageBoxButtons.OKCancel))
            {
                bool rs = gtService.Delete(_PartnerID);
                if (rs)
                {
                    gtService = new ServiceTypeService();
                    dataGridViewGroupTour.DataSource = gtService.GetList();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin");
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

    }
}
