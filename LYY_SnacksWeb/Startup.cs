using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LYY_SnacksWeb.Startup))]
namespace LYY_SnacksWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
