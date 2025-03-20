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


    protected void make_entry(object sender, EventArgs e)
    {
        double k;
        if(cardno.Value=="" || fullname.Value=="" || dob.Value=="" || gender.SelectedIndex==0 || adddress.Value=="" || phone.Value=="" || speciality.SelectedIndex==0 || purpose.Value=="" )
        {
            alert_false("All fields are required!");
        }
        else if(double.TryParse(phone.Value, out k)== false)
        {
            alert_false("Invalid Phone Number");
        }
        else
        {
            data.new_appointment(cardno.Value, fullname.Value, dob.Value, gender.Text, adddress.Value, phone.Value, speciality.Text, purpose.Value);
            if(data.exe==1)
            {
                alert_true(data.msg());
                clear();
            }
            else
            {
                alert_false(data.msg());
            }
        }
    }
  

    void clear()
    {
        cardno.Value = "";
        fullname.Value = "";
        dob.Value = "";
        gender.SelectedIndex = 0;
        adddress.Value = "";
        phone.Value = "";
        speciality.SelectedIndex = 0;
        purpose.Value = "";
        fullname.Focus();
    }


}