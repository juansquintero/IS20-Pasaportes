using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Admin_MostrarReport : System.Web.UI.Page
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

protected void BT_Mostrar_Click(object sender, EventArgs e)
    {
        E_reportes rep = new DAO_Admin().getIdReporte(int.Parse(DropDownList1.SelectedValue));
        var parseJson = Newtonsoft.Json.JsonConvert.DeserializeObject<List<JsonHelper>>(File.ReadAllText(rep.Path));
        GridView1.DataSource = parseJson;
        GridView1.DataBind();
    }

    protected void BT_Salir_Click(object sender, EventArgs e)
    {
        Response.Redirect("ReporteUsuario.aspx");
    }
}
