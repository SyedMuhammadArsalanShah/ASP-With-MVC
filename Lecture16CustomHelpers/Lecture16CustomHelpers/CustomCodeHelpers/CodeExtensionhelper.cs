using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture16CustomHelpers.CustomCodeHelpers
{
    public static class CodeExtensionhelper
    {
        public static IHtmlString LabelCustomext(this HtmlHelper helper ,string laiba)
        {
            string value = string.Format("{0}", laiba);


            return new HtmlString(value);
        }




    }
}