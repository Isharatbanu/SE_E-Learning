using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace E_Learning_Platform
{
    public partial class Homepage : Form
    {
        
        StudentRegister std = new StudentRegister();
        public Homepage()
        {
            InitializeComponent();
        }

        private void StudentRegisteration(object sender, EventArgs e)
        {
            std.Show();
            this.Hide();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Homepage h = new Homepage();
            h.Show();
            this.Hide();
        }

        private void AdminLoginButton_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            if ((AdminUsername.Text.Equals("Admin")) && (AdminPassword.Text.Equals("Pass")))
            {
                MessageBox.Show("Login Successfull !!","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                a.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please check your Username & Password !!", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);  //red cross
            }

        }

        private void AdminUsername_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(AdminUsername.Text))
            {
                e.Cancel = true;
                AdminUsername.Focus();
                errorProvider1.SetError(AdminUsername, "Please enter Username!!");
                //MessageBox.Show(AdminUsername.Text, "Please enter Username !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);    
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(AdminUsername, null);
            }
           
        }

        private void AdminPassword_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(AdminPassword.Text))
            {
                e.Cancel = true;
                AdminPassword.Focus();
                errorProvider1.SetError(AdminPassword, "Please enter Password !!");
               // MessageBox.Show(AdminPassword.Text, "Please enter Password !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(AdminPassword, null);
            }
        }

        private void msg_Click(object sender, EventArgs e)
        {

        }

        private void msg_Click_1(object sender, EventArgs e)
        {

        }

        private void clearAll()
        {
            Action<Control.ControlCollection> func = null;
            func = (Controls) =>
            {
                foreach (Control control in Controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to clear all fields ??", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                clearAll();
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            if(AdminPassword.PasswordChar=='*')
            {
                buttonHide.BringToFront();
                AdminPassword.PasswordChar = '\0';
            }
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            if (AdminPassword.PasswordChar == '\0')
            {
                buttonShow.BringToFront();
                AdminPassword.PasswordChar = '*';
            }
        }

        private void buttonExit_DoubleClick(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == System.Windows.Forms.DialogResult.Yes)
            {
                StudentRegister st = new StudentRegister();
                Application.Exit();
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

        }
    }
}
