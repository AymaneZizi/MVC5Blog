using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5Blog.Startup))]
namespace MVC5Blog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
