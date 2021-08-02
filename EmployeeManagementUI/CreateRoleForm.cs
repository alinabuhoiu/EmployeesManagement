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
    public partial class CreateRoleForm : Form
    {
        public CreateRoleForm()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Role role = new Role();

            role.Name = txtRoleName.Text;
            role.ReadPermission = checkBoxRead.Checked;
            role.CreatePermission = checkBoxCreate.Checked;
            role.UpdatePermission = checkBoxUpdate.Checked;
            role.DeletePermission = checkBoxDelete.Checked;
            role.CreateNewRolePermission = checkBoxCreateRoles.Checked;

            if (GlobalConfig.Connection.AddNewRole(role) == null)
            {
                DialogResult dialogResult = MessageBox.Show(
                        "A role with this name already exist. Please use another name.",
                        "Create new role error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(
                        "Role successfully created.",
                        "Create new role",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
