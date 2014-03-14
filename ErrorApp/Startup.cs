using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ErrorApp.Startup))]
namespace ErrorApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
