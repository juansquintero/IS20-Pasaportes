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
        string num = ((E_user)Session["validUser"]).Id_driver.ToString();
        E_driver ps = new DAO_Admin().getNoPasaportes(int.Parse(num));


        LB_Nombre.Text = ((E_user)Session["validUser"]).Name;
        LB_Apellido.Text = ((E_user)Session["validUser"]).Last_name;
        LB_Bonos.Text = ps.Total_pasaporte.ToString();  

    }

    protected void BT_Salir_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/View/DriverHome.aspx");
    }
}