using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace books_management_project.viewers.admin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter sda;
        protected void Page_Load(object sender, EventArgs e)
        {
           String connect = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            con = new SqlConnection(connect);
            con.Open();
            showBook();
            getdataAuthor();
            getdataCategry();         
            display();
           
        }
        public void showBook()
        {
            string query = "select * from Booktbl";
            sda = new SqlDataAdapter(query,con);
            DataTable td = new DataTable();
            sda.Fill(td);
            
        }
        public void getdataAuthor()
        {
            String qurget = "select * from AuthorTbl";
            sda = new SqlDataAdapter(qurget, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DropDownLis1.DataValueField = "Authorid";
            DropDownLis1.DataTextField = "AuthorName";
            DropDownLis1.DataSource = dt;
            DropDownLis1.DataBind();
        }
        public void getdataCategry()
        {
            string qur = "select * from categoryTbl";
            sda = new SqlDataAdapter(qur, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DropDownLis2.DataValueField = "catid";
            DropDownLis2.DataTextField = "catname";
            DropDownLis2.DataSource = dt;
            DropDownLis2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select BookName from BookTbl where BookName='" + booktitle.Value + "'", con);
                sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    ErrMsg.Text = "data All redy inserted......";
                }
                else
                {
                    if (booktitle.Value == "" || DropDownLis1.SelectedIndex.ToString() == "" || DropDownLis2.SelectedIndex.ToString() == "" || bookprice.Value == "" || bookQua.Value == "")
                    {
                        ErrMsg.Text = "please enter the value";
                    }
                    else
                    {
                        if (fileupload.HasFile)
                        {
                            string path = "img/"+fileupload.FileName;
                            fileupload.SaveAs(MapPath("~/viewers/admin/img/" + fileupload.FileName));
                            int len = fileupload.PostedFile.ContentLength;
                            byte[] pic = new byte[len];
                            fileupload.PostedFile.InputStream.Read(pic, 0, len);
                            cmd = new SqlCommand("insert into BookTbl values(@booktitle,@bookAuthor,@bookcat,@bookprice,@bookqua,@bookimg)",con);
                            cmd.Parameters.AddWithValue("booktitle",booktitle.Value);
                            cmd.Parameters.AddWithValue("bookAuthor",DropDownLis1.SelectedValue);
                            cmd.Parameters.AddWithValue("bookcat", DropDownLis2.SelectedValue);
                            cmd.Parameters.AddWithValue("bookprice",bookprice.Value);
                            cmd.Parameters.AddWithValue("bookqua", bookQua.Value);
                            cmd.Parameters.AddWithValue("bookimg",pic);
                            int ans = cmd.ExecuteNonQuery();
                            if (ans > 0)
                            {
                                Response.Write("<script>alert('data inserted...');</script>");
                            }

                        }


                        ErrMsg.Text = "Book inserted";
                        booktitle.Value = "";
                        DropDownLis1.SelectedIndex = 0;
                        DropDownLis2.SelectedIndex = 0;
                        bookQua.Value = "";
                        bookprice.Value = "";
                       

                    }
                }
            }
            catch (Exception ex)
            {
                ErrMsg.Text = ex.Message;
            }
           display();
        }

       public void display()
        {
            cmd = new SqlCommand("select * from BookTbl", con);
            sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            booktitle.Value = GridView1.SelectedRow.Cells[2].Text;
            bookprice.Value = GridView1.SelectedRow.Cells[5].Text;
            bookQua.Value = GridView1.SelectedRow.Cells[6].Text;
            bimage.Visible = false;
            fileupload.Visible = false;
          
        }

       

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete from BookTbl where BookName='"+booktitle.Value+"'", con);
            cmd.ExecuteNonQuery();
            ErrMsg.Text = "data deleted..."; 
            booktitle.Value = "";
            DropDownLis1.SelectedIndex = 0;
            DropDownLis2.SelectedIndex = 0;
            bookQua.Value = "";
            bookprice.Value = "";
            display();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update BookTbl set BookAuthor='" + DropDownLis1.SelectedIndex + "',Bookcat='" + DropDownLis2.SelectedIndex + "',Bookprice='" + bookprice.Value + "',BookQua='" + bookQua.Value + "' where BookName='" +booktitle.Value + "'", con);
            sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            ErrMsg.Text = "data updated...";
            booktitle.Value = "";
            DropDownLis1.SelectedIndex = 0;
            DropDownLis2.SelectedIndex = 0;
            bookQua.Value = "";
            bookprice.Value = "";
            display();
           
        }
    }
}