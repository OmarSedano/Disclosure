using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Disclosure.Startup))]
namespace Disclosure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }

}