using Super_Shop_Management_System.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Shop_Management_System.Controllers
{
    public class AdminController
    {
        static Database db1 = new Database();
        public static Admin AuthenticateAdmin(string username, string password)
        {
            return db1.Admins.AuthenticateAdmin(username, password);
        }

        public static bool AddAdmin(dynamic user)
        {
            Admin u = new Admin();
            u.Name = user.Name;
            u.Username = user.Username;
            u.Password = user.Password;
            //var u = (User)user;//boxing---> it was not working because this is user type and registration form btnclick is anonymous type

            return db1.Admins.AddAdmin(u);
        }

        public static Admin GetAdmin(string username)
        {
            return db1.Admins.GetAdmin(username);
        }

        public static bool UpdateAdmin(dynamic user)
        {
            Admin u = new Admin();
            u.Username = user.Username;
            u.Name = user.Name;

            return db1.Admins.UpdateAdmin(u);
        }
        public static bool DeleteAdmin(string username)
        {
            return db1.Admins.DeleteAdmin(username);
        }
        public static ArrayList GetAllAdmins()
        {
            return db1.Admins.GetAllAdmins();
        }
    }
}
