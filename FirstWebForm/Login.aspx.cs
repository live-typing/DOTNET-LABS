using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebForm
    {
        public partial class Login : System.Web.UI.Page
        {
            protected void Page_Load(object sender, EventArgs e)
            {

            }

            protected void TextBox1_TextChanged(object sender, EventArgs e)
            {
                if (TextBox1.Text == "vimal" && TextBox2.Text == "@444#")
                {
                    Label2.Text = "Login Successful";
                }
                else
                {
                    Label2.Text = "Enter Valid Credentials";
                }
            }

            protected void TextBox2_TextChanged(object sender, EventArgs e)
            {

            }

            protected void Button1_Click(object sender, EventArgs e)
            {
                if (TextBox1.Text == "vimal" && TextBox2.Text == "@444#")
                {
                    Label2.Text = "Login Successful";
                }
                else
                {
                    Label2.Text = "Enter Valid Credentials";
                }
            Session["Hobbies"] = new List<string>() { "cricket", "gymming", "badminton" };
            }

            protected void Button2_Click(object sender, EventArgs e)
            {
                Label2.Text = "vimal";
                Session["Username"] = TextBox1.Text;



        }


    }
    }
   
    
