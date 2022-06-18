using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lecture20ActionFilter.Startup))]
namespace Lecture20ActionFilter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
