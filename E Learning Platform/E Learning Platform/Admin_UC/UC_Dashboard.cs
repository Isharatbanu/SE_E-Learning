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
    public partial class UC_Dashboard : UserControl
    {
        function fn = new function();
        DataSet ds;
        String query_StudentRegister, query_StudentDetails;
        public UC_Dashboard()
        {
            InitializeComponent();
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {

        }

        /*private void abc()
        {
            int count = 0;
            SqlConnection con = new SqlConnection("Data Source = LAPTOP - 6OCFE43M; Initial Catalog = ELearning; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("Select count(*) from StudentRegister", con);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            labelRegistered.Text = count.ToString();
            con.Close();
        }*/
        private void UC_Dashboard_Load(object sender, EventArgs e)
        {

            query_StudentRegister = "Select count(*) from StudentRegister";
            ds = fn.getData(query_StudentRegister);
            setLabel(ds, labelRegistered);

            query_StudentDetails = "Select count(*) from StudentDetails";
            ds = fn.getData(query_StudentDetails);
            setLabel(ds, labelApplied);
        }

         private void setLabel(DataSet ds, Label lbl)
         {
             if (ds.Tables[0].Rows.Count != 0)
             {
                 lbl.Text = ds.Tables[0].Rows[0][0].ToString();
             }
             else
             {
                 lbl.Text = "0";
             }
         }



    }
}
