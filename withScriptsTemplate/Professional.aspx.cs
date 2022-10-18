using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace FirstWebForm
{
    public partial class Professional : System.Web.UI.Page
    {
        public object SqlDataSource1 { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Connect to database

            SqlDataAdapter adapter = new SqlDataAdapter();
            //Get the command from SqlDataSource1

           // adapter.InsertCommand = new SqlCommand(SqlDataSource1.InsertCommand);
           // adapter.InsertCommand.Connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = KpmgDb; Integrated Security = True");

            //Add parameters for command

            //adapter.InsertCommand.Parameters.Add(new SqlParameter("Name", txtName.Text));
            //adapter.InsertCommand.Parameters.Add(new SqlParameter("Designation", txtDesignation.Text));
           // adapter.InsertCommand.Parameters.Add(new SqlParameter("Salary", txtSalary.Text));
            //Open Connection

            using (adapter.InsertCommand.Connection)
            {
                adapter.InsertCommand.Connection.Open();
                adapter.InsertCommand.ExecuteNonQuery();
            }
            // Execute command
            // RE-bind the grid
           // GridView1.DataBind();



        }
    }
}