using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Winnie_Learning_Programme.Models
{
    public class Constant
    {
        public static class Category
        {
            public static string Pop = "Popular";
            public static string Mine = "My Course";
            public static string Fav = "Favourite Course";
        }

        public static class UserRole
        {
            public static string Admin = "Admin";

            public static string Student = "Student";
        }
        public  static string defaultMail = WebConfigurationManager.AppSettings["domain_mail"];
    }
}