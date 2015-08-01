using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ManyToManyPractice.Startup))]
namespace ManyToManyPractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
