using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lecture08DatabaseFirst.Startup))]
namespace Lecture08DatabaseFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
