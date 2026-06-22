namespace GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            mnuNhanvien = new ToolStripMenuItem();
            mnuMedicine = new ToolStripMenuItem();
            mnuServiceManagement = new ToolStripMenuItem();
            khámBệnhToolStripMenuItem = new ToolStripMenuItem();
            mnuListExam = new ToolStripMenuItem();
            mnuHistory = new ToolStripMenuItem();
            lịchToolStripMenuItem = new ToolStripMenuItem();
            mnuPatient = new ToolStripMenuItem();
            mnuPayment = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            mnuStatics = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuNhanvien, mnuMedicine, mnuServiceManagement });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(73, 24);
            quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // mnuNhanvien
            // 
            mnuNhanvien.Name = "mnuNhanvien";
            mnuNhanvien.Size = new Size(209, 26);
            mnuNhanvien.Text = "Quản lý nhân viên";
            mnuNhanvien.Click += mnuNhanvien_Click;
            // 
            // mnuMedicine
            // 
            mnuMedicine.Name = "mnuMedicine";
            mnuMedicine.Size = new Size(209, 26);
            mnuMedicine.Text = "Quản lý thuốc";
            mnuMedicine.Click += mnuMedicine_Click;
            // 
            // mnuServiceManagement
            // 
            mnuServiceManagement.Name = "mnuServiceManagement";
            mnuServiceManagement.Size = new Size(209, 26);
            mnuServiceManagement.Text = "Dịch vụ/Bảng giá";
            mnuServiceManagement.Click += mnuServiceManagement_Click;
            // 
            // khámBệnhToolStripMenuItem
            // 
            khámBệnhToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuListExam, mnuHistory });
            khámBệnhToolStripMenuItem.Name = "khámBệnhToolStripMenuItem";
            khámBệnhToolStripMenuItem.Size = new Size(98, 24);
            khámBệnhToolStripMenuItem.Text = "Khám bệnh";
            // 
            // mnuListExam
            // 
            mnuListExam.Name = "mnuListExam";
            mnuListExam.Size = new Size(224, 26);
            mnuListExam.Text = "Danh sách khám";
            mnuListExam.Click += mnuListExam_Click;
            // 
            // mnuHistory
            // 
            mnuHistory.Name = "mnuHistory";
            mnuHistory.Size = new Size(224, 26);
            mnuHistory.Text = "Lịch sử khám";
            mnuHistory.Click += mnuHistory_Click;
            // 
            // lịchToolStripMenuItem
            // 
            lịchToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuPatient, mnuPayment });
            lịchToolStripMenuItem.Name = "lịchToolStripMenuItem";
            lịchToolStripMenuItem.Size = new Size(77, 24);
            lịchToolStripMenuItem.Text = "Lịch hẹn";
            // 
            // mnuPatient
            // 
            mnuPatient.Name = "mnuPatient";
            mnuPatient.Size = new Size(186, 26);
            mnuPatient.Text = "Đăng ký khám";
            mnuPatient.Click += mnuPatient_Click;
            // 
            // mnuPayment
            // 
            mnuPayment.Name = "mnuPayment";
            mnuPayment.Size = new Size(186, 26);
            mnuPayment.Text = "Thanh toán";
            mnuPayment.Click += mnuPayment_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quảnLýToolStripMenuItem, khámBệnhToolStripMenuItem, lịchToolStripMenuItem, mnuStatics });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1182, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuStatics
            // 
            mnuStatics.Name = "mnuStatics";
            mnuStatics.Size = new Size(84, 24);
            mnuStatics.Text = "Thống kê";
            mnuStatics.Click += mnuStatics_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1182, 653);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Clinic Management";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem mnuNhanvien;
        private ToolStripMenuItem mnuMedicine;
        private ToolStripMenuItem khámBệnhToolStripMenuItem;
        private ToolStripMenuItem mnuListExam;
        private ToolStripMenuItem mnuHistory;
        private ToolStripMenuItem lịchToolStripMenuItem;
        private ToolStripMenuItem mnuPatient;
        private ToolStripMenuItem mnuPayment;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuServiceManagement;
        private ToolStripMenuItem mnuStatics;
    }
}