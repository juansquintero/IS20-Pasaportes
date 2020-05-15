using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_sessionClose : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        E_Auth auth = new E_Auth();
        auth.User_id = ((E_user)Session["validUser"]).Id;
        auth.Session = Session.SessionID;
        new DAO_Security().updateUser(auth);
        Session["validUser"] = null;
        Session.Abandon();
        Session.Clear();
        Response.Redirect("~/View/Login.aspx");
    }
}