using EmployeeManagementLibrary.Models;
using System;
using System.Collections.Generic;

namespace EmployeeManagementLibrary.DataAccess
{
    class SqlConnector : IDataConnection
    {
        public Role AddNewRole(Role role)
        {
            throw new NotImplementedException();
        }

        public User AddNewUser(User model)
        {
            throw new NotImplementedException();
        }

        public User CheckLoginCredentials(string email, string password)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public List<Role> GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Role GetEmployeeDefaultRole()
        {
            throw new NotImplementedException();
        }

        public Role GetManagerDefaultTole()
        {
            throw new NotImplementedException();
        }

        public User GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(int oldUserId, User newUser)
        {
            throw new NotImplementedException();
        }
    }
}
