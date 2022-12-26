using Super_Shop_Management_System.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Shop_Management_System.Controllers
{
    public class CustomerController
    {
        static Database db = new Database();
        public static Customer AuthenticateCustomer(string username, string password)
        {
            return db.Customers.AuthenticateCustomer(username, password);
        }

        public static bool AddCustomer(dynamic user)
        {
            Customer u = new Customer();
            u.Name = user.Name;
            u.Username = user.Username;
            u.Password = user.Password;
            //var u = (User)user;//boxing---> it was not working because this is user type and registration form btnclick is anonymous type

            return db.Customers.AddCustomer(u);
        }

        public static Customer GetCustomer(string username)
        {
            return db.Customers.GetCustomer(username);
        }

        public static bool UpdateCustomer(dynamic user)
        {
            Customer u = new Customer();
            u.Username = user.Username;
            u.Name = user.Name;

            return db.Customers.UpdateCustomer(u);
        }
        public static bool DeleteCustomer(string username)
        {
            return db.Customers.DeleteCustomer(username);
        }
        public static ArrayList GetAllCustomers()
        {
            return db.Customers.GetAllCustomers();
        }
    }
}
