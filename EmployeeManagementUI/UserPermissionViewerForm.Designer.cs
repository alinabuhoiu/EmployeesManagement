
namespace EmployeeManagementUI
{
    partial class UserPermissionViewerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtEmployeeView = new System.Windows.Forms.Label();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReadPermissionColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CreatePermissionColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UpdatePermissionColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DeletePermissionColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UpdateButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCreateNewRole = new System.Windows.Forms.Button();
            this.btnCreateNewUser = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmployeeView
            // 
            this.txtEmployeeView.AutoSize = true;
            this.txtEmployeeView.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEmployeeView.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtEmployeeView.Location = new System.Drawing.Point(303, 39);
            this.txtEmployeeView.Name = "txtEmployeeView";
            this.txtEmployeeView.Size = new System.Drawing.Size(221, 52);
            this.txtEmployeeView.TabIndex = 10;
            this.txtEmployeeView.Text = "Employees";
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AllowUserToAddRows = false;
            this.usersDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.EmailColumn,
            this.DepartmentColumn,
            this.ReadPermissionColumn,
            this.CreatePermissionColumn,
            this.UpdatePermissionColumn,
            this.DeletePermissionColumn,
            this.UpdateButtonColumn,
            this.DeleteButtonColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usersDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.usersDataGridView.Location = new System.Drawing.Point(12, 113);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.ReadOnly = true;
            this.usersDataGridView.RowHeadersWidth = 51;
            this.usersDataGridView.RowTemplate.Height = 29;
            this.usersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersDataGridView.Size = new System.Drawing.Size(1348, 224);
            this.usersDataGridView.TabIndex = 11;
            this.usersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersDataGridView_CellClick);
            this.usersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersDataGridView_CellContentClick);
            // 
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // EmailColumn
            // 
            this.EmailColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmailColumn.HeaderText = "Email";
            this.EmailColumn.MinimumWidth = 6;
            this.EmailColumn.Name = "EmailColumn";
            this.EmailColumn.ReadOnly = true;
            // 
            // DepartmentColumn
            // 
            this.DepartmentColumn.HeaderText = "Department";
            this.DepartmentColumn.MinimumWidth = 6;
            this.DepartmentColumn.Name = "DepartmentColumn";
            this.DepartmentColumn.ReadOnly = true;
            this.DepartmentColumn.Width = 125;
            // 
            // ReadPermissionColumn
            // 
            this.ReadPermissionColumn.HeaderText = "Read";
            this.ReadPermissionColumn.MinimumWidth = 6;
            this.ReadPermissionColumn.Name = "ReadPermissionColumn";
            this.ReadPermissionColumn.ReadOnly = true;
            this.ReadPermissionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ReadPermissionColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ReadPermissionColumn.Width = 80;
            // 
            // CreatePermissionColumn
            // 
            this.CreatePermissionColumn.HeaderText = "Create";
            this.CreatePermissionColumn.MinimumWidth = 6;
            this.CreatePermissionColumn.Name = "CreatePermissionColumn";
            this.CreatePermissionColumn.ReadOnly = true;
            this.CreatePermissionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CreatePermissionColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CreatePermissionColumn.Width = 80;
            // 
            // UpdatePermissionColumn
            // 
            this.UpdatePermissionColumn.HeaderText = "Update";
            this.UpdatePermissionColumn.MinimumWidth = 6;
            this.UpdatePermissionColumn.Name = "UpdatePermissionColumn";
            this.UpdatePermissionColumn.ReadOnly = true;
            this.UpdatePermissionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UpdatePermissionColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.UpdatePermissionColumn.Width = 80;
            // 
            // DeletePermissionColumn
            // 
            this.DeletePermissionColumn.HeaderText = "Delete";
            this.DeletePermissionColumn.MinimumWidth = 6;
            this.DeletePermissionColumn.Name = "DeletePermissionColumn";
            this.DeletePermissionColumn.ReadOnly = true;
            this.DeletePermissionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeletePermissionColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DeletePermissionColumn.Width = 80;
            // 
            // UpdateButtonColumn
            // 
            this.UpdateButtonColumn.HeaderText = "Update";
            this.UpdateButtonColumn.MinimumWidth = 6;
            this.UpdateButtonColumn.Name = "UpdateButtonColumn";
            this.UpdateButtonColumn.ReadOnly = true;
            this.UpdateButtonColumn.Text = "Update";
            this.UpdateButtonColumn.UseColumnTextForButtonValue = true;
            this.UpdateButtonColumn.Width = 125;
            // 
            // DeleteButtonColumn
            // 
            this.DeleteButtonColumn.HeaderText = "Delete";
            this.DeleteButtonColumn.MinimumWidth = 6;
            this.DeleteButtonColumn.Name = "DeleteButtonColumn";
            this.DeleteButtonColumn.ReadOnly = true;
            this.DeleteButtonColumn.Text = "Delete";
            this.DeleteButtonColumn.UseColumnTextForButtonValue = true;
            this.DeleteButtonColumn.Width = 125;
            // 
            // btnCreateNewRole
            // 
            this.btnCreateNewRole.Location = new System.Drawing.Point(319, 362);
            this.btnCreateNewRole.Name = "btnCreateNewRole";
            this.btnCreateNewRole.Size = new System.Drawing.Size(130, 29);
            this.btnCreateNewRole.TabIndex = 13;
            this.btnCreateNewRole.Text = "Create new role";
            this.btnCreateNewRole.UseVisualStyleBackColor = true;
            this.btnCreateNewRole.Click += new System.EventHandler(this.btnCreateNewRole_Click);
            // 
            // btnCreateNewUser
            // 
            this.btnCreateNewUser.Enabled = false;
            this.btnCreateNewUser.Location = new System.Drawing.Point(136, 362);
            this.btnCreateNewUser.Name = "btnCreateNewUser";
            this.btnCreateNewUser.Size = new System.Drawing.Size(130, 29);
            this.btnCreateNewUser.TabIndex = 12;
            this.btnCreateNewUser.Text = "Create new user";
            this.btnCreateNewUser.UseVisualStyleBackColor = true;
            this.btnCreateNewUser.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1162, 362);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 29);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // UserPermissionViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreateNewRole);
            this.Controls.Add(this.btnCreateNewUser);
            this.Controls.Add(this.usersDataGridView);
            this.Controls.Add(this.txtEmployeeView);
            this.Name = "UserPermissionViewerForm";
            this.Text = "EmployeeViewerForm";
            this.Load += new System.EventHandler(this.UserPermissionViewerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtEmployeeView;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ReadPermissionColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CreatePermissionColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn UpdatePermissionColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DeletePermissionColumn;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateButtonColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButtonColumn;
        private System.Windows.Forms.Button btnCreateNewRole;
        private System.Windows.Forms.Button btnCreateNewUser;
        private System.Windows.Forms.Button btnExit;
    }
}