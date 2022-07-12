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
using System.Data.OleDb;
using System.IO;

namespace E_Learning_Platform.Admin_UC
{
    public partial class UC_ViewUser : UserControl
    {
        function fn = new function();
        String qr;
        String currentUser = "";
        String connectionString = @"Data Source=DESKTOP-8V3S77O;Initial Catalog=ELearning; Integrated Security=True";

        public UC_ViewUser()
        {
            InitializeComponent();
        }

        public String ID
        {
            set { currentUser = value; }
        }

        private void UC_ViewUser_Load(object sender, EventArgs e)
        {
            getDataDB();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            //qr = "select Id,Firstname,Middlename,Lastname,Gender,Fathername,Mothername,Mobile,Email,Bloodgrp,Aadhar,Nationality,SSC,HSC from StudentDetails where Firstname like '" + SearchBox.Text +"%' ";
            //DataSet ds = fn.getData(qr);
            //DataGridViewUser.DataSource = ds.Tables[0];

        }
        //String userName;
        private void DataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /* try 
            {
                userName = DataGridViewUser.Rows[e.RowIndex].Cells[1].Value.ToString();

            }
            catch { }*/
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {

        }


        private void getDataDB()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            try
            {
                String q = "Select Id,Firstname,Middlename,Lastname,Gender,Fathername,Mothername,Mobile,Email,Bloodgrp,Aadhar,Nationality,SSC,HSC from StudentDetails";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                
               /* dt.Columns.Add("Photo", Type.GetType("System.Byte[]"));
                foreach(DataRow row in dt.Rows)
                {
                    row["Photo"] = File.ReadAllBytes(row["Photo"].ToString());
                }*/
                dataGridView1.DataSource = dt;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
