<%@ Page Title="" Language="C#" MasterPageFile="~/viewers/admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Books.aspx.cs" Inherits="books_management_project.viewers.admin.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="myContent" runat="server">
     <div class="container-fluid" style="margin-left:150px">
             <div class="col-md-19">
                 <div class="text-center">
                     <h3>Manage Books</h3>
                     <p>&nbsp;</p>
              </div>
                 
              <div class="col-md-6 text-center mt-3">
                 <div class="form-label text-success" style="margin-top:50px;">
                     <label runat="server" id="bname">Book Title:</label>
                </div>
                  <div class="mb-2" style="margin-left:42%;">
                     <input type="text" autocomplete="off" placeholder="Title:" class="form-control" id="booktitle" runat="server" />
                 </div>
             </div>
                  <div class="col-md-6 text-center mt-2" style="padding:5px;">
                 <div class="form-label text-success">
                     <label style="margin-left:5px;">Book Author:</label>
                </div>
                  <div class="mb-2" style="margin-left:42%">
                                           <asp:DropDownList ID="DropDownLis1" runat="server" Class="form-control"></asp:DropDownList>
                 </div>
                 <div class="form-label text-success mt-2">
                     <label style="margin-right:10px;">Categories:</label>
                </div>
                  <div class="mb-2" style="margin-left:42%">
                      <asp:DropDownList ID="DropDownLis2" runat="server" Class="form-control"></asp:DropDownList>
                 </div>

        
                 <div class="form-label text-success mt-2">
                     <label style="margin-right:20px">Price:</label>
                </div>
                  <div class="mb-2" style="margin-left:42%">
                     <input type="text" autocomplete="off" placeholder="Quantity:" class="form-control" id="bookprice" runat="server"/>
                 </div>
                      <div class="form-label-md-1 text-success mt-2">
                     <label style="margin-right:50px;">Quantity:</label>
                </div>
                  <div class="mb-2" style="margin-left:42%">
                     <input type="text" autocomplete="off" placeholder="Price:" class="form-control" id="bookQua" runat="server"/>
                 </div>
                      <div class="form-label text-success mt-2">
                     <label style="margin-right:20px" runat="server" id="bimage">Book Image:</label>
                </div>
                  <div class="mb-2" style="margin-left:42%">
                    <asp:FileUpload ID="fileupload" runat="server" />
                 </div>
                      
                      <div class="d-block mt-3 p-1" style="margin-left:90px">
                          <div>
                          <asp:Label ID="ErrMsg" runat="server" Style="color:red"/>
                              </div>
                          <asp:Button ID="Button3" Text="Update" runat="server" Class="btn-warning btn-block btn" OnClick="Button3_Click" />
                          <asp:Button ID="Button1" Text="Save" runat="server" Class="btn-success btn-block btn" OnClick="Button1_Click" />
                           <asp:Button ID="DeleteBtn" Text="Delete" runat="server" Class="btn-danger mb-2 btn-block btn" OnClick="DeleteBtn_Click"/>
                      </div>
                      <div class="col-md-8">
                          <div style="top:30px;margin-left:35%;position:absolute;display:flexbox">
                             
                          <asp:GridView ID="GridView1" runat="server" Class="table table-bordered" style="margin-left:400px;" BackColor="White" BorderColor="White" BorderWidth="2px"  AutoGenerateSelectButton="True"  OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" BorderStyle="Ridge" CellPadding="3" CellSpacing="1" GridLines="None">
                              <Columns>
                                  
                                  <asp:TemplateField HeaderText="image">

                                     <ItemTemplate>
                                        <asp:Image ID="image" runat="server" ImageUrl='<%#"data:Image/png;base64,"+Convert.ToBase64String((byte[])Eval("BookImage")) %>' Width="50" Height="50"/>
                                     </ItemTemplate>
                                 </asp:TemplateField>
                                 <asp:BoundField HeaderText="Book Name" DataField="BookName" />
                                  
                                  <asp:BoundField HeaderText="Book Price" DataField="Bookprice" />
                                  <asp:BoundField HeaderText="Book Quantity" DataField="BookQua" />
                              </Columns>
                              
                             
                              <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                              <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                              <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                              <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                              <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                              <SortedAscendingCellStyle BackColor="#F1F1F1" />
                              <SortedAscendingHeaderStyle BackColor="#594B9C" />
                              <SortedDescendingCellStyle BackColor="#CAC9C9" />
                              <SortedDescendingHeaderStyle BackColor="#33276A" />
                              
                             
                          </asp:GridView>
                              </div>
                      </div>
             </div>
         </div>
        
         </div>
        
    <style>
        .columan {
            border:2px solid ;
            border-color:black;
        }
    </style>
  
</asp:Content>
