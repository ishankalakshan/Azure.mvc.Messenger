using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Azure.mvc.Messenger.Startup))]
namespace Azure.mvc.Messenger
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
