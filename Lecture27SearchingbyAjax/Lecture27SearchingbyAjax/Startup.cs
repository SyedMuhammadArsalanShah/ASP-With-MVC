using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lecture27SearchingbyAjax.Startup))]
namespace Lecture27SearchingbyAjax
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
