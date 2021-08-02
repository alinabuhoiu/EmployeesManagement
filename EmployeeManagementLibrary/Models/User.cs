using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagementLibrary.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public string Password { get; set; }
        public List<Role> Roles { get; set; } = new List<Role>();
        public User(string name, string email, string department, string password)
        {
            this.Name = name;
            this.Email = email;
            this.Department = department;
            this.Password = password;

            Roles.Add(new Role
            {
                Name = "Employee",
                ReadPermission = true,
                CreatePermission = false,
                UpdatePermission = false,
                DeletePermission = false
            });
        }
        public User()
        {
            Id = -1;
            Name = "";
            Email = "";
            Department = "";
            Password = "";
            Roles = new List<Role>();
        }

        public bool CreatePermission()
        {
            foreach (Role r in Roles)
            {
                if (r.CreatePermission)
                {
                    return true;
                }
            }

            return false;
        }

        public bool UpdatePermission()
        {
            foreach (Role r in Roles)
            {
                if (r.UpdatePermission)
                {
                    return true;
                }
            }

            return false;
        }

        public bool DeletePermission()
        {
            foreach (Role r in Roles)
            {
                if (r.DeletePermission)
                {
                    return true;
                }
            }

            return false;
        }

        public bool CreateNewRolePermission()
        {
            foreach (Role r in Roles)
            {
                if (r.CreateNewRolePermission)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
