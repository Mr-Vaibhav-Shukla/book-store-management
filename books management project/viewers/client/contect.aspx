<%@ Page Title="" Language="C#" MasterPageFile="~/viewers/client/ClientView.Master" AutoEventWireup="true" CodeBehind="contect.aspx.cs" Inherits="books_management_project.viewers.client.contect" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <section class="contact_section layout_padding">
    <div class="container">
      <div class="row">
        <div class="col-md-6 ">
          <div class="heading_container ">
            <h2 class="">
              Contact Us
            </h2>
          </div>
          <form action="#">
            <div>
              <input type="text" placeholder="Name" id="cname" runat="server"/>
            </div>
            <div>
              <input type="email" placeholder="Email" id="cemail" runat="server"/>
            </div>
            <div>
              <input type="text" placeholder="Phone number" id="cnum" runat="server"/>
            </div>
            <div>
              <input type="text" class="message-box" placeholder="Message" id="cmsg" runat="server"/>
            </div>
            <div class="btn-box">
               <asp:Button ID="Button1" runat="server" Text="Subscribe" BorderStyle="Solid" Font-Bold="true" BackColor="Yellow" OnClick="Button1_Click"></asp:Button>
            </div>
          </form>
        </div>
        <div class="col-md-6">
          <div class="img-box">
            <img src="../../Assites/images/contact-img.jpg" alt="">
          </div>
        </div>
      </div>
    </div>
  </section>

  <!-- end contact section -->
</asp:Content>
