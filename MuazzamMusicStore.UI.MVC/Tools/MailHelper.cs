using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace MuazzamMusicStore.UI.MVC.Tools
{
    public class MailHelper
    {
        //mail gönderme kodları

        public static bool SendConfirmationMail(string username,string password,string mail,int id)
        {
            bool result = false;
            MailMessage msg = new MailMessage();
            msg.To.Add(mail);
            msg.Subject = "Hoşgeldiniz...";
            msg.IsBodyHtml = true;
            //mesaj içeriği için html template kullanılabiki1Araştır
            msg.Body = "<b>deneme<b>";
            msg.From = new MailAddress("sinifmuazzam@gmail.com");
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com",587);
            smtpClient.EnableSsl = true;
            NetworkCredential credential = new NetworkCredential("sinifmuazzam@gmail.com", "123456**sinif");
            smtpClient.Credentials = credential;
            try
            {
                smtpClient.Send(msg);
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }
    }
}