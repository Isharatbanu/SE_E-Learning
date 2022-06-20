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

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Homepage h = new Homepage();
            h.Show();
            this.Hide();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {

        }

        private void buttonViewUser_Click(object sender, EventArgs e)
        {

        }
    }
}
