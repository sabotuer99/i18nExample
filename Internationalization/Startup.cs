using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Internationalization.Startup))]
namespace Internationalization
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
