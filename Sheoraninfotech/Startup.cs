using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sheoraninfotech.Startup))]
namespace Sheoraninfotech
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
