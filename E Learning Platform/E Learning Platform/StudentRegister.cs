using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace E_Learning_Platform
{
    public partial class StudentRegister : Form
    {
        String pattern = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{6,}$";
        String Name_pattern = @"^([a-zA-Z\s]+$)";
        String Mobile_pattern = @"^[6-9]{1}[0-9]{9}$";
        String Mail_pattern = @"^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]";
        String Num_pattern = @"^[1-9]+$";

        StudentLoginForm slf = new StudentLoginForm();
       
        public StudentRegister()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void textUsername_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textUsername.Text))
            {
                e.Cancel = true;
                textUsername.Focus();
                errorProvider1.SetError(textUsername, "Please enter Username !!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textUsername, null);
            }
        }

        private void textLastname_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textLastname.Text))
            {
                e.Cancel = true;
                textLastname.Focus();
                errorProvider1.SetError(textLastname, "Please enter Lastname!!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textLastname, null);
            }

        }

        private void textRoll_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textRoll.Text))
            {
                e.Cancel = true;
                textRoll.Focus();
                errorProvider1.SetError(textRoll, "Please enter Roll no !!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textRoll, null);
            }
        }

        private void textEmail_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textEmail.Text))
            {
                e.Cancel = true;
                textEmail.Focus();
                errorProvider1.SetError(textEmail, "Please enter Email ID !!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textEmail, null);
            }
        }

        private void textMobile_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textMobile.Text))
            {
                e.Cancel = true;
                textMobile.Focus();
                errorProvider1.SetError(textMobile, "Please enter Mobile no !!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textMobile, null);
            }
        }

        private void ComboBlood_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(ComboBlood.Text))
            {
                e.Cancel = true;
                ComboBlood.Focus();
                errorProvider1.SetError(ComboBlood, "Please select appropriate Blood group !!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(ComboBlood, null);
            }
        }

        private void textAddress_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textAddress.Text))
            {
                e.Cancel = true;
                textAddress.Focus();
                errorProvider1.SetError(textAddress, "Please enter Address !!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textAddress, null);
            }
        }

        private void textPass_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textPass.Text))
            {
                e.Cancel = true;
                textPass.Focus();
                errorProvider1.SetError(textPass, "Please enter Password!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textPass, null);
            }
        }

        private void textPassConfirm_Validating(object sender, CancelEventArgs e)
        {

            if (String.IsNullOrEmpty(textPassConfirm.Text))
            {
                e.Cancel = true;
                textPassConfirm.Focus();
                errorProvider1.SetError(textPassConfirm, "Please enter Password!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textPassConfirm, null);
            }
        }

        private void textPassConfirm_TextChanged(object sender, EventArgs e)
        {
            if (textPass.Text != textPassConfirm.Text)
            {
                errorProvider1.SetError(textPassConfirm, "Both password should be same !!");

            }
        }

        private void ButtonExit(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == System.Windows.Forms.DialogResult.Yes)
            {
                StudentRegister st = new StudentRegister();
                Application.Exit();
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8V3S77O;Initial Catalog=ELearning; Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[StudentRegister]
           ([Username]
           ,[Lastname]
           ,[Roll]
           ,[Email]
           ,[Mobile]
           ,[Blood]
           ,[Address]
           ,[Password])
     VALUES 
            ('" + textUsername.Text + "','" + textLastname.Text + "', '" + textRoll.Text + "', '" + textEmail.Text + "', " +
            "'" + textMobile.Text + "', '" + ComboBlood.SelectedItem.ToString() + "', '" + textAddress.Text + "', '" + textPass.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            clearAll();
            ComboBlood.Text = String.Empty;
            MessageBox.Show("Registration successfull !!", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void textPass_Leave(object sender, EventArgs e)
        {
            if(Regex.IsMatch(textPass.Text,pattern) == false)
            {
                textPass.Focus();
                errorProvider2.SetError(textPass,"Password should have 6 characters having at least one Upper case letter, Lower case letter," +
                    " numric character, special character each !!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void textUsername_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textUsername.Text, Name_pattern) == false)
            {
                textUsername.Focus();
                errorProvider2.SetError(textUsername, "Please enter characters only !!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void textLastname_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textLastname.Text, Name_pattern) == false)
            {
                textLastname.Focus();
                errorProvider2.SetError(textLastname, "Please enter characters only !!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void textMobile_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textMobile.Text, Mobile_pattern) == false)
            {
                textMobile.Focus();
                errorProvider2.SetError(textMobile, "Please enter valid mobile !!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void textEmail_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textEmail.Text, Mail_pattern) == false)
            {
                textEmail.Focus();
                errorProvider2.SetError(textEmail, "Please enter valid email !!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void textRoll_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textRoll.Text, Num_pattern) == false)
            {
                textRoll.Focus();
                errorProvider2.SetError(textRoll, "Please enter numbers only !!");
            }
            else
            {
                errorProvider2.Clear();
            }
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
        private void ButtonClear_click(object sender, EventArgs e)
        {
            DialogResult ra = MessageBox.Show("Are you sure you want to clear all fields ??", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ra == System.Windows.Forms.DialogResult.Yes)
            {
                clearAll();
                ComboBlood.Text = String.Empty;
            }
             
        }

        private void LoginStudentLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            slf.Show();
            this.Hide();
        }
    }
}
