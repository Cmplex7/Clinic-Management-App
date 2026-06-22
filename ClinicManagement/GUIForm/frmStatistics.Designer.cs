namespace GUI.GUIForm
{
    partial class frmStatistics
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
            splitter1 = new SplitContainer();
            btnThongKe = new Button();
            lblCap = new Label();
            dtpToDate = new DateTimePicker();
            dtpFrom = new DateTimePicker();
            lblToDate = new Label();
            lblFrom = new Label();
            splitter2 = new SplitContainer();
            dgvStatisc = new DataGridView();
            lblTongDoanhThu = new Label();
            lblTongLuot = new Label();
            ((System.ComponentModel.ISupportInitialize)splitter1).BeginInit();
            splitter1.Panel1.SuspendLayout();
            splitter1.Panel2.SuspendLayout();
            splitter1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitter2).BeginInit();
            splitter2.Panel1.SuspendLayout();
            splitter2.Panel2.SuspendLayout();
            splitter2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStatisc).BeginInit();
            SuspendLayout();
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Fill;
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Orientation = Orientation.Horizontal;
            // 
            // splitter1.Panel1
            // 
            splitter1.Panel1.Controls.Add(btnThongKe);
            splitter1.Panel1.Controls.Add(lblCap);
            splitter1.Panel1.Controls.Add(dtpToDate);
            splitter1.Panel1.Controls.Add(dtpFrom);
            splitter1.Panel1.Controls.Add(lblToDate);
            splitter1.Panel1.Controls.Add(lblFrom);
            // 
            // splitter1.Panel2
            // 
            splitter1.Panel2.Controls.Add(splitter2);
            splitter1.Size = new Size(1182, 748);
            splitter1.SplitterDistance = 221;
            splitter1.TabIndex = 0;
            // 
            // btnThongKe
            // 
            btnThongKe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThongKe.Location = new Point(857, 117);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(99, 34);
            btnThongKe.TabIndex = 5;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // lblCap
            // 
            lblCap.Anchor = AnchorStyles.Top;
            lblCap.AutoSize = true;
            lblCap.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCap.Location = new Point(356, 26);
            lblCap.Name = "lblCap";
            lblCap.Size = new Size(500, 38);
            lblCap.TabIndex = 4;
            lblCap.Text = "THỐNG KÊ LƯỢT KHÁM THEO NGÀY";
            // 
            // dtpToDate
            // 
            dtpToDate.Anchor = AnchorStyles.Top;
            dtpToDate.Location = new Point(492, 145);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(302, 30);
            dtpToDate.TabIndex = 3;
            // 
            // dtpFrom
            // 
            dtpFrom.Anchor = AnchorStyles.Top;
            dtpFrom.Location = new Point(492, 100);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(302, 30);
            dtpFrom.TabIndex = 2;
            // 
            // lblToDate
            // 
            lblToDate.Anchor = AnchorStyles.Top;
            lblToDate.AutoSize = true;
            lblToDate.Location = new Point(346, 152);
            lblToDate.Name = "lblToDate";
            lblToDate.Size = new Size(87, 23);
            lblToDate.TabIndex = 1;
            lblToDate.Text = "Đến ngày:";
            // 
            // lblFrom
            // 
            lblFrom.Anchor = AnchorStyles.Top;
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(346, 106);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(75, 23);
            lblFrom.TabIndex = 0;
            lblFrom.Text = "Từ ngày:";
            // 
            // splitter2
            // 
            splitter2.Dock = DockStyle.Fill;
            splitter2.Location = new Point(0, 0);
            splitter2.Name = "splitter2";
            splitter2.Orientation = Orientation.Horizontal;
            // 
            // splitter2.Panel1
            // 
            splitter2.Panel1.Controls.Add(dgvStatisc);
            // 
            // splitter2.Panel2
            // 
            splitter2.Panel2.Controls.Add(lblTongDoanhThu);
            splitter2.Panel2.Controls.Add(lblTongLuot);
            splitter2.Size = new Size(1182, 523);
            splitter2.SplitterDistance = 402;
            splitter2.TabIndex = 0;
            // 
            // dgvStatisc
            // 
            dgvStatisc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStatisc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStatisc.Dock = DockStyle.Fill;
            dgvStatisc.Location = new Point(0, 0);
            dgvStatisc.Name = "dgvStatisc";
            dgvStatisc.ReadOnly = true;
            dgvStatisc.RowHeadersWidth = 51;
            dgvStatisc.Size = new Size(1182, 402);
            dgvStatisc.TabIndex = 0;
            // 
            // lblTongDoanhThu
            // 
            lblTongDoanhThu.Anchor = AnchorStyles.Bottom;
            lblTongDoanhThu.AutoSize = true;
            lblTongDoanhThu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTongDoanhThu.ForeColor = Color.Firebrick;
            lblTongDoanhThu.Location = new Point(347, 65);
            lblTongDoanhThu.Name = "lblTongDoanhThu";
            lblTongDoanhThu.Size = new Size(195, 28);
            lblTongDoanhThu.TabIndex = 1;
            lblTongDoanhThu.Text = "TỔNG DOANH THU:";
            // 
            // lblTongLuot
            // 
            lblTongLuot.Anchor = AnchorStyles.Bottom;
            lblTongLuot.AutoSize = true;
            lblTongLuot.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongLuot.Location = new Point(346, 27);
            lblTongLuot.Name = "lblTongLuot";
            lblTongLuot.Size = new Size(167, 25);
            lblTongLuot.TabIndex = 0;
            lblTongLuot.Text = "Tổng số lượt khám:";
            // 
            // frmStatistics
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 748);
            Controls.Add(splitter1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmStatistics";
            Text = "Clinic Statistics";
            WindowState = FormWindowState.Maximized;
            Load += frmStatistics_Load;
            splitter1.Panel1.ResumeLayout(false);
            splitter1.Panel1.PerformLayout();
            splitter1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitter1).EndInit();
            splitter1.ResumeLayout(false);
            splitter2.Panel1.ResumeLayout(false);
            splitter2.Panel2.ResumeLayout(false);
            splitter2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitter2).EndInit();
            splitter2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStatisc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitter1;
        private Label lblCap;
        private DateTimePicker dtpToDate;
        private DateTimePicker dtpFrom;
        private Label lblToDate;
        private Label lblFrom;
        private SplitContainer splitter2;
        private DataGridView dgvStatisc;
        private Label lblTongDoanhThu;
        private Label lblTongLuot;
        private Button btnThongKe;
    }
}