using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.Services;
using BarcodeLib.BarcodeReader;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            if (Request.InputStream.Length > 0)
            {
                using (StreamReader reader = new StreamReader(Request.InputStream))
                {
                    string hexString = Server.UrlEncode(reader.ReadToEnd());
                    string imageName = "qr_code";//DateTime.Now.ToString("dd-MM-yy hh-mm-ss");
                    string imagePath = string.Format("~/Captures/{0}.png", imageName);
                    //string imagePath = string.Format("E:/{0}.png", imageName);
                    File.WriteAllBytes(Server.MapPath(imagePath), ConvertHexToBytes(hexString));
                    Session["CapturedImage"] = ResolveUrl(imagePath);
                }
            }
        }
    }

    private static byte[] ConvertHexToBytes(string hex)
    {
        byte[] bytes = new byte[hex.Length / 2];
        for (int i = 0; i < hex.Length; i += 2)
        {
            bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
        }
        return bytes;
    }

    [WebMethod(EnableSession = true)]

    public static string GetCapturedImage()
    {
        string url = HttpContext.Current.Session["CapturedImage"].ToString();
        HttpContext.Current.Session["CapturedImage"] = null;
        return url;
    }

    protected void BT_Escanear_Click(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        string[] data = BarcodeReader.read(AppDomain.CurrentDomain.BaseDirectory.Insert(AppDomain.CurrentDomain.BaseDirectory.Length, "Captures/qr_code.png"), BarcodeReader.QRCODE);
        string result = String.Concat(data);
        E_user e_User = new DAO_Admin().getQrUser(result);
        if (result == null || result == "") 
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('El usuario no existe o el codigo no funciona');</script>");
            return;
        }
        else if (e_User == null)
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('El usuario no existe');</script>");
            return;
        }
        else
        {            
            LB_Name.Text = e_User.Name;
            LB_LastName.Text = e_User.Last_name;
            LB_Code.Text = result;
            LB_Bonos.Text = e_User.Pasaporte_numero.ToString();
            e_User.Pasaporte_numero = e_User.Pasaporte_numero - 1;
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('El pasaporte se ha cobrado');</script>");
            new DAO_Admin().editUser(e_User);
        }
        File.Delete(AppDomain.CurrentDomain.BaseDirectory.Insert(AppDomain.CurrentDomain.BaseDirectory.Length, "Captures/qr_code.png"));
    }

    protected void BT_Salir_Click(object sender, EventArgs e)
    {
        Response.Redirect("/View/DriverHome.aspx");
    }
}