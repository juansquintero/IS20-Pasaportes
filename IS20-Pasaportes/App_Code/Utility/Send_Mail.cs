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

    public void sendMail(String destMail, String userToken, String mail)
    {
        try
        {
            var EmailTemplate = new System.IO.StreamReader(AppDomain.CurrentDomain.BaseDirectory.Insert(AppDomain.CurrentDomain.BaseDirectory.Length, "Template\\mailer.html"));
            var strBody = string.Format(EmailTemplate.ReadToEnd(), userToken);
            EmailTemplate.Close(); EmailTemplate.Dispose(); EmailTemplate = null;

            strBody = strBody.Replace("#TOKEN#", "A continuacion se le enviara su usuario y contraseña");
            MailMessage mailM = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mailM.From = new MailAddress("prueba@mail.com", "prueba");
            SmtpServer.Host = "smtp.gmail.com";
            mailM.Subject = "Registro usuario";
            mailM.Body = strBody;
            mailM.To.Add(destMail);
            mailM.IsBodyHtml = true;
            mailM.Priority = MailPriority.Normal;
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("prueba@mail.com", "passPrueba");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mailM);
        }
        catch (Exception)
        {

            throw;
        }
    }
}