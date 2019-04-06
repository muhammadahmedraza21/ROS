using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ROS_QRCodeNew.Startup))]
namespace ROS_QRCodeNew
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
