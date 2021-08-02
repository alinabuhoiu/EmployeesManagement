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
    public partial class UpdateUserForm : Form
    {
        IUserRequester callingForm;
        User userToBeUpdated;
        List<Role> availableRoles = GlobalConfig.Connection.GetAllRoles();
        List<Role> selectedRoles = new List<Role>();

        public UpdateUserForm(User user, IUserRequester caller)
        {
            InitializeComponent();
            //CreateSampleData();
            RefreshLists();
            callingForm = caller;
            userToBeUpdated = user;
            InitializeView();
        }

        private void InitializeView()
        {
            txtEmail.Text = userToBeUpdated.Email;
            txtName.Text = userToBeUpdated.Name;
            txtDepartment.Text = userToBeUpdated.Department;
        }

        //private void CreateSampleData()
        //{
        //    availableRoles.Add(new Role { Name = "Employee", ReadPermission = true, CreatePermission = false, UpdatePermission = false, DeletePermission = false });
        //    availableRoles.Add(new Role { Name = "Manager", ReadPermission = true, CreatePermission = true, UpdatePermission = true, DeletePermission = true });
        //}

        private void RefreshLists()
        {
            selectRoleDropDown.DataSource = null;
            selectRoleDropDown.DataSource = availableRoles;
            selectRoleDropDown.DisplayMember = "Name";

            selectedRolesListBox.DataSource = null;
            selectedRolesListBox.DataSource = selectedRoles;
            selectedRolesListBox.DisplayMember = "Name";
        }

        private void btnAddNewRole_Click(object sender, EventArgs e)
        {
            Role role = (Role)selectRoleDropDown.SelectedItem;

            if (role != null)
            {
                availableRoles.Remove(role);
                selectedRoles.Add(role);

                RefreshLists();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedRoles.Count == 0)
            {
                MessageBox.Show(
                    "The current user does not have any role assigned. Please assign one.",
                    "Missing role",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            User newUser = new User();

            newUser.Name = txtName.Text;
            newUser.Email = txtEmail.Text;
            newUser.Department = txtDepartment.Text;
            newUser.Roles = selectedRoles;

            newUser = GlobalConfig.Connection.UpdateUser(userToBeUpdated.Id, newUser);

            if (newUser != null)
            {
                MessageBox.Show(
                    "User successfully updated.",
                    "Update",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                callingForm.UserComplete(newUser);
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "An error occur. Update not performed.",
                    "Update",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }


        }

        private void btnRemoveSelectedRole_Click(object sender, EventArgs e)
        {
            Role role = (Role)selectedRolesListBox.SelectedItem;

            if (role != null)
            {
                selectedRoles.Remove(role);
                availableRoles.Add(role);

                RefreshLists();
            }
        }

        private void UpdateUserForm_Load(object sender, EventArgs e)
        {
            foreach (Role r in userToBeUpdated.Roles)
            {
                selectedRoles.Add(r);
            }

            RefreshLists();
        }

        private void linkLabelAddNewRole_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateRoleForm createRoleForm = new CreateRoleForm();
            createRoleForm.Show();
        }
    }
}
