using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lecture13BootstrapTheme.Startup))]
namespace Lecture13BootstrapTheme
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
