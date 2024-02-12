<%@ Page Title="" Language="C#" MasterPageFile="~/viewers/admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="seller.aspx.cs" Inherits="books_management_project.viewers.admin.seller" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="myContent" runat="server">
     <div class="container-fluid">
             <div class="col-md-19">
                 <div class="text-center">
                     <h3>Manage Sellers:</h3>
              </div>
              <div class="col-md-6 text-center mt-3">
                  <div class="form-label text-success">
                     <label>System Id:</label>
                </div>
                  <div class="mb-2" style="margin-left:42%">
                     <input type="text" autocomplete="off" class="form-control" runat="server" id="sid" disabled="disabled" style="border-style:hidden" />
                 </div>
                 <div class="form-label text-success">
                     <label style="margin-left:10px">Seller Name:</label>
                </div>
                  <div class="mb-2" style="margin-left:42%">
                     <input type="text" autocomplete="off" placeholder="Seller Name:"  class="form-control" runat="server" id="sellerName" pattern="[A-Za-z\s]{2,}" title="enter only name" required="" />
                 </div>
             </div>
                  <div class="col-md-6 text-center mt-2" style="padding:5px;">
                 <div class="form-label text-success"
                     <label style="margin-right:15px;">Seller Email:</label>
                </div>
                  <div class="mb-2" style="margin-left:42%">
                    <input type="Email" autocomplete="off" placeholder="Seller Email:"  class="form-control" runat="server" id="sellerEm" pattern="[a-z]+[0-9]+@[a-z]+.com" required="" title="Please enter valid email"/>
                 </div>
                 </div>
                      <div class="col-md-6 text-center mt-3">
                 <div class="form-label text-success">
                     <label style="margin-left:69px">Seller passwored:</label>
                </div>
                  <div class="mb-2" style="margin-left:42%">
                     <input type="text" autocomplete="off" placeholder="Seller password:"  class="form-control" runat="server" id="sellerphone" required="" pattern="(?=.*\d)(?=.[a-z])(?=.*[A-z]).{9,}" title="Must contain at least one number and one uppercase and lowercase letter,and at least 9 or more characters"/>
                 </div>
             </div>
                <div class="col-md-6 text-center mt-3">
                 <div class="form-label text-success">
                     <label style="margin-left:15px">Seller city:</label>
                </div>
                  <div class="mb-2" style="margin-left:42%">
                     <textarea class="form-control" runat="server" id="selleraddress1" placeholder="Seller Address:" required=""></textarea>
                 </div>
             </div>
                   
                      <div class="d-block mt-3 p-1" style="margin-left:130px">
                            <div style="margin-left:130px">
                               <asp:Label runat="server" id="ErrMsg" Class="text-danger-emphasis"></asp:Label>                             
                          </div>
                         <div style="margin-left:150px">
                           <asp:Button ID="ubtn" Text="Update" runat="server" Class="btn-warning mb-2 btn-block btn" OnClick="ubtn_Click" />
                          <asp:Button ID="Savebtn" Text="Save" runat="server" Class="btn-success mb-2 btn-block btn" OnClick="Savebtn_Click"/>
                          <asp:Button ID="Deletbtn" Text="Delete" runat="server" Class="btn-danger mb-2 btn-block btn" OnClick="Deletbtn_Click"/>
                      
                         </div>
                          </div>
                      <div class="col-md-8">
                       <div class="mt-auto" style="margin-left:60%;margin-bottom:10%;position:absolute;display:flexbox;top:30px;left:2%;">
                          <asp:GridView ID="sellerList" runat="server" Class="table table-bordered" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="TRUE" OnSelectedIndexChanged="sellerList_SelectedIndexChanged">
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
       </div>
</asp:Content>
