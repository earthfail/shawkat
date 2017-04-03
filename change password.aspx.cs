using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class change_password : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Type"] != "user")
            Response.Redirect("~/log in.aspx");
    }
   
    protected void Button1_Click(object sender, EventArgs e)
    {
        UserClass user1 = new UserClass();
        if (user1.UserExist(this.TextBox1.Text, this.TextBox2.Text))
        {
            user1.UserEmail = this.TextBox1.Text;
            user1.UpdatePassword(this.TextBox3.Text);

            Label1.Text = "change successful";
            Label1.Visible = true;
        }
        else
        {
            Label1.Text = "Something wrong";
            Label1.Visible = true;
        }
    }
}
