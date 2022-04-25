using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lecture11Data_Annotation.Startup))]
namespace Lecture11Data_Annotation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
