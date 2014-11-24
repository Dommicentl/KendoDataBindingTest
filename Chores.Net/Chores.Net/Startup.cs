using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Chores.Net.Startup))]
namespace Chores.Net
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
