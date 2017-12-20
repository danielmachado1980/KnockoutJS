using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_.Startup))]
namespace MVC_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
