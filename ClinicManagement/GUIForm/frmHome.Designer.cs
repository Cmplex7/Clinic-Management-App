namespace GUI
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            lblWelcome = new Label();
            groupBox1 = new GroupBox();
            lblUsernameValue = new Label();
            lblRoleValue = new Label();
            lblIDValue = new Label();
            lblNameValue = new Label();
            btnExit = new Button();
            btnLogout = new Button();
            lblUser = new Label();
            lblRole = new Label();
            lblID = new Label();
            lblName = new Label();
            btnChange = new Button();
            ptbox = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbox).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.Top;
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(393, 57);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(190, 50);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome";
            lblWelcome.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(lblUsernameValue);
            groupBox1.Controls.Add(lblRoleValue);
            groupBox1.Controls.Add(lblIDValue);
            groupBox1.Controls.Add(lblNameValue);
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(btnLogout);
            groupBox1.Controls.Add(lblUser);
            groupBox1.Controls.Add(lblRole);
            groupBox1.Controls.Add(lblID);
            groupBox1.Controls.Add(lblName);
            groupBox1.Controls.Add(btnChange);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(339, 226);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(560, 431);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tài khoản";
            // 
            // lblUsernameValue
            // 
            lblUsernameValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblUsernameValue.AutoSize = true;
            lblUsernameValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUsernameValue.Location = new Point(273, 252);
            lblUsernameValue.Name = "lblUsernameValue";
            lblUsernameValue.Size = new Size(27, 28);
            lblUsernameValue.TabIndex = 10;
            lblUsernameValue.Text = "...";
            // 
            // lblRoleValue
            // 
            lblRoleValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblRoleValue.AutoSize = true;
            lblRoleValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRoleValue.Location = new Point(273, 189);
            lblRoleValue.Name = "lblRoleValue";
            lblRoleValue.Size = new Size(27, 28);
            lblRoleValue.TabIndex = 9;
            lblRoleValue.Text = "...";
            // 
            // lblIDValue
            // 
            lblIDValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblIDValue.AutoSize = true;
            lblIDValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblIDValue.Location = new Point(273, 122);
            lblIDValue.Name = "lblIDValue";
            lblIDValue.Size = new Size(27, 28);
            lblIDValue.TabIndex = 8;
            lblIDValue.Text = "...";
            // 
            // lblNameValue
            // 
            lblNameValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblNameValue.AutoSize = true;
            lblNameValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNameValue.Location = new Point(273, 65);
            lblNameValue.Name = "lblNameValue";
            lblNameValue.Size = new Size(27, 28);
            lblNameValue.TabIndex = 7;
            lblNameValue.Text = "...";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(411, 339);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(129, 52);
            btnExit.TabIndex = 6;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(212, 339);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(129, 52);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUser.Location = new Point(42, 252);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(157, 28);
            lblUser.TabIndex = 4;
            lblUser.Text = "Tên đăng nhập:";
            // 
            // lblRole
            // 
            lblRole.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRole.Location = new Point(42, 184);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(93, 28);
            lblRole.TabIndex = 3;
            lblRole.Text = "Chức vụ:";
            // 
            // lblID
            // 
            lblID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblID.Location = new Point(42, 122);
            lblID.Name = "lblID";
            lblID.Size = new Size(146, 28);
            lblID.TabIndex = 2;
            lblID.Text = "Mã nhân viên:";
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblName.Location = new Point(42, 65);
            lblName.Name = "lblName";
            lblName.Size = new Size(109, 28);
            lblName.TabIndex = 1;
            lblName.Text = "Họ và tên:";
            // 
            // btnChange
            // 
            btnChange.Location = new Point(19, 339);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(129, 52);
            btnChange.TabIndex = 0;
            btnChange.Text = "Đổi mật khẩu";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // ptbox
            // 
            ptbox.Anchor = AnchorStyles.Top;
            ptbox.Image = (Image)resources.GetObject("ptbox.Image");
            ptbox.InitialImage = null;
            ptbox.Location = new Point(549, 137);
            ptbox.Name = "ptbox";
            ptbox.Size = new Size(84, 83);
            ptbox.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbox.TabIndex = 4;
            ptbox.TabStop = false;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 748);
            Controls.Add(ptbox);
            Controls.Add(groupBox1);
            Controls.Add(lblWelcome);
            Name = "frmHome";
            Text = "Account";
            WindowState = FormWindowState.Maximized;
            Load += frmHome_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private GroupBox groupBox1;
        private PictureBox ptbox;
        private Button btnExit;
        private Button btnLogout;
        private Label lblUser;
        private Label lblRole;
        private Label lblID;
        private Label lblName;
        private Button btnChange;
        private Label lblUsernameValue;
        private Label lblRoleValue;
        private Label lblIDValue;
        private Label lblNameValue;
    }
}