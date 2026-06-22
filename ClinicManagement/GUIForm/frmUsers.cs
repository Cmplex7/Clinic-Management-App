using System;
using System.Windows.Forms;
using Entities;
using System.Linq;
using System.Collections.Generic;
using BLL.Implements;
using BLL;

namespace GUI
{
    public partial class frmUsers : Form
    {
        private UserService _service = new UserService();
        public frmUsers()
        {
            InitializeComponent();
        }

        //Load Form
        private void frmUsers_Load(object sender, EventArgs e)
        {
            try
            {
                LoadRolesBox();
                LoadFilterBox();
                LoadData(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        //Load thông tin lên DGV
        private void LoadData(List<User> list = null)
        {
            if (list == null)
            {
                bool showStopped = chkShowStopped.Checked;
                list = _service.GetAllUser(showStopped);
            }

            dgvHienThi.DataSource = list;

            string[] hideCols = { "Password", "RoleID", "Prescription", "MedicalRecords" };
            foreach (var col in hideCols)
            {
                if (dgvHienThi.Columns[col] != null) dgvHienThi.Columns[col].Visible = false;
            }

            if (dgvHienThi.Columns["IsActive"] != null) dgvHienThi.Columns["IsActive"].Visible = false;

            if (dgvHienThi.Columns["RoleID"] != null)
            {
                dgvHienThi.Columns["RoleID"].Visible = true;
                dgvHienThi.Columns["RoleID"].HeaderText = "Chức vụ";
                dgvHienThi.Columns["RoleID"].DisplayIndex = 3;
            }

            if (dgvHienThi.Columns["FullName"] != null) dgvHienThi.Columns["FullName"].HeaderText = "Họ và tên";
            if (dgvHienThi.Columns["UserName"] != null) dgvHienThi.Columns["UserName"].HeaderText = "Tên đăng nhập";
        }

        private void LoadRolesBox()
        {
            cboRole.DataSource = _service.GetRoles();
            cboRole.DisplayMember = "RoleName";
            cboRole.ValueMember = "RoleID";
        }


        //Combobox Chức vụ
        private void LoadFilterBox()
        {
            var roles = _service.GetRoles();

            Role allRole = new Role();
            allRole.RoleID = 0;
            allRole.RoleName = "Tất cả";

            roles.Insert(0, allRole);

            cboFilterRole.DataSource = roles;
            cboFilterRole.DisplayMember = "RoleName";
            cboFilterRole.ValueMember = "RoleID";
        }


        //Xóa thông tin trong các ô
        private void ClearInputs()
        {
            txtID.Clear();
            txtName.Clear();
            txtUsername.Clear();
            cboRole.SelectedIndex = 0;
            txtUsername.Enabled = true;

            btnDelete.Text = "Cho nghỉ việc";
            btnDelete.BackColor = DefaultBackColor;
            btnDelete.ForeColor = Color.Black;
        }

        private void dgvHienThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHienThi.Rows[e.RowIndex];
                txtID.Text = row.Cells["UserID"].Value.ToString();
                txtName.Text = row.Cells["FullName"].Value.ToString();
                txtUsername.Text = row.Cells["UserName"].Value.ToString();
                cboRole.SelectedValue = row.Cells["RoleID"].Value;

                if (row.Cells["IsActive"].Value != null)
                {
                    bool isActive = (bool)row.Cells["IsActive"].Value;
                    if (isActive)
                    {
                        btnDelete.Text = "Cho nghỉ việc";
                        btnDelete.BackColor = Color.IndianRed;
                        btnDelete.ForeColor = Color.White;
                    }
                    else
                    {
                        btnDelete.Text = "Khôi phục chức vụ";
                        btnDelete.BackColor = Color.ForestGreen;
                        btnDelete.ForeColor = Color.White;  
                    }
                }

            }
        }


        //Nút thêm
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên và tên đăng nhập!");
                return;
            }

            try
            {
                User u = new User()
                {
                    FullName = txtName.Text.Trim(),
                    UserName = txtUsername.Text.Trim(),
                    RoleID = (int)cboRole.SelectedValue,
                    IsActive = true
                };

                _service.AddUser(u);
                MessageBox.Show("Thêm thành công ! Mật khẩu mặc định: 123");

                chkShowStopped.Checked = false;
                LoadData();
                ClearInputs();
            }
            catch (Exception ex)
            {
                var currentEx = ex;
                string errorMessage = "Lỗi gốc: " + currentEx.Message;

                while (currentEx.InnerException != null)
                {
                    currentEx = currentEx.InnerException;
                    errorMessage += "\n----------------\nChi tiết: " + currentEx.Message;
                }

                MessageBox.Show(errorMessage, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadData();
            txtSearch.Clear();
            cboFilterRole.SelectedIndex = 0;
        }


        //Show chức vụ trong DGV
        private void dgvHienThi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvHienThi.Columns[e.ColumnIndex].Name == "Role" && e.Value != null)
            {
                var role = e.Value as Role;
                if (role != null)
                {
                    e.Value = role.RoleName;
                    e.FormattingApplied = true;
                }
            }

            if (dgvHienThi.Rows[e.RowIndex].Cells["IsActive"].Value != null)
            {
                bool isActive = (bool)dgvHienThi.Rows[e.RowIndex].Cells["IsActive"].Value;
                if (!isActive)
                {
                    e.CellStyle.ForeColor = Color.Gray;
                    e.CellStyle.Font = new Font(dgvHienThi.Font, FontStyle.Italic);
                    e.CellStyle.SelectionForeColor = Color.LightGray;
                }
            }
        }

        //Nút sửa
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text)) return;

            User u = new User()
            {
                UserID = int.Parse(txtID.Text),
                FullName = txtName.Text.Trim(),
                RoleID = (int)cboRole.SelectedValue,
                UserName = txtUsername.Text.Trim()
            };

            _service.UpdateUser(u);
            MessageBox.Show("Cập nhật thành công !");
            LoadData();
            ClearInputs();
        }


        //Nút xóa
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text)) return;

            int id = int.Parse(txtID.Text);
            string name = txtName.Text;

            if(btnDelete.Text == "Cho nghỉ việc")
            {
                if(MessageBox.Show($"Xác nhận cho nhân viên [{name}] nghỉ việc ?\n(Tài khoản này sẽ bị vô hiệu hóa",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    _service.SetUserStatus(id, false);
                    MessageBox.Show("Đã cập nhật trạng thái: Thôi việc");
                }
            }
            else
            {
                if(MessageBox.Show($"Xác nhận khôi phục chức vụ nhân viên [{name}] ?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _service.SetUserStatus(id, true);
                    MessageBox.Show("Đã khôi phục chức vụ cho nhân viên thành công !");
                }
            }

            LoadData(null);
            ClearInputs();
        }


        //Nút tìm kiếm
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadData(null);
            }
            else
            {
                var results = _service.SearchUsers(keyword);
                LoadData(results);
                if (results.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy nhân viên nào !");
                }
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        //Thay đổi combobox Roles
        private void cboFilterRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFilterRole.SelectedValue is int selectedRoleID)
            {
                if (selectedRoleID == 0)
                {
                    LoadData(null);
                }
                else
                {
                    var allUsers = _service.GetAllUser();
                    var filteredUsers = allUsers.Where(u => u.RoleID == selectedRoleID).ToList();
                    LoadData(filteredUsers);
                }
            }
        }

        private void chkShowStopped_CheckedChanged(object sender, EventArgs e)
        {
            LoadData(null);
            ClearInputs();
        }
    }
}
