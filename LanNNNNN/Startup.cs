using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LanNNNNN.Startup))]
namespace LanNNNNN
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
