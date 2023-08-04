using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Winnie_Learning_Programme.Services
{
    public static class AuthenticationHelper
    {
        public static bool IsAuthenticated()
        {
            return HttpContext.Current.Session["Username"]!= null ? true : false;
        }
    }
}