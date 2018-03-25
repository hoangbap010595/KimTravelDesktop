using DevExpress.XtraEditors;
using KimTravel.DAL;
using KimTravel.DAL.Models;
using KimTravel.DAL.Services;
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
    public partial class frmConfirm : XtraForm
    {
        private ApplicationUserService service = new ApplicationUserService();
        public delegate void ConfirmPassword();
        public ConfirmPassword confirm;
        public frmConfirm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int rs = service.CheckLogin(Constant.CurrentSessionUser, txtPassword.Text);
            if (rs == 1)
            {
                if (confirm != null)
                    confirm();
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Mật khẩu không đúng. Vui lòng thử lại.");
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnConfirm.PerformClick();
            }
        }

        private void frmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
