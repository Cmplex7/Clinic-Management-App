namespace GUI
{
    partial class frmServiceManagement
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
            splitter = new SplitContainer();
            btnReset = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            lblCap = new Label();
            txtServicePrice = new TextBox();
            txtServiceName = new TextBox();
            txtServiceID = new TextBox();
            lblServicePrice = new Label();
            lblServiceName = new Label();
            lblServiceID = new Label();
            dgvService = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitter).BeginInit();
            splitter.Panel1.SuspendLayout();
            splitter.Panel2.SuspendLayout();
            splitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvService).BeginInit();
            SuspendLayout();
            // 
            // splitter
            // 
            splitter.Dock = DockStyle.Fill;
            splitter.Location = new Point(0, 0);
            splitter.Name = "splitter";
            splitter.Orientation = Orientation.Horizontal;
            // 
            // splitter.Panel1
            // 
            splitter.Panel1.Controls.Add(btnReset);
            splitter.Panel1.Controls.Add(btnDelete);
            splitter.Panel1.Controls.Add(btnEdit);
            splitter.Panel1.Controls.Add(btnAdd);
            splitter.Panel1.Controls.Add(btnSearch);
            splitter.Panel1.Controls.Add(txtSearch);
            splitter.Panel1.Controls.Add(lblSearch);
            splitter.Panel1.Controls.Add(lblCap);
            splitter.Panel1.Controls.Add(txtServicePrice);
            splitter.Panel1.Controls.Add(txtServiceName);
            splitter.Panel1.Controls.Add(txtServiceID);
            splitter.Panel1.Controls.Add(lblServicePrice);
            splitter.Panel1.Controls.Add(lblServiceName);
            splitter.Panel1.Controls.Add(lblServiceID);
            // 
            // splitter.Panel2
            // 
            splitter.Panel2.Controls.Add(dgvService);
            splitter.Size = new Size(1182, 748);
            splitter.SplitterDistance = 333;
            splitter.TabIndex = 0;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(975, 219);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(118, 46);
            btnReset.TabIndex = 13;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(741, 219);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(118, 46);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(502, 219);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(118, 46);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(257, 219);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(118, 46);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(12, 219);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(118, 46);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 132);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(190, 30);
            txtSearch.TabIndex = 8;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10.8F);
            lblSearch.Location = new Point(12, 104);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(84, 25);
            lblSearch.TabIndex = 7;
            lblSearch.Text = "Tìm kiếm";
            // 
            // lblCap
            // 
            lblCap.Anchor = AnchorStyles.Top;
            lblCap.AutoSize = true;
            lblCap.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCap.ImageAlign = ContentAlignment.BottomRight;
            lblCap.Location = new Point(451, 36);
            lblCap.Name = "lblCap";
            lblCap.Size = new Size(318, 38);
            lblCap.TabIndex = 6;
            lblCap.Text = "SERVICE MANGEMENT";
            // 
            // txtServicePrice
            // 
            txtServicePrice.Location = new Point(952, 132);
            txtServicePrice.Name = "txtServicePrice";
            txtServicePrice.Size = new Size(196, 30);
            txtServicePrice.TabIndex = 5;
            // 
            // txtServiceName
            // 
            txtServiceName.Location = new Point(614, 132);
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new Size(224, 30);
            txtServiceName.TabIndex = 4;
            // 
            // txtServiceID
            // 
            txtServiceID.Location = new Point(296, 132);
            txtServiceID.Name = "txtServiceID";
            txtServiceID.ReadOnly = true;
            txtServiceID.Size = new Size(190, 30);
            txtServiceID.TabIndex = 3;
            // 
            // lblServicePrice
            // 
            lblServicePrice.AutoSize = true;
            lblServicePrice.Font = new Font("Segoe UI", 10.8F);
            lblServicePrice.Location = new Point(952, 104);
            lblServicePrice.Name = "lblServicePrice";
            lblServicePrice.Size = new Size(71, 25);
            lblServicePrice.TabIndex = 2;
            lblServicePrice.Text = "Giá tiền";
            // 
            // lblServiceName
            // 
            lblServiceName.AutoSize = true;
            lblServiceName.Font = new Font("Segoe UI", 10.8F);
            lblServiceName.Location = new Point(614, 104);
            lblServiceName.Name = "lblServiceName";
            lblServiceName.Size = new Size(100, 25);
            lblServiceName.TabIndex = 1;
            lblServiceName.Text = "Tên dịch vụ";
            // 
            // lblServiceID
            // 
            lblServiceID.AutoSize = true;
            lblServiceID.Font = new Font("Segoe UI", 10.8F);
            lblServiceID.Location = new Point(296, 104);
            lblServiceID.Name = "lblServiceID";
            lblServiceID.Size = new Size(99, 25);
            lblServiceID.TabIndex = 0;
            lblServiceID.Text = "Mã dịch vụ";
            // 
            // dgvService
            // 
            dgvService.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvService.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvService.Dock = DockStyle.Fill;
            dgvService.Location = new Point(0, 0);
            dgvService.Name = "dgvService";
            dgvService.RowHeadersWidth = 51;
            dgvService.Size = new Size(1182, 411);
            dgvService.TabIndex = 0;
            dgvService.CellClick += dgvService_CellClick;
            // 
            // frmServiceManagement
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 748);
            Controls.Add(splitter);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmServiceManagement";
            Text = "Service Center";
            WindowState = FormWindowState.Maximized;
            Load += frmServiceManagemrnt_Load;
            splitter.Panel1.ResumeLayout(false);
            splitter.Panel1.PerformLayout();
            splitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitter).EndInit();
            splitter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvService).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitter;
        private TextBox txtSearch;
        private Label lblSearch;
        private Label lblCap;
        private TextBox txtServicePrice;
        private TextBox txtServiceName;
        private TextBox txtServiceID;
        private Label lblServicePrice;
        private Label lblServiceName;
        private Label lblServiceID;
        private DataGridView dgvService;
        private Button btnReset;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnSearch;
    }
}