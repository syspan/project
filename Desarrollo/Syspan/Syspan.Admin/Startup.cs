using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Syspan.Admin.Startup))]
namespace Syspan.Admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
