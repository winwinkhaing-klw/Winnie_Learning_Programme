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

        public static string GenerateRandomOTP(int length, string[] chars)
        {

            string otp = String.Empty;

            string tempChar = String.Empty;

            Random rand = new Random();

            for (int i = 0; i < length; i++)

            {
                int p = rand.Next(0, chars.Length);

                tempChar = chars[rand.Next(0, chars.Length)];

                otp += tempChar;

            }

            return otp;

        }
    }
}