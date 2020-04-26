using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_LostOrForgotten : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void B_Generar_Click(object sender, EventArgs e)
    {
        E_user e_user = new DAO_Admin().getMailUser(TB_Correo.Text);
        ClientScriptManager cm = this.ClientScript;
        if (e_user == null)
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Correo No Ecnontrado');</script>");
            return;
        }

        e_user.Pass = "";
        e_user.StateId = 2;
        e_user.Token = encrypt(JsonConvert.SerializeObject(e_user));
        e_user.EndToken = DateTime.Now.AddDays(1);
        e_user.Sesion = e_user.Sesion = "Sistema";

        new Send_Mail().sendMail(e_user.Mail, e_user.Token, "", "");
        new DAO_Admin().editUser(e_user);
    }

    private string encrypt(string input)
    {
        SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();

        byte[] inputBytes = Encoding.UTF8.GetBytes(input);
        byte[] hashedBytes = provider.ComputeHash(inputBytes);

        StringBuilder output = new StringBuilder();

        for (int i = 0; i < hashedBytes.Length; i++)
            output.Append(hashedBytes[i].ToString("x2").ToLower());

        return output.ToString();
    }
}