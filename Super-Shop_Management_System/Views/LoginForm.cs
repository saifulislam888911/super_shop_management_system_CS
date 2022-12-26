using Super_Shop_Management_System.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Shop_Management_System.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            var result = CustomerController.AuthenticateCustomer(username, password);
            if (result != null)
            {
                new CustomerPage().Show();
            }
            else
            {
                MessageBox.Show("Customer Not Valid");
            }

            var result1 = AdminController.AuthenticateAdmin(username, password);
            if (result1 != null)
            {
                new AdminPage().Show();
            }
            else
            {
                MessageBox.Show("Admin Not Valid");
            }

            var result2 = EmployeeController.AuthenticateEmployee(username, password);
            if (result2 != null)
            {
                new EmployeePage().Show();
            }
            else
            {
                MessageBox.Show("Employee Not Valid");
            }

            var result3 = ManagerController.AuthenticateManager(username, password);
            if (result3 != null)
            {
                new ManagerPage().Show();
            }
            else
            {
                MessageBox.Show("Manager Not Valid");
            }
        }

        private void btnNotRegister_Click(object sender, EventArgs e)
        {
            new RegistrationForm().Show();
        }
    }
}
