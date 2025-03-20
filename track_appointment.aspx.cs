using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Threading.Tasks;
using System.Net;
using System.Threading.Tasks;

public partial class _Default : System.Web.UI.Page
{

    appointment_Api data = new appointment_Api();
    protected void Page_Load(object sender, EventArgs e)
    {
       
       
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



    protected void track_response(object sender, EventArgs e)
    {
        if(patient_id.Value=="")
        {
            alert_false("Enter Patient ID");
        }
        else
        {
            GridView1.DataSource = data.get_all_appointment_by_patient(patient_id.Value);
            GridView1.DataBind();
        }
    }

   


}