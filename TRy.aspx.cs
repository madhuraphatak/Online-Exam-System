using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class TRy : System.Web.UI.Page
{
    public static int i = 0;
    SqlConnection scon;
    SqlDataAdapter sda;
    DataSet ds;
    SqlCommand scmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] != null)
        {
            string uid = Convert.ToString(Session["userid"]);
            Label10.Text = uid;
            
        }
        else
        {
            Response.Redirect("Failure.aspx");
        }

        scon = new SqlConnection("server=DESKTOP-E8Q152A\\SQLEXPRESS;uid=sa;pwd=microsoft;database=onlineexam");
        sda = new SqlDataAdapter("select * from table_que;", scon);
        ds = new DataSet();
        sda.Fill(ds, "acc");
        int cnt = ds.Tables["acc"].Rows.Count;
        if (!IsPostBack)
        {

            //i = 0;
            Label1.Text = ds.Tables["acc"].Rows[0]["qid"] + ")";
            Label2.Text = Convert.ToString(ds.Tables["acc"].Rows[0]["que"]);
            Label3.Text = Convert.ToString(ds.Tables["acc"].Rows[0]["op1"]);
            Label4.Text = Convert.ToString(ds.Tables["acc"].Rows[0]["op2"]);
            Label5.Text = Convert.ToString(ds.Tables["acc"].Rows[0]["op3"]);
            Label6.Text = Convert.ToString(ds.Tables["acc"].Rows[0]["op4"]);

        }
    }

    protected void Next(object sender, EventArgs e)
    {
        int cnt = ds.Tables["acc"].Rows.Count;
        i++;
        if (i < cnt)
        {

            Label1.Text = ds.Tables["acc"].Rows[i]["qid"] + ")";
            Label2.Text = Convert.ToString(ds.Tables["acc"].Rows[i]["que"]);
            Label3.Text = Convert.ToString(ds.Tables["acc"].Rows[i]["op1"]);
            Label4.Text = Convert.ToString(ds.Tables["acc"].Rows[i]["op2"]);
            Label5.Text = Convert.ToString(ds.Tables["acc"].Rows[i]["op3"]);
            Label6.Text = Convert.ToString(ds.Tables["acc"].Rows[i]["op4"]);

        }
        else
        {
            i = cnt;
        }
    }
    protected void Back(object sender, EventArgs e)
    {
        i--;
        int cnt = ds.Tables["acc"].Rows.Count;
        if (i >= 0)
        {

            Label1.Text = ds.Tables["acc"].Rows[i]["qid"] + ")";
            Label2.Text = Convert.ToString(ds.Tables["acc"].Rows[i]["que"]);
            Label3.Text = Convert.ToString(ds.Tables["acc"].Rows[i]["op1"]);
            Label4.Text = Convert.ToString(ds.Tables["acc"].Rows[i]["op2"]);
            Label5.Text = Convert.ToString(ds.Tables["acc"].Rows[i]["op3"]);
            Label6.Text = Convert.ToString(ds.Tables["acc"].Rows[i]["op4"]);
        }
        else
        {
            i = 0;
        }


    }
    protected void Save(object sender, EventArgs e)
    {
        

    }   




}
