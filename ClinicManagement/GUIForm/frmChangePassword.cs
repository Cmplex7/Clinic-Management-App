using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmChangePassword : Form
    {
        private UserService _service = new UserService();
        public frmChangePassword()
        {
            InitializeComponent();
        }

        public void frmChangePassword_Load(object sender, EventArgs e)
        {
            var currentUser = UserSession.CurrentUser;
            if (currentUser != null)
            {
                txtUsername.Text = currentUser.UserName;
                txtUsername.Enabled = false;
            }
            txtOldPW.Focus();
        }

        private void btnChangePW_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOldPW.Text) || string.IsNullOrEmpty(txtNewPW.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
                return;
            }
            try
            {
                int userId = UserSession.CurrentUser.UserID;
                _service.ChangePassword(userId, txtOldPW.Text, txtNewPW.Text);

                MessageBox.Show("Đổi mật khẩu thành công ! Vui lòng đăng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOldPW.Focus();
                txtOldPW.SelectAll();
            }
        }
    }
}
