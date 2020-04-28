using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

/// <summary>
/// Summary description for Send_Mail
/// </summary>
public class Send_Mail
{
    public Send_Mail()
    {

    }

    public void sendMail(String destMail, String userToken, String pass, String user, String extra)
    {
        try
        {
            var EmailTemplate = new System.IO.StreamReader(AppDomain.CurrentDomain.BaseDirectory.Insert(AppDomain.CurrentDomain.BaseDirectory.Length, "App_Code/Template/mailer2.html"));
            var strBody = string.Format(EmailTemplate.ReadToEnd(), userToken);
            EmailTemplate.Close(); EmailTemplate.Dispose(); EmailTemplate = null;

            strBody = strBody.Replace("#TOKEN#", "Su usuario es: " + user + " Su contraseña es: " + pass + userToken + extra);
            MailMessage mailM = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mailM.From = new MailAddress("SABT_registro@sabt.com", "SABT");
            SmtpServer.Host = "smtp.gmail.com";
            mailM.Subject = "Bienvenido";
            mailM.Body = strBody;
            mailM.To.Add(destMail);
            mailM.IsBodyHtml = true;
            mailM.Priority = MailPriority.Normal;
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("is20pasaportes@gmail.com", "tueomzhsfsvorbfq");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mailM);
        }
        catch (Exception)
        {

            throw;
        }
    }
}