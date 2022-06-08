using System.Web;
using System.Web.Mvc;

namespace Lecture17HttpVerbs
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
