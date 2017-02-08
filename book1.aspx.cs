using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

public partial class book1 : System.Web.UI.Page
{
   // private string a;
    public string username;
    public string password;
    //public string bankname;
    protected void Page_Load(object sender, EventArgs e)
    {
        //Label30.Text = (string)Session["uname"];
      //  username=(string)Session["uname"];
        //password=(string)Session["pass"];

        
    }
    protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
    {
        
       //Label2.Text = DropDownList1.SelectedValue;
       // Label3.Text = TextBox1.Text;
     //   Label38.Text = DropDownList1.SelectedValue;
     
      
        Response.Redirect("book2.aspx");
        
    }

   
    protected void Wizard1_NextButtonClick(object sender, WizardNavigationEventArgs e)
    {
        AddControls();
      /*  Label38.Text = DropDownList1.SelectedValue;
        Label39.Text = TextBox3.Text;
        Label40.Text = TextBox2.Text;
        Label27.Text = RadioButtonList1.SelectedValue + " " + DropDownList2.SelectedValue + "  Hotel";
        Label41.Text = RadioButtonList2.SelectedValue;
        //Label30.Text = username + password;
        Label29.Text = Label13.Text;
        Label2.Text = "Hello   "+TextBox4.Text+"...";
        Label42.Text = bankname;
    */
    }

    private void AddControls()
    {
         int a=Convert.ToInt32(TextBox2.Text);
         int b = Convert.ToInt32(TextBox3.Text);
         int c = a + b;
      TextBox[] txt=new TextBox[c];
      Label l1 = new Label();
      l1.Text = "Enter other person's Name : ";
      PlaceHolder2.Controls.Add(l1);
      PlaceHolder2.Controls.Add(new LiteralControl("<br/>"));

      for (int i = 0; i <c; i++)
      {

          txt[i] = new TextBox();

          txt[i].ID = "name" + i;
        

          //  Panel p1 = new Panel();
        // PlaceHolder1.Controls.Add(l1[i]);
          PlaceHolder2.Controls.Add(txt[i]);
          PlaceHolder2.Controls.Add(new LiteralControl("<br/>"));
      //    PlaceHolder1.Controls.Add(new LiteralControl("<br/>"));

          //  p1.Controls.Add(dyc);
          ViewState["controlsadded"] = true;
      }
    }


    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {
       
      
        
    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }
 //   public int children_price { get; set; }
    protected void RadioButtonList2_SelectedIndexChanged1(object sender, EventArgs e)
    {
     /*   SqlConnection cn = new SqlConnection();
        cn.ConnectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True";
        cn.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = cn;
        cmd.CommandText = "SELECT [adult_price], [children_price] FROM [price1] WHERE (([package no] = '" + DropDownList1.SelectedItem + "') AND ([hotel] ='" + RadioButtonList1.SelectedItem + "') AND ([hotel_name] = '" + DropDownList2.SelectedItem + "') AND ([room_type] ='" + RadioButtonList2.SelectedItem + "'))";
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        DataSet ds = new DataSet();
        da.Fill(ds, "S1");
        string a = ds.Tables["S1"].Rows[0].ItemArray[0].ToString();
        string b = ds.Tables["S1"].Rows[0].ItemArray[1].ToString();
        int c = Convert.ToInt32(a);
        int d = Convert.ToInt32(b);
        int x = Convert.ToInt32(TextBox3.Text);
        int y = Convert.ToInt32(TextBox2.Text);

        int f = c * x;
        int s = d * y;
        int z = f + s;

        Label11.Text = f.ToString();
        Label12.Text = s.ToString();
        Label13.Text = z.ToString();
        GridView1.DataSource = ds;
        GridView1.DataBind();*/
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection();
        cn.ConnectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True";
        cn.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = cn;
        cmd.CommandText = "SELECT [adult_price], [children_price] FROM [price1] WHERE (([package no] = '" + DropDownList1.SelectedItem + "') AND ([hotel] ='" + RadioButtonList1.SelectedItem + "') AND ([hotel_name] = '" + DropDownList2.SelectedItem + "') AND ([room_type] ='" + RadioButtonList2.SelectedItem + "'))";
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        DataSet ds = new DataSet();
        da.Fill(ds, "S1");
        string a = ds.Tables["S1"].Rows[0].ItemArray[0].ToString();
        string b = ds.Tables["S1"].Rows[0].ItemArray[1].ToString();
        int c = Convert.ToInt32(a);
        int d = Convert.ToInt32(b);
        int x = Convert.ToInt32(TextBox3.Text);
        int y = Convert.ToInt32(TextBox2.Text);

        int f = c * x;
        int s = d * y;
        int z = f + s;

        Label11.Text = f.ToString();
        Label12.Text = s.ToString();
        Label13.Text = z.ToString();
        GridView1.DataSource = ds;
        GridView1.DataBind();
       
     
    }
   
    
    protected void TextBox8_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList3.SelectedIndex == 0)
        {
            TextBox10.Enabled = true;
            AddControls();
        }
        else
        {
            TextBox10.Enabled = false;
            AddControls();
        }
    }
}