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
    public partial class EmployeePage : Form
    {
        public EmployeePage()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string username = textBoxSearch.Text;
            dynamic user = CustomerController.GetCustomer(username);
            if (user != null)
            {
                textBoxCustName.Text = user.Name;
                textBoxCustUsername.Text = user.Username;
            }
            else
            {
                textBoxCustName.Text = "";
                textBoxCustUsername.Text = "";
                MessageBox.Show("No Employee Found");
            }
        }

        private void btnCustomerInformation_Click(object sender, EventArgs e)
        {
            new CustomerAllinfomation().Show();
        }

        private void btnProductInformation_Click(object sender, EventArgs e)
        {
            new AllProductsList().Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
        }
    }
}
