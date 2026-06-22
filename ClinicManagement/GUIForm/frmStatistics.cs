using BLL.Implements;
using Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.GUIForm
{
    public partial class frmStatistics : Form
    {
        private StatisticService _service = new StatisticService();
        public frmStatistics()
        {
            InitializeComponent();
        }

        private void frmStatistics_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Now.AddDays(-30);
            dtpToDate.Value = DateTime.Now;

            btnThongKe.PerformClick();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime from = dtpFrom.Value;
            DateTime to = dtpToDate.Value;

            if(from > to)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Statistics> list = _service.GetStatistics(from, to);
            dgvStatisc.DataSource = list;
            CalculateGrandTotal(list);
            FormatGrid();
        }


        private void CalculateGrandTotal(List<Statistics> list)
        {
            int tongLuot = 0;
            decimal tongTien = 0;

            foreach(var item in list)
            {
                tongLuot += item.SoLuotKham;
                tongTien += item.DoanhThu;
            }

            lblTongLuot.Text = $"Tổng số lượt khám: {tongLuot}";
            lblTongDoanhThu.Text = $"TỔNG DOANH THU: {tongTien}";
            lblTongDoanhThu.ForeColor = Color.Firebrick;
        }


        private void FormatGrid()
        {
            if (dgvStatisc.Columns["Ngay"] != null)
            {
                dgvStatisc.Columns["Ngay"].HeaderText = "Ngày";
                dgvStatisc.Columns["Ngay"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvStatisc.Columns["SoLuotKham"] != null)
            {
                dgvStatisc.Columns["SoLuotKham"].HeaderText = "Số lượt khám";
                dgvStatisc.Columns["SoLuotKham"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvStatisc.Columns["DoanhThu"] != null)
            {
                dgvStatisc.Columns["DoanhThu"].HeaderText = "Doanh thu";
                dgvStatisc.Columns["DoanhThu"].DefaultCellStyle.Format = "N0";
                dgvStatisc.Columns["DoanhThu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }
    }
}
