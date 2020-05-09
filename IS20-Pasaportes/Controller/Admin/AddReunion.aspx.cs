using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Admin_AddReunion : System.Web.UI.Page
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


    protected void btnSave_Click(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;

        DateTime dob = DateTime.Parse(Request.Form[TextBox1.UniqueID]);
        E_reunion reu = new E_reunion();
        reu.Fecha = dob;
        new DAO_Admin().addReunion(reu);
        List<E_user> mail_user = new DAO_Admin().getUserMail();

        Send_Mail mail = new Send_Mail();

        foreach(E_user mails in mail_user)
        {
            mail.sendMail(mails.Mail, "", "", "", "Se ha registrado una nueva reunion: " + dob.ToString());
        }
       
        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Se ha programado la reunion y se ha informado a los usuarios');</script>");
    }

    protected void BT_Salir_Click(object sender, EventArgs e)
    {
        Response.Redirect("ReunionMenu.aspx");
    }
}