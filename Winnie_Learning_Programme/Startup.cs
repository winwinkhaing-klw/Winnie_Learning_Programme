using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Winnie_Learning_Programme.Startup))]
namespace Winnie_Learning_Programme
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
