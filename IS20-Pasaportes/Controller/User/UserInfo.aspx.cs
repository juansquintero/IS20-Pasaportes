using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_User_UserInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["validUser"] != null && ((E_user)Session["validUser"]).Id_rol == 2)
        {

        }
        else
        {
            Response.Redirect("/Login.aspx");
        }

        E_user e_user = new E_user();
        LB_Nombre.Text = ((E_user)Session["validUser"]).Name;
        LB_Apellido.Text = ((E_user)Session["validUser"]).Last_name; 
        LB_PasDisponibles.Text = ((E_user)Session["validUser"]).Pasaporte_numero.ToString(); 
    }

    protected void BT_Salir_Click(object sender, EventArgs e)
    {
        Response.Redirect("/View/UserHome.aspx");
    }
}