using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lecture16CustomHelpers.CustomCodeHelpers
{
    public static class CodeStaticHelpers
    {
        public static IHtmlString  LabelCustom(string laiba)
        {
            string value = string.Format("{0}",laiba );


            return new HtmlString(value);
        } 



    }
}