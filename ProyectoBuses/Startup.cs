using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoBuses.Startup))]
namespace ProyectoBuses
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
