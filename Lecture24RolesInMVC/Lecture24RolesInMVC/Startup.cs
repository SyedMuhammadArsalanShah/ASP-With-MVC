using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lecture24RolesInMVC.Startup))]
namespace Lecture24RolesInMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
