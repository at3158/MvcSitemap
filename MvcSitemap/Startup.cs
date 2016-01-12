using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcSitemap.Startup))]
namespace MvcSitemap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
