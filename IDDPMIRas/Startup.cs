using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IDDPMIRas.Startup))]
namespace IDDPMIRas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
