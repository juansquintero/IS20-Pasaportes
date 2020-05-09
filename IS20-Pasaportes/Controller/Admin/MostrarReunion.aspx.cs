using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Admin_MostrarReunion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void BT_Salir_Click(object sender, EventArgs e)
    {
        Response.Redirect("ReunionMenu.aspx");
    }

    protected void BT_Enviar_Click(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;

        string fileName = System.IO.Path.GetFileName(FileUpload1.PostedFile.FileName);
        string extension = System.IO.Path.GetExtension(FileUpload1.PostedFile.FileName);
        string saveLocation = Server.MapPath("~\\View\\Reports\\ActasReunion\\") + DateTime.Now.ToFileTime().ToString() + extension;

        


        if (!(extension.Equals(".pdf")))
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Tipo de archivo no es PDF o no subio archivo');</script>");
            return;
        }

        if (System.IO.File.Exists(saveLocation))
        {
            File.Delete(saveLocation);
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ya existe un archivo en el servidor con ese nombre');</script>");
            return;
        }

        try
        {
            FileUpload1.PostedFile.SaveAs(saveLocation);
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('El archivo ha sido cargado');</script>");
        }
        catch (Exception exc)
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Error: ');</script>");
            return;
        }
        
        E_reunion ren = new DAO_Admin().getDateActa(int.Parse(DropDownList1.SelectedValue));    
        ren.Acta = saveLocation;
        new DAO_Admin().editEmpresaActa(ren);
        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Error2: ');</script>");
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}