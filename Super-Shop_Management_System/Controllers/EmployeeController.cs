using Super_Shop_Management_System.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Shop_Management_System.Controllers
{
    public class EmployeeController
    {
        static Database db2 = new Database();
        public static Employee AuthenticateEmployee(string username, string password)
        {
            return db2.Employees.AuthenticateEmployee(username, password);
        }

        public static bool AddEmployee(dynamic user)
        {
            Employee u = new Employee();
            u.Name = user.Name;
            u.Username = user.Username;
            u.Password = user.Password;
            //var u = (User)user;//boxing---> it was not working because this is user type and registration form btnclick is anonymous type

            return db2.Employees.AddEmployee(u);
        }

        public static Employee GetEmployee(string username)
        {
            return db2.Employees.GetEmployee(username);
        }

        public static bool UpdateEmployee(dynamic user)
        {
            Employee u = new Employee();
            u.Username = user.Username;
            u.Name = user.Name;

            return db2.Employees.UpdateEmployee(u);
        }
        public static bool DeleteEmployee(string username)
        {
            return db2.Employees.DeleteEmployee(username);
        }
        public static ArrayList GetAllEmployees()
        {
            return db2.Employees.GetAllEmployees();
        }
    }
}
