using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuditSales.Startup))]
namespace AuditSales
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
