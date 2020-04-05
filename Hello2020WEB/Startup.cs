using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hello2020WEB.Startup))]
namespace Hello2020WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
