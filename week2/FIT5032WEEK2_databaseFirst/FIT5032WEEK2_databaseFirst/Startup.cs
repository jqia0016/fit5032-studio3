using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FIT5032WEEK2_databaseFirst.Startup))]
namespace FIT5032WEEK2_databaseFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
