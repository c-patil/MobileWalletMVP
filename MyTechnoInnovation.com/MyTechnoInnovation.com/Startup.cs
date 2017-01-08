using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyTechnoInnovation.com.Startup))]
namespace MyTechnoInnovation.com
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
