using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrabajoEnClase.Startup))]
namespace TrabajoEnClase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
