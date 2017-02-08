using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class myaccount : System.Web.UI.Page
{
     string username ;
     string password;
    protected void Page_Load(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
        username = (string)Session["uname"];
        password = (string)Session["pass"];
        Label1.Text=(string)Session["fname"];
        Label2.Text = (string)Session["lname"];
        /*SqlConnection con1 = new SqlConnection();
        con1.ConnectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True";
        SqlCommand cmd1 = new SqlCommand();
        cmd1.CommandType = CommandType.Text;
        cmd1.CommandText = "SELECT * FROM [reg] WHERE (([username] = '" + username + "') AND ([password] ='" + password + "'))";
        cmd1.Connection = con1;
        SqlDataAdapter da1 = new SqlDataAdapter();
        da1.SelectCommand = cmd1;
        DataSet ds1 = new DataSet();
        da1.Fill(ds1, "Test");
        //string UN = TextBox2.Text;
        int count = ds1.Tables["Test"].Rows.Count;
        //TO CHECK THE USERNAME IS UNIQUE OR NOT
        if (count == 1)
        {
            //LOGIN SCCESSFUL
            Label1.Text=ds1.Tables["Test"].Rows[0].ItemArray[2].ToString();
            Label2.Text=ds1.Tables["Test"].Rows[0].ItemArray[3].ToString();

            /*Session.Add("uname", TextBox2.Text);
            Session.Add("pass", TextBox3.Text);
            Response.Redirect("myaccount.aspx");

        }*/
       
       

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
      /*  SqlConnection con1 = new SqlConnection();
        con1.ConnectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True";
        SqlCommand cmd1 = new SqlCommand();
        cmd1.CommandType = CommandType.Text;
        cmd1.CommandText = "SELECT * FROM [book] WHERE ([username] = '" + (string)Session["uname"] + "' AND [password]='" + (string)Session["pass"]+"')";
        cmd1.Connection = con1;
        SqlDataAdapter da1 = new SqlDataAdapter();
        da1.SelectCommand = cmd1;
        DataSet ds1 = new DataSet();
        da1.Fill(ds1, "Test");
        //string UN = TextBox4.Text;
        int count = ds1.Tables["Test"].Rows.Count;
        Label2.Text = count.ToString();
        Label3.Text = ds1.Tables["Test"].Rows[0].ItemArray[2].ToString();
        Label4.Text = ds1.Tables["Test"].Rows[0].ItemArray[3].ToString();
        Label5.Text = ds1.Tables["Test"].Rows[0].ItemArray[4].ToString();
       * */
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
    }
    protected void MultiView1_ActiveViewChanged(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("home.aspx");
        

    }
}