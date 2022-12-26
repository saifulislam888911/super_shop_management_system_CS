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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
            
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

        }

        private void btnProductInformation_Click(object sender, EventArgs e)
        {
            new AllProductsList().Show();
        }

        private void btnCustomerInformation_Click(object sender, EventArgs e)
        {
            new CustomerAllinfomation().Show();
        }

        private void btnEmployeeInformation_Click(object sender, EventArgs e)
        {
            new EmployeeAllinformation().Show();
        }

        private void btnManagerInformation_Click(object sender, EventArgs e)
        {
            new ManagerAllInformation().Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string username = textBoxSearch.Text;
            //string name = textBoxSearch.Text;
            dynamic user = AdminController.GetAdmin(username);
            dynamic user1 = CustomerController.GetCustomer(username);
            dynamic user2 = ManagerController.GetManager(username);
            dynamic user3 = EmployeeController.GetEmployee(username);
            dynamic user4 = ProductController.GetProduct(username);

            if (user != null)
            {
                textBoxName.Text = user.Name;
                textBoxUsername.Text = user.Username;

                //textBoxName.Text = user2.Name;
                //textBoxUsername.Text = user2.Username;

              
            }
            else if(user1 != null)
            {
                textBoxName.Text = user1.Name;
                textBoxUsername.Text = user1.Username;
            }
            else if (user2 != null)
            {
                textBoxName.Text = user2.Name;
                textBoxUsername.Text = user2.Username;
            }
            else if (user3 != null)
            {
                textBoxName.Text = user3.Name;
                textBoxUsername.Text = user3.Username;
            }
            else if (user4 != null)
            {
                textBoxProductName.Text = user4.Name;
                
            }
            else
            {
                textBoxName.Text = "";
                textBoxUsername.Text = "";
                textBoxProductName.Text = "";
                MessageBox.Show("No User Found");

               
            }
        }

        private void dataGridViewManagerInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AdminAccountInformation().Show();
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            new NewProductAdd().Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
        }
    }
}
