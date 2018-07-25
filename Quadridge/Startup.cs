using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Quadridge.Startup))]
namespace Quadridge
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
