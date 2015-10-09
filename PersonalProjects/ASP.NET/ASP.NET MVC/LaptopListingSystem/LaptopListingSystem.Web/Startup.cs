using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LaptopListingSystem.Web.Startup))]
namespace LaptopListingSystem.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
