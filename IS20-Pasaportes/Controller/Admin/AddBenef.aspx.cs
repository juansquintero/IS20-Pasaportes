using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

public partial class View_Admin_AddBenef : System.Web.UI.Page
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

        string fileName = System.IO.Path.GetFileName(FU_Foto.PostedFile.FileName);
        string extension = System.IO.Path.GetExtension(FU_Foto.PostedFile.FileName);        
        string saveLocation = Server.MapPath("~\\Images\\ProfilePictures\\") + DateTime.Now.ToFileTime().ToString() + extension;

        E_user e_user = new E_user();
        e_user.Id_rol = 2;
        e_user.Name = TB_Nombre.Text;
        e_user.Last_name = TB_Apellido.Text;
        e_user.User_name = TB_User.Text;
        e_user.Pass = TB_Pass.Text;
        e_user.Mail = TB_Correo.Text;
        e_user.Id_ruta = int.Parse(DDL_NumRuta.SelectedValue);
        e_user.Activo = CB_Activo.Checked;
        e_user.Profile_pic = saveLocation;

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
        try { 
            if (euser_mail.Mail == TB_Correo.Text)
            {
                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('El correo ya existe');</script>");
                return;
            }
        }catch (NullReferenceException)
        {

        }

        //---------------------------------//
        if (!(extension.Equals(".jpg") || extension.Equals(".jpge") || extension.Equals(".png")))
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Tipo de archivo no valido o no subio archivo');</script>");
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
            FU_Foto.PostedFile.SaveAs(saveLocation);
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('El archivo ha sido cargado');</script>");
        }
        catch (Exception exc)
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Error: ');</script>");
            return;
        }
        try
        {
            if (e_user.Profile_pic == " ")
            {
                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('No ha subido ninguna foto');</script>");
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
        //Generador de usuario ahora en User/QRCode.aspx.cs
        e_user.Qr_hash = RNG_Gen.RNG_gen();
  
        Send_Mail mail = new Send_Mail();
        mail.sendMail(e_user.Mail, e_user.Token, e_user.User_name, e_user.Pass, "");
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