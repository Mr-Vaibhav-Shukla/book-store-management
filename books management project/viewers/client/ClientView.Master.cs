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
    public partial class ClientView : System.Web.UI.MasterPage
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adr;
        protected void Page_Load(object sender, EventArgs e)
        {
             string connec = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            con = new SqlConnection(connec);
            con.Open();
            user.InnerText = Request.Cookies["client"]["User_name"].ToString(); 
        }

          protected void Button1_Click(object sender, EventArgs e)
          {
              SqlCommand scmd = new SqlCommand("select sscrib from subscribers where sscrib='" + subtxt.Value + "'", con);
              SqlDataAdapter adr = new SqlDataAdapter(scmd);
              DataTable dt = new DataTable();
              adr.Fill(dt);
              if (dt.Rows.Count > 0)
              {
                  Response.Write("<script>alert('Data all redy instered...');</script>");
                  subtxt.Value = "";
              }

              else
              {
                  if (subtxt.Value == "")
                  {
                      Response.Write("<script>alert('Please enter the value...');</script>");

                  }
                  else
                  {
                      SqlCommand icmd = new SqlCommand("insert into subscribers values('" + subtxt.Value + "')", con);
                      int ans = icmd.ExecuteNonQuery();
                      if (ans > 0)
                      {
                          Response.Write("<script>alert('data success fully inserted...');</script>");

                      }
                  }
              }
              
          }

          protected void Button2_Click(object sender, EventArgs e)
          {
              Response.Redirect("product.aspx");
          }

          protected void logout_Click(object sender, EventArgs e)
          {
              Request.Cookies["client"].Expires = DateTime.Now.AddSeconds(-1);
              Response.Redirect("~/viewers/log.aspx");
                       }

           
        }
    }
