using EmployeeManagementLibrary.Models;
using System.Collections.Generic;

namespace EmployeeManagementLibrary.DataAccess
{
    public interface IDataConnection
    {
        User AddNewUser(User user);
        User CheckLoginCredentials(string email, string password);
        Role AddNewRole(Role role);
        Role GetEmployeeDefaultRole();
        Role GetManagerDefaultTole();
        List<User> GetAllUsers();
        List<Role> GetAllRoles();
        void DeleteUser(User user);
        User GetUserByEmail(string email);
        User UpdateUser(int oldUserId, User newUser);
    }
}
