using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoachUs.Site.Startup))]
namespace CoachUs.Site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
