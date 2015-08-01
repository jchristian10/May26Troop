using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Day12Auth.Startup))]
namespace Day12Auth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
