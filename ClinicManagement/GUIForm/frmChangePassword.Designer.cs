namespace GUI
{
    partial class frmChangePassword
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
            lblText = new Label();
            btnChangePW = new Button();
            txtOldPW = new TextBox();
            txtUsername = new TextBox();
            lblOldPW = new Label();
            lblUsername = new Label();
            txtNewPW = new TextBox();
            lblNewPW = new Label();
            SuspendLayout();
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblText.Location = new Point(139, 99);
            lblText.Name = "lblText";
            lblText.Size = new Size(172, 35);
            lblText.TabIndex = 1;
            lblText.Text = "Đổi mật khẩu";
            // 
            // btnChangePW
            // 
            btnChangePW.Font = new Font("Segoe UI", 10.2F);
            btnChangePW.Location = new Point(139, 340);
            btnChangePW.Name = "btnChangePW";
            btnChangePW.Size = new Size(126, 56);
            btnChangePW.TabIndex = 10;
            btnChangePW.Text = "Đổi mật khẩu";
            btnChangePW.UseVisualStyleBackColor = true;
            btnChangePW.Click += btnChangePW_Click;
            // 
            // txtOldPW
            // 
            txtOldPW.Font = new Font("Segoe UI", 10.2F);
            txtOldPW.Location = new Point(178, 210);
            txtOldPW.Name = "txtOldPW";
            txtOldPW.RightToLeft = RightToLeft.No;
            txtOldPW.Size = new Size(241, 30);
            txtOldPW.TabIndex = 9;
            txtOldPW.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10.2F);
            txtUsername.Location = new Point(178, 154);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(241, 30);
            txtUsername.TabIndex = 8;
            // 
            // lblOldPW
            // 
            lblOldPW.AutoSize = true;
            lblOldPW.Font = new Font("Segoe UI", 10.2F);
            lblOldPW.Location = new Point(34, 210);
            lblOldPW.Name = "lblOldPW";
            lblOldPW.Size = new Size(82, 23);
            lblOldPW.TabIndex = 7;
            lblOldPW.Text = "Mật khẩu";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10.2F);
            lblUsername.Location = new Point(34, 154);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(124, 23);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "Tên đăng nhập";
            // 
            // txtNewPW
            // 
            txtNewPW.Font = new Font("Segoe UI", 10.2F);
            txtNewPW.Location = new Point(178, 266);
            txtNewPW.Name = "txtNewPW";
            txtNewPW.RightToLeft = RightToLeft.No;
            txtNewPW.Size = new Size(241, 30);
            txtNewPW.TabIndex = 12;
            txtNewPW.UseSystemPasswordChar = true;
            // 
            // lblNewPW
            // 
            lblNewPW.AutoSize = true;
            lblNewPW.Font = new Font("Segoe UI", 10.2F);
            lblNewPW.Location = new Point(34, 266);
            lblNewPW.Name = "lblNewPW";
            lblNewPW.Size = new Size(82, 23);
            lblNewPW.TabIndex = 11;
            lblNewPW.Text = "Mật khẩu";
            // 
            // frmChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 513);
            Controls.Add(txtNewPW);
            Controls.Add(lblNewPW);
            Controls.Add(btnChangePW);
            Controls.Add(txtOldPW);
            Controls.Add(txtUsername);
            Controls.Add(lblOldPW);
            Controls.Add(lblUsername);
            Controls.Add(lblText);
            Name = "frmChangePassword";
            Text = "Change Password";
            Load += frmChangePassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblText;
        private Button btnChangePW;
        private TextBox txtOldPW;
        private TextBox txtUsername;
        private Label lblOldPW;
        private Label lblUsername;
        private TextBox txtNewPW;
        private Label lblNewPW;
    }
}