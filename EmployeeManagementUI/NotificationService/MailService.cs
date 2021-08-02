using EmployeeManagementLibrary.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace EmployeeManagementUI.NotificationService
{
    public class MailService : INotification
    {
        public string EmailAddress { get; set; }

        public MailService(string emailAddress)
        {
            this.EmailAddress = emailAddress;
        }
        public void Notify(string message)
        {
            Debug.WriteLine("Email service invoked... Sending email to " + EmailAddress);
            Debug.WriteLine("Message text: " + message);
        }
    }
}
