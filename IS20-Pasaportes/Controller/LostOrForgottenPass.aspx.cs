using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_LostAndForgottenPass : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString.Count > 0)
        {
            E_user e_user = new DAO_Admin().getTokenUser(Request.QueryString[0] == null ? "" : Request.QueryString[0]);

            if (e_user == null)
                this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('El Token es invalido. Genere uno nuevo');window.location=\"PrimerFormulario.aspx\"</script>");
            else if (e_user.EndToken < DateTime.Now)
                this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('El Token esta vencido. Genere uno nuevo');window.location=\"PrimerFormulario.aspx\"</script>");
            else
                Session["user_id"] = e_user;
        }

        else
            Response.Redirect("~/View/Login.aspx");
    }

    protected void B_Cambiar_Click(object sender, EventArgs e)
    {
        E_user e_user = (E_user)Session["user_id"];

        e_user.Pass = Tb_Contraseña.Text;
        e_user.StateId = 1;
        e_user.Token = null;
        e_user.EndToken = null;
        e_user.Sesion = e_user.User;

        new DAO_Admin().editUser(e_user);
        this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Su Contraseña ha sido actualizada.');window.location=\"PrimerFormulario.aspx\"</script>");
    }
}