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
        private Winnie_Learning_Programme.WKDbEntities _context;
        public MailService(WKDbEntities context)
        {
            _context = context;
        }
        public bool SendMail(Mail model)
        {
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            MailMessage mail = new MailMessage();
            mail.To.Add(model.ReceiverMail);
            mail.From = new MailAddress(model.SenderMail);
            mail.Subject = model.Subject;
            mail.Body = model.Body;
            mail.IsBodyHtml = true;
            SmtpClient smtpClient = new SmtpClient("localhost", 25);
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            smtpClient.Send(mail);
            _context.Mails.Add(model);
            _context.SaveChanges();
            //SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            //smtpClient.EnableSsl = true;
            //smtpClient.Credentials = new NetworkCredential("wwk773@gmail.com", "@Wwkwwk18");
            //smtpClient.Send(mail);
            return true;
        }
    }
}