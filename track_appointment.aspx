<%@ Page Language="C#" AutoEventWireup="true" CodeFile="track_appointment.aspx.cs" Inherits="_Default" %>

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
               
                  <h3>Track Doctor Response</h3>
                 <div id="msg" class="msg" runat="server"></div>
                   <input type="text" runat="server" id="patient_id" placeholder="Enter Patient Number" class="txtbox" />
                <asp:Button ID="Button2" runat="server" Text="Track Response" CssClass="btn" OnClick="track_response" style="background-color:#2ecc71;"  />
               
            </div>
            <div style="overflow:scroll;">
            <asp:GridView ID="GridView1" runat="server" EmptyDataText="No  Record yet"></asp:GridView>
                </div>

        </div>
       <div class="clear"></div>
         <div id="footer">
    All  right Reserved copyright &copy; 2023.&nbsp;&nbsp;&nbsp;&nbsp;Project by &nbsp;<a href="#" style="font-weight:bold; text-decoration:none; color:#fff;"> AKINOLA MANZUR ADENIYI (HNDCS/021/616)</a>
    </div>

    </form>
</body>
</html>
