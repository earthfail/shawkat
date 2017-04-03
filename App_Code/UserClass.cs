
using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.OleDb;

/// <summary>
/// Summary description for UserClass
/// </summary>
public class UserClass
{
    private string userEmail;
    private string userPassword;
    private string userFirstName;
    private string userLastName;
    private string userType;

    public UserClass()
    {
        this.userType = "Guest";

        //
        // TODO: Add constructor logic here
        //
    }

    public string UserEmail
    {
        get { return userEmail; }
        set { this.userEmail = value; }
    }

    public string UserPassword
    {
        get { return userPassword; }
        set { this.userPassword = value; }
    }


    public string UserFirstName
    {
        get { return userFirstName; }
        set { this.userFirstName = value; }
    }


    public string UserLastName
    {
        get { return userLastName; }
        set { this.userLastName = value; }
    }

    public string UserType
    {
        set { this.userType = value; }
        get { return this.userType; }
    }
    public bool AdminExist(string AdminEmail, string AdminPassword)
    {
        string userSqlStr = "select  [AdminEmail] from [AdminTbl] where [AdminEmail]='" +
            AdminEmail + "' and [AdminPassword]='" + AdminPassword + "'";
        DataTable dt = DBFunctions.SelectFromTable(userSqlStr, "shawkat11.accdb");
        if (dt.Rows.Count > 0)
            return true;
        return false;
    }
    public bool UserExist(string userEmail, string userPassword)
    {
        string userSqlStr = "select  [userEmail] from [UserTbl] where [userEmail]='" +
            userEmail + "' and [userPassword]='" + userPassword + "'";
        DataTable dt = DBFunctions.SelectFromTable(userSqlStr, "shawkat11.accdb");
        if (dt.Rows.Count > 0)
            return true;
        return false;
    }
    public string UserDetails(string userEmail)
    {
        string userSqlStr = "select  [UserFirstName] , [UserLastName] from [UserTbl] where [userEmail]='" + userEmail + "'";
        DataTable dt = DBFunctions.SelectFromTable(userSqlStr, "shawkat11.accdb");
        if (dt.Rows.Count > 0)
            return dt.Rows[0][0].ToString() + " " + dt.Rows[0][1].ToString();
        return " ";

    }
    public bool UserExistSignUp()
    {
        string userSqlStr = "select  [userEmail] from [UserTbl] where [userEmail]='" + this.userEmail + "'";
        DataTable dt = DBFunctions.SelectFromTable(userSqlStr, "shawkat11.accdb"); 
        if (dt.Rows.Count > 0)
            return true;
        return false;
    }
    public bool CheckAdmin2(string userEmail, string userPassword)
    {
        string userSqlStr = "select  * from [UserTbl] where [userEmail]='" + userEmail + "' and [userPassword]='" + userPassword + "' and [userTybe]='Admin' ";
        DataTable dt = DBFunctions.SelectFromTable(userSqlStr, "shawkat11.accdb");

        if (dt.Rows.Count > 0)
            return true;
        else
            return false;
    }

    public bool CheckAdmin(string userEmail, string userPassword)
    {
        DataSet ds = new DataSet();
        ds.ReadXml(HttpContext.Current.Server.MapPath("~/XMLLoginFile.xml"));
        DataTable dt = ds.Tables[0];
        if (dt != null)
            if (dt.Rows.Count > 0)
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["email"].ToString() == userEmail && dt.Rows[i]["password"].ToString() == userPassword)
                        return true;
                }
        return false;
    }
    public void UpdateFname(string newFname)
    {

        string userSqlStr = "Update [UserTable] Set [userFirstName]='" + newFname + "' where [userEmail]='" + this.userEmail + "'";
        DBFunctions.ChangeTable(userSqlStr, "shawkat11.accdb");


    }
    public void UpdateLname(string newLname)
    {

        string userSqlStr = "Update [UserTable] Set [userLastName]='" + newLname + "' where [userEmail]='" + this.userEmail + "'";
        DBFunctions.ChangeTable(userSqlStr, "shawkat11.accdb");


    }
    public void UpdatePassword(string newPassword)
    {

        string userSqlStr = "Update [UserTbl] Set [userPassword]='" + newPassword + "' where [userEmail]='" + this.userEmail + "'";
        DBFunctions.ChangeTable(userSqlStr, "shawkat11.accdb");

    }
}