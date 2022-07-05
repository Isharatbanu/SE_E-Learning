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


namespace E_Learning_Platform
{
    public partial class ChangePassword : Form
    {
        //String username = sendOTP.to;
        String uname = "Admin";
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            if(TextBoxnewPassword.Text == TextBoxConfirmPassword.Text)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-8V3S77O;Initial Catalog=ELearning; Integrated Security=True");
                SqlCommand cmd = new SqlCommand("UPDATE Admin set Password = '"+TextBoxnewPassword.Text+"' where Username='"+uname+"' ",con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Password reset successful!","",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Password reset unsuccessful,Please try again!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
