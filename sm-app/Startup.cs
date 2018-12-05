using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sm_app.Startup))]
namespace sm_app
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
