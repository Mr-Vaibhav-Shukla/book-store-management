<%@ Page Title="" Language="C#" MasterPageFile="~/viewers/admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Bill.aspx.cs" Inherits="books_management_project.viewers.admin.Bill" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="myContent" runat="server">
    <div class="bg-body" style="margin-left:300px;position:relative;padding:2%;text-justify:inherit;text-align:center;font-size:2rem;font-family:CordiaUPC;margin-top:8%;letter-spacing:2px;font-weight:100;">
        <label>Manage Bill:</label>
    </div>
     <div class="col-md-6 text-center mt-3">
                   <div class="form-label text-success">
                     <label>System Id:</label>
                </div>
                  <div class="mb-2" style="margin-left:53%;line-height:30px;padding:10px">
                     <input type="text" autocomplete="off" class="form-control" runat="server" id="Bid" disabled="disabled" style="border-style:hidden;text-align:center;width:40%" />
                 </div>
             </div>  <div style="margin-left:30%">
        <asp:Button ID="Button1" runat="server" Text="Delete" BackColor="Red" Font-Bold="true" ForeColor="White" Width="126px" BorderStyle="Groove" Height="36px" BorderColor="Black" BorderWidth="2px" CssClass="btn btn-block btn-danger" OnClick="Button1_Click"/>                                
    </div>
     <div class="col-md-3">
         <div style="margin-left:130px">
                               <asp:Label runat="server" id="ErrMsg" Class="text-danger-emphasis"></asp:Label>                             
                          </div>
                       <div class="mt-auto" style="margin-left:30%;margin-bottom:100%;position:absolute;top:20%;left:30%">
                           <asp:GridView ID="GridView1" runat="server" CellPadding="4" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" ForeColor="#333333" GridLines="None" Width="316px">
                               <AlternatingRowStyle BackColor="White" />
                               <EditRowStyle BackColor="#2461BF" />
                               <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
                               <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                               <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                               <RowStyle BackColor="#EFF3FB" />
                               <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                               <SortedAscendingCellStyle BackColor="#F5F7FB" />
                               <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                               <SortedDescendingCellStyle BackColor="#E9EBEF" />
                               <SortedDescendingHeaderStyle BackColor="#4870BE" />
                           </asp:GridView>
                      </div>   
                      </div>
</asp:Content>
