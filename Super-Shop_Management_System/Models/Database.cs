using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Shop_Management_System.Models
{
    public class Database
    {
        public Customers Customers { get; set; }

        public Admins Admins { get; set; }

        public Employees Employees { get; set; }

        public Managers Managers { get; set; }

        public Products Products { get; set; }

        public Categories Categories { get; set; }


        public Database()
        {
            string connString = "Server=DESKTOP-HE0MQ0Q\\SQLEXPRESS;Integrated Security=true;Database=super-shop_m_s";
            SqlConnection conn = new SqlConnection(connString);
            SqlConnection conn1 = new SqlConnection(connString);
            SqlConnection conn2 = new SqlConnection(connString);
            SqlConnection conn3 = new SqlConnection(connString);
            SqlConnection conn4 = new SqlConnection(connString);
            Customers = new Customers(conn);
            Admins = new Admins(conn1);
            Employees = new Employees(conn2);
            Managers = new Managers(conn3);
            Products = new Products(conn4);
            Categories = new Categories();
        }
    }
}
