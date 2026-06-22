namespace GUI
{
    partial class frmPatient
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
            txtSearch = new TextBox();
            txtName = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtYear = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnReset = new Button();
            btnDelete = new Button();
            btnRegister = new Button();
            lblSearch = new Label();
            lblName = new Label();
            lblPhone = new Label();
            lblAddress = new Label();
            lblYear = new Label();
            lblCap = new Label();
            panel = new Panel();
            txtSymptoms = new TextBox();
            lblSymptoms = new Label();
            txtID = new TextBox();
            lblID = new Label();
            lblDoctor = new Label();
            cboDoctor = new ComboBox();
            cboService = new ComboBox();
            lblService = new Label();
            lblGender = new Label();
            cboGender = new ComboBox();
            dgvPatient = new DataGridView();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatient).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(982, 174);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(166, 30);
            txtSearch.TabIndex = 1;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // txtName
            // 
            txtName.Location = new Point(204, 106);
            txtName.Name = "txtName";
            txtName.Size = new Size(166, 30);
            txtName.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(404, 106);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(166, 30);
            txtPhone.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(596, 106);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(166, 30);
            txtAddress.TabIndex = 4;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(797, 106);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(166, 30);
            txtYear.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(25, 244);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(111, 42);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(254, 244);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(111, 42);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(506, 244);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(111, 42);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(1002, 244);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(111, 42);
            btnReset.TabIndex = 9;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(758, 244);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 42);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(910, 292);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(158, 68);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Đăng ký khám";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(982, 148);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(79, 23);
            lblSearch.TabIndex = 12;
            lblSearch.Text = "Tìm kiếm";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(204, 80);
            lblName.Name = "lblName";
            lblName.Size = new Size(84, 23);
            lblName.TabIndex = 13;
            lblName.Text = "Họ và tên";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(404, 80);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(111, 23);
            lblPhone.TabIndex = 14;
            lblPhone.Text = "Số điện thoại";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(596, 80);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 23);
            lblAddress.TabIndex = 15;
            lblAddress.Text = "Địa chỉ";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(797, 80);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(83, 23);
            lblYear.TabIndex = 16;
            lblYear.Text = "Năm sinh";
            // 
            // lblCap
            // 
            lblCap.Anchor = AnchorStyles.Top;
            lblCap.AutoSize = true;
            lblCap.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCap.Location = new Point(415, 4);
            lblCap.Name = "lblCap";
            lblCap.Size = new Size(340, 38);
            lblCap.TabIndex = 17;
            lblCap.Text = "PATIENT MANAGEMENT";
            lblCap.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel
            // 
            panel.Controls.Add(txtSymptoms);
            panel.Controls.Add(lblSymptoms);
            panel.Controls.Add(txtID);
            panel.Controls.Add(lblID);
            panel.Controls.Add(lblDoctor);
            panel.Controls.Add(cboDoctor);
            panel.Controls.Add(cboService);
            panel.Controls.Add(lblService);
            panel.Controls.Add(lblGender);
            panel.Controls.Add(cboGender);
            panel.Controls.Add(btnEdit);
            panel.Controls.Add(lblCap);
            panel.Controls.Add(txtSearch);
            panel.Controls.Add(lblYear);
            panel.Controls.Add(txtName);
            panel.Controls.Add(lblAddress);
            panel.Controls.Add(txtPhone);
            panel.Controls.Add(lblPhone);
            panel.Controls.Add(txtAddress);
            panel.Controls.Add(lblName);
            panel.Controls.Add(txtYear);
            panel.Controls.Add(lblSearch);
            panel.Controls.Add(btnSearch);
            panel.Controls.Add(btnRegister);
            panel.Controls.Add(btnAdd);
            panel.Controls.Add(btnDelete);
            panel.Controls.Add(btnReset);
            panel.Dock = DockStyle.Top;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(1182, 388);
            panel.TabIndex = 19;
            // 
            // txtSymptoms
            // 
            txtSymptoms.Location = new Point(12, 174);
            txtSymptoms.Name = "txtSymptoms";
            txtSymptoms.Size = new Size(166, 30);
            txtSymptoms.TabIndex = 26;
            // 
            // lblSymptoms
            // 
            lblSymptoms.AutoSize = true;
            lblSymptoms.Location = new Point(12, 148);
            lblSymptoms.Name = "lblSymptoms";
            lblSymptoms.Size = new Size(100, 23);
            lblSymptoms.TabIndex = 27;
            lblSymptoms.Text = "Triệu chứng";
            // 
            // txtID
            // 
            txtID.Location = new Point(12, 107);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(166, 30);
            txtID.TabIndex = 24;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(12, 81);
            lblID.Name = "lblID";
            lblID.Size = new Size(122, 23);
            lblID.TabIndex = 25;
            lblID.Text = "Mã bệnh nhân";
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDoctor.Location = new Point(124, 317);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(122, 23);
            lblDoctor.TabIndex = 23;
            lblDoctor.Text = "Chỉ định bác sĩ";
            // 
            // cboDoctor
            // 
            cboDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDoctor.FormattingEnabled = true;
            cboDoctor.Location = new Point(285, 314);
            cboDoctor.Name = "cboDoctor";
            cboDoctor.Size = new Size(166, 31);
            cboDoctor.TabIndex = 22;
            // 
            // cboService
            // 
            cboService.DropDownStyle = ComboBoxStyle.DropDownList;
            cboService.FormattingEnabled = true;
            cboService.Location = new Point(712, 314);
            cboService.Name = "cboService";
            cboService.Size = new Size(137, 31);
            cboService.TabIndex = 21;
            // 
            // lblService
            // 
            lblService.AutoSize = true;
            lblService.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblService.Location = new Point(520, 317);
            lblService.Name = "lblService";
            lblService.Size = new Size(160, 23);
            lblService.TabIndex = 20;
            lblService.Text = "Chọn dịch vụ khám";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(982, 80);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(75, 23);
            lblGender.TabIndex = 19;
            lblGender.Text = "Giới tính";
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(982, 106);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(166, 31);
            cboGender.TabIndex = 18;
            // 
            // dgvPatient
            // 
            dgvPatient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPatient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatient.Dock = DockStyle.Fill;
            dgvPatient.Location = new Point(0, 388);
            dgvPatient.Name = "dgvPatient";
            dgvPatient.RowHeadersWidth = 51;
            dgvPatient.Size = new Size(1182, 360);
            dgvPatient.TabIndex = 18;
            dgvPatient.CellClick += dgvPatient_CellClick;
            // 
            // frmPatient
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 748);
            Controls.Add(dgvPatient);
            Controls.Add(panel);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmPatient";
            Text = "Patient Center";
            WindowState = FormWindowState.Maximized;
            Load += frmPatient_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatient).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtSearch;
        private TextBox txtName;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtYear;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnReset;
        private Button btnDelete;
        private Button btnRegister;
        private Label lblSearch;
        private Label lblName;
        private Label lblPhone;
        private Label lblAddress;
        private Label lblYear;
        private Label lblCap;
        private Panel panel;
        private Label lblGender;
        private ComboBox cboGender;
        private DataGridView dgvPatient;
        private ComboBox cboService;
        private Label lblService;
        private Label lblDoctor;
        private ComboBox cboDoctor;
        private TextBox txtID;
        private Label lblID;
        private TextBox txtSymptoms;
        private Label lblSymptoms;
    }
}