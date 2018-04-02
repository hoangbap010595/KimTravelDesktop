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
    public partial class xtraRPBaoCaoCongNoDoiTac : DevExpress.XtraReports.UI.XtraReport
    {
        private BookService objService;
        private PartnerService partnerService;
        private GroupTourService groupTourService;
        public xtraRPBaoCaoCongNoDoiTac(int partnerID, int groupID, int month, int year)
        {
            InitializeComponent();
            objService = new BookService();
            partnerService = new PartnerService();
            groupTourService = new GroupTourService();
            this.objectDataSource1.DataSource = objService.GetListBookedDoneReport(partnerID, month, year, true);
            GroupTour g = groupTourService.GetByID(groupID);
            string title = "CÔNG NỢ " + g.Name + " THÁNG " + month + "/" + year;
            lblTitle.Text = title.ToUpper();
            Partner p = partnerService.GetByID(partnerID);
            lblPartnerName.Text = p.Name;
            lblPartnerPhone.Text = p.Phone;
        }
        public xtraRPBaoCaoCongNoDoiTac(int partnerID, int month, int year)
        {
            InitializeComponent();
            objService = new BookService();
            partnerService = new PartnerService();
            groupTourService = new GroupTourService();
            this.objectDataSource2.DataSource = objService.GetListBookedDoneReportPartner(partnerID, month, year, true);
            string title = "CÔNG NỢ THÁNG " + month + "/" + year;
            lblTitle.Text = title.ToUpper();
            Partner p = partnerService.GetByID(partnerID);
            lblPartnerName.Text = p.Name;
            lblPartnerPhone.Text = p.Phone;
        }
        public xtraRPBaoCaoCongNoDoiTac(DataTable dt)
        {
            InitializeComponent();
            this.objectDataSource1.DataSource = dt;
            lblTitle.Text = "CÔNG NỢ THÁNG " + DateTime.Now.Month + "/" + DateTime.Now.Year;
        }


    }
}
