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
    public partial class StudentDetailForm : Form
    {
        String Name_pattern = @"^([a-zA-Z\s]+$)";
        String Mobile_pattern = @"^[6-9]{1}[0-9]{9}$";
        String Mail_pattern = @"^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]";
        //String Num_pattern = @"^[1-9]+$";
        String Marks_pattern = "([0-9]*[.])?[0-9]+";
        String Aadhar_pattern = @"^[2-9]{1}[0-9]{11}$";
        public StudentDetailForm()
        {
            InitializeComponent();
        }


        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            /* String imageLocation = "";
                try {
                 OpenFileDialog dialog = new OpenFileDialog();
                 dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

                 if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                     imageLocation = dialog.FileName;

                     pictureBoxPhoto.ImageLocation = imageLocation;
                 }


             }
             catch(Exception) {
                 MessageBox.Show("An error occured while browsing file.","",MessageBoxButtons.OK,MessageBoxIcon.Error);
             } */

            openFileDialog1.Filter = "Select image(*.jpg; *.png; *.Gif) | *.jpg; *.png; *.Gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPhoto.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void textFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textFirstName.Text))
            {
                e.Cancel = true;
                textFirstName.Focus();
                errorProvider1.SetError(textFirstName, "Please enter First name !!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textFirstName, null);
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

        private void comboBoxGender_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(comboBoxGender.Text))
            {
                e.Cancel = true;
                comboBoxGender.Focus();
                errorProvider1.SetError(comboBoxGender, "Please select Gender !!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(comboBoxGender, null);
            }
        }

        private void ComboBlood_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(ComboBlood.Text))
            {
                e.Cancel = true;
                ComboBlood.Focus();
                errorProvider1.SetError(ComboBlood, "Please select Blood group !!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(ComboBlood, null);
            }
        }

        private void textBoxAadhar_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxAadhar.Text))
            {
                e.Cancel = true;
                textBoxAadhar.Focus();
                errorProvider1.SetError(textBoxAadhar, "Please enter Aadhar no !!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBoxAadhar, null);
            }
        }

        private void textBoxSSC_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxSSC.Text))
            {
                e.Cancel = true;
                textBoxSSC.Focus();
                errorProvider1.SetError(textBoxSSC, "Please enter SSC marks !!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBoxSSC, null);
            }
        }

        private void textBoxHSC_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxHSC.Text))
            {
                e.Cancel = true;
                textBoxHSC.Focus();
                errorProvider1.SetError(textBoxHSC, "Please enter HSC marks !!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBoxHSC, null);
            }
        }

        private void textBoxFatherName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxFatherName.Text))
            {
                e.Cancel = true;
                textBoxFatherName.Focus();
                errorProvider1.SetError(textBoxFatherName, "Please enter Father name !!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBoxFatherName, null);
            }
        }

        private void textBoxMotherName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxMotherName.Text))
            {
                e.Cancel = true;
                textBoxMotherName.Focus();
                errorProvider1.SetError(textBoxMotherName, "Please enter Mother name !!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBoxMotherName, null);
            }
        }

        private void textFirstName_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textFirstName.Text, Name_pattern) == false)
            {
                textFirstName.Focus();
                errorProvider2.SetError(textFirstName, "Please enter characters only !!");
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

        private void textBoxSSC_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBoxSSC.Text, Marks_pattern) == false)
            {
                textBoxSSC.Focus();
                errorProvider2.SetError(textBoxSSC, "Please enter Numbers only !!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void textBoxHSC_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBoxHSC.Text, Marks_pattern) == false)
            {
                textBoxHSC.Focus();
                errorProvider2.SetError(textBoxHSC, "Please enter Numbers only !!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

  

        private void textBoxMotherName_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBoxMotherName.Text, Name_pattern) == false)
            {
                textBoxMotherName.Focus();
                errorProvider2.SetError(textBoxMotherName, "Please enter characters only !!");
            }
            else
            {
                errorProvider2.Clear();
            }

        }

        private void textBoxFatherName_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBoxFatherName.Text, Name_pattern) == false)
            {
                textBoxFatherName.Focus();
                errorProvider2.SetError(textBoxFatherName, "Please enter characters only !!");
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
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8V3S77O;Initial Catalog=ELearning; Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[StudentDetails]
           ([Firstname]
           ,[Middlename]
           ,[Lastname]
           ,[Gender]
           ,[Fathername]
           ,[Mothername]
           ,[Mobile]
           ,[Email]
           ,[Bloodgrp]
           ,[Aadhar]
           ,[Nationality]
           ,[SSC]
           ,[HSC]
           ,[Photo]
            )
     VALUES 
            ('" +textFirstName.Text+ "','"+textMiddleName.Text+"','"+textLastName.Text+"'," +
              "'"+comboBoxGender.SelectedItem.ToString()+"','"+textBoxFatherName.Text+"'," +
              "'"+textBoxMotherName.Text+ "','"+textMobile.Text+"','"+textEmail.Text+"'," +
              "'"+ComboBlood.SelectedItem.ToString()+"','"+textBoxAadhar.Text+ "'," +
              "'"+textBoxNationalist.Text+"','"+textBoxSSC.Text+"','"+textBoxHSC.Text+"'," +
              "'"+pictureBoxPhoto.Image+"')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            ComboBlood.Text = String.Empty;
            comboBoxGender.Text = String.Empty;
            pictureBoxPhoto.Image = null;
            clearAll();
           
            MessageBox.Show("Application Form successfully submitted !!", "Application Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void textBoxNationalist_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxNationalist.Text))
            {
                e.Cancel = true;
                textBoxNationalist.Focus();
                errorProvider1.SetError(textBoxNationalist, "Please enter Email ID !!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBoxNationalist, null);
            }

        }

        private void textBoxAadhar_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBoxAadhar.Text, Aadhar_pattern) == false)
            {
                textBoxAadhar.Focus();
                errorProvider2.SetError(textBoxAadhar, "Please enter Valid aadhar !!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void ClickHere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Homepage h = new Homepage();
            h.Show();
            this.Hide();
        }
    }
}
