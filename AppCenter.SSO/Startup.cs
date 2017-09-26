using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ShareCenter.SSO.Startup))]
namespace ShareCenter.SSO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
