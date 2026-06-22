using System;
using System.Windows.Forms;
using GUI.GUIForm;
using BLL.Implements;
using BLL;

namespace GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Load form
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (UserSession.CurrentUser == null) return;

            var user = UserSession.CurrentUser;
            this.Text = "CLINIC MANAGEMENT SYSTEM";

            frmHome fHome = new frmHome();
            fHome.MdiParent = this;

            fHome.FormBorderStyle = FormBorderStyle.None;
            fHome.Dock = DockStyle.Fill;
            fHome.Show();

            PhanQuyen(user.RoleID);
        }


        
        //Phân quyền
        private void PhanQuyen(int roleID)
        {
            mnuNhanvien.Visible = false;
            mnuServiceManagement.Visible = false;
            mnuMedicine.Visible = false;
            mnuPatient.Visible = false;
            mnuListExam.Visible = false;
            mnuPayment.Visible = false;
            mnuStatics.Visible = false;
            mnuHistory.Visible = false;

            switch (roleID)
            {
                case 1: //Admin
                    mnuNhanvien.Visible = true;
                    mnuMedicine.Visible = true;
                    mnuServiceManagement.Visible = true;
                    mnuPatient.Visible = true;
                    mnuListExam.Visible = true;
                    mnuPayment.Visible = true;
                    mnuStatics.Visible = true;
                    mnuHistory.Visible = true;
                    break;

                case 2: //Doctor
                    mnuListExam.Visible = true;
                    mnuHistory.Visible = true;
                    mnuMedicine.Visible = true;
                    break;

                case 3: //Staff
                    mnuPatient.Visible = true;
                    mnuPayment.Visible = true;
                    mnuHistory.Visible = true;
                    break;
            }
        }


        private string GetRoleName(int roleID)
        {
            switch (roleID)
            {
                case 1: return "Quản trị viên";
                case 2: return "Bác sĩ";
                case 3: return "Nhân viên";
                default: return "Khách";
            }
        }


        //Thoát
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void OpenChildForm(Form childform)
        {
            foreach(Form f in this.MdiChildren)
            {
                if(f.GetType() == childform.GetType())
                {
                    f.Activate();
                    return;
                }
            }
            childform.MdiParent = this;
            childform.Show();
        }

        private void mnuNhanvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmUsers());
        }

        private void mnuMedicine_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmMedicine());
        }

        private void mnuPatient_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmPatient());
        }

        private void mnuListExam_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDoctorCenter());
        }

        private void mnuPayment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmPayment());
        }

        private void mnuServiceManagement_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmServiceManagement());
        }

        private void mnuHistory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHistory());
        }

        private void mnuStatics_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmStatistics());
        }
    }
}