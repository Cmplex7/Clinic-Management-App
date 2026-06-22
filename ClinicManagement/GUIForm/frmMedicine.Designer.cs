namespace GUI
{
    partial class frmMedicine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboFilterCat = new ComboBox();
            lblCap = new Label();
            btnEdit = new Button();
            dgvMedicine = new DataGridView();
            txtName = new TextBox();
            lblSearch = new Label();
            lblRole = new Label();
            btnDelete = new Button();
            lblID = new Label();
            cboCategory = new ComboBox();
            txtID = new TextBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            lblName = new Label();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            btnReset = new Button();
            panel1 = new Panel();
            lblUnit = new Label();
            txtUnit = new TextBox();
            dtpExpiry = new DateTimePicker();
            lblExpiry = new Label();
            lblSellPrice = new Label();
            txtSell = new TextBox();
            lblImport = new Label();
            txtImport = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMedicine).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cboFilterCat
            // 
            cboFilterCat.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterCat.FormattingEnabled = true;
            cboFilterCat.Location = new Point(8, 396);
            cboFilterCat.Name = "cboFilterCat";
            cboFilterCat.Size = new Size(190, 31);
            cboFilterCat.TabIndex = 10;
            cboFilterCat.SelectedIndexChanged += cboFilterCat_SelectedIndexChanged;
            // 
            // lblCap
            // 
            lblCap.Anchor = AnchorStyles.Top;
            lblCap.AutoSize = true;
            lblCap.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCap.Location = new Point(395, 47);
            lblCap.Name = "lblCap";
            lblCap.Size = new Size(364, 38);
            lblCap.TabIndex = 8;
            lblCap.Text = "MEDICINE MANAGEMENT";
            lblCap.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(471, 322);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(125, 48);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // dgvMedicine
            // 
            dgvMedicine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedicine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicine.Dock = DockStyle.Fill;
            dgvMedicine.Location = new Point(0, 442);
            dgvMedicine.Name = "dgvMedicine";
            dgvMedicine.RowHeadersWidth = 51;
            dgvMedicine.Size = new Size(1182, 306);
            dgvMedicine.TabIndex = 19;
            dgvMedicine.CellClick += dgvMedicine_CellClick;
            dgvMedicine.CellFormatting += dgvMedicine_CellFormatting;
            // 
            // txtName
            // 
            txtName.Location = new Point(482, 147);
            txtName.Name = "txtName";
            txtName.Size = new Size(190, 30);
            txtName.TabIndex = 6;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(34, 112);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(79, 23);
            lblSearch.TabIndex = 17;
            lblSearch.Text = "Tìm kiếm";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(977, 201);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(90, 23);
            lblRole.TabIndex = 4;
            lblRole.Text = "Loại thuốc";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(727, 322);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 48);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(264, 110);
            lblID.Name = "lblID";
            lblID.Size = new Size(83, 23);
            lblID.TabIndex = 0;
            lblID.Text = "Mã thuốc";
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(977, 237);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(190, 31);
            cboCategory.TabIndex = 3;
            // 
            // txtID
            // 
            txtID.Location = new Point(264, 149);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(190, 30);
            txtID.TabIndex = 5;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(34, 151);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(190, 30);
            txtSearch.TabIndex = 16;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(33, 322);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(125, 48);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(228, 322);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 48);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(482, 108);
            lblName.Name = "lblName";
            lblName.Size = new Size(85, 23);
            lblName.TabIndex = 1;
            lblName.Text = "Tên thuốc";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(718, 110);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(78, 23);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Số lượng";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(718, 149);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(190, 30);
            txtQuantity.TabIndex = 7;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(977, 322);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(125, 48);
            btnReset.TabIndex = 15;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblUnit);
            panel1.Controls.Add(txtUnit);
            panel1.Controls.Add(dtpExpiry);
            panel1.Controls.Add(lblExpiry);
            panel1.Controls.Add(lblSellPrice);
            panel1.Controls.Add(txtSell);
            panel1.Controls.Add(lblImport);
            panel1.Controls.Add(txtImport);
            panel1.Controls.Add(cboFilterCat);
            panel1.Controls.Add(lblCap);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(lblSearch);
            panel1.Controls.Add(lblRole);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(lblID);
            panel1.Controls.Add(cboCategory);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(lblQuantity);
            panel1.Controls.Add(txtQuantity);
            panel1.Controls.Add(btnReset);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 442);
            panel1.TabIndex = 20;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Location = new Point(718, 202);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(59, 23);
            lblUnit.TabIndex = 24;
            lblUnit.Text = "Đơn vị";
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(718, 241);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(190, 30);
            txtUnit.TabIndex = 25;
            // 
            // dtpExpiry
            // 
            dtpExpiry.Format = DateTimePickerFormat.Short;
            dtpExpiry.Location = new Point(482, 238);
            dtpExpiry.Name = "dtpExpiry";
            dtpExpiry.Size = new Size(190, 30);
            dtpExpiry.TabIndex = 23;
            // 
            // lblExpiry
            // 
            lblExpiry.AutoSize = true;
            lblExpiry.Location = new Point(482, 198);
            lblExpiry.Name = "lblExpiry";
            lblExpiry.Size = new Size(108, 23);
            lblExpiry.TabIndex = 22;
            lblExpiry.Text = "Hạn sử dụng";
            // 
            // lblSellPrice
            // 
            lblSellPrice.AutoSize = true;
            lblSellPrice.Location = new Point(264, 199);
            lblSellPrice.Name = "lblSellPrice";
            lblSellPrice.Size = new Size(69, 23);
            lblSellPrice.TabIndex = 20;
            lblSellPrice.Text = "Giá bán";
            // 
            // txtSell
            // 
            txtSell.Location = new Point(264, 238);
            txtSell.Name = "txtSell";
            txtSell.Size = new Size(190, 30);
            txtSell.TabIndex = 21;
            // 
            // lblImport
            // 
            lblImport.AutoSize = true;
            lblImport.Location = new Point(48, 203);
            lblImport.Name = "lblImport";
            lblImport.Size = new Size(79, 23);
            lblImport.TabIndex = 18;
            lblImport.Text = "Giá nhập";
            // 
            // txtImport
            // 
            txtImport.Location = new Point(37, 242);
            txtImport.Name = "txtImport";
            txtImport.Size = new Size(187, 30);
            txtImport.TabIndex = 19;
            // 
            // frmMedicine
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 748);
            Controls.Add(dgvMedicine);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmMedicine";
            Text = "Medicine Center";
            WindowState = FormWindowState.Maximized;
            Load += frmMedicine_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMedicine).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboFilterCat;
        private Label lblCap;
        private Button btnEdit;
        private DataGridView dgvMedicine;
        private TextBox txtName;
        private Label lblSearch;
        private Label lblRole;
        private Button btnDelete;
        private Label lblID;
        private ComboBox cboCategory;
        private TextBox txtID;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnAdd;
        private Label lblName;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private Button btnReset;
        private Panel panel1;
        private Label lblImport;
        private TextBox txtImport;
        private Label lblSellPrice;
        private TextBox txtSell;
        private DateTimePicker dtpExpiry;
        private Label lblExpiry;
        private Label lblUnit;
        private TextBox txtUnit;
    }
}