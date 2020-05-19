using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Admin_ReporteUsuario : System.Web.UI.Page
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

    protected void BT_GenerarReporte_Click(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        string json = JsonConvert.SerializeObject(new DAO_Admin().getUserActivo().ToArray(), Formatting.Indented, new JsonSerializerSettings {NullValueHandling = NullValueHandling.Ignore});
        string path = Server.MapPath("~\\View\\Reports\\Usuarios\\") + DateTime.Now.ToFileTime().ToString() + ".json";
        System.IO.File.WriteAllText(path, json);
        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('El resporte se ha generado');</script>");

        E_reportes rep = new E_reportes();
        rep.ReportDate = DateTime.Now;
        rep.Path = path;
        new DAO_Admin().addReport(rep);
    }

    protected void BT_Purgar_Click(object sender, EventArgs e)
    {

    }

    protected void BT_MostrarReporte_Click(object sender, EventArgs e)
    {
        Response.Redirect("MostrarReport.aspx");

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void BT_Salir_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/View/AdminHome.aspx");
    }
}