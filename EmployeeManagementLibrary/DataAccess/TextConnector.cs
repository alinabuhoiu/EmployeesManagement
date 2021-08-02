using EmployeeManagementLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeManagementLibrary.DataAccess
{
    class TextConnector : IDataConnection
    {
        public User AddNewUser(User userModel)
        {
            List<User> users = GlobalConfig.UsersFile.FullFilePath().LoadFile().ConvertToUsers();
            List<Role> roles = GlobalConfig.RolesFile.FullFilePath().LoadFile().ConvertToRoles();

            foreach (User u in users)
            {
                if (u.Email == userModel.Email)
                {
                    return null;
                }
            }

            //Set User ID
            int currentId = 1;
            if (users.Count > 0)
            {
                currentId = users.OrderByDescending(e => e.Id).First().Id + 1;
            }

            userModel.Id = currentId;

            userModel.Roles.First().Id = GetDefaultRoleId();

            users.Add(userModel);

            users.SaveToUsersFile();

            return userModel;
        }

        private int GetDefaultRoleId()
        {
            List<Role> roles = GlobalConfig.RolesFile.FullFilePath().LoadFile().ConvertToRoles();

            int currentId = 1;
            if (roles.Count > 0)
            {
                foreach (Role r in roles)
                {
                    if (r.Name == "Employee")
                    {
                        currentId = r.Id;
                        break;
                    }
                }
            }

            return currentId;
        }

        public Role GetEmployeeDefaultRole()
        {
            Role temp = new Role();
            List<Role> roles = GlobalConfig.RolesFile.FullFilePath().LoadFile().ConvertToRoles();

            temp.Name = "Employee";
            temp.ReadPermission = true;
            temp.CreatePermission = false;
            temp.UpdatePermission = false;
            temp.DeletePermission = false;
            temp.CreateNewRolePermission = false;

            //Set Role ID
            int currentId = 1;
            if (roles.Count > 0)
            {
                currentId = roles.OrderByDescending(e => e.Id).First().Id + 1;
            }

            temp.Id = currentId;

            roles.Add(temp);

            return temp;
        }



        public User CheckLoginCredentials(string email, string password)
        {
            List<User> users = GlobalConfig.UsersFile.FullFilePath().LoadFile().ConvertToUsers();

            foreach (User u in users)
            {
                if (u.Email == email && u.Password == password)
                {
                    return u;
                }
            }

            return null;
        }

        public Role AddNewRole(Role role)
        {
            List<Role> roles = GlobalConfig.RolesFile.FullFilePath().LoadFile().ConvertToRoles();

            foreach (Role r in roles)
            {
                if (r.Name == role.Name)
                {
                    return null;
                }
            }

            int currentId = 1;
            if (roles.Count > 0)
            {
                currentId = roles.OrderByDescending(e => e.Id).First().Id + 1;
            }

            role.Id = currentId;

            roles.Add(role);

            roles.SaveToRolesFile();

            return role;
        }

        public List<User> GetAllUsers()
        {
            return GlobalConfig.UsersFile.FullFilePath().LoadFile().ConvertToUsers();
        }

        public List<Role> GetAllRoles()
        {
            return GlobalConfig.RolesFile.FullFilePath().LoadFile().ConvertToRoles();
        }

        public void DeleteUser(User user)
        {
            List<User> users = GlobalConfig.UsersFile.FullFilePath().LoadFile().ConvertToUsers();

            users.RemoveAll(x => x.Id == user.Id);

            users.SaveToUsersFile();
        }

        public User GetUserByEmail(string email)
        {
            List<User> users = GlobalConfig.UsersFile.FullFilePath().LoadFile().ConvertToUsers();

            return users.Where(x => x.Email == email).First();
        }

        public User UpdateUser(int oldUserId, User newUser)
        {
            List<User> users = GlobalConfig.UsersFile.FullFilePath().LoadFile().ConvertToUsers();

            foreach (User u in users)
            {
                if (u.Id == oldUserId)
                {
                    u.Email = newUser.Email;
                    u.Name = newUser.Name;
                    u.Department = newUser.Department;
                    u.Roles = newUser.Roles;

                    users.SaveToUsersFile();

                    return u;
                }
            }

            return null;

        }

        public Role GetManagerDefaultTole()
        {
            Role temp = new Role();
            List<Role> roles = GlobalConfig.RolesFile.FullFilePath().LoadFile().ConvertToRoles();

            temp.Name = "Manager";
            temp.ReadPermission = true;
            temp.CreatePermission = true;
            temp.UpdatePermission = true;
            temp.DeletePermission = true;
            temp.CreateNewRolePermission = true;

            //Set Role ID
            int currentId = 1;
            if (roles.Count > 0)
            {
                currentId = roles.OrderByDescending(e => e.Id).First().Id + 1;
            }

            temp.Id = currentId;

            roles.Add(temp);

            return temp;
        }
    }
}
