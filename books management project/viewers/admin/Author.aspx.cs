using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;
using System.Configuration;
namespace books_management_project.viewers.admin
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter sda;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            String conn1 = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            con = new SqlConnection(conn1);
            con.Open();
            ShowAuthors();
            
        }
        private void ShowAuthors()
        {
            String query = "select * from AuthorTbl";
            cmd = new SqlCommand(query,con);
            sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            AuthorsList.DataSource = dt;
            AuthorsList.DataBind();
       }
        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from AuthorTbl where  AuthorName='"+ANameTb.Value+"'",con);
            sda  = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                ErrMsg.Text = "Data all redy Accessed";
            }
            else{

            if (ANameTb.Value == "" || Gencb.SelectedIndex == -1 || ContryCb.SelectedIndex == -1)
            {
                ErrMsg.Text = "Missing detail...";
            }
            else
            {
                try
                {

                    String Query = "insert into AuthorTbl values('" + ANameTb.Value + "','" + Gencb.SelectedItem.Text + "','" + ContryCb.SelectedItem.Text + "')";
                    cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    ShowAuthors();
                    ErrMsg.Text = "Author inserted....";
                    Aid.Value = "";
                    ANameTb.Value = "";
                    Gencb.SelectedItem.Value = "";
                    ContryCb.SelectedIndex = 0;


                }

                catch (Exception Ex)
                {
                    ErrMsg.Text = Ex.Message;
                }
            }
           
        }
        }          
        
        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ANameTb.Value == "" || Gencb.SelectedIndex == -1 || ContryCb.SelectedIndex == -1)
                {
                    ErrMsg.Text = "Missing detail...";
                }
                else
                {                    
                        String Query = "update AuthorTbl set AuthorName='"+ANameTb.Value+"', AuthorGender='"+Gencb.SelectedItem.Text+"',AuthorCountry='"+ContryCb.SelectedItem.Text+"' where Authorid='"+Aid.Value+"' ";
                        cmd = new SqlCommand(Query, con);
                        cmd.ExecuteNonQuery();
                        ShowAuthors();
                        ErrMsg.Text = "Author Updated....";
                        Aid.Value = "";
                        ANameTb.Value = "";
                        Gencb.SelectedIndex = 0;
                        ContryCb.SelectedIndex = 0;
                       
                    
                }
            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }
                      
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (ANameTb.Value == "" || Gencb.SelectedIndex == -1 || ContryCb.SelectedIndex == -1)
            {
                ErrMsg.Text = "NO DATA FUND....";
            }
            else
            {
                try
                {
                    String AName = ANameTb.Value;
                    String Gender = Gencb.SelectedItem.Value;
                    String Country = ContryCb.SelectedItem.Value;

                    String Qury = "delete from AuthorTbl Where Authorid='"+Aid.Value+"'";
                    cmd = new SqlCommand(Qury, con);
                    cmd.ExecuteNonQuery();
                    ShowAuthors();
                    ErrMsg.Text = "Author Deleted....";
                    Aid.Value = "";
                    ANameTb.Value = "";
                    Gencb.SelectedItem.Value = "";
                    ContryCb.SelectedIndex = 0;
                }
                catch (Exception exx)
                {
                    ErrMsg.Text = exx.Message;
                }
                
            }
        }

        protected void AuthorsList_SelectedIndexChanged1(object sender, EventArgs e)
        {
            Aid.Value = AuthorsList.SelectedRow.Cells[1].Text;
            ANameTb.Value = AuthorsList.SelectedRow.Cells[2].Text;
           
        }

       
    }
}