using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["UN"]!=null)
            {
                Label1.Text = "Welcome :" + Session["UN"].ToString();
                Label1.Text = "Desginsation :" + Session["Deg"].ToString();
                Label1.Text = Session.SessionID.ToString();
            }
            else
            {
                Response.Redirect("Login.aspx", false);
            }
        }
    }
}