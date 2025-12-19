using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;

        string con_str = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Login_Click(object sender, EventArgs e)
        {
            string username = Txt_Username.Text;
            string userpass = Txt_Password.Text;

            if (username.Equals("Raj") && userpass.Equals("Raj123"))
            {
                Session["UN"] = username;
                Response.Redirect("Menu.aspx", false);
            }
            else if (username.Equals("Admin") && userpass.Equals("Admin123"))
            {
                Session["UN"] = username;
            }
            else
            {
                Response.Write("Invalid user");
            }






            /*
            try
            {
                con = new SqlConnection(con_str);
                con.Open();
                cmd = new SqlCommand("Sp_Check_Login", con);
                cmd.Parameters.AddWithValue("@un", Txt_Username.Text);
                cmd.Parameters.AddWithValue("@ps", Txt_Password.Text);
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();

                if(dr.HasRows)
                {
                    Response.Redirect("Menu.aspx", false);
                }
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                dr.Close();
                con.Close();
            }
            */
        }
    }
}