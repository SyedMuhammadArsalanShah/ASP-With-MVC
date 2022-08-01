using System.Web;
using System.Web.Mvc;

namespace Lecture28CV_uploading
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
