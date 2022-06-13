using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lecture19AuthorizationFilter.Startup))]
namespace Lecture19AuthorizationFilter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
