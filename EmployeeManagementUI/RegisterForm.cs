using EmployeeManagementLibrary;
using EmployeeManagementLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeManagementUI
{
    public partial class RegisterForm : Form
    {
        IUserRequester callingForm;
        public RegisterForm(IUserRequester caller)
        {
            InitializeComponent();
            callingForm = caller;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                User user = new User(
                    txtName.Text,
                    txtEmail.Text,
                    txtDepartment.Text,
                    txtPassword.Text);

                if (GlobalConfig.Connection.AddNewUser(user) == null)
                {
                    MessageBox.Show("An account is already created for this email address. " +
                        "Please login or try register using another email address.");
                }
                else
                {
                    MessageBox.Show("Account successfully created.");
                    //call the parent (caller form) and provide the user model to it
                    callingForm.UserComplete(user);
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("All fields are required. Please fill them in and try again");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (txtName.Text.Length == 0)
            {
                output = false;
            }

            if (txtEmail.Text.Length == 0)
            {
                output = false;
            }

            if (txtDepartment.Text.Length == 0)
            {
                output = false;
            }

            if (txtPassword.Text.Length == 0)
            {
                output = false;
            }

            return output;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
