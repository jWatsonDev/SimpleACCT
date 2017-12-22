using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleACCT.Startup))]
namespace SimpleACCT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
