using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureWebJobSample.Startup))]
namespace AzureWebJobSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
