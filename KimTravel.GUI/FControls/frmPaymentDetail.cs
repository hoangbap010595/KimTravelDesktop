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
    public partial class frmPaymentDetail :XtraForm
    {
        private int _Month = 0;
        private int _Year = 0;
        private int _PartnerID = 0;
        private int _IsPayment = -1;
        public frmPaymentDetail(int partnerID, int month, int year, int typePayment)
        {
            InitializeComponent();
            this._PartnerID = partnerID;
            this._Month = month;
            this._Year = year;
            this._IsPayment = typePayment;
        }

        private void frmPaymentDetail_Load(object sender, EventArgs e)
        {
            this.Controls.Clear();
            UControls.UCReportCongNo uc = new UControls.UCReportCongNo(_PartnerID, _Month, _Year, _IsPayment);
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }
    }
}
