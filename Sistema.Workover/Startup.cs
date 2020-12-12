using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sistema.Workover.Startup))]
namespace Sistema.Workover
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
