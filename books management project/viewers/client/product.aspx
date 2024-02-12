<%@ Page Title="" Language="C#" MasterPageFile="~/viewers/client/ClientView.Master" AutoEventWireup="true" CodeBehind="product.aspx.cs" Inherits="books_management_project.viewers.client.product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <style>
        .set {
            border:2px solid red;
            padding:50px;
            margin-left:20px;
        }
        .tex {
            color:lightskyblue;
            font-size:15px;
            text-align:center;
        }
        .backbord {
           padding:30px;
           max-width:100%;
           position:relative;
        }
          .btn1 {
              padding:30px;
          }
          .searchbar {
             
          }
    </style>   
   
    <asp:DataList ID="DataList1" runat="server" DataKeyField="Bookid" OnItemCommand="DataList1_ItemCommand"  RepeatColumns="3" RepeatDirection="Horizontal" DataSourceID="SqlDataSource1">      
         <ItemTemplate>
           
              
             
              
             
             <div class="backbord">
                 <div class="set">
                       <div class="row">
         
            <div class="box ">
                 <div class="detail-box">
                Bookid:
                <asp:Label ID="BookidLabel" runat="server" Text='<%# Eval("Bookid") %>' />
                <br />
                BookName:
                <asp:Label ID="BookNameLabel" runat="server" Text='<%# Eval("BookName") %>' />
                <br />
                     </div>
                     <div class="img-box">
                <asp:Image ID="Image1" runat="server" Height="80px" ImageUrl='<%#"data:Image/png;base64,"+Convert.ToBase64String((byte[])Eval("BookImage")) %>' Width="140px" />
               </div>
                <br />
                 <div class="detail-box">
                Bookprice:
                <asp:Label ID="BookpriceLabel" runat="server" Text='<%# Eval("Bookprice") %>' />
                <br />
                BookQua:
                <asp:Label ID="BookQuaLabel" runat="server" Text='<%# Eval("BookQua") %>' />
                <br />
                <br />
                     </div>
                     <div>
                        
                <asp:Button ID="Button2" runat="server" CommandArgument='<%# Bind("Bookid") %>' Text="Add to card" CssClass="btn-info"  />
                         </div>
                <br />
                <br />
                     </div>  </div>
            </div>
          </div>
            </div>
            </ItemTemplate>
        </asp:DataList>
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connect %>" SelectCommand="SELECT [Bookid], [BookName], [Bookprice], [BookQua], [BookImage] FROM [BookTbl]">
          
      </asp:SqlDataSource>
        <br />
        <br />
       
</asp:Content>
