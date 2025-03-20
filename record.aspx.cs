using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    appointment_Api data = new appointment_Api();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] != null)
        {
            if (!IsPostBack)
            {
                getdata();
            }
        }
        else
        {
            Response.Redirect("login.aspx");
        }
    }

    void getdata()
    {
        GridView1.DataSource = data.get_all_appointment();
        GridView1.DataBind();
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

    protected void GridView1_OnRowCommand(object sender, GridViewCommandEventArgs e)
    {
      
        if (e.CommandName == "approve")
        {
            postid.Value = e.CommandArgument.ToString();
            updatebox.Style.Add("display", "block");
        }
       else if (e.CommandName == "decline")
        {
            string id = e.CommandArgument.ToString();
            data.update_appointment_status("Cancelled","Cancelled","Declined", id);
            getdata();
            alert_true("Successful");
        }
    }

    protected void approve_request(object sender, EventArgs e)
    {
        if(request_time.Value=="" || request_date.Value=="" || doctor_response.Value=="")
        {
            alert_false("All fields are required");
        }
        else
        {
            data.update_appointment_status(request_time.Value, request_date.Value, doctor_response.Value, postid.Value);
            getdata();
            alert_true("Successful");
            request_date.Value = "";
            request_time.Value = "";
        }
    }

  
 
}