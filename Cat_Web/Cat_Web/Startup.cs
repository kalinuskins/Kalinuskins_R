using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cat_Web.Startup))]
namespace Cat_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
