using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eimdbapi.Startup))]
namespace eimdbapi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
