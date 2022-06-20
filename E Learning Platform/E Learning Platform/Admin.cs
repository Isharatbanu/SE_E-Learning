using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Learning_Platform
{
    public partial class Admin : Form
    {
        
        public Admin()
        {
            InitializeComponent();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = true;
            uC_Dashboard1.BringToFront();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Homepage h = new Homepage();
            h.Show();
            this.Hide();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            uC_AddUser1.Visible = true;
            uC_AddUser1.BringToFront();
        }

        private void buttonViewUser_Click(object sender, EventArgs e)
        {
            uC_ViewUser1.Visible = true;
            uC_ViewUser1.BringToFront();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = false;
            uC_ViewUser1.Visible = false;
            uC_AddUser1.Visible = false;
            buttonDashboard.PerformClick();
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
