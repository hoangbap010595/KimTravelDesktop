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
    public partial class frmConfirmSaleBook : XtraForm
    {
        private ApplicationUserService service = new ApplicationUserService();
        public delegate void ConfirmSaleBook(string value);
        public ConfirmSaleBook confirm;
        public frmConfirmSaleBook()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var text = txtTenNguoiBook.Text;
            if (confirm != null)
                confirm(text);
            this.Close();
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
