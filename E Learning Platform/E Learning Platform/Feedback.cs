using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace E_Learning_Platform
{
    public partial class Feedback : Form
    {
        String Mail_pattern = @"^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]";
        public Feedback()
        {
            InitializeComponent();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
           
            if(textBoxName.Text != "" && textBoxEmail.Text!= "" && textBoxMsg.Text != "")
            {
                Homepage h = new Homepage();
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-8V3S77O;Initial Catalog=ELearning; Integrated Security=True");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Feedback] 
                    (
                      [Username],
                      [Email],
                      [Message],
                      [Rating]  
                    )
                    VALUES
                    (
                       '" + textBoxName.Text + "', " +
                       "'" + textBoxEmail.Text + "'," +
                       "'" + textBoxMsg.Text + "'," +
                       " '"+ textBoxRate.Text +"')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                clearAll();
                MessageBox.Show("Thank you! Visit again", "Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);

                h.Show();
                this.Close();
                
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

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxName.Text))
            {
                e.Cancel = true;
                textBoxName.Focus();
                errorProvider1.SetError(textBoxName, "Please enter your name !!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBoxName, null);
            }
        }

        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxEmail.Text))
            {
                e.Cancel = true;
                textBoxEmail.Focus();
                errorProvider1.SetError(textBoxEmail, "Please enter your email !!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBoxEmail, null);
            }
        }

        private void textBoxMsg_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxMsg.Text))
            {
                e.Cancel = true;
                textBoxMsg.Focus();
                errorProvider1.SetError(textBoxMsg, "Please give us your feedback !!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBoxMsg, null);
            }
        }

        private void RatingStar_ValueChanged(object sender, EventArgs e)
        {
            float x = RatingStar.Value;
            
                textBoxRate.Text = x.ToString();
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBoxEmail.Text, Mail_pattern) == false)
            {
                textBoxEmail.Focus();
                errorProvider1.SetError(textBoxEmail, "Please enter valid email.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
