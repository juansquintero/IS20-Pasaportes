using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Admin_AddRoute : System.Web.UI.Page
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

    protected void BT_Salir_Click(object sender, EventArgs e)
    {
        Response.Redirect("/View/Admin/RouteDrivers.aspx");
    }

    protected void BT_Guardar_Click(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        E_ruta _Ruta = new E_ruta();
        _Ruta.Ruta = TB_Ruta.Text;

        E_ruta _ruta = new DAO_Admin().getRuta(TB_Ruta.Text);
        try
        {
            if (_ruta.Ruta == TB_Ruta.Text)
            {
                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('La ruta ya existe');</script>");
                return;
            }
        }
        catch (NullReferenceException)
        {

        }

        new DAO_Admin().addRuta(_Ruta);
        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('La ruta ha sido registrada');</script>");
   
        TB_Ruta.Text = String.Empty;
    }
}