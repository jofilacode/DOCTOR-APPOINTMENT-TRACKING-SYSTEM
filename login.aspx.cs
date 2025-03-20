using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["admin"] = null;
    }


    void alert_true(string info)
    {

        msg.InnerText = info;
        msg.Style.Add("color", "#16a085");
        msg.Style.Add("background-color", "#d0ece7");
        msg.Style.Add("display", "block");
    }

    void alert_false(string info)
    {
        msg.InnerText = info;
        msg.Style.Add("color", "#c0392b");
        msg.Style.Add("background-color", "#f5b7b1");
        msg.Style.Add("display", "block");
    }


    protected void login(object sender, EventArgs e)
    {
        if (username.Value == "" || password.Value == "")
        {
            alert_false("Please enter username/password");
        }
        else if (username.Value == "admin" & password.Value == "12345")
        {
            Session["admin"] = "1";
            Response.Redirect("record.aspx");
        }
        else
        {
            alert_false("Invalid Username/Password");
        }
    }
}