namespace GUI.GUIForm
{
    partial class frmPayment
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
            splitContainer1 = new SplitContainer();
            gb1 = new GroupBox();
            dgvWaitingList = new DataGridView();
            gb3 = new GroupBox();
            dgvService = new DataGridView();
            panel2 = new Panel();
            btnPayment = new Button();
            lblTotal = new Label();
            panel1 = new Panel();
            gb2 = new GroupBox();
            dgvMedicine = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWaitingList).BeginInit();
            gb3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvService).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            gb2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMedicine).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(gb1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(gb3);
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(1182, 748);
            splitContainer1.SplitterDistance = 485;
            splitContainer1.TabIndex = 0;
            // 
            // gb1
            // 
            gb1.Controls.Add(dgvWaitingList);
            gb1.Dock = DockStyle.Fill;
            gb1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gb1.Location = new Point(0, 0);
            gb1.Name = "gb1";
            gb1.Size = new Size(485, 748);
            gb1.TabIndex = 0;
            gb1.TabStop = false;
            gb1.Text = "Danh sách chờ thanh toán";
            // 
            // dgvWaitingList
            // 
            dgvWaitingList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvWaitingList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWaitingList.Dock = DockStyle.Fill;
            dgvWaitingList.Location = new Point(3, 27);
            dgvWaitingList.Name = "dgvWaitingList";
            dgvWaitingList.RowHeadersWidth = 51;
            dgvWaitingList.Size = new Size(479, 718);
            dgvWaitingList.TabIndex = 0;
            dgvWaitingList.CellClick += dgvWaitingList_CellClick;
            // 
            // gb3
            // 
            gb3.Controls.Add(dgvService);
            gb3.Dock = DockStyle.Fill;
            gb3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gb3.Location = new Point(0, 291);
            gb3.Name = "gb3";
            gb3.Size = new Size(693, 322);
            gb3.TabIndex = 2;
            gb3.TabStop = false;
            gb3.Text = "Tiền dịch vụ";
            // 
            // dgvService
            // 
            dgvService.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvService.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvService.Dock = DockStyle.Fill;
            dgvService.Location = new Point(3, 27);
            dgvService.Name = "dgvService";
            dgvService.RowHeadersWidth = 51;
            dgvService.Size = new Size(687, 292);
            dgvService.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnPayment);
            panel2.Controls.Add(lblTotal);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 613);
            panel2.Name = "panel2";
            panel2.Size = new Size(693, 135);
            panel2.TabIndex = 1;
            // 
            // btnPayment
            // 
            btnPayment.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayment.Location = new Point(235, 81);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(184, 42);
            btnPayment.TabIndex = 1;
            btnPayment.Text = "Hoàn tất thanh toán";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.OrangeRed;
            lblTotal.Location = new Point(3, 13);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(295, 31);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Tổng tiền cần thanh toán:";
            // 
            // panel1
            // 
            panel1.Controls.Add(gb2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(693, 291);
            panel1.TabIndex = 0;
            // 
            // gb2
            // 
            gb2.Controls.Add(dgvMedicine);
            gb2.Dock = DockStyle.Fill;
            gb2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gb2.Location = new Point(0, 0);
            gb2.Name = "gb2";
            gb2.Size = new Size(693, 291);
            gb2.TabIndex = 0;
            gb2.TabStop = false;
            gb2.Text = "Tiền thuốc";
            // 
            // dgvMedicine
            // 
            dgvMedicine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedicine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicine.Dock = DockStyle.Fill;
            dgvMedicine.Location = new Point(3, 27);
            dgvMedicine.Name = "dgvMedicine";
            dgvMedicine.RowHeadersWidth = 51;
            dgvMedicine.Size = new Size(687, 261);
            dgvMedicine.TabIndex = 0;
            // 
            // frmPayment
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 748);
            Controls.Add(splitContainer1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmPayment";
            Text = "Payment Center";
            WindowState = FormWindowState.Maximized;
            Load += frmPayment_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            gb1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvWaitingList).EndInit();
            gb3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvService).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            gb2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMedicine).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox gb1;
        private DataGridView dgvWaitingList;
        private GroupBox gb3;
        private DataGridView dgvService;
        private Panel panel2;
        private Label lblTotal;
        private Panel panel1;
        private GroupBox gb2;
        private DataGridView dgvMedicine;
        private Button btnPayment;
    }
}