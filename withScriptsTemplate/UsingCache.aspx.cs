using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace withScriptsTemplate
{
    public partial class UsingCache : System.Web.UI.Page
    {
        List<string> names = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                names.Add("Meena");
                names.Add("Meena");
                ListBox1.DataSource = names;
                ListBox1.DataBind();
                ViewState["list"] = names;
                Cache.Insert("list", names);
            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Add  the item in the textbox1 to the list
            names = (List<string>)ViewState["list"];
            names.Add(TextBox1.Text);

            //Rebind the listbox
            ListBox1.DataSource = names;
            ListBox1.DataBind();

            //Update the viewstate
            ViewState["names"] = names;
            Cache.Insert("list", names);
        }
    }
}