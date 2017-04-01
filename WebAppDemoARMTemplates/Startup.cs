using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppDemoARMTemplates.Startup))]
namespace WebAppDemoARMTemplates
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
