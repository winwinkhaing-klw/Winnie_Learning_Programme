using System.Web;
using System.Web.Mvc;

namespace Winnie_Learning_Programme
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
