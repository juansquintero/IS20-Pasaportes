using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

public partial class View_Admin_AddUser : System.Web.UI.Page
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
        ClientScriptManager cm = this.ClientScript;
        E_user e_user = new E_user();
        e_user.Name = TB_Nombre.Text;
        e_user.Last_name = TB_Apellido.Text;
        e_user.User_name = TB_User.Text;
        e_user.Pass = TB_Pass.Text;
        e_user.Mail = TB_Correo.Text;
        e_user.Id_rol = 1;

        //---------------------------------//

        E_user euser = new DAO_Admin().getUserLogin(TB_User.Text);
        try
        {
            if (euser.User_name == TB_User.Text)
            {
                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('El usuario ya existe');</script>");
                return;
            }
        }
        catch (NullReferenceException)
        {

        }

        E_user euser_mail = new DAO_Admin().getMailUser(TB_Correo.Text);
        try
        {
            if (euser_mail.Mail == TB_Correo.Text)
            {
                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('El correo ya existe');</script>");
                return;
            }
        }
        catch (NullReferenceException)
        {

        }

        //---------------------------------//

        e_user.LastModified = DateTime.Now;
        e_user.Sesion = ((E_user)Session["validUser"]).User_name;

        //---------------------------------//

        Send_Mail mail = new Send_Mail();
        mail.sendMail(e_user.Mail, e_user.Token, "Su usuario: " + e_user.User_name, "Su contraseña: " + e_user.Pass, "Bienvenido administrador.");
        new DAO_Admin().addUser(e_user);
        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('El usuario ha sido registrado');</script>");

        //-------------------------------//

        TB_Pass.Text = String.Empty;
        TB_Nombre.Text = String.Empty;
        TB_Correo.Text = String.Empty;
        TB_Apellido.Text = String.Empty;
        TB_User.Text = String.Empty;

    }

    protected void BT_Salir_Click(object sender, EventArgs e)
    {
        Response.Redirect("/View/Admin/typeUserAdd.aspx");
    }
}
