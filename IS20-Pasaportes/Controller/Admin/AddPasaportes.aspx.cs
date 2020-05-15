using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Admin_AddPasaportes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["validUser"] != null && ((E_user)Session["validUser"]).Id_rol == 1)
        {

        }
        else
        {
            Response.Redirect("~/View/Login.aspx");
        }
    }

    protected void BT_Salir_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/View/AdminHome.aspx");
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
    
    }

    protected void GridView1_RowUpdated1(object sender, GridViewUpdateEventArgs e)
    {    
        
    }

    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
        var st = row.Cells[0].Text;
        E_cambioPasaportes e_Cambio = new E_cambioPasaportes();
        E_user hell = new DAO_Admin().getUserId(int.Parse(st));
        e_Cambio.Session = ((E_user)Session["validUser"]).User_name;
        e_Cambio.ChangeDate = DateTime.Now;
        e_Cambio.User_name = hell.User_name;
        e_Cambio.PasaportesAmount = hell.Pasaporte_numero;
        new DAO_Admin().pasaportesCambio(e_Cambio);
    }
}