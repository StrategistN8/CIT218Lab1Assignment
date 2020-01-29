using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CIT218Lab1Assignment.Startup))]
namespace CIT218Lab1Assignment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
