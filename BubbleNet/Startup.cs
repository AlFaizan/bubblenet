using Microsoft.Owin;
using Owin;
//commented
[assembly: OwinStartupAttribute(typeof(BubbleNet.Startup))]
namespace BubbleNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
