using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SSOPOC5.Startup))]
namespace SSOPOC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
