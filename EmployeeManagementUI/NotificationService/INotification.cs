using EmployeeManagementLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagementUI.NotificationService
{
    public interface INotification
    {
        void Notify(string message);
    }
}
