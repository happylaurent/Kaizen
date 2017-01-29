using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kaizen.Startup))]
namespace Kaizen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
