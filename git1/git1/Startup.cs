using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(git1.Startup))]
namespace git1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
