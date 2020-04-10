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
        //E_user e_user = new E_user();
        //LB_QR.Text = e_user.Qr_hash;
        //E_user q_user = new DAO_Login().QR(e_user);
        //string code = e_user.Qr_hash;

        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode("Hola como estas", QRCodeGenerator.ECCLevel.Q);
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
    }
}