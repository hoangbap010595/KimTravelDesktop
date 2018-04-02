using DevExpress.XtraEditors;
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
    public partial class frmConfirmPayment : XtraForm
    {
        public delegate void SendPayment(int typePayment);
        public SendPayment sendPayment;
        public frmConfirmPayment()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int x = -1;
            if (rdAll.Checked)
                x = 3;
            else if (rdPayment.Checked)
                x = 1;
            else if (rdNotPayment.Checked)
                x = 2;
            if (sendPayment != null)
                sendPayment(x);
            this.Close();
        }
    }
}
