using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HushHush.Startup))]
namespace HushHush
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
