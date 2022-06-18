using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lecture21ExceptionFilter.Startup))]
namespace Lecture21ExceptionFilter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
