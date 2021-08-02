using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagementLibrary.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool ReadPermission { get; set; }
        public bool CreatePermission { get; set; }
        public bool UpdatePermission { get; set; }
        public bool DeletePermission { get; set; }

        public bool CreateNewRolePermission { get; set; }

        public Role()
        {
            Name = "";
            ReadPermission = false;
            CreatePermission = false;
            UpdatePermission = false;
            DeletePermission = false;
            CreateNewRolePermission = false;
        }
    }
}
