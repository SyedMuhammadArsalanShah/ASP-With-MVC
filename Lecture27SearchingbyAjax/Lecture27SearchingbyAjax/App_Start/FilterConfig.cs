﻿using System.Web;
using System.Web.Mvc;

namespace Lecture27SearchingbyAjax
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
