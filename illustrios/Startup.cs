using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(illustrios.Startup))]
namespace illustrios
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
