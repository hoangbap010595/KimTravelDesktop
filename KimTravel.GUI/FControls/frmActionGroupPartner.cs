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
    public partial class frmActionGroupPartner : MaterialForm
    {
        private MaterialSkinManager mSkin;
        private GroupPartner _objectData;
        private GroupPartnerService gpService = new GroupPartnerService();
        private int _action = -1;
        private int _objID = -1;
        public delegate void LoadData();
        public LoadData loadData;
        public frmActionGroupPartner(int action = -1, int objID = -1)
        {
            InitializeComponent();
            _action = action;
            _objID = objID;
            _objectData = gpService.GetByID(objID);
        }

        private void frmActionGroupTour_Load(object sender, EventArgs e)
        {
            mSkin = MaterialSkinManager.Instance;
            mSkin.AddFormToManage(this);
            mSkin.Theme = ConfigApp.Themes;
            mSkin.ColorScheme = new ColorScheme(ConfigApp.Primary, ConfigApp.DarkPrimary, ConfigApp.LightPrimary, ConfigApp.Accent, ConfigApp.TextShade);
            txtGroupPartner.Focus();

            if (_action == -1)
                this.Text = "Thêm mới nhóm đối tác";
            else
                this.Text = "Cập nhật nhóm đối tác";

            if (_objectData != null)
            {
                txtGroupPartner.Text = _objectData.GroupName;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtGroupPartner.Text == "")
            {
                MessageBox.Show("Tên nhóm không thể để trống.");
                return;
            }
            GroupPartner g = new GroupPartner();
            g.GroupPartnerID = _objID;
            g.GroupName = txtGroupPartner.Text;

            var rs = false;
            var msg = "";
            if (_action == -1)
            {
                rs = this.gpService.Insert(g);
                msg = "Thêm mới thành công";
            }
            else
            {
                rs = this.gpService.Update(g);
                msg = "Cập nhật thành công";
            }
            if (rs)
            {
                MessageBox.Show(msg);

                if (loadData != null)
                    loadData();
                this.Close();
            }
            else
                MessageBox.Show("Tên nhóm đã tồn tại trong hệ thống. Vui lòng kiểm tra lại.");

        }

    }
}
