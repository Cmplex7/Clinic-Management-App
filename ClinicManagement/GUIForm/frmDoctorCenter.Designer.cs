namespace GUI.GUIForm
{
    partial class frmDoctorCenter
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
            split1 = new SplitContainer();
            gb1 = new GroupBox();
            dgvWaitingList = new DataGridView();
            split2 = new SplitContainer();
            btnDelete = new Button();
            lblCurrent = new Label();
            lblCap1 = new Label();
            txtDiagnosis = new TextBox();
            lblDiagnosis = new Label();
            lblUnit = new Label();
            lblQuantity = new Label();
            lblUsage = new Label();
            label1 = new Label();
            btnAdd = new Button();
            txtUsage = new TextBox();
            txtUnit = new TextBox();
            numQuantity = new NumericUpDown();
            cboDrug = new ComboBox();
            panel1 = new Panel();
            btnFinished = new Button();
            lblTotal = new Label();
            dgvPrescription = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)split1).BeginInit();
            split1.Panel1.SuspendLayout();
            split1.Panel2.SuspendLayout();
            split1.SuspendLayout();
            gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWaitingList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)split2).BeginInit();
            split2.Panel1.SuspendLayout();
            split2.Panel2.SuspendLayout();
            split2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrescription).BeginInit();
            SuspendLayout();
            // 
            // split1
            // 
            split1.Dock = DockStyle.Fill;
            split1.Location = new Point(0, 0);
            split1.Name = "split1";
            // 
            // split1.Panel1
            // 
            split1.Panel1.Controls.Add(gb1);
            // 
            // split1.Panel2
            // 
            split1.Panel2.Controls.Add(split2);
            split1.Size = new Size(1282, 928);
            split1.SplitterDistance = 411;
            split1.TabIndex = 0;
            // 
            // gb1
            // 
            gb1.Controls.Add(dgvWaitingList);
            gb1.Dock = DockStyle.Fill;
            gb1.Location = new Point(0, 0);
            gb1.Name = "gb1";
            gb1.Size = new Size(411, 928);
            gb1.TabIndex = 0;
            gb1.TabStop = false;
            gb1.Text = "DANH SÁCH CHỜ";
            // 
            // dgvWaitingList
            // 
            dgvWaitingList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvWaitingList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWaitingList.Dock = DockStyle.Fill;
            dgvWaitingList.Location = new Point(3, 23);
            dgvWaitingList.Name = "dgvWaitingList";
            dgvWaitingList.RowHeadersWidth = 51;
            dgvWaitingList.Size = new Size(405, 902);
            dgvWaitingList.TabIndex = 0;
            dgvWaitingList.CellClick += dgvWaitingList_CellClick;
            // 
            // split2
            // 
            split2.Dock = DockStyle.Fill;
            split2.Location = new Point(0, 0);
            split2.Name = "split2";
            split2.Orientation = Orientation.Horizontal;
            // 
            // split2.Panel1
            // 
            split2.Panel1.Controls.Add(btnDelete);
            split2.Panel1.Controls.Add(lblCurrent);
            split2.Panel1.Controls.Add(lblCap1);
            split2.Panel1.Controls.Add(txtDiagnosis);
            split2.Panel1.Controls.Add(lblDiagnosis);
            split2.Panel1.Controls.Add(lblUnit);
            split2.Panel1.Controls.Add(lblQuantity);
            split2.Panel1.Controls.Add(lblUsage);
            split2.Panel1.Controls.Add(label1);
            split2.Panel1.Controls.Add(btnAdd);
            split2.Panel1.Controls.Add(txtUsage);
            split2.Panel1.Controls.Add(txtUnit);
            split2.Panel1.Controls.Add(numQuantity);
            split2.Panel1.Controls.Add(cboDrug);
            // 
            // split2.Panel2
            // 
            split2.Panel2.Controls.Add(panel1);
            split2.Panel2.Controls.Add(dgvPrescription);
            split2.Size = new Size(867, 928);
            split2.SplitterDistance = 252;
            split2.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(648, 130);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(91, 44);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblCurrent
            // 
            lblCurrent.AutoSize = true;
            lblCurrent.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCurrent.Location = new Point(34, 66);
            lblCurrent.Name = "lblCurrent";
            lblCurrent.Size = new Size(252, 31);
            lblCurrent.TabIndex = 12;
            lblCurrent.Text = "Bệnh nhân đang khám:";
            // 
            // lblCap1
            // 
            lblCap1.AutoSize = true;
            lblCap1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCap1.Location = new Point(401, 23);
            lblCap1.Name = "lblCap1";
            lblCap1.Size = new Size(152, 31);
            lblCap1.TabIndex = 11;
            lblCap1.Text = "ĐƠN THUỐC";
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Location = new Point(34, 140);
            txtDiagnosis.Multiline = true;
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.Size = new Size(207, 34);
            txtDiagnosis.TabIndex = 10;
            // 
            // lblDiagnosis
            // 
            lblDiagnosis.AutoSize = true;
            lblDiagnosis.Location = new Point(34, 118);
            lblDiagnosis.Name = "lblDiagnosis";
            lblDiagnosis.Size = new Size(80, 20);
            lblDiagnosis.TabIndex = 9;
            lblDiagnosis.Text = "Chẩn đoán";
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Location = new Point(220, 182);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(52, 20);
            lblUnit.TabIndex = 8;
            lblUnit.Text = "Đơn vị";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(35, 184);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(69, 20);
            lblQuantity.TabIndex = 7;
            lblQuantity.Text = "Số lượng";
            // 
            // lblUsage
            // 
            lblUsage.AutoSize = true;
            lblUsage.Location = new Point(367, 182);
            lblUsage.Name = "lblUsage";
            lblUsage.Size = new Size(79, 20);
            lblUsage.TabIndex = 6;
            lblUsage.Text = "Cách dùng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(262, 117);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 5;
            label1.Text = "Chọn loại thuốc";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(523, 131);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(91, 44);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtUsage
            // 
            txtUsage.Location = new Point(367, 207);
            txtUsage.Multiline = true;
            txtUsage.Name = "txtUsage";
            txtUsage.Size = new Size(186, 27);
            txtUsage.TabIndex = 3;
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(220, 207);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(125, 27);
            txtUnit.TabIndex = 2;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(35, 207);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(150, 27);
            numQuantity.TabIndex = 1;
            // 
            // cboDrug
            // 
            cboDrug.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDrug.FormattingEnabled = true;
            cboDrug.Location = new Point(262, 140);
            cboDrug.Name = "cboDrug";
            cboDrug.Size = new Size(202, 28);
            cboDrug.TabIndex = 0;
            cboDrug.SelectedIndexChanged += cboDrug_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnFinished);
            panel1.Controls.Add(lblTotal);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 635);
            panel1.Name = "panel1";
            panel1.Size = new Size(867, 37);
            panel1.TabIndex = 0;
            // 
            // btnFinished
            // 
            btnFinished.Dock = DockStyle.Right;
            btnFinished.Location = new Point(773, 0);
            btnFinished.Name = "btnFinished";
            btnFinished.Size = new Size(94, 37);
            btnFinished.TabIndex = 2;
            btnFinished.Text = "Hoàn tất";
            btnFinished.UseVisualStyleBackColor = true;
            btnFinished.Click += btnFinished_Click;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(3, 10);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(94, 20);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Tổng chi phí:";
            // 
            // dgvPrescription
            // 
            dgvPrescription.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrescription.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrescription.Dock = DockStyle.Fill;
            dgvPrescription.Location = new Point(0, 0);
            dgvPrescription.Name = "dgvPrescription";
            dgvPrescription.RowHeadersWidth = 51;
            dgvPrescription.Size = new Size(867, 672);
            dgvPrescription.TabIndex = 1;
            // 
            // frmDoctorCenter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 928);
            Controls.Add(split1);
            Name = "frmDoctorCenter";
            Text = "Doctor Desk";
            WindowState = FormWindowState.Maximized;
            Activated += frmDoctorCenter_Activated;
            Load += frmDoctorCenter_Load;
            split1.Panel1.ResumeLayout(false);
            split1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)split1).EndInit();
            split1.ResumeLayout(false);
            gb1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvWaitingList).EndInit();
            split2.Panel1.ResumeLayout(false);
            split2.Panel1.PerformLayout();
            split2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)split2).EndInit();
            split2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrescription).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer split1;
        private GroupBox gb1;
        private DataGridView dgvWaitingList;
        private SplitContainer split2;
        private Panel panel1;
        private Button btnAdd;
        private TextBox txtUsage;
        private TextBox txtUnit;
        private NumericUpDown numQuantity;
        private ComboBox cboDrug;
        private Label lblUnit;
        private Label lblQuantity;
        private Label lblUsage;
        private Label label1;
        private Label lblTotal;
        private TextBox txtDiagnosis;
        private Label lblDiagnosis;
        private Label lblCap1;
        private DataGridView dgvPrescription;
        private Button btnFinished;
        private Label lblCurrent;
        private Button btnDelete;
    }
}