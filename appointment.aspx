<%@ Page Language="C#" AutoEventWireup="true" CodeFile="appointment.aspx.cs" Inherits="_Default" %>

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
            <h3>Appointment Entry</h3>
            <div id="msg" runat="server" class="msg"></div>
              <input type="text" runat="server" id="cardno" placeholder="Clinic Card No" class="txtbox" />
                 <input type="text" runat="server" id="fullname" placeholder="Fullname" class="txtbox" />
                 <input type="text" runat="server" id="dob" placeholder="Date of Birth" class="txtbox" />
              <asp:DropDownList ID="gender" runat="server" CssClass="txtbox2">
                 <asp:ListItem>Select Gender </asp:ListItem>
                 <asp:ListItem> Male </asp:ListItem>
                 <asp:ListItem> Female </asp:ListItem>
             </asp:DropDownList>
              <input type="text" runat="server" id="adddress" placeholder="Address" class="txtbox" />
              <input type="text" runat="server" id="phone" placeholder="Phone Number" class="txtbox" />
                <asp:DropDownList ID="speciality" runat="server" CssClass="txtbox2">
                 <asp:ListItem>Select Speciality </asp:ListItem>
                    <asp:ListItem>Family medicine</asp:ListItem>
<asp:ListItem>Internal Medicine</asp:ListItem>
<asp:ListItem>Pediatrician</asp:ListItem>
<asp:ListItem>Obstetricians/gynecologist (OBGYNs)</asp:ListItem>
<asp:ListItem>Cardiologist</asp:ListItem>
<asp:ListItem>Oncologist</asp:ListItem>
<asp:ListItem>Gastroenterologist</asp:ListItem>
<asp:ListItem>Pulmonologist</asp:ListItem>
<asp:ListItem>Infectious disease</asp:ListItem>
<asp:ListItem>Nephrologist</asp:ListItem>
<asp:ListItem>Endocrinologist</asp:ListItem>
<asp:ListItem>Ophthalmologist</asp:ListItem>
<asp:ListItem>Otolaryngologist</asp:ListItem>
<asp:ListItem>Dermatologist</asp:ListItem>
<asp:ListItem>Psychiatrist</asp:ListItem>
<asp:ListItem>Neurologist</asp:ListItem>
<asp:ListItem>Radiologist</asp:ListItem>
<asp:ListItem>Anesthesiologist</asp:ListItem>
<asp:ListItem>Surgeon</asp:ListItem>
<asp:ListItem>Physician executive</asp:ListItem>
             </asp:DropDownList>
             <span style="margin-left:15px; font-weight:bold;">Describe Purpose of Appointment: </span>
            <textarea id="purpose" runat="server" class="txtbox" placeholder="Describe Purpose of Appointment"> </textarea>
                <asp:Button ID="Button1" runat="server" Text="Submit" CssClass="btn" OnClick="make_entry"  />
        </div>

           
          

        </div>
       <div class="clear"></div>
        <div id="footer">
    All  right Reserved copyright &copy; 2023.&nbsp;&nbsp;&nbsp;&nbsp;Project by &nbsp;<a href="#" style="font-weight:bold; text-decoration:none; color:#fff;"> AKINOLA MANZUR ADENIYI (HNDCS/021/616)</a>
    </div>

    </form>
</body>
</html>
