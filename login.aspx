<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>DOCTOR APPOINTMENT SYSTEM</title>
    <script src="js/jquery.js"></script>
     <script src="js/script.js"></script>
    <link href="css/design.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="header">
    <h1>DOCTOR APPOINTMENT SYSTEM</h1>
    </div>
        <div id="nav">
            <ul>
               <li><a href="default.aspx">Home</a></li>
                <li><a href="appointment.aspx">Make Appointment</a></li>
                <li><a href="track_appointment.aspx">Track Response</a></li>
                <li><a href="login.aspx">Admin Login</a></li>          
            </ul>


        </div>
       
        <div id="content">
            <div class="form">
            <h3>Admin Login</h3>
                <div>
                    <center>
                        <img src="images/admin_banner.jpg" alt="admin" style="height:100px; width:100px; border-radius:100%;" />
                    </center>
                </div>
            <div id="msg" runat="server" class="msg"></div>
                <input type="text" runat="server" id="username" placeholder="Username" class="txtbox" />
                <input type="password" runat="server" id="password" placeholder="Password" class="txtbox" />
                <asp:Button ID="Button1" runat="server" Text="Login" CssClass="btn" OnClick="login"  />
           </div>


        </div>
       <div class="clear"></div>
         <div id="footer">
    All  right Reserved copyright &copy; 2023.&nbsp;&nbsp;&nbsp;&nbsp;Project by &nbsp;<a href="#" style="font-weight:bold; text-decoration:none; color:#fff;"> AKINOLA MANZUR ADENIYI (HNDCS/021/616)</a>
    </div>

    </form>
</body>
</html>
