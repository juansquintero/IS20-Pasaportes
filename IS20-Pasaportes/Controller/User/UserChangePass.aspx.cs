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
        E_user e_user = new E_user();
        if (TB_Pass == TB_Repeat)
        {
            e_user.Pass = TB_Pass.Text;
            new DAO_Admin().editUser(e_user);
        }
        else
        {
            ClientScriptManager cm = this.ClientScript;
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Las contraseñas no coinciden');</script>");
            return;
        }                 
    }

    protected void BT_Salir_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/View/User/UserInfo.aspx");
    }
}