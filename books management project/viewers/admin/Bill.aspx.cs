using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace books_management_project.viewers.admin
{
    public partial class Bill : System.Web.UI.Page
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
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bid.Value = GridView1.SelectedRow.Cells[1].Text;
        }
        public void display()
        {
            cmd = new SqlCommand("select * from BillTbl",con);
            adr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adr.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Bid.Value=="")
            {
                ErrMsg.Text = "Missing detail..";
            }
            else
            {
            cmd = new SqlCommand("delete from BillTbl where Id='"+Bid.Value+"'",con);
          int ans =  cmd.ExecuteNonQuery();
          if (ans > 0)
          {
              Response.Write("<script>alert('data deleted success fully');</script>");
          }
          display();
          Bid.Value = "";
            }
        }
    }
}