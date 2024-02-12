using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace books_management_project.viewers
{
    public partial class index : System.Web.UI.Page
    {
        SqlCommand cmd;
        SqlConnection con;

        protected void Page_Load(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            con = new SqlConnection(conn);
            con.Open();

            cmd = new SqlCommand("delete from addto", con);
            cmd.ExecuteNonQuery();
        }

        protected void log_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from sellerTbl where sellerEmail='"+uname.Value+"' and sellerPass='"+upass.Value+"'", con);
            SqlDataReader dt = cmd.ExecuteReader();
            if (uname.Value == "Admin111@gmail.com" && upass.Value == "admin123")
            {
                Session["user"]=uname.Value;
                Response.Redirect("~/viewers/admin/Books.aspx");
            }
            else if (dt.HasRows == true)
            {


                while (dt.Read())
                {
                    string u = dt["sellerEmail"].ToString();
                    string p = dt["sellerPass"].ToString();
                    if (u == uname.Value && p == upass.Value)
                    {
                        HttpCookie c = new HttpCookie("client");
                        c["User_name"] = uname.Value;
                        c["User_pass"] = upass.Value;
                        Response.Cookies.Add(c);
                       
                        Response.Redirect("~/viewers/client/index.aspx");
                        c.Expires = DateTime.Now.AddMonths(1);
                    }
                }
            }
            else
            {
                Response.Write("<script>alert('data not valid...');</script>");
               
            }
                
            
            uname.Value = "";
           
        }
    }
}