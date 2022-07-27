using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lecture26CreatebyAjax.Startup))]
namespace Lecture26CreatebyAjax
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
