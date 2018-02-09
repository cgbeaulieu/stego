using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Stego.Startup))]
namespace Stego
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
