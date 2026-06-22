using BLL.Implements;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI.GUIForm
{
    public partial class frmDoctorCenter : Form
    {
        private DoctorService doctorService_ = new DoctorService();
        private int _currentRecordID = -1;
        public frmDoctorCenter()
        {
            InitializeComponent();
        }

        private void frmDoctorCenter_Load(object sender, EventArgs e)
        {
            LoadWaitingList();
            LoadMedicines();
            SetUpPrescriptionGrid();

            ToggleInputs(false);
        }


        private void ToggleInputs(bool enable)
        {
            txtDiagnosis.Enabled = enable;
            cboDrug.Enabled = enable;
            numQuantity.Enabled = enable;
            btnAdd.Enabled = enable;
            btnFinished.Enabled = enable;
        }



        //Load DGV đơn thuốc
        private void SetUpPrescriptionGrid()
        {
            dgvPrescription.Columns.Clear();

            dgvPrescription.Columns.Add("colMedID", "Mã thuốc");
            dgvPrescription.Columns["colMedID"].Visible = false;

            dgvPrescription.Columns.Add("colName", "Tên thuốc");
            dgvPrescription.Columns["colName"].ReadOnly = true;

            dgvPrescription.Columns.Add("colQuantity", "Số lượng");
            dgvPrescription.Columns["colQuantity"].ReadOnly = false;

            dgvPrescription.Columns.Add("colUnit", "Đơn vị");
            dgvPrescription.Columns["colUnit"].ReadOnly = true;

            dgvPrescription.Columns.Add("colPrice", "Đơn giá");
            dgvPrescription.Columns["colPrice"].DefaultCellStyle.Format = "N0";
            dgvPrescription.Columns["colPrice"].ReadOnly = true;

            dgvPrescription.Columns.Add("colUsage", "Cách dùng");
            dgvPrescription.Columns["colUsage"].ReadOnly = false;

        }


        //Load danh sách chờ khám lên DGV chờ
        private void LoadWaitingList()
        {
            dgvWaitingList.DataSource = doctorService_.GetWaitingList();

            if (dgvWaitingList.Columns["RecordID"] != null)
                dgvWaitingList.Columns["RecordID"].Visible = true;
            if (dgvWaitingList.Columns["FullName"] != null)
            {
                dgvWaitingList.Columns["FullName"].HeaderText = "Họ tên";
            }

            if (dgvWaitingList.Columns["Phone"] != null)
            {
                dgvWaitingList.Columns["Phone"].HeaderText = "SĐT";
            }

            if (dgvWaitingList.Columns["Symptoms"] != null)
            {
                dgvWaitingList.Columns["Symptoms"].HeaderText = "Lý do khám";
            }
        }


        //Cell Click DGV
        private void dgvWaitingList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvWaitingList.Rows[e.RowIndex].IsNewRow) return;

            try
            {
                var row = dgvWaitingList.Rows[e.RowIndex];
                if (row.Cells[0] != null)
                {
                    _currentRecordID = int.Parse(row.Cells[0].Value.ToString());
                }
                else
                {
                    _currentRecordID = -1;
                }


                string name = row.Cells[1].Value?.ToString() ?? "NaN";

                lblCurrent.Text = $"Đang khám: {name.ToUpper()}";
                lblCurrent.ForeColor = Color.BlueViolet;

                ToggleInputs(true);
                txtDiagnosis.Clear();
                txtDiagnosis.Focus();
                dgvPrescription.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chọn bệnh nhân" + ex.Message);
            }
        }


        //Load combobox Medicines
        private void LoadMedicines()
        {
            cboDrug.DataSource = doctorService_.GetMedicines();
            cboDrug.DisplayMember = "MedicineName";
            cboDrug.ValueMember = "MedicineID";
        }


        //Chọn giá trị trong combobox Medicines
        private void cboDrug_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDrug.SelectedItem is Medicine selectedMed)
            {
                txtUnit.Text = selectedMed.Unit;
            }
        }



        //Nút Add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_currentRecordID == -1)
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân trong danh sách chờ !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Medicine selectedMed = (Medicine)cboDrug.SelectedItem;
            int qty = (int)numQuantity.Value;

            if (qty <= 0) return;

            dgvPrescription.Rows.Add(
               selectedMed.MedicineID,
               selectedMed.MedicineName,
               qty,
               txtUnit.Text,
               selectedMed.SellPrice,
               txtUsage.Text
            );
            numQuantity.Value = 1;
            txtUsage.Clear();
        }


        //Nút Finished
        private void btnFinished_Click(object sender, EventArgs e)
        {
            if (_currentRecordID <= 0)
            {
                MessageBox.Show("Chưa chọn bệnh nhân ! Vui lòng chọn một bệnh nhân ở danh sách chờ bên trái !");
            }
            if (string.IsNullOrWhiteSpace(txtDiagnosis.Text))
            {
                MessageBox.Show("Vui lòng nhập chẩn đoán bệnh !", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                List<PrescriptionDetail> listDetails = new List<PrescriptionDetail>();
                foreach (DataGridViewRow row in dgvPrescription.Rows)
                {
                    if (row.IsNewRow) continue;

                    PrescriptionDetail item = new PrescriptionDetail();
                    item.MedicineID = int.Parse(row.Cells["colMedID"].Value.ToString());
                    item.Quantity = int.Parse(row.Cells["colQuantity"].Value.ToString());
                    item.Usage = row.Cells["colUsage"].Value?.ToString() ?? "";

                    listDetails.Add(item);
                }

                doctorService_.FinishExamination(_currentRecordID, txtDiagnosis.Text.Trim(), listDetails);
                MessageBox.Show("Đã lưu bệnh án & Kê đơn hoàn tất !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadWaitingList();
                ToggleInputs(false);
                lblCurrent.ForeColor = Color.Black;
                _currentRecordID = -1;
                dgvPrescription.Rows.Clear();
                txtDiagnosis.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Nút Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPrescription.CurrentRow == null || dgvPrescription.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn đơn thuốc cần xóa !", "Thông báo");
                return;
            }

            string tenThuoc = dgvPrescription.CurrentRow.Cells["colName"].Value.ToString();
            if (MessageBox.Show("Bạn có chắc muốn xóa đơn thuốc này ?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvPrescription.Rows.Remove(dgvPrescription.CurrentRow);
            }
        }

        private void frmDoctorCenter_Activated(object sender, EventArgs e)
        {
            LoadWaitingList();
        }
    }
}