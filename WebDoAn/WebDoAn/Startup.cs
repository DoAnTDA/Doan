using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebDoAn.Startup))]
namespace WebDoAn
{
    public partial class Startup
    {
        //sd
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
