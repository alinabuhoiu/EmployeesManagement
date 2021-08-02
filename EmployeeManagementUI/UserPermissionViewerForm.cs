using EmployeeManagementLibrary;
using EmployeeManagementLibrary.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EmployeeManagementUI
{
    public partial class UserPermissionViewerForm : Form, IUserRequester
    {
        List<User> users = GlobalConfig.Connection.GetAllUsers();
        User currentUser;

        public UserPermissionViewerForm(User user)
        {
            InitializeComponent();
            currentUser = user;

            if (!currentUser.CreatePermission())
            {
                btnCreateNewUser.Enabled = false;
            }

            if (!currentUser.CreateNewRolePermission())
            {
                btnCreateNewRole.Enabled = false;
            }
        }

        public void UserComplete(User returnedUser)
        {
            //foreach (User u in users)
            //{
            //    if (u.Id == returnedUser.Id)
            //    {
            //        u.Name = returnedUser.Name;
            //        u.Email = returnedUser.Email;
            //        u.Department = returnedUser.Department;
            //        u.Roles = returnedUser.Roles;
            //    }
            //}

            users = GlobalConfig.Connection.GetAllUsers();

            FillDataGridViewWithUsers();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(this);
            registerForm.Show();
        }

        private void usersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserPermissionViewerForm_Load(object sender, EventArgs e)
        {
            FillDataGridViewWithUsers();
        }

        private void FillDataGridViewWithUsers()
        {
            //List<User> users = GlobalConfig.Connection.GetAllUsers();

            usersDataGridView.Rows.Clear();

            bool readPermission;
            bool createPermission;
            bool updatePermission;
            bool deletePermission;

            foreach (User u in users)
            {
                readPermission = false;
                createPermission = false;
                updatePermission = false;
                deletePermission = false;

                foreach (Role r in u.Roles)
                {
                    if (r.ReadPermission)
                    {
                        readPermission = true;
                    }

                    if (r.CreatePermission)
                    {
                        createPermission = true;
                    }

                    if (r.UpdatePermission)
                    {
                        updatePermission = true;
                    }

                    if (r.DeletePermission)
                    {
                        deletePermission = true;
                    }
                }

                int rowId = usersDataGridView.Rows.Add();
                DataGridViewRow row = usersDataGridView.Rows[rowId];

                row.Cells["NameColumn"].Value = u.Name;
                row.Cells["NameColumn"].Value = u.Name;
                row.Cells["EmailColumn"].Value = u.Email;
                row.Cells["DepartmentColumn"].Value = u.Department;
                row.Cells["ReadPermissionColumn"].Value = readPermission ? true : false;
                row.Cells["CreatePermissionColumn"].Value = createPermission ? true : false;
                row.Cells["UpdatePermissionColumn"].Value = updatePermission ? true : false;
                row.Cells["DeletePermissionColumn"].Value = deletePermission ? true : false;
            }
        }

        private void usersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (usersDataGridView.Columns[e.ColumnIndex].Name == "DeleteButtonColumn")
            {
                if (currentUser.DeletePermission())
                {
                    DeleteUser();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show(
                         "You do not have rights to Delete another User.",
                         "Rights error",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                }
            }

            if (usersDataGridView.Columns[e.ColumnIndex].Name == "UpdateButtonColumn")
            {
                if (currentUser.UpdatePermission())
                {
                    UpdateUser();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show(
                         "You do not have rights to Update a User.",
                         "Rights error",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateUser()
        {
            User userToBeUpdated = GetSelectedUser();

            UpdateUserForm updateUserForm = new UpdateUserForm(userToBeUpdated, this);

            updateUserForm.Show();
        }

        private User GetSelectedUser()
        {
            int index = usersDataGridView.CurrentCell.RowIndex;

            DataGridViewRow selectedRow = usersDataGridView.Rows[index];

            string userEmail = selectedRow.Cells["EmailColumn"].Value.ToString();

            return GlobalConfig.Connection.GetUserByEmail(userEmail);
        }

        private void DeleteUser()
        {
            string userEmail = "";

            int index = usersDataGridView.CurrentCell.RowIndex;

            DataGridViewRow selectedRow = usersDataGridView.Rows[index];

            userEmail = selectedRow.Cells["EmailColumn"].Value.ToString();

            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to delete user with " + userEmail + " email address? ",
                "Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                GlobalConfig.Connection.DeleteUser(GlobalConfig.Connection.GetUserByEmail(userEmail));
                usersDataGridView.Rows.RemoveAt(index);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnCreateNewRole_Click(object sender, EventArgs e)
        {
            CreateRoleForm createRoleForm = new CreateRoleForm();
            createRoleForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
