using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Taller02.Startup))]
namespace Taller02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
