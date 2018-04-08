using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.DataAccess.Native.Data;
using KimTravel.DAL.Services;
using KimTravel.DAL.Models;

namespace KimTravel.GUI
{
    public partial class xtraRPBaoCaoCongNo : DevExpress.XtraReports.UI.XtraReport
    {
        private BookService objService;
        private PartnerService partnerService;
        private GroupTourService groupTourService;
        public xtraRPBaoCaoCongNo(int partnerID, int month, int year, int isPayment)
        {
            InitializeComponent();
            objService = new BookService();
            partnerService = new PartnerService();
            groupTourService = new GroupTourService();
            if (isPayment == 3)
                this.objectDataSource1.DataSource = objService.GetListBookedDoneReport(partnerID, month, year, null, true);
            else if (isPayment == 1)
                this.objectDataSource1.DataSource = objService.GetListBookedDoneReport(partnerID, month, year, true, true);
            else if (isPayment == 2)
                this.objectDataSource1.DataSource = objService.GetListBookedDoneReport(partnerID, month, year, false, true);
            //GroupTour g = groupTourService.GetByID(groupID);
            string title = "CÔNG NỢ THÁNG " + month + "/" + year;
            lblTitle.Text = title.ToUpper();
            Partner p = partnerService.GetByID(partnerID);
            lblPartnerName.Text = p.Name;
            lblPartnerPhone.Text = p.Phone;
        }
        public xtraRPBaoCaoCongNo(DataTable dt)
        {
            InitializeComponent();
            this.objectDataSource1.DataSource = dt;
            lblTitle.Text = "CÔNG NỢ THÁNG " + DateTime.Now.Month + "/" + DateTime.Now.Year;
        }


    }
}
