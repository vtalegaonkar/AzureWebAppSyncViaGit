using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureWebAppSyncViaGit.Startup))]
namespace AzureWebAppSyncViaGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
