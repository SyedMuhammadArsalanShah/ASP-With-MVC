using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lecture12Authentication_and_Authorization.Startup))]
namespace Lecture12Authentication_and_Authorization
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
