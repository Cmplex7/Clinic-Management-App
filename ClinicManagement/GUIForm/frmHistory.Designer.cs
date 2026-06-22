namespace GUI.GUIForm
{
    partial class frmHistory
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
            btnRefresh = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblCap = new Label();
            splitter2 = new SplitContainer();
            gb1 = new GroupBox();
            dgvList = new DataGridView();
            splitter3 = new SplitContainer();
            gb2 = new GroupBox();
            dgvPrescriptionDetails = new DataGridView();
            gb3 = new GroupBox();
            dgvService = new DataGridView();
            lblSearch = new Label();
            ((System.ComponentModel.ISupportInitialize)splitter).BeginInit();
            splitter.Panel1.SuspendLayout();
            splitter.Panel2.SuspendLayout();
            splitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitter2).BeginInit();
            splitter2.Panel1.SuspendLayout();
            splitter2.Panel2.SuspendLayout();
            splitter2.SuspendLayout();
            gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitter3).BeginInit();
            splitter3.Panel1.SuspendLayout();
            splitter3.Panel2.SuspendLayout();
            splitter3.SuspendLayout();
            gb2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrescriptionDetails).BeginInit();
            gb3.SuspendLayout();
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
            splitter.Panel1.Controls.Add(lblSearch);
            splitter.Panel1.Controls.Add(btnRefresh);
            splitter.Panel1.Controls.Add(btnSearch);
            splitter.Panel1.Controls.Add(txtSearch);
            splitter.Panel1.Controls.Add(lblCap);
            // 
            // splitter.Panel2
            // 
            splitter.Panel2.Controls.Add(splitter2);
            splitter.Size = new Size(1182, 748);
            splitter.SplitterDistance = 201;
            splitter.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.Location = new Point(975, 116);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(97, 43);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(791, 116);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(97, 43);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(217, 116);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nhập tên hoặc SĐT";
            txtSearch.Size = new Size(348, 30);
            txtSearch.TabIndex = 4;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // lblCap
            // 
            lblCap.Anchor = AnchorStyles.Top;
            lblCap.AutoSize = true;
            lblCap.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCap.Location = new Point(433, 24);
            lblCap.Name = "lblCap";
            lblCap.Size = new Size(340, 38);
            lblCap.TabIndex = 3;
            lblCap.Text = "EXAMINATION HISTORY";
            // 
            // splitter2
            // 
            splitter2.Dock = DockStyle.Fill;
            splitter2.Location = new Point(0, 0);
            splitter2.Name = "splitter2";
            // 
            // splitter2.Panel1
            // 
            splitter2.Panel1.Controls.Add(gb1);
            // 
            // splitter2.Panel2
            // 
            splitter2.Panel2.Controls.Add(splitter3);
            splitter2.Size = new Size(1182, 543);
            splitter2.SplitterDistance = 601;
            splitter2.TabIndex = 0;
            // 
            // gb1
            // 
            gb1.Controls.Add(dgvList);
            gb1.Dock = DockStyle.Fill;
            gb1.Location = new Point(0, 0);
            gb1.Name = "gb1";
            gb1.Size = new Size(601, 543);
            gb1.TabIndex = 0;
            gb1.TabStop = false;
            gb1.Text = "Danh sách khám bệnh";
            // 
            // dgvList
            // 
            dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Dock = DockStyle.Fill;
            dgvList.Location = new Point(3, 26);
            dgvList.Name = "dgvList";
            dgvList.ReadOnly = true;
            dgvList.RowHeadersWidth = 51;
            dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvList.Size = new Size(595, 514);
            dgvList.TabIndex = 0;
            dgvList.CellClick += dgvList_CellClick;
            // 
            // splitter3
            // 
            splitter3.Dock = DockStyle.Fill;
            splitter3.Location = new Point(0, 0);
            splitter3.Name = "splitter3";
            splitter3.Orientation = Orientation.Horizontal;
            // 
            // splitter3.Panel1
            // 
            splitter3.Panel1.Controls.Add(gb2);
            // 
            // splitter3.Panel2
            // 
            splitter3.Panel2.Controls.Add(gb3);
            splitter3.Size = new Size(577, 543);
            splitter3.SplitterDistance = 264;
            splitter3.TabIndex = 0;
            // 
            // gb2
            // 
            gb2.Controls.Add(dgvPrescriptionDetails);
            gb2.Dock = DockStyle.Fill;
            gb2.Location = new Point(0, 0);
            gb2.Name = "gb2";
            gb2.Size = new Size(577, 264);
            gb2.TabIndex = 0;
            gb2.TabStop = false;
            gb2.Text = "Chi tiết đơn thuốc";
            // 
            // dgvPrescriptionDetails
            // 
            dgvPrescriptionDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrescriptionDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrescriptionDetails.Dock = DockStyle.Fill;
            dgvPrescriptionDetails.Location = new Point(3, 26);
            dgvPrescriptionDetails.Name = "dgvPrescriptionDetails";
            dgvPrescriptionDetails.ReadOnly = true;
            dgvPrescriptionDetails.RowHeadersWidth = 51;
            dgvPrescriptionDetails.Size = new Size(571, 235);
            dgvPrescriptionDetails.TabIndex = 0;
            // 
            // gb3
            // 
            gb3.Controls.Add(dgvService);
            gb3.Dock = DockStyle.Fill;
            gb3.Location = new Point(0, 0);
            gb3.Name = "gb3";
            gb3.Size = new Size(577, 275);
            gb3.TabIndex = 0;
            gb3.TabStop = false;
            gb3.Text = "Dịch vụ khám";
            // 
            // dgvService
            // 
            dgvService.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvService.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvService.Dock = DockStyle.Fill;
            dgvService.Location = new Point(3, 26);
            dgvService.Name = "dgvService";
            dgvService.ReadOnly = true;
            dgvService.RowHeadersWidth = 51;
            dgvService.Size = new Size(571, 246);
            dgvService.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(104, 119);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(79, 23);
            lblSearch.TabIndex = 7;
            lblSearch.Text = "Tìm kiếm";
            // 
            // frmHistory
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 748);
            Controls.Add(splitter);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmHistory";
            Text = "Examination History";
            WindowState = FormWindowState.Maximized;
            Load += frmHistory_Load;
            splitter.Panel1.ResumeLayout(false);
            splitter.Panel1.PerformLayout();
            splitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitter).EndInit();
            splitter.ResumeLayout(false);
            splitter2.Panel1.ResumeLayout(false);
            splitter2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitter2).EndInit();
            splitter2.ResumeLayout(false);
            gb1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            splitter3.Panel1.ResumeLayout(false);
            splitter3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitter3).EndInit();
            splitter3.ResumeLayout(false);
            gb2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPrescriptionDetails).EndInit();
            gb3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvService).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitter;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label lblCap;
        private SplitContainer splitter2;
        private SplitContainer splitter3;
        private GroupBox gb1;
        private DataGridView dgvList;
        private GroupBox gb2;
        private DataGridView dgvPrescriptionDetails;
        private GroupBox gb3;
        private DataGridView dgvService;
        private Button btnRefresh;
        private Label lblSearch;
    }
}