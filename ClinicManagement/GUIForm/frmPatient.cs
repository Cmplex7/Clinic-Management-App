using BLL;
using Entities;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmPatient : Form
    {
        private PatientService _patientService = new PatientService();
        private UserService _userService = new UserService();
        private ServicesService _servicesService = new ServicesService();

        public frmPatient()
        {
            InitializeComponent();
        }

        //Load Form
        private void frmPatient_Load(object sender, EventArgs e)
        {
            try
            {
                LoadPatients();
                LoadDoctors();
                LoadServices();

                if (cboGender.Items.Count == 0)
                {
                    cboGender.Items.Add("Nam");
                    cboGender.Items.Add("Nữ");
                    cboGender.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Load danh sách bệnh nhân
        private void LoadPatients()
        {
            dgvPatient.DataSource = _patientService.GetPatient();

            dgvPatient.Columns["PatientID"].HeaderText = "Mã bệnh nhân";
            dgvPatient.Columns["FullName"].HeaderText = "Họ và tên";
            dgvPatient.Columns["Phone"].HeaderText = "SĐT";
            dgvPatient.Columns["BirthYear"].HeaderText = "Năm sinh";
            dgvPatient.Columns["Gender"].HeaderText = "Giới tính";
            dgvPatient.Columns["Address"].HeaderText = "Địa chỉ";

            if (dgvPatient.Columns["MedicalRecords"] != null) dgvPatient.Columns["MedicalRecords"].Visible = false;
        }


        //Load ComboBox Doctors
        private void LoadDoctors()
        {
            var allActiveUsers = _userService.GetAllUser(false);
            var doctors = allActiveUsers.Where(u => u.RoleID == 2).ToList();

            if(doctors.Count == 0)
            {
                MessageBox.Show("Chưa có bác sĩ nào trong hệ thống. Vui lòng thêm bác sĩ trước khi đăng ký khám cho bệnh nhân.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            cboDoctor.DataSource = doctors;
            cboDoctor.DisplayMember = "FullName";
            cboDoctor.ValueMember = "UserID";
        }

        private void dgvPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            var row = dgvPatient.Rows[e.RowIndex];
            txtID.Text = row.Cells["PatientID"].Value.ToString();
            txtName.Text = row.Cells["FullName"].Value.ToString();
            txtPhone.Text = row.Cells["Phone"].Value.ToString();
            txtAddress.Text = row.Cells["Address"].Value.ToString();
            txtYear.Text = row.Cells["BirthYear"].Value.ToString();

            string gender = row.Cells["Gender"].Value?.ToString();
            cboGender.SelectedItem = gender;
        }


        private void LoadServices()
        {
            cboService.DataSource = _servicesService.GetServices();
            cboService.DisplayMember = "ServiceName";
            cboService.ValueMember = "ServiceID";
        }



        //Button thêm
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Patient p = new Patient();
                p.FullName = txtName.Text.Trim();
                p.Address = txtAddress.Text.Trim();
                p.Phone = txtPhone.Text.Trim();
                p.BirthYear = int.Parse(txtYear.Text);
                p.Gender = cboGender.SelectedItem.ToString();

                _patientService.AddPatient(p);
                MessageBox.Show("Thêm bệnh nhân thành công !");
                LoadPatients();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Button sửa
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text)) return;

            try
            {
                Patient p = new Patient();
                p.PatientID = int.Parse(txtID.Text);
                p.FullName = txtName.Text.Trim();
                p.Phone = txtPhone.Text.Trim();
                p.Address = txtAddress.Text.Trim();
                p.BirthYear = int.Parse(txtYear.Text);
                p.Gender = cboGender.SelectedItem.ToString();

                _patientService.UpdatePatient(p);
                MessageBox.Show("Cập nhật thành công !");
                LoadPatients();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Button xóa
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa thông tin này không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    int id = int.Parse(txtID.Text);
                    _patientService.DeletePatient(id);
                    LoadPatients();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa: " + ex.Message);
                }
            }
        }

        //Button đăng ký khám
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Vui lòng chọn một bệnh nhân từ danh sách !");
                return;
            }

            if (cboDoctor.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn một trong các bác sĩ để chỉ định !");
                return;
            }

            try
            {
                string symptomInput = txtSymptoms.Text.Trim();
                if (string.IsNullOrEmpty(symptomInput))
                {
                    symptomInput = "Đang chờ khám";
                }
                int patientId = int.Parse(txtID.Text);
                int doctorID = (int)cboDoctor.SelectedValue;
                int serviceId = (int)cboService.SelectedValue;

                _patientService.RegisterExam(patientId, doctorID, symptomInput, serviceId);
                MessageBox.Show($"Đăng ký khám thành công cho bệnh nhân: {txtName.Text} !");
                txtSymptoms.Clear();
            }
            catch (Exception ex)
            {
                string message = ex.Message;

                if (ex.InnerException != null)
                {
                    message += "\nLỗi chi tiết: " + ex.InnerException.Message;
                }

                MessageBox.Show(message, "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Button tìm
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadPatients();
                return;
            }

            var resultList_ = _patientService.SearchPatient(keyword);
            dgvPatient.DataSource = resultList_;
            if (resultList_.Count == 0)
            {
                MessageBox.Show("Không tìm thấy bệnh nhân nào !");
            }
        }


        //Nhấn Enter để tìm
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                btnSearch.PerformClick();
                e.SuppressKeyPress = true;
            }
        }



        //Xóa các giá trị trong Textboxes
        private void ClearInputs()
        {
            txtID.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtYear.Clear();
            cboGender.SelectedIndex = 0;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cboService.SelectedIndex = 0;
            cboDoctor.SelectedIndex = 0;
            cboGender.SelectedIndex = 0;
            LoadPatients();
            ClearInputs();
            if (txtSymptoms != null) txtSymptoms.Clear();
        }
    }
}
