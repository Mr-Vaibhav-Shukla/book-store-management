<%@ Page Title="" Language="C#" MasterPageFile="~/viewers/admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="contecct.aspx.cs" Inherits="books_management_project.viewers.admin.contecct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="myContent" runat="server">
    <div class="bg-body" style="margin-left:300px;position:relative;padding:2%;text-justify:inherit;text-align:center;font-size:2rem;font-family:CordiaUPC;margin-top:8%;letter-spacing:2px;font-weight:100;">
        <label>Manage Contects:</label>
    </div>
     <div class="col-md-6 text-center mt-3">
                   <div class="form-label text-success">
                     <label>System Id:</label>
                </div>
                  <div class="mb-2" style="margin-left:53%;line-height:30px;padding:10px">
                     <input type="text" autocomplete="off" class="form-control" runat="server" id="Aid" disabled="disabled" style="border-style:hidden;text-align:center;width:40%" />
                 </div>
             </div>  <div style="margin-left:30%">
        <asp:Button ID="Button1" runat="server" Text="Delete" BackColor="Red" Font-Bold="true" ForeColor="White" Width="126px" BorderStyle="Groove" Height="36px" BorderColor="Black" BorderWidth="2px" OnClick="Button1_Click"/>                                
    </div>
     <div class="col-md-3">
         <div style="margin-left:130px">
                               <asp:Label runat="server" id="ErrMsg" Class="text-danger-emphasis"></asp:Label>                             
                          </div>
                       <div class="mt-auto" style="margin-left:30%;margin-bottom:100%;position:absolute;top:20%;left:30%">
                          <asp:GridView ID="seb" AutoGenerateColumns="false" runat="server" Class="table table-bordered" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" Width="166%" Height="71px" OnSelectedIndexChanged="seb_SelectedIndexChanged">
                              <AlternatingRowStyle BackColor="White" />
                              <Columns>
                                  <asp:BoundField HeaderText="Id" DataField="id" />
                                  <asp:BoundField HeaderText="Name" DataField="name" />
                                  <asp:BoundField HeaderText="Email" DataField="email" />
                                  <asp:BoundField HeaderText="Mobile" DataField="mobile" />
                                  <asp:BoundField HeaderText="Message" DataField="message" />
                              </Columns>
                              <EditRowStyle BackColor="#7C6F57" />
                              <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                              <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                              <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                              <RowStyle BackColor="#4F96B0" ForeColor="#000066" HorizontalAlign="Justify" VerticalAlign="Top" />
                              <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                              <SortedAscendingCellStyle BackColor="#F8FAFA" />
                              <SortedAscendingHeaderStyle BackColor="#246B61" />
                              <SortedDescendingCellStyle BackColor="#D4DFE1" />
                              <SortedDescendingHeaderStyle BackColor="#15524A" />
                          </asp:GridView>
                      </div>   
                      </div>
</asp:Content>
