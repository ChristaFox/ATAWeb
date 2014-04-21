using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebATA.Startup))]
namespace WebATA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
