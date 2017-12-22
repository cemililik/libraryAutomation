using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Library_Automation.Startup))]
namespace Library_Automation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
