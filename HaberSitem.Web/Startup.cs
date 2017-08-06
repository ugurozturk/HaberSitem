using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HaberSitem.Web.Startup))]
namespace HaberSitem.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
