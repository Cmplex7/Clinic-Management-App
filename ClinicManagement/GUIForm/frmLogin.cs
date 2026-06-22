using BLL;
using Entities;
using GUI;
using System.Windows.Forms;

namespace ClinicManagement
{
    public partial class frmLogin : Form
    {
        private UserService _service = new UserService();
        public frmLogin()
        {
            InitializeComponent();
        }


        //Button Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu !");
                return;
            }

            User user = _service.Login(txtUsername.Text, txtPassword.Text);

            if (user != null)
            {
                UserSession.CurrentUser = user;

                MessageBox.Show($"Xin chào {user.FullName}!", "Đăng nhập thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);


                MainForm f = new MainForm();
                f.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng !", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
