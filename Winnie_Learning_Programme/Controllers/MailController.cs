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
        public JsonResult SendMail(MailModel model)
        {
            if (model != null)
            {
                if (MailService.SendMail(model))
                {
                    return Json(true, JsonRequestBehavior.AllowGet);
                }
            }

            return Json(false, JsonRequestBehavior.AllowGet);
        }
    }
}