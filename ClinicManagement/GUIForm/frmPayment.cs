using BLL.Implements;
using Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.GUIForm
{
    public partial class frmPayment : Form
    {
        private PaymentService _service = new PaymentService();
        private int _currentRecordID = -1;
        private decimal _totalAmount = 0;

        public frmPayment()
        {
            InitializeComponent();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            LoadWaitingList();
        }


        //Load danh sách chờ thanh toán
        private void LoadWaitingList()
        {
            dgvWaitingList.DataSource = _service.GetPaymentWaitingList();
            FormatGrid();
        }

        private void dgvWaitingList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvWaitingList.Rows[e.RowIndex];
            if (row.Cells[0].Value != null)
            {
                _currentRecordID = int.Parse(row.Cells[0].Value.ToString());
            }

            dgvMedicine.DataSource = _service.GetPrescriptionDetails(_currentRecordID);
            dgvService.DataSource = _service.GetServiceDetails(_currentRecordID);

            FormatGrid();
            CalculateTotal();
        }


        private void FormatGrid()
        {
            if(dgvWaitingList.Columns.Count > 0)
            {
                dgvWaitingList.Columns["RecordID"].Visible = false;

                dgvWaitingList.Columns["FullName"].HeaderText = "Họ và tên";
                dgvWaitingList.Columns["Phone"].HeaderText = "Số điện thoại";
                dgvWaitingList.Columns["Diagnosis"].HeaderText = "Chẩn đoán";
                dgvWaitingList.Columns["DateCreated"].HeaderText = "Thời gian khám";
                dgvWaitingList.Columns["DateCreated"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }

            if (dgvMedicine.Columns.Contains("ItemName"))
            {
                dgvMedicine.Columns["ItemName"].HeaderText = "Tên thuốc";
                dgvMedicine.Columns["SL"].HeaderText = "Số lượng";
                dgvMedicine.Columns["SL"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvMedicine.Columns["DonGia"].HeaderText = "Đơn giá";
                dgvMedicine.Columns["DonGia"].DefaultCellStyle.Format = "N0";
                dgvMedicine.Columns["ThanhTien"].HeaderText = "Thành tiền";
                dgvMedicine.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
            }

            if (dgvService.Columns.Contains("ItemName"))
            {
                dgvService.Columns["ItemName"].HeaderText = "Tên dịch vụ";
                dgvService.Columns["SL"].HeaderText = "Số lượng";
                dgvService.Columns["SL"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvService.Columns["DonGia"].HeaderText = "Đơn giá";
                dgvService.Columns["DonGia"].DefaultCellStyle.Format = "N0";
                dgvService.Columns["ThanhTien"].HeaderText = "Thành tiền";
                dgvService.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
            }
        }



        //Tính tổng tiền
        private void CalculateTotal()
        {
            decimal tongThuoc = 0;
            decimal tongDichvu = 0;

            foreach (DataGridViewRow row in dgvMedicine.Rows)
            {
                if (row.Cells["ThanhTien"].Value != null)
                    tongThuoc += Convert.ToDecimal(row.Cells["ThanhTien"].Value);
            }

            foreach (DataGridViewRow row in dgvService.Rows)
            {
                if (row.Cells["ThanhTien"].Value != null)
                    tongDichvu += Convert.ToDecimal(row.Cells["ThanhTien"].Value);
            }

            _totalAmount = tongThuoc + tongDichvu;

            lblTotal.Text = $"Tổng tiền cần thanh toán: {_totalAmount:N0}";
        }


        //Button Thanh toán
        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (_currentRecordID == -1)
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân tại danh sách chờ !");
                return;
            }

            if (_totalAmount == 0)
            {
                if (MessageBox.Show("Tổng tiền cuối cùng là 0VNĐ. Bạn có chắc muốn hoàn tất không ?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            }

            try
            {
                _service.ConfirmPayment(_currentRecordID, _totalAmount);
                MessageBox.Show("Thanh toán thành công !");

                LoadWaitingList();
                dgvMedicine.DataSource = null;
                dgvService.DataSource = null;
                lblTotal.Text = "Tổng tiền cần thanh toán: 0VNĐ";
                _currentRecordID = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
