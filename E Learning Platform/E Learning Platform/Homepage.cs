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
        StudentCorner sc = new StudentCorner();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8V3S77O;Initial Catalog=ELearning; Integrated Security=True");
        //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-6OCFE43M;Initial Catalog=ELearning;Integrated Security=True");

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
            /* Admin a = new Admin();
            if ((AdminUsername.Text.Equals("Admin")) && (AdminPassword.Text.Equals("Pass")))
            {
                MessageBox.Show("Login Successfull !!","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                a.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please check your Username & Password !!", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);  //red cross
            } */

            Admin a = new Admin();
            // String user_name, pass_word;
            //user_name = AdminUsername.Text;
            //pass_word = AdminPassword.Text;

            /*
             String qr = "SELECT * FROM Admin WHERE Username = '" + AdminUsername.Text.Trim() + "'AND Password = '" + AdminPassword.Text.Trim() + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(qr, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count == 1)
            {
                MessageBox.Show("Login Successfull!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                a.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("error");
            }
             */

            try
            {
                 String qr = "SELECT * FROM Admin WHERE Username = '" + AdminUsername.Text + "'AND Password = '" + AdminPassword.Text + "' ";
                 SqlDataAdapter sda = new SqlDataAdapter(qr, conn);

                 DataTable dtable = new DataTable();
                 sda.Fill(dtable);

                 if (dtable.Rows.Count > 0)
                 {
                     //user_name = AdminUsername.Text;
                     //pass_word = AdminPassword.Text;

                     MessageBox.Show("Login Successfull!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     a.Show();
                     this.Hide();
                 }
                 else
                 {
                     MessageBox.Show("Please check username & password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     AdminUsername.Clear();
                     AdminPassword.Clear();
                 }

             }
             catch
             {
                 MessageBox.Show("Invalid login details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 AdminUsername.Clear();
                 AdminPassword.Clear();

                 AdminUsername.Focus();
             }
             finally
             {
                 conn.Close();
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

        

        private void buttonStudentCorner_Click(object sender, EventArgs e)
        {
            sc.Show();
            this.Hide();
        }

        private void ButtonFeedback_Click(object sender, EventArgs e)
        {
            Feedback f = new Feedback();
            f.Show();
            this.Hide();
           
        }

        private void ForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sendOTP sotp = new sendOTP();
            sotp.Show();
            this.Hide();

        }
    }
}
