<%@ Page Title="" Language="C#" MasterPageFile="~/viewers/admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Author.aspx.cs" Inherits="books_management_project.viewers.admin.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="myContent" runat="server">
      
         <div class="container-fluid">
             <div class="col-md-19">
                 <div class="text-center">
                     <h3>Manage Author</h3>
              </div>
                   <div class="col-md-6 text-center mt-3">
                   <div class="form-label text-success">
                     <label>System Id:</label>
                </div>
                  <div class="mb-2" style="margin-left:42%">
                     <input type="text" autocomplete="off" class="form-control" runat="server" id="Aid" disabled="disabled" style="border-style:hidden" />
                 </div>
             </div>
              <div class="col-md-6 text-center mt-3">
                 <div class="form-label text-success">
                     <label>Author Name:</label>
                </div>
                  <div class="mb-2" style="margin-left:42%">
                     <input type="text" autocomplete="off" placeholder="Name:" class="form-control" runat="server" id="ANameTb" />
                 </div>
             </div>
                  <div class="col-md-6 text-center mt-2" style="padding:5px;">
                 <div class="form-label text-success">
                     <label style="margin-left:5px;">Author Gender:</label>
                </div>
        
                  <div class="mb-2" style="margin-left:42%">
                    <asp:DropDownList runat="server" Class="form-control" id="Gencb">
                        <asp:ListItem Text="male">Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:DropDownList>
                 </div>
                 <div class="form-label text-success mt-2">
                     <label style="margin-right:50px;">Contry:</label>
                </div>
                  <div class="mb-2" style="margin-left:42%">
                      <asp:DropDownList ID="ContryCb" CssClass="form-control" runat="server">
                          <asp:ListItem>USA</asp:ListItem>
                          <asp:ListItem>UK</asp:ListItem>
                          <asp:ListItem>INDIA</asp:ListItem>
                          <asp:ListItem>JAPAN</asp:ListItem>
                          <asp:ListItem>PERICE</asp:ListItem>
                          <asp:ListItem>others</asp:ListItem>
                      </asp:DropDownList>
                     
                 </div>    
                      <div class="d-block mt-3 p-1">
                            <div>
                               <asp:Label runat="server" id="ErrMsg" Class="text-danger-emphasis"></asp:Label>                             
                         <div style="margin-left:90px">
                          <asp:Button ID="UpdateBtn" Text="Update" runat="server" Class="btn-warning mb-2 btn-block btn" OnClick="UpdateBtn_Click"/>
                          <asp:Button ID="SaveBtn" Text="Save" runat="server" Class="btn-success mb-2 btn-block btn" OnClick="SaveBtn_Click"/>
                          <asp:Button ID="DeleteBtn" Text="Delete" runat="server" Class="btn-danger mb-2 btn-block btn" OnClick="DeleteBtn_Click"/>
                         </div>
                          
                      
                          </div>
                          
                      
                         </div>
                          </div>
                      <div class="col-md-3">
                       <div class="mt-auto" style="margin-left:30%;margin-bottom:100%;position:absolute;top:40px;left:30%">
                          <asp:GridView ID="AuthorsList" runat="server" Class="table table-bordered" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="TRUE" OnSelectedIndexChanged="AuthorsList_SelectedIndexChanged1">
                              <AlternatingRowStyle BackColor="White" />
                              <EditRowStyle BackColor="#7C6F57" />
                              <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                              <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                              <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                              <RowStyle BackColor="#4F96B0" ForeColor="#000066" HorizontalAlign="Center" VerticalAlign="Top" />
                              <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                              <SortedAscendingCellStyle BackColor="#F8FAFA" />
                              <SortedAscendingHeaderStyle BackColor="#246B61" />
                              <SortedDescendingCellStyle BackColor="#D4DFE1" />
                              <SortedDescendingHeaderStyle BackColor="#15524A" />
                          </asp:GridView>
                      </div>   
                      </div>
               </div>
             
         </div>
 
</asp:Content>
