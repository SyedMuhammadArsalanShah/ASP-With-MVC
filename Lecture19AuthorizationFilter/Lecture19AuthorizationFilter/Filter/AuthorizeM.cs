using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture19AuthorizationFilter.Filter
{
    public class AuthorizeM : AuthorizeAttribute 
    {
        private bool localAllowed;
        public AuthorizeM(bool allowedParam)
        {
            localAllowed = allowedParam;
        }
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.Request.IsLocal)
            {
                return localAllowed;
            }
            else
            {
                return true;
            }
        }





    }
}