using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_User_UserChangePass : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["validUser"] != null && ((E_user)Session["validUser"]).Id_rol == 2)
        {

        }
        else
        {
            Response.Redirect("~/View/Login.aspx");
        }
    }

    protected void B_Cambiar_Click(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        E_user e_user = new DAO_Admin().getUserLogin(((E_user)Session["validUser"]).User_name);
        if (TB_Pass.Text == TB_Repeat.Text)
        {
            e_user.Pass = TB_Pass.Text;
            new DAO_Admin().editUser(e_user);
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Su contraseña ha sido cambiada con exito');</script>");
            Send_Mail mail = new Send_Mail();
            mail.sendMail(e_user.Mail, "", e_user.User_name, e_user.Pass, "Su contraseña se ha actualizado");
            TB_Pass.Text = String.Empty;
            TB_Repeat.Text = String.Empty;
        }
        else
        {            
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Las contraseñas no coinciden');</script>");
            return;
        }                 
    }

    protected void BT_Salir_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/View/User/UserInfo.aspx");
    }
}