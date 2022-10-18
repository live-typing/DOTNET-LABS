using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebForm
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                List<Employee> employees = new List<Employee>();
                employees.Add(new Employee() { EmpId = 1001, Ename = "Sam", Designation = "Director" });
                employees.Add(new Employee() { EmpId = 1002, Ename = "Dharshik", Designation = "Ceo" });
                employees.Add(new Employee() { EmpId = 1003, Ename = "Hari", Designation = "Manager" });
                ViewState["EmpData"] = employees;
            
        }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button1.Text = "You are Logged In as : " + Convert.ToString(Session["Username"]);
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelected.Text = "Your selected Value:" + ListBox1.SelectedValue.ToString();
            lblSelected.Text = lblSelected.Text + " | Your Selected Text : " + ListBox1.SelectedItem.Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            List<string> dataFromSession = (List<string>)Session["Hobbies"];
            //Databind to listbox
            ListBox2.DataSource = dataFromSession;
            ListBox2.DataBind();

            //Create a cookie

            HttpCookie cookie = new HttpCookie("RemindMe");
            cookie.Value = "To attend Townhall session";
            cookie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(cookie);

            //cookie preference
            HttpCookie prefCookie = new HttpCookie("Preferences");
            prefCookie.Value = "SeaGreen:White";
            prefCookie.Expires = DateTime.Now.AddDays(2);
            Response.Cookies.Add(prefCookie);

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            HttpCookie varReadCookie = Request.Cookies["RemindMe"];
            Button3.Text = varReadCookie.Value;

            //HttpCookie var 
            HttpCookie varPrefCookie = Request.Cookies["Preferences"];
            string cookieValue = varPrefCookie.Value; //seaGreen:White
            string[] splits = cookieValue.Split(':');

            ApplyColor(splits[0], "Backcolor");
            ApplyColor(splits[1], "Forecolor");
        }
        private void ApplyColor(String color, string property)
        {
            System.Drawing.Color resultColor = System.Drawing.Color.White;
            switch(color)
            {
                case "SeaGreen":
                    resultColor = System.Drawing.Color.SeaGreen;
                    break;
                case "White":
                    resultColor = System.Drawing.Color.White;
                    break;
                default:
                    resultColor = System.Drawing.Color.Tomato;
                    break;
            }

            if(property == "Backcolor")
            {
                ListBox1.BackColor = resultColor;
                ListBox2.BackColor = resultColor;

            }
            else if (property == "Forecolor")
            {
                ListBox1.ForeColor = resultColor;
                ListBox1.ForeColor = resultColor;

            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = ViewState["EmpData"];
            GridView1.DataBind();
        }
    }
    }
