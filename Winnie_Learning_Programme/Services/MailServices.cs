using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using Winnie_Learning_Programme.Models;

namespace Winnie_Learning_Programme.Services
{
    public class MailService
    {
        public static bool SendMail(MailModel model)
        {
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            MailMessage mail = new MailMessage();
            model.To = "wwk773@gmail.com";
            mail.To.Add(model.To);
            mail.From = new MailAddress(model.From);
            mail.Subject = model.Subject;
            mail.Body = model.Body;
            mail.IsBodyHtml = true;
            SmtpClient smtpClient = new SmtpClient("localhost", 25);
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            smtpClient.Send(mail);
            //SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            //smtpClient.EnableSsl = true;
            //smtpClient.Credentials = new NetworkCredential("wwk773@gmail.com", "@Wwkwwk18");
            //smtpClient.Send(mail);
            return true;
        }
    }
}