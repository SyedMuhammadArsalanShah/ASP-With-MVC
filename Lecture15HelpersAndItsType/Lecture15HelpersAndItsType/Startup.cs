using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lecture15HelpersAndItsType.Startup))]
namespace Lecture15HelpersAndItsType
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
