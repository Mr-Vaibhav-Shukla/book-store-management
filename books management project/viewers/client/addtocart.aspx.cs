using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace books_management_project.viewers.client
{
    public partial class addtocart : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adr;
        DataTable dt = new DataTable();
        int total = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            con = new SqlConnection(conn);
            con.Open();
            cmd = new SqlCommand("select * from BookTbl where Bookid='" + Request.QueryString["id"] + "'", con);
            adr = new SqlDataAdapter(cmd);
            adr.Fill(dt);
            inser();
            display();
            gtotal();
            
        }
        public void inser()
        {
             cmd = new SqlCommand("select * from addto where Id='" + Request.QueryString["id"] + "'", con);
            adr = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            adr.Fill(dt1);
            if (dt1.Rows.Count > 0)
            {

            }
            else
            {
                if (dt.Rows == null)
                {
                    display();
                }
                else
                {
                    string id = dt.Rows[0][0].ToString();
                    string bname = dt.Rows[0][1].ToString();
                    string bprice = dt.Rows[0][4].ToString();
                    string bqua = dt.Rows[0][5].ToString();
                    cmd = new SqlCommand("insert into addto values('" + id.ToString() + "','" + bname.ToString() + "','" + bprice.ToString() + "','" + bqua.ToString() + "')", con);
                    cmd.ExecuteNonQuery();
                }
            }
        
        }
        public void display()
        {
            cmd = new SqlCommand("select * from addto", con);
            adr = new SqlDataAdapter(cmd);
            DataTable dist = new DataTable();
            adr.Fill(dist);
            GridView1.DataSource = dist;
            GridView1.DataBind();
          
           // Label1.Text = total.ToString();
        }
       

        protected void Button2_Click(object sender, EventArgs e)
        {
           
            string gtotal = Label1.Text;
            string name = Request.Cookies["client"]["User_name"].ToString();
           /* Response.Write("Total: "+gtotal+"<br>");
            Response.Write("name: " + name);*/
            cmd = new SqlCommand("select * from BillTbl where total='"+gtotal.ToString()+"'and Billname='"+name.ToString()+"'",con);
            adr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adr.Fill(dt);
            if (dt.Rows.Count > 0)
            {
               
            }
            else
            {
                cmd = new SqlCommand("insert into BillTbl values('" + name.ToString() + "','" + gtotal.ToString() + "')", con);
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('success......')</script>");
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("product.aspx");
            //gtotal();
        }
        
        public void gtotal()
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                total = total + Convert.ToInt16(row.Cells[2].Text);
            }
            Label1.Text = total.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            delete();
            Response.Redirect("index.aspx");

        }
        public void delete()
        {
            cmd = new SqlCommand("delete from addto",con);
            cmd.ExecuteNonQuery();
        }
    }
}