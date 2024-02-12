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
    public partial class categories : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sda;
        protected void Page_Load(object sender, EventArgs e)
        {
            string connect = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            con = new SqlConnection(connect);
            con.Open();
            showCategores();
         }
        public void showCategores()
        {
            String Query = "select * from categoryTbl";
            sda = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CategoryList.DataSource = dt;
            CategoryList.DataBind();
        }

        protected void Savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (categoriesName.Value == "" || categoriesDesc.Value == "")
                {
                    ErrMsg.Text = "Missing detail";
                }
                else
                {
                    //Response.Write("<Script>alert('data insert sucess fully....');</Script>");
                    
                    String insert = "insert into categoryTbl values('"+categoriesName.Value+"','"+categoriesDesc.Value+"')";
                    cmd = new SqlCommand(insert, con);
                    cmd.ExecuteNonQuery();
                    showCategores();
                    cid.Value = "";
                    categoriesName.Value = "";
                    categoriesDesc.Value = "";
                    
                }
            }
            catch(Exception ex)
            {
                ErrMsg.Text = ex.Message;
                //CategoryList.SelectedIndex.ToString().Trim();
                
            }

        }

     
        protected void Deletbtn_Click(object sender, EventArgs e)
        {
            try{
                if (categoriesName.Value == "" || categoriesDesc.Value == "")
                {

                   Response.Write("<Script>alert('please enter the data.....');</Script>");
                }
                else
                {
                  
                    String Qury = "delete from categoryTbl Where catid='"+cid.Value+"'";
                    cmd = new SqlCommand(Qury, con);
                    cmd.ExecuteNonQuery();
                    showCategores();
                    ErrMsg.Text = "Category deleted....";
                    cid.Value = "";
                    categoriesName.Value = "";
                    categoriesDesc.Value = "";

                }
            }
            catch (Exception ex)
            {
                ErrMsg.Text = ex.Message;
                //CategoryList.SelectedIndex.ToString().Trim();

            }
            }
            
        

        protected void CategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            cid.Value = CategoryList.SelectedRow.Cells[1].Text;
            categoriesName.Value = CategoryList.SelectedRow.Cells[2].Text;
            categoriesDesc.Value = CategoryList.SelectedRow.Cells[3].Text;
        }

        protected void Updatebtn_Click(object sender, EventArgs e)
        {
            try{
            if (categoriesName.Value == "" || categoriesDesc.Value == "")
            {

                Response.Write("<Script>alert('please enter the data.....');</Script>");
            }
            else
            {
                  //Response.Write("<Script>alert('data insert sucess fully....');</Script>");
                String Qury = "update categoryTbl set catName='"+categoriesName.Value+"',catdes='"+categoriesDesc.Value+"' Where catid='"+cid.Value+"'";
                cmd = new SqlCommand(Qury,con);
                cmd.ExecuteNonQuery();
                    showCategores();
                    ErrMsg.Text = "Category updated....";
                    cid.Value = "";
                    categoriesName.Value = "";
                    categoriesDesc.Value = "";

                }
            }
                catch (Exception ex)
                {
                    ErrMsg.Text = ex.Message;
                    //CategoryList.SelectedIndex.ToString().Trim();

                }
            
        }

    }
}