using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Driver_Get_TotalBonos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["validUser"] != null && ((E_user)Session["validUser"]).Id_rol == 3)
        {

        }
        else
        {
            Response.Redirect("~/View/Login.aspx");
        }

        E_user e_user = new E_user();
        E_driver e_driver = new E_driver();

        LB_Nombre.Text = e_user.Name;
        LB_Apellido.Text = e_user.Last_name;
        LB_Bonos.Text = e_driver.Total_pasaporte.ToString();  

    }

    protected void BT_Salir_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/View/DriverHome.aspx");
    }
}