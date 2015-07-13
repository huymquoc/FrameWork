using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Framework.Web.Startup))]
namespace Framework.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            ConfigureAuth(app);
        }
    }
}
