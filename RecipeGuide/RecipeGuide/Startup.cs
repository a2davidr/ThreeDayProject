using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RecipeGuide.Startup))]
namespace RecipeGuide
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
