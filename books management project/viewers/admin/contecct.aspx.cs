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
    public partial class contecct : System.Web.UI.Page
    {
        SqlCommand cmd;
        SqlDataAdapter adr;
        SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            string cone = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            con = new SqlConnection(cone);
            con.Open();
            dis();
        }

        protected void seb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Aid.Value = seb.SelectedRow.Cells[1].Text;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Aid.Value=="")
            {
                ErrMsg.Text = "Missing detail..";
            }
            else
            {
            cmd = new SqlCommand("delete from contect where id='" + Aid.Value + "' ", con);
            int ans = cmd.ExecuteNonQuery();
            if (ans > 0)
            {
                Response.Write("<script>alert('data sucess fully deleted...');</script>");
            }
            Aid.Value = "";
            dis();
            }
        }
        public void dis()
        {
            cmd = new SqlCommand("select * from contect", con);
            adr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adr.Fill(dt);
            seb.DataSource = dt;
            seb.DataBind();
        }
           
        
    }
}