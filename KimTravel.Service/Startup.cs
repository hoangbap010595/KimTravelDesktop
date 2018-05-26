using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KimTravel.Service.Startup))]
namespace KimTravel.Service
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
