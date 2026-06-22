using BLL.Implements;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.GUIForm
{
    public partial class frmHistory : Form
    {
        private HistoryService _service = new HistoryService();

        public frmHistory()
        {
            InitializeComponent();
        }

        private void frmHistory_Load(object sender, EventArgs e)
        {
            LoadData("");
            FormatGrid();
        }


        //Load DGV
        private void LoadData(string keyword)
        {
            var list = _service.GetHistoryList(keyword);
            dgvList.DataSource = list;

            if (list.Count == 0)
            {
                if (!string.IsNullOrEmpty(keyword))
                {
                    MessageBox.Show("Không tìm thấy hồ sơ nào !");
                }

                dgvPrescriptionDetails.DataSource = null;
                dgvService.DataSource = null;
            }
            else
            {
                FormatGrid();
            }
        }


        //Button Tìm
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            LoadData(keyword);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                int recordID = int.Parse(dgvList.Rows[e.RowIndex].Cells["RecordID"].Value.ToString());
                dgvPrescriptionDetails.DataSource = _service.GetPrescriptionDetail(recordID);
                dgvService.DataSource = _service.GetServiceDetails(recordID);

                FormatDetailGrids();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }



        private void FormatGrid()
        {
            if (dgvList.Columns["RecordID"] != null)
                dgvList.Columns["RecordID"].Visible = false;

            if (dgvList.Columns["NgayKham"] != null)
            {
                dgvList.Columns["NgayKham"].HeaderText = "Ngày khám";
                dgvList.Columns["NgayKham"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                dgvList.Columns["NgayKham"].Width = 120;
            }

            if (dgvList.Columns["TenBenhNhan"] != null) dgvList.Columns["TenBenhNhan"].HeaderText = "Tên bệnh nhân";
            if (dgvList.Columns["BacSiKham"] != null) dgvList.Columns["BacSiKham"].HeaderText = "Bác sĩ chỉ định";
            if (dgvList.Columns["ChanDoan"] != null) dgvList.Columns["ChanDoan"].HeaderText = "Chẩn đoán";

            if (dgvList.Columns["TongTien"] != null)
            {
                dgvList.Columns["TongTien"].HeaderText = "Tổng tiền";
                dgvList.Columns["TongTien"].DefaultCellStyle.Format = "N0";
                dgvList.Columns["TongTien"].DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            }

            if (dgvList.Columns["TrangThai"] != null) dgvList.Columns["TrangThai"].HeaderText = "Trạng thái";
        }


        private void FormatDetailGrids()
        {
            if (dgvPrescriptionDetails.Columns["TenThuoc"] != null)
                dgvPrescriptionDetails.Columns["TenThuoc"].HeaderText = "Tên thuốc";

            if (dgvPrescriptionDetails.Columns["ThanhTien"] != null)
                dgvPrescriptionDetails.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";

            if (dgvService.Columns["TenDichVu"] != null)
                dgvService.Columns["TenDichVu"].HeaderText = "Tên dịch vụ";

            if (dgvService.Columns["ThanhTien"] != null)
                dgvService.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
        }



        //Button Refresh
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadData("");
        }
    }
}
