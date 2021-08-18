using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_5StarWifi.Startup))]
namespace _5StarWifi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
