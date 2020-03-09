using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TutionClassManagement.Startup))]
namespace TutionClassManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
