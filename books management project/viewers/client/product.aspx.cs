using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace books_management_project.viewers.client
{
    public partial class product : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adr;
        protected void Page_Load(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            con = new SqlConnection(conn);
            con.Open();
            display();
           if (Request.QueryString["search"] != null)
            {
                
                cmd = new SqlCommand("select * from addto where BookName='" + Request.QueryString["search"].ToString() + "'", con);
                adr = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adr.Fill(dt);
                DataList1.DataSource = dt;
                DataList1.DataBind();
            }
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            Response.Redirect("addtocart.aspx?id=" + e.CommandArgument.ToString());
        }

       /* protected void Button2_Click(object sender, EventArgs e)
        {

        }*/


        public void display()
        {
            cmd = new SqlCommand("select * from addto", con);
            adr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adr.Fill(dt);
            /*DataList1.DataSource = dt;
            DataList1.DataBind();*/
        }
        
    }
}