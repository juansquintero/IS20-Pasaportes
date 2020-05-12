using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Admin_MostrarAddEmpresa : System.Web.UI.Page
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

    protected void BT_Enviar_Click(object sender, EventArgs e)
    {
        E_driver _driver = new E_driver();
        _driver.Empresa = TB_Empresa.Text;
        ClientScriptManager cm = this.ClientScript;
        E_driver driver = new DAO_Admin().getEmpresa(TB_Empresa.Text);
        try
        {
            if (driver.Empresa == TB_Empresa.Text)
            {
                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('La ruta ya existe');</script>");
                return;
            }
        }
        catch (NullReferenceException)
        {

        }

        new DAO_Admin().addEmpresa(_driver);
        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('La ruta ha sido registrada');</script>");

        TB_Empresa.Text = String.Empty;
    }

    protected void BT_Salir_Click(object sender, EventArgs e)
    {
        Response.Redirect("/View/Admin/RoutesDrivers.aspx");
    }
}