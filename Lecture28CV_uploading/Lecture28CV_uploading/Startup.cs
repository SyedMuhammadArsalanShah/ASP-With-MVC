using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lecture28CV_uploading.Startup))]
namespace Lecture28CV_uploading
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
