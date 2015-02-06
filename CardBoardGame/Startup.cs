using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CardBoardGame.Startup))]
namespace CardBoardGame
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
