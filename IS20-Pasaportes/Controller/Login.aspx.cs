using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LG_Proyecto_Authenticate(object sender, AuthenticateEventArgs e)
    {
       
    }

    protected void Connection()
    {
        E_Auth authenticate = new E_Auth();
        Mac connection = new Mac();
        authenticate.fecha_Fin = DateTime.Now;
        authenticate.Ip = connection.ip();
        authenticate.Mac = connection.mac();
        authenticate.User_id = ((E_user)Session["validUser"]).Id;
        authenticate.Session = Session.SessionID;
        new DAO_Security().insertAuthetication(authenticate);
    }

    protected void LoginButton_Click(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        E_user e_user = new E_user();
        e_user.User_name = LG_Proyecto.UserName.ToString();
        e_user.Pass = LG_Proyecto.Password.ToString();
        e_user = new DAO_Login().Login(e_user);

        if (e_user == null)
        {
            ((Label)LG_Proyecto.FindControl("L_Mensaje")).Text = "Usuario o contraseña incorrecto";
        }
        else if (e_user.State_Id == 2)
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Su cuenta esta en espera de Recuperar Contraseña');</script>");
            return;
        }
        else if (e_user.Id_rol == 1)
        {
            ((Label)LG_Proyecto.FindControl("L_Mensaje")).Text = "Bienvenido señor administrador";
            Session["validUser"] = e_user;
            Connection();
            Response.Redirect("AdminHome.aspx");
        }
        else if (e_user.Id_rol == 2)
        {
            ((Label)LG_Proyecto.FindControl("L_Mensaje")).Text = "Bienvenido beneficiario";
            Session["validUser"] = e_user;
            Connection();
            Response.Redirect("UserHome.aspx");
        }
        else if (e_user.Id_rol == 3)
        {
            ((Label)LG_Proyecto.FindControl("L_Mensaje")).Text = "Bienvenido conductor";
            Session["validUser"] = e_user;
            Connection();
            Response.Redirect("DriverHome.aspx");
        }
    }

    protected void BT_Recuperar_Click(object sender, EventArgs e)
    {
        
    }

    protected void LB_Recuperar_Click(object sender, EventArgs e)
    {
        ((TextBox)LG_Proyecto.FindControl("TB_Validate")).Visible = true;
        ((Button)LG_Proyecto.FindControl("BT_Recuperar")).Visible = true;
    }
}