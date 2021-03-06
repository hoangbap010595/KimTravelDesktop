﻿using DevExpress.XtraEditors;
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
    public partial class frmActionGroupPrice : XtraForm
    {
        private Price _objectData;
        private PriceService priceService = new PriceService();
        private GroupPartnerService groupService = new GroupPartnerService();
        private TourService tourService = new TourService();
        GroupTourService grTourService = new GroupTourService();


        private int _action = -1;
        private int _objID = -1;
        public delegate void LoadData();
        public LoadData loadData;
        public frmActionGroupPrice(int action = -1, int objID = -1)
        {
            InitializeComponent();
            _action = action;
            _objID = objID;
            _objectData = priceService.GetByID(objID);
        }

        private void frmActionGroupTour_Load(object sender, EventArgs e)
        {
            txtPriceRe.Focus();

            cbbGroupPartner.DataSource = groupService.GetList();
            cbbGroupPartner.ValueMember = "GroupPartnerID";
            cbbGroupPartner.DisplayMember = "GroupName";

            cbbGroupTour.DataSource = grTourService.GetListCombobox();
            cbbGroupTour.ValueMember = "GroupID";
            cbbGroupTour.DisplayMember = "Name";

            if (_action == -1)
                this.Text = "Thêm mới giá nhận theo tour";
            else
                this.Text = "Cập nhật giá nhận theo tour";

            if (_objectData != null)
            {
                txtPriceRe.Text = _objectData.PriceRe.ToString();
                txtPriceReChild.Text = _objectData.PriceReChild.ToString();
                cbbGroupPartner.SelectedValue = _objectData.GroupID;
                Tour t = tourService.GetByID((int)_objectData.TourID);
                cbbGroupTour.SelectedValue = t.GroupID;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPriceRe.Text == "")
            {
                XtraMessageBox.Show("Giá nhận người lớn không thể để trống.");
                return;
            }
            if (txtPriceReChild.Text == "")
            {
                XtraMessageBox.Show("Giá nhận trẻ em không thể để trống.");
                return;
            }
            Price price = new Price();
            price.Key = _objID;
            price.GroupID = int.Parse(cbbGroupPartner.SelectedValue.ToString());
            price.TourID = int.Parse(cbbTour.SelectedValue.ToString());
            price.PriceRe = int.Parse(txtPriceRe.Text);
            price.PriceReChild = int.Parse(txtPriceReChild.Text);
            var rs = false;
            var msg = "";
            if (_action == -1)
            {
                rs = this.priceService.Insert(price);
                msg = "Thêm mới thành công";
            }
            else
            {
                rs = this.priceService.Update(price);
                msg = "Cập nhật thành công";
            }
            if (rs)
            {
                XtraMessageBox.Show(msg);

                if (loadData != null)
                    loadData();
                this.Close();
            }
            else
                XtraMessageBox.Show("Giá tour đã được thiết lập trong hệ thống. Vui lòng kiểm tra lại.");

        }
        private void TextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbbGroupTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var x = cbbGroupTour.SelectedValue.ToString();
                int gID = int.Parse(x);
                cbbTour.DataSource = tourService.GetListForGroup(gID);
                cbbTour.ValueMember = "TourID";
                cbbTour.DisplayMember = "Name";
                cbbTour.SelectedValue = _objectData.TourID;
            }
            catch { }
        }
    }
}
