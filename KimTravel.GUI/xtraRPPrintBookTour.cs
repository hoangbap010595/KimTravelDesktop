using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace KimTravel.GUI
{
    public partial class xtraRPPrintBookTour : DevExpress.XtraReports.UI.XtraReport
    {
        public xtraRPPrintBookTour(DataTable dt, string tourName, string startDate,string hdv, string taixe)
        {
            InitializeComponent();
            this.objectDataSource1.DataSource = dt;

            lblTourName.Text = tourName;
            lblStartDate.Text = startDate;
            lblHDV.Text = hdv;
            lblTaiXe.Text = taixe;
        }
        
    }
}
