using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;

/// <summary>
/// Summary description for Fixturews
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class Fixturews : System.Web.Services.WebService {

    public Fixturews () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }
    [WebMethod]
    public DataTable GetFixtureTable()
    {
        string sqlStr = "Select [teams], [date], [time], [field], [result] From [FixtureTbl]";
        DataTable dt = DBFunctions.SelectFromTable(sqlStr, "basketdatabase.accdb");
        return dt;
    }
    
}
