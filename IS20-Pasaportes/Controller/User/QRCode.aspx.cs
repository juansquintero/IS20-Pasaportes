using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QRCoder;
using System.IO;
using System.Drawing;

public partial class View_User_QRCode : System.Web.UI.Page
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



        var Qr = ((E_user)Session["validUser"]).Qr_hash;
        
        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(Qr, QRCodeGenerator.ECCLevel.Q);
        QRCode qrCode = new QRCode(qrCodeData);
        System.Web.UI.WebControls.Image imgBarCode = new System.Web.UI.WebControls.Image();
        imgBarCode.Height = 150;
        imgBarCode.Width = 150;
        using (Bitmap bitMap = qrCode.GetGraphic(20))
        {
            using (MemoryStream ms = new MemoryStream())
            {
                bitMap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] byteImage = ms.ToArray();
                imgBarCode.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(byteImage);
            }
            QR_PlaceHolder.Controls.Add(imgBarCode);
        }
        LB_QR.Text = Qr;
        LB_Usuario.Text = ((E_user)Session["validUser"]).Name;
        LB_UserApellido.Text = ((E_user)Session["validUser"]).Last_name;

    }

    protected void BT_Session_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/View/AdminHome.aspx");
    }
}