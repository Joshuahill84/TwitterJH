using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TwitterJH.App.Startup))]
namespace TwitterJH.App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
