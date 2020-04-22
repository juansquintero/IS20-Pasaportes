﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Admin_AddUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["validUser"] != null && ((E_user)Session["validUser"]).Id_rol == 1)
        {

        }
        else
        {
            Response.Redirect("Login.aspx");
        }

    }

    protected void BT_Enviar_Click(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;

        E_user e_user = new E_user();
        //e_user.Id = int.Parse(TB_Id.Text);
        e_user.Name = TB_Nombre.Text;
        e_user.Last_name = TB_Apellido.Text;
        e_user.User = TB_User.Text;
        e_user.Pass = TB_Pass.Text;
        e_user.Mail = TB_Correo.Text;
        e_user.Sesion = ((E_user)Session["validUser"]).User;
        e_user.Id_ruta = int.Parse(DDL_NumRuta.SelectedValue);
        e_user.Activo = CB_Activo.Checked;
        e_user.Id_rol = int.Parse(DDL_Rol.SelectedValue);
        e_user.Id_driver = int.Parse(DDL_IdeConductor.SelectedValue);
        e_user.LastModified = DateTime.Now;

        new DAO_Admin().addUser(e_user);

        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('El usuario ha sido registrado');</script>");
    }

    protected void BT_Salir_Click(object sender, EventArgs e)
    {
        Response.Redirect("/View/AdminHome.aspx");
    }
}