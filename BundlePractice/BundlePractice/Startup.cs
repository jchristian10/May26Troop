using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BundlePractice.Startup))]
namespace BundlePractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
