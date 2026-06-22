namespace ClinicManagement
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblText = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblText.Location = new Point(146, 66);
            lblText.Name = "lblText";
            lblText.Size = new Size(147, 35);
            lblText.TabIndex = 0;
            lblText.Text = "Đăng Nhập";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10.2F);
            lblUsername.Location = new Point(41, 188);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(124, 23);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Tên đăng nhập";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10.2F);
            lblPassword.Location = new Point(41, 244);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(82, 23);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Mật khẩu";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10.2F);
            txtUsername.Location = new Point(185, 188);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(241, 30);
            txtUsername.TabIndex = 3;
            txtUsername.KeyDown += txtUsername_KeyDown;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10.2F);
            txtPassword.Location = new Point(185, 244);
            txtPassword.Name = "txtPassword";
            txtPassword.RightToLeft = RightToLeft.No;
            txtPassword.Size = new Size(241, 30);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 10.2F);
            btnLogin.Location = new Point(146, 336);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(126, 56);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 513);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblText);
            Name = "frmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblText;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}
