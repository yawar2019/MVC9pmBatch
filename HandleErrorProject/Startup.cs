using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HandleErrorProject.Startup))]
namespace HandleErrorProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
