using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lecture09ModelFirst.Startup))]
namespace Lecture09ModelFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
