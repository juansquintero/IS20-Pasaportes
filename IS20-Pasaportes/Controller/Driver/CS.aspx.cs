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
        //Aplicar un path virtual no fisico
        string[] data = BarcodeReader.read("C:/Users/Sebastian Quintero/source/repos/IS20-Pasaportes/IS20-Pasaportes/Captures/qr_code.png", BarcodeReader.QRCODE);
        string result = String.Concat(data);

        if (result == null || result == "") 
        {
            LB_QRCode.Text = "No existe o el codigo no funciona";
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('El usuario no existe o el codigo no funciona');</script>");
            return;
        }
        else
        {
            LB_QRCode.Text = result;
        }
        //Mirar se se puede con un path virtual no fisico
        File.Delete(@"C:\Users\Sebastian Quintero\source\repos\IS20-Pasaportes\IS20-Pasaportes\Captures\qr_code.png");
    }
}