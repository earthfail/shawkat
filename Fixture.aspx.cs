using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Fixture : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MatchWS.Fixturews t = new MatchWS.Fixturews();
        GridView1.DataSource = t.GetFixtureTable();
        GridView1.DataBind();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}