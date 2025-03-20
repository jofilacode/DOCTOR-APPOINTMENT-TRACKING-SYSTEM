<%@ Page Language="C#" AutoEventWireup="true" CodeFile="record.aspx.cs" Inherits="_Default" %>

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
               <li><a href="record.aspx">Home</a></li>
                <li><a href="login.aspx">Logout</a></li>             
            </ul>


        </div>
       
       
        <div id="content">
            <div class="form">
                 <div id="msg" class="msg" runat="server"></div>

                <h3>Patient Appointment Record</h3>
           
                <div id="updatebox" runat="server" style="display:none;">
             
             <input type="text" runat="server" id="request_time" placeholder="Time" class="txtbox" />
             <input type="text" runat="server" id="request_date" placeholder="Date" class="txtbox" />
             <input type="text" runat="server" id="doctor_response" placeholder="Doctor Response" class="txtbox" />
             <asp:Button ID="Button2" runat="server" Text="Update Request" CssClass="btn" OnClick="approve_request" style="background-color:#2ecc71;"  />
                 </div>
                </div>
            <hr />
            <div style="overflow:scroll;">
            <asp:GridView ID="GridView1" runat="server" EmptyDataText="No  Record yet" OnRowCommand="GridView1_OnRowCommand">
                 <Columns>
                    <asp:TemplateField ShowHeader="False" >
                   <ItemTemplate>
                     <asp:Button ID="Button1" CssClass="delbtn" runat="server" CausesValidation="false" CommandName="approve" style="padding:10px; background-color:#27ae60;color:#fff; border:0; cursor:pointer; border-radius:10px;"
                             Text="Accept" CommandArgument='<%# Eval("app_id") %>' /> <hr />
                            <asp:Button ID="myupbtn" CssClass="delbtn" runat="server" CausesValidation="false" CommandName="decline" style="padding:10px; background-color:#bd3d3d;color:#fff; border:0; cursor:pointer; border-radius:10px;"
                             Text="Decline" CommandArgument='<%# Eval("app_id") %>' />
                     
                      </ItemTemplate>
                    </asp:TemplateField>
                 
                </Columns>
            </asp:GridView>
                  <asp:HiddenField ID="postid" runat="server" />
                </div>
        </div>
       <div class="clear"></div>
       <div id="footer">
    All  right Reserved copyright &copy; 2023.&nbsp;&nbsp;&nbsp;&nbsp;Project by &nbsp;<a href="#" style="font-weight:bold; text-decoration:none; color:#fff;"> AKINOLA MANZUR ADENIYI (HNDCS/021/616)</a>
    </div>

    </form>
</body>
</html>
