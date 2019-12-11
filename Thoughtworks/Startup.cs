using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Thoughtworks.Startup))]
namespace Thoughtworks
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
