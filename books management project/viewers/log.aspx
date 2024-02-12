<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="log.aspx.cs" Inherits="books_management_project.viewers.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <link href="Assites/lib/custom.css" rel="stylesheet" />
     
  <link href="../../Assites/lib/custom/css/font-awesome.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="../../Assites/lib/css/bootstrap.min.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
      <div class="col-md-15 text-center">
          <div class="img-fluid mt-5" style="">
              <img src="../Assites/images/benner.png"  alt="" width="300" style="max-height:200px;border:2px thick;border-radius:50%"/>
          </div>
                 <div class="form-label" style="font-size:30px;font-family:BrowalliaUPC;letter-spacing:2px">
                     <label>Login</label>
                </div>
                  <div class="form-label">
                     <input type="text" autocomplete="off" placeholder="Enter User Id:" class="form-control" runat="server" id="uname" style="width:25%;margin-left:39%"/>
                 </div><br />
          <div class="">
                     <input type="password" autocomplete="off" placeholder="Enter passwored:" class="form-control" runat="server" id="upass" style="width:25%;margin-left:39%"/>
                 </div>
          <div class="d-block mt-3 p-3">
              <div style="padding-left:3%;width:100%">
             <asp:Button ID="log" runat="server" class="btn" Text="Login" CssClass="btn-success mb-2 btn-block btn" OnClick="log_Click" Width="134px" />
                  </div>
              </div>
             </div>
        </div>
    </form>
</body>
</html>
