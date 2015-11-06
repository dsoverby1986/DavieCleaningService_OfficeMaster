using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DavieCleaningService_OfficeMaster.Startup))]
namespace DavieCleaningService_OfficeMaster
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
