using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

public class appointment_Api
{
    public OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\WEB DEV\DOCTOR APPOINTMENT SYSTEM\database\appointment_db.mdb");
    public string status;
    public int exe;
    public string xfullname, xidno, xdepartment, xemergency, xlocation, xphone;
    public string security_number;
	public appointment_Api()
	{
    
		
	}
    private void checkconn()
    {
        if (conn.State == ConnectionState.Open)
        {
            conn.Close();
        }
    }
    public string msg()
    {
        return status;
    }

    

    private string appointment_ID()
    {
        Random rnd = new Random();
        return "App-" + rnd.Next(10000, 90000).ToString();
    }

    private string patient_ID()
    {
        Random rnd = new Random();
        return "Pat-" + rnd.Next(10000, 90000).ToString();
    }

    public void new_appointment(string cardno, string fullname, string dob, string gender, string address, string phone, string speciality, string purpose)
    {
        checkconn();
        conn.Open();
        string check = "select * from appointment_data where card_no=@cardno and speciality=@spec and purpose=@purpose and status=@status";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@cardno", cardno);
        cmd.Parameters.AddWithValue("@spec", speciality);
        cmd.Parameters.AddWithValue("@purpose", purpose);
        cmd.Parameters.AddWithValue("@status", "pending");
        OleDbDataReader dr = cmd.ExecuteReader();

        if (dr.Read() == true)
        {
            exe = 0;
            status = "You have previously book this appointment, please wait for response";
        }
        else
        {

            save_appointment(  cardno,  fullname,  dob,  gender,  address,  phone,  speciality,  purpose);
            dr.Close();
            dr.Dispose();

        }
    }

    private void save_appointment(string cardno, string fullname, string dob, string gender, string address, string phone, string speciality, string purpose)
    {
        checkconn();
        conn.Open();
        string new_pat_id = patient_ID();
        string save = "insert into appointment_data values(@id,@pid,@cardno,@fname,@dob,@gen,@add,@phn,@spec,@pur,@sta,@r_time,@r_date,@date)";
        OleDbCommand cmd = new OleDbCommand(save, conn);
        cmd.Parameters.AddWithValue("@id", appointment_ID());
        cmd.Parameters.AddWithValue("@pid", new_pat_id);
        cmd.Parameters.AddWithValue("@cardno", cardno);
        cmd.Parameters.AddWithValue("@fname", fullname);
        cmd.Parameters.AddWithValue("@dob", dob);
        cmd.Parameters.AddWithValue("@gen", gender);
        cmd.Parameters.AddWithValue("@add", address);
        cmd.Parameters.AddWithValue("@phn", phone);
        cmd.Parameters.AddWithValue("@spec", speciality);
        cmd.Parameters.AddWithValue("@pur", purpose);
        cmd.Parameters.AddWithValue("@sta", "Pending");
        cmd.Parameters.AddWithValue("@r_time", "Not-Fixed");
        cmd.Parameters.AddWithValue("@r_date", "Not-Fixed");
        cmd.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());

        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "Appointment has been booked successfully! - Your Patient-ID: " + new_pat_id; 
            exe = 1;
        }
        else
        {
            status = "Error while reporting!";
            exe = 0;
        }
    }


    public DataTable get_all_appointment()
    {
        checkconn();
        string check = "select * from appointment_data";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt;
    }

    public DataTable get_all_appointment_by_patient(string pid)
    {
        checkconn();
        string check = "select app_id,fullname,speciality,purpose,request_time,request_date,status,entry_date from appointment_data where patient_id=@pid";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.Add("@pid", pid);
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt;
    }


    public void update_appointment_status(string time, string date, string status, string id)
    {
        checkconn();
        conn.Open();
        string save = "update appointment_data set request_time=@time,request_date=@date,status=@status where app_id=@appid";
        OleDbCommand cmd = new OleDbCommand(save, conn);
        cmd.Parameters.AddWithValue("@time", time);
        cmd.Parameters.AddWithValue("@date", date);
        cmd.Parameters.AddWithValue("@status", status);
        cmd.Parameters.AddWithValue("@appid", id);
        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "Appointment status has been updated successfully";
            exe = 1;
        }
        else
        {
            status = "Error while updating status!";
            exe = 0;
        }
    }


}