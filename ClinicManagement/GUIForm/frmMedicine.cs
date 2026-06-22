using BLL.Implements;
using Entities;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMedicine : Form
    {
        //Khai báo services
        private MedicineService _medicineService = new MedicineService();
        private CategoryService _categoryService = new CategoryService();

        public frmMedicine()
        {
            InitializeComponent();
        }

        //Load form
        private void frmMedicine_Load(object sender, EventArgs e)
        {
            try
            {
                LoadCategories();
                LoadFilterCategory();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + ex.Message);
            }
        }

        //Nạp Combobox Loại thuốc
        private void LoadCategories()
        {
            var list = _categoryService.GetMedicineCategories();

            cboCategory.DataSource = list;
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "CategoryID";

            if (cboCategory.Items.Count > 0) cboCategory.SelectedIndex = 0;
        }

        //Hiển thị thuốc lên DGV
        private void LoadData()
        {
            dgvMedicine.DataSource = _medicineService.GetMedicines();
            SetUpGridView();
        }

        //Chỉnh bố cục GridView
        private void SetUpGridView()
        {
            if (dgvMedicine.Columns["CategoryID"] != null) dgvMedicine.Columns["CategoryID"].Visible = false;

            if (dgvMedicine.Columns["Category"] != null)
            {
                dgvMedicine.Columns["Category"].Visible = true;
                dgvMedicine.Columns["Category"].HeaderText = "Loại thuốc";
            }
            if (dgvMedicine.Columns["PrescriptionDetails"] != null) dgvMedicine.Columns["PrescriptionDetails"].Visible = false;

            dgvMedicine.Columns["MedicineID"].HeaderText = "Mã thuốc";
            dgvMedicine.Columns["MedicineName"].HeaderText = "Tên thuốc";
            dgvMedicine.Columns["Unit"].HeaderText = "Đơn vị";
            dgvMedicine.Columns["StockQuantity"].HeaderText = "Số lượng trong kho";

            dgvMedicine.Columns["ImportPrice"].HeaderText = "Giá nhập";
            dgvMedicine.Columns["ImportPrice"].DefaultCellStyle.Format = "N0";

            dgvMedicine.Columns["SellPrice"].HeaderText = "Giá bán";
            dgvMedicine.Columns["SellPrice"].DefaultCellStyle.Format = "N0";

            dgvMedicine.Columns["ExpiryDate"].HeaderText = "Hạn sử dụng";
        }



        private void dgvMedicine_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvMedicine.Columns[e.ColumnIndex].Name == "Category" && e.Value != null)
            {
                var cat = e.Value as Entities.MedicineCategory;
                if (cat != null)
                {
                    e.Value = cat.CategoryName;
                    e.FormattingApplied = true;
                }
            }
        }



        //Sự kiện CellClick
        private void dgvMedicine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            DataGridViewRow row = dgvMedicine.Rows[e.RowIndex];

            txtID.Text = row.Cells["MedicineID"].Value.ToString();
            txtName.Text = row.Cells["MedicineName"].Value.ToString();
            txtUnit.Text = row.Cells["Unit"].Value?.ToString();
            txtQuantity.Text = row.Cells["StockQuantity"].Value.ToString();

            txtImport.Text = row.Cells["ImportPrice"].Value.ToString();
            txtSell.Text = row.Cells["SellPrice"].Value.ToString();

            if (row.Cells["ExpiryDate"].Value != null)
            {
                dtpExpiry.Value = Convert.ToDateTime(row.Cells["ExpiryDate"].Value);
            }

            if (row.Cells["CategoryID"].Value != null)
            {
                cboCategory.SelectedValue = row.Cells["CategoryID"].Value;
            }
        }

        //Button Thêm
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtUnit.Text))
            {
                MessageBox.Show("Vui lòng nhập tên thuốc và Đơn vị !");
                return;
            }
            try
            {
                Medicine m = new Medicine();
                m.MedicineName = txtName.Text.Trim();
                m.Unit = txtUnit.Text.Trim();
                m.StockQuantity = int.Parse(txtSell.Text);
                m.ImportPrice = decimal.Parse(txtQuantity.Text);
                m.SellPrice = decimal.Parse(txtImport.Text);
                m.ExpiryDate = dtpExpiry.Value;

                m.CategoryID = (int)cboCategory.SelectedValue;
                _medicineService.AddMedicine(m);

                MessageBox.Show("Thêm thành công !");
                LoadData();
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
            if (string.IsNullOrEmpty(txtID.Text)) return;

            try
            {
                Medicine m = new Medicine();
                m.MedicineID = int.Parse(txtID.Text);
                m.MedicineName = txtName.Text.Trim();
                m.Unit = txtUnit.Text.Trim();
                m.StockQuantity = int.Parse(txtSell.Text);
                m.ImportPrice = decimal.Parse(txtQuantity.Text);
                m.SellPrice = decimal.Parse(txtImport.Text);
                m.ExpiryDate = dtpExpiry.Value;
                m.CategoryID = (int)cboCategory.SelectedValue;

                _medicineService.UpdateMedicine(m);

                MessageBox.Show("Cập nhật thành công !");
                LoadData();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }




        //Nút xóa
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text)) return;

            if (MessageBox.Show("Bạn có chắc muốn xóa thông tin này không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    int id = int.Parse(txtID.Text);
                    _medicineService.DeleteMedicine(id);
                    LoadData();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa: " + ex.Message);
                }
            }
        }



        //Nút tìm
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadData();
                return;
            }

            var resultList_ = _medicineService.SearchMedicine(keyword);
            dgvMedicine.DataSource = resultList_;
            if (resultList_.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thuốc nào có tên: " + keyword);
            }
        }


        //Enter để tìm
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                e.SuppressKeyPress = true;
            }
        }



        //Xóa giá trị trong các ô
        private void ClearInputs()
        {
            txtID.Clear();
            txtName.Clear();
            txtUnit.Clear();
            txtSell.Text = "0";
            txtQuantity.Text = "0";
            txtImport.Text = "0";
            dtpExpiry.Value = DateTime.Now;
            if (cboCategory.Items.Count > 0) cboCategory.SelectedIndex = 0;
        }




        //Load theo Category
        private void LoadFilterCategory()
        {
            var list = _categoryService.GetMedicineCategories();

            MedicineCategory allItems = new MedicineCategory();
            allItems.CategoryID = 0;
            allItems.CategoryName = "Tất cả";

            var filter = new List<MedicineCategory>();
            filter.Add(allItems);
            filter.AddRange(list);

            cboFilterCat.DataSource = filter;
            cboFilterCat.DisplayMember = "CategoryName";
            cboFilterCat.ValueMember = "CategoryID";

            cboFilterCat.SelectedIndex = 0;
        }




        //Chuyển index trong CBO
        private void cboFilterCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFilterCat.SelectedValue == null) return;

            try
            {
                int selectedID = 0;
                if (cboFilterCat.SelectedValue is int)
                {
                    selectedID = (int)cboFilterCat.SelectedValue;
                }
                else
                {
                    MedicineCategory item = cboFilterCat.SelectedItem as MedicineCategory;
                    selectedID = item.CategoryID;
                }

                if (selectedID == 0)
                {
                    LoadData();
                }
                else
                {
                    dgvMedicine.DataSource = _medicineService.GetByCategory(selectedID);
                }
            }
            catch (Exception ex)
            {

            }
        }


        //Nút Reset
        private void btnReset_Click(object sender, EventArgs e)
        {
            cboFilterCat.SelectedIndex = 0;
            LoadData();
            ClearInputs();
        }
    }
}
