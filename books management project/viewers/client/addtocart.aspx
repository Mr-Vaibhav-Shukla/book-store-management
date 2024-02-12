<%@ Page Title="" Language="C#" MasterPageFile="~/viewers/client/ClientView.Master" AutoEventWireup="true" CodeBehind="addtocart.aspx.cs" Inherits="books_management_project.viewers.client.addtocart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script>
    function printbill() {
        var grid = document.getElementById('<%=GridView1.ClientID%>');
        var date = new Date();
        var dd = date.getDate();
        var mm = date.getMonth();
        var yy = date.getYear();
        date = dd+' / '+mm+' / '+yy;
            var pwd = window.open('Prinr', 'print', 'left=1000,top=100,width=1024,height=760,tollbar=0,scrollbar=1,status=0,resizable=1');
            pwd.document.write("<br/> <br/><br/><b>Bill Date:</b>", date);
            pwd.document.write("<center><div><b><label> Crystal Book shop Bill:</label></b></div></center><hr><br><br>", grid.outerHTML);
            pwd.document.close();
            // pwd.focus();
            pwd.print();
            pwd.close();
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:Label ID="Label2" runat="server" Text="ADD TO CART:" style="margin-left:50%;width:30px;margin-top:25px;" BackColor="White" ForeColor="#666666"></asp:Label>
    <div style="margin-left:80%;" class="btn-box mt-4">
       
        <button class="btn-light" style="width:100px" onclick="printbill()">Print</button></div>
    <div style="margin-left:30%;margin-top:12%;">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" Width="449px">
        <AlternatingRowStyle BackColor="#CCCCCC" />
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
        </div>
    <br />
    <br />
    <br />
    <div style="color:red;margin-left:45%;margin-top:0px;position:relative;font-weight:bold"><span class="text-black-50">total price : </span>
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="False" Font-Names="Arial Black"></asp:Label></div>
    <div class="btn btn-block">
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="continue shoping" CssClass="btn-dark"/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="BUY" CssClass="btn-info" Width="97px" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" CssClass="btn-deanger" Font-Bold="True" Text="Complete" Width="101px" BackColor="#FF5050" ForeColor="White" OnClick="Button3_Click" />
    </div>
</asp:Content>
