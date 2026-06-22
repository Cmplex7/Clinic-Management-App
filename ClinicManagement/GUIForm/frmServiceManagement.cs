using BLL.Implements;
using Entities;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmServiceManagement : Form
    {
        private ServiceManagement _service = new ServiceManagement();

        public frmServiceManagement()
        {
            InitializeComponent();
        }

        private void frmServiceManagemrnt_Load(object sender, EventArgs e)
        {
            LoadServiceList();
            FormatGrid();
        }


        //Load danh sách dịch vụ
        private void LoadServiceList()
        {
            dgvService.DataSource = _service.GetAllServices();
        }


        private void FormatGrid()
        {
            if (dgvService.Columns.Count > 0)
            {
                if (dgvService.Columns["ServiceID"] != null)
                    dgvService.Columns["ServiceID"].Visible = false;

                if (dgvService.Columns["ServiceName"] != null)
                {
                    dgvService.Columns["ServiceName"].HeaderText = "Tên dịch vụ";
                }

                if (dgvService.Columns["Price"] != null)
                {
                    dgvService.Columns["Price"].HeaderText = "Giá tiền (VNĐ)";
                    dgvService.Columns["Price"].DefaultCellStyle.Format = "N0";
                    dgvService.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
        }

        private void dgvService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvService.Rows[e.RowIndex];
            txtServiceID.Text = row.Cells["ServiceID"].Value.ToString();
            txtServiceName.Text = row.Cells["ServiceName"].Value.ToString();

            if (row.Cells["Price"].Value != null)
            {
                decimal price = (decimal)row.Cells["Price"].Value;
                txtServicePrice.Text = price.ToString("0");
            }
        }


        //Button thêm
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput() == false) return;

            try
            {
                Service s = new Service();
                s.ServiceName = txtServiceName.Text.Trim();
                s.Price = decimal.Parse(txtServicePrice.Text);

                _service.AddServices(s);

                MessageBox.Show("Thêm dịch vụ thành công !", "Thông báo");
                LoadServiceList();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }



        //Button sửa
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtServiceID.Text))
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần sửa !", "Thông báo");
                return;
            }

            if (ValidateInput() == false) return;

            try
            {
                Service s = new Service();
                s.ServiceID = int.Parse(txtServiceID.Text);
                s.ServiceName = txtServiceName.Text.Trim();
                s.Price = decimal.Parse(txtServicePrice.Text);

                _service.UpdateServices(s);

                MessageBox.Show("Cập nhật thành công !", "Thông báo");
                LoadServiceList();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }




        //Button Xóa
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtServiceID.Text))
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần xóa !");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dịch vụ này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    int id = int.Parse(txtServiceID.Text);
                    _service.DeleteServices(id);

                    MessageBox.Show("Đã xóa dịch vụ!", "Thông báo");
                    LoadServiceList();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa: " + ex.Message);
                }
            }
        }




        //Button tìm kiếm
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            var _resultList = _service.SearchServices(keyword);

            dgvService.DataSource = _resultList;

            if (_resultList.Count == 0)
            {
                MessageBox.Show($"Không tìm thấy dịch vụ nào có tên: {keyword} !");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadServiceList();
        }


        private void ClearInputs()
        {
            txtServiceID.Clear();
            txtServiceName.Clear();
            txtServicePrice.Clear();
            txtSearch.Clear();
            txtServiceName.Focus();
        }


        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtServiceName.Text))
            {
                MessageBox.Show("Tên dịch vụ không được để trống !");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtServicePrice.Text) || !decimal.TryParse(txtServicePrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Giá tiền phải là số và không âm !");
                return false;
            }
            return true;
        }


        //Nhấn enter để tìm kiếm
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
