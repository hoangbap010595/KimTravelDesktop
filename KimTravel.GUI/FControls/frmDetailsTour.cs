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
    public partial class frmDetailsTour : MaterialForm
    {
        private MaterialSkinManager mSkin;
        private BookService tourService = new BookService();

        public delegate void LoadData();
        public LoadData loadData;
        private int _WorkID = -1;
        public frmDetailsTour(int wID = 1)
        {
            InitializeComponent();
            _WorkID = wID;
        }

        private void frmActionGroupTour_Load(object sender, EventArgs e)
        {
            mSkin = MaterialSkinManager.Instance;
            mSkin.AddFormToManage(this);
            mSkin.Theme = ConfigApp.Themes;
            mSkin.ColorScheme = new ColorScheme(ConfigApp.Primary, ConfigApp.DarkPrimary, ConfigApp.LightPrimary, ConfigApp.Accent, ConfigApp.TextShade);

            if (_WorkID == 1)
                btnCancel.Text = "Hủy bỏ";
            else
                btnCancel.Text = "Hoàn tác";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (loadData != null)
                loadData();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_WorkID == 1)
            {
                //Cancel = true
                if (DialogResult.OK == MessageBox.Show("Xác nhận muốn hủy bỏ tour đã book này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                {

                }
            }
            else
            {
                //Cancel = false
                if (DialogResult.OK == MessageBox.Show("Xác nhận muốn hoàn tác tour đã hủy này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                {

                }
            }
        }
    }
}
