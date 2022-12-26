using Super_Shop_Management_System.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Shop_Management_System.Controllers
{
    public class ManagerController
    {
        static Database db3 = new Database();
        public static Manager AuthenticateManager(string username, string password)
        {
            return db3.Managers.AuthenticateManager(username, password);
        }

        public static bool AddManager(dynamic user)
        {
            Manager u = new Manager();
            u.Name = user.Name;
            u.Username = user.Username;
            u.Password = user.Password;
            //var u = (User)user;//boxing---> it was not working because this is user type and registration form btnclick is anonymous type

            return db3.Managers.AddManager(u);
        }

        public static Manager GetManager(string username)
        {
            return db3.Managers.GetManager(username);
        }

        public static bool UpdateManager(dynamic user)
        {
            Manager u1 = new Manager();
            u1.Username = user.Username;
            u1.Name = user.Name;

            return db3.Managers.UpdateManager(u1);
        }
        public static bool DeleteManager(string username)
        {
            return db3.Managers.DeleteManager(username);
        }
        public static ArrayList GetAllManagers()
        {
            return db3.Managers.GetAllManagers();
        }
    }
}
