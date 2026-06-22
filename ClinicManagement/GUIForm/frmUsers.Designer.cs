namespace GUI
{
    partial class frmUsers
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
            dgvHienThi = new DataGridView();
            btnReset = new Button();
            txtUsername = new TextBox();
            lblUsername = new Label();
            lblName = new Label();
            btnAdd = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            txtID = new TextBox();
            cboRole = new ComboBox();
            lblID = new Label();
            btnDelete = new Button();
            lblRole = new Label();
            lblSearch = new Label();
            btnEdit = new Button();
            txtName = new TextBox();
            lblCap = new Label();
            cboFilterRole = new ComboBox();
            panel1 = new Panel();
            chkShowStopped = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvHienThi).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvHienThi
            // 
            dgvHienThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHienThi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHienThi.Dock = DockStyle.Fill;
            dgvHienThi.Location = new Point(0, 358);
            dgvHienThi.Name = "dgvHienThi";
            dgvHienThi.RowHeadersWidth = 51;
            dgvHienThi.Size = new Size(1182, 390);
            dgvHienThi.TabIndex = 9;
            dgvHienThi.CellClick += dgvHienThi_CellClick;
            dgvHienThi.CellFormatting += dgvHienThi_CellFormatting;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(984, 231);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(111, 42);
            btnReset.TabIndex = 15;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(735, 163);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(199, 30);
            txtUsername.TabIndex = 7;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(735, 118);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(124, 23);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Tên đăng nhập";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(509, 118);
            lblName.Name = "lblName";
            lblName.Size = new Size(84, 23);
            lblName.TabIndex = 1;
            lblName.Text = "Họ và tên";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(260, 231);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(111, 42);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(28, 231);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(111, 42);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(28, 163);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(178, 30);
            txtSearch.TabIndex = 16;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // txtID
            // 
            txtID.Location = new Point(260, 162);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(160, 30);
            txtID.TabIndex = 5;
            // 
            // cboRole
            // 
            cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRole.FormattingEnabled = true;
            cboRole.Location = new Point(984, 162);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(169, 31);
            cboRole.TabIndex = 3;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(260, 118);
            lblID.Name = "lblID";
            lblID.Size = new Size(114, 23);
            lblID.TabIndex = 0;
            lblID.Text = "Mã nhân viên";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(735, 231);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(162, 42);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Cho nghỉ việc";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(984, 118);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(72, 23);
            lblRole.TabIndex = 4;
            lblRole.Text = "Chức vụ";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(28, 118);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(79, 23);
            lblSearch.TabIndex = 17;
            lblSearch.Text = "Tìm kiếm";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(509, 231);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(111, 42);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(509, 163);
            txtName.Name = "txtName";
            txtName.Size = new Size(178, 30);
            txtName.TabIndex = 6;
            // 
            // lblCap
            // 
            lblCap.Anchor = AnchorStyles.Top;
            lblCap.AutoSize = true;
            lblCap.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCap.Location = new Point(454, 30);
            lblCap.Name = "lblCap";
            lblCap.Size = new Size(309, 38);
            lblCap.TabIndex = 8;
            lblCap.Text = "STAFF MANAGEMENT";
            lblCap.TextAlign = ContentAlignment.TopCenter;
            // 
            // cboFilterRole
            // 
            cboFilterRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterRole.FormattingEnabled = true;
            cboFilterRole.Location = new Point(28, 314);
            cboFilterRole.Name = "cboFilterRole";
            cboFilterRole.Size = new Size(169, 31);
            cboFilterRole.TabIndex = 10;
            cboFilterRole.SelectedIndexChanged += cboFilterRole_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(chkShowStopped);
            panel1.Controls.Add(cboFilterRole);
            panel1.Controls.Add(lblCap);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(lblSearch);
            panel1.Controls.Add(lblRole);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(lblID);
            panel1.Controls.Add(cboRole);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(btnReset);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 358);
            panel1.TabIndex = 18;
            // 
            // chkShowStopped
            // 
            chkShowStopped.AutoSize = true;
            chkShowStopped.Location = new Point(901, 318);
            chkShowStopped.Name = "chkShowStopped";
            chkShowStopped.Size = new Size(269, 27);
            chkShowStopped.TabIndex = 18;
            chkShowStopped.Text = "Hiển thị nhân viên đã nghỉ việc";
            chkShowStopped.UseVisualStyleBackColor = true;
            chkShowStopped.CheckedChanged += chkShowStopped_CheckedChanged;
            // 
            // frmUsers
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 748);
            Controls.Add(dgvHienThi);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmUsers";
            Text = "Admin Center";
            WindowState = FormWindowState.Maximized;
            Load += frmUsers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHienThi).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvHienThi;
        private Button btnReset;
        private TextBox txtUsername;
        private Label lblUsername;
        private Label lblName;
        private Button btnAdd;
        private Button btnSearch;
        private TextBox txtSearch;
        private TextBox txtID;
        private ComboBox cboRole;
        private Label lblID;
        private Button btnDelete;
        private Label lblRole;
        private Label lblSearch;
        private Button btnEdit;
        private TextBox txtName;
        private Label lblCap;
        private ComboBox cboFilterRole;
        private Panel panel1;
        private CheckBox chkShowStopped;
    }
}