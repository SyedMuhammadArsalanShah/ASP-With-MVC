using System.Web;
using System.Web.Mvc;

namespace Lecture12Authentication_and_Authorization
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
