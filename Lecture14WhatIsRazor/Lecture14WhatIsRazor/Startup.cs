using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lecture14WhatIsRazor.Startup))]
namespace Lecture14WhatIsRazor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
