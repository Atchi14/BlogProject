using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webproj.Startup))]
namespace webproj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
