using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HealthyU.Startup))]
namespace HealthyU
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
