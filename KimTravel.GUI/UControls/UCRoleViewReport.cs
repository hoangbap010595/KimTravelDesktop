using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimTravel.GUI.FControls;
using KimTravel.DAL.Services;

namespace KimTravel.GUI.UControls
{
    public partial class UCRoleViewReport : UserControl
    {
        private PartnerService partnerService;
        private ApplicationUserService userService = new ApplicationUserService();
        private int _currentUserID = 0;
        public UCRoleViewReport()
        {
            InitializeComponent();
        }

        private void loadDataGroup()
        {
            partnerService = new PartnerService();
            var data = partnerService.GetList();
            dtgPartner.DataSource = data;
            dtgPartner.Update();
            dtgPartner.Refresh();

            userService = new ApplicationUserService();
            dtgAccount.DataSource = userService.GetList();
            dtgAccount.Update();
            dtgAccount.Refresh();
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmActionGroupPartner frm = new frmActionGroupPartner();
            frm.loadData = new frmActionGroupPartner.LoadData(loadDataGroup);
            frm.ShowDialog();
        }

        private void UCGroupTour_Load(object sender, EventArgs e)
        {
            dtgPartner.AutoGenerateColumns = false;
            dtgAccount.AutoGenerateColumns = false;
            loadDataGroup();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadDataGroup();
        }
        private void dataGridViewGroupTour_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dtgPartner.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void btnThemMoi_Click_1(object sender, EventArgs e)
        {
            frmActionGroupPrice frm = new frmActionGroupPrice();
            frm.loadData = new frmActionGroupPrice.LoadData(loadDataGroup);
            frm.ShowDialog();
        }
     
        private void dtgPartner_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.DataSource != null)
            {
                if (senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "True")
                {
                    senderGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
                }
                else
                {
                    senderGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }

            }
        }

        private void dtgAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;
                var id = int.Parse(senderGrid.Rows[e.RowIndex].Cells["colUID"].Value.ToString());
                var username = senderGrid.Rows[e.RowIndex].Cells["colUserName"].Value.ToString();
                _currentUserID = id;
                lblText.Text = username;

                var data = userService.GetPartnerViewReport(username);
                SetRowsChecked(data);
            }
            catch { }
        }
        private string GetRowsChecked()
        {
            string rs = "";
            foreach (DataGridViewRow row in dtgPartner.Rows)
            {
                if (row.Cells["colCheck"].Value != null && (bool)row.Cells["colCheck"].Value)
                {
                    rs += int.Parse(row.Cells["colPartnerID"].Value.ToString()) + ",";
                }
            }
            return rs;
        }
        private void SetRowsChecked(string data)
        {
            var datas = data.Split(',');
            List<int> lsPartner = new List<int>();
            foreach (var item in datas)
            {
                if (item != "")
                    lsPartner.Add(int.Parse(item));
            }
            foreach (DataGridViewRow row in dtgPartner.Rows)
            {
                int id = int.Parse(row.Cells["colPartnerID"].Value.ToString());
                if(lsPartner.Contains(id))
                {
                    row.Cells["colCheck"].Value = true;
                }else
                    row.Cells["colCheck"].Value = false;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_currentUserID == 0)
            {
                MessageBox.Show("Bạn chưa chọn tài khoản để thiết lập.");
                return;
            }
            if (DialogResult.Yes == MessageBox.Show("Cập nhật phân quyền xem báo cáo cho tài khoản \"" + lblText.Text + "\"", "Thông báo", MessageBoxButtons.YesNo))
            {
                string data = GetRowsChecked();
                var rs = userService.UpdateRoleViewReport(_currentUserID, data);
                if (rs)
                    MessageBox.Show("Cập nhật thành công.");
                else
                    MessageBox.Show("Xảy ra lỗi. Cập nhật thất bại.");
            }
        }
    }
}
