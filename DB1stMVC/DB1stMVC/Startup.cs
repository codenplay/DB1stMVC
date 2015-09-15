using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DB1stMVC.Startup))]
namespace DB1stMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
