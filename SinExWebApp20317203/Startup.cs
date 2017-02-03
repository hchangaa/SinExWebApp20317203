using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SinExWebApp20317203.Startup))]
namespace SinExWebApp20317203
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
