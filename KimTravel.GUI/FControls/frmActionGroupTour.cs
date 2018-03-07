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
    public partial class frmActionGroupTour : MaterialForm
    {
        private MaterialSkinManager mSkin;
        private GroupTour _groupTour;
        private GroupTourService gtService = new GroupTourService();
        private int _action = -1;
        private int _groupID = -1;
        public delegate void LoadData();
        public LoadData loadData;
        public frmActionGroupTour(int action = -1, int GroupTourID = -1)
        {
            InitializeComponent();
            if (action == -1)
                this.Text = "Thêm mới nhóm tour";
            else
                this.Text = "Cập nhật nhóm tour";
            _action = action;
            _groupID = GroupTourID;
            _groupTour = gtService.GetByID(GroupTourID);
            if (_groupTour != null)
            {
                txtGroupName.Text = _groupTour.Name;
                txtMinPax.Text = _groupTour.MinPax.ToString();
                txtMaxPax.Text = _groupTour.MaxPax.ToString();
                ckEnabled.Checked = _groupTour.Enable == true ? true : false;
                txtNote.Text = _groupTour.Note;
            }
        }

        private void frmActionGroupTour_Load(object sender, EventArgs e)
        {
            mSkin = MaterialSkinManager.Instance;
            mSkin.AddFormToManage(this);
            mSkin.Theme = ConfigApp.Themes;
            mSkin.ColorScheme = new ColorScheme(ConfigApp.Primary, ConfigApp.DarkPrimary, ConfigApp.LightPrimary, ConfigApp.Accent, ConfigApp.TextShade);
            txtGroupName.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtGroupName.Text == "")
            {
                MessageBox.Show("Tên nhóm không thể để trống.");
                return;
            }
            GroupTour groupTourNew = new GroupTour();
            groupTourNew.GroupID = _groupID;
            groupTourNew.Name = txtGroupName.Text;
            groupTourNew.MinPax = int.Parse(txtMinPax.Text);
            groupTourNew.MaxPax = int.Parse(txtMaxPax.Text);
            groupTourNew.Enable = ckEnabled.Checked;
            groupTourNew.Note = txtNote.Text;
            var rs = false;
            var msg = "";
            if (_action == -1)
            {
                groupTourNew.DateCreate = DateTime.Now;
                rs = this.gtService.Insert(groupTourNew);
                msg = "Thêm mới nhóm tour thành công";
            }
            else
            {
                rs = this.gtService.Update(groupTourNew);
                msg = "Cập nhật nhóm tour thành công";
            }
            if (rs)
            {
                MessageBox.Show(msg);

                if (loadData != null)
                    loadData();
                this.Close();
            }
            else
                MessageBox.Show("Tên group tồn tại trong hệ thống. Vui lòng kiểm tra lại.");

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
