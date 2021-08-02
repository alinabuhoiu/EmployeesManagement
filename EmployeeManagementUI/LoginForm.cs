using EmployeeManagementLibrary;
using EmployeeManagementLibrary.Models;
using EmployeeManagementUI.NotificationService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeManagementUI
{
    public partial class LoginForm : Form, IUserRequester
    {
        User user = new User();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabelRegisterNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(this);
            //this.Hide();
            registerForm.Show();
        }

        public void UserComplete(User user)
        {
            this.user = user;
            FillLoginCredentials(user);

            SendNotification(user);
        }

        private void SendNotification(User newUser)
        {
            List<User> usersInSameDepartemnt = GlobalConfig.Connection.GetAllUsers().Where(x => x.Department == newUser.Department).ToList();
            MailService mailService;

            foreach (User user in usersInSameDepartemnt)
            {
                if (IsManager(user))
                {
                    mailService = new MailService(user.Email);
                    mailService.Notify("Hello " + user.Name + ". A new user \'" + newUser.Name + "\' was registered to your department.");
                }
            }
        }

        private bool IsManager(User user)
        {
            foreach (Role role in user.Roles)
            {
                if (role.Name == "Manager")
                {
                    return true;
                }
            }

            return false;
        }

        private void FillLoginCredentials(User user)
        {
            txtEmail.Text = user.Email;
            txtPassword.Text = user.Password;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = UserSuccessfullyAuthenticated();

            if (user != null)
            {
                UserPermissionViewerForm userPermissionViewerForm = new UserPermissionViewerForm(user);
                this.Hide();
                userPermissionViewerForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login failed. Please try again.");
            }
        }

        private User UserSuccessfullyAuthenticated()
        {
            bool output = true;

            if (txtEmail.Text.Length == 0)
            {
                output = false;
            }

            if (txtPassword.Text.Length == 0)
            {
                output = false;
            }

            if (output)
            {
                return GlobalConfig.Connection.CheckLoginCredentials(txtEmail.Text, txtPassword.Text);
            }

            return null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtPassword.Text = "";
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            GlobalConfig.Connection.AddNewRole(GlobalConfig.Connection.GetEmployeeDefaultRole());
            GlobalConfig.Connection.AddNewRole(GlobalConfig.Connection.GetManagerDefaultTole());
        }
    }
}
