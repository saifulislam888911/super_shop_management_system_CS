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
    public partial class ManagerAllInformation : Form
    {
        public ManagerAllInformation()
        {
            InitializeComponent();
            var ds = ManagerController.GetAllManagers();
            dataGridViewManagerInfo.DataSource = ds;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string username = textBoxSearch.Text;
            dynamic user = ManagerController.GetManager(username);
            if (user != null)
            {
                textBoxName.Text = user.Name;
                textBoxUsername.Text = user.Username;
            }
            else
            {
                textBoxName.Text = "";
                textBoxUsername.Text = "";
                MessageBox.Show("No Manager Found");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var user = new
            {
                Name = textBoxName.Text,
                Username = textBoxUsername.Text
            };
            bool result = ManagerController.UpdateManager(user);
            if (result)
            {
                MessageBox.Show("User Updated");
            }
            else
            {
                MessageBox.Show("Could not Update");
            }
            var ds = ManagerController.GetAllManagers();
            dataGridViewManagerInfo.DataSource = ds;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var r = ManagerController.DeleteManager(textBoxUsername.Text);
            if (r)
            {
                MessageBox.Show("Manager Deleted");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }
    }
}
