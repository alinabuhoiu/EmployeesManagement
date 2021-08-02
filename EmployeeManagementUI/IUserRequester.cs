using EmployeeManagementLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagementUI
{
    public interface IUserRequester
    {
        void UserComplete(User user);
    }
}
