using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.IO;
using System.Linq;
using EmployeeManagementLibrary.Models;

namespace EmployeeManagementLibrary.DataAccess
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string filename)
        {
            return $"{ ConfigurationManager.AppSettings["filePath"] }\\{ filename }";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<Role> ConvertToRoles(this List<string> lines)
        {
            List<Role> output = new List<Role>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                Role r = new Role();
                r.Id = int.Parse(cols[0]);
                r.Name = cols[1];
                r.ReadPermission = cols[2] == "1" ? true : false;
                r.CreatePermission = cols[3] == "1" ? true : false;
                r.UpdatePermission = cols[4] == "1" ? true : false;
                r.DeletePermission = cols[5] == "1" ? true : false;
                r.CreateNewRolePermission = cols[6] == "1" ? true : false;

                output.Add(r);
            }

            return output;
        }

        public static List<User> ConvertToUsers(this List<string> lines)
        {
            List<User> output = new List<User>();
            List<Role> roles = GlobalConfig.RolesFile.FullFilePath().LoadFile().ConvertToRoles();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                User u = new User();
                u.Id = int.Parse(cols[0]);
                u.Name = cols[1];
                u.Email = cols[2];
                u.Department = cols[3]; 
                u.Password = cols[4];

                string[] rolesIds = cols[5].Split('|');

                foreach (string id in rolesIds)
                {
                    u.Roles.Add(roles.Where(x => x.Id == int.Parse(id)).First());
                }

                output.Add(u);
            }

            return output;
        }

        public static void SaveToUsersFile(this List<User> users)
        {
            List<string> lines = new List<string>();

            foreach (User u in users)
            {
                lines.Add($"{ u.Id },{ u.Name },{ u.Email },{ u.Department },{ u.Password },{ ConvertRoleListToString(u.Roles) }");
            }

            File.WriteAllLines(GlobalConfig.UsersFile.FullFilePath(), lines);
        }

        public static void SaveToRolesFile(this List<Role> roles)
        {
            List<string> lines = new List<string>();

            foreach (Role r in roles)
            {
                lines.Add($"{ r.Id },{ r.Name },{ ConvertPermissionsToString(r) }");
            }

            File.WriteAllLines(GlobalConfig.RolesFile.FullFilePath(), lines);
        }

        private static object ConvertPermissionsToString(Role r)
        {
            string output = "";

            if (r.ReadPermission)
            {
                output += "1,";
            }
            else
            {
                output += "0,";
            }

            if (r.CreatePermission)
            {
                output += "1,";
            }
            else
            {
                output += "0,";
            }

            if (r.UpdatePermission)
            {
                output += "1,";
            }
            else
            {
                output += "0,";
            }

            if (r.DeletePermission)
            {
                output += "1,";
            }
            else
            {
                output += "0,";
            }

            if (r.CreateNewRolePermission)
            {
                output += "1,";
            }
            else
            {
                output += "0,";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertRoleListToString(List<Role> roles)
        {
            if (roles.Count == 0)
            {
                return "";
            }

            string output = "";
            foreach (Role role in roles)
            {
                output += $"{ role.Id }|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }

    }
}
