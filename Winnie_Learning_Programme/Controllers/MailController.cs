using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Winnie_Learning_Programme.Models;
using Winnie_Learning_Programme.Services;

namespace Winnie_Learning_Programme.Controllers
{
    public class MailController : Controller
    {
        private UserService userService;
        private MailService mailService;
        public MailController()
        {
            userService = new UserService(new WKDbEntities());
            mailService = new MailService(new WKDbEntities());
        }
        // GET: Mail
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult SendMail(MailModel model)
        {
            if (model != null && !string.IsNullOrEmpty(model.From))
            {
                User user = userService.GetUserByUserRole(Constant.UserRole.Admin);
                if(user != null && !string.IsNullOrEmpty(user.Email))
                {
                    model.To = user.Email;
                }
                Mail mail = new Mail();
                if (model != null)
                {
                    mail.SenderMail = model.From;
                    mail.Body = model.Body;
                    mail.Subject = model.Subject;
                    mail.ReceiverMail = model.To;
                    mail.TemplateName = "Contact Mail";
                }

                if (mailService.SendMail(mail))
                {
                    return Json(new { success = true, message = "We sent your message to our service team."});
                }
            }

            return Json(new { success = false, message = "Failed to send your message." });
        }
    }
}