using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SummitAngularJS.Startup))]
namespace SummitAngularJS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
