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
        Session["validUser"] = null;
        Response.Redirect("Login.aspx");
    }
}