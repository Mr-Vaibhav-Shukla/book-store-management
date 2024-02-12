using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace books_management_project.viewers.client
{
    public partial class contect : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adr;
        protected void Page_Load(object sender, EventArgs e)
        {
            string conne = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            con = new SqlConnection(conne);
            con.Open();
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select name from contect where name='"+cname.Value+"'",con);
            adr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adr.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Response.Write("<script>alert('data all redy inserted.....');</script>");
            }

            else
            {
                cmd = new SqlCommand("insert into contect values('"+cname.Value+"','"+cemail.Value+"','"+cnum.Value+"','"+cmsg.Value+"')", con);
                int ans = cmd.ExecuteNonQuery();
                if (ans > 0)
                {
                    Response.Write("<script>alert('data inserted.....');</script>");
                }
               
                  cname.Value = "";
            cemail.Value = "";
            cnum.Value = "";
            cmsg.Value = "";
            }
        }
    }
}