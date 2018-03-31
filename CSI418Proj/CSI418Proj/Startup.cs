using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSI418Proj.Startup))]
namespace CSI418Proj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
