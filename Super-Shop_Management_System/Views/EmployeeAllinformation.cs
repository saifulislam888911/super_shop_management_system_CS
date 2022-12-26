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
    public partial class EmployeeAllinformation : Form
    {
        public EmployeeAllinformation()
        {
            InitializeComponent();
            var ds = EmployeeController.GetAllEmployees();
            dataGridViewEmployeeInfo.DataSource = ds;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string username = textBoxSearch.Text;
            dynamic user = EmployeeController.GetEmployee(username);
            if (user != null)
            {
                textBoxName.Text = user.Name;
                textBoxUsername.Text = user.Username;
            }
            else
            {
                textBoxName.Text = "";
                textBoxUsername.Text = "";
                MessageBox.Show("No Employee Found");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var user = new
            {
                Name = textBoxName.Text,
                Username = textBoxUsername.Text
            };
            bool result = EmployeeController.UpdateEmployee(user);
            if (result)
            {
                MessageBox.Show("User Updated");
            }
            else
            {
                MessageBox.Show("Could not Update");
            }
            var ds = EmployeeController.GetAllEmployees();
            dataGridViewEmployeeInfo.DataSource = ds;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var r = EmployeeController.DeleteEmployee(textBoxUsername.Text);
            if (r)
            {
                MessageBox.Show("Employee Deleted");
            }
            else
            {
                MessageBox.Show("Could not Delete");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new AdminPage().Show();
        }

        private void dataGridViewEmployeeInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ManagerPage().Show();
        }
    }
}
