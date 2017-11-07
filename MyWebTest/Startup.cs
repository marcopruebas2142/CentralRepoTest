using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyWebTest.Startup))]
namespace MyWebTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
