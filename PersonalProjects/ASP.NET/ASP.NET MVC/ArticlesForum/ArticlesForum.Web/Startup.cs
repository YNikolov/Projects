using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArticlesForum.Web.Startup))]
namespace ArticlesForum.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
