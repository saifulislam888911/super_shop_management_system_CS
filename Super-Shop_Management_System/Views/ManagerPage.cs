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
    public partial class ManagerPage : Form
    {
        public ManagerPage()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string username = textBoxSearch.Text;
            dynamic user = CustomerController.GetCustomer(username);
            dynamic user1 = EmployeeController.GetEmployee(username);
            if (user != null)
            {
                textBoxName.Text = user.Name;
                textBoxUsername.Text = user.Username;
            }
            else if(user1 != null)
            {
                textBoxName.Text = user1.Name;
                textBoxUsername.Text = user1.Username;
            }
            else
            {
                textBoxName.Text = "";
                textBoxUsername.Text = "";
                MessageBox.Show("No Employee Found");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
        }

        private void btnEmployeeInformation_Click(object sender, EventArgs e)
        {
            new EmployeeAllinformation().Show();
        }

        private void btnCustomerInformation_Click(object sender, EventArgs e)
        {
            new CustomerAllinfomation().Show();
        }

        private void btnProductInformation_Click(object sender, EventArgs e)
        {
            new AllProductsList().Show();
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            new NewProductAdd().Show();
        }
    }
}
