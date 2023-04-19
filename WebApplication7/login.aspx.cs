using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\user.mdf;Integrated Security = True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*
            con.Open();
            SqlDataReader dr;
            String str ="Select * from Login where UID ='"+TextBox1.Text+"' and password = '"+TextBox2.Text+"'";
            SqlCommand cmd = new SqlCommand(str, con);
            
            dr = cmd.ExecuteReader();
            
            if (dr.HasRows)
            {
                Label1.Text = " Login Successful ";
            }
            else
            {
                Label1.Text ="Invalid User" ;
            }
            */
            Session["uname"] = TextBox1.Text;
            Response.Redirect("home.aspx");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}