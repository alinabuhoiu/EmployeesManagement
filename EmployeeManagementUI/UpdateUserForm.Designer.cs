
namespace EmployeeManagementUI
{
    partial class UpdateUserForm
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
            this.selectedRolesListBox = new System.Windows.Forms.ListBox();
            this.btnAddNewRole = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.selectRoleDropDown = new System.Windows.Forms.ComboBox();
            this.linkLabelAddNewRole = new System.Windows.Forms.LinkLabel();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.lmlEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblUpdateUser = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemoveSelectedRole = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectedRolesListBox
            // 
            this.selectedRolesListBox.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectedRolesListBox.FormattingEnabled = true;
            this.selectedRolesListBox.ItemHeight = 23;
            this.selectedRolesListBox.Location = new System.Drawing.Point(527, 207);
            this.selectedRolesListBox.Name = "selectedRolesListBox";
            this.selectedRolesListBox.Size = new System.Drawing.Size(246, 188);
            this.selectedRolesListBox.TabIndex = 29;
            // 
            // btnAddNewRole
            // 
            this.btnAddNewRole.Location = new System.Drawing.Point(608, 143);
            this.btnAddNewRole.Name = "btnAddNewRole";
            this.btnAddNewRole.Size = new System.Drawing.Size(94, 29);
            this.btnAddNewRole.TabIndex = 28;
            this.btnAddNewRole.Text = "Add";
            this.btnAddNewRole.UseVisualStyleBackColor = true;
            this.btnAddNewRole.Click += new System.EventHandler(this.btnAddNewRole_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(436, 110);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(39, 20);
            this.lblRole.TabIndex = 27;
            this.lblRole.Text = "Role";
            // 
            // selectRoleDropDown
            // 
            this.selectRoleDropDown.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectRoleDropDown.FormattingEnabled = true;
            this.selectRoleDropDown.Location = new System.Drawing.Point(527, 100);
            this.selectRoleDropDown.Name = "selectRoleDropDown";
            this.selectRoleDropDown.Size = new System.Drawing.Size(246, 37);
            this.selectRoleDropDown.TabIndex = 26;
            // 
            // linkLabelAddNewRole
            // 
            this.linkLabelAddNewRole.AutoSize = true;
            this.linkLabelAddNewRole.Location = new System.Drawing.Point(660, 77);
            this.linkLabelAddNewRole.Name = "linkLabelAddNewRole";
            this.linkLabelAddNewRole.Size = new System.Drawing.Size(113, 20);
            this.linkLabelAddNewRole.TabIndex = 25;
            this.linkLabelAddNewRole.TabStop = true;
            this.linkLabelAddNewRole.Text = "Create new role";
            this.linkLabelAddNewRole.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAddNewRole_LinkClicked);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(38, 364);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(89, 20);
            this.lblDepartment.TabIndex = 37;
            this.lblDepartment.Text = "Department";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDepartment.Location = new System.Drawing.Point(142, 354);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(246, 45);
            this.txtDepartment.TabIndex = 36;
            // 
            // lmlEmail
            // 
            this.lmlEmail.AutoSize = true;
            this.lmlEmail.Location = new System.Drawing.Point(38, 290);
            this.lmlEmail.Name = "lmlEmail";
            this.lmlEmail.Size = new System.Drawing.Size(46, 20);
            this.lmlEmail.TabIndex = 35;
            this.lmlEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(142, 280);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(246, 45);
            this.txtEmail.TabIndex = 34;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(38, 217);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 31;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(142, 207);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(246, 45);
            this.txtName.TabIndex = 30;
            // 
            // lblUpdateUser
            // 
            this.lblUpdateUser.AutoSize = true;
            this.lblUpdateUser.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUpdateUser.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblUpdateUser.Location = new System.Drawing.Point(126, 85);
            this.lblUpdateUser.Name = "lblUpdateUser";
            this.lblUpdateUser.Size = new System.Drawing.Size(262, 52);
            this.lblUpdateUser.TabIndex = 38;
            this.lblUpdateUser.Text = "Update user";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(273, 440);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemoveSelectedRole
            // 
            this.btnRemoveSelectedRole.Location = new System.Drawing.Point(608, 417);
            this.btnRemoveSelectedRole.Name = "btnRemoveSelectedRole";
            this.btnRemoveSelectedRole.Size = new System.Drawing.Size(94, 29);
            this.btnRemoveSelectedRole.TabIndex = 40;
            this.btnRemoveSelectedRole.Text = "Remove selected";
            this.btnRemoveSelectedRole.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedRole.Click += new System.EventHandler(this.btnRemoveSelectedRole_Click);
            // 
            // UpdateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 607);
            this.Controls.Add(this.btnRemoveSelectedRole);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblUpdateUser);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.lmlEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.selectedRolesListBox);
            this.Controls.Add(this.btnAddNewRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.selectRoleDropDown);
            this.Controls.Add(this.linkLabelAddNewRole);
            this.Name = "UpdateUserForm";
            this.Text = "UpdateUserForm";
            this.Load += new System.EventHandler(this.UpdateUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox selectedRolesListBox;
        private System.Windows.Forms.Button btnAddNewRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox selectRoleDropDown;
        private System.Windows.Forms.LinkLabel linkLabelAddNewRole;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label lmlEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblUpdateUser;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemoveSelectedRole;
    }
}