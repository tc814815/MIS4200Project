using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MIS4200Project.Startup))]
namespace MIS4200Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
