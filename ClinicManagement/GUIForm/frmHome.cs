using System;
using System.Windows.Forms;
using BLL;
using BLL.Implements;

namespace GUI
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            var user = UserSession.CurrentUser;
            if (user != null)
            {
                lblWelcome.Text = $"Chào mừng, {user.FullName}!";
                lblIDValue.Text = user.UserID.ToString();
                lblNameValue.Text = user.FullName;
                lblRoleValue.Text = user.Role.RoleName;
                lblUsernameValue.Text = user.UserName;
            }
            else
            {
                lblNameValue.Text = "Chưa đăng nhập";
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            frmChangePassword f = new frmChangePassword();
            f.Show();
        }
    }
}
