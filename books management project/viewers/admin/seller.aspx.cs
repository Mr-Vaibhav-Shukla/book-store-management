using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace books_management_project.viewers.admin
{
    public partial class seller : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sda;

        protected void Page_Load(object sender, EventArgs e)
        {
            String connect =ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            con = new SqlConnection(connect);
            con.Open();
            showSeller();
        }
        public void showSeller()
        {
            String query = "Select * from sellerTbl";
            sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sellerList.DataSource = dt;
            sellerList.DataBind();
        }

        protected void Savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (sellerName.Value == "" || sellerEm.Value == "" || sellerphone.Value == "" || selleraddress1.Value == "")
                {
                    Response.Write("<script>alert('please enter the data!!!');</script>");
                }
                else
                {
                    cmd = new SqlCommand("select * from sellerTbl where sellerEmail='"+sellerEm.Value+"'", con);
                    sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        ErrMsg.Text = "data all redy inserted....";
                    }
                    else
                    {
                        String Qury = "insert into sellerTbl values('" + sellerName.Value + "','" + sellerEm.Value + "','" + sellerphone.Value + "','" + selleraddress1.Value + "');";
                        cmd = new SqlCommand(Qury, con);
                        cmd.ExecuteNonQuery();
                        ErrMsg.Text = "Seller inserted....";
                        showSeller();
                        sid.Value = "";
                        sellerName.Value = "";
                        sellerEm.Value = "";
                        sellerphone.Value = "";
                        selleraddress1.Value = "";
                    }
                }
            }
            catch (Exception ex)
            {
                ErrMsg.Text = ex.Message;
            }
        }

        protected void sellerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            sid.Value = sellerList.SelectedRow.Cells[1].Text;
           sellerName.Value = sellerList.SelectedRow.Cells[2].Text;
            sellerEm.Value = sellerList.SelectedRow.Cells[3].Text;
            sellerphone.Value = sellerList.SelectedRow.Cells[4].Text;
            selleraddress1.Value = sellerList.SelectedRow.Cells[5].Text;
        }

        protected void Deletbtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (sellerName.Value == "" || sellerEm.Value == "" || sellerphone.Value == "" || selleraddress1.Value == "")
                {
                    Response.Write("<script>alert('please enter the data!!!');</script>");
                }
                else
                {

                    String Qury = "delete from sellerTbl where sellerid='" + sid.Value + "'";
                    cmd = new SqlCommand(Qury, con);
                    cmd.ExecuteNonQuery();
                    ErrMsg.Text = "Seller Deleted....";
                    showSeller();
                    sid.Value = "";
                    sellerName.Value = "";
                    sellerEm.Value = "";
                    sellerphone.Value = "";
                    selleraddress1.Value = "";
                }
            }
            catch (Exception ex)
            {
                ErrMsg.Text = ex.Message;
            }
        }

        protected void ubtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (sellerName.Value == "" || sellerEm.Value == "" || sellerphone.Value == "" || selleraddress1.Value == "")
                {
                    Response.Write("<script>alert('please enter the data!!!');</script>");
                }
                else
                {


                    String Qury = "update sellerTbl set sellerName='" + sellerName.Value + "', sellerEmail='" + sellerEm.Value + "',sellerPass='" + sellerphone.Value + "',selleraddress='" + selleraddress1.Value + "' where sellerid='" + sid.Value + "'";
                    cmd = new SqlCommand(Qury, con);
                    cmd.ExecuteNonQuery();
                    ErrMsg.Text = "Seller data was updated....";
                    showSeller();
                    sid.Value = "";
                    sellerName.Value = "";
                    sellerEm.Value = "";
                    sellerphone.Value = "";
                    selleraddress1.Value = "";
                }
            }
            catch (Exception ex)
            {
                ErrMsg.Text = ex.Message;
            }
        }

       

    }
}