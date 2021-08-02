
namespace EmployeeManagementUI
{
    partial class CreateRoleForm
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
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.lblCreateNewRole = new System.Windows.Forms.Label();
            this.groupBoxPermissions = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelPermissions = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxDelete = new System.Windows.Forms.CheckBox();
            this.checkBoxUpdate = new System.Windows.Forms.CheckBox();
            this.checkBoxCreate = new System.Windows.Forms.CheckBox();
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.lblCreate = new System.Windows.Forms.Label();
            this.lblRead = new System.Windows.Forms.Label();
            this.checkBoxRead = new System.Windows.Forms.CheckBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblCreateRoles = new System.Windows.Forms.Label();
            this.checkBoxCreateRoles = new System.Windows.Forms.CheckBox();
            this.groupBoxPermissions.SuspendLayout();
            this.tableLayoutPanelPermissions.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRoleName
            // 
            this.txtRoleName.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRoleName.Location = new System.Drawing.Point(285, 130);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(273, 45);
            this.txtRoleName.TabIndex = 0;
            // 
            // lblRoleName
            // 
            this.lblRoleName.AutoSize = true;
            this.lblRoleName.Location = new System.Drawing.Point(175, 140);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(80, 20);
            this.lblRoleName.TabIndex = 1;
            this.lblRoleName.Text = "Role name";
            // 
            // lblCreateNewRole
            // 
            this.lblCreateNewRole.AutoSize = true;
            this.lblCreateNewRole.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCreateNewRole.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCreateNewRole.Location = new System.Drawing.Point(199, 35);
            this.lblCreateNewRole.Name = "lblCreateNewRole";
            this.lblCreateNewRole.Size = new System.Drawing.Size(337, 52);
            this.lblCreateNewRole.TabIndex = 9;
            this.lblCreateNewRole.Text = "Create new role";
            // 
            // groupBoxPermissions
            // 
            this.groupBoxPermissions.Controls.Add(this.tableLayoutPanelPermissions);
            this.groupBoxPermissions.Location = new System.Drawing.Point(100, 234);
            this.groupBoxPermissions.Name = "groupBoxPermissions";
            this.groupBoxPermissions.Size = new System.Drawing.Size(599, 160);
            this.groupBoxPermissions.TabIndex = 10;
            this.groupBoxPermissions.TabStop = false;
            this.groupBoxPermissions.Text = "Permissions";
            // 
            // tableLayoutPanelPermissions
            // 
            this.tableLayoutPanelPermissions.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelPermissions.ColumnCount = 5;
            this.tableLayoutPanelPermissions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelPermissions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelPermissions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelPermissions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelPermissions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelPermissions.Controls.Add(this.checkBoxCreateRoles, 4, 1);
            this.tableLayoutPanelPermissions.Controls.Add(this.checkBoxDelete, 3, 1);
            this.tableLayoutPanelPermissions.Controls.Add(this.checkBoxUpdate, 2, 1);
            this.tableLayoutPanelPermissions.Controls.Add(this.checkBoxCreate, 1, 1);
            this.tableLayoutPanelPermissions.Controls.Add(this.lblDelete, 3, 0);
            this.tableLayoutPanelPermissions.Controls.Add(this.lblUpdate, 2, 0);
            this.tableLayoutPanelPermissions.Controls.Add(this.lblCreate, 1, 0);
            this.tableLayoutPanelPermissions.Controls.Add(this.lblRead, 0, 0);
            this.tableLayoutPanelPermissions.Controls.Add(this.checkBoxRead, 0, 1);
            this.tableLayoutPanelPermissions.Controls.Add(this.lblCreateRoles, 4, 0);
            this.tableLayoutPanelPermissions.Location = new System.Drawing.Point(24, 36);
            this.tableLayoutPanelPermissions.Name = "tableLayoutPanelPermissions";
            this.tableLayoutPanelPermissions.RowCount = 2;
            this.tableLayoutPanelPermissions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPermissions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPermissions.Size = new System.Drawing.Size(555, 100);
            this.tableLayoutPanelPermissions.TabIndex = 11;
            this.tableLayoutPanelPermissions.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // checkBoxDelete
            // 
            this.checkBoxDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxDelete.AutoSize = true;
            this.checkBoxDelete.Location = new System.Drawing.Point(376, 66);
            this.checkBoxDelete.Name = "checkBoxDelete";
            this.checkBoxDelete.Size = new System.Drawing.Size(18, 17);
            this.checkBoxDelete.TabIndex = 7;
            this.checkBoxDelete.UseVisualStyleBackColor = true;
            // 
            // checkBoxUpdate
            // 
            this.checkBoxUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxUpdate.AutoSize = true;
            this.checkBoxUpdate.Location = new System.Drawing.Point(266, 66);
            this.checkBoxUpdate.Name = "checkBoxUpdate";
            this.checkBoxUpdate.Size = new System.Drawing.Size(18, 17);
            this.checkBoxUpdate.TabIndex = 6;
            this.checkBoxUpdate.UseVisualStyleBackColor = true;
            // 
            // checkBoxCreate
            // 
            this.checkBoxCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxCreate.AutoSize = true;
            this.checkBoxCreate.Location = new System.Drawing.Point(156, 66);
            this.checkBoxCreate.Name = "checkBoxCreate";
            this.checkBoxCreate.Size = new System.Drawing.Size(18, 17);
            this.checkBoxCreate.TabIndex = 5;
            this.checkBoxCreate.UseVisualStyleBackColor = true;
            // 
            // lblDelete
            // 
            this.lblDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDelete.AutoSize = true;
            this.lblDelete.Location = new System.Drawing.Point(359, 15);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(53, 20);
            this.lblDelete.TabIndex = 3;
            this.lblDelete.Text = "Delete";
            // 
            // lblUpdate
            // 
            this.lblUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(246, 15);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(58, 20);
            this.lblUpdate.TabIndex = 2;
            this.lblUpdate.Text = "Update";
            // 
            // lblCreate
            // 
            this.lblCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCreate.AutoSize = true;
            this.lblCreate.Location = new System.Drawing.Point(139, 15);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(52, 20);
            this.lblCreate.TabIndex = 1;
            this.lblCreate.Text = "Create";
            // 
            // lblRead
            // 
            this.lblRead.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRead.AutoSize = true;
            this.lblRead.Location = new System.Drawing.Point(34, 15);
            this.lblRead.Name = "lblRead";
            this.lblRead.Size = new System.Drawing.Size(43, 20);
            this.lblRead.TabIndex = 0;
            this.lblRead.Text = "Read";
            // 
            // checkBoxRead
            // 
            this.checkBoxRead.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxRead.AutoSize = true;
            this.checkBoxRead.Location = new System.Drawing.Point(46, 66);
            this.checkBoxRead.Name = "checkBoxRead";
            this.checkBoxRead.Size = new System.Drawing.Size(18, 17);
            this.checkBoxRead.TabIndex = 4;
            this.checkBoxRead.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(355, 430);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(94, 29);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblCreateRoles
            // 
            this.lblCreateRoles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCreateRoles.AutoSize = true;
            this.lblCreateRoles.Location = new System.Drawing.Point(451, 15);
            this.lblCreateRoles.Name = "lblCreateRoles";
            this.lblCreateRoles.Size = new System.Drawing.Size(92, 20);
            this.lblCreateRoles.TabIndex = 8;
            this.lblCreateRoles.Text = "Create Roles";
            // 
            // checkBoxCreateRoles
            // 
            this.checkBoxCreateRoles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxCreateRoles.AutoSize = true;
            this.checkBoxCreateRoles.Location = new System.Drawing.Point(488, 66);
            this.checkBoxCreateRoles.Name = "checkBoxCreateRoles";
            this.checkBoxCreateRoles.Size = new System.Drawing.Size(18, 17);
            this.checkBoxCreateRoles.TabIndex = 9;
            this.checkBoxCreateRoles.UseVisualStyleBackColor = true;
            // 
            // CreateRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.groupBoxPermissions);
            this.Controls.Add(this.lblCreateNewRole);
            this.Controls.Add(this.lblRoleName);
            this.Controls.Add(this.txtRoleName);
            this.Name = "CreateRoleForm";
            this.Text = "CreateRoleForm";
            this.groupBoxPermissions.ResumeLayout(false);
            this.tableLayoutPanelPermissions.ResumeLayout(false);
            this.tableLayoutPanelPermissions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.Label lblCreateNewRole;
        private System.Windows.Forms.GroupBox groupBoxPermissions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPermissions;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Label lblCreate;
        private System.Windows.Forms.Label lblRead;
        private System.Windows.Forms.CheckBox checkBoxDelete;
        private System.Windows.Forms.CheckBox checkBoxUpdate;
        private System.Windows.Forms.CheckBox checkBoxCreate;
        private System.Windows.Forms.CheckBox checkBoxRead;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblCreateRoles;
        private System.Windows.Forms.CheckBox checkBoxCreateRoles;
    }
}