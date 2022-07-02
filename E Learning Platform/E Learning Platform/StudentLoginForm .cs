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
    public partial class StudentLoginForm : Form
    {
        StudentDetailForm sdf = new StudentDetailForm();
        
        public StudentLoginForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8V3S77O;Initial Catalog=ELearning; Integrated Security=True");
        private void StudentLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            UserName.Clear();
            PassWord.Clear();

            UserName.Focus();
        }

      

        private void ButtonShow_Click(object sender, EventArgs e)
        {
            if (PassWord.PasswordChar == '*')
            {
                ButtonHide.BringToFront();
                PassWord.PasswordChar = '\0';
            }
        }

        private void ButtonHide_Click(object sender, EventArgs e)
        {
            if (PassWord.PasswordChar == '\0')
            {
                ButtonShow.BringToFront();
                PassWord.PasswordChar = '*';
            }
        }

        private void UserName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(UserName.Text))
            {
                e.Cancel = true;
                UserName.Focus();
                errorProvider1.SetError(UserName, "Please enter Username !!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(UserName, null);
            }
        }

        private void PassWord_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(PassWord.Text))
            {
                e.Cancel = true;
                PassWord.Focus();
                errorProvider1.SetError(PassWord, "Please enter Password !!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(PassWord, null);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String user_name, pass_word;
            user_name = UserName.Text;
            pass_word = PassWord.Text;

            try
            {
                String qr = "SELECT * FROM StudentRegister WHERE Username = '"+ UserName.Text +"'AND Password = '"+ PassWord.Text +"' ";
                SqlDataAdapter sda = new SqlDataAdapter(qr, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0)
                {
                    user_name = UserName.Text;
                    pass_word = PassWord.Text;

                    sdf.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please check username & password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UserName.Clear();
                    PassWord.Clear();
                }

            }
            catch
            {
                MessageBox.Show("Invalid login details!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                UserName.Clear();
                PassWord.Clear();

                UserName.Focus();
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
