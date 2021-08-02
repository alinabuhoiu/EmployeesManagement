using EmployeeManagementLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagementLibrary
{
    public static class GlobalConfig
    {

        public const string UsersFile = "Users.csv";
        public const string RolesFile = "Roles.csv";
        public const string LogFile = "_log.txt";
        public static IDataConnection Connection { get; private set; }
        public static void InitializeConnections(DatabaseType db)
        {
            switch (db)
            {
                case DatabaseType.Sql:
                    Connection = new SqlConnector();
                    break;
                case DatabaseType.TextFile:
                    Connection = new TextConnector();
                    break;
                default:
                    break;
            }
        }
    }
}
