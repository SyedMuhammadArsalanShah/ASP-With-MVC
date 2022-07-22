using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lecture25Ajax.Startup))]
namespace Lecture25Ajax
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
