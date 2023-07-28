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
                if (MailService.SendMail(model))
                {
                    return Json(new { success = true, message = "We sent your message to our service team."});
                }
            }

            return Json(new { success = false, message = "Failed to send your message." });
        }
    }
}