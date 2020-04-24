using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Admin_MostrarUsers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["validUser"] != null && ((E_user)Session["validUser"]).Id_rol == 1)
        {

        }
        else
        {
            Response.Redirect("/View/Login.aspx");
        }
    }

    protected void GV_UserMostrar_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void BT_Salir_Click(object sender, EventArgs e)
    {
        Response.Redirect("/View/AdminHome.aspx");
    }

    protected void ODS_UsersMostrar_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}