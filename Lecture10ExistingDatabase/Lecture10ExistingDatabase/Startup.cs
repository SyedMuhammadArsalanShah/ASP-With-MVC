using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lecture10ExistingDatabase.Startup))]
namespace Lecture10ExistingDatabase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
