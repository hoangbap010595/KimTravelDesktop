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
    public partial class frmShowConfirmBookTour : XtraForm
    {
        public delegate void OKBookTour();
        public OKBookTour okbook;
        public frmShowConfirmBookTour()
        {
            InitializeComponent();
        }
        
        public frmShowConfirmBookTour(string ngaydi, string tour, string pax, string dichvu, string nvbook, string pickup, string room, string doitac, string thuho, string ghichu)
        {
            InitializeComponent();
            lblNgayDi.Text = ngaydi;
            lblTour.Text = tour;
            lblSoLuong.Text = pax;
            lblDichVu.Text = dichvu;
            lblNVBook.Text = nvbook;
            lblPickup.Text = pickup;
            lblRoom.Text = room;
            lblPartner.Text = doitac;
            lblPartnerPrice.Text = thuho;
            lblNote.Text = ghichu;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (okbook != null)
                okbook();
            this.Close();
        }
    }
}
