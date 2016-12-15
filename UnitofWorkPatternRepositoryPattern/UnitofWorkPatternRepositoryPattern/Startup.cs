using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UnitofWorkPatternRepositoryPattern.Startup))]
namespace UnitofWorkPatternRepositoryPattern
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
