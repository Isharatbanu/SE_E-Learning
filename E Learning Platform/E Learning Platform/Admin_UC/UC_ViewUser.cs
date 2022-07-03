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

namespace E_Learning_Platform.Admin_UC
{
    public partial class UC_ViewUser : UserControl
    {
        function fn = new function();
        String qr;
        public UC_ViewUser()
        {
            InitializeComponent();
        }

        private void UC_ViewUser_Load(object sender, EventArgs e)
        {
            qr = "select Id,Firstname,Middlename,Lastname,Gender,Fathername,Mothername,Mobile,Email,Bloodgrp,Aadhar,Nationality,SSC,HSC from StudentDetails";
            DataSet ds = fn.getData(qr);
            DataGridViewUser.DataSource = ds.Tables[0];
        }

        private void Refresh_Click(object sender, EventArgs e)
        {

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            qr = "select Id,Firstname,Middlename,Lastname,Gender,Fathername,Mothername,Mobile,Email,Bloodgrp,Aadhar,Nationality,SSC,HSC from StudentDetails where Firstname like '" + SearchBox.Text +"%' ";
            DataSet ds = fn.getData(qr);
            DataGridViewUser.DataSource = ds.Tables[0];

        }

        
        private void DataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
