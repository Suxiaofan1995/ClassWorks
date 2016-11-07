using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_161017.Startup))]
namespace _161017
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
