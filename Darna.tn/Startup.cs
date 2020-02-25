using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Darna.tn.Startup))]
namespace Darna.tn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
