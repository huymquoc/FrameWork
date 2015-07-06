using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Framework.Web.Startup))]
namespace Framework.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
