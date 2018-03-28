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
    public partial class frmFindPartner : XtraForm
    {
        private PartnerService gtService = new PartnerService();

        public delegate void LoadData(int pID);
        public LoadData sendData;
        private int _PartnerID = -1;
        public frmFindPartner()
        {
            InitializeComponent();
        }

        private void frmActionGroupTour_Load(object sender, EventArgs e)
        {
            txtPartner.Focus();
            dataGridViewGroupTour.AutoGenerateColumns = false;
            dataGridViewGroupTour.DataSource = gtService.GetList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (sendData != null)
                sendData(_PartnerID);
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
                var x = dataGridViewGroupTour.Rows[e.RowIndex].Cells[0].Value.ToString();
                _PartnerID = int.Parse(x);
            }
            catch { }
        }
    }
}
